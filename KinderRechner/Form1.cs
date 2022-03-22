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
            pnl_Aufg.Visible = false;
            pnl_End.Visible = false;

        }
        bool[] operators = {false, false, false, false};//0=+, 1=-, 2=*, 3=/
        int[] Frage = { 0, 0, 0 };//0=Zahl1, 1=operator (siehe oben), 2=Zahl2
        int range;
        int rounds = 10;
        int roundNumber = 0;
        int Lösung;
        int LösungRest;
        int Antwort;
        int AntwortDivide;
        int AntwortRest;
        int richtigeAntworten;
        bool beantwortet = false;
        bool richtig;
        Random random = new Random();

        public void ChangeScene(int scene)//wechselt zwischen unterschiedlichen Scenen
        {
            pnl_Aufg.Visible = false;
            pnl_Main.Visible = false;
            pnl_End.Visible = false;
            if (scene == 1) pnl_Main.Visible = true;
            if (scene == 2) pnl_Aufg.Visible = true;
            if (scene == 3) pnl_End.Visible = true;
        }
        
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
            if(operators[0] == false && operators[1] == false && operators[2] == false && operators[3] == false)
            {
                return; //Keine Rechnungen ohne Operatoren!
            }
            
            roundNumber = 1;
            richtigeAntworten = 0;

            if (cbb_Schwierigkeit.SelectedIndex == 0) range = 10;
            if (cbb_Schwierigkeit.SelectedIndex == 1) range = 20;
            if (cbb_Schwierigkeit.SelectedIndex == 2) range = 50;
            if (cbb_Schwierigkeit.SelectedIndex == 3) range = 100;

            try
            {
                rounds = Convert.ToInt32(txb_Fragen.Text);
            }catch { }

            ChangeScene(2);
            NeueAufgabe();
        }

        //Screen 2
        public void NeueAufgabe()
        {
            txb_antwort.Text = "";
            txb_AntwortDivide.Text = "";
            txb_AntwortRest.Text = "";
            beantwortet = false;

            grb_Lösung.Visible = false;
            lbl_Aufg_progress.Text = "Frage " + roundNumber + " von " + rounds;
            pgb_progress.Maximum = rounds;//Ladebalken aktualisieren
            pgb_progress.Value = roundNumber;

            Frage[0] = random.Next(0, range+1);
            Frage[2] = random.Next(0, range+1);

            Frage[1] = random.Next(0, 3);
            while (operators[Frage[1]] == false)
            {
                Frage[1] = random.Next(0, 4);
            }

            lbl_Aufg_header.Text = "Was ist " + Frage[0];

            if (Frage[1] == 0) lbl_Aufg_header.Text = lbl_Aufg_header.Text + " + ";
            if (Frage[1] == 1) lbl_Aufg_header.Text = lbl_Aufg_header.Text + " - ";
            if (Frage[1] == 2) lbl_Aufg_header.Text = lbl_Aufg_header.Text + " * ";
            if (Frage[1] == 3) lbl_Aufg_header.Text = lbl_Aufg_header.Text + " : ";

            lbl_Aufg_header.Text = lbl_Aufg_header.Text + Frage[2] + "?";

            if (Frage[1] == 3)
            {
                txb_AntwortDivide.Visible = true;
                txb_AntwortRest.Visible = true;
                txb_antwort.Visible = false;
                lbl_Rest.Visible = true;
            }
            else
            {
                txb_AntwortDivide.Visible = false;
                txb_AntwortRest.Visible = false;
                txb_antwort.Visible = true;
                lbl_Rest.Visible = false;
            }
        }

        private void btn_enter_Click(object sender, EventArgs e)
        {
            if (beantwortet) return;


            if (Frage[1] == 0) Lösung = Frage[0] + Frage[2];
            if (Frage[1] == 1) Lösung = Frage[0] - Frage[2];
            if (Frage[1] == 2) Lösung = Frage[0] * Frage[2];
            if (Frage[1] == 3)
            {
                double temp = Frage[0] / Frage[2];
                Lösung = Convert.ToInt32(Math.Floor(temp));
                LösungRest = Convert.ToInt32(Frage[0] % Frage[2]);
            }

            try
            {
                if (Frage[1] < 3)
                {
                    Antwort = Convert.ToInt32(txb_antwort.Text);
                    if (Antwort == Lösung)
                    {
                        richtig = true;
                    }
                    else richtig = false;
                }
                else
                {
                    AntwortDivide = Convert.ToInt32(txb_AntwortDivide.Text);
                    AntwortRest = Convert.ToInt32(txb_AntwortRest.Text);
                    if (AntwortDivide == Lösung && AntwortRest == LösungRest)
                    {
                        richtig = true;
                    }
                    else richtig = false;
                }
            }
            catch
            {
                MessageBox.Show("Bitte nur Zahlen eintragen!");
                richtig = false;
            }

            if (richtig)
            {
                lbl_richtigFalsch.Text = "Das ist Richtig!";
                richtigeAntworten += 1;
            }
            else
            {
                lbl_richtigFalsch.Text = "Das ist leider Falsch...";
            }
            lbl_vonRichtig.Text = richtigeAntworten + " von " + roundNumber + " richtig";
            grb_Lösung.Visible = true;
            beantwortet = true;
        }

        private void btn_weiter_Click(object sender, EventArgs e)
        {
            if(roundNumber == rounds)
            {
                ChangeScene(3);
            }
            else
            {
                roundNumber += 1;
                NeueAufgabe();
            }
            

        }
    }
}
