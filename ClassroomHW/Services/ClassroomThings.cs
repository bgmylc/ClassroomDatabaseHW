using ClassroomHW.Migrations;
using ClassroomHW.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassroomHW.Services
{
    public class ClassroomThings
    {
        ClassroomDbContext dbCntxt = new ClassroomDbContext();

        public Classroom GetClassroomByID(int ID)
        {

            return dbCntxt.Classrooms.Find(ID);

        }

        public List<Classroom> GetClassrooms()
        {
            return dbCntxt.Classrooms.ToList();

        }






    }
}
