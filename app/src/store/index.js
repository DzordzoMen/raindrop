import Vue from 'vue';
import Vuex from 'vuex';
import Api from '../axios/api';

Vue.use(Vuex);

export default new Vuex.Store({
  state: {
    devices: [],
    weather: [],
  },
  getters: {
    firstDevice: (state) => state.devices[0] || {},
    allWeather: (state) => state.weather || [],
    currentWeather: (state) => state.weather[0] || {},
  },
  mutations: {
    setDevices(state, data) {
      state.devices = data;
    },
    setWeather(state, data) {
      state.weather = data;
    },
  },
  actions: {
    fetchDevices({ commit }) {
      Api.get('/tanks').then(({ data }) => {
        commit('setDevices', data);
      });
    },
    fetchWeather({ commit }) {
      Api.get('/weatherForecast').then(({ data }) => {
        commit('setWeather', data);
      });
    },
  },
});
