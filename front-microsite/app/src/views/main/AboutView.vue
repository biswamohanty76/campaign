<template>
  <v-main>
    <v-container>
      <v-row>
        <v-col cols="12">
          <h1>About Us</h1>
        </v-col>
      </v-row>
      <v-row>
        <v-col cols="12" md="6">
          <img src="https://picsum.photos/500/300" alt="About Us" />
        </v-col>
        <v-col cols="12" md="6">
          <p>
            Welcome to our website! We are a team of dedicated professionals who are committed to providing top-notch
            services to our clients. Our goal is to deliver high-quality work that exceeds our clients' expectations.
          </p>
          <p>
            We have been in the industry for several years and have built a solid reputation for our expertise,
            reliability, and exceptional customer service. We pride ourselves on our ability to deliver projects on time
            and within budget, without compromising on quality.
          </p>
          <p>
            At our core, we are a team of problem-solvers who are dedicated to helping our clients achieve their goals. We
            value integrity, honesty, and transparency, and we believe that these values are reflected in the way we work.

            Thank you for considering us for your next project. We look forward to working with you!
          </p>
        </v-col>
      </v-row>
    </v-container>
  </v-main>
</template>
  
<script>
export default {
  name: 'about',
};
</script>
  
<style scoped>
h1 {
  font-size: 32px;
  margin-bottom: 20px;
}

img {
  width: 100%;
  height: auto;
  margin-bottom: 20px;
}

p {
  font-size: 18px;
  line-height: 1.5;
  margin-bottom: 20px;
}</style>
  