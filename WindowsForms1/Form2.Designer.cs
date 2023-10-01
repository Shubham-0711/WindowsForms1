namespace WindowsForms1
{
    partial class Form_Employee_Details
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
            this.lblEmployeeID = new System.Windows.Forms.Label();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.lblBasicSalary = new System.Windows.Forms.Label();
            this.lbHRA = new System.Windows.Forms.Label();
            this.lblTA = new System.Windows.Forms.Label();
            this.lblda = new System.Windows.Forms.Label();
            this.lblPF = new System.Windows.Forms.Label();
            this.lblGrossSalary = new System.Windows.Forms.Label();
            this.txtEmpId = new System.Windows.Forms.TextBox();
            this.txtEmpname = new System.Windows.Forms.TextBox();
            this.txtbasicsalary = new System.Windows.Forms.TextBox();
            this.cmbDEPTlist = new System.Windows.Forms.ComboBox();
            this.txtHra = new System.Windows.Forms.TextBox();
            this.txtTa = new System.Windows.Forms.TextBox();
            this.txtDA = new System.Windows.Forms.TextBox();
            this.txtGrossSalry = new System.Windows.Forms.TextBox();
            this.txtPF = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.lblmsg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblEmployeeID
            // 
            this.lblEmployeeID.AutoSize = true;
            this.lblEmployeeID.Location = new System.Drawing.Point(56, 23);
            this.lblEmployeeID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmployeeID.Name = "lblEmployeeID";
            this.lblEmployeeID.Size = new System.Drawing.Size(85, 16);
            this.lblEmployeeID.TabIndex = 0;
            this.lblEmployeeID.Text = "Employee ID";
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.AutoSize = true;
            this.lblEmployeeName.Location = new System.Drawing.Point(56, 86);
            this.lblEmployeeName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(109, 16);
            this.lblEmployeeName.TabIndex = 1;
            this.lblEmployeeName.Text = "Employee Name";
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Location = new System.Drawing.Point(60, 150);
            this.lblDepartment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(77, 16);
            this.lblDepartment.TabIndex = 2;
            this.lblDepartment.Text = "Department";
            // 
            // lblBasicSalary
            // 
            this.lblBasicSalary.AutoSize = true;
            this.lblBasicSalary.Location = new System.Drawing.Point(60, 214);
            this.lblBasicSalary.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBasicSalary.Name = "lblBasicSalary";
            this.lblBasicSalary.Size = new System.Drawing.Size(83, 16);
            this.lblBasicSalary.TabIndex = 3;
            this.lblBasicSalary.Text = "Basic Salary";
            // 
            // lbHRA
            // 
            this.lbHRA.AutoSize = true;
            this.lbHRA.Location = new System.Drawing.Point(82, 340);
            this.lbHRA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbHRA.Name = "lbHRA";
            this.lbHRA.Size = new System.Drawing.Size(36, 16);
            this.lbHRA.TabIndex = 4;
            this.lbHRA.Text = "HRA";
            // 
            // lblTA
            // 
            this.lblTA.AutoSize = true;
            this.lblTA.Location = new System.Drawing.Point(81, 413);
            this.lblTA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTA.Name = "lblTA";
            this.lblTA.Size = new System.Drawing.Size(25, 16);
            this.lblTA.TabIndex = 5;
            this.lblTA.Text = "TA";
            // 
            // lblda
            // 
            this.lblda.AutoSize = true;
            this.lblda.Location = new System.Drawing.Point(81, 468);
            this.lblda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblda.Name = "lblda";
            this.lblda.Size = new System.Drawing.Size(26, 16);
            this.lblda.TabIndex = 6;
            this.lblda.Text = "DA";
            // 
            // lblPF
            // 
            this.lblPF.AutoSize = true;
            this.lblPF.Location = new System.Drawing.Point(82, 531);
            this.lblPF.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPF.Name = "lblPF";
            this.lblPF.Size = new System.Drawing.Size(24, 16);
            this.lblPF.TabIndex = 7;
            this.lblPF.Text = "PF";
            // 
            // lblGrossSalary
            // 
            this.lblGrossSalary.AutoSize = true;
            this.lblGrossSalary.Location = new System.Drawing.Point(60, 587);
            this.lblGrossSalary.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGrossSalary.Name = "lblGrossSalary";
            this.lblGrossSalary.Size = new System.Drawing.Size(111, 16);
            this.lblGrossSalary.TabIndex = 8;
            this.lblGrossSalary.Text = "GROSS SALARY";
            // 
            // txtEmpId
            // 
            this.txtEmpId.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtEmpId.Location = new System.Drawing.Point(203, 15);
            this.txtEmpId.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmpId.Name = "txtEmpId";
            this.txtEmpId.Size = new System.Drawing.Size(231, 22);
            this.txtEmpId.TabIndex = 9;
            // 
            // txtEmpname
            // 
            this.txtEmpname.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtEmpname.Location = new System.Drawing.Point(203, 78);
            this.txtEmpname.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmpname.Name = "txtEmpname";
            this.txtEmpname.Size = new System.Drawing.Size(231, 22);
            this.txtEmpname.TabIndex = 10;
            // 
            // txtbasicsalary
            // 
            this.txtbasicsalary.Location = new System.Drawing.Point(203, 206);
            this.txtbasicsalary.Margin = new System.Windows.Forms.Padding(4);
            this.txtbasicsalary.Name = "txtbasicsalary";
            this.txtbasicsalary.Size = new System.Drawing.Size(231, 22);
            this.txtbasicsalary.TabIndex = 11;
            // 
            // cmbDEPTlist
            // 
            this.cmbDEPTlist.BackColor = System.Drawing.SystemColors.MenuBar;
            this.cmbDEPTlist.FormattingEnabled = true;
            this.cmbDEPTlist.Location = new System.Drawing.Point(203, 139);
            this.cmbDEPTlist.Margin = new System.Windows.Forms.Padding(4);
            this.cmbDEPTlist.Name = "cmbDEPTlist";
            this.cmbDEPTlist.Size = new System.Drawing.Size(200, 24);
            this.cmbDEPTlist.TabIndex = 12;
            this.cmbDEPTlist.SelectedIndexChanged += new System.EventHandler(this.cmbDEPTlist_SelectedIndexChanged);
            // 
            // txtHra
            // 
            this.txtHra.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtHra.Location = new System.Drawing.Point(203, 340);
            this.txtHra.Margin = new System.Windows.Forms.Padding(4);
            this.txtHra.Name = "txtHra";
            this.txtHra.ReadOnly = true;
            this.txtHra.Size = new System.Drawing.Size(231, 22);
            this.txtHra.TabIndex = 13;
            this.txtHra.TextChanged += new System.EventHandler(this.txtHra_TextChanged);
            // 
            // txtTa
            // 
            this.txtTa.Location = new System.Drawing.Point(203, 413);
            this.txtTa.Margin = new System.Windows.Forms.Padding(4);
            this.txtTa.Name = "txtTa";
            this.txtTa.ReadOnly = true;
            this.txtTa.Size = new System.Drawing.Size(231, 22);
            this.txtTa.TabIndex = 14;
            this.txtTa.TextChanged += new System.EventHandler(this.txtTa_TextChanged);
            // 
            // txtDA
            // 
            this.txtDA.Location = new System.Drawing.Point(203, 465);
            this.txtDA.Margin = new System.Windows.Forms.Padding(4);
            this.txtDA.Name = "txtDA";
            this.txtDA.ReadOnly = true;
            this.txtDA.Size = new System.Drawing.Size(231, 22);
            this.txtDA.TabIndex = 15;
            this.txtDA.TextChanged += new System.EventHandler(this.txtDA_TextChanged);
            // 
            // txtGrossSalry
            // 
            this.txtGrossSalry.Location = new System.Drawing.Point(203, 581);
            this.txtGrossSalry.Margin = new System.Windows.Forms.Padding(4);
            this.txtGrossSalry.Name = "txtGrossSalry";
            this.txtGrossSalry.ReadOnly = true;
            this.txtGrossSalry.Size = new System.Drawing.Size(231, 22);
            this.txtGrossSalry.TabIndex = 16;
            this.txtGrossSalry.TextChanged += new System.EventHandler(this.txtGrossSalry_TextChanged);
            // 
            // txtPF
            // 
            this.txtPF.Location = new System.Drawing.Point(203, 525);
            this.txtPF.Margin = new System.Windows.Forms.Padding(4);
            this.txtPF.Name = "txtPF";
            this.txtPF.ReadOnly = true;
            this.txtPF.Size = new System.Drawing.Size(231, 22);
            this.txtPF.TabIndex = 17;
            this.txtPF.TextChanged += new System.EventHandler(this.txtPF_TextChanged);
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCalculate.Location = new System.Drawing.Point(203, 265);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(94, 26);
            this.btnCalculate.TabIndex = 19;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnDisplay
            // 
            this.btnDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnDisplay.Location = new System.Drawing.Point(342, 265);
            this.btnDisplay.Margin = new System.Windows.Forms.Padding(4);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(92, 26);
            this.btnDisplay.TabIndex = 20;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = false;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // lblmsg
            // 
            this.lblmsg.AutoSize = true;
            this.lblmsg.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblmsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F);
            this.lblmsg.Location = new System.Drawing.Point(551, 140);
            this.lblmsg.Name = "lblmsg";
            this.lblmsg.Size = new System.Drawing.Size(43, 18);
            this.lblmsg.TabIndex = 21;
            this.lblmsg.Text = "MSG";
            this.lblmsg.Click += new System.EventHandler(this.lblmsg_Click);
            // 
            // Form_Employee_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(997, 846);
            this.Controls.Add(this.lblmsg);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtPF);
            this.Controls.Add(this.txtGrossSalry);
            this.Controls.Add(this.txtDA);
            this.Controls.Add(this.txtTa);
            this.Controls.Add(this.txtHra);
            this.Controls.Add(this.cmbDEPTlist);
            this.Controls.Add(this.txtbasicsalary);
            this.Controls.Add(this.txtEmpname);
            this.Controls.Add(this.txtEmpId);
            this.Controls.Add(this.lblGrossSalary);
            this.Controls.Add(this.lblPF);
            this.Controls.Add(this.lblda);
            this.Controls.Add(this.lblTA);
            this.Controls.Add(this.lbHRA);
            this.Controls.Add(this.lblBasicSalary);
            this.Controls.Add(this.lblDepartment);
            this.Controls.Add(this.lblEmployeeName);
            this.Controls.Add(this.lblEmployeeID);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_Employee_Details";
            this.Text = "Employee Details";
            this.Load += new System.EventHandler(this.Form_Employee_Details_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmployeeID;
        private System.Windows.Forms.Label lblEmployeeName;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Label lblBasicSalary;
        private System.Windows.Forms.Label lbHRA;
        private System.Windows.Forms.Label lblTA;
        private System.Windows.Forms.Label lblda;
        private System.Windows.Forms.Label lblPF;
        private System.Windows.Forms.Label lblGrossSalary;
        private System.Windows.Forms.TextBox txtEmpId;
        private System.Windows.Forms.TextBox txtEmpname;
        private System.Windows.Forms.TextBox txtbasicsalary;
        private System.Windows.Forms.ComboBox cmbDEPTlist;
        private System.Windows.Forms.TextBox txtHra;
        private System.Windows.Forms.TextBox txtTa;
        private System.Windows.Forms.TextBox txtDA;
        private System.Windows.Forms.TextBox txtGrossSalry;
        private System.Windows.Forms.TextBox txtPF;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Label lblmsg;
    }
}