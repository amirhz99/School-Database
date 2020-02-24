namespace SCHOOL_DATABASE
{
    partial class SelectUnit
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
            this.DgStudentCourseTerm = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnchange = new System.Windows.Forms.Button();
            this.btncheck = new System.Windows.Forms.Button();
            this.lblStudentID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgStudentCourseTerm)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgStudentCourseTerm
            // 
            this.DgStudentCourseTerm.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgStudentCourseTerm.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.DgStudentCourseTerm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgStudentCourseTerm.Dock = System.Windows.Forms.DockStyle.Top;
            this.DgStudentCourseTerm.Location = new System.Drawing.Point(0, 0);
            this.DgStudentCourseTerm.MultiSelect = false;
            this.DgStudentCourseTerm.Name = "DgStudentCourseTerm";
            this.DgStudentCourseTerm.ReadOnly = true;
            this.DgStudentCourseTerm.RowTemplate.Height = 24;
            this.DgStudentCourseTerm.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgStudentCourseTerm.Size = new System.Drawing.Size(1020, 422);
            this.DgStudentCourseTerm.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnchange, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btncheck, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 428);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1020, 52);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // btnchange
            // 
            this.btnchange.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnchange.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnchange.Font = new System.Drawing.Font("Mj_Digital Arabia XL", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnchange.Location = new System.Drawing.Point(3, 3);
            this.btnchange.Name = "btnchange";
            this.btnchange.Size = new System.Drawing.Size(504, 46);
            this.btnchange.TabIndex = 1;
            this.btnchange.Text = "اعمال تغییرات";
            this.btnchange.UseVisualStyleBackColor = false;
            this.btnchange.Click += new System.EventHandler(this.btnchange_Click);
            // 
            // btncheck
            // 
            this.btncheck.BackColor = System.Drawing.Color.LawnGreen;
            this.btncheck.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btncheck.Font = new System.Drawing.Font("Mj_Digital Arabia XL", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btncheck.Location = new System.Drawing.Point(513, 3);
            this.btncheck.Name = "btncheck";
            this.btncheck.Size = new System.Drawing.Size(504, 46);
            this.btncheck.TabIndex = 0;
            this.btncheck.Text = "بررسی تغییرات";
            this.btncheck.UseVisualStyleBackColor = false;
            this.btncheck.Click += new System.EventHandler(this.btncheck_Click);
            // 
            // lblStudentID
            // 
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.Location = new System.Drawing.Point(831, 344);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(0, 17);
            this.lblStudentID.TabIndex = 2;
            // 
            // SelectUnit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 480);
            this.Controls.Add(this.lblStudentID);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.DgStudentCourseTerm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SelectUnit";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "SelectUnit";
            this.Load += new System.EventHandler(this.SelectUnit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgStudentCourseTerm)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgStudentCourseTerm;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnchange;
        private System.Windows.Forms.Button btncheck;
        public System.Windows.Forms.Label lblStudentID;
    }
}