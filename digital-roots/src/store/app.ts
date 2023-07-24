// Utilities
import { defineStore } from 'pinia'
import moment          from 'moment';

let id = 0;
export const useAppStore = defineStore('app', {
  state: () => ({
    cities: ['California', 'Colorado', 'Florida', 'Georgia', 'Texas', 'Wyoming'],
    tickets: [{
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
    //
  })
})
