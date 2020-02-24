namespace SCHOOL_DATABASE
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Enterbt = new System.Windows.Forms.Button();
            this.tblStudent = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStudentId = new System.Windows.Forms.TextBox();
            this.txtStudentPass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbgroup = new System.Windows.Forms.ComboBox();
            this.pbr = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tblStudent.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(360, 217);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(136, 231);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Enterbt
            // 
            this.Enterbt.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Enterbt.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Enterbt.Image = ((System.Drawing.Image)(resources.GetObject("Enterbt.Image")));
            this.Enterbt.Location = new System.Drawing.Point(72, 41);
            this.Enterbt.Name = "Enterbt";
            this.Enterbt.Size = new System.Drawing.Size(161, 119);
            this.Enterbt.TabIndex = 8;
            this.Enterbt.Text = "ثبت نام";
            this.Enterbt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Enterbt.UseVisualStyleBackColor = true;
            this.Enterbt.Click += new System.EventHandler(this.Enterbt_Click);
            // 
            // tblStudent
            // 
            this.tblStudent.BackColor = System.Drawing.Color.Orchid;
            this.tblStudent.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tblStudent.ColumnCount = 2;
            this.tblStudent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.53289F));
            this.tblStudent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.46711F));
            this.tblStudent.Controls.Add(this.label3, 0, 3);
            this.tblStudent.Controls.Add(this.label2, 0, 0);
            this.tblStudent.Controls.Add(this.label4, 0, 1);
            this.tblStudent.Controls.Add(this.txtStudentId, 1, 0);
            this.tblStudent.Controls.Add(this.txtStudentPass, 1, 1);
            this.tblStudent.Controls.Add(this.label1, 0, 2);
            this.tblStudent.Controls.Add(this.txtname, 1, 2);
            this.tblStudent.Controls.Add(this.cbgroup, 1, 3);
            this.tblStudent.Font = new System.Drawing.Font("Titr", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tblStudent.Location = new System.Drawing.Point(251, 13);
            this.tblStudent.Margin = new System.Windows.Forms.Padding(4);
            this.tblStudent.Name = "tblStudent";
            this.tblStudent.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tblStudent.RowCount = 4;
            this.tblStudent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tblStudent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tblStudent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tblStudent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tblStudent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblStudent.Size = new System.Drawing.Size(548, 197);
            this.tblStudent.TabIndex = 10;
            this.tblStudent.Paint += new System.Windows.Forms.PaintEventHandler(this.tblStudent_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Titr", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(328, 2);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 40);
            this.label2.TabIndex = 0;
            this.label2.Text = "شناسه دانشجو انتخابی";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(498, 49);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 40);
            this.label4.TabIndex = 0;
            this.label4.Text = "رمز";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtStudentId
            // 
            this.txtStudentId.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtStudentId.Location = new System.Drawing.Point(5, 5);
            this.txtStudentId.Name = "txtStudentId";
            this.txtStudentId.Size = new System.Drawing.Size(279, 32);
            this.txtStudentId.TabIndex = 1;
            // 
            // txtStudentPass
            // 
            this.txtStudentPass.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtStudentPass.Location = new System.Drawing.Point(5, 52);
            this.txtStudentPass.Name = "txtStudentPass";
            this.txtStudentPass.PasswordChar = '*';
            this.txtStudentPass.Size = new System.Drawing.Size(279, 32);
            this.txtStudentPass.TabIndex = 2;
            this.txtStudentPass.TextChanged += new System.EventHandler(this.txtStudentPass_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Titr", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(500, 96);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 40);
            this.label1.TabIndex = 3;
            this.label1.Text = "نام";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtname
            // 
            this.txtname.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtname.Location = new System.Drawing.Point(5, 99);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(279, 32);
            this.txtname.TabIndex = 5;
            this.txtname.TextChanged += new System.EventHandler(this.txtname_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Titr", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(483, 143);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 40);
            this.label3.TabIndex = 6;
            this.label3.Text = "گروه";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbgroup
            // 
            this.cbgroup.FormattingEnabled = true;
            this.cbgroup.Items.AddRange(new object[] {
            "کامپیوتر"});
            this.cbgroup.Location = new System.Drawing.Point(5, 146);
            this.cbgroup.Name = "cbgroup";
            this.cbgroup.Size = new System.Drawing.Size(279, 45);
            this.cbgroup.TabIndex = 11;
            this.cbgroup.SelectedIndexChanged += new System.EventHandler(this.cbgroup_SelectedIndexChanged);
            // 
            // pbr
            // 
            this.pbr.Location = new System.Drawing.Point(12, 462);
            this.pbr.Name = "pbr";
            this.pbr.Size = new System.Drawing.Size(841, 36);
            this.pbr.TabIndex = 11;
            this.pbr.Value = 10;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(865, 510);
            this.Controls.Add(this.pbr);
            this.Controls.Add(this.tblStudent);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Enterbt);
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tblStudent.ResumeLayout(false);
            this.tblStudent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Enterbt;
        private System.Windows.Forms.TableLayoutPanel tblStudent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtStudentId;
        public System.Windows.Forms.TextBox txtStudentPass;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbgroup;
        private System.Windows.Forms.ProgressBar pbr;
    }
}