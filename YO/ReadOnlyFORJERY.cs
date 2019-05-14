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
    public partial class ReadOnlyFORJERY : Form
    {
        public BlockJewelry BlockJewerly { get; set; }
        public ReadOnlyFORJERY()
        {
            InitializeComponent();
        }

        private void ReadOnlyFORJURY_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < BlockJewerly.ContactDetails.Count; i++)
            {
                textBox2.Text += BlockJewerly.ContactDetails[i].ToString();
            }
            textBox1.Text = BlockJewerly.NameCostumer;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
