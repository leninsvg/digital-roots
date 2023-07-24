<script setup lang="ts">
import { ref }         from 'vue';
import router          from '@/router';
import moment          from 'moment';
import { useAppStore } from '@/store/app';

const originCity = ref('');
const destinationCity = ref('');
const startDate = ref(new Date());
const returnDate = ref(new Date());
const state = useAppStore()
const cities = state.cities;
const search = () => {
  router.push({
    name: 'FlightsPage',
    params: {
      origin: originCity.value,
      destination: destinationCity.value,
      startDate: moment(startDate.value).format('YYYY-MM-DD'),
      returnDate: moment(returnDate.value).format('YYYY-MM-DD')
    }
  })
}
</script>

<template>
  <div class="ma-4 d-inline">
    Input the filter for continue
    <v-btn :disabled="!originCity || !destinationCity || !startDate || !returnDate" @click="search">
      Search
    </v-btn>
  </div>
  <div class="d-flex">
    <v-select class="ma-4" v-model="originCity" label="Origin city"
              :items="cities.filter(x => x !== destinationCity)"></v-select>
    <v-select class="ma-4" v-model="destinationCity" label="Destination city"
              :items="cities.filter(x => x !== originCity)"></v-select>
  </div>
  <div class="d-flex text-center">
    <v-date-picker class="ma-4" v-model="startDate"></v-date-picker>
    <v-date-picker class="ma-4" v-model="returnDate"></v-date-picker>
  </div>
</template>

<style scoped>

</style>
