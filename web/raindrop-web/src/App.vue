<template>
  <v-app>
    <the-header />
    <v-navigation-drawer
      permanent
      left
      clipped
      app
      class="v-theme--dark">
        <v-list
          dense
          nav
        >
          <v-list-item
            v-for="item in items"
            :key="item.title"
            link
            @click="redirect(item.routerName)"
          >
            <v-list-item-icon>
              <v-icon>{{ item.icon }}</v-icon>
            </v-list-item-icon>

            <v-list-item-content>
              <v-list-item-title>{{ item.title }}</v-list-item-title>
            </v-list-item-content>
          </v-list-item>

          <v-list-item link @click="openRankomat()">
            <v-list-item-icon>
              <v-icon>mdi-water-alert-outline</v-icon>
            </v-list-item-icon>

            <v-list-item-content>
              <v-list-item-title>Twoje zużycie wody</v-list-item-title>
            </v-list-item-content>
          </v-list-item>
        </v-list>
      </v-navigation-drawer>
      <v-main>
        <v-container>
          <router-view/>
        </v-container>
      </v-main>
  </v-app>
</template>

<script>

import TheHeader from '@/components/TheHeader.vue';

export default {
  name: 'App',
  components: {
    TheHeader,
  },
  data() {
    return {
      items: [
        { title: 'O nas', icon: 'mdi-account-group', routerName: 'Home' },
        { title: 'Jak zacząć', icon: 'mdi-help', routerName: 'Start' },
        { title: 'Dotacje', icon: 'mdi-cash-multiple', routerName: 'Grants' },
        { title: 'Ile zaoszczędzisz', icon: 'mdi-calculator', routerName: 'Savings' },
      ],
    };
  },
  methods: {
    redirect(routerName) {
      this.$router.push({ name: routerName });
    },
    openRankomat() {
      window.open('https://rankomat.pl/woda/#/', '_blank');
    },
  },
};
</script>

<style lang="scss">
  @import url('https://fonts.googleapis.com/css2?family=Nunito&display=swap');
  html, body {
    font-family: 'Nunito', sans-serif;
  }
  #app {
    font-family: 'Nunito', sans-serif;
  }
  .v-main__wrap {
    background-color: #e1eeff !important;
  }
  .v-navigation-drawer {
    background-color: #a5ccff !important;
  }
  a {
    text-decoration: none;
  }
</style>
