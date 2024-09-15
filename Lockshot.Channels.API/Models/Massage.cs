namespace Lockshot.Channels.API.Models
{
    public class Massage
    {
        public int Id { get; set; }
        public int ServerId { get; set; }
        public string UserId { get; set; }
        public string Text { get; set; }
        public DateTime DateOnle { get; set; }
    }
}
