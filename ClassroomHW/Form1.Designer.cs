
using System;

namespace ClassroomHW
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxClass = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelAbsence = new System.Windows.Forms.Label();
            this.textBoxAbsence = new System.Windows.Forms.TextBox();
            this.buttonGoster = new System.Windows.Forms.Button();
            this.label1Ogr = new System.Windows.Forms.Label();
            this.labelGPA = new System.Windows.Forms.Label();
            this.labelSoyad = new System.Windows.Forms.Label();
            this.labelAd = new System.Windows.Forms.Label();
            this.buttonGüncelle = new System.Windows.Forms.Button();
            this.button2Sil = new System.Windows.Forms.Button();
            this.button1Ekle = new System.Windows.Forms.Button();
            this.textBoxStudentGPA = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.comboBox1Ogrenci = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 291;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxClass);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.labelAbsence);
            this.groupBox1.Controls.Add(this.textBoxAbsence);
            this.groupBox1.Controls.Add(this.buttonGoster);
            this.groupBox1.Controls.Add(this.label1Ogr);
            this.groupBox1.Controls.Add(this.labelGPA);
            this.groupBox1.Controls.Add(this.labelSoyad);
            this.groupBox1.Controls.Add(this.labelAd);
            this.groupBox1.Controls.Add(this.buttonGüncelle);
            this.groupBox1.Controls.Add(this.button2Sil);
            this.groupBox1.Controls.Add(this.button1Ekle);
            this.groupBox1.Controls.Add(this.textBoxStudentGPA);
            this.groupBox1.Controls.Add(this.textBoxLastName);
            this.groupBox1.Controls.Add(this.textBoxName);
            this.groupBox1.Controls.Add(this.comboBox1Ogrenci);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 391);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // comboBoxClass
            // 
            this.comboBoxClass.FormattingEnabled = true;
            this.comboBoxClass.Location = new System.Drawing.Point(12, 264);
            this.comboBoxClass.Name = "comboBoxClass";
            this.comboBoxClass.Size = new System.Drawing.Size(121, 21);
            this.comboBoxClass.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Student Classroom";
            // 
            // labelAbsence
            // 
            this.labelAbsence.AutoSize = true;
            this.labelAbsence.Location = new System.Drawing.Point(148, 198);
            this.labelAbsence.Name = "labelAbsence";
            this.labelAbsence.Size = new System.Drawing.Size(107, 13);
            this.labelAbsence.TabIndex = 15;
            this.labelAbsence.Text = "Student Absent Days";
            // 
            // textBoxAbsence
            // 
            this.textBoxAbsence.Location = new System.Drawing.Point(149, 214);
            this.textBoxAbsence.Name = "textBoxAbsence";
            this.textBoxAbsence.Size = new System.Drawing.Size(100, 20);
            this.textBoxAbsence.TabIndex = 14;
            // 
            // buttonGoster
            // 
            this.buttonGoster.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttonGoster.Location = new System.Drawing.Point(174, 72);
            this.buttonGoster.Name = "buttonGoster";
            this.buttonGoster.Size = new System.Drawing.Size(75, 35);
            this.buttonGoster.TabIndex = 13;
            this.buttonGoster.Text = "Show Students";
            this.buttonGoster.UseVisualStyleBackColor = false;
            this.buttonGoster.Click += new System.EventHandler(this.buttonGoster_Click);
            // 
            // label1Ogr
            // 
            this.label1Ogr.AutoSize = true;
            this.label1Ogr.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1Ogr.Location = new System.Drawing.Point(9, 22);
            this.label1Ogr.Name = "label1Ogr";
            this.label1Ogr.Size = new System.Drawing.Size(95, 16);
            this.label1Ogr.TabIndex = 11;
            this.label1Ogr.Text = "Select A Student";
            // 
            // labelGPA
            // 
            this.labelGPA.AutoSize = true;
            this.labelGPA.Location = new System.Drawing.Point(12, 198);
            this.labelGPA.Name = "labelGPA";
            this.labelGPA.Size = new System.Drawing.Size(106, 13);
            this.labelGPA.TabIndex = 9;
            this.labelGPA.Text = "Student Current GPA";
            // 
            // labelSoyad
            // 
            this.labelSoyad.AutoSize = true;
            this.labelSoyad.Location = new System.Drawing.Point(9, 145);
            this.labelSoyad.Name = "labelSoyad";
            this.labelSoyad.Size = new System.Drawing.Size(98, 13);
            this.labelSoyad.TabIndex = 8;
            this.labelSoyad.Text = "Student Last Name";
            // 
            // labelAd
            // 
            this.labelAd.AutoSize = true;
            this.labelAd.Location = new System.Drawing.Point(12, 94);
            this.labelAd.Name = "labelAd";
            this.labelAd.Size = new System.Drawing.Size(75, 13);
            this.labelAd.TabIndex = 7;
            this.labelAd.Text = "Student Name";
            // 
            // buttonGüncelle
            // 
            this.buttonGüncelle.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttonGüncelle.Enabled = false;
            this.buttonGüncelle.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.buttonGüncelle.Location = new System.Drawing.Point(174, 321);
            this.buttonGüncelle.Name = "buttonGüncelle";
            this.buttonGüncelle.Size = new System.Drawing.Size(75, 46);
            this.buttonGüncelle.TabIndex = 6;
            this.buttonGüncelle.Text = "Update Student Info";
            this.buttonGüncelle.UseVisualStyleBackColor = false;
            this.buttonGüncelle.Click += new System.EventHandler(this.buttonGüncelle_Click);
            // 
            // button2Sil
            // 
            this.button2Sil.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button2Sil.Enabled = false;
            this.button2Sil.ForeColor = System.Drawing.Color.Maroon;
            this.button2Sil.Location = new System.Drawing.Point(93, 321);
            this.button2Sil.Name = "button2Sil";
            this.button2Sil.Size = new System.Drawing.Size(75, 46);
            this.button2Sil.TabIndex = 5;
            this.button2Sil.Text = "Delete Student";
            this.button2Sil.UseVisualStyleBackColor = false;
            this.button2Sil.Click += new System.EventHandler(this.button2Sil_Click);
            // 
            // button1Ekle
            // 
            this.button1Ekle.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button1Ekle.Location = new System.Drawing.Point(12, 321);
            this.button1Ekle.Name = "button1Ekle";
            this.button1Ekle.Size = new System.Drawing.Size(75, 23);
            this.button1Ekle.TabIndex = 4;
            this.button1Ekle.Text = "Add Student";
            this.button1Ekle.UseVisualStyleBackColor = false;
            this.button1Ekle.Click += new System.EventHandler(this.button1Ekle_Click);
            // 
            // textBoxStudentGPA
            // 
            this.textBoxStudentGPA.Location = new System.Drawing.Point(12, 214);
            this.textBoxStudentGPA.Name = "textBoxStudentGPA";
            this.textBoxStudentGPA.Size = new System.Drawing.Size(100, 20);
            this.textBoxStudentGPA.TabIndex = 3;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(12, 161);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(166, 20);
            this.textBoxLastName.TabIndex = 2;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(12, 110);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(166, 20);
            this.textBoxName.TabIndex = 1;
            // 
            // comboBox1Ogrenci
            // 
            this.comboBox1Ogrenci.BackColor = System.Drawing.SystemColors.Menu;
            this.comboBox1Ogrenci.FormattingEnabled = true;
            this.comboBox1Ogrenci.Location = new System.Drawing.Point(12, 41);
            this.comboBox1Ogrenci.Name = "comboBox1Ogrenci";
            this.comboBox1Ogrenci.Size = new System.Drawing.Size(248, 21);
            this.comboBox1Ogrenci.TabIndex = 0;
            this.comboBox1Ogrenci.SelectionChangeCommitted += new System.EventHandler(this.comboBox1Ogrenci_SelectionChangeCommitted);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(505, 450);
            this.dataGridView1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        private void comboBox2Sınıf_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelGPA;
        private System.Windows.Forms.Label labelSoyad;
        private System.Windows.Forms.Label labelAd;
        private System.Windows.Forms.Button buttonGüncelle;
        private System.Windows.Forms.Button button2Sil;
        private System.Windows.Forms.Button button1Ekle;
        private System.Windows.Forms.TextBox textBoxStudentGPA;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.ComboBox comboBox1Ogrenci;
        private System.Windows.Forms.Label label1Ogr;
        private System.Windows.Forms.Button buttonGoster;
        private System.Windows.Forms.Label labelAbsence;
        private System.Windows.Forms.TextBox textBoxAbsence;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxClass;
    }
}

