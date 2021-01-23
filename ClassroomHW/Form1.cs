using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassroomHW.Migrations;
using ClassroomHW.Models;
using ClassroomHW.Services;
using Microsoft.EntityFrameworkCore;

namespace ClassroomHW
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            getClassroomsToSelect();
            getStudentToSelect();
        }

        StudentThings studentThings = new StudentThings();
        ClassroomThings classroomThings = new ClassroomThings();
        private void getStudentsToView()
        {
          
            dataGridView1.DataSource = studentThings.GetStudents();

        }

        private void getClassroomsToSelect()
        {

            comboBoxClass.DataSource = classroomThings.GetClassrooms();
            comboBoxClass.DisplayMember = "Name";
            comboBoxClass.ValueMember = "ID";

        }

        private void getStudentToSelect()
        {
            comboBox1Ogrenci.DataSource = studentThings.GetStudents();
            comboBox1Ogrenci.DisplayMember = "Name";
            comboBox1Ogrenci.ValueMember = "ID";
        }
        Student selectedStudent = null;

        private void button1Ekle_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            student.Name = textBoxName.Text;
            student.Surname = textBoxLastName.Text;
            Decimal.TryParse(textBoxStudentGPA.Text, out decimal gpaStu);
            student.GPA = gpaStu;
            Decimal.TryParse(textBoxAbsence.Text, out decimal absenceStu);
            student.Absence = absenceStu;
            int selectedClassID = (int)comboBoxClass.SelectedValue;
            student.ClassroomID = selectedClassID;
            if (studentThings.DoesStudentExist(student))
            {
                string message = $"A Student with the name {textBoxName.Text} {textBoxLastName.Text} already exists.  Do you want to continue?";
                var result = MessageBox.Show(message, "Existing Student",
                    MessageBoxButtons.YesNo, 
                    MessageBoxIcon.Question);
                switch(result)
                {
                    case DialogResult.Yes:
                        studentThings.AddStudent(student);
                        break;
                    case DialogResult.No:   
                        break;
                    default:                 
                        break;
                }


            }
         
            getStudentsToView();
            getStudentToSelect();
        }

    
        private void comboBox1Ogrenci_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int selectedID = (int)comboBox1Ogrenci.SelectedValue;

            var student = studentThings.GetStudentByID(selectedID);
            selectedStudent = student;

            textBoxName.Text = student.Name;
            textBoxLastName.Text = student.Surname;
            textBoxStudentGPA.Text = student.GPA.ToString();
            textBoxAbsence.Text = student.Absence.ToString();
            comboBoxClass.SelectedValue = student.ClassroomID;

            buttonGüncelle.Enabled = true;
            button2Sil.Enabled = true;
        }

        private void buttonGüncelle_Click(object sender, EventArgs e)
        {
            selectedStudent.Name = textBoxName.Text;
            selectedStudent.Surname = textBoxLastName.Text;

            Decimal.TryParse(textBoxStudentGPA.Text, out decimal gpa);
            selectedStudent.GPA = gpa;
            Decimal.TryParse(textBoxAbsence.Text, out decimal absence);
            selectedStudent.Absence = absence;

            int selectedClassID = (int)comboBoxClass.SelectedValue;
            selectedStudent.ClassroomID = selectedClassID;
            //selectedStudent.classroom = classroomThings.GetClassroomByID(selectedClassID);
            studentThings.UpdateStudent(selectedStudent);
            getStudentsToView();
            getStudentToSelect();

        }

        private void button2Sil_Click(object sender, EventArgs e)
        {
            studentThings.DeleteStudent(selectedStudent);
            getStudentsToView();
            getStudentToSelect();
        }

        private void buttonGoster_Click(object sender, EventArgs e)
        {
            getStudentsToView();
        }
    }
}
