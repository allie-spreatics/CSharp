using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string operation;
        
        // 연산자
        private void plus_Click(object sender, EventArgs e)
        {
            operation = "+";
            input_text.Text = "";
        }
    

        private void minus_Click(object sender, EventArgs e)
        {
            operation = "-";
            input_text.Text = "";


        }
        private void multi_btn_Click(object sender, EventArgs e)
        {
            operation = "*";
            input_text.Text = "";


        }

        private void divide_btn_Click(object sender, EventArgs e)
        {
            operation = "/";
            input_text.Text = "";


        }

        private void remain_btn_Click(object sender, EventArgs e)
        {
            operation = "%";
            input_text.Text = "";


        }

        private void check_history_Click(object sender, EventArgs e)
        {

        }

      

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        

        private void nega_posi_btn_Click(object sender, EventArgs e)
        {

        }

        private void do_calc_btn_Click(object sender, EventArgs e)
        {

        }

        private void reset_btn_Click(object sender, EventArgs e)
        {

        }

        private void del_btn_Click(object sender, EventArgs e)
        {

        }

      
    }
}
