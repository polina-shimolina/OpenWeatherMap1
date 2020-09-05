using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public string url=string.Empty;
        Class weath;
        public Form1()
        {
            InitializeComponent();
            weath = new Class();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            url += "http://api.openweathermap.org/data/2.5/weather?q=";
            url += comboBox1.SelectedItem.ToString();
            url += "&appid = ecc0ea77210f8032ef8804a80a9f40f0 & units = metric";
            
            weath.ChangeRequest(url);
               //MessageBox.Show(comboBox1.SelectedItem.ToString());  
            weath.Search();
              
            weath.MessageShow();
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
