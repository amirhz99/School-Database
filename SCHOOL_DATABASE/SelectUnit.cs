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
    public partial class SelectUnit : Form
    {
        public SelectUnit()
        {
            InitializeComponent();
        }
        UDBE DB = new UDBE();
        int CurrentId = 0;
        private void SelectUnit_Load(object sender, EventArgs e)
        {

            CurrentId = int.Parse(lblStudentID.Text);
            lblStudentID.Visible = false;

            DgStudentCourseTerm.DataSource = DB.Courses.Where(c => c.Student == 0 && c.Status == "شروع نشده" ).ToList();

            DgStudentCourseTerm.Columns["ID"].HeaderText = "کد درس";
            DgStudentCourseTerm.Columns["Name"].HeaderText = "نام درس";
            DgStudentCourseTerm.Columns["Unit"].HeaderText = "تعداد واحد";
            DgStudentCourseTerm.Columns["DeptName"].HeaderText = "گروه";
            DgStudentCourseTerm.Columns["Teacher"].HeaderText = "استاد";
            DgStudentCourseTerm.Columns["Grade"].HeaderText = "نمره";
            DgStudentCourseTerm.Columns["Capacity"].Visible = false;
            DgStudentCourseTerm.Columns["Status"].Visible = false;
            DgStudentCourseTerm.Columns["Student"].Visible = false;
            DgStudentCourseTerm.Columns["Semester"].Visible = false;
            DgStudentCourseTerm.Columns["Students"].Visible = false;
            DgStudentCourseTerm.Columns["Grade"].Visible = false;


        }

        private void btnchange_Click(object sender, EventArgs e)
        {
            string CurrentCourseName = DgStudentCourseTerm.CurrentRow.Cells[1].Value.ToString();
            List<Course> t = new List<Course>();
            t = DB.Courses.Where(m => m.Name == CurrentCourseName && m.Student == CurrentId).ToList();
            if (t.Count > 0)
            {
                btncheck.Text = "بررسی تغییرات";
                frmError err = new frmError();
                err.lblErroe.Text = "شما قبلا این درس را برداشتین";
                err.ShowDialog();
            }
            else
            {
                btncheck.Text = "قابل ثبت";

                int current = int.Parse(DgStudentCourseTerm.CurrentRow.Cells[0].Value.ToString());
                Course co = new Course();
                //co = DB.Courses.First(c => c.Id == current);
                co.Id = current + 20;
                co.Name = DgStudentCourseTerm.CurrentRow.Cells[1].Value.ToString();
                co.Unit = int.Parse(DgStudentCourseTerm.CurrentRow.Cells[2].Value.ToString());
                co.Capacity = 50;
                co.Status = "در حال برگزاری";
                co.Student = CurrentId;
                co.Semester = 1;
                co.Teacher = DgStudentCourseTerm.CurrentRow.Cells[7].Value.ToString();
                co.DeptName = DgStudentCourseTerm.CurrentRow.Cells[8].Value.ToString();
                DB.Courses.Add(co);
                DB.SaveChanges();
                MessageBox.Show("درس " + DgStudentCourseTerm.CurrentRow.Cells[1].Value.ToString() + " با موفقیت ثبت شد ");
            }
        }
        private void btncheck_Click(object sender, EventArgs e)
        {
           
                string CurrentCourseName = DgStudentCourseTerm.CurrentRow.Cells[1].Value.ToString();
                List<Course> t = new List<Course>();
                t = DB.Courses.Where(m => m.Name == CurrentCourseName && m.Student == CurrentId).ToList();
                if (t.Count > 0)
                {
                    btncheck.Text = "بررسی تغییرات";
                    frmError err = new frmError();
                    err.lblErroe.Text = "شما قبلا این درس را برداشتین";
                    err.ShowDialog();
                }

                btncheck.Text = "قابل ثبت";

            }
        }
    }
