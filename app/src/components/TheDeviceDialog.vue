<template>
  <v-dialog
    v-model="show"
    fullscreen
    persistent
  >
    <v-card v-if="selectedDevice" class="fill-height">
      <v-card-text style="height: calc(100% - 52px)" class="pa-4 body-1 font-weight-regular">
        <v-row dense>
          <v-col cols="4">
            <v-icon style="font-size: 92px">
              {{ deviceIconByType(selectedType) }}
            </v-icon>
          </v-col>
          <v-col cols="8">
            <v-row dense justify="end" style="gap: 0 8px">
              <v-col cols="2">
                <v-icon large @click="edit = !edit">
                  mdi-pencil
                </v-icon>
              </v-col>
              <v-col cols="2">
                <v-icon large>
                  mdi-cog
                </v-icon>
              </v-col>
              <v-col cols="2">
                <v-icon
                  large
                  :color="selectedDevice.connected ? 'success darken-1' : 'error darken-1'"
                >
                  mdi-record
                </v-icon>
              </v-col>
              <v-col cols="12">
                <v-select
                  v-model="selectedType"
                  :items="deviceTypes"
                  :disabled="!edit"
                  color="black"
                  dense
                  hide-selected
                  :menu-props="{
                    bottom: true,
                    offsetY: true,
                    left: true,
                    tile: true,
                  }"
                  flat
                  outlined
                  solo
                  hide-details
                />
              </v-col>
            </v-row>
          </v-col>

          <template v-if="['washing-machine', 'sprinkler', 'dishwasher'].includes(selectedType)">
            <v-col cols="12" class="pt-12 d-flex justify-end">
              {{ active ? 'Aktywne' : 'Wyłączone'}}
              <v-switch
                v-model="active"
                inset
                color="primary"
                hide-details
                dense
                class="pa-0 pl-3 ma-0"
              />
            </v-col>
            <v-col cols="12" class="pt-4 d-flex align-end">
              Włącz zawsze o godzinie
              <v-menu
                ref="menu"
                v-model="menu2"
                :close-on-content-click="false"
                :nudge-right="40"
                :return-value.sync="time"
                transition="scale-transition"
                offset-y
                max-width="290px"
                min-width="290px"
              >
                <template v-slot:activator="{ on, attrs }">
                  <v-text-field
                    v-model="time"
                    label="20:00"
                    readonly
                    hide-details
                    class="ml-auto"
                    dense
                    outlined
                    solo
                    flat
                    v-bind="attrs"
                    style="max-width: 100px"
                    v-on="on"
                  />
                </template>
                <v-time-picker
                  v-if="menu2"
                  v-model="time"
                  full-width
                  format="24hr"
                  @click:minute="$refs.menu.save(time)"
                />
              </v-menu>
            </v-col>
            <v-col cols="12" class="d-flex pt-4">
              Nie uruchamiaj gdy pogoda zapowiada się na deszczową
              <v-switch
                inset
                color="primary"
                hide-details
                dense
                class="pa-0 pl-3 ma-0"
              />
            </v-col>
            <v-col cols="12" class="pt-12 body-2">
              <v-icon class="pr-2">
                mdi-information
              </v-icon>
              Twoje zmiany zostaną zapisane, jeżeli chcesz uruchomić urządzenie w tym momencie
              kliknij przycisk uruchom
            </v-col>
          </template>
        </v-row>
      </v-card-text>
      <v-card-actions>
        <v-btn
          style="width: 50%"
          color="primary"
          outlined
          @click="show = false"
        >
          Zamknij
        </v-btn>
        <v-btn
          color="primary"
          style="width: 50%"
          @click="show = false"
        >
          Uruchom
        </v-btn>
      </v-card-actions>
    </v-card>
  </v-dialog>
</template>

<script>
import deviceIconByType from '../mixins/deviceIconByType';

export default {
  name: 'TheDeviceDialog',
  mixins: [
    deviceIconByType,
  ],
  props: {
    value: {
      type: Boolean,
      required: true,
      default: false,
    },
    selectedDevice: {
      type: Object,
      required: false,
      default: null,
    },
  },
  data: () => ({
    selectedType: null,
    time: null,
    active: false,
    menu2: false,
    edit: false,
    deviceTypes: [
      {
        text: 'Pralka',
        value: 'washing-machine',
      },
      {
        text: 'Zraszacz',
        value: 'sprinkler',
      },
      {
        text: 'Zmywarka',
        value: 'dishwasher',
      },
      {
        text: 'Panele słoneczne',
        value: 'solar-panel',
      },
    ],
  }),
  computed: {
    show: {
      get() {
        return this.value;
      },
      set(val) {
        this.$emit('input', val);
      },
    },
  },
  watch: {
    // eslint-disable-next-line
    show: function (val) {
      if (val) {
        this.selectedType = this.selectedDevice.type;
      } else {
        Object.assign(this.$data, this.$options.data());
      }
    },
  },
};
</script>

<style lang="scss">
.v-dialog{
  height: calc(100% - 60px) !important;
  bottom: 0 !important;
  top: 60px !important
}
</style>
