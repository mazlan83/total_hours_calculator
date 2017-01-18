using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public DateTime endTime;
        public DateTime startTime;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            string input;

            try
            {
                input = txtStart.Text;
                input = input.Trim();

                startTime = Convert.ToDateTime(input);
                var hours = (endTime - startTime).TotalHours;

                MessageBox.Show(hours.ToString("N2") + " hours");
            }
            catch (Exception ex)
            {
                MessageBox.Show( "Error: " + ex );
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            updatetime();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            updatetime();
        }

        private void updatetime()
        {
            endTime = DateTime.Now;
            txtCurrent.Text = endTime.ToString();
        }
    }
}
