using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace _05_LabExer_1
{
    public partial class FrmRegisration : Form
    {
        private string studNo;
        private string LName;
        private string FName;
        private string MName;
        private int Age;
        private string Bday;
        private string ContactNo;
        private string Gender;
        private string Program;
        public FrmRegisration()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
           string fileName = txtStudNo.Text + ".txt";

            try
            {
                studNo = txtStudNo.Text;
                FName = txtFirstName.Text;
                LName = txtLastName.Text;
                MName = txtMiddleInitial.Text;
                Age = Convert.ToInt32(txtAge.Text);
                Bday = dtpBday.Text;
                ContactNo = txtContactNo.Text;
                Gender = cboxGender.Text;
                Program = cboxProgram.Text;

                string ContactNoRegex = @"^\d{11}$";
                string StudentNoRegex = @"^\d{11}$";

                if (String.IsNullOrWhiteSpace(studNo))
                {
                    MessageBox.Show("Student Number can't be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (String.IsNullOrWhiteSpace(FName))
                {
                    MessageBox.Show("First Name can't be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (String.IsNullOrWhiteSpace(MName))
                {
                    MessageBox.Show("Middle Name can't be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }
                if (String.IsNullOrWhiteSpace(LName))
                {
                    MessageBox.Show("Last Name can't be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (String.IsNullOrWhiteSpace(txtAge.Text))
                {
                    MessageBox.Show("Age can't be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (String.IsNullOrWhiteSpace(Gender))
                {
                    MessageBox.Show("Please select a gender.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (String.IsNullOrWhiteSpace(Program))
                {
                    MessageBox.Show("Please select a program.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (String.IsNullOrWhiteSpace(ContactNo))
                {
                    MessageBox.Show("Contact Number can't be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!Regex.IsMatch(ContactNo, ContactNoRegex))
                {
                    MessageBox.Show("Invalid contact number! Expecting (09-XXXXXXXXX)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!Regex.IsMatch(studNo, StudentNoRegex))
                {
                    MessageBox.Show("Invalid student number! Expecting (02000-XXXXXX)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                string docPath =
           Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath,
                fileName)))
                {
                    outputFile.WriteLine("Student No: " + studNo);
                    outputFile.WriteLine("Full Name: " + FName + " " + MName + ". " + LName);
                    outputFile.WriteLine("Age: " + Age);
                    outputFile.WriteLine("Gender: " + Gender);
                    outputFile.WriteLine("Birthday: " + Bday);
                    outputFile.WriteLine("Program: " + Program);
                    outputFile.WriteLine("Contact No: " + ContactNo);

                }
            }  
            catch (Exception)
            {
                MessageBox.Show("Invalid input! Please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
         
            MessageBox.Show("File has been saved!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
           


        }
    }
}
