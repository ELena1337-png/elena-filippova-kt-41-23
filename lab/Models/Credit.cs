namespace lab.Models
{
    public enum CreditStatus
    {
        Passed = 1,
        Failed = 2
    }

    public class Credit
    {
        public int Id { get; set; }

        public int StudentId { get; set; }
        public Student Student { get; set; } = null!;

        public int DisciplineId { get; set; }
        public Discipline Discipline { get; set; } = null!;

        public CreditStatus Status { get; set; }
        public int AcademicYear { get; set; }
        public int? Semester { get; set; }
        public DateTime Date { get; set; }
    }
}