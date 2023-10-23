using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestBaiTapLonWinform2
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void HomeBtn_MouseEnter(object sender, EventArgs e)
        {
            //HomeBtn.Image = new Bitmap((Bitmap)Properties.Resources.ResourceManager.GetObject("home_active_Ic"));
            HomeBtn.Image = Properties.Resources.home_active_Ic;
        }
        private void HomeBtn_MouseLeave(object sender, EventArgs e)
        {
            HomeBtn.Image = Properties.Resources.home_Ic;
        }

        private void DashBoardBtn_MouseEnter(object sender, EventArgs e)
        {
            DashBoardBtn.Image = Properties.Resources.Dashboard_active_Ic;
        }

        private void DashBoardBtn_MouseLeave(object sender, EventArgs e)
        {
            DashBoardBtn.Image = Properties.Resources.Dashboard_Ic;
        }

        private void CookBtn_MouseLeave(object sender, EventArgs e)
        {
            CookBtn.Image = Properties.Resources.ppl_Ic;
        }

        private void CookBtn_MouseEnter(object sender, EventArgs e)
        {
            CookBtn.Image = Properties.Resources.ppl_active_Ic;
        }

        private void ChartBtn_MouseEnter(object sender, EventArgs e)
        {
            ChartBtn.Image = Properties.Resources.pie_chart_Ic;
        }

        private void ChartBtn_MouseLeave(object sender, EventArgs e)
        {
            ChartBtn.Image = Properties.Resources.pie_chart_Ic;
        }

        private void Setting_MouseEnter(object sender, EventArgs e)
        {
            SettingBtn.Image = Properties.Resources.setting_Ic;
        }

        private void Setting_MouseLeave(object sender, EventArgs e)
        {
            SettingBtn.Image = Properties.Resources.setting_Ic;
        }

        private void ExitBtn_MouseEnter(object sender, EventArgs e)
        {
            ExitBtn.Image = Properties.Resources.exit_Ic;
        }

        private void ExitBtn_MouseLeave(object sender, EventArgs e)
        {
            ExitBtn.Image = Properties.Resources.exit_Ic;
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            Panel panel = tableLayoutPanel1.GetControlFromPosition(1,0) as Panel;
            panel.Controls.Clear();
            QuangNam control = new QuangNam() { TopLevel = false, Dock = DockStyle.Fill };
            panel.Controls.Add(control);
            control.Show();
        }

        private void CookBtn_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_ControlAdded(object sender, ControlEventArgs e)
        {
            Console.WriteLine("true");
        }
    }
}
