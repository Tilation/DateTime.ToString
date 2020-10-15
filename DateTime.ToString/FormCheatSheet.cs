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
    public partial class FormCheatSheet : Form
    {
        public FormCheatSheet()
        {
            InitializeComponent();
            label1.Text =   "d\n" +
                            "D\n" +
                            "f\n" +
                            "F\n" +
                            "g\n" +
                            "G\n" +
                            "m\n" +
                            "o\n" +
                            "R\n" +
                            "s\n" +
                            "t\n" +
                            "T\n" +
                            "u\n" +
                            "U\n" +
                            "y\n" +
                            "h:mm:ss.ff t\n" +
                            "d MMM yyyy\n" +
                            "HH:mm:ss.f\n" +
                            "dd MMM HH:mm:ss\n" +
                            "\\Mon\\t\\h\\: M\n" +
                            "HH:mm:ss.ffffzzz\n";
            CalculateLabel2();
            Timer t = new Timer();
            t.Tick += TimerTick;
            t.Interval = 1000;
            t.Start();
        }

        private void TimerTick(object sender, EventArgs e)
        {
            CalculateLabel2();
        }

        void CalculateLabel2()
        {
            // sip esto es un asco pero funciona rapido
            // esto muestra los ejemplos de todos los tipos de formato diferente
            string ss =     $"{System.DateTime.Now.ToString("d")}\n" +
                            $"{System.DateTime.Now.ToString("D")}\n" +
                            $"{System.DateTime.Now.ToString("f")}\n" +
                            $"{System.DateTime.Now.ToString("F")}\n" +
                            $"{System.DateTime.Now.ToString("g")}\n" +
                            $"{System.DateTime.Now.ToString("G")}\n" +
                            $"{System.DateTime.Now.ToString("m")}\n" +
                            $"{System.DateTime.Now.ToString("o")}\n" +
                            $"{System.DateTime.Now.ToString("R")}\n" +
                            $"{System.DateTime.Now.ToString("s")}\n" +
                            $"{System.DateTime.Now.ToString("t")}\n" +
                            $"{System.DateTime.Now.ToString("T")}\n" +
                            $"{System.DateTime.Now.ToString("u")}\n" +
                            $"{System.DateTime.Now.ToString("U")}\n" +
                            $"{System.DateTime.Now.ToString("y")}\n" +
                            $"{System.DateTime.Now.ToString("h:mm:ss.ff t")}\n" +
                            $"{System.DateTime.Now.ToString("d MMM yyyy")}\n" +
                            $"{System.DateTime.Now.ToString("HH:mm:ss.f")}\n" +
                            $"{System.DateTime.Now.ToString("dd MMM HH:mm:ss")}\n" +
                            $"{System.DateTime.Now.ToString("\\Mon\\t\\h\\: M")}\n" +
                            $"{System.DateTime.Now.ToString("HH:mm:ss.ffffzzz")}\n";
            label2.Text = ss;
        }
    }
}
