namespace LracucichTask1.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public DateTime BirthDate { get; set; }
        public IEnumerable<Subsriber> Subsribers { get; set; }
    }
}
