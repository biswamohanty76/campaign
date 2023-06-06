

<template>
    <v-layout style="height: 800px; width: 1200px   ;">
        <v-main>
            <v-system-bar window color="primary" style="justify-content:center">
                <h3>Settings</h3>
            </v-system-bar>
            <v-navigation-drawer expand-on-hover rail isStuck>
                <v-tabs v-model="tab" direction="vertical" color="primary">
                    <v-tab value="microsite"> <v-icon start> mdi-web </v-icon> Microsite </v-tab>
                    <v-tab value="content"> <v-icon start> mdi-file-document-multiple </v-icon> Content </v-tab>
                    <v-tab value="jobs"> <v-icon start>mdi-book-search </v-icon> Jobs </v-tab>
                    <v-tab value="candidate"> <v-icon start> mdi-account-multiple </v-icon> Canididate </v-tab>
                    <v-tab value="assessment"> <v-icon start> mdi-trophy-award </v-icon> Assessment </v-tab>
                </v-tabs>
            </v-navigation-drawer>
            <v-window v-model="tab">
                <v-window-item value="microsite">
                    <micrositeview></micrositeview>
                </v-window-item>
                <v-window-item value="content">
                    <v-card flat>
                        <ContentView></ContentView>
                    </v-card>
                </v-window-item>
                <v-window-item value="jobs">
                    <v-card flat>
                        <JobsView></JobsView>
                    </v-card>
                </v-window-item>
                <v-window-item value="candidate">
                    <v-card flat>
                        <CandidateView></CandidateView>
                    </v-card>
                </v-window-item>
                <v-window-item value="assessment">
                    <v-card flat>
                        <AssessmentView></AssessmentView>
                    </v-card>
                </v-window-item>
            </v-window>

        </v-main>
    </v-layout>
</template>

<script lang="ts" setup>
import { ref } from "vue";
import micrositeview from "../settings/MicrositeView.vue"
import ContentView from "../settings/ContentView.vue"
import JobsView from "../settings/JobsView.vue"
import CandidateView from '../settings/CanidateView.vue'
import AssessmentView from '../settings/AssessmentView.vue'
const tab = ref('option-1');
const selectComponent = (compoent: string) => {

    console.log(compoent)
}

</script>
<style scoped>
.v-icon {
    width: 2.2rem;
}
</style>