import React, { useEffect, useState } from 'react';
import { useSelector, useDispatch } from 'react-redux';
import {
    selectBookings,
    loadBookings
} from '../modules/booking-list/bookingsSlice';
import styles from './bookings.module.css';

export function Bookings() {
  const bookings = useSelector(selectBookings)
  const dispatch = useDispatch();

  useEffect(() => {
    dispatch(loadBookings())
  }, [])

  return (
    <div>
        <ul>
            { bookings.map(b => (<li key={b.id}>{b.name}</li>)) }
        </ul>
    </div>
  );
}
