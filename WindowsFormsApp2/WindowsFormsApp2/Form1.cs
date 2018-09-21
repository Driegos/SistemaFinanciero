using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

           
        }
   
        public static class Util
        {
            public enum Effect { Roll, Slide, Center, Blend }
            public static void Animate(Control ctl, Effect effect, int msec, int angle)
            {
                int flags = effmap[(int)effect];

                if (ctl.Visible)
                {
                    flags |= 0x10000; angle += 180;
                }
                else
                {
                    if (ctl.TopLevelControl == ctl) flags |= 0x20000;
                    else if (effect == Effect.Blend) throw new ArgumentException();
                }
                flags |= dirmap[(angle % 360) / 45];
                bool ok = AnimateWindow(ctl.Handle, msec, flags);
                if (!ok) throw new Exception("Animation failed");
                ctl.Visible = !ctl.Visible;
            }

            private static int[] dirmap = { 1, 5, 4, 6, 2, 10, 8, 9 };
            private static int[] effmap = { 0, 0x40000, 0x10, 0x80000 };

            [DllImport("user32.dll")]
            private static extern bool AnimateWindow(IntPtr handle, int msec, int flags);

            internal static bool Animate(Panel registroVideo, Effect roll)
            {
                throw new NotImplementedException();
            }
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            Util.Animate(panel3, Util.Effect.Slide, 150, 360);

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
             
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Util.Animate(panel4, Util.Effect.Slide, 150, 360);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Util.Animate(panel4, Util.Effect.Slide, 150, 360);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Util.Animate(panel3, Util.Effect.Slide, 150, 360);
        }

        private void button11_Click(object sender, EventArgs e)
        {
          //  textBox2.Focus();
        }

        private void button13_Click(object sender, EventArgs e)
        {
         //   textBox5.Focus();
        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
