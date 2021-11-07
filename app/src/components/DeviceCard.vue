<template>
  <v-container class="elevation-4 rounded-lg" v-ripple>
    <v-row dense>
      <v-col cols="12" class="d-flex align-center justify-center">
        <v-icon x-large style="font-size: 72px">
          {{ icon }}
        </v-icon>
      </v-col>

      <v-col cols="12" class="title font-weight-bold text-center">
        {{ name }}
      </v-col>
      <v-col cols="12" class="subtitle-1 text-center">
        {{ location }}
      </v-col>
    </v-row>
  </v-container>
</template>

<script>
import deviceIconByType from '../mixins/deviceIconByType';

export default {
  name: 'DeviceCard',
  mixins: [
    deviceIconByType,
  ],
  props: {
    id: {
      type: Number,
      required: true,
    },
    name: {
      type: String,
      required: true,
    },
    type: {
      type: String,
      required: true,
    },
    location: {
      type: String,
      required: true,
    },
    connected: {
      type: Boolean,
      required: true,
    },
  },
  computed: {
    icon() {
      const { type } = this;
      return this.deviceIconByType(type);
    },
  },
};
</script>

<style lang="scss" scoped>
.container {
  background: #e7e7e7;
}
</style>
