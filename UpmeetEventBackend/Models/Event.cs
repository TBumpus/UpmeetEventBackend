namespace UpmeetEventBackend.Models
{
    public class Event
    {
        public int EventId { get; set; }
        public string Title { get; set; }
        public string Details { get; set; }
        public decimal Price { get; set; }

        public Event(int eventId, string title, string details, decimal price)
        {
            EventId = eventId;
            Title = title;
            Details = details;
            Price = price;
            
        }
       
    }
}
