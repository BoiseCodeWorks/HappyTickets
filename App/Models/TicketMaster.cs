using System;
using System.Collections.Generic;

namespace ticketHappy.Models
{
    class TicketMaster
    {
        private List<Ticket> Tickets { get; set; }

        public void AddTicket()
        {
            Console.Write("Ticket Title: ");
            string title = Console.ReadLine();
            Console.Write("Ticket Description: ");
            string description = Console.ReadLine();
            Ticket newTicket = new Ticket(title, description);
            Tickets.Add(newTicket);
            Console.Clear();
            Console.WriteLine("Added Ticket Successfully");
        }

        public void RemoveTicket(string index)
        {
            Ticket toRemove = ValidateTicket(index);
            if (toRemove == null)
            {
                return;
            }
            Tickets.Remove(toRemove);
            System.Console.WriteLine("REMOVED TICKET");
        }
        private void RemoveTicket(Ticket ticket)
        {
            Tickets.Remove(ticket);
        }

        private Ticket ValidateTicket(string index)
        {
            int tIndex;
            if (Int32.TryParse(index, out tIndex) && tIndex > 0 && tIndex <= Tickets.Count)
            {
                return Tickets[tIndex - 1];
            }
            Console.Clear();
            System.Console.WriteLine("INVALID SELECTION");
            return null;
        }

        public void ViewDetails()
        {
            Console.Write("Ticket Number: ");
            string index = Console.ReadLine();
            Ticket ticket = ValidateTicket(index);
            if (ticket == null)
            {
                return;
            }
            Console.Clear();
            System.Console.WriteLine($@"
Title       Description
-------------------------
{ticket.Title}  {ticket.Description}

Press (C) to close, any other key to return to the main menu
            ");
            ConsoleKeyInfo key = Console.ReadKey();
            Console.Clear();
            if (key.KeyChar == 'c')
            {
                RemoveTicket(ticket);
                System.Console.WriteLine("TICKET CLOSED");
            }
        }



        public void ViewTickets()
        {
            System.Console.WriteLine($@"
Id       Title
-------------------------");
            for (int i = 0; i < Tickets.Count; i++)
            {
                Console.WriteLine($@"{i + 1}         {Tickets[i].Title}");
            }
            System.Console.WriteLine("Type (new) to create a ticket, (view) to look at ticket details and (quit) to quit");
        }
        public TicketMaster()
        {
            Tickets = new List<Ticket>();
        }

    }



}