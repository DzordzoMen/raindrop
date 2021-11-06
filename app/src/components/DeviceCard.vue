<template>
  <v-container class="elevation-4 rounded-lg" v-ripple>
    <v-row >
      <v-col cols="2" class="d-flex align-start justify-center">
        <v-icon x-large style="font-size: 48px">
          {{ icon }}
        </v-icon>
      </v-col>
      <v-col cols="10">
        <v-row dense>
          <v-col cols="10" class="title font-weight-bold">
            {{ name }}
          </v-col>
          <v-col cols="2" class="d-flex justify-end align-start">
            <v-icon :color="connected ? 'success darken-1' : 'error'">
              mdi-record
            </v-icon>
          </v-col>
          <v-col cols="7" class="subtitle-1 d-flex align-end">
            {{ location }}
          </v-col>
          <v-col cols="5">
            <v-btn
              depressed
              outlined
              class="px-2"
              color="primary"
              height="30"
            >
              Zarządzaj
            </v-btn>
          </v-col>
        </v-row>
      </v-col>
    </v-row>
  </v-container>
</template>

<script>
export default {
  name: 'DeviceCard',
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
      let icon = 'mdi-washing-machine';
      switch (type) {
        case 'washing-machine':
          icon = 'mdi-washing-machine';
          break;
        case 'sprinkler':
          icon = 'mdi-sprinkler-variant';
          break;
        case 'dishwasher':
          icon = 'mdi-dishwasher';
          break;
        default:
          break;
      }
      return icon;
    },
  },
};
</script>
