<template>
  <v-container>
      <the-header />
      <v-navigation-drawer
      permanent
      left
      absolute
      class="menu-background">
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
  </v-container>
</template>

<script>

import TheHeader from '@/components/TheHeader.vue';

export default {
  name: 'TheNavigationDrawer',
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

<style lang="scss" scoped>
  .menu-background {
    background-color: '#a5ccff' !important;
  }
</style>
