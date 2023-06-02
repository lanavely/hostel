import { hostelSeviceUrl } from '../config/default'

export function fetchBookingsAsync() {
    return fetch(`${hostelSeviceUrl}/Bookings`)
}
