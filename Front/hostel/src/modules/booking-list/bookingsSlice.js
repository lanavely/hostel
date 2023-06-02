import { createAsyncThunk, createSlice } from '@reduxjs/toolkit';
import { fetchBookingsAsync } from '../../api/hostelApi';


const initialState = {
    status: 'idle',
    bookings: [{
        id: 1,
        name: "245"
    }, {
        id: 2,
        name: "246"
    }]
  };
  
export const loadBookings = createAsyncThunk(
'bookings/load',
async () => {
    const response = await fetchBookingsAsync();
    return await response.json();
}
);

export const selectBookings = state => state.bookings.bookings;

export const bookingsSlice = createSlice({
    name: 'bookings',
    initialState,
    extraReducers: (builder) => {
        builder.addCase(loadBookings.pending, (state) => {
            state.status = 'loading'
        })
        builder.addCase(loadBookings.fulfilled, (state, action) => {
            state.status = 'idle';
            console.log(action.payload)
            state.bookings = action.payload;
        })
    }
}
)

export default bookingsSlice.reducer

