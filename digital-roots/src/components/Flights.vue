<script setup lang="ts">
import { useRoute }    from 'vue-router';
import { useAppStore } from '@/store/app';
import { ref }         from 'vue';

const route = useRoute()
const state = useAppStore()

const departureTicket = ref(null);
const returnTicket = ref(null);
const flights = state.tickets;
const origin = route.params.origin;
const destination = route.params.destination;
const startDate = route.params.startDate;
const returnDate = route.params.returnDate;
const departureFlights = flights.filter(x => x.origin === origin && x.destination === destination && x.date === startDate);
const returnFlights = flights.filter(x => x.origin === origin && x.destination === destination && x.date === returnDate);

</script>

<template>
  <v-btn :to="'/'">Change filter</v-btn>
  <v-btn :to="`/flight-detail/${departureTicket}/${returnTicket}`">Continue</v-btn>
  <div v-if="departureFlights.length && returnFlights.length" class="d-flex">
    <div>
      <h1>Departure</h1>
      <v-card
        v-for="flight in departureFlights"
        @click="departureTicket = flight.id"
        :key="flight.id"
        :title="`${flight.airline} ${flight.price}$`"
        :subtitle="`${flight.duration} hours - ${flight.scales} scales`"
        :text="`${flight.origin} to ${flight.destination}`"
        width="400"
        class="ma-4"
      ></v-card>
    </div>
    <div>
      <h1>Return</h1>
      <v-card
        v-for="flight in returnFlights"
        @click="returnTicket = flight.id"
        :key="flight.id"
        :title="`${flight.airline} ${flight.price}$`"
        :subtitle="`${flight.duration} hours - ${flight.scales} scales`"
        :text="`${flight.origin} to ${flight.destination}`"
        width="400"
        class="ma-4"
      ></v-card>
    </div>
  </div>
  <div v-if="!departureFlights.length || !returnFlights.length">
    <h1>No flights</h1>
  </div>
</template>
<style scoped>

</style>
