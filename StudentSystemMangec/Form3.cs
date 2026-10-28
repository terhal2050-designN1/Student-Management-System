using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace StudentSystemMangec
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.Columns.Add("name", 50);
            listView1.Columns.Add("age", 50);
            listView1.Columns.Add("city", 50);
            listView1.Columns.Add("emile", 50);
         
        }

        private void butcoler_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void butmessag_Click(object sender, EventArgs e)
        {
            MessageBox.Show("helo");

        }

        private void butexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void radBtnmul_CheckedChanged(object sender, EventArgs e)
        {
            double num1, num2;
            bool isValid1=double.TryParse(textBox1.Text, out num1);
            bool isValid2 = double.TryParse(textBox2.Text, out num2);
            if (isValid1 && isValid2)
            {
                double result = Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox2.Text);
                labelresult.Text = "result" + result.ToString();
            }
            else
            {
                labelresult.Text = "Invalid Input";
            }
            
        }

        private void radBtnsub_CheckedChanged(object sender, EventArgs e)
        {
            double num1, num2;
            bool isValid1 = double.TryParse(textBox1.Text, out num1);
            bool isValid2 = double.TryParse(textBox2.Text, out num2);
            if (isValid1 && isValid2)
            {
                double result = Convert.ToDouble(textBox1.Text) - Convert.ToDouble(textBox2.Text);
                labelresult.Text = "result" + result.ToString();
            }
            else
            {
                labelresult.Text = "Invalid Input";
            }
        }

        private void radBtnadd_CheckedChanged(object sender, EventArgs e)
        {
            double num1, num2;
            bool isValid1 = double.TryParse(textBox1.Text, out num1);
            bool isValid2 = double.TryParse(textBox2.Text, out num2);
            if (isValid1 && isValid2)
            {
                double result = Convert.ToDouble(textBox1.Text) + Convert.ToDouble(textBox2.Text);
                labelresult.Text = "result" + result.ToString();
            }
            else
            {
                labelresult.Text = "Invalid Input";
            }

        }

        private void labelresult_Click(object sender, EventArgs e)
        {

        }

        private void buttclear_Click(object sender, EventArgs e)
        {
           textBox1.Clear();
            textBox2.Clear();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            progressBar1.Value=0;
        }
        int scend = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            scend++;
            label1.Text="scend"+scend.ToString();
            
            if(progressBar1.Value<100)
            {
                progressBar1.Value += 5;
            }
            else
            {
               
                timer1.Stop();
                MessageBox.Show("تم اكتمال العمليه");
            } 
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void recet_Click(object sender, EventArgs e)
        {
            scend = 0;
            progressBar1.Value = 0;
            label1.Text = "0 scend";

        }

        private void stop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        bool fs()
        {
            if(textBxname.Text==""|| textBxage.Text==""|| textBxcity.Text==""|| textBxEmial.Text=="")
            {
                return true;
            }
            return false;
        }
        private void buttcombx_Click(object sender, EventArgs e)
        {
            if (fs())
            {
                MessageBox.Show("error");
            }
            else
            {
                ListViewItem item = new ListViewItem(textBxname.Text);

                item.SubItems.Add(textBxage.Text);
                item.SubItems.Add(textBxcity.Text);
                item.SubItems.Add(textBxEmial.Text);

                listView1.Items.Add(item);
            }
        }

           /* if (textcomp.Text != "" && !comboBox1.Items.Contains(textcomp.Text))
            { comboBox1.Items.Add(textcomp.Text); }
        
       
        else{
                MessageBox.Show("خطا اعد ادخال البيانات");
        }
        }*/
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelcombox_Click(object sender, EventArgs e)
        {

        }

        private void buttshow_Click(object sender, EventArgs e)
        {
            labelcombox.Text=comboBox1.Text;
            
            ListViewItem item = new ListViewItem(textBxname.Text);
            item.SubItems.Add(textBxage.Text);
            item.SubItems.Add(textBxcity.Text);
            item.SubItems.Add(textBxEmial.Text);

            listView1.Items.Add(item);
           


        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
           

           


        }

        private void textBxname_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBxage_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBxEmial_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBxcity_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttDelet_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                listView1.Items.Remove(listView1.SelectedItems[0]);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hello");
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hello");
        }

        private void butsav_Click(object sender, EventArgs e)
        {
          
           
            if (textBxFile.Text != "")
            { File.WriteAllText("ser.txt", textBxFile.Text);
                MessageBox.Show(" save");
            }
            else
            {
                MessageBox.Show("not save");
            }
        }

        private void textBxFile_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttload_Click(object sender, EventArgs e)
        {


            if (File.Exists("s.txt"))
            {
                string datafile = File.ReadAllText("ser.txt");
              textBxFile.Text = datafile;
                MessageBox.Show("load");
            }
            else
            {
                MessageBox.Show("not load");
            }
        }

        private void buttopen_Click(object sender, EventArgs e)
        {
            war a = new war(textBxFile.Text);
          a.Show();
        }
    }
}
