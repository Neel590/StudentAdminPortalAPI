using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using StudentAdminPortalAPI.DomainModels;
using StudentAdminPortalAPI.Repository;

namespace StudentAdminPortalAPI.Controllers
{
    [ApiController]
    public class StudentController : Controller
    {
        private readonly IStudentRepo _studentRepo;
        private readonly IMapper _mapper;
        public StudentController(IStudentRepo studentRepo, IMapper mapper)
        {
            _studentRepo = studentRepo;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("[controller]")]
        public async Task<IActionResult> GetAllStudents()
        {
            var students = await _studentRepo.GetAllStudents();

            /*            var domainModelStudent = new List<Student>();
                        foreach (var student in students)
                        {
                            domainModelStudent.Add(new Student
                            {
                                Id = student.Id,
                                FirstName = student.FirstName,
                                LastName = student.LastName,
                                DateOfBirth = student.DateOfBirth,
                                Email = student.Email,
                                Mobile = student.Mobile,
                                ProfileImageURL = student.ProfileImageURL,
                                GenderId = student.GenderId,

                                Address = new Address()
                                {
                                    Id= student.Address.Id,
                                    PhysicalAddress= student.Address.PhysicalAddress,
                                    PostalAddress= student.Address.PostalAddress,
                                    StudentId= student.Id,
                                },
                                Gender = new Gender()
                                {
                                    Id= student.Gender.Id,
                                    Description= student.Gender.Description,
                                }

                            });
                            return Ok(domainModelStudent);
                        }
            */
            return Ok(_mapper.Map<List<Student>>(students));   
        }
    }
}
