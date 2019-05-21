using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeaBagMaker
{
    public partial class Form : System.Windows.Forms.Form
    {
        string[] list = new string[]{ "홍차", "녹차", "루이보스차", "국화차" };
        string[] tlist = new string[] { "2","3","5","2" };
        int[] time = { 2 * 60, 3 * 60, 5 * 60, 2 * 60 };
        int countTime = 0;
        string restr = "";

        public Form()
        {
            InitializeComponent();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Form_Load(object sender, EventArgs e)
        {
           for(int i=0; i<list.Length; i++)
            {
                this.combobox.Items.Add(list[i]);
            }
            this.combobox.SelectedItem = 0;
            this.restr = this.timelb.Text;

            this.combobox.Text = "" + this.combobox.Items[0];
            this.timelb.Text = "" + restr + " " + tlist[0]+"분";
        }

        private void Btn_go_Click(object sender, EventArgs e)
        {
           
        }

        private void Timer_Tick(object sender, EventArgs e)
        {

        }

        private void Combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.timelb.Text = restr + tlist[this.combobox.SelectedIndex]+"분";
        }
    }
}
