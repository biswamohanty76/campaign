<template>
  <v-app>
    <v-layout class="background">
      <AppLayout></AppLayout>
      <router-view />
    </v-layout>
  </v-app>
</template>

<script lang="ts">
import { defineComponent } from 'vue'
import AppLayout from '../src/views/shared/_Layout.vue';
export default defineComponent({
  name: 'App',
  components: {
    AppLayout,
  },
  data() {
    return {
      //
    }
  },
})
</script>
<style>
html {
  overflow: hidden !important;
}
</style>