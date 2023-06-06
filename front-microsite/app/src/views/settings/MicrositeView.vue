<template>
  <v-card outlined>
    <v-card-title>
      <h2>Add Page to Microsite</h2>
    </v-card-title>
    <v-card-text>
      <v-container>
        <v-row>
          <v-col cols="9">
            <v-text-field v-model="pageTitle" label="Title to the Page Name"></v-text-field>
          </v-col>
          <v-col cols="1">
            <v-btn color="primary" @click="addPage">
              <v-icon>mdi-plus</v-icon>
            </v-btn>
          </v-col>
        </v-row>
        <v-divider></v-divider>
        <v-row>
          <v-col cols="12">

            <v-table class="compact-table" height="540px">
  <thead>
    <tr>
      <th class="text-left">Serial Number</th>
      <th class="text-left">Page Title</th>
      <th class="text-left">Toggle Button</th>
      <th class="text-left">Delete Page</th>
    </tr>
  </thead>
  <tbody>
    <tr v-for="(page, index) in pages" :key="index">
      <td class="text-left">{{ index + 1 }}</td>
      <td class="text-left">{{ page.title }}</td>
      <td class="text-left">
        <v-switch v-model="page.enabled" :label="''" color="primary"></v-switch>
      </td>
      <td class="text-left">
        <v-icon small color="error" @click="deletePage(index)">mdi-delete</v-icon>
      </td>
    </tr>
  </tbody>
</v-table>
          </v-col>
        </v-row>
      </v-container>
    </v-card-text>
    <v-card-actions>
      <v-spacer></v-spacer>
      <v-btn color="primary" @click="savePages">Save</v-btn>
    </v-card-actions>
  </v-card>
</template>
  
<script lang="ts">
export default {
  data() {
    return {
      pageTitle: '',
      pages: [],
    };
  },
  methods: {
    addPage() {
      if (this.pageTitle) {
        this.pages.push({
          title: this.pageTitle,
          enabled: false,
        });
        this.pageTitle = '';
      }
    },
    deletePage(index) {
      this.pages.splice(index, 1);
    },
    savePages() {
      // Perform save operation here
      console.log('Saving pages:', this.pages);
    },
  },
};
</script>
  
<style scoped>
.compact-table tr {
    padding: 5px 10px; /* Adjust the padding as needed */
    font-size: 14px; /* Adjust the font size as needed */
  }
</style>
  