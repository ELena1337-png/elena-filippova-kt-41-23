using System.Diagnostics;
using System.Text.RegularExpressions;

namespace lab.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string LastName { get; set; } = null!;
        public string FirstName { get; set; } = null!;
        public string? MiddleName { get; set; }

        public int GroupId { get; set; }
        public Group Group { get; set; } = null!;

        public bool IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }

        public ICollection<Grade> Grades { get; set; } = new List<Grade>();
        public ICollection<Credit> Credits { get; set; } = new List<Credit>();
    }
}