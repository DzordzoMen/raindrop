import Vue from 'vue';
import VueRouter from 'vue-router';
import Home from '../views/Home.vue';
import Rainwater from '../views/Rainwater.vue';
import Devices from '../views/Devices.vue';
import Weather from '../views/Weather.vue';

Vue.use(VueRouter);

const routes = [
  {
    path: '/',
    name: 'Home',
    component: Home,
  },
  {
    path: '/rainwater',
    name: 'Rainwater',
    component: Rainwater,
  },
  {
    path: '/devices',
    name: 'Devices',
    component: Devices,
  },
  {
    path: '/weather',
    name: 'Weather',
    component: Weather,
  },
];

const router = new VueRouter({
  mode: 'history',
  base: process.env.BASE_URL,
  routes,
});

export default router;
