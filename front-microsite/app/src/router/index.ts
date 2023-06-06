import { createRouter, createWebHistory } from 'vue-router'

import HomeView from '@/views/main/HomeView.vue'
import LoginView from '@/views/LoginView.vue'
import RegisterView from '@/views/RegisterView.vue'
import AboutView from '../views/main/AboutView.vue'
import BlogView from '../views/main/BlogView.vue'
import ContactUsView from '../views/main/ContactUsView.vue'
import ServicesView from '../views/main/ServicesView.vue'
import TeamView from '../views/main/TeamView.vue'
import NewContest from '../views/contest/NewContest.vue'
import ContestView from '../views/contest/ContestView.vue'
import ParticipantsView from '../views/participants/ParticipantsView.vue'
import Settings from '../views/settings/ContentView.vue'

const router = createRouter({
  history: createWebHistory(import.meta.env.BASE_URL),
  routes: [
    {
      path: '/settings',
      name: 'settings',
      component: Settings,
      meta: { auth: true }
    },
    {
      path: '/participants',
      name: 'participants',
      component: ParticipantsView,
      meta: { auth: true }
    },
    {
      path: '/contest',
      name: 'contest',
      component: ContestView,
      meta: { auth: true }
    },
    {
      path: '/contestnew',
      name: 'contestnew',
      component: NewContest,
      meta: { auth: true }
    },
    {
      path: '/aboutus',
      name: 'about',
      component: AboutView,
      meta: { auth: true }
    },
    {
      path: '/blog',
      name: 'blog',
      component: BlogView,
      meta: { auth: true }
    },
    {
      path: '/contactus',
      name: 'contactus',
      component: ContactUsView,
      meta: { auth: true }
    },
    {
      path: '/services',
      name: 'services',
      component: ServicesView,
      meta: { auth: true }
    },
    {
      path: '/team',
      name: 'team',
      component: TeamView,
      meta: { auth: true }
    },
    {
      path: '/register',
      name: 'register',
      component: RegisterView,
      meta: { auth: true }
    },
    {
      path: '/login',
      name: 'login',
      component: LoginView,
      meta: { auth: true }
    },
    {
      path: '/',
      name: 'home',
      component: HomeView,
      meta: { auth: true }
    }

  ]
})

export default router
