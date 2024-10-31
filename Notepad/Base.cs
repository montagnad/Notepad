using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notepad
{
    public partial class Base : Form
    {
        Image novaGuia, fecharGuia;
        Point _imageLocation = new Point(20,4);
        Point imageHitArea = new Point(20, 4);

        private void Base_Load_1(object sender, EventArgs e)
        {
            novaGuia = Properties.Resources.novaguia;
            fecharGuia = Properties.Resources.fecharguia;
            //tabControl1.Padding = new Point(20,4);
            this.tabControl1.TabPages[tabControl1.TabCount - 1].Text = "";
            //this.tabControl1.TabPages[tabControl1.TabCount - 1].BackgroundImage
        }

        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            Image img;
            if (e.Index == this.tabControl1.TabCount -1)
            {
                img = new Bitmap(novaGuia);
                tabControl1.Padding = new Point(4, 4);
            }
            else
            {
                img = new Bitmap(fecharGuia);
            }
            Rectangle r = e.Bounds;
            r = this.tabControl1.GetTabRect(e.Index);
            r.Offset(2, 2);
            Brush TitleBrush = new SolidBrush(Color.Black);
            Font f = this.Font;
            string title = this.tabControl1.TabPages[e.Index].Text;
            e.Graphics.DrawString(title, f, TitleBrush, new PointF(r.X, r.Y));
            e.Graphics.DrawImage(img, new Point(r.X + (
                this.tabControl1.GetTabRect(e.Index).Width - _imageLocation.X),
                _imageLocation.Y));
        }

        private void tabControl1_MouseClick(object sender, MouseEventArgs e)
        {
            TabControl tabControl = (TabControl)sender;
            Point p = e.Location;
            int _tabWidth = 0;
            _tabWidth = this.tabControl1.GetTabRect(tabControl.SelectedIndex).Width - (imageHitArea.X);
            Rectangle r = this.tabControl1.GetTabRect(tabControl.SelectedIndex);
            r.Offset(_tabWidth, imageHitArea.Y);
            r.Width = 16;
            r.Height = 16;
            if (tabControl1.SelectedIndex == this.tabControl1.TabCount - 1)
            {
                TabPage tab = new TabPage();
                tab.Text = "";
                tabControl1.Controls.Add(tab);
                this.tabControl1.TabPages[this.tabControl1.TabCount - 2].Text =
                    "Nova guia";
            }
            else
            {
                if (r.Contains(p))
                {
                    TabPage tabPage = (TabPage)tabControl.TabPages[tabControl.SelectedIndex];
                    tabControl.TabPages.Remove(tabPage);
                }
            }
        }

        public Base()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
