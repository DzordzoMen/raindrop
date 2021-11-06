<template>
  <v-container>
    <v-row dense>
      <v-col cols="12" v-for="weather in weathers" :key="weather.id">
        <weather-card
          v-bind="weather"
        />
      </v-col>
    </v-row>
  </v-container>
</template>

<script>
import WeatherCard from '../components/WeatherCard.vue';

export default {
  name: 'Weather',
  components: {
    WeatherCard,
  },
  data: () => ({
    weathers: [
      {
        id: 1,
        name: 'Burza',
        temp: 10,
        icon: '11d',
        rainH: 15,
      },
      {
        id: 2,
        name: 'Słoneczko',
        temp: 20,
        icon: '01d',
        rainH: 0,
      },
      {
        id: 3,
        name: 'Mgła',
        temp: 8,
        icon: '50d',
        rainH: 5,
      },
      {
        id: 4,
        name: 'Zachmurzone',
        temp: 12,
        icon: '03d',
        rainH: 5,
      },
      {
        id: 5,
        name: 'Zachmurzone',
        temp: 12,
        icon: '03d',
        rainH: 5,
      },
      {
        id: 6,
        name: 'Deszcz',
        temp: 10,
        icon: '10d',
        rainH: 10,
      },
      {
        id: 7,
        name: 'Deszcz',
        temp: 10,
        icon: '10d',
        rainH: 10,
      },
    ],
  }),
};
</script>

<style lang="scss" scoped>

</style>
