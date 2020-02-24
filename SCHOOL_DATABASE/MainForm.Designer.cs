namespace SCHOOL_DATABASE
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tbStudentInfo = new System.Windows.Forms.TabControl();
            this.tbpgStudentInfo = new System.Windows.Forms.TabPage();
            this.tblStudent = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.lblStudentID = new System.Windows.Forms.Label();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.lbldepartment = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblaverage = new System.Windows.Forms.Label();
            this.lblpassunits = new System.Windows.Forms.Label();
            this.tbGrvPage = new System.Windows.Forms.TabControl();
            this.pgGrvPage = new System.Windows.Forms.TabPage();
            this.DgStudentCourseTerm = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btndashboard = new System.Windows.Forms.ToolStripButton();
            this.btnselectunit = new System.Windows.Forms.ToolStripButton();
            this.karnamebtn = new System.Windows.Forms.ToolStripButton();
            this.exitbtn = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.tbStudentInfo.SuspendLayout();
            this.tbpgStudentInfo.SuspendLayout();
            this.tblStudent.SuspendLayout();
            this.tbGrvPage.SuspendLayout();
            this.pgGrvPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgStudentCourseTerm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btndashboard,
            this.btnselectunit,
            this.karnamebtn,
            this.exitbtn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1032, 99);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tbStudentInfo
            // 
            this.tbStudentInfo.Alignment = System.Windows.Forms.TabAlignment.Right;
            this.tbStudentInfo.Controls.Add(this.tbpgStudentInfo);
            this.tbStudentInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbStudentInfo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tbStudentInfo.Location = new System.Drawing.Point(0, 99);
            this.tbStudentInfo.Margin = new System.Windows.Forms.Padding(4);
            this.tbStudentInfo.Multiline = true;
            this.tbStudentInfo.Name = "tbStudentInfo";
            this.tbStudentInfo.SelectedIndex = 0;
            this.tbStudentInfo.Size = new System.Drawing.Size(1032, 166);
            this.tbStudentInfo.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tbStudentInfo.TabIndex = 1;
            // 
            // tbpgStudentInfo
            // 
            this.tbpgStudentInfo.Controls.Add(this.tblStudent);
            this.tbpgStudentInfo.Location = new System.Drawing.Point(4, 4);
            this.tbpgStudentInfo.Margin = new System.Windows.Forms.Padding(4);
            this.tbpgStudentInfo.Name = "tbpgStudentInfo";
            this.tbpgStudentInfo.Padding = new System.Windows.Forms.Padding(4);
            this.tbpgStudentInfo.Size = new System.Drawing.Size(998, 158);
            this.tbpgStudentInfo.TabIndex = 0;
            this.tbpgStudentInfo.Text = "مشخصات دانشجو";
            this.tbpgStudentInfo.UseVisualStyleBackColor = true;
            // 
            // tblStudent
            // 
            this.tblStudent.BackColor = System.Drawing.Color.Lime;
            this.tblStudent.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tblStudent.ColumnCount = 2;
            this.tblStudent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblStudent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblStudent.Controls.Add(this.label7, 0, 4);
            this.tblStudent.Controls.Add(this.lblStudentID, 1, 0);
            this.tblStudent.Controls.Add(this.lblStudentName, 1, 1);
            this.tblStudent.Controls.Add(this.lbldepartment, 1, 2);
            this.tblStudent.Controls.Add(this.label6, 0, 2);
            this.tblStudent.Controls.Add(this.label2, 0, 0);
            this.tblStudent.Controls.Add(this.label4, 0, 1);
            this.tblStudent.Controls.Add(this.label5, 0, 3);
            this.tblStudent.Controls.Add(this.lblaverage, 1, 3);
            this.tblStudent.Controls.Add(this.lblpassunits, 1, 4);
            this.tblStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblStudent.Location = new System.Drawing.Point(4, 4);
            this.tblStudent.Margin = new System.Windows.Forms.Padding(4);
            this.tblStudent.Name = "tblStudent";
            this.tblStudent.RowCount = 5;
            this.tblStudent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.81482F));
            this.tblStudent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.37037F));
            this.tblStudent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tblStudent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tblStudent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tblStudent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblStudent.Size = new System.Drawing.Size(990, 150);
            this.tblStudent.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(814, 126);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(170, 21);
            this.label7.TabIndex = 4;
            this.label7.Text = "تعداد واحد های گذرانده";
            // 
            // lblStudentID
            // 
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.Location = new System.Drawing.Point(452, 2);
            this.lblStudentID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(38, 21);
            this.lblStudentID.TabIndex = 0;
            this.lblStudentID.Text = "داده";
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Location = new System.Drawing.Point(452, 36);
            this.lblStudentName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(38, 21);
            this.lblStudentName.TabIndex = 0;
            this.lblStudentName.Text = "داده";
            // 
            // lbldepartment
            // 
            this.lbldepartment.AutoSize = true;
            this.lbldepartment.Location = new System.Drawing.Point(452, 66);
            this.lbldepartment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbldepartment.Name = "lbldepartment";
            this.lbldepartment.Size = new System.Drawing.Size(38, 21);
            this.lbldepartment.TabIndex = 0;
            this.lbldepartment.Text = "داده";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(935, 66);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = "رشته";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(846, 2);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "شماره دانشجویی";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(894, 36);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "نام دانشجو";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(937, 98);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 21);
            this.label5.TabIndex = 3;
            this.label5.Text = "معدل";
            // 
            // lblaverage
            // 
            this.lblaverage.AutoSize = true;
            this.lblaverage.Location = new System.Drawing.Point(452, 98);
            this.lblaverage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblaverage.Name = "lblaverage";
            this.lblaverage.Size = new System.Drawing.Size(38, 21);
            this.lblaverage.TabIndex = 1;
            this.lblaverage.Text = "داده";
            // 
            // lblpassunits
            // 
            this.lblpassunits.AutoSize = true;
            this.lblpassunits.Location = new System.Drawing.Point(452, 126);
            this.lblpassunits.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblpassunits.Name = "lblpassunits";
            this.lblpassunits.Size = new System.Drawing.Size(38, 21);
            this.lblpassunits.TabIndex = 2;
            this.lblpassunits.Text = "داده";
            // 
            // tbGrvPage
            // 
            this.tbGrvPage.Alignment = System.Windows.Forms.TabAlignment.Right;
            this.tbGrvPage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbGrvPage.Controls.Add(this.pgGrvPage);
            this.tbGrvPage.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tbGrvPage.Location = new System.Drawing.Point(0, 253);
            this.tbGrvPage.Margin = new System.Windows.Forms.Padding(4);
            this.tbGrvPage.Multiline = true;
            this.tbGrvPage.Name = "tbGrvPage";
            this.tbGrvPage.SelectedIndex = 0;
            this.tbGrvPage.Size = new System.Drawing.Size(1029, 347);
            this.tbGrvPage.TabIndex = 2;
            // 
            // pgGrvPage
            // 
            this.pgGrvPage.Controls.Add(this.DgStudentCourseTerm);
            this.pgGrvPage.Location = new System.Drawing.Point(4, 4);
            this.pgGrvPage.Margin = new System.Windows.Forms.Padding(4);
            this.pgGrvPage.Name = "pgGrvPage";
            this.pgGrvPage.Padding = new System.Windows.Forms.Padding(4);
            this.pgGrvPage.Size = new System.Drawing.Size(995, 339);
            this.pgGrvPage.TabIndex = 0;
            this.pgGrvPage.Text = "کلاس های در حال برگزاری";
            this.pgGrvPage.UseVisualStyleBackColor = true;
            // 
            // DgStudentCourseTerm
            // 
            this.DgStudentCourseTerm.AllowUserToAddRows = false;
            this.DgStudentCourseTerm.AllowUserToDeleteRows = false;
            this.DgStudentCourseTerm.AllowUserToOrderColumns = true;
            this.DgStudentCourseTerm.AllowUserToResizeColumns = false;
            this.DgStudentCourseTerm.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Red;
            this.DgStudentCourseTerm.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DgStudentCourseTerm.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgStudentCourseTerm.BackgroundColor = System.Drawing.Color.Red;
            this.DgStudentCourseTerm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgStudentCourseTerm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgStudentCourseTerm.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.DgStudentCourseTerm.Location = new System.Drawing.Point(4, 4);
            this.DgStudentCourseTerm.Margin = new System.Windows.Forms.Padding(4);
            this.DgStudentCourseTerm.MultiSelect = false;
            this.DgStudentCourseTerm.Name = "DgStudentCourseTerm";
            this.DgStudentCourseTerm.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DgStudentCourseTerm.ShowCellErrors = false;
            this.DgStudentCourseTerm.ShowEditingIcon = false;
            this.DgStudentCourseTerm.Size = new System.Drawing.Size(987, 331);
            this.DgStudentCourseTerm.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(7, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(86, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btndashboard
            // 
            this.btndashboard.BackColor = System.Drawing.Color.White;
            this.btndashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btndashboard.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndashboard.Image = global::SCHOOL_DATABASE.Properties.Resources.edit_business_user;
            this.btndashboard.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btndashboard.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btndashboard.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btndashboard.Margin = new System.Windows.Forms.Padding(5);
            this.btndashboard.Name = "btndashboard";
            this.btndashboard.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btndashboard.Size = new System.Drawing.Size(109, 89);
            this.btndashboard.Text = "صفحه کاربری";
            this.btndashboard.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btndashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btndashboard.Click += new System.EventHandler(this.btndashboard_Click);
            // 
            // btnselectunit
            // 
            this.btnselectunit.BackColor = System.Drawing.Color.White;
            this.btnselectunit.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnselectunit.Image = ((System.Drawing.Image)(resources.GetObject("btnselectunit.Image")));
            this.btnselectunit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnselectunit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnselectunit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnselectunit.Margin = new System.Windows.Forms.Padding(5);
            this.btnselectunit.Name = "btnselectunit";
            this.btnselectunit.Size = new System.Drawing.Size(96, 89);
            this.btnselectunit.Text = "انتخاب واحد";
            this.btnselectunit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnselectunit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnselectunit.Click += new System.EventHandler(this.btnselectunit_Click);
            // 
            // karnamebtn
            // 
            this.karnamebtn.BackColor = System.Drawing.Color.White;
            this.karnamebtn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.karnamebtn.Image = ((System.Drawing.Image)(resources.GetObject("karnamebtn.Image")));
            this.karnamebtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.karnamebtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.karnamebtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.karnamebtn.Margin = new System.Windows.Forms.Padding(5);
            this.karnamebtn.Name = "karnamebtn";
            this.karnamebtn.Size = new System.Drawing.Size(142, 89);
            this.karnamebtn.Text = "کارنامه و ریز نمرات";
            this.karnamebtn.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.karnamebtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.karnamebtn.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // exitbtn
            // 
            this.exitbtn.BackColor = System.Drawing.Color.White;
            this.exitbtn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitbtn.Image = ((System.Drawing.Image)(resources.GetObject("exitbtn.Image")));
            this.exitbtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.exitbtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.exitbtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.exitbtn.Margin = new System.Windows.Forms.Padding(5);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(68, 89);
            this.exitbtn.Text = "خروج";
            this.exitbtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.exitbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.exitbtn.Click += new System.EventHandler(this.exitbtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 603);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbGrvPage);
            this.Controls.Add(this.tbStudentInfo);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "امیرحسین زارعی";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tbStudentInfo.ResumeLayout(false);
            this.tbpgStudentInfo.ResumeLayout(false);
            this.tblStudent.ResumeLayout(false);
            this.tblStudent.PerformLayout();
            this.tbGrvPage.ResumeLayout(false);
            this.pgGrvPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgStudentCourseTerm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btndashboard;
        private System.Windows.Forms.TabControl tbStudentInfo;
        private System.Windows.Forms.TabPage tbpgStudentInfo;
        private System.Windows.Forms.TableLayoutPanel tblStudent;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.Label lbldepartment;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabControl tbGrvPage;
        private System.Windows.Forms.TabPage pgGrvPage;
        private System.Windows.Forms.DataGridView DgStudentCourseTerm;
        private System.Windows.Forms.ToolStripButton btnselectunit;
        public System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblaverage;
        private System.Windows.Forms.Label lblpassunits;
        private System.Windows.Forms.ToolStripButton exitbtn;
        private System.Windows.Forms.ToolStripButton karnamebtn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

