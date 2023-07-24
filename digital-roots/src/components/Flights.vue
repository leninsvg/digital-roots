<script setup lang="ts">
import { useRoute } from 'vue-router';
import moment       from 'moment/moment';

const route = useRoute()
let id = 0;
const flights = [{
  id: id++,
  date: moment().format('YYYY-MM-DD'),
  origin: 'California',
  destination: 'Colorado',
  price: 200,
  airline: 'Tame',
  scales: 1,
  duration: 20
}, {
  id: id++,
  date: moment().format('YYYY-MM-DD'),
  origin: 'California',
  destination: 'Colorado',
  price: 200,
  airline: 'Tame',
  scales: 1,
  duration: 20
}, {
  id: id++,
  date: moment().format('YYYY-MM-DD'),
  origin: 'California',
  destination: 'Colorado',
  price: 200,
  airline: 'Tame',
  scales: 1,
  duration: 20
}, {
  id: id++,
  date: moment().format('YYYY-MM-DD'),
  origin: 'California',
  destination: 'Colorado',
  price: 200,
  airline: 'Tame',
  scales: 1,
  duration: 20
}, {
  id: id++,
  date: moment().format('YYYY-MM-DD'),
  origin: 'California',
  destination: 'Colorado',
  price: 200,
  airline: 'Tame',
  scales: 1,
  duration: 20
}, {
  id: id++,
  date: moment().format('YYYY-MM-DD'),
  origin: 'California',
  destination: 'Colorado',
  price: 200,
  airline: 'Tame',
  scales: 1,
  duration: 20
}, {
  id: id++,
  date: moment().format('YYYY-MM-DD'),
  origin: 'California',
  destination: 'Colorado',
  price: 200,
  airline: 'Tame',
  scales: 1,
  duration: 20
}, {
  id: id++,
  date: moment().format('YYYY-MM-DD'),
  origin: 'California',
  destination: 'Colorado',
  price: 200,
  airline: 'Tame',
  scales: 1,
  duration: 20
}]
const origin = route.params.origin;
const destination = route.params.destination;
const startDate = route.params.startDate;
const returnDate = route.params.returnDate;
</script>

<template>
  <v-btn :to="'/'">Change filter</v-btn>
  <div class="d-flex">
    <div>
      <h1>Departure</h1>
      <v-card
        v-for="flight in flights.filter(x => x.origin === origin &&  x.destination === destination  && x.date === startDate)"
        :key="flight.id"
        :title="`${flight.price}$`"
        width="400"
        subtitle="This is a subtitle"
        text="This is content"
        class="ma-4"
      ></v-card>
    </div>
    <div>
      <h1>Return</h1>
      <v-card
        v-for="flight in flights.filter(x => x.origin === origin &&  x.destination === destination  && x.date === returnDate)"
        :key="flight.id"
        :title="`${flight.price}$`"
        width="400"
        subtitle="This is a subtitle"
        text="This is content"
        class="ma-4"
      ></v-card>
    </div>


  </div>
</template>
<style scoped>

</style>
