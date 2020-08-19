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
        public string url;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    {

                        url = "http://api.openweathermap.org/data/2.5/weather?q=Moscow&appid=ecc0ea77210f8032ef8804a80a9f40f0&units=metric";
                        break;
                    }
                case 1:
                    {
                        url = "http://api.openweathermap.org/data/2.5/weather?q=London&appid=ecc0ea77210f8032ef8804a80a9f40f0&units=metric";
                        break;
                    }
                case 2:
                    {
                        url = "http://api.openweathermap.org/data/2.5/weather?q=Washington&appid=ecc0ea77210f8032ef8804a80a9f40f0&units=metric";
                        break;
                    }
                case 3:
                    {
                        url = "http://api.openweathermap.org/data/2.5/weather?q=Minsk&appid=ecc0ea77210f8032ef8804a80a9f40f0&units=metric";
                        break;
                    }
                case 4:
                    {
                        url = "http://api.openweathermap.org/data/2.5/weather?q=Kiev&appid=ecc0ea77210f8032ef8804a80a9f40f0&units=metric";
                        break;
                    }
            }
            Class weath = new Class(url);
            weath.Search();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
