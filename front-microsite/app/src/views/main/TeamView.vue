<template>
  <v-main>
    <v-container fluid>
      <h1 class="text-center mb-5">Meet Our Team</h1>
      <v-row>
        <v-col v-for="(member, index) in teamMembers" :key="index" cols="12" md="4">
          <v-card class="elevation-10">
            <v-img :src="member.avatar" alt="Team Member" height="200"></v-img>
            <v-card-title class="text-center">{{ member.name }}</v-card-title>
            <v-card-subtitle class="text-center">{{ member.title }}</v-card-subtitle>
            <v-card-text class="text-center">{{ member.bio }}</v-card-text>
            <v-card-actions>
              <v-btn color="primary" text :href="member.linkedin" target="_blank">LinkedIn</v-btn>
            </v-card-actions>
          </v-card>
        </v-col>
      </v-row>
    </v-container>
  </v-main>
</template>
  
<script lang="ts">
export default {
  name: 'TeamPage',
  data() {
    return {
      teamMembers: [
        {
          name: 'John Doe',
          title: 'CEO',
          bio: 'John is the founder and CEO of our company.',
          avatar: 'https://randomuser.me/api/portraits/men/1.jpg',
          linkedin: 'https://www.linkedin.com/in/john-doe'
        },
        {
          name: 'Jane Smith',
          title: 'CTO',
          bio: 'Jane is responsible for overseeing our technical operations.',
          avatar: 'https://randomuser.me/api/portraits/women/2.jpg',
          linkedin: 'https://www.linkedin.com/in/jane-smith'
        },
        {
          name: 'Bob Johnson',
          title: 'Marketing Director',
          bio: 'Bob leads our marketing efforts and brings years of experience to the team.',
          avatar: 'https://randomuser.me/api/portraits/men/3.jpg',
          linkedin: 'https://www.linkedin.com/in/bob-johnson'
        }
      ]
    }
  }
}
</script>
  
<style>
.v-card {
  margin-bottom: 20px;
}
</style>
  