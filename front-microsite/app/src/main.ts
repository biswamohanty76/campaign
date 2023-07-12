import { createApp } from 'vue';
import App from './App.vue';
import router from './router';
import { createCustomVuetify } from './plugins/vuetify';
import { loadFonts } from './plugins/webfontloader';
import { useRoute } from 'vue-router';

loadFonts();
const route = useRoute();
async function initializeApp() {
  
  const vuetify = await createCustomVuetify(route);

  createApp(App)
    .use(router)
    .use(vuetify)
    .mount('#app');
}



initializeApp();
