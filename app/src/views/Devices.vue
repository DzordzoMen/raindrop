<template>
  <v-container class="container-on-header">
    <v-row dense>
      <v-col
        cols="6"
        v-for="(device, index) in devices"
        :key="device.id"
        :style="index < 2 && 'z-index: 6'"
        @click="showDeviceDialog(device)"
      >
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

    <the-device-dialog
      v-model="deviceDialog"
      :selectedDevice="selectedDevice"
    />
  </v-container>
</template>

<script>
import DeviceCard from '../components/DeviceCard.vue';
import TheDeviceDialog from '../components/TheDeviceDialog.vue';

export default {
  name: 'Devices',
  components: {
    DeviceCard,
    TheDeviceDialog,
  },
  data: () => ({
    deviceDialog: false,
    selectedDevice: null,
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
        name: 'Zraszacz 2',
        type: 'sprinkler',
        location: 'Ogródek 2',
        connected: false,
      },
      {
        id: 5,
        name: 'Panele',
        type: 'solar-panel',
        location: 'Dach',
        connected: true,
      },
    ],
  }),
  methods: {
    showDeviceDialog(device) {
      this.selectedDevice = device;
      this.deviceDialog = true;
    },
  },
};
</script>

<style lang="scss" scoped>
.container-on-header {
  margin-top: -64px;
}
</style>
