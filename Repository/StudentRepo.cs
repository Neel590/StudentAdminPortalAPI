using Microsoft.EntityFrameworkCore;
using StudentAdminPortalAPI.DataModels;

namespace StudentAdminPortalAPI.Repository
{
    public class StudentRepo : IStudentRepo
    {
        private readonly StudentAdminContext _context;
        public StudentRepo(StudentAdminContext context)
        {
            _context = context;
        }

        public async Task<List<Student>> GetAllStudents()
        {
            return await _context.Student.Include(nameof(Gender)).Include(nameof(Address)).ToListAsync();
        }
    }
}
