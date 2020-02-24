using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;//Imported
using System.Data;

namespace SCHOOL_DATABASE
{
    public partial class MainForm : Form
    {
       
        bool DATA_GRID_VIEW_IS_CLICKED = false;//Barresi cclick bar rooyeh GRidView

           
        frmError error = null;

        UDBE DB = new UDBE();

        SelectUnit F = new SelectUnit();

        Karname KF = new Karname();

        public MainForm()
        {
            InitializeComponent();
        }
        public void DataLoad()//Bargozari Kolle data dar GridView
        {

            try
            {

                int CurrentId = int.Parse(lblStudentID.Text);

                lblStudentName.Text = DB.Students.Find(CurrentId).Name;
                lbldepartment.Text = DB.Students.Find(CurrentId).DeptName;
                lblaverage.Text = DB.Students.Find(CurrentId).Average.ToString();
                lblpassunits.Text = DB.Students.Find(CurrentId).PassUnit.ToString();


                DgStudentCourseTerm.DataSource = DB.Courses.Where(c => c.Student == CurrentId && c.Status == "در حال برگزاری").ToList();

                DgStudentCourseTerm.Columns["ID"].HeaderText = "کد درس";
                DgStudentCourseTerm.Columns["Name"].HeaderText = "نام درس";
                DgStudentCourseTerm.Columns["Unit"].HeaderText = "تعداد واحد";
                DgStudentCourseTerm.Columns["DeptName"].HeaderText = "گروه";
                DgStudentCourseTerm.Columns["Teacher"].HeaderText = "استاد";
                DgStudentCourseTerm.Columns["Capacity"].Visible = false;
                DgStudentCourseTerm.Columns["Status"].Visible = false;
                DgStudentCourseTerm.Columns["Student"].Visible = false;
                DgStudentCourseTerm.Columns["Semester"].Visible = false;
                DgStudentCourseTerm.Columns["Students"].Visible = false;
                DgStudentCourseTerm.Columns["Grade"].Visible = false;



            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "مشکل در برقراری ارتباط با پایگاه داده", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
               

                try
                {
                   
                }
                catch (Exception exp)
                {

                    error = new frmError();
                    error.lblErroe.Text = exp.Message;
                    error.ShowDialog();
                }

            }
        }
       

   
        private void btndashboard_Click(object sender, EventArgs e)
        {
            DataLoad();
            F.Hide();
            KF.Hide();

            tbGrvPage.Visible = true;
            tbStudentInfo.Visible = true;
        }

        private void btnkarname_Click(object sender, EventArgs e)
        {
            KF.MdiParent = this;
            KF.lblStudentID.Text = lblStudentID.Text;
            KF.Show();
            F.Hide();

            tbGrvPage.Visible = false;
            tbStudentInfo.Visible = false;

           
        }

        private void btnselectunit_Click(object sender, EventArgs e)
        {
            F.MdiParent = this;
            F.lblStudentID.Text = lblStudentID.Text;
            F.Show();
            KF.Hide();

            tbGrvPage.Visible = false;
            tbStudentInfo.Visible = false;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DataLoad();
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            KF.MdiParent = this;
            KF.lblStudentID.Text = lblStudentID.Text;
            KF.Show();
            F.Hide();

            tbGrvPage.Visible = false;
            tbStudentInfo.Visible = false;

        }
    }
}
