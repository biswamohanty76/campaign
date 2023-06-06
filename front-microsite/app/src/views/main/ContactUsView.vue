<template>
    <v-main>
        <v-container>
      <v-row>
        <v-col cols="12">
          <h1>Contact Us</h1>
          <p>Please fill out the form below to get in touch with us.</p>
        </v-col>
      </v-row>
      <v-row>
        <v-col cols="12" sm="6">
          <v-form @submit.prevent="submitForm">
            <v-text-field v-model="name" label="Name"></v-text-field>
            <v-text-field v-model="email" label="Email"></v-text-field>
            <v-textarea v-model="message" label="Message"></v-textarea>
            <v-btn type="submit" color="primary">Submit</v-btn>
          </v-form>
        </v-col>
        <v-col cols="12" sm="6">
          <h2>Our Address</h2>
          <p>123 Main Street</p>
          <p>Anytown, USA 12345</p>
          <h2>Phone Number</h2>
          <p>(123) 456-7890</p>
          <h2>Email Address</h2>
          <p>info@company.com</p>
        </v-col>
      </v-row>
    </v-container>
    </v-main>
  </template>
  
  <script lang="ts">
  export default {
    data() {
      return {
        name: "",
        email: "",
        message: "",
      };
    },
    methods: {
      submitForm() {
        // TODO: Implement form submission logic
        console.log(this.name, this.email, this.message);
      },
    },
  };
  </script>
  