using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExerciseWindowsFormsApp13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_Submit_Click(object sender, EventArgs e)
        {
            string formdetails = "" ;

            try
            {
                formdetails += $"First Name : {txt_FirstName.Text}\n\n Last Name : {txt_LastName.Text}\n\n PREFIX : {comboPREFIX.Text}\n\n TITLE : {txtTITLE.Text}\n\n CITY : {txt_City.Text}\n\n STATE : {comboState.Text}\n\n zip code : {txtZIPCODE.Text}\n\n Home Phone : {txtHomePhone.Text}\n\n Mobile Phone : {txtMobilePhone.Text}\n\n Email : {txt_Email.Text}\n\n SKYPE : {txtSkype.Text}\n\n Departmant : {comboDepartment.Text}\n\n STATUS : {comboStatus.Text}\n\n Hire Date : {txtDoB.Text}";

                MessageBox.Show(formdetails);


                lbl_Employee.Text = "Employee :" + txt_FirstName.Text  + txt_LastName.Text;
            }
            catch (Exception ex)
            {

            }
           

        }
    }
}
