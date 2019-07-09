using System.Collections.Generic;
using Model.Entities;

namespace Service.IRepository
{
    public interface IStudent
    {
        List<Student> GetStudents();
        Student GetStudent(int StudentID);
        Student InsertStudent(Student student);
        Student UpdateStudent(Student student);
        bool Delete(int StudentID);
    }
}
