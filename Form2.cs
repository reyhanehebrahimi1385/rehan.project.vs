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
    public partial class Form2 : Form
    {
        private Label lblInfoUser;
        private Label lblInfoPass;
        public Form2()
        {
            InitializeComponent();
            this.Text = "form2";
            this.Size = new System.Drawing.Size(300, 200);
            lblInfoUser = new Label()
            {
                Text = "user",
                Location = new System.Drawing.Point(20, 30),
            AutoSize=true
            };
            this.Controls.Add(lblInfoUser);
            lblInfoPass = new Label()
            {
                Text = "Password",
                Location = new System.Drawing.Point(20, 70),
                AutoSize = true
            };
            this.Controls.Add(lblInfoPass);
        
        }
        public void setdeta(string user, string pass)
        {
            lblInfoUser.Text = "User:" + user;
            lblInfoPass.Text = "password:" + pass;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }

        private void Form2_Load_1(object sender, EventArgs e)
        {

        }
    }
}
