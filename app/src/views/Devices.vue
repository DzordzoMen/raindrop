<template>
  <v-container>
    <v-row dense>
      <v-col cols="12" v-for="device in devices" :key="device.id">
        <device-card v-bind="device" />
      </v-col>
    </v-row>

    <v-btn
      fab
      bottom
      right
      fixed
      style="bottom: 64px"
      color="primary"
    >
      <v-icon>
        mdi-plus
      </v-icon>
    </v-btn>
  </v-container>
</template>

<script>
import DeviceCard from '../components/DeviceCard.vue';

export default {
  name: 'Devices',
  components: {
    DeviceCard,
  },
  data: () => ({
    devices: [
      {
        id: 1,
        name: 'Pralka',
        type: 'washing-machine',
        location: 'Łazienka',
        connected: true,
      },
      {
        id: 2,
        name: 'Zmywarka',
        type: 'dishwasher',
        location: 'Kuchnia',
        connected: true,
      },
      {
        id: 3,
        name: 'Zraszacz',
        type: 'sprinkler',
        location: 'Ogródek 1',
        connected: true,
      },
      {
        id: 4,
        name: 'Zraszacz',
        type: 'sprinkler',
        location: 'Ogródek 2',
        connected: false,
      },
    ],
  }),
};
</script>

<style lang="scss" scoped>

</style>
