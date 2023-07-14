<template>
  <header class="sticky-top custom-navbar">
    <v-app-bar color="secondary" density="default" :elevation="1"
      style="border-bottom:0px solid #e0e0e0;padding:0px 10% !important;">
      <v-app-bar-title>
        <v-img :src="logo.tenantIcon" style="width:350px;height:54px;"></v-img>
      </v-app-bar-title>
      <v-tabs color="primary" v-model="activetab">
        <v-tab value="home" @click="navigate('home')">Home</v-tab>
        <v-tab value="contest" @click="navigate('contest')">Contest</v-tab>
      </v-tabs>
    </v-app-bar>
  </header>

  <v-footer color="secondary" style="position: fixed; bottom: 0; width: 100%;">
    <v-row justify="center" no-gutters>
      <v-btn color="primary" variant="text" class="mx-3 rounded-xl" @click="navigate('home')">Home</v-btn>
      <v-btn color="primary" variant="text" class="mx-3 rounded-xl" @click="navigate('about')">About Us</v-btn>
      <v-btn color="primary" variant="text" class="mx-3 rounded-xl" @click="navigate('contactus')">Contact Us</v-btn>
      <v-col class="text-center mt-4" cols="12">
        {{ new Date().getFullYear() }} — <strong> Powered By- Cultre Cubs</strong>
      </v-col>
    </v-row>
  </v-footer>
</template>
<script lang='ts'>
import { defineComponent } from 'vue';
import { themeConfig } from '../../plugins/vuetify'
import type { ThemeConfig } from '../../plugins/vuetify';
export default defineComponent({
  name: 'AppLayout',
  data: () => ({
    fav: true,
    menu: false,
    message: false,
    hints: true,
    dialog: false,

  }),
  computed: {
    logo() {
      return themeConfig as ThemeConfig;
    },

  },
})
</script>
<script lang='ts' setup>
import { onMounted, ref, watch } from 'vue'
import { useRouter, useRoute } from 'vue-router'

const router = useRouter()
const route = useRoute()

const navigate = (name: string) => {
  router.push({
    name: name
  });
};
var activetab = ref('');
watch(() => route.name, () => {
  if (route.name == 'contest') {
    activetab.value = "contest";
  } else if (route.name == 'home') {
    activetab.value = "home";
  }
}, { immediate: true });

</script>
