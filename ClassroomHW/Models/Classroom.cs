using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassroomHW.Models
{
    public class Classroom
    {

        /* Sınıfın neleri vardır?
         * ID
         * Ad
         * Öğrencileri
         * Genel not ortalaması?
         */
        public int ID { get; set; }

        public string Name { get; set; }
        public decimal ClassroomGPA { get; set; }
        public IList<Student> Students { get; set; }








    }
}
