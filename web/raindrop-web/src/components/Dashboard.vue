<template>
    <v-app id="inspire">
      <the-header />
      <v-navigation-drawer v-model="drawer"
      permanent
      left
      absolute
      class="v-theme--dark">
        <v-list
          dense
          nav
        >
          <v-list-item
            v-for="item in items"
            :key="item.title"
            link
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
  name: 'TheNavigationDrawer',
  components: {
    TheHeader,
  },
  data() {
    return {
      items: [
        { title: 'O nas', icon: 'mdi-view-dashboard' },
        { title: 'Jak zacząć', icon: 'mdi-image' },
        { title: 'Dotacje', icon: 'mdi-image' },
        { title: 'Ile zaoszczędzisz', icon: 'mdi-image' },
        { title: 'Twoje zużycie wody', icon: 'mdi-image' },
      ],
    };
  },
};
</script>
