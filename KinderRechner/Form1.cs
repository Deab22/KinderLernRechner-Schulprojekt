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
        int rounds = 10;          //Anzahl Fragen
        int roundNumber = 0;      //Anzahl beantwortete Fragen
        int Lösung;               //Richtige Lösungen
        int LösungRest;
        int Antwort;              //Antworten User
        int AntwortDivide;
        int AntwortRest;
        int richtigeAntworten;    //Anahl richtige Antworten
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
        
        //Scene 1: Hauptmenü
        private void btn_Main_plus_Click(object sender, EventArgs e)//Konnte leider keine Funktion für diesen Teil schreiben...
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
                rounds = Convert.ToInt32(txb_Fragen.Text);//wenn Text keine Zahl, nehme vorherige Zahl
            }catch { }

            ChangeScene(2);
            NeueAufgabe();
        }

        //Scene 2: Aufgaben
        public void NeueAufgabe()
        {
            txb_antwort.Text = "";//Bildschirm und Variablen zurücksetzen
            txb_AntwortDivide.Text = "";
            txb_AntwortRest.Text = "";
            btn_weiter.Enabled = false;
            beantwortet = false;

            grb_Lösung.Visible = false;
            lbl_Aufg_progress.Text = "Frage " + roundNumber + " von " + rounds;
            pgb_progress.Maximum = rounds;//Ladebalken aktualisieren
            pgb_progress.Value = roundNumber;

            Frage[0] = random.Next(0, range+1);//Zufällige Frage generieren
            Frage[2] = random.Next(0, range+1);

            Frage[1] = random.Next(0, 3);
            while (operators[Frage[1]] == false)//Zufälliger Operator
            {
                Frage[1] = random.Next(0, 4);
            }

            if(Frage[1] == 3 && Frage[2] == 0) Frage[2] = 1;//Kein Teilen durch Null!

            lbl_Aufg_header.Text = "Was ist " + Frage[0];//Aufgabe als Text anzeigen

            if (Frage[1] == 0) lbl_Aufg_header.Text = lbl_Aufg_header.Text + " + ";
            if (Frage[1] == 1) lbl_Aufg_header.Text = lbl_Aufg_header.Text + " - ";
            if (Frage[1] == 2) lbl_Aufg_header.Text = lbl_Aufg_header.Text + " * ";
            if (Frage[1] == 3) lbl_Aufg_header.Text = lbl_Aufg_header.Text + " : ";

            lbl_Aufg_header.Text = lbl_Aufg_header.Text + Frage[2] + "?";

            if (Frage[1] == 3)//Spezieller Bildschirm für Geteilt
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

        private void btn_enter_Click(object sender, EventArgs e)//Lösung überprüfen
        {
            if (beantwortet) return;


            if (Frage[1] == 0) Lösung = Frage[0] + Frage[2];//+
            if (Frage[1] == 1) Lösung = Frage[0] - Frage[2];//-
            if (Frage[1] == 2) Lösung = Frage[0] * Frage[2];//*
            if (Frage[1] == 3)                              //:
            {        //temp = Temporary Variable
                double temp = Frage[0] / Frage[2];//spezielle Rechnung für Geteilt: Ohne Komma und Rest
                Lösung = Convert.ToInt32(Math.Floor(temp));
                LösungRest = Convert.ToInt32(Frage[0] % Frage[2]);
            }

            try
            {
                if (Frage[1] < 3)//Auslesen von Input
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
                    if (txb_AntwortRest.Text == "") txb_AntwortRest.Text = "0";
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

            if (richtig)//Feedback an User
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
            btn_weiter.Enabled = true;
            beantwortet = true;
        }

        private void btn_weiter_Click(object sender, EventArgs e)
        {
            if(roundNumber == rounds)//Wechsel zu Ende
            {
                ChangeScene(3);
                
                double Prozent = Convert.ToDouble(richtigeAntworten) / Convert.ToDouble(rounds) * 100;
                lbl_End_vonRichtig.Text = richtigeAntworten + " von " + rounds + " richtig!";
                lbl_End_Prozent.Text = "Das sind " + Prozent + "%!";
            }
            else
            {
                roundNumber += 1;//Nächste Frage
                NeueAufgabe();
            }
            

        }
        //Scene 3: Ende
        private void btn_End_Fertig_Click(object sender, EventArgs e)
        {
            ChangeScene(1);
        }
    }
}
