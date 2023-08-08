namespace LracucichTask1.Models
{
    public class Subsriber
    {
        public int Id { get; set; }
        public Customer Customer { get; set; }
        public IEnumerable<Service> Services { get; set; }
        public double Account { get; set; }
        public string Email { get; set; } = "levongabrielyan44@gmail.com";
        public int ContactNumber { get; set; }
    }
}
