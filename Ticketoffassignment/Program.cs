// See https://aka.ms/new-console-template for more information



using Ticketoffassignment;

    Console.WriteLine("Welcome to the Ticket Booking!");
    Console.WriteLine("");
    int age = Class1.GetAge();
    string place = Class1.GetTicket();
    int price = Class1.PriceSetter(age, place);
    decimal tax = Class1.TaxCalculator(price);
    int ticketNumber = Class1.TicketNumberGenerator();
    Console.WriteLine("");
    Console.WriteLine("Ticket Details:");
    Console.WriteLine($"Age: {age} years");
    Console.WriteLine($"Place preference: {place}");
    Console.WriteLine($"Total Price: {price} SEK");
    Console.WriteLine($"Tax (6%): {tax} SEK");
    Console.WriteLine($"Ticket Number: {ticketNumber}");
    Console.WriteLine("");
    Console.WriteLine("Thank you for booking!");


   

    


