// See https://aka.ms/new-console-template for more information
using SOA3_CinemaCasus;

Movie MeanGirls = new Movie("MeanGirls");
MovieScreening MeanGrillsScreening1 = new MovieScreening(new DateTime(2024, 02, 02, 20, 00, 00), 8.5, MeanGirls);


MeanGirls.AddScreening(MeanGrillsScreening1);
Order Order1 = new Order(1, true);

Order1.AddSeatReservation(new MovieTicket(1, 1, true, MeanGrillsScreening1));
Order1.AddSeatReservation(new MovieTicket(1, 2, true, MeanGrillsScreening1));
Order1.AddSeatReservation(new MovieTicket(1, 3, true, MeanGrillsScreening1));
Order1.AddSeatReservation(new MovieTicket(1, 4, true, MeanGrillsScreening1));
Console.WriteLine(Order1.CalculatePrice());

MovieScreening MeanGrillsScreening2 = new MovieScreening(new DateTime(2024, 02, 01, 20, 00, 00), 8.5, MeanGirls);
MeanGirls.AddScreening(MeanGrillsScreening2);
Order Order2 = new Order(2, false);

Order2.AddSeatReservation(new MovieTicket(1, 1, false, MeanGrillsScreening2));
Order2.AddSeatReservation(new MovieTicket(1, 2, true, MeanGrillsScreening2));
Order2.AddSeatReservation(new MovieTicket(1, 3, true, MeanGrillsScreening2));
Order2.AddSeatReservation(new MovieTicket(1, 4, true, MeanGrillsScreening2));
Console.WriteLine(Order2.CalculatePrice());

Order1.Export(TicketExportFormat.PLAINTEXT);
Order2.Export(TicketExportFormat.JSON);

