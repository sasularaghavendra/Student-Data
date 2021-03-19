using Models.Student_Models;
using PostgreSQLRepository.Repository;
using StudentServices.Interfaces;
using System;
using System.Threading.Tasks;

namespace StudentServices
{
    public class StudentData : IStudent
    {
        private readonly StudentRepository _studentRepository;
        public StudentData(StudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }
        public async Task<ServiceResponse<Student>> addStudentDetails(Student student)
        {
            return await _studentRepository.addStudentDetails(student);
        }

        public ServiceResponse<double> getClassAverage(int classId)
        {
            return _studentRepository.getClassAverage(classId);
        }
    }
}
