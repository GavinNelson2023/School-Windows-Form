using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A_New_windows_class_thing
{
    public partial class Form1 : Form
    {
        string fName;
        string lName;
        string Email;
        bool Sms;
        bool Reports;
        bool Transactions;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblsmsmessage.Text = "";
            lblreportsmessage.Text = "";
            lbltransactionsmessage.Text = "";

            lblsmsmessage.ForeColor = System.Drawing.Color.Red;
            lbltransactionsmessage.ForeColor = System.Drawing.Color.Red;
            lblreportsmessage.ForeColor = System.Drawing.Color.Red;
        }

        private void chksms_CheckedChanged(object sender, EventArgs e)
        {
            if(chksms.Checked)
            {
                lblsmsmessage.Text = "Service Rates May Apply.";
            }
            else
            {
                lblsmsmessage.Text = "";
            }
        }

        private void chkreport_CheckedChanged(object sender, EventArgs e)
        {
            if (chkreport.Checked)
            {
                lblreportsmessage.Text = "Service Rates May Apply.";
            }
            else
            {
                lblreportsmessage.Text = "";
            }
        }

        private void chktransaction_CheckedChanged(object sender, EventArgs e)
        {
            if (chktransaction.Checked)
            {
                lbltransactionsmessage.Text = "Service Rates May Apply.";
            }
            else
            {
                lbltransactionsmessage.Text = "";
            }
        }

        private void Signup()
        {
            fName = txtFname.Text;
            lName = txtLname.Text;
            Email = txtEmail.Text;
            Sms = chksms.Checked;
            Reports = chkreport.Checked;
            Transactions = chktransaction.Checked;

            Confirmation n = new Confirmation(fName, lName, Email, Sms, Reports, Transactions);
            n.Show();
        }

        private void btnsignup_Click(object sender, EventArgs e)
        {
            Signup();
        }
    }
}
