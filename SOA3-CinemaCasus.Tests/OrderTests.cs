namespace SOA3_CinemaCasus.Tests
{

    public class OrderTests
    {
        private Movie Movie = new("Title");
        [Fact]
        public void CalculatePrice_With_No_Tickets()
        {
            // Arange
            Order order = new(1, false);

            // Act
            double result = order.CalculatePrice();

            // Assert
            Assert.Equal(0, result);
        }

        [Fact]
        public void CalculatePrice_With_StudentOrder()
        {
            // Arange
            Order order = new(1, true);
            MovieScreening screening = new(new DateTime(2024, 02, 02, 20, 00, 00), 8.5, this.Movie);
            MovieTicket ticket = new(1, 1, false, screening);
            order.AddSeatReservation(ticket);
            MovieTicket ticket2 = new(1, 2, false, screening);
            order.AddSeatReservation(ticket2);

            // Act
            double result = order.CalculatePrice();

            // Assert
            Assert.Equal(8.5, result);
        }

        [Fact]
        public void CalculatePrice_With_RegularOrder_On_Weekend()
        {
            // Arange
            Order order = new(1, false);
            MovieScreening screening = new(new DateTime(2024, 02, 03, 20, 00, 00), 8.5, this.Movie);
            MovieTicket ticket = new(1, 1, false, screening);
            order.AddSeatReservation(ticket);
            MovieTicket ticket2 = new(1, 2, false, screening);
            order.AddSeatReservation(ticket2);

            // Act
            double result = order.CalculatePrice();

            // Assert
            Assert.Equal(17, result);
        }

        [Fact]
        public void CalculatePrice_With_RegularOrder_On_Weekday()
        {
            // Arange
            Order order = new(1, false);
            MovieScreening screening = new(new DateTime(2024, 02, 01, 20, 00, 00), 8.5, this.Movie);
            MovieTicket ticket = new(1, 1, false, screening);
            order.AddSeatReservation(ticket);
            MovieTicket ticket2 = new(1, 2, false, screening);
            order.AddSeatReservation(ticket2);

            // Act
            double result = order.CalculatePrice();

            // Assert
            Assert.Equal(8.5, result);
        }

        [Fact]
        public void CalculatePrice_With_RegularOrder_On_Weekend_With_Premium_Ticket()
        {
            // Arange
            Order order = new(1, false);
            MovieScreening screening = new(new DateTime(2024, 02, 03, 20, 00, 00), 8.5, this.Movie);
            MovieTicket ticket = new(1, 1, true, screening);
            order.AddSeatReservation(ticket);
            MovieTicket ticket2 = new(1, 2, true, screening);
            order.AddSeatReservation(ticket2);

            // Act
            double result = order.CalculatePrice();

            // Assert
            Assert.Equal(23, result);
        }

        [Fact]
        public void CalculatePrice_With_StudentOrder_On_Weekend_With_Premium_Ticket()
        {
            // Arange
            Order order = new(1, true);
            MovieScreening screening = new(new DateTime(2024, 02, 01, 20, 00, 00), 8.5, this.Movie);
            MovieTicket ticket = new(1, 1, true, screening);
            order.AddSeatReservation(ticket);
            MovieTicket ticket2 = new(1, 2, true, screening);
            order.AddSeatReservation(ticket2);

            // Act
            double result = order.CalculatePrice();

            // Assert
            Assert.Equal(10.5, result);
        }

        [Fact]
        public void CalculatePrice_With_RegularOrder_And_PremiumTicket_And_6Tickets()
        {
            // Arange
            Order order = new(1, false);
            MovieScreening screening = new(new DateTime(2024, 02, 02, 20, 00, 00), 8.5, this.Movie);
            MovieTicket ticket = new(1, 1, true, screening);
            order.AddSeatReservation(ticket);
            MovieTicket ticket2 = new(1, 2, true, screening);
            order.AddSeatReservation(ticket2);
            MovieTicket ticket3 = new(1, 3, true, screening);
            order.AddSeatReservation(ticket3);
            MovieTicket ticket4 = new(1, 4, true, screening);
            order.AddSeatReservation(ticket4);
            MovieTicket ticket5 = new(1, 5, true, screening);
            order.AddSeatReservation(ticket5);
            MovieTicket ticket6 = new(1, 6, true, screening);
            order.AddSeatReservation(ticket6);

            // Act
            double result = order.CalculatePrice();

            // Assert
            Assert.Equal(62.1, result);
        }

        [Fact]
        public void CalculatePrice_With_StudentOrder_And_PremiumTicket_And_6Tickets()
        {
            // Arange
            Order order = new(1, true);
            MovieScreening screening = new(new DateTime(2024, 02, 02, 20, 00, 00), 8.5, this.Movie);
            MovieTicket ticket = new(1, 1, true, screening);
            order.AddSeatReservation(ticket);
            MovieTicket ticket2 = new(1, 2, true, screening);
            order.AddSeatReservation(ticket2);
            MovieTicket ticket3 = new(1, 3, true, screening);
            order.AddSeatReservation(ticket3);
            MovieTicket ticket4 = new(1, 4, true, screening);
            order.AddSeatReservation(ticket4);
            MovieTicket ticket5 = new(1, 5, true, screening);
            order.AddSeatReservation(ticket5);
            MovieTicket ticket6 = new(1, 6, true, screening);
            order.AddSeatReservation(ticket6);

            // Act
            double result = order.CalculatePrice();

            // Assert
            Assert.Equal(31.5, result);
        }

        [Fact]
        public void CalculatePrice_With_StudentOrder_And_Regular_And_PremiumTickets()
        {
            // Arange
            Order order = new(1, true);
            MovieScreening screening = new(new DateTime(2024, 02, 02, 20, 00, 00), 8.5, this.Movie);
            MovieTicket ticket = new(1, 1, true, screening);
            order.AddSeatReservation(ticket);
            MovieTicket ticket2 = new(1, 2, true, screening);
            order.AddSeatReservation(ticket2);
            MovieTicket ticket3 = new(1, 3, true, screening);
            order.AddSeatReservation(ticket3);
            MovieTicket ticket4 = new(1, 4, false, screening);
            order.AddSeatReservation(ticket4);
            MovieTicket ticket5 = new(1, 5, true, screening);
            order.AddSeatReservation(ticket5);
            MovieTicket ticket6 = new(1, 6, false, screening);
            order.AddSeatReservation(ticket6);

            // Act
            double result = order.CalculatePrice();

            // Assert
            Assert.Equal(31.5, result);
        }

        [Fact]
        public void OrderState_On_Creation()
        {
            // Arrange
            Order Order = new Order(1, false);

            // Act

            // Assert
            Assert.IsType<NoOrderState>(Order.State);
        }

        [Fact]
        public void OrderState_After_Adding_Reservation()
        {
            // Arrange
            Order Order = new Order(1, false);
            MovieScreening Screening = new(new DateTime(2024, 02, 02, 20, 00, 00), 10, this.Movie);
            MovieTicket Ticket = new(1, 1, false, Screening);

            // Act
            Order.AddSeatReservation(Ticket);

            // Assert
            Assert.IsType<UnestablishedOrderState>(Order.State);
        }


    }
}