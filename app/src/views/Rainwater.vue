<template>
  <v-container class="container-on-header">
    <v-row>
      <v-col cols="12" style="z-index: 5" @click="$router.push({ name: 'Weather' })">
        <weather-card
          :name="currentWeather.weather[0].main || ''"
          :temp="currentWeather.dayTemperature || 0"
          :icon="currentWeather.weather[0].icon || '10d'"
          :rainH="currentWeather.rain || 0"
        />
      </v-col>

      <v-col cols="12" v-if="showWarn">
        <v-alert type="error" color="red lighten-1" border="bottom" class="ma-0" dark>
          Zbiornik niedługo się przepełni
        </v-alert>
      </v-col>

      <v-col
        cols="12"
        class="d-flex align-center justify-center"
        :style="showWarn ? 'height: 400px' : 'height: 450px'"
      >
        <the-circle :percent="tankFillPercentage">
          <v-row dense class="flex-column text-center headline font-weight-bold">
            <v-col cols="12">
              {{ tankCurrent.toFixed(0) }}
            </v-col>
            <v-col>
              <v-divider />
            </v-col>
            <v-col cols="12">
              {{ tankCapacity.toFixed(0) }}
            </v-col>
          </v-row>
        </the-circle>
      </v-col>
      <v-col cols="12" class="text-center title">
        Ogólna ilość zebranej wody przez Ciebie: <b>{{ tankTotalCollectedWater.toFixed(0) }}</b> l
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
  computed: {
    currentTankData() {
      return this.$store.getters.firstDevice;
    },
    currentWeather() {
      return this.$store.getters.currentWeather || {};
    },
    tankCurrent() {
      return this.currentTankData?.currentAmount || 0;
    },
    tankCapacity() {
      return this.currentTankData?.maxAmount || 100;
    },
    tankTotalCollectedWater() {
      return this.currentTankData?.totalCollectedAmount || 0;
    },
    tankFillPercentage() {
      const { tankCurrent, tankCapacity } = this;
      return (tankCurrent / tankCapacity) * 100;
    },
    showWarn() {
      return this.tankFillPercentage >= 90;
    },
  },
};
</script>

<style lang="scss" scoped>
.container-on-header {
  margin-top: -64px;
}
</style>
