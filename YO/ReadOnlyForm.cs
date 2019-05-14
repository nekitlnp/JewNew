using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassJew;

namespace YO
{
    public partial class ReadOnlyForm : Form
    {
        public ReadOnlyForm()
        {
            InitializeComponent();
        }

        public Jewelry Jewelry { get; set; }
        

        private void ReadOnlyForm_Load(object sender, EventArgs e)
        {
            textBox1.Text = Jewelry.JewType;
            textBox3.Text = Jewelry.DateOfReady.ToString();
            textBox2.Text = Jewelry.DateOfDel.ToString();
            textBox4.Text = Jewelry.MetType.ToString();
            textBox5.Text = Jewelry.Description;
            var ms = new MemoryStream(Jewelry.Photo);
            pictureBox1.Image = Image.FromStream(ms);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult =  DialogResult.OK;
        }
    }
}
