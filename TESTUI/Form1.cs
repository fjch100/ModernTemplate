using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TESTUI
{
    public partial class Form1 : Form
    {
        private Form activeForm = null;
        public Form1()
        {
            InitializeComponent();
            CustomizeDesing();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void CustomizeDesing()
        {
            panelSubMenu1.Visible = false;
            panelSubMenu2.Visible = false;
        }


        private void HideSubMenu()
        {
            if (panelSubMenu1.Visible) panelSubMenu1.Visible = false;
            if (panelSubMenu2.Visible) panelSubMenu2.Visible = false;
        }

        private void ShowSubMenu (Panel submenu)
        {
            if(submenu.Visible==false)
            {
                HideSubMenu();
                submenu.Visible = true;
            }
            else
            {
                submenu.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelSubMenu1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form2());// open form inside panel
            //
            // your code
            //
            HideSubMenu();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelSubMenu2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //
            // your code
            //
            HideSubMenu();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //
            // your code
            //
            HideSubMenu();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            //
            // your code
            //
            HideSubMenu();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            //
            // your code
            //
            HideSubMenu();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            //
            // your code
            //
            HideSubMenu();
        }

        private void OpenChildForm(Form childForm)
        {
            if(activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

    }
}
