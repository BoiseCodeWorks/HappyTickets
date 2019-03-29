using System;
using ticketHappy.Models;

namespace ticketHappy
{
    class App
    {
        TicketMaster tm3000 { get; set; }
        bool Running { get; set; } = true;

        public void Run()
        {
            while (Running)
            {
                tm3000.ViewTickets();
                string choice = Console.ReadLine().ToLower();
                HandleUserInput(choice);
            }

        }

        private void HandleUserInput(string choice)
        {
            switch (choice)
            {
                case "view":
                    tm3000.ViewDetails();
                    break;
                case "new":
                    tm3000.AddTicket();
                    break;
                case "quit":
                    Running = false;
                    break;
                default:
                    Console.Clear();
                    System.Console.WriteLine("Unrecognized Command");
                    break;
            }
        }

        public App()
        {
            tm3000 = new TicketMaster();
        }
    }
}