<template>
    <v-container>
        <div class="pb-5">
            <h2>
                Oblicz swój potencjał oszczędzania wody
            </h2>
        </div>
        <div>
            <form @submit.prevent="submit">
                <h4>Prognozowana objętość zebranej deszczówki</h4>
                <v-container>
                    <v-row>
                        <v-col cols="4">
                            <v-text-field v-model="amountOfRainfall"
                            label="Średnia wielkość opadów w ciągu roku"
                            placeholder="Wartość w mm"
                            >
                            </v-text-field>
                        </v-col>
                        <v-col cols="4">
                            <v-text-field v-model="effectiveSizeOfRoofArea"
                            label="Efektywna wielkość powierzchni dachu"
                            placeholder="Rzut poziomy powierzchni dachu"
                            >
                            </v-text-field>
                        </v-col>
                        <v-col cols="4">
                            <v-select v-model="roofType"
                            label="Typ dachu"
                            :items="items"
                            @change = "Change()"
                            >
                            </v-select>
                        </v-col>
                    </v-row>
                </v-container>
                <v-container>
                    <v-row>
                        <v-col cols="4">
                            <v-text-field v-model="amountOfPeople"
                            label="Liczba domowników"
                            >
                            </v-text-field>
                        </v-col>
                        <v-col cols="4">
                            <v-checkbox v-model="ifWateringGarden"
                            label="Czy podlewasz ogród?"
                            >
                            </v-checkbox>
                        </v-col>
                        <v-col cols="4">
                            <v-text-field v-model="gardenArea"
                            label="Powierzchnia ogrodu"
                            placeholder="Wartoś w m2"
                            :disabled="!ifWateringGarden"
                            >
                            </v-text-field>
                        </v-col>
                    </v-row>
                </v-container>
                <v-container>
                    <div class="div-loc">
                    <v-btn
                            @click="Calculate"
                            class="location"
                            :disabled="shouldBeDisabled"
                            >
                            Przelicz
                            </v-btn>
                    </div>
                </v-container>
            </form>
        </div>
        <v-row v-show="isCounted">
            <v-col cols="12">
                <h2>Twoje wyniki</h2>
            </v-col>
            <v-col cols="4">
                <v-card>
                    <v-card-title>Roczna iloś wody deszczowej</v-card-title>
                    <v-card-text><b>{{this.annualRainfall}} l/rok</b></v-card-text>
                </v-card>
            </v-col>
            <v-col cols="4">
                <v-card>
                    <v-card-title>Roczne zapotrzebowanie na wodę</v-card-title>
                    <v-card-text><b>{{this.annualWaterRequirements}} l/rok</b></v-card-text>
                </v-card>
            </v-col>
            <v-col cols="4">
                <v-card>
                    <v-card-title>Zalecana wielkoś zbiornika na wodę</v-card-title>
                    <v-card-text><b>{{this.sizeOfTank}} l</b></v-card-text>
                </v-card>
            </v-col>
        </v-row>
    </v-container>
</template>

<script>

export default {
  name: 'Savings',
  data: () => ({
    amountOfRainfall: '',
    effectiveSizeOfRoofArea: '',
    roofType: '',
    items: [
      'skośny pokryty blachą / dachówką ceramiczną glazurowaną',
      'skośny pokryty dachówką betonową',
      'płaski z płyty warstwowej',
      'płaski pokryty papą',
      'zielony',
    ],
    amountOfPeople: '',
    ifWateringGarden: false,
    annualRainfall: '',
    annualWaterRequirements: '',
    sizeOfTank: '',
    runoffCoefficient: '',
    gardenArea: '',
    isCounted: false,
  }),
  computed: {
    shouldBeDisabled() {
      return (this.amountOfRainfall === '' || this.effectiveSizeOfRoofArea === '' || this.roofType === ''
      || this.amountOfPeople === '' || (this.ifWateringGarden === true && this.gardenArea === ''));
    },
  },
  methods: {
    Calculate() {
      const activities = 13500;
      this.annualRainfall = this.amountOfRainfall * this.effectiveSizeOfRoofArea
      * this.runoffCoefficient;
      this.annualWaterRequirements = activities * this.amountOfPeople;
      if (this.ifWateringGarden) {
        this.annualWaterRequirements += 60 * this.gardenArea;
      }
      this.sizeOfTank = (((this.annualRainfall / 2)
      + ((this.annualWaterRequirements * 21) / 356)) / 100) * 5;
      console.log(this.sizeOfTank);
      this.sizeOfTank += (1000 - (this.sizeOfTank % 1000));
      console.log(this.sizeOfTank);
      this.isCounted = true;
    },
    Change() {
      switch (this.roofType) {
        case 'skośny pokryty blachą / dachówką ceramiczną glazurowaną':
          this.runoffCoefficient = 0.9;
          break;
        case 'skośny pokryty dachówką betonową':
          this.runoffCoefficient = 0.8;
          break;
        case 'płaski z płyty warstwowej':
          this.runoffCoefficient = 0.7;
          break;
        case 'płaski pokryty papą':
          this.runoffCoefficient = 0.6;
          break;
        case 'zielony':
          this.runoffCoefficient = 0.35;
          break;
        default:
          this.runoffCoefficient = 0;
      }
    },
  },
};
</script>

<style lang="scss" scoped>
    .location {
        margin-top: 20px;
        width: 25%;
    }
    .div-loc {
        display: flex;
        justify-content: flex-end;
    }
</style>
