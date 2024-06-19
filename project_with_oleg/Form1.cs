using Bunifu.UI.WinForms;
using Bunifu.UI.WinForms.BunifuButton;
using project_with_oleg.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_with_oleg
{
    public partial class Form1 : Form
    {
        static Form1 _obj;
        //private BunifuButton.BunifuButton2 ButtonHome;
        public static Form1 Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new Form1();
                }
                return _obj;
            }
        }
        public Form1()
        {
            InitializeComponent();
            UC_Home home = new UC_Home();
            addUserControl(home);
            UC_Trading trading = new UC_Trading();
            addUserControl(trading);
        }
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panel_start.Controls.Clear();
            panel_start.Controls.Add(userControl);
            userControl.BringToFront();
        }
        public Panel Panel_home
        {
            get { return panel_start; }
            set { panel_start = value; }

        }
        public BunifuButton Button_Home
        {
            get { return ButtonHome; }
            set { ButtonHome = value; }

        }
        public BunifuButton Button_Trading
        {
            get { return ButtonTrading; }
            set { ButtonTrading = value; }

        }

        private void button_home_clk(object sender, EventArgs e)
        {
            //panel_start.Controls["Home"].BringToFront();
            //ButtonHome.Visible = false;
            UC_Home home = new UC_Home();
            addUserControl(home);
           
        }
        private void button_trading_clk(object sender, EventArgs e)
        {
            UC_Trading trading = new UC_Trading();
            addUserControl(trading);
        }
        
      
        private void Form1_Load(object sender, EventArgs e)
        {
            //ButtonHome.Visible = false;
            _obj = this;

            Home home = new Home();
            home.Dock = DockStyle.Fill;
            panel_start.Controls.Add(home);
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton4_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton5_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton6_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        
    }
}
