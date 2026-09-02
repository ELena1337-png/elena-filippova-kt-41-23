namespace lab.Models
{
    public enum DisciplineDirection
    {
        Humanitarian = 1,
        Technical = 2
    }

    public class Discipline
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public DisciplineDirection Direction { get; set; }

        public bool IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }

        public ICollection<Grade> Grades { get; set; } = new List<Grade>();
        public ICollection<Credit> Credits { get; set; } = new List<Credit>();
    }
}