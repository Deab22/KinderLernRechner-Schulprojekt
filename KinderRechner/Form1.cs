using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KinderRechner
{
    public partial class frm_Kinderrechner : Form
    {
        public frm_Kinderrechner()
        {
            InitializeComponent();
            cbb_Schwierigkeit.DropDownStyle = ComboBoxStyle.DropDownList;
            cbb_Schwierigkeit.SelectedIndex = 0;

        }
        bool[] operators = {false, false, false, false};//0=+, 1=-, 2=*, 3=/
        int range = 10;
        int rounds = 10;
        int completed = 0;

        //Screen 1
        private void btn_Main_plus_Click(object sender, EventArgs e)
        {
            if (operators[0] == true)
            {
                operators[0] = false;
                btn_Main_plus.BackColor = SystemColors.Control;
            }
            else
            {
                operators[0] = true;
                btn_Main_plus.BackColor = SystemColors.Highlight;
            }
        }

        private void btn_Main_minus_Click(object sender, EventArgs e)
        {
            if (operators[1] == true)
            {
                operators[1] = false;
                btn_Main_minus.BackColor = SystemColors.Control;
            }
            else
            {
                operators[1] = true;
                btn_Main_minus.BackColor = SystemColors.Highlight;
            }
        }

        private void btn_Main_mal_Click(object sender, EventArgs e)
        {
            if (operators[2] == true)
            {
                operators[2] = false;
                btn_Main_mal.BackColor = SystemColors.Control;
            }
            else
            {
                operators[2] = true;
                btn_Main_mal.BackColor = SystemColors.Highlight;
            }
        }

        private void btn_Main_geteilt_Click(object sender, EventArgs e)
        {
            if (operators[3] == true)
            {
                operators[3] = false;
                btn_Main_geteilt.BackColor = SystemColors.Control;
            }
            else
            {
                operators[3] = true;
                btn_Main_geteilt.BackColor = SystemColors.Highlight;
            }
        }

        private void btn_Main_Los_Click(object sender, EventArgs e)
        {
            if (cbb_Schwierigkeit.SelectedIndex == 0) range = 10;
            if (cbb_Schwierigkeit.SelectedIndex == 1) range = 20;
            if (cbb_Schwierigkeit.SelectedIndex == 2) range = 50;
            if (cbb_Schwierigkeit.SelectedIndex == 3) range = 100;


        }
    }
}
