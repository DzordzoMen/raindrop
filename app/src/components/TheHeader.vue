<template>
  <v-app-bar
    app
    color="primary lighten-2"
    :height="['Rainwater', 'Devices'].includes($route.name) ? 112 : null"
    dark
  >
    <div class="d-flex align-center justify-start" style="gap: 10px">
      <v-img
        alt="Raindrop Logo"
        contain
        src="../assets/logo.svg"
        width="40"
        height="40"
      />
      <span class="headline">
        Raindrop
      </span>
    </div>
  </v-app-bar>
</template>

<script>
export default {
  name: 'TheHeader',
};
</script>

<style lang="scss">
.v-toolbar {
  border-bottom-left-radius: 20px 15px !important;
  border-bottom-right-radius: 20px 15px !important;

  &__content {
    padding: 8px 16px !important;
    align-items: flex-start !important;
  }
}
</style>
