using ClassroomHW.Migrations;
using ClassroomHW.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassroomHW.Services
{
    public class StudentThings
    {

            ClassroomDbContext dbCntxt = new ClassroomDbContext();

            public List<Student> GetStudents()
            {

                return dbCntxt.Students.ToList();

            }

        public Student GetStudentByID(int ID)
        {

            return dbCntxt.Students.Find(ID);

        }


        public void AddStudent(Student student)
        {
            dbCntxt.Students.Add(student);
            dbCntxt.SaveChanges();
        
        
        }
     
        public void UpdateStudent(Student student)
        {
            dbCntxt.Entry(student).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            dbCntxt.SaveChanges();
        }

        public void DeleteStudent(Student student)
        {

            dbCntxt.Remove(student);
            dbCntxt.SaveChanges();
        
        }

        public bool DoesStudentExist(Student student)
        {
            bool checking = false;
            foreach (var item in dbCntxt.Students)
            {
                if (item.Name == student.Name && item.Surname == student.Surname)
                {
                    checking = true;
                }
            }

            return checking;
        }
       


        }
    }
