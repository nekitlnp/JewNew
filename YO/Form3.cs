using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassField;

namespace YO
{
    public partial class Form3 : Form
    {
        public static BlockJewelry Data4 { get; set; }
        public List<string> Data5 { get; set; }

        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Names;
            var Jury = new BlockJewelry();
            Jury.ContactDetails = new List<string>();
            Jury.NameCostumer = textBox5.Text;
            Names = textBox1.Text + Environment.NewLine + textBox2.Text;
                Jury.ContactDetails.Add(Names); /*Data5.Add(Names[i])*/;
            DialogResult = DialogResult.OK;
            Data4 = Jury;
        }      
    }
}
