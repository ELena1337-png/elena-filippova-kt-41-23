using lab.Data;
using lab.Models;
using Microsoft.EntityFrameworkCore;
using lab.Filters.StudentFilters;
using NLog.Filters;
namespace lab.Interfaces.StudentsInterfaces
{
    public interface IStudentService
    {
        Task<Student[]> GetStudentsByGroupAsync(StudentGroupFilter filter, CancellationToken cancellationToken = default);
    }
    public class StudentService : IStudentService
    {
        private readonly StudentsDbContext _dbContext;
        public StudentService(StudentsDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<Student[]> GetStudentsByGroupAsync(StudentGroupFilter filter, CancellationToken cancellationToken = default)
        {
            var students = _dbContext.Set<Student>().Where(w => w.Group.Name == filter.Name).ToArrayAsync(cancellationToken);
            return students;


        }


    }



    


}
