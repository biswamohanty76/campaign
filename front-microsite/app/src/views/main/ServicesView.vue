<template>
  <v-main>
    <v-container>
      <h1 class="text-center">Our Services</h1>
      <v-row>
        <v-col cols="12" sm="6" md="4">
          <v-card class="service-card">
            <v-card-media :src="require('@/assets/images/service1.jpg')" height="200px"></v-card-media>
            <v-card-title>Service 1</v-card-title>
            <v-card-text>
              Welcome to our website! We are a team of dedicated professionals who are committed to providing top-notch
              services to our clients. Our goal is to deliver high-quality work that exceeds our clients' expectations.


            </v-card-text>
            <v-card-actions>
              <v-btn color="primary" text>Read More</v-btn>
            </v-card-actions>
          </v-card>
        </v-col>
        <v-col cols="12" sm="6" md="4">
          <v-card class="service-card">
            <v-card-media :src="require('@/assets/images/service2.jpg')" height="200px"></v-card-media>
            <v-card-title>Service 2</v-card-title>
            <v-card-text>
              We have been in the industry for several years and have built a solid reputation for our expertise,
              reliability, and exceptional customer service. We pride ourselves on our ability to deliver projects on time
              and within budget, without compromising on quality.

            </v-card-text>
            <v-card-actions>
              <v-btn color="primary" text>Read More</v-btn>
            </v-card-actions>
          </v-card>
        </v-col>
        <v-col cols="12" sm="6" md="4">
          <v-card class="service-card">
            <v-card-media :src="require('@/assets/images/service3.jpg')" height="200px"></v-card-media>
            <v-card-title>Service 3</v-card-title>
            <v-card-text>

              At our core, we are a team of problem-solvers who are dedicated to helping our clients achieve their goals.
              We value integrity, honesty, and transparency, and we believe that these values are reflected in the way we
              work. Thank you for considering us for your next project. We look forward to working with you!
            </v-card-text>
            <v-card-actions>
              <v-btn color="primary" text>Read More</v-btn>
            </v-card-actions>
          </v-card>
        </v-col>
      </v-row>
    </v-container>
  </v-main>
</template>
  
<script>
export default {
  name: "ServicesView",
};
</script>
  
<style scoped>
.service-card {
  margin: 20px;
  text-align: center;
}
</style>
  