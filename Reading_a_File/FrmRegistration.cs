using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reading_a_File
{
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();
        }
        public static string SetFileName;
        private void FrmRegistration_Load(object sender, EventArgs e)
        {
            string[] ListOfPrograms = new string[]
            {
                "BS Information Technology",
                "BS Computer Science",
                "BS Computer Engineering",
                "BS Human Resource and Management",
                "BS Accountancy",
                "BS Information Systems"
            };
            for (int i = 0; i < 6; i++)
            {
                cbProgram.Items.Add(ListOfPrograms[i].ToString());
            }

            string[] ListOfGenders = new string[]
                {"Male",
                "Female"};
            for(int i = 0; i < 2; i++)
            {
                cbGender.Items.Add(ListOfGenders[i].ToString());
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, txtBoxStudentNo.Text + ".txt")))
            {
                string[] outputRegistered = new string[] {
            "Student No.  : " + txtBoxStudentNo.Text,
            "Full Name    : " + txtBoxLastName.Text + ", " + txtBoxFirstName.Text + ", "  + txtBoxMiddleName.Text + ".",
            "Program      : " + cbProgram.Text,
            "Gender       : " + cbGender.Text,
            "Age          : " + txtBoxAge.Text,
            "Birthday     : " + dateTimePickerBirthday.Value.ToString("yyyy-MM-dd"),
            "Contact No.  : " + txtBoxContactNo.Text
                };

                foreach (string i in outputRegistered)
                {
                    outputFile.WriteLine(i);
                    Console.WriteLine(i);
                }
            }
            Close();
        }
    }
}
