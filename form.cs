using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication44
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            newToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            openToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            SaveToFile.ShortcutKeys = Keys.Control | Keys.S;
            exsitToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.F4;
            Timer t = new Timer();
            t.Interval = 30000;
            t.Tick += (s, e) => System.IO.File.WriteAllText("mesal.txt", textPass.Text);
            t.Start();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textPass.Clear();
            
          
        }

        private void newToolStripMenuItem_DoubleClick(object sender, EventArgs e)
        {

        }

        private void newToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Text File(*.text)|*.text|All File(*.*)|*.*";
                if(ofd.ShowDialog()==DialogResult.OK)
                {
                    string[] lines = System.IO.File.ReadAllLines("helo");
                    textUser.Text = lines.Length > 0 ? lines[0] : "";
                    textPass.Text = lines.Length > 1 ? lines[1] : "";

                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            try
            {
                string path = "data.txt";
                string[] lines = { textUser.Text, textPass.Text };
                System.IO.File.WriteAllLines(path, lines);
                MessageBox.Show("ذخیره شد");
            }
            catch(Exception ex)
            {
                MessageBox.Show("خطا در ذخیره فایل");
            }
            
            
        }

        private void exsitToolStripMenuItem_Click(object sender, EventArgs e)
        {

            DialogResult dr = MessageBox.Show("آیا مطمئن هستید میخواهید خارج شوید؟", "خروج" , MessageBoxButtons.YesNo,MessageBoxIcon.Question);
           
        
            if (dr == DialogResult.Yes)
                Application.Exit();
        }

        private void combSave_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (save.SelectedItem !=null&&save.SelectedItem.ToString()=="save")
            {
                
                save.SelectedIndex = -1;
            }
        }

        private void autosaveTimer_Tick(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(textPass.Text))
            {
                System.IO.File.WriteAllLines(textPass.Text, new string[]

                {
                    textUser.Text,
                    textPass.Text,

                });
            }
        }

        private void btNext_Click(object sender, EventArgs e)
        {
            if (textUser.Text == "rehan" && textPass.Text == "1385")
                new Form1().Show();
            else
                MessageBox.Show("ERROR");
        }
    }
}
