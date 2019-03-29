namespace ticketHappy.Models
{
    class Ticket
    {
        public string Title { get; private set; }
        public string Description { get; private set; }
        public bool Open { get; private set; }


        public Ticket(string title, string description)
        {
            Title = title;
            Description = description;
            Open = true;
        }

    }

}




