<template>
    <v-main>
      <v-card flat   >
        <v-card-title>Participants</v-card-title>
        <v-card >
          <v-card-title>
            <v-text-field v-model="search" append-icon="mdi-magnify" label="Search" single-line
              hide-details></v-text-field>
          </v-card-title>
          <v-data-table :headers="headers" :items="participants" :search="search" show-select :dense="dense"></v-data-table>
        </v-card>
        <v-spacer></v-spacer>
        <v-btn color="primary">Edit</v-btn>        
      </v-card>
    </v-main>
</template>
<script lang="ts">
export default {
  data() {
    return {
      dense:"true",
      search: '',
      headers: [
        {
          align: 'start',
          key: 'Name',
          sortable: false,
          title: 'Name',
        },
        { key: 'Contest', title: 'Contest' },
        { key: 'Status', title: 'Status' },
        { key: 'Score', title: 'Score' },
        { key: 'Phone', title: 'Phone' },
        { key: 'Email', title: 'Email' },
        { key: 'Company', title: 'Company' },
        { key: 'Location', title: 'Location' },
      ],
      participants: [
        {
          Name: "John Doe",
          Contest: "Annual Sales Competition",
          Status: "Winner",
          Score: 87,
          Phone: "+1 (555) 123-4567",
          Email: "johndoe@example.com",
          Company: "Acme Corporation",
          Location: "New York, NY"
        },
        {
          Name: "Jane Smith",
          Contest: "Quarterly Performance Awards",
          Status: "Runner-up",
          Score: 79,
          Phone: "+1 (555) 234-5678",
          Email: "janesmith@example.com",
          Company: "ABC Inc.",
          Location: "San Francisco, CA"
        },
        {
          Name: "David Lee",
          Contest: "Employee of the Month",
          Status: "Winner",
          Score: 93,
          Phone: "+1 (555) 345-6789",
          Email: "davidlee@example.com",
          Company: "XYZ Corp.",
          Location: "Seattle, WA"
        },
        {
          Name: "Sarah Johnson",
          Contest: "Annual Sales Competition",
          Status: "Runner-up",
          Score: 82,
          Phone: "+1 (555) 456-7890",
          Email: "sarahjohnson@example.com",
          Company: "Acme Corporation",
          Location: "Los Angeles, CA"
        },
        {
          Name: "Kevin Smith",
          Contest: "Quarterly Performance Awards",
          Status: "Winner",
          Score: 91,
          Phone: "+1 (555) 567-8901",
          Email: "kevinsmith@example.com",
          Company: "ABC Inc.",
          Location: "Denver, CO"
        },
        {
          Name: "Jessica Chen",
          Contest: "Employee of the Month",
          Status: "Runner-up",
          Score: 88,
          Phone: "+1 (555) 678-9012",
          Email: "jessicachen@example.com",
          Company: "XYZ Corp.",
          Location: "Boston, MA"
        },
        {
          Name: "Brian Nguyen",
          Contest: "Annual Sales Competition",
          Status: "Winner",
          Score: 89,
          Phone: "+1 (555) 789-0123",
          Email: "briannguyen@example.com",
          Company: "Acme Corporation",
          Location: "Chicago, IL"
        },
        {
          Name: "Amanda Lee",
          Contest: "Quarterly Performance Awards",
          Status: "Runner-up",
          Score: 77,
          Phone: "+1 (555) 890-1234",
          Email: "amandalee@example.com",
          Company: "ABC Inc.",
          Location: "Houston, TX"
        },
        {
          Name: "Michael Davis",
          Contest: "Employee of the Month",
          Status: "Winner",
          Score: 95,
          Phone: "+1 (555) 901-2345",
          Email: "michaeldavis@example.com",
          Company: "XYZ Corp.",
          Location: "Portland, OR"
        }


      ],
    }
  },
}
</script>
