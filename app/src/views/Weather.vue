<template>
  <v-container>
    <v-row dense>
      <v-col cols="12" v-for="(weather, index) in weatherForWeek" :key="index">
        <weather-card
          :date="dates[index]"
          :icon="weather.weather[0].icon"
          :name="weather.weather[0].main"
          :temp="weather.dayTemperature"
          :rainH="weather.rain"
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
  computed: {
    weatherForWeek() {
      return this.$store.getters.allWeather || [];
    },
    dates() {
      const array = [];
      for (let i = 0; i < this.weatherForWeek.length; i += 1) {
        const date = new Date();
        date.setDate(date.getDate() + i);
        array.push(date);
      }
      return array;
    },
  },
};
</script>

<style lang="scss" scoped>

</style>
