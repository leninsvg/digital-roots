<script setup lang="ts">
import { ref } from 'vue';
import router  from '@/router';
import moment  from 'moment';
import { useAppStore } from '@/store/app';

const originCity = ref('California');
const destinationCity = ref('Colorado');
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
  <div>
    <v-select v-model="originCity" label="Origin city" :items="cities.filter(x => x !== destinationCity)"></v-select>
    <v-select v-model="destinationCity" label="Destination city"
              :items="cities.filter(x => x !== originCity)"></v-select>
    <v-row>
      <v-date-picker v-model="startDate"></v-date-picker>
      <v-date-picker v-model="returnDate"></v-date-picker>
    </v-row>
    <v-btn @click="search">Search</v-btn>
  </div>
</template>

<style scoped>

</style>
