using FlightTest;
using Domain;
using FluentAssertions;

namespace FlightTest
{
    public class FlightSpecifications
    {
        [Fact]
        public void Booking_reduces_the_number_of_seats()
        {
            var flight = new Flight(seatCapacity: 3);

            flight.Book("jack@email.com", 1);

            flight.RemainingNumberOfSeats.Should().Be(2);
        }

        [Fact]
        public void Avoid_OverBooking()
        {
            // Given 
            var flight = new Flight(seatCapacity: 3);

            // When 
            var error = flight.Book("jack@email.com", 4);

            // Then
            error.Should().BeOfType<OverBookingError>();
        }
    }
}