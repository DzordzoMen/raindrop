<template>
  <v-container>
    <v-row>
      <v-col cols="12">
        <weather-card
          name="Burza"
          :temp="12"
          icon="10d"
          :rainH="15"
        />
      </v-col>
      <v-col
        cols="12"
        class="d-flex align-center justify-center"
        style="height: 450px"
      >
        <the-circle :percent="tankFillPercentage">
          <v-row dense class="flex-column text-center headline font-weight-bold">
            <v-col cols="12">
              {{ tank.current.toFixed(0) }}
            </v-col>
            <v-col>
              <v-divider />
            </v-col>
            <v-col cols="12">
              {{ tank.capacity.toFixed(0) }}
            </v-col>
          </v-row>
        </the-circle>
      </v-col>
      <v-col cols="12" class="text-center title">
        Ogólna ilość zebranej wody przez Ciebie: <b>{{ collectedWater }}</b> ml
      </v-col>
    </v-row>
  </v-container>
</template>

<script>
import WeatherCard from '../components/WeatherCard.vue';
import TheCircle from '../components/TheCircle.vue';

export default {
  name: 'Rainwater',
  components: {
    TheCircle,
    WeatherCard,
  },
  data: () => ({
    collectedWater: 20000,
    tank: {
      current: 2000.17,
      capacity: 10000,
    },
  }),
  computed: {
    tankFillPercentage() {
      const { current, capacity } = this.tank;
      return (current / capacity) * 100;
    },
  },
};
</script>

<style lang="scss" scoped>

</style>
