<template>
  <v-app>
    <v-layout>
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
.v-main {
  background-color: #f5f5f5 !important;
}

html {
  overflow: hidden !important;
}
</style>