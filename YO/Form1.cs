using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using ClassJew;

namespace YO
{
    public partial class Form1 : Form
    {
        public List<Jewelry> Jew = new List<Jewelry>();
        public List<BlockJewelry> Contacts = new List<BlockJewelry>();
        public string Data5 { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button2.Enabled = listBox1.SelectedItem is Jewelry;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)) && !((e.KeyChar == '/') && (textBox1.Text.IndexOf("/") == -1)))
            {
                if (e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var jewelry = new Jewelry();
            jewelry.DateOfDel = textBox2.Text;
            jewelry.JewType = textBox1.Text;
            jewelry.MetType = textBox3.Text;
            jewelry.Description = textBox4.Text;



            jewelry.DateOfReady = Data5 = dateTimePicker1.Value.ToString("dd/MM/yyyy");
            var stream = new MemoryStream();
            pictureBox1.Image.Save(stream, ImageFormat.Jpeg);
            jewelry.Photo = stream.ToArray();
            pictureBox1.Image = new Bitmap("D:\\AnyTask\\Jewelry\\ClassField\\2057.jpg");
            listBox1.Items.Add(jewelry.JewType);
            Jew.Add(jewelry);
            tabControl1.SelectedIndex = 1;
            textBox2.Text = "";
            textBox1.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            int index = this.listBox1.IndexFromPoint(e.Location);
            Jewelry item = new Jewelry();
            if (index != ListBox.NoMatches)
            {
                foreach (Jewelry tmp in Jew)
                {
                    if (tmp.JewType == listBox1.Items[index])
                        item = tmp;
                }
                var ff = new ReadOnlyForm() { Jewelry = item };
                ff.ShowDialog(this);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog() { Filter = "Фотография|*.jpg" };
            var dr = ofd.ShowDialog(this);
            if (dr == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(ofd.FileName);
            }
        }





        private void button4_Click(object sender, EventArgs e)
        {
            Jewelry item = new Jewelry();
            foreach (Jewelry tmp in Jew)
            {
                if (tmp.JewType == listBox1.SelectedItem)
                    item = tmp;
            }

            listBox1.Items.Remove(listBox1.SelectedItem);
            Jew.Remove(item);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem is BlockJewelry)
            {
                Contacts.Remove((BlockJewelry)listBox2.SelectedItem);
                listBox2.Items.Remove(listBox2.SelectedItem);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox2.DisplayMember = "NameCostumer";
            var Jury = new Form3();
            Jury.ShowDialog();
            if (Jury.DialogResult == DialogResult.OK)
            {
                listBox2.Items.Add(Form3.Data4);
                Contacts.Add(Form3.Data4);
            }
        }

        private void listBox2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.listBox2.IndexFromPoint(e.Location);
            if (index != ListBox.NoMatches)
            {
                var item = (BlockJewelry)Contacts[index];
                var ff = new ReadOnlyFORJERY() { BlockJewerly = item };
                ff.ShowDialog(this);
                /*if (ff.ShowDialog(this) == DialogResult.OK)
                {
                    listBox2.Items.Remove(item);
                    listBox2.Items.Insert(index, item);
                }*/
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabControl1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_2(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog() { Filter = "Тип изделия|*.jewelry" };
            if (sfd.ShowDialog(this) != DialogResult.OK)
                return;
/*            var jewelry = new Jewelry()
            {
                DateOfDel = textBox2.Text,
                JewType = textBox1.Text,
                MetType = textBox3.Text,
                Description = textBox4.Text,
                DateOfReady = Data5,
            };*/

            /*Jewelery*/
            var xs = new XmlSerializer(typeof(List<Jewelry>));
            var file = File.Create(sfd.FileName);
            xs.Serialize(file, Jew);
            file.Close();
            
            /*Contacts*/
            xs = new XmlSerializer(typeof(List<BlockJewelry>));
            file = File.Create(sfd.FileName.Replace("jewelry", "contac"));
            xs.Serialize(file, Contacts);
            file.Close();
            /*var sfd = new SaveFileDialog() { Filter = "Тип изделия|*.jewelry" };

            if (sfd.ShowDialog(this) != DialogResult.OK)
                return;

            var jewelry = new Jewelry()
            {
                DateOfDel = textBox2.Text,
                JewType = textBox1.Text,
                MetType = textBox3.Text,
                Description = textBox4.Text,
                DateOfReady = Data5 = dateTimePicker1.Value.ToString("dd/MM/yyyy"),
            };

            var stream = new MemoryStream();
            pictureBox1.Image.Save(stream, ImageFormat.Jpeg);
            jewelry.Photo = stream.ToArray();

            var xs = new XmlSerializer(typeof(Jewelry));

            var file = File.Create(sfd.FileName);

            xs.Serialize(file, jewelry);
            file.Close();*/
        }

        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog() { Filter = "Тип изделия|*.jewelry" };
            if (ofd.ShowDialog(this) != DialogResult.OK)
                return;


            var xs = new XmlSerializer(typeof(List<Jewelry>));
            var file = File.OpenRead(ofd.FileName);
            Jew = (List<Jewelry>)xs.Deserialize(file);
            file.Close();
            
            listBox1.Items.Clear();
            foreach (var Competitor in Jew)
            {
                listBox1.Items.Add(Competitor.JewType);
            }

            /*Contacts*/
            if (File.Exists(ofd.FileName.Replace("jewelry", "contac")) ){
                xs = new XmlSerializer(typeof(List<BlockJewelry>));

                file = File.OpenRead(ofd.FileName.Replace("jewelry", "contac"));
                Contacts = (List<BlockJewelry>)xs.Deserialize(file);
                file.Close();
                listBox2.Items.Clear();
                foreach (var Jury in Contacts)
                {
                    listBox2.Items.Add(Jury);
                }
            }
        }
    }
}




