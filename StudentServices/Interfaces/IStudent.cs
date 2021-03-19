using Models.Student_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentServices.Interfaces
{
    public interface IStudent
    {
        Task<ServiceResponse<Student>> addStudentDetails(Student student);
        ServiceResponse<double> getClassAverage(int classId);
    }
}
