using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace nakrutchik
{
    public partial class MainForm : Form
    {
        //public bool stop = false;
        public int i;
        public int cycles;
        public MainForm()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            processlbl.Visible = true;
            urltext.ReadOnly = true;
            countnum.ReadOnly = true;
            delaydiapnumot.ReadOnly = true;
            delaydiapnumdo.ReadOnly = true;
            startbtn.Enabled = false;
            stopbtn.Enabled = true;
            if (urltext.Text == "http://") { }
            else if (urltext.Text == "") { }
            else
            {
                Random r = new Random();
                string url = urltext.Text;
                cycles = Convert.ToInt32(countnum.Value);
                cycles = cycles + 1;
                int delayot = Convert.ToInt32(delaydiapnumot.Value);
                int delaydo = Convert.ToInt32(delaydiapnumdo.Value);
                int delay = r.Next(delayot, delaydo + 1);
                for (i = 1; i < cycles; i++)
                {
                    using (var webClient = new WebClient())
                    {
                        var response = webClient.DownloadString(url);
                    }
                    progress.Value = (i / (cycles - 1)) * 100;
                    Thread.Sleep(delay);
                }
            }
            urltext.ReadOnly = false;
            countnum.ReadOnly = false;
            delaydiapnumot.ReadOnly = false;
            delaydiapnumdo.ReadOnly = false;
            startbtn.Enabled = true;
            stopbtn.Enabled = false;
            processlbl.Visible = false;
        }

        private void stopbtn_Click(object sender, EventArgs e)
        {
            i = cycles - 1;
            urltext.ReadOnly = false;
            countnum.ReadOnly = false;
            delaydiapnumot.ReadOnly = false;
            delaydiapnumdo.ReadOnly = false;
            startbtn.Enabled = true;
            stopbtn.Enabled = false;
            processlbl.Visible = false;
        }

        private void delaydiapnumot_ValueChanged(object sender, EventArgs e)
        {
            if (delaydiapnumot.Value > delaydiapnumdo.Value) {
                delaydiapnumot.Value = delaydiapnumdo.Value;
            }
        }

        private void delaydiapnumdo_ValueChanged(object sender, EventArgs e)
        {
            if (delaydiapnumdo.Value < delaydiapnumot.Value)
            {
                delaydiapnumdo.Value = delaydiapnumot.Value;
            }
        }

        private void urltext_TextChanged(object sender, EventArgs e)
        {
            if (urltext.Text == "http://") { }
            else if (urltext.Text == "") { }
            else { startbtn.Enabled = true; }
        }

        private void urltext_KeyUp(object sender, KeyEventArgs e)
        {
            if (urltext.Text == "http://") { }
            else if (urltext.Text == "") { }
            else { startbtn.Enabled = true; }
        }

        private void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://dubos.esy.es/");
        }
    }
}
