using Project_Program;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AC_Remake
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Variables
        bool Hover = false;
        private bool mouseDown;
        private Point lastLocation;

        private void Form1_Load(object sender, EventArgs e)
        {
            //set the side bar width on start up, set the button names and get the screen working area
            pnSide.Width = 70;
            btnMain.Text = " ";
            this.MaximumSize = Screen.PrimaryScreen.WorkingArea.Size;

            //open the main user control on start up
            pnControl.Controls.Clear();
            pnControl.Controls.Add(main.Instance);
            main.Instance.Dock = DockStyle.Fill;
        }


        //expand and contact side bar
        private void tHover_Tick(object sender, EventArgs e)
        {

            //if true expand side bar to 200px
            if (Hover == true)
            {
                if(pnSide.Width < 225)
                {
                    pnSide.Width = pnSide.Width + 15;
                }
            }
            //if false contract side bar to 70px
            else if (Hover == false)
            {
                if (pnSide.Width > 55)
                {
                    pnSide.Width = pnSide.Width - 15;
                }
            }

            //set the button text after 150px
            if (pnSide.Width > 150)
            {
                btnMain.Text = "   Main Menu";
                btnResults.Text = "   Results      ";
                btnToggle.Text = "                            ";
            } else if (pnSide.Width < 150)
            {
                btnToggle.Text = "";
                btnResults.Text = "";
                btnMain.Text = "";
            }
        }

        private void btnToggle_Click(object sender, EventArgs e)
        {
            //set if the menu bar button has been selected
            if(Hover == false)
            {
                Hover = true;
            }
            else
            {
                Hover = false;
            }
        }

        //make custom window follow mouse cursor
        private void pnHead_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void pnHead_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void pnHead_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        //close application
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //maximise application
        private void btnMaximise_Click(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Maximized)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        //minimise application
        private void btnMinimise_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        //open the main user control within the pannel named control
        private void btnMain_Click(object sender, EventArgs e)
        {
            pnControl.Controls.Clear();
            pnControl.Controls.Add(main.Instance);
            main.Instance.Dock = DockStyle.Fill;
        }

        private void btnResults_Click(object sender, EventArgs e)
        {
            pnControl.Controls.Clear();
            pnControl.Controls.Add(Results.Instance);
            Results.Instance.Dock = DockStyle.Fill;
        }

        public void showResult()
        {
            pnControl.Controls.Clear();
            pnControl.Controls.Add(Results.Instance);
            Results.Instance.Dock = DockStyle.Fill;
        }

        private void pnHead_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
