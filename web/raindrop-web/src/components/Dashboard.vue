<template>
  <v-app>
    <the-header />
    <the-navigation-drawer />
  </v-app>
</template>

<script>
import TheHeader from '@/components/TheHeader.vue';
import TheNavigationDrawer from '@/components/TheNavigationDrawer.vue';

export default {
  name: 'Dashboard',
  components: {
    TheHeader,
    TheNavigationDrawer,
  },
};
</script>
