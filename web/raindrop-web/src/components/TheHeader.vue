<template>
  <v-app-bar
    app
    color="primary lighten-2"
    dark
    clipped-left
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
    <v-spacer></v-spacer>
    <button class="d-flex align-right">
      <span>
        Przejdź do aplikacji
      </span>
      <v-icon>
        arrow-right-thin
      </v-icon>
    </button>
  </v-app-bar>
</template>

<script>

export default {
  name: 'TheHeader',
};
</script>
