namespace A_New_windows_class_thing
{
    partial class Form1
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
            this.lblfirstname = new System.Windows.Forms.Label();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.txtLname = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lbllastname = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbltransactionsmessage = new System.Windows.Forms.Label();
            this.lblreportsmessage = new System.Windows.Forms.Label();
            this.lblsmsmessage = new System.Windows.Forms.Label();
            this.chktransaction = new System.Windows.Forms.CheckBox();
            this.chkreport = new System.Windows.Forms.CheckBox();
            this.chksms = new System.Windows.Forms.CheckBox();
            this.btnsignup = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblfirstname
            // 
            this.lblfirstname.AutoSize = true;
            this.lblfirstname.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfirstname.Location = new System.Drawing.Point(12, 45);
            this.lblfirstname.Name = "lblfirstname";
            this.lblfirstname.Size = new System.Drawing.Size(96, 21);
            this.lblfirstname.TabIndex = 0;
            this.lblfirstname.Text = "First Name:";
            // 
            // txtFname
            // 
            this.txtFname.Location = new System.Drawing.Point(165, 45);
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(400, 20);
            this.txtFname.TabIndex = 1;
            // 
            // txtLname
            // 
            this.txtLname.Location = new System.Drawing.Point(165, 83);
            this.txtLname.Name = "txtLname";
            this.txtLname.Size = new System.Drawing.Size(400, 20);
            this.txtLname.TabIndex = 2;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(165, 128);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(400, 20);
            this.txtEmail.TabIndex = 3;
            // 
            // lbllastname
            // 
            this.lbllastname.AutoSize = true;
            this.lbllastname.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllastname.Location = new System.Drawing.Point(12, 83);
            this.lbllastname.Name = "lbllastname";
            this.lbllastname.Size = new System.Drawing.Size(94, 21);
            this.lbllastname.TabIndex = 4;
            this.lbllastname.Text = "Last Name:";
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemail.Location = new System.Drawing.Point(12, 127);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(122, 21);
            this.lblemail.TabIndex = 5;
            this.lblemail.Text = "Email Address:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbltransactionsmessage);
            this.groupBox1.Controls.Add(this.lblreportsmessage);
            this.groupBox1.Controls.Add(this.lblsmsmessage);
            this.groupBox1.Controls.Add(this.chktransaction);
            this.groupBox1.Controls.Add(this.chkreport);
            this.groupBox1.Controls.Add(this.chksms);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(41, 204);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(524, 199);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Services";
            // 
            // lbltransactionsmessage
            // 
            this.lbltransactionsmessage.AutoSize = true;
            this.lbltransactionsmessage.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltransactionsmessage.Location = new System.Drawing.Point(194, 121);
            this.lbltransactionsmessage.Name = "lbltransactionsmessage";
            this.lbltransactionsmessage.Size = new System.Drawing.Size(42, 21);
            this.lbltransactionsmessage.TabIndex = 9;
            this.lbltransactionsmessage.Text = "aaaa";
            // 
            // lblreportsmessage
            // 
            this.lblreportsmessage.AutoSize = true;
            this.lblreportsmessage.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblreportsmessage.Location = new System.Drawing.Point(194, 79);
            this.lblreportsmessage.Name = "lblreportsmessage";
            this.lblreportsmessage.Size = new System.Drawing.Size(42, 21);
            this.lblreportsmessage.TabIndex = 8;
            this.lblreportsmessage.Text = "aaaa";
            // 
            // lblsmsmessage
            // 
            this.lblsmsmessage.AutoSize = true;
            this.lblsmsmessage.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsmsmessage.Location = new System.Drawing.Point(194, 38);
            this.lblsmsmessage.Name = "lblsmsmessage";
            this.lblsmsmessage.Size = new System.Drawing.Size(42, 21);
            this.lblsmsmessage.TabIndex = 7;
            this.lblsmsmessage.Text = "aaaa";
            // 
            // chktransaction
            // 
            this.chktransaction.AutoSize = true;
            this.chktransaction.Location = new System.Drawing.Point(42, 121);
            this.chktransaction.Name = "chktransaction";
            this.chktransaction.Size = new System.Drawing.Size(124, 25);
            this.chktransaction.TabIndex = 2;
            this.chktransaction.Text = "Transactions";
            this.chktransaction.UseVisualStyleBackColor = true;
            this.chktransaction.CheckedChanged += new System.EventHandler(this.chktransaction_CheckedChanged);
            // 
            // chkreport
            // 
            this.chkreport.AutoSize = true;
            this.chkreport.Location = new System.Drawing.Point(42, 79);
            this.chkreport.Name = "chkreport";
            this.chkreport.Size = new System.Drawing.Size(89, 25);
            this.chkreport.TabIndex = 1;
            this.chkreport.Text = "Reports";
            this.chkreport.UseVisualStyleBackColor = true;
            this.chkreport.CheckedChanged += new System.EventHandler(this.chkreport_CheckedChanged);
            // 
            // chksms
            // 
            this.chksms.AutoSize = true;
            this.chksms.Location = new System.Drawing.Point(42, 38);
            this.chksms.Name = "chksms";
            this.chksms.Size = new System.Drawing.Size(67, 25);
            this.chksms.TabIndex = 0;
            this.chksms.Text = "SMS";
            this.chksms.UseVisualStyleBackColor = true;
            this.chksms.CheckedChanged += new System.EventHandler(this.chksms_CheckedChanged);
            // 
            // btnsignup
            // 
            this.btnsignup.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsignup.Location = new System.Drawing.Point(464, 434);
            this.btnsignup.Name = "btnsignup";
            this.btnsignup.Size = new System.Drawing.Size(101, 39);
            this.btnsignup.TabIndex = 7;
            this.btnsignup.Text = "Sign Up";
            this.btnsignup.UseVisualStyleBackColor = true;
            this.btnsignup.Click += new System.EventHandler(this.btnsignup_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 512);
            this.Controls.Add(this.btnsignup);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.lbllastname);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtLname);
            this.Controls.Add(this.txtFname);
            this.Controls.Add(this.lblfirstname);
            this.Name = "Form1";
            this.Text = "Sign Up";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblfirstname;
        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.TextBox txtLname;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lbllastname;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chktransaction;
        private System.Windows.Forms.CheckBox chkreport;
        private System.Windows.Forms.CheckBox chksms;
        private System.Windows.Forms.Label lbltransactionsmessage;
        private System.Windows.Forms.Label lblreportsmessage;
        private System.Windows.Forms.Label lblsmsmessage;
        private System.Windows.Forms.Button btnsignup;
    }
}

