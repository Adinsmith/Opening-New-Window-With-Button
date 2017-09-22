using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            Thread t = new Thread(new ThreadStart(splashstart));
            t.Start();
            Thread.Sleep(5000);

            InitializeComponent();
            

            t.Abort();
        }
        public void splashstart()
        {
            Application.Run(new Form2());
        }

        public void nootnoot()
        {
            Application.Run(new Form3());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread v = new Thread(new ThreadStart(nootnoot));
            v.Start();
            Application.Exit();


           
        }
    }
}
