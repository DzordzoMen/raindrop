<template>
    <v-container>
        <v-row dense>
            <v-col cols="12">
                <h2>Do czego chcesz używać deszczówki?</h2>
            </v-col>
            <v-col cols="12">
                To pierwsze pytanie ma duży wpływ na wybór zbiornika. Niewielki zbiornik
                (około 300 l) powinien wystarczyć dla małego gospodarstwa, które chce
                wykorzystywać wodę z opadów do toalety oraz pralki. W przypadku celów ogrodowych
                wskazane są już znacznie większe zbiorniki (1000 - 1500 l). Jest to kwestia mocno
                indywidualna, warto ją przemyśleć oraz skorzystać z pomocy kalkulatora doboru
                zbiornika lub porady eksperta.
            </v-col>
            <v-col cols="12" class="pt-4">
                <h2>Jaki zbiornik wybrać?</h2>
            </v-col>
            <v-col cols="12">
                Istnieją dwa typy zbiorników: nadziemny i podziemny. Główna różnica (poza
                lokalizacją) to możliwa objętość. Maksymalna ilość wody jaką można zmieścić do
                dostępnych obecnie w sprzedaży pojemników naziemnych to około 800 litrów. Zbiorniki
                podziemne są o wiele większe. Ich możliwości są ograniczone jedynie wielkością
                działki, ponieważ można łączyć ze sobą takie zbiorniki pod powierzchnią.
            </v-col>
            <v-col cols="12">
                Warto również zwrócić uwagę na okres gwarancji zbiornika. Dłuższa gwarancja
                wskazuje, że producent jest pewniejszy swojego produktu. W przypadku zbiorników
                podziemnych istotna jest również informacja pod jaką warstwą ziemi zbiornik może być
                zasypany.
            </v-col>
            <v-col cols="12" class="pt-4">
                <h2>Jak zamontować?</h2>
            </v-col>
            <v-row>
                <v-col cols="6">
                    <v-col cols="12">
                W przypadku <b>zbiornika nadziemnego</b> kluczowe jest poprawne połączenie z rynną.
                Bardzo często w sklepach ogrodniczych można kupić całe komplety, a obsługa służy
                radą i pomocą, co dokładnie kupić, aby kompletnie zamontować zbiornik. W
                zdecydowanej większości przypadków poradzi sobie z tym nawet osoba bez większej
                wiedzy technicznej.
                    </v-col>
                    <v-col cols="12">
                W celu zamontowania <b>zbiornika podziemnego</b>, musimy najpierw wybrać odpowiednią
                lokalizację. Kluczowe jest, czy w wybranym przez nas miejscu pod ziemią, nie czekają
                na nas niespodzianki w postaci przewodów, rur, gazu, czy nawet korzeni drzew.
                Istotne jest również oddalenie od innych działek oraz czy zbiornik nie ma być
                zamontowany tak, gdzie odbywa się ruch samochodowy - wtedy trzeba się upewnić, czy
                ma on odpowiednie właściwości i jest odpowiednio wytrzymały.
                    </v-col>
                    <v-col cols="12">
                Wykop musi mieć stabilne ściany oraz podsypkę pod zbiornik. Kiedy wykop jest już
                przygotowany, należy ostrożnie umieścić w nim zbiornik. Następnie trzeba go
                odpowiednio wypoziomować. Zbiornik nie może zmieniać swojej pozycji, więc
                wypoziomowanie będzie musiało być powtarzane do skutku, aż cały zbiornik nie
                zostanie pokryty ziemią.Kolejnym krokiem jest wypełnienie zbiornika wodą. Ostatnim
                etapem jest przyłączanie dopływu i odpływu. Warto powierzyć to zadanie fachowcom,
                ponieważ trzeba zrobić to umiejętnie, aby zbiornik służył przez wiele lat.
                    </v-col>
                </v-col>
                <v-col cols="6" class="pt-8">
                    <v-row>
                        <v-col cols="12">
                           <v-img
                        alt="Undergrand tank"
                        src="../assets/zbiornik-podziemny.jpg"
                            ></v-img>
                        </v-col>
                        <v-col cols="12" class="source">
                            Źródło: <a href="https://waterspec.pl">Waterspec</a>
                        </v-col>
                    </v-row>
                </v-col>
            </v-row>
        </v-row>
    </v-container>
</template>

<style lang="scss" scoped>
    .source {
        display: flex;
        justify-content: right;
        margin-top: -15px;
        font-size: 0.75rem;
        color: grey;
        a {
            color: grey;
        }
    }
</style>
