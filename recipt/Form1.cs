using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace feeRecipt
{       //https://www.youtube.com/watch?v=4lHnyHMhoc0
    public partial class FeeRecipt : Form
    {         //Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\infom\source\repos\feeRecipt\feeDetails.accdb
        public FeeRecipt()
        {
            InitializeComponent();
        }
        private void Generate_Click(object sender, EventArgs e)
        {
            txtResult.Clear();
            txtResult.Text +="************************************************************\n\t\t\tFee Recipt";
           // txtResult.Text += "                     Fee Recipt\n"; 
            txtResult.Text += "\n************************************************************";
            txtResult.Text += "\n\n\t\t\t Date:"+DateTime.Now+"\n\n\n\n";
            txtResult.Text += "Student Name : "+Sname.Text+"\n\\n";
            txtResult.Text += "Course Name :"+Course.Text+"\n\n";
           // txtResult.Text += "Amount :" + Amount+ "\n\n";
            txtResult.Text += "Mobile Number :" + MobileNo.Text + "\n\n";
            txtResult.Text += "Amount payable :" + Amount.Text + "\n\n";
            txtResult.Text += "";
        }

        private void Reset_Click(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(txtResult.Text, new Font("Malgun Gothic", 20, FontStyle.Bold), Brushes.Black, new Point(10, 10));
        }

        private void Print_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void Sname_TextChanged(object sender, EventArgs e)
        {

        }

        private void FeeRecipt_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'feeDetailsDataSet.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.feeDetailsDataSet.Student);

        }
    }
}
