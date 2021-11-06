<template>
  <v-app>
    <the-header />
    <v-navigation-drawer
      permanent
      left
      absolute
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
        { title: 'O nas', icon: 'mdi-view-dashboard', routerName: 'Home' },
        { title: 'Jak zacząć', icon: 'mdi-image', routerName: 'Start' },
        { title: 'Dotacje', icon: 'mdi-image', routerName: 'Grants' },
        { title: 'Ile zaoszczędzisz', icon: 'mdi-image', routerName: 'Savings' },
        { title: 'Twoje zużycie wody', icon: 'mdi-image', routerName: 'WaterConsumption' },
      ],
    };
  },
  methods: {
    redirect(routerName) {
      this.$router.push({ name: routerName });
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
    background-color: #e1eeff;
  }
</style>
