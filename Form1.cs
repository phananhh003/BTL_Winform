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

        string activeBtn = "";

        public Form1()
        {
            InitializeComponent();
            changeActiveBtn(HomeBtn, true);
            activeBtn = "panelHomeBtn";
        }

        private Bitmap changeActiveImage (string target, bool active)
        {
            if (target == "HomeBtn")
            {
                if (active)
                {
                    return Properties.Resources.home_active_Ic;
                }
                else
                {
                    return Properties.Resources.home_Ic;
                }
            }
            else if (target == "DashBoardBtn")
            {
                if (active)
                {
                    return Properties.Resources.Dashboard_active_Ic;
                }
                else
                {
                    return Properties.Resources.Dashboard_Ic;

                }
            }
            else if(target == "ChartBtn")
            {
                if (active)
                {
                    return Properties.Resources.pie_chart_active_Ic;

                }
                else
                {
                    return Properties.Resources.pie_chart_Ic;

                }
            }
            else if(target == "CookBtn")
            {
                if (active)
                {
                    return Properties.Resources.ppl_active_Ic;
                }
                else
                {
                    return Properties.Resources.ppl_Ic;
                }
            }
            else if(target == "SettingBtn")
            {
                if (active)
                {
                    return Properties.Resources.setting_active_Ic;
                }
                else
                {
                    return Properties.Resources.setting_Ic;
                }
            }
            else if (target == "ExitBtn")
            {
                if (active)
                {
                    return Properties.Resources.exit_active_Ic;
                }
                else
                {
                    return Properties.Resources.exit_Ic;
                }
            }
            else
            {
                return null;
            }
            
        }

        private void setCurrActivePanel(string panelBtnName)
        {
            if (string.IsNullOrEmpty(panelBtnName)) activeBtn = "panelHomeBtn";
            else activeBtn = panelBtnName;
        }

        private void setInActiveBtn(string panelBtnName)
        {
            // bỏ nút đang active
            foreach (Control item in panelNavBarContent.Controls)
            {
                if (item.Name == activeBtn)
                {
                    Button btn = item.Controls.OfType<Button>().ToList()[0];
                    btn.Image = changeActiveImage(btn.Name,false);
                    btn.BackColor = Color.FromArgb(31, 29, 43);
                }
            }
            // set lại nút đang active
            setCurrActivePanel(panelBtnName);
        }

        private void changeActiveBtn (Object sender, bool active)
        {
            Button ctrl = sender as Button;
            if (ctrl.Parent.Name != activeBtn)
            { 
                ctrl.Image = changeActiveImage(ctrl.Name, active);
                if (active) ctrl.BackColor = Color.FromArgb(234, 124, 105);
                else ctrl.BackColor = Color.FromArgb(31, 29, 43);
            }
        }

        private void HomeBtn_MouseEnter(object sender, EventArgs e)
        {
            //HomeBtn.Image = new Bitmap((Bitmap)Properties.Resources.ResourceManager.GetObject("home_active_Ic"));
            changeActiveBtn(sender, true);
        }
        private void HomeBtn_MouseLeave(object sender, EventArgs e)
        {
            changeActiveBtn(sender, false);
        }

        private void DashBoardBtn_MouseEnter(object sender, EventArgs e)
        {
            changeActiveBtn(sender, true);
        }

        private void DashBoardBtn_MouseLeave(object sender, EventArgs e)
        {
            changeActiveBtn(sender, false);
        }

        private void CookBtn_MouseLeave(object sender, EventArgs e)
        {
            changeActiveBtn(sender, false);

        }

        private void CookBtn_MouseEnter(object sender, EventArgs e)
        {
            changeActiveBtn(sender, true);
        }

        private void ChartBtn_MouseEnter(object sender, EventArgs e)
        {
            changeActiveBtn(sender, true);

        }

        private void ChartBtn_MouseLeave(object sender, EventArgs e)
        {
            changeActiveBtn(sender, false);

        }

        private void Setting_MouseEnter(object sender, EventArgs e)
        {
            changeActiveBtn(sender, true);

        }

        private void Setting_MouseLeave(object sender, EventArgs e)
        {
            changeActiveBtn(sender, false);

        }

        private void ExitBtn_MouseEnter(object sender, EventArgs e)
        {
            changeActiveBtn(sender, true);

        }

        private void ExitBtn_MouseLeave(object sender, EventArgs e)
        {
            changeActiveBtn(sender, false);

        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            Control ctrl = sender as Control;
            changeActiveBtn(sender, true);
            setInActiveBtn(ctrl.Parent.Name);
        }

        private void CookBtn_Click(object sender, EventArgs e)
        {
            Control ctrl = sender as Control;
            changeActiveBtn(sender, true);
            setInActiveBtn(ctrl.Parent.Name);

            Panel panel = tableLayoutPanel1.GetControlFromPosition(1, 0) as Panel;
            panel.Controls.Clear();
            LuongCunt control = new LuongCunt() { TopLevel = false, Dock = DockStyle.Fill };
            panel.Controls.Add(control);
            control.Show();
        }

        private void tableLayoutPanel1_ControlAdded(object sender, ControlEventArgs e)
        {
            Console.WriteLine("true");
        }

        private void DashBoardBtn_Click(object sender, EventArgs e)
        {
            Control ctrl = sender as Control;
            changeActiveBtn(sender, true);
            setInActiveBtn(ctrl.Parent.Name);

            Panel panel = tableLayoutPanel1.GetControlFromPosition(1, 0) as Panel;
            panel.Controls.Clear();
            DucAnh control = new DucAnh() { TopLevel = false, Dock = DockStyle.Fill };
            panel.Controls.Add(control);
            control.Show();

        }

        private void ChartBtn_Click(object sender, EventArgs e)
        {
            Control ctrl = sender as Control;
            changeActiveBtn(sender, true);
            setInActiveBtn(ctrl.Parent.Name);

            Panel panel = tableLayoutPanel1.GetControlFromPosition(1, 0) as Panel;
            panel.Controls.Clear();
            DuyAnh control = new DuyAnh() { TopLevel = false, Dock = DockStyle.Fill };
            panel.Controls.Add(control);
            control.Show();
        }

        private void SettingBtn_Click(object sender, EventArgs e)
        {
            Control ctrl = sender as Control;
            changeActiveBtn(sender, true);
            setInActiveBtn(ctrl.Parent.Name);

            Panel panel = tableLayoutPanel1.GetControlFromPosition(1, 0) as Panel;
            panel.Controls.Clear();
            QuangNam control = new QuangNam() { TopLevel = false, Dock = DockStyle.Fill };
            panel.Controls.Add(control);
            control.Show();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
