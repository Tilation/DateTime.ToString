using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tilation.DateTime.Visualize
{
    public partial class MainForm : Form
    {
        Timer timer;
        FormCheatSheet formCheatSheet;
        About formAbout;

        public MainForm()
        {
            InitializeComponent();
            label2.Text = "Click Here to Copy!";
            label1.Text = System.DateTime.Now.ToString(textBox1.Text);
            formCheatSheet = new FormCheatSheet();
            formAbout = new About();
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += timer_tick;
            timer.Start();
            UpdatePreview();
        }

        private void timer_tick(object sender, EventArgs e)
        {
            UpdatePreview();
        }

        void UpdatePreview()
        {
            try
            {
                label2.ForeColor = Color.DodgerBlue;
                label1.Text = System.DateTime.Now.ToString(textBox1.Text);
                if (textBox1.Text == "")
                {
                    label2.Text = "DateTime.Now.ToString();";
                }
                else
                {
                    label2.Text = $"DateTime.Now.ToString(\"{textBox1.Text}\");";
                }
            }
            catch (Exception ex)
            {

                label2.Text = ex.Message;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            UpdatePreview();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            if (label2.Text != "Copied!" && label2.Text != "Click Here to Copy!")
            {
                Clipboard.SetText(label2.Text);
                label2.ForeColor = Color.Green;
                label2.Text = "Copied!";
                
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (formCheatSheet.IsDisposed) { formCheatSheet = new FormCheatSheet(); }
            if (!formCheatSheet.Visible)
            {
                formCheatSheet.Show();
                formCheatSheet.DesktopLocation = new Point(DesktopBounds.Right + 10, DesktopLocation.Y);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (formAbout.IsDisposed) { formAbout = new About(); }
            if (!formAbout.Visible)
            {
                formAbout.Width = Width;
                formAbout.Show();
                formAbout.DesktopLocation = new Point(DesktopLocation.X, DesktopBounds.Bottom + 10);
            }
        }
    }
}
