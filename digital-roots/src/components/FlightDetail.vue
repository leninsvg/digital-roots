<script setup lang="ts">
import { useRoute }    from 'vue-router';
import { useAppStore } from '@/store/app';
import router          from '@/router';

const route = useRoute()
const state = useAppStore()

const departureTicket: any = state.tickets.find(x => x.id == route.params.departureTicket);
const returnTicket: any = state.tickets.find(x => x.id == route.params.returnTicket);
</script>

<template>
  <div>
    <v-btn  @click="router.back()" :disabled="!departureTicket || !returnTicket">Change tickets</v-btn>
    <div>
      <h1>Origin</h1>
      <v-card
        :key="departureTicket.id"
        :title="`${departureTicket.date} | ${departureTicket.airline} ${departureTicket.price}$`"
        :subtitle="`${departureTicket.duration} hours - ${departureTicket.scales} scales`"
        :text="`${departureTicket.origin} to ${departureTicket.destination}`"
        width="400"
        class="ma-4"
      ></v-card>

    </div>
    <div>
      <h1>Destination</h1>
      <v-card
        :title="`${departureTicket.date} | ${returnTicket.airline} ${returnTicket.price}$`"
        :subtitle="`${returnTicket.duration} hours - ${returnTicket.scales} scales`"
        :text="`${returnTicket.origin} to ${returnTicket.destination}`"
        width="400"
        class="ma-4"
      ></v-card>
    </div>
  </div>
</template>

<style scoped>

</style>
