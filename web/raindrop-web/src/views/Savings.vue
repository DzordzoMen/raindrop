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
                            @input = "$v.amountOfRainfall.$model = $event"
                            >
                            </v-text-field>
                        </v-col>
                        <v-col cols="4">
                            <v-text-field v-model="effectiveSizeOfRoofArea"
                            label="Efektywna wielkość powierzchni dachu"
                            placeholder="Rzut poziomy powierzchni dachu"
                            @input = "$v.effectiveSizeOfRoofArea.$model = $event"
                            >
                            </v-text-field>
                        </v-col>
                        <v-col cols="4">
                            <v-select v-model="roofType"
                            label="Typ dachu"
                            :items="items"
                            @select = "$v.roofType.$model = $event"
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
                            @input = "$v.amountOfPeople.$model = $event"
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
  }),
  computed: {
    shouldBeDisabled() {
      return (this.amountOfRainfall === '' || this.effectiveSizeOfRoofArea === '' || this.roofType === ''
      || this.amountOfPeople === '' || (this.ifWateringGarden === true && this.gardenArea === ''));
    },
  },
  methods: {
    Calculate() {
      // const activities = 13500;
      this.annualRainfall = this.amountOfRainfall * this.effectiveSizeOfRoofArea
      * this.runoffCoefficient;
    },
    Change() {
      console.log(this.roofType);
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
