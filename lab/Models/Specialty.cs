namespace lab.Models
{
    public class Specialty
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Code { get; set; }

        public ICollection<Group> Groups { get; set; } = new List<Group>();
    }
}