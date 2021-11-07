<template>
  <v-container fluid>
    <v-row>
      <v-col cols="12" class="px-0 pt-1">
        <highcharts
          class="hc"
          :options="chartOptions"
          ref="chart"
        />
      </v-col>
    </v-row>
  </v-container>
</template>

<script>
export default {
  name: 'Stats',
  computed: {
    currentTankHistory() {
      return this.$store.getters.deviceHistory;
    },
    balanceSeries() {
      const { currentTankHistory } = this;
      const data = currentTankHistory
        .map((item) => [item.date.substr(0, 10), Math.round(item.balance)]);
      return ({
        name: 'Zapełnienie',
        data,
      });
    },
    consumptionSeries() {
      const { currentTankHistory } = this;
      const data = currentTankHistory
        .map((item) => [item.date.substr(0, 10), Math.round(item.amountConsumption)]);
      return ({
        name: 'Zużycie',
        data,
      });
    },
    collectedSeries() {
      const { currentTankHistory } = this;
      const data = currentTankHistory
        .map((item) => [item.date.substr(0, 10), Math.round(item.amountCollected)]);
      return ({
        name: 'Zebrano',
        data,
      });
    },
    chartOptions() {
      const { balanceSeries, consumptionSeries, collectedSeries } = this;
      return ({
        series: [
          balanceSeries,
          consumptionSeries,
          collectedSeries,
        ],
        title: null,
        chart: {
          backgroundColor: '#f2f2f2',
        },
        yAxis: {
          title: {
            text: 'Ilość w litrach',
          },
          labels: {
            // eslint-disable-next-line
            // formatter: function() {
            //   return `${this.value}l`;
            // },
          },
        },
      });
    },
  },
};
</script>

<style lang="scss">
.highcharts-container {
  width: 100% !important;
}
</style>
