import { configureStore } from '@reduxjs/toolkit';
import counterReducer from '../features/counter/counterSlice';
import bookingsReducer from '../modules/booking-list/bookingsSlice.js'

export const store = configureStore({
  reducer: {
    counter: counterReducer,
    bookings: bookingsReducer
  },
});
