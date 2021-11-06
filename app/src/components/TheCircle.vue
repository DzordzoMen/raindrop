<template>
  <div class="circle__wrapper">
    <div class="circle--outer">
      <div class="circle--inner">
        <div class="circle--text">
          <slot>
            {{ percent }}%
          </slot>
        </div>
      </div>
    </div>
    <svg
      xmlns="http://www.w3.org/2000/svg"
      version="1.1"
      width="320px"
      height="320px"
      :style="`--percent: ${circlePercent}`"
    >
      <defs>
        <linearGradient id="GradientColor">
          <stop offset="0%" stop-color="#e91e63" />
          <stop offset="100%" stop-color="#673ab7" />
        </linearGradient>
      </defs>
      <circle cx="160" cy="160" r="150" stroke-linecap="round" />
    </svg>
  </div>
</template>

<script>
export default {
  name: 'TheCircle',
  props: {
    percent: {
      type: Number,
      required: true,
    },
    size: {
      type: [Number, String],
      required: false,
      default: 160,
    },
  },
  computed: {
    circlePercent() {
      const { percent } = this;
      return 944 - 944 * (parseFloat(percent) / 100);
    },
  },
};
</script>

<style lang="scss">
.circle__wrapper {
  width: 320px;
  height: 320px;
  position: relative;

  .circle {
    &--outer {
      width: 320px;
      height: 320px;
      border-radius: 50%;
      padding: 20px;
      box-shadow: 6px 6px 10px -1px rgba(0, 0, 0, .15),
        -6px -6px 10px -1px rgba(255, 255, 255, .7);
    }

    &--inner {
      width: 280px;
      height: 280px;
      border-radius: 50%;
      display: flex;
      align-items: center;
      justify-content: center;
      box-shadow: inset 4px 4px 6px -1px rgba(0, 0, 0, .2),
        inset -4px -4px 6px -1px rgba(255, 255, 255, .7),
        -0.5px -0.5px 0px rgba(255, 255, 255, 1),
        0.5px 0.5px 0px rgba(0, 0, 0, .15),
        0px 12px 10px -10px rgba(0, 0, 0, .05);
    }

    &--text {
      font-weight: 600;
      color: #555;
    }
  }

  svg {
    --percent: 0;
    position: absolute;
    top: 0;
    left: 0;

    circle {
      fill: none;
      stroke: url(#GradientColor);
      stroke-width: 20px;
      stroke-dasharray: 944;
      stroke-dashoffset: 944;
      animation: circle-animation 1s linear forwards;
      transform-origin: center;
      transform-box: fill-box;
      transform: rotate(90deg);
    }
  }
}

@keyframes circle-animation {
  100% {
    stroke-dashoffset: var(--percent);
  }
}
</style>
