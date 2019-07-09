using System;
using System.Collections.Generic;
using System.Linq;
using Model.Entities;
using Service.IRepository;

namespace Service.Repository
{
   public class StudentRepo : IStudent
    {
        private readonly AppDBContext context;

      public StudentRepo(AppDBContext context)
        {
            this.context = context;
        }
        public bool Delete(int StudentID)
        {
            Student student = context.students.Find(StudentID);
            if (student != null)
            {
                student.IsDeleted = true;
                student.ModificationDate = DateTime.Now;
                bool res = context.SaveChanges() > 0;
                return res;
            }
            return false;
        }

        public Student GetStudent(int StudentID)
        {
            return context.students.Where(s => s.ID == StudentID).FirstOrDefault();
        }

        public List<Student> GetStudents()
        {
            return context.students.ToList();
        }

        public Student InsertStudent(Student student)
        {
            context.students.Add(student);
            bool res = context.SaveChanges() > 0;
            return student;
        }

        public Student UpdateStudent(Student student)
        {
            context.students.Update(student);
            bool res = context.SaveChanges() > 0;
            return student;
        }

    }
}
