import Vue from 'vue';
import Vuex from 'vuex';
import Api from '../axios/api';

Vue.use(Vuex);

export default new Vuex.Store({
  state: {
    devices: [],
    weather: [],
    history: [],
  },
  getters: {
    firstDevice: (state) => state.devices[0] || {},
    deviceHistory: (state) => state.history || [],
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
    setHistory(state, data) {
      state.history = data;
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
    fetchHistory({ commit }) {
      Api.get('/tanks/1').then(({ data }) => {
        commit('setHistory', data.history);
      });
    },
  },
});
