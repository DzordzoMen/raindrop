import Vue from 'vue';
import VueRouter from 'vue-router';
import Home from '../views/Home.vue';

Vue.use(VueRouter);

const routes = [
  {
    path: '/',
    name: 'Home',
    component: Home,
  },
  {
    path: '/start',
    name: 'Start',
    component: () => import('../views/Start.vue'),
  },
  {
    path: '/grants',
    name: 'Grants',
    component: () => import('../views/Grants.vue'),
  },
  {
    path: '/savings',
    name: 'Savings',
    component: () => import('../views/Savings.vue'),
  },
  {
    path: '/water-consumption',
    name: 'WaterConsumption',
    component: () => import('../views/WaterConsumption.vue'),
  },
];

const router = new VueRouter({
  mode: 'history',
  base: process.env.BASE_URL,
  routes,
});

export default router;
