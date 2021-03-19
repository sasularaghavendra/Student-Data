using Microsoft.EntityFrameworkCore;
using Models.Student_Models;
using PostgreSQLRepository.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostgreSQLRepository.Repository
{
    public class StudentRepository
    {
        private readonly StudentDbContext _studentDbContext;
        public StudentRepository(StudentDbContext studentDbContext)
        {
            _studentDbContext = studentDbContext;
        }
        public async Task<ServiceResponse<Student>> addStudentDetails(Student student)
        {
            ServiceResponse<Student> serviceResponse = new ServiceResponse<Student>();
            try
            {
                await _studentDbContext.Students.AddAsync(student);
                await _studentDbContext.SaveChangesAsync();
                serviceResponse.Data = student;
                serviceResponse.Message = $"Student {student.StudentName} Record added successfully.";
                return serviceResponse;
            }
            catch(Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = ex.Message;
                return serviceResponse;
            }
        }
        public ServiceResponse<double> getClassAverage(int classId)
        {
            ServiceResponse<double> serviceResponse = new ServiceResponse<double>();
            try
            {
                var classDetails = _studentDbContext.Students.Where(std => std.Class == classId).ToList();

                if(classDetails.Count != 0)
                {
                    int studentsCount = classDetails.Count();
                    int totalClassMarks = classDetails.Sum(x => x.Marks);
                    serviceResponse.Data = totalClassMarks / studentsCount; 
                    return serviceResponse;
                }
                else
                {
                    serviceResponse.Success = false;
                    serviceResponse.Message = "Records not available.";
                    return serviceResponse;
                }
            }
            catch(Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = ex.Message;
                return serviceResponse;
            }
        }
    }
}
