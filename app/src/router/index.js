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
  {
    path: '/about',
    name: 'About',
    // route level code-splitting
    // this generates a separate chunk (about.[hash].js) for this route
    // which is lazy-loaded when the route is visited.
    component: () => import(/* webpackChunkName: "about" */ '../views/About.vue'),
  },
];

const router = new VueRouter({
  mode: 'history',
  base: process.env.BASE_URL,
  routes,
});

export default router;
