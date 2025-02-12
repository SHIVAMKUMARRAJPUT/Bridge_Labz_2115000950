using System;

class Ticket {
    public int TicketID;
    public string CustomerName;
    public string MovieName;
    public int SeatNumber;
    public DateTime BookingTime;
    public Ticket Next;

    public Ticket(int ticketID, string customerName, string movieName, int seatNumber) {
        TicketID = ticketID;
        CustomerName = customerName;
        MovieName = movieName;
        SeatNumber = seatNumber;
        BookingTime = DateTime.Now;
        Next = null;
    }
}

class TicketReservationSystem {
    private Ticket head;
    private int count;

    public void AddTicket(int ticketID, string customerName, string movieName, int seatNumber) {
        Ticket newTicket = new Ticket(ticketID, customerName, movieName, seatNumber);
        if (head == null) {
            head = newTicket;
            head.Next = head;
        } else {
            Ticket temp = head;
            while (temp.Next != head) {
                temp = temp.Next;
            }
            temp.Next = newTicket;
            newTicket.Next = head;
        }
        count++;
    }

    public void RemoveTicket(int ticketID) {
        if (head == null) {
            Console.WriteLine("No tickets to remove.");
            return;
        }
        Ticket temp = head, prev = null;
        do {
            if (temp.TicketID == ticketID) {
                if (temp == head && temp.Next == head) {
                    head = null;
                } else {
                    if (temp == head) {
                        Ticket last = head;
                        while (last.Next != head) {
                            last = last.Next;
                        }
                        head = head.Next;
                        last.Next = head;
                    } else {
                        prev.Next = temp.Next;
                    }
                }
                count--;
                Console.WriteLine("Ticket removed successfully.");
                return;
            }
            prev = temp;
            temp = temp.Next;
        } while (temp != head);
        Console.WriteLine("Ticket not found.");
    }

    public void DisplayTickets() {
        if (head == null) {
            Console.WriteLine("No tickets booked.");
            return;
        }
        Ticket temp = head;
        do {
            Console.WriteLine($"Ticket ID: {temp.TicketID}, \nCustomer: {temp.CustomerName}, \nMovie: {temp.MovieName}, \nSeat: {temp.SeatNumber}, Time: {temp.BookingTime}\n");
            temp = temp.Next;
        } while (temp != head);
    }

    public void SearchTicket(string customerName, string movieName) {
        if (head == null) {
            Console.WriteLine("No tickets booked.");
            return;
        }
        Ticket temp = head;
        do {
            if (temp.CustomerName == customerName || temp.MovieName == movieName) {
                Console.WriteLine($"Found - Ticket ID: \n{temp.TicketID}, Customer: \n{temp.CustomerName}, Movie: \n{temp.MovieName}, Seat: {temp.SeatNumber}, \nTime: {temp.BookingTime}\n");
                return;
            }
            temp = temp.Next;
        } while (temp != head);
        Console.WriteLine("Ticket not found.");
    }

    public void CountTickets() {
        Console.WriteLine($"Total Booked Tickets: {count}");
    }
}

class Test9 {
    public static void Print() {
        TicketReservationSystem system = new TicketReservationSystem();

        system.AddTicket(173, "Shivam", "Inception", 5);
        system.AddTicket(135, "Aditya", "Interstellar", 10);
        system.AddTicket(154, "Ashish", "Dunkirk", 15);

        Console.WriteLine("\n=== Current Reservations ===");
        system.DisplayTickets();

        Console.WriteLine("\n=== Searching for Shivam's Ticket ===");
        system.SearchTicket("Shivam", "");

        Console.WriteLine("\n=== Removing Ticket ID 135 ===");
        system.RemoveTicket(135);

        Console.WriteLine("\n=== Final Reservations ===");
        system.DisplayTickets();
        system.CountTickets();
    }
}
