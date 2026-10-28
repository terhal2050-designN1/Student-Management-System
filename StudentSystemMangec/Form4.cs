using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentSystemMangec
{
    public partial class war : Form
    {
        public war(string name)
        {
            InitializeComponent();
            label1.Text = name;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sizeprec = 0;
            double addprec = 0;
            string sizename = "";
            string  addname = "";
            bool casee=false;
            bool addcasee = false;
            double totalpric = 0;


            if (checkBox1.Checked)
            {
                sizename = "صغير1";
                sizeprec = 20;
                casee = true;
            }

            if (checkBox2.Checked)
            {
                sizename = "2صغير";
                sizeprec = 30;
                casee = true;
            }

            if (checkBox3.Checked)
            {
                sizename = "صغير3";
                sizeprec = 40;
                casee = true;
            }
            if (!casee)
            {
                MessageBox.Show("حدد حجم الوجبه");
            }

            if (chekbmete.Checked)
            {
                addname += "+"+"برجر";
               addprec += 15;
                addcasee = true;
            }

            if (chekwater.Checked)
            {
                addname += "+"+"مشروب";
                addprec += 5;
               addcasee = true;
            }

            if (chbxchees.Checked)
            {
                addname += "+"+"جبنه اضافيه";
                addprec += 8;
                addcasee = true;
            }
           
            if(!addcasee)
            {
                MessageBox.Show("حدد الوجبه");
            }
            totalpric = addprec + sizeprec;
            string s= " الفاتوره \n" + "\n الحجم :\n"+sizename+" pric:"+sizeprec
               + " الاضافات :\n" + addname + " pric:" + addprec+
               " \nالاجمالي "+totalpric;
            if (casee&&addcasee)
            { MessageBox.Show(s); }

            else
            {
                MessageBox.Show("لا يوجد عليك حساب");
            }

        }
        }
    }

