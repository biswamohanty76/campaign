<template>
  <v-main>
    <v-container>
      <v-label style="font-size: x-large;">Setup your page and workflow.</v-label>
      <v-card></v-card>
      <v-btn color="primary" @click="navigate('contestnew')">Add New Contest</v-btn>
    </v-container>    
    <v-container class="grey lighten-5">
      <v-row no-gutters class="align-items-center" v-for="(contest, index) in contests" :key="index">
        <v-col cols="12" sm="6">
          <v-card class="pa-2" outlined tile>
            {{ contest.name }}
          </v-card>
        </v-col>
        <v-col cols="12" sm="2" class="d-flex justify-center">
          <v-switch v-model="contest.isActive" color="green" label="Active" hide-details></v-switch>
        </v-col>
        <v-col cols="12" sm="2" class="d-flex justify-center">
          <v-icon color="primary" @click="editContest(index)">mdi-pencil</v-icon>
        </v-col>
        <v-col cols="12" sm="2" class="d-flex justify-center">
          <v-icon color="error" @click="deleteContest(index)">mdi-delete</v-icon>
        </v-col>
      </v-row>
    </v-container>
  </v-main>
</template>

<script lang="ts" setup>
import { onMounted, ref, watch } from 'vue'
import { useRouter, useRoute } from 'vue-router'

const router = useRouter()
const route = useRoute()

const contests = ref([
  {
    name: 'Contest 1',
    isActive: false,
  },
  {
    name: 'Contest 2',
    isActive: true,
  },
  {
    name: 'Contest 3',
    isActive: false,
  },
])

const navigate = (name: string) => {
  router.push({
    name: name
  });
};

const editContest = (index: number) => {
  // implement edit contest logic
}

const deleteContest = (index: number) => {
  contests.value.splice(index, 1)
}

</script>

<style scoped>
.width-50{
  width: 50%;
}
.align-items-center{
  align-items: center;
}
</style>
