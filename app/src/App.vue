<template>
  <v-app>
    <the-header />

    <v-main>
      <router-view/>
    </v-main>

    <v-bottom-navigation
      v-model="navigation"
      app
      grow
      color="primary"
      background-color="grey lighten-3"
      mandatory
      shift
    >
      <v-btn :to="{ name: 'Rainwater' }">
        <span>
          Zbiornik
        </span>
        <v-icon>
          mdi-water-sync
        </v-icon>
      </v-btn>
      <v-btn :to="{ name: 'Devices' }">
        <span>
          Smart home
        </span>
        <v-icon>
          mdi-tablet-cellphone
        </v-icon>
      </v-btn>
      <v-btn :to="{ name: 'Weather' }">
        <span>
          Pogoda
        </span>
        <v-icon>
          mdi-weather-cloudy
        </v-icon>
      </v-btn>
      <v-btn :to="{ name: 'Stats' }">
        <span>
          Statystyki
        </span>
        <v-icon>
          mdi-finance
        </v-icon>
      </v-btn>
    </v-bottom-navigation>
  </v-app>
</template>

<script>
import TheHeader from './components/TheHeader.vue';

export default {
  name: 'App',
  components: {
    TheHeader,
  },
  data: () => ({
    navigation: null,
  }),
  created() {
    this.$store.dispatch('fetchDevices');
    this.$store.dispatch('fetchWeather');
    this.$store.dispatch('fetchHistory');
  },
};
</script>

<style lang="scss">
.v-main__wrap {
  background-color: hsl(0deg 0% 81% / 50%);
}
</style>
