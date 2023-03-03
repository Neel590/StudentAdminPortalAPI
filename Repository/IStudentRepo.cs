using StudentAdminPortalAPI.DataModels;

namespace StudentAdminPortalAPI.Repository
{
    public interface IStudentRepo
    {
        Task<List<Student>> GetAllStudents();
    }
}
