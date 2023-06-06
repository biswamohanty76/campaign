<template>
    <v-main>
        <v-container fluid>
            <v-row>
                <v-col cols="9">
                    <div class="green-base-image"></div>
                </v-col>
                <v-col cols="3">
                    <v-card>
                        <v-card-title class="text-center">Login</v-card-title>
                        <v-card-text>
                            <v-form>
                                <v-text-field label="Email" type="email" required></v-text-field>
                                <v-text-field label="Password" type="password" required></v-text-field>
                                <v-text-field label="OTP" type="number" required></v-text-field>
                                <v-checkbox label="Remember me on this machine"></v-checkbox>
                                <v-row class="d-flex justify-center">
                                    <v-col cols="auto">
                                        <v-btn color="primary" @click="navigate('home')" block>Login</v-btn>
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
                                    <v-btn color="primary" class="width-50" block @click="navigate('register')">Register</v-btn>
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