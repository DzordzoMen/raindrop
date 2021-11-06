<template>
  <v-app-bar
    app
    color="primary lighten-2"
    dark
  >
    <div class="d-flex align-center" style="gap: 10px">
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
