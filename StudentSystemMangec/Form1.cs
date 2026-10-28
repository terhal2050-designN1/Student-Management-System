using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace StudentSystemMangec
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }


        private void FillCombSerach()
        {
            combSerach.Items.Clear();
            foreach (ListViewItem item in listViewDataStudent.Items)
            {
                combSerach.Items.Add(item.SubItems[0].Text);
            }

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            labTimer.Text = DateTime.Now.ToString("hh:mm:ss:tt");

            labDate.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy");

            timer1.Start();

            SetupListView();
        }

        private void SetupListView()
        {
            

            listViewDataStudent.Columns.Clear();
            listViewDataStudent.Columns.Add("ID", 150);
            listViewDataStudent.Columns.Add("Name", 160);
            listViewDataStudent.Columns.Add("Level", 150);
            listViewDataStudent.Columns.Add("Phone", 160);
            listViewDataStudent.Columns.Add("Average", 150);
            listViewDataStudent.Columns.Add("Major", 160);
        }

        private void ClearInputs()
        {
            textId.Clear();
            texName.Clear();
            textBox1.Clear();      // Level
            texPhone.Clear();
            texAverage.Clear();
            textBox2.Clear();      // Major
          
        }

        private bool CheckInputs(string Messag)
        {
            if (textId.Text == "" || texName.Text == "" || textBox1.Text == "" ||
                texPhone.Text == "" || texAverage.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show(Messag);
                return false;
            }

            return true;
        }

        private void buttAdd_Click(object sender, EventArgs e)
        {
            if (!CheckInputs("Please fill all fields to added"))
                return;

            ListViewItem item = new ListViewItem(textId.Text);
            item.SubItems.Add(texName.Text);
            item.SubItems.Add(textBox1.Text); // Level
            item.SubItems.Add(texPhone.Text);
            item.SubItems.Add(texAverage.Text);
            item.SubItems.Add(textBox2.Text);//Major

            bool found = false;

            foreach (ListViewItem it in listViewDataStudent.Items)
            {
                if(it.Text==textId.Text)
                { 
                found = true; break;
                }

            }

                if (!found)
            {
                listViewDataStudent.Items.Add(item);
                FillCombSerach();
                ClearInputs();
            
             MessageBox.Show("Student added successfully");
            }

            else
            {
                MessageBox.Show(" Data Student is Available");
            }
           
        }

        private void buttUpData_Click(object sender, EventArgs e)
        {
            if (!CheckInputs("Please select a student from the table"))
            {
                return;
            }
            if (listViewDataStudent.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a student from the table");
                return;
            }


            ListViewItem item = listViewDataStudent.SelectedItems[0];

            item.SubItems[0].Text = textId.Text;
            item.SubItems[1].Text = texName.Text;
            item.SubItems[2].Text = textBox1.Text;//level
            item.SubItems[3].Text = texPhone.Text;
            item.SubItems[4].Text = texAverage.Text;
            item.SubItems[5].Text = textBox2.Text;//major
            FillCombSerach();
            ClearInputs();

            MessageBox.Show("Student updated successfully");
        }

        private void buttDelete_Click(object sender, EventArgs e)
        {
            if (!CheckInputs("Please select a student from the table"))
            {
                return;
            }
            if (listViewDataStudent.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a student from the table");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this student?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                listViewDataStudent.Items.Remove(listViewDataStudent.SelectedItems[0]);
                FillCombSerach();
                ClearInputs();
                MessageBox.Show("Student deleted successfully");
            }
        }

        private void buttClear_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }

        private void buttSearch_Click(object sender, EventArgs e)
        {
            string search = combSerach.Text;

            if (search == "")
            {
                MessageBox.Show("Please enter ID  to search");
                return;
            }

            bool found = false;

            foreach (ListViewItem item in listViewDataStudent.Items)
            { 
                item.BackColor = Color.LightBlue;

                if (item.SubItems[0].Text==search )
                {
                    item.BackColor = Color.FromArgb(250, 250, 0);
                 item.EnsureVisible();
                    found = true;
                }
            }

            if (!found)
            {
                MessageBox.Show("Student not found");
            }
        }

        private void listViewDataStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewDataStudent.SelectedItems.Count == 1)
            {
                ListViewItem item = listViewDataStudent.SelectedItems[0];

                textId.Text = item.SubItems[0].Text;
                texName.Text = item.SubItems[1].Text;
                textBox1.Text = item.SubItems[2].Text;
                texPhone.Text = item.SubItems[3].Text;
                texAverage.Text = item.SubItems[4].Text;
                textBox2.Text = item.SubItems[5].Text;
            }
        }

        private void SaveData()
        {

            if (listViewDataStudent.Items.Count==0)
                { 
                    MessageBox.Show("There is no data to save");
                    return;

                }
            
                DialogResult result = MessageBox.Show(
               "Are you sure you want to save  students data?",
               "Confirm Save",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Warning
           );

            if (result == DialogResult.Yes)
            {
                StreamWriter writer = new StreamWriter("students.txt");

                foreach (ListViewItem item in listViewDataStudent.Items)
                {
                    writer.WriteLine(
                        item.SubItems[0].Text + "^" +
                        item.SubItems[1].Text + "^" +
                        item.SubItems[2].Text + "^" +
                        item.SubItems[3].Text + "^" +
                        item.SubItems[4].Text + "^" +
                        item.SubItems[5].Text
                    );
                }

                writer.Close();
                MessageBox.Show("Data saved successfully");

            } 
            
            
            }

        private void LoadData()
        {
            if (!File.Exists("students.txt"))
            {
                MessageBox.Show("File not found");
                return;
            }

            listViewDataStudent.Items.Clear();

            string[] lines = File.ReadAllLines("students.txt");

            foreach (string line in lines)
            {
                string[] data = line.Split('^');

                if (data.Length == 6)
                {
                    ListViewItem item = new ListViewItem(data[0]);
                    item.SubItems.Add(data[1]);
                    item.SubItems.Add(data[2]);
                    item.SubItems.Add(data[3]);
                    item.SubItems.Add(data[4]);
                    item.SubItems.Add(data[5]);

                    listViewDataStudent.Items.Add(item);
                }
            }

            MessageBox.Show("Data loaded successfully");
        }

        private void toolStripSave_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void toolStripLoad_Click(object sender, EventArgs e)
        {
            LoadData();
            FillCombSerach();
        }

        private void toolStripExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Student Management System\nCreated by: Mohammed Sabri Saeed Al Ameri \nID:38 \nC# WinForms Project");
                        
        }
       
        private void radioColorBackgroundForm1_CheckedChanged(object sender, EventArgs e)
        {
          
            this.BackColor = Color.FromArgb(5, 8, 35);



           
            panelHeader.BackColor = Color.FromArgb(35, 0, 90);
            panlFoter.BackColor= Color.FromArgb(35, 0, 90);



         
            groupBoxStudentData.BackColor = Color.FromArgb(10, 15, 55);
            groupBoxSearchId.BackColor = Color.FromArgb(18, 12, 70);



          
            textId.BackColor = Color.FromArgb(15, 20, 65);
            textId.ForeColor = Color.White;

            texName.BackColor = Color.FromArgb(15, 20, 65);
            texName.ForeColor = Color.White;

            textBox1.BackColor = Color.FromArgb(15, 20, 65);//levell
            textBox1.ForeColor = Color.White;

            texPhone.BackColor = Color.FromArgb(15, 20, 65);
            texPhone.ForeColor = Color.White;

            texAverage.BackColor = Color.FromArgb(15, 20, 65);
            texAverage.ForeColor = Color.White;

            textBox2.BackColor = Color.FromArgb(15, 20, 65);//major
            textBox2.ForeColor = Color.White;
            combSerach.BackColor = Color.FromArgb(200, 210, 240);
            combSerach.ForeColor = Color.Black;





         
            buttAdd.BackColor = Color.FromArgb(0, 200, 90);
            buttAdd.ForeColor = Color.White;

            buttUpData.BackColor = Color.FromArgb(0, 110, 255);
            buttUpData.ForeColor = Color.White;

            buttDelete.BackColor = Color.FromArgb(255, 45, 85);
            buttDelete.ForeColor = Color.White;

            buttClear.BackColor = Color.FromArgb(255, 140, 0);
            buttClear.ForeColor = Color.White;

            buttSearch.BackColor = Color.FromArgb(120, 0, 255);
            buttSearch.ForeColor = Color.White;



       
            listViewDataStudent.BackColor=Color.FromArgb(200, 210, 240);
            listViewDataStudent.ForeColor = Color.Black;



        
            menuStrip1.BackColor = Color.FromArgb(15, 15, 40);
            menuStrip1.ForeColor = Color.White;



       
            toolStrip1.BackColor = Color.FromArgb(10, 10, 35);
            toolStrip1.ForeColor = Color.White;

            labAvg.ForeColor = Color.White;
            labId.ForeColor = Color.White;
            labLevel.ForeColor = Color.White;
            labName.ForeColor = Color.White;
            labPhone.ForeColor = Color.White;
            labMajor.ForeColor = Color.White;
            labelSearch.ForeColor = Color.White;
           labStyle.ForeColor = Color.White;
            labGropStudentData.ForeColor = Color.White;
            radioColorBackgroundToForm1.ForeColor = Color.White;
            radioColorBackgroundToForm2.ForeColor = Color.White;

        }





        private void radioColorBackgroundForm2_CheckedChanged(object sender, EventArgs e)
        {
           
            this.BackColor = Color.FromArgb(248, 248, 248);



            
            panelHeader.BackColor = Color.FromArgb(0, 69, 64);
            panlFoter.BackColor= Color.FromArgb(0, 69, 64);



        
            groupBoxStudentData.BackColor = Color.FromArgb(250, 250, 250);
            groupBoxSearchId.BackColor = Color.FromArgb(250, 250, 250);


           
            textId.BackColor = Color.White;
            textId.ForeColor = Color.Black;

            texName.BackColor = Color.White;
            texName.ForeColor = Color.Black;

            textBox1.BackColor = Color.White;
            textBox1.ForeColor = Color.Black;

            texPhone.BackColor = Color.White;
            texPhone.ForeColor = Color.Black;

            texAverage.BackColor = Color.White;
            texAverage.ForeColor = Color.Black;

            textBox2.BackColor = Color.White;
            textBox2.ForeColor = Color.Black;

        

           
            buttAdd.BackColor = Color.FromArgb(50, 255, 50);
            buttAdd.ForeColor = Color.Black;

            buttUpData.BackColor = Color.FromArgb(30, 158, 255);
            buttUpData.ForeColor = Color.Black;

            buttDelete.BackColor = Color.Red;
            buttDelete.ForeColor = Color.Black;

            buttClear.BackColor = Color.FromArgb(255, 140, 45);
            buttClear.ForeColor = Color.Black;

            buttSearch.BackColor = Color.FromArgb(196, 225, 190);
            buttSearch.ForeColor = Color.Black;



           
            listViewDataStudent.BackColor = Color.FromArgb(196, 225, 190);
            listViewDataStudent.ForeColor = Color.Black;


        
            menuStrip1.BackColor = Color.White;
            menuStrip1.ForeColor = Color.Black;


           
            toolStrip1.BackColor = Color.FromArgb(245, 245, 245);
            toolStrip1.ForeColor = Color.Black;
            labAvg.ForeColor = Color.Black;
            labId.ForeColor = Color.Black;
            labLevel.ForeColor = Color.Black;
            labName.ForeColor = Color.Black;
            labPhone.ForeColor = Color.Black;
            labMajor.ForeColor = Color.Black;
            labelSearch.ForeColor = Color.Black;
            labGropStudentData.ForeColor = Color.Black;
          labStyle.ForeColor = Color.Black;
            radioColorBackgroundToForm1.ForeColor = Color.Black;
            radioColorBackgroundToForm2.ForeColor =  Color.Black;
        }


        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
        }

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }

        private void textId_TextChanged(object sender, EventArgs e)
        {
        }

        private void texName_TextChanged(object sender, EventArgs e)
        {
        }

        private void texPhone_TextChanged(object sender, EventArgs e)
        {
        }

        private void texAverage_TextChanged(object sender, EventArgs e)
        {
        }

        private void texSearch_TextChanged(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        private void labId_Click(object sender, EventArgs e)
        {
        }

        private void labLevel_Click(object sender, EventArgs e)
        {
        }

        private void labPhone_Click(object sender, EventArgs e)
        {
        }

        private void labAvg_Click(object sender, EventArgs e)
        {
        }

        private void labMajor_Click(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void IMgHeader_Click(object sender, EventArgs e)
        {
        }
       
        private void combSerach_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labTimer.Text = DateTime.Now.ToString("hh:mm:ss:tt");

            labDate.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy");

            
        }

        private void labTimer_Click(object sender, EventArgs e)
        {

        }

        private void labDate_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}