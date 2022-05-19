using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NMU_project_1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            string Account_Name = txt_account_name.Text;
            //Needs to be only numbers (Account_number,Id)
            string Account_Nmuber = txt_account_num.Text;  
            string Id = txt_id.Text;
            this.Hide();
            Form2 frm2 = new Form2();
            frm2.Show();

        }


        private bool charschecker(string x)
        {
            if(x.Length < 1) return false;
            for (int i = 0; i < x.Length; ++i)
            {
                if (!(x[i] >= 'A' && x[i] <= 'z') && !(x[i] >= 'a' && x[i] <= 'Z')) return false;
            }
            return true; 
        }

        private void btn_create_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            logo.BorderStyle = BorderStyle.None;
            btn_Exit.FlatStyle = FlatStyle.Flat;
            btn_Exit.FlatAppearance.BorderSize = 0;
            btn_Min.FlatStyle = FlatStyle.Flat;
            btn_Min.FlatAppearance.BorderSize = 0;
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btn_MIn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
           
        }
        private void btn_Exit_MouseHover(object sender, EventArgs e)
        {
            btn_Exit.BackColor = Color.Red;
        }

        private void btn_Exit_MouseLeave(object sender, EventArgs e)
        {
            btn_Exit.BackColor = Color.CadetBlue;
        }

        private void btn_Min_MouseHover(object sender, EventArgs e)
        {
            btn_Min.BackColor = Color.SkyBlue;
        }

        private void btn_Min_MouseLeave(object sender, EventArgs e)
        {
            btn_Min.BackColor = Color.CadetBlue;
        }
    }
}
