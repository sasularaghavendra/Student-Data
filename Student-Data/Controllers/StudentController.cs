using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models.Student_Models;
using StudentServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Student_Data.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudent _student;
        public StudentController(IStudent student)
        {
            _student = student;
        }
        [HttpPost]
        public Task<ServiceResponse<Student>> addStudentDetails(Student student)
        {
            return _student.addStudentDetails(student);
        }
        [HttpGet]
        public ServiceResponse<double> getClassAverage(int classId)
        {
            return _student.getClassAverage(classId);
        }
    }
}
