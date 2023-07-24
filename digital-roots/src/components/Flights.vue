<script setup lang="ts">
import { useRoute }    from 'vue-router';
import { useAppStore } from '@/store/app';
import { ref }         from 'vue';
import router          from '@/router';

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
const returnFlights = flights.filter(x => x.origin === destination && x.destination === origin && x.date === returnDate);

</script>

<template>
  <v-btn @click="router.back()">Change filter</v-btn>
  <div>
    Please select the tickets for continue
  </div>
  <v-btn :to="`/flight-detail/${departureTicket}/${returnTicket}`" :disabled="!departureTicket || !returnTicket">
    Continue
  </v-btn>
  <div v-if="departureFlights.length && returnFlights.length" class="d-flex">
    <div>
      <h1>Departure {{ startDate }}</h1>
      <v-card
        v-for="flight in departureFlights"
        @click="departureTicket = flight.id"
        :key="flight.id"
        :title="`${flight.airline} ${flight.price}$`"
        :subtitle="`${flight.duration} hours - ${flight.scales} scales`"
        :text="`${flight.origin} to ${flight.destination}`"
        :class="{'bg-amber': flight.id === departureTicket}"
        width="400"
        class="ma-4"
      ></v-card>
    </div>
    <div>
      <h1>Return {{ returnDate }}</h1>
      <v-card
        v-for="flight in returnFlights"
        @click="returnTicket = flight.id"
        :key="flight.id"
        :title="`${flight.airline} ${flight.price}$`"
        :subtitle="`${flight.duration} hours - ${flight.scales} scales`"
        :text="`${flight.origin} to ${flight.destination}`"
        :class="{'bg-blue-grey': flight.id === returnTicket}"
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
