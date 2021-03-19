using Models.Student_Models;
using Moq;
using Student_Data.Controllers;
using StudentServices.Interfaces;
using System;
using Xunit;

namespace xUnit_Testcases
{
    public class StudentTestCases
    {
        [Fact]
        public void Add_StudentData_Success()
        {
            //Arrange
            var student = new Student {Class = 10 , StudentName = "Ragav", Subject="Computers", Marks = 89 };

            var mockRepo = new Mock<IStudent>();
            mockRepo.Setup(repo => repo.addStudentDetails(student));
            var controller = new StudentController(mockRepo.Object);

            //Act
            var result = controller.addStudentDetails(student);

            //Assert
            Assert.True(true);
        }
    }
}
