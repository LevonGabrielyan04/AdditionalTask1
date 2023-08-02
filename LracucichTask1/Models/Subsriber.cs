namespace LracucichTask1.Models
{
    public class Subsriber
    {
        public int Id { get; set; }
        public Customer Customer { get; set; }
        public int ServiceId { get; set; }
        public double Account { get; set; }
    }
}
