<template>
  <v-container class="elevation-4 rounded-lg py-1" v-ripple>
    <v-row>
      <v-col cols="4">
        <v-img
          :src="`http://openweathermap.org/img/wn/${icon}@2x.png`"
          alt="weather icon"
          style="-webkit-filter: drop-shadow(12px 12px 25px rgba(0,0,0,0.5));"
          contain
        />
      </v-col>
      <v-col cols="8">
        <v-row dense class="fill-height text-right">
          <v-col cols="12" v-if="date">
            {{ date }}
          </v-col>
          <v-col cols="12" align-self="end" class="d-flex justify-end title">
            {{ name }} {{ temp.toFixed(0) }}°C
          </v-col>
          <v-col cols="12" align-self="end" class="d-flex justify-end subtitle-2" v-if="rainH">
            Opad na godzinę {{ rainH }}mm
          </v-col>
          <v-col cols="12" align-self="end" class="d-flex justify-end subtitle-2">
            Brak opadów
          </v-col>
        </v-row>
      </v-col>
    </v-row>
  </v-container>
</template>

<script>
export default {
  name: 'WeatherCard',
  props: {
    name: {
      type: String,
      required: true,
    },
    date: {
      type: String,
      required: false,
      default: null,
    },
    temp: {
      type: Number,
      required: true,
    },
    rainH: {
      type: Number,
      required: true,
    },
    icon: {
      type: String,
      required: true,
    },
  },
};
</script>

<style lang="scss" scoped>
.container {
  background: #e7e7e7;
}
</style>
