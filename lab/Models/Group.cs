namespace lab.Models
{
    public class Group
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public int SpecialtyId { get; set; }
        public Specialty Specialty { get; set; } = null!;

        public int AdmissionYear { get; set; }

        public bool IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }

        public ICollection<Student> Students { get; set; } = new List<Student>();
    }
}