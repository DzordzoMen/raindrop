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
      mandatory
      shift
    >
      <v-btn :to="{ name: 'Rainwater' }">
        <span>
          Woda
        </span>
        <v-icon>
          mdi-water-sync
        </v-icon>
      </v-btn>
      <v-btn :to="{ name: 'Devices' }">
        <span>
          Urządzenia
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
};
</script>

<style lang="scss">
.v-main__wrap {
  background-color: hsl(0deg 0% 81% / 50%);
}
</style>
