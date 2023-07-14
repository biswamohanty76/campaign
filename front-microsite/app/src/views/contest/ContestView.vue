<template>
  <v-main>
    <v-container class="grey lighten-10 contests-container">
      <v-row>
        <v-col cols="5" v-for="(contest, index) in contestList" :key="index">
          <v-card class="mx-auto my-1 custom-card" @click="openContestPopup(contest)">
            <v-img :src="contest.image" class="pa-4"></v-img>
            <v-card-title class="text-center">{{ contest.title }}</v-card-title>
            <v-card-text>
              <v-row>
                <v-col cols="4">
                  <p class="mb-2"><strong>Category:</strong> {{ contest.category }}</p>
                </v-col>
                <v-col cols="6">
                  <p class="mb-2"><strong>Experience:</strong> {{ contest.experience }}</p>
                </v-col>
              </v-row>
              <v-row>
                <v-col cols="6">
                  <p class="mb-2"><strong>Reg. End Date:</strong> {{ formatDate(contest.registrationEndDate) }}</p>
                </v-col>
              </v-row>
              <v-row>
                <v-col cols="6">
                  <p class="mb-2"><strong>Summary:</strong> {{ contest.summary }}</p>
                </v-col>
              </v-row>
            </v-card-text>
          </v-card>
        </v-col>
      </v-row>
      <v-dialog v-model="showContestPopup" style="max-width: 73%; max-height: 80%;">
        <v-card class="elevation-1" max-width="100%" max-height="100%">
          <v-card-title>{{ selectedContest.title }}</v-card-title>
          <v-tabs v-model="activeTab">
            <v-tab v-for="(tab, index) in selectedContest.tabs" :key="index" :value="tab.key">
              {{ tab.key }}
            </v-tab>
          </v-tabs>

          <v-card-text>
            <v-window v-model="activeTab">
              <v-window-item v-for="(tab, index) in selectedContest.tabs" :key="index" :value="tab.key">
                <v-card-text v-html="tab.value"></v-card-text>
              </v-window-item>
            </v-window>
          </v-card-text>

          <v-card-actions>
            <v-btn color="primary" @click="registerForContest(selectedContest)">Register</v-btn>
            <v-btn color="secondary" @click="closeContestPopup">Close</v-btn>
          </v-card-actions>
        </v-card>
      </v-dialog>
    </v-container>
  </v-main>
</template>

<script lang="ts" setup>
import { ContestApi } from '../../openapi/apis/ContestApi'
import type { Contest, ContestTab } from '../../openapi/models'
import { ref, onMounted } from 'vue'
import { useRoute, useRouter } from 'vue-router'

const router = useRouter()
const route = useRoute();
var contestApi = new ContestApi();
const pageLoading = ref(true);
const selectedContest = ref({
  title: '',
  tabs: {},
})
const registerForContest = () => {
  router.push({ name: 'Registration' });
};
const activeTab = ref('')

const showContestPopup = ref(false)
const openContestPopup = (contest:any) => {
  selectedContest.value = contest
  console.log(selectedContest.value);
  showContestPopup.value = true
}

const closeContestPopup = () => {
  showContestPopup.value = false
}
const formatDate = (date:any) => {
  const options = { year: 'numeric', month: 'long', day: 'numeric' }
  return date.toLocaleDateString(undefined, options)
}
const contestList = ref<Contest[]>([]);
onMounted(() => {
  if (route.params.id !== undefined) {
    var tenantId = route.params.id.toString();
    contestApi.getcontestsbytenantid({ guid: tenantId })
      .then((response) => {
        contestList.value = response as Contest[]; // Type assertion to assign the response data
        console.log(contestList.value);
      })
      .catch(error => {
        console.log(error);
      });
  } else {
    pageLoading.value = false;
  }
});
</script>

<style scoped>
.v-card {
  transition: transform 0.2s;
  cursor: pointer;
}
.v-card:hover {
  transform: scale(1.05);
}
.v-card-title {
  font-size: 20px;
  font-weight: bold;
  padding: 16px;
}
.v-card-text {
  padding: 0 16px 16px;
}
.v-dialog {
  max-width: 600px;
}
.v-dialog .v-card-title {
  font-size: 24px;
  font-weight: bold;
  padding: 16px;
}
.v-dialog .v-card-text {
  padding: 16px;
}
.custom-card {
  width: 100%;
  margin-left: auto;
  margin-right: auto;
  max-height: 250px;
}
.contests-container {
  overflow-x: auto;
  white-space: nowrap;
  max-height: calc(100vh - 200px);
  /* Adjust the height according to your footer height */
}
</style>
