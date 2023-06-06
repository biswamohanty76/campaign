<template>
  <v-main>
    <v-container fluid>
      <v-row>
        <v-col cols="9">
          <div class="green-base-image"></div>
        </v-col>
        <v-col cols="3">
          <v-card>
            <v-card-title class="text-center">Register</v-card-title>
            <v-card-text>
              <v-form>
                <v-text-field label="Full Name" type="text" required></v-text-field>
                <v-text-field label="Email" type="email" required></v-text-field>
                <v-text-field label="Password" type="password" required></v-text-field>
                <v-text-field label="Confirm Password" type="password" required></v-text-field>
                <v-row>
                  <v-col cols="6">
                    <v-text-field label="Date of Birth" type="date" required></v-text-field>
                  </v-col>
                  <v-col cols="6">
                    <v-select label="Gender" :items="['Male', 'Female', 'Other']"></v-select>
                  </v-col>
                </v-row>
                <v-checkbox label="I agree to the Terms and Conditions"></v-checkbox>
                <v-row class="d-flex justify-center">
                  <v-col cols="auto">
                    <v-btn color="primary" @click="navigate('home')" block>Register</v-btn>
                  </v-col>
                  <v-col cols="auto">
                    <v-spacer></v-spacer>
                    <v-btn class="bg-green-lighten-1" block>Cancel</v-btn>
                  </v-col>
                </v-row>
              </v-form>
            </v-card-text>
            <v-card-actions>
              <v-spacer></v-spacer>
              <v-row class="center">
                <v-col cols="auto">
                  <p>Already have an account? <router-link to="/login">Log in</router-link></p>
                </v-col>
              </v-row>
            </v-card-actions>
          </v-card>
        </v-col>
      </v-row>
    </v-container>
  </v-main>
</template>
<script lang='ts' setup>
import { useRouter } from 'vue-router';
const router = useRouter()
const navigate = (name: string) => {
  router.push({
    name: name
  });
};
</script>
<style>
.green-base-image {
    background-image: url('./../../assets/images/login_left.jpg');
    background-size: cover;
    background-position: center center;
    height: 100vh;
    width: 100%;
    background-color: green;
}

.width-50 {
    width: 100%;
}
</style>