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
    public partial class Enter : Form
    {
        public Enter()
        {
            InitializeComponent();
        }
        UDBE DB = new UDBE();

        public void Clear()
        {
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void tblStudent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Enterbt_Click(object sender, EventArgs e)
        {
            MainForm form = new MainForm();
            form.lblStudentID.Text = txtStudentId.Text;
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Register f = new Register();
            f.Show();
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Register f = new Register();
            f.Show();
        }
    }
}
