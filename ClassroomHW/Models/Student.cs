using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassroomHW.Models
{
    public class Student
    {
        /* Öğrencinin neleri vardır?
         * ID
         * Ad
         * Soyad
         * Sınıf
         * Derslerdeki notları
         */

        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public decimal GPA { get; set; }
        public decimal Absence { get; set; }
        public int ClassroomID { get; set; }

        public Classroom classroom { get; set; }
    }
}
