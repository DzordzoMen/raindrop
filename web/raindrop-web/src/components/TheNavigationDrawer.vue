<template>
    <v-app id="inspire">
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
  </v-app>
</template>

<script>

export default {
  name: 'TheNavigationDrawer',
  data() {
    return {
      items: [
        { title: 'O nas', icon: 'mdi-view-dashboard' },
        { title: 'Jak zacząć?', icon: 'mdi-image' },
        { title: 'Dotacje', icon: 'mdi-image' },
        { title: 'Ile możesz zaoszczędzić?', icon: 'mdi-image' },
        { title: 'Jak dużo wody zużywasz?', icon: 'mdi-image' },
      ],
      right: null,
    };
  },
};
</script>
