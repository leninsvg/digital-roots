// Utilities
import { defineStore } from 'pinia'

export const useAppStore = defineStore('app', {
  state: () => ({
    Tickets: [
      {
        originCity: 'Quito',
        destinationCity: 'Guayaquil',
        departureDate: '23-07-2023',
        returnDate: '28-08-2023'
      }
    ],
    //
  }),
})
