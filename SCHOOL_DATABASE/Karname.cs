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
    public partial class Karname : Form
    {
        public Karname()
        {
            InitializeComponent();
        }
        UDBE DB = new UDBE();

        private void Karname_Load(object sender, EventArgs e)
        {
            int CurrentId = int.Parse(lblStudentID.Text);

            lblStudentName.Text = DB.Students.Find(CurrentId).Name;
            lbldepartment.Text = DB.Students.Find(CurrentId).DeptName;
            lblaverage.Text = DB.Students.Find(CurrentId).Average.ToString();
            lblpassunits.Text = DB.Students.Find(CurrentId).PassUnit.ToString();


            DgStudentCourseTerm.DataSource = DB.Courses.Where(c => c.Student == CurrentId && c.Status == "به اتمام رسیده").ToList();

            DgStudentCourseTerm.Columns["ID"].HeaderText = "کد درس";
            DgStudentCourseTerm.Columns["Name"].HeaderText = "نام درس";
            DgStudentCourseTerm.Columns["Unit"].HeaderText = "تعداد واحد";
            DgStudentCourseTerm.Columns["DeptName"].HeaderText = "گروه";
            DgStudentCourseTerm.Columns["Teacher"].HeaderText = "استاد";
            DgStudentCourseTerm.Columns["Grade"].HeaderText = "نمره";
            DgStudentCourseTerm.Columns["Capacity"].Visible = false;
            DgStudentCourseTerm.Columns["Status"].HeaderText = "وضعیت";
            DgStudentCourseTerm.Columns["Student"].Visible = false;
            DgStudentCourseTerm.Columns["Semester"].Visible = false;
            DgStudentCourseTerm.Columns["Students"].Visible = false;

            
        }
    }
}
