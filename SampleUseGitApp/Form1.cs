using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SampleUseGitApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Model1 db = new Model1();
        private void Form1_Load(object sender, EventArgs e)
        {
            productBindingSource.DataSource = db.Products.ToList();
        }

        private void productBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
