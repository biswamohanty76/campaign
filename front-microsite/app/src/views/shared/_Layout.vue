<template>
  <header class="sticky-top custom-navbar">
    <v-app-bar class="bg-white" density="default" :elevation="0"
      style="border-bottom:1px solid #e0e0e0;padding:0px 10% !important;">
      <v-app-bar-title>
        <v-img src="../../assets/images/logo.png" style="width:350px;height:54px;"></v-img>
      </v-app-bar-title>
      <template v-slot:append>
        <span class="pr-5" style="font-size:large;">Akash Varshney</span>
        <v-menu v-model="menu" :close-on-content-click="false" location="end">
          <template v-slot:activator="{ props }">
            <v-btn color="indigo" v-bind="props" variant="text">
              <v-avatar color="green">
                <span class="text-h5">AV</span>
              </v-avatar>
            </v-btn>
          </template>
          <v-card min-width="300">
            <v-list>
              <v-list-item prepend-avatar="https://cdn.vuetifyjs.com/images/john.jpg" title="Akash Varshney"
                subtitle="Administrator">
                <template v-slot:append>
                  <v-btn variant="text" :class="fav ? 'text-red' : ''" icon="mdi-heart" @click="fav = !fav"></v-btn>
                </template>
              </v-list-item>
            </v-list>
            <v-divider></v-divider>
            <v-list>
              <v-list-item>
                <v-switch v-model="message" color="purple" label="Enable message" hide-details></v-switch>
                <v-list-item>
                  <v-btn @click="dialog = true">Settings</v-btn>

                </v-list-item>
              </v-list-item>
              <v-card-actions>
                <v-btn variant="text" @click="navigate('login')">
                  Login
                </v-btn>
                <v-btn variant="text" @click="menu = false">
                  Logout
                </v-btn>
              </v-card-actions>
            </v-list>
          </v-card>
        </v-menu>
      </template>
    </v-app-bar>

    <v-app-bar density="default" style="padding:0px 10% !important;" class="bg-white">
      <v-tabs color="primary" v-model="activetab">
        <v-tab value="home" @click="navigate('home')">Home</v-tab>
        <v-tab value="contest" @click="navigate('contest')">Contest</v-tab>
        <v-tab value="participants" @click="navigate('participants')">Participants</v-tab>
        <v-tab value="jobs">Jobs</v-tab>
        <v-tab value="candiate" @click="navigate('candidate')">Candidate</v-tab>
        <v-tab value="assessment">Assessment</v-tab>
        <v-tab value="report">Report</v-tab>

      </v-tabs>
    </v-app-bar>
  </header>

 
    <v-dialog v-model="dialog" width="auto">
      <v-card>
        <!-- //new COmponet  -->
        <Settings></Settings>
      </v-card>
    </v-dialog>


  <v-footer class="bg-green-lighten-1" style="position: fixed; bottom: 0; width: 100%;">
    <v-row justify="center" no-gutters>
      <v-btn color="white" variant="text" class="mx-3 rounded-xl" @click="navigate('home')">Home</v-btn>
      <v-btn color="white" variant="text" class="mx-3 rounded-xl" @click="navigate('about')">About Us</v-btn>
      <v-btn color="white" variant="text" class="mx-3 rounded-xl" @click="navigate('team')">Team</v-btn>
      <v-btn color="white" variant="text" class="mx-3 rounded-xl" @click="navigate('services')">Services</v-btn>
      <v-btn color="white" variant="text" class="mx-3 rounded-xl" @click="navigate('blog')">Blog</v-btn>
      <v-btn color="white" variant="text" class="mx-3 rounded-xl" @click="navigate('contactus')">Contact Us</v-btn>
      <v-col class="text-center mt-4" cols="12">
        {{ new Date().getFullYear() }} — <strong>Cultre Cubs</strong>
      </v-col>
    </v-row>
  </v-footer>
</template>
<script lang='ts'>
import { defineComponent } from 'vue'
export default defineComponent({
  name: 'AppLayout',
  data: () => ({
    fav: true,
    menu: false,
    message: false,
    hints: true,
    dialog: false,
  })
})
</script>
<script lang='ts' setup>
import { onMounted, ref, watch } from 'vue'
import { useRouter, useRoute } from 'vue-router'
import Settings from '../settings/SettingsView.vue'

const router = useRouter()
const route = useRoute()

const navigate = (name: string) => {
  router.push({
    name: name
  });
};


var activetab = ref('');

onMounted(() => {

})

watch(() => route.name, () => {
  if (route.name == 'contest') {
    activetab.value = "contest";
  } else if (route.name == 'home') {
    activetab.value = "home";
  } else if (route.name == 'participant') {
    activetab.value = "participant";
  } else if (route.name == 'jobs') {
    activetab.value = "jobs";
  } else if (route.name == 'candidate') {
    activetab.value = "candidate";
  } else if (route.name == 'assessment') {
    activetab.value = "assessment";
  } else {
    activetab.value = "report";
  }
}, { immediate: true });

</script>
