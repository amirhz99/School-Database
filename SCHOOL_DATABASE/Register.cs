using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCHOOL_DATABASE
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        UDBE DB = new UDBE();
        MainForm mainf = new MainForm();

        private void Enterbt_Click(object sender, EventArgs e)
        {
            

                Student co = new Student();
                //co = DB.Courses.First(c => c.Id == current);
                co.Id = int.Parse(txtStudentId.Text);
                co.Name = txtname.Text;
                co.DeptName = "کامپیوتر";
                DB.Students.Add(co);
                DB.SaveChanges();
                MessageBox.Show(" با موفقیت ثبت شد ");

                mainf.lblStudentID.Text = txtStudentId.Text;
                mainf.Show();
                this.Close();
            
            
        }

        private void tblStudent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtStudentPass_TextChanged(object sender, EventArgs e)
        {
            pbr.Value = 30;
        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {
            pbr.Value = 60;
        }

        private void cbgroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            pbr.Value = 100;
        }
    }
}
