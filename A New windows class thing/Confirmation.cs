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
    public partial class Confirmation : Form
    {
        string fName;
        string lName;
        string Email;
        bool sms;
        bool reports;
        bool transactions;
        public Confirmation(string f, string l, string e, bool s, bool r, bool t)
        {
            InitializeComponent();
            fName = f;
            lName = l;
            Email = e;
            sms = s;
            reports = r;
            transactions = t;
        }

        private void Confirmation_Load(object sender, EventArgs e)
        {
            lblfName.Text = fName;
            lbllName.Text = lName;
            email.Text = Email;

            if(sms)
            {
                lblsms.Text = "✓";
            }
            if(reports)
            {
                lblreports.Text = "✓";
            }
            if(transactions)
            {
                lbltransactions.Text = "✓";
            }
            
        }
    }
}
