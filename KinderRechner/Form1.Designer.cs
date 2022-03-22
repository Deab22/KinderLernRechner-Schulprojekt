namespace KinderRechner
{
    partial class frm_Kinderrechner
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnl_Main = new System.Windows.Forms.Panel();
            this.txb_Fragen = new System.Windows.Forms.TextBox();
            this.lbl_Main_fragen = new System.Windows.Forms.Label();
            this.btn_Main_Los = new System.Windows.Forms.Button();
            this.lbl_Main_Zahlen = new System.Windows.Forms.Label();
            this.cbb_Schwierigkeit = new System.Windows.Forms.ComboBox();
            this.lbl_Main_Rechenarten = new System.Windows.Forms.Label();
            this.btn_Main_geteilt = new System.Windows.Forms.Button();
            this.btn_Main_mal = new System.Windows.Forms.Button();
            this.btn_Main_minus = new System.Windows.Forms.Button();
            this.btn_Main_plus = new System.Windows.Forms.Button();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.pnl_Aufg = new System.Windows.Forms.Panel();
            this.lbl_Rest = new System.Windows.Forms.Label();
            this.txb_AntwortRest = new System.Windows.Forms.TextBox();
            this.txb_AntwortDivide = new System.Windows.Forms.TextBox();
            this.grb_Lösung = new System.Windows.Forms.GroupBox();
            this.btn_weiter = new System.Windows.Forms.Button();
            this.lbl_richtigFalsch = new System.Windows.Forms.Label();
            this.lbl_vonRichtig = new System.Windows.Forms.Label();
            this.pgb_progress = new System.Windows.Forms.ProgressBar();
            this.btn_enter = new System.Windows.Forms.Button();
            this.txb_antwort = new System.Windows.Forms.TextBox();
            this.lbl_Aufg_progress = new System.Windows.Forms.Label();
            this.lbl_Aufg_header = new System.Windows.Forms.Label();
            this.pnl_End = new System.Windows.Forms.Panel();
            this.btn_End_Fertig = new System.Windows.Forms.Button();
            this.lbl_End_Prozent = new System.Windows.Forms.Label();
            this.lbl_End_vonRichtig = new System.Windows.Forms.Label();
            this.lbl_Ergebnis = new System.Windows.Forms.Label();
            this.pnl_Main.SuspendLayout();
            this.pnl_Aufg.SuspendLayout();
            this.grb_Lösung.SuspendLayout();
            this.pnl_End.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Main
            // 
            this.pnl_Main.Controls.Add(this.txb_Fragen);
            this.pnl_Main.Controls.Add(this.lbl_Main_fragen);
            this.pnl_Main.Controls.Add(this.btn_Main_Los);
            this.pnl_Main.Controls.Add(this.lbl_Main_Zahlen);
            this.pnl_Main.Controls.Add(this.cbb_Schwierigkeit);
            this.pnl_Main.Controls.Add(this.lbl_Main_Rechenarten);
            this.pnl_Main.Controls.Add(this.btn_Main_geteilt);
            this.pnl_Main.Controls.Add(this.btn_Main_mal);
            this.pnl_Main.Controls.Add(this.btn_Main_minus);
            this.pnl_Main.Controls.Add(this.btn_Main_plus);
            this.pnl_Main.Controls.Add(this.lbl_Title);
            this.pnl_Main.Location = new System.Drawing.Point(12, 12);
            this.pnl_Main.Name = "pnl_Main";
            this.pnl_Main.Size = new System.Drawing.Size(411, 291);
            this.pnl_Main.TabIndex = 0;
            // 
            // txb_Fragen
            // 
            this.txb_Fragen.Font = new System.Drawing.Font("Comic Sans MS", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_Fragen.Location = new System.Drawing.Point(163, 240);
            this.txb_Fragen.Name = "txb_Fragen";
            this.txb_Fragen.Size = new System.Drawing.Size(95, 31);
            this.txb_Fragen.TabIndex = 10;
            this.txb_Fragen.Text = "10";
            // 
            // lbl_Main_fragen
            // 
            this.lbl_Main_fragen.AutoSize = true;
            this.lbl_Main_fragen.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Main_fragen.Location = new System.Drawing.Point(151, 213);
            this.lbl_Main_fragen.Name = "lbl_Main_fragen";
            this.lbl_Main_fragen.Size = new System.Drawing.Size(117, 18);
            this.lbl_Main_fragen.TabIndex = 9;
            this.lbl_Main_fragen.Text = "Wie viele Fragen?";
            // 
            // btn_Main_Los
            // 
            this.btn_Main_Los.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Main_Los.Location = new System.Drawing.Point(274, 163);
            this.btn_Main_Los.Name = "btn_Main_Los";
            this.btn_Main_Los.Size = new System.Drawing.Size(123, 112);
            this.btn_Main_Los.TabIndex = 8;
            this.btn_Main_Los.Text = "Los geht\'s!";
            this.btn_Main_Los.UseVisualStyleBackColor = true;
            this.btn_Main_Los.Click += new System.EventHandler(this.btn_Main_Los_Click);
            // 
            // lbl_Main_Zahlen
            // 
            this.lbl_Main_Zahlen.AutoSize = true;
            this.lbl_Main_Zahlen.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Main_Zahlen.Location = new System.Drawing.Point(159, 131);
            this.lbl_Main_Zahlen.Name = "lbl_Main_Zahlen";
            this.lbl_Main_Zahlen.Size = new System.Drawing.Size(111, 19);
            this.lbl_Main_Zahlen.TabIndex = 7;
            this.lbl_Main_Zahlen.Text = "Welche Zahlen?";
            // 
            // cbb_Schwierigkeit
            // 
            this.cbb_Schwierigkeit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_Schwierigkeit.FormattingEnabled = true;
            this.cbb_Schwierigkeit.Items.AddRange(new object[] {
            "0-10",
            "0-20",
            "0-50",
            "0-100"});
            this.cbb_Schwierigkeit.Location = new System.Drawing.Point(163, 163);
            this.cbb_Schwierigkeit.Name = "cbb_Schwierigkeit";
            this.cbb_Schwierigkeit.Size = new System.Drawing.Size(95, 33);
            this.cbb_Schwierigkeit.TabIndex = 6;
            // 
            // lbl_Main_Rechenarten
            // 
            this.lbl_Main_Rechenarten.AutoSize = true;
            this.lbl_Main_Rechenarten.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Main_Rechenarten.Location = new System.Drawing.Point(3, 131);
            this.lbl_Main_Rechenarten.Name = "lbl_Main_Rechenarten";
            this.lbl_Main_Rechenarten.Size = new System.Drawing.Size(150, 19);
            this.lbl_Main_Rechenarten.TabIndex = 5;
            this.lbl_Main_Rechenarten.Text = "Welche Rechenarten?";
            // 
            // btn_Main_geteilt
            // 
            this.btn_Main_geteilt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Main_geteilt.Location = new System.Drawing.Point(80, 222);
            this.btn_Main_geteilt.Name = "btn_Main_geteilt";
            this.btn_Main_geteilt.Size = new System.Drawing.Size(54, 53);
            this.btn_Main_geteilt.TabIndex = 4;
            this.btn_Main_geteilt.Text = ":";
            this.btn_Main_geteilt.UseVisualStyleBackColor = true;
            this.btn_Main_geteilt.Click += new System.EventHandler(this.btn_Main_geteilt_Click);
            // 
            // btn_Main_mal
            // 
            this.btn_Main_mal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Main_mal.Location = new System.Drawing.Point(20, 222);
            this.btn_Main_mal.Name = "btn_Main_mal";
            this.btn_Main_mal.Size = new System.Drawing.Size(54, 53);
            this.btn_Main_mal.TabIndex = 3;
            this.btn_Main_mal.Text = "*";
            this.btn_Main_mal.UseVisualStyleBackColor = true;
            this.btn_Main_mal.Click += new System.EventHandler(this.btn_Main_mal_Click);
            // 
            // btn_Main_minus
            // 
            this.btn_Main_minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Main_minus.Location = new System.Drawing.Point(80, 163);
            this.btn_Main_minus.Name = "btn_Main_minus";
            this.btn_Main_minus.Size = new System.Drawing.Size(54, 53);
            this.btn_Main_minus.TabIndex = 2;
            this.btn_Main_minus.Text = "-";
            this.btn_Main_minus.UseVisualStyleBackColor = true;
            this.btn_Main_minus.Click += new System.EventHandler(this.btn_Main_minus_Click);
            // 
            // btn_Main_plus
            // 
            this.btn_Main_plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Main_plus.Location = new System.Drawing.Point(20, 163);
            this.btn_Main_plus.Name = "btn_Main_plus";
            this.btn_Main_plus.Size = new System.Drawing.Size(54, 53);
            this.btn_Main_plus.TabIndex = 1;
            this.btn_Main_plus.Text = "+";
            this.btn_Main_plus.UseVisualStyleBackColor = true;
            this.btn_Main_plus.Click += new System.EventHandler(this.btn_Main_plus_Click);
            // 
            // lbl_Title
            // 
            this.lbl_Title.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Title.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.Location = new System.Drawing.Point(0, 0);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(410, 115);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "Willkommen beim Mathe-Lernprogramm!\r\nSuch dir ein paar Schwerpunkte und die Schwi" +
    "erigkeitsstufe aus, und dann kann\'s losgehen!";
            // 
            // pnl_Aufg
            // 
            this.pnl_Aufg.Controls.Add(this.lbl_Rest);
            this.pnl_Aufg.Controls.Add(this.txb_AntwortRest);
            this.pnl_Aufg.Controls.Add(this.txb_AntwortDivide);
            this.pnl_Aufg.Controls.Add(this.grb_Lösung);
            this.pnl_Aufg.Controls.Add(this.pgb_progress);
            this.pnl_Aufg.Controls.Add(this.btn_enter);
            this.pnl_Aufg.Controls.Add(this.txb_antwort);
            this.pnl_Aufg.Controls.Add(this.lbl_Aufg_progress);
            this.pnl_Aufg.Controls.Add(this.lbl_Aufg_header);
            this.pnl_Aufg.Location = new System.Drawing.Point(12, 12);
            this.pnl_Aufg.Name = "pnl_Aufg";
            this.pnl_Aufg.Size = new System.Drawing.Size(411, 291);
            this.pnl_Aufg.TabIndex = 1;
            // 
            // lbl_Rest
            // 
            this.lbl_Rest.AutoSize = true;
            this.lbl_Rest.Font = new System.Drawing.Font("Comic Sans MS", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Rest.Location = new System.Drawing.Point(235, 115);
            this.lbl_Rest.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Rest.Name = "lbl_Rest";
            this.lbl_Rest.Size = new System.Drawing.Size(32, 15);
            this.lbl_Rest.TabIndex = 8;
            this.lbl_Rest.Text = "Rest:";
            this.lbl_Rest.Visible = false;
            // 
            // txb_AntwortRest
            // 
            this.txb_AntwortRest.Font = new System.Drawing.Font("Comic Sans MS", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_AntwortRest.Location = new System.Drawing.Point(231, 131);
            this.txb_AntwortRest.Name = "txb_AntwortRest";
            this.txb_AntwortRest.Size = new System.Drawing.Size(115, 53);
            this.txb_AntwortRest.TabIndex = 7;
            this.txb_AntwortRest.Visible = false;
            // 
            // txb_AntwortDivide
            // 
            this.txb_AntwortDivide.Font = new System.Drawing.Font("Comic Sans MS", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_AntwortDivide.Location = new System.Drawing.Point(7, 131);
            this.txb_AntwortDivide.Name = "txb_AntwortDivide";
            this.txb_AntwortDivide.Size = new System.Drawing.Size(220, 53);
            this.txb_AntwortDivide.TabIndex = 6;
            this.txb_AntwortDivide.Visible = false;
            // 
            // grb_Lösung
            // 
            this.grb_Lösung.Controls.Add(this.btn_weiter);
            this.grb_Lösung.Controls.Add(this.lbl_richtigFalsch);
            this.grb_Lösung.Controls.Add(this.lbl_vonRichtig);
            this.grb_Lösung.Location = new System.Drawing.Point(0, 184);
            this.grb_Lösung.Name = "grb_Lösung";
            this.grb_Lösung.Size = new System.Drawing.Size(411, 108);
            this.grb_Lösung.TabIndex = 5;
            this.grb_Lösung.TabStop = false;
            this.grb_Lösung.Visible = false;
            // 
            // btn_weiter
            // 
            this.btn_weiter.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_weiter.Location = new System.Drawing.Point(225, 58);
            this.btn_weiter.Name = "btn_weiter";
            this.btn_weiter.Size = new System.Drawing.Size(147, 34);
            this.btn_weiter.TabIndex = 7;
            this.btn_weiter.Text = "Weiter";
            this.btn_weiter.UseVisualStyleBackColor = true;
            this.btn_weiter.Click += new System.EventHandler(this.btn_weiter_Click);
            // 
            // lbl_richtigFalsch
            // 
            this.lbl_richtigFalsch.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_richtigFalsch.Location = new System.Drawing.Point(3, 16);
            this.lbl_richtigFalsch.Name = "lbl_richtigFalsch";
            this.lbl_richtigFalsch.Size = new System.Drawing.Size(385, 43);
            this.lbl_richtigFalsch.TabIndex = 5;
            this.lbl_richtigFalsch.Text = "Das ist leider falsch...";
            this.lbl_richtigFalsch.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_vonRichtig
            // 
            this.lbl_vonRichtig.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_vonRichtig.Location = new System.Drawing.Point(26, 57);
            this.lbl_vonRichtig.Name = "lbl_vonRichtig";
            this.lbl_vonRichtig.Size = new System.Drawing.Size(176, 34);
            this.lbl_vonRichtig.TabIndex = 6;
            this.lbl_vonRichtig.Text = "xyz von xyz richtig";
            this.lbl_vonRichtig.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pgb_progress
            // 
            this.pgb_progress.Location = new System.Drawing.Point(211, 18);
            this.pgb_progress.Name = "pgb_progress";
            this.pgb_progress.Size = new System.Drawing.Size(197, 14);
            this.pgb_progress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pgb_progress.TabIndex = 4;
            // 
            // btn_enter
            // 
            this.btn_enter.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_enter.Location = new System.Drawing.Point(352, 131);
            this.btn_enter.Name = "btn_enter";
            this.btn_enter.Size = new System.Drawing.Size(56, 53);
            this.btn_enter.TabIndex = 3;
            this.btn_enter.Text = ">";
            this.btn_enter.UseVisualStyleBackColor = true;
            this.btn_enter.Click += new System.EventHandler(this.btn_enter_Click);
            // 
            // txb_antwort
            // 
            this.txb_antwort.Font = new System.Drawing.Font("Comic Sans MS", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_antwort.Location = new System.Drawing.Point(7, 131);
            this.txb_antwort.Name = "txb_antwort";
            this.txb_antwort.Size = new System.Drawing.Size(339, 53);
            this.txb_antwort.TabIndex = 2;
            // 
            // lbl_Aufg_progress
            // 
            this.lbl_Aufg_progress.AutoSize = true;
            this.lbl_Aufg_progress.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Aufg_progress.Location = new System.Drawing.Point(3, 9);
            this.lbl_Aufg_progress.Name = "lbl_Aufg_progress";
            this.lbl_Aufg_progress.Size = new System.Drawing.Size(109, 23);
            this.lbl_Aufg_progress.TabIndex = 1;
            this.lbl_Aufg_progress.Text = "Frage x von x";
            // 
            // lbl_Aufg_header
            // 
            this.lbl_Aufg_header.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Aufg_header.Font = new System.Drawing.Font("Comic Sans MS", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Aufg_header.Location = new System.Drawing.Point(0, 45);
            this.lbl_Aufg_header.Name = "lbl_Aufg_header";
            this.lbl_Aufg_header.Size = new System.Drawing.Size(411, 70);
            this.lbl_Aufg_header.TabIndex = 0;
            this.lbl_Aufg_header.Text = "Was ist xyz + xyz?";
            this.lbl_Aufg_header.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnl_End
            // 
            this.pnl_End.Controls.Add(this.btn_End_Fertig);
            this.pnl_End.Controls.Add(this.lbl_End_Prozent);
            this.pnl_End.Controls.Add(this.lbl_End_vonRichtig);
            this.pnl_End.Controls.Add(this.lbl_Ergebnis);
            this.pnl_End.Font = new System.Drawing.Font("Comic Sans MS", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnl_End.Location = new System.Drawing.Point(12, 12);
            this.pnl_End.Name = "pnl_End";
            this.pnl_End.Size = new System.Drawing.Size(411, 291);
            this.pnl_End.TabIndex = 2;
            // 
            // btn_End_Fertig
            // 
            this.btn_End_Fertig.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_End_Fertig.Location = new System.Drawing.Point(148, 239);
            this.btn_End_Fertig.Name = "btn_End_Fertig";
            this.btn_End_Fertig.Size = new System.Drawing.Size(122, 43);
            this.btn_End_Fertig.TabIndex = 3;
            this.btn_End_Fertig.Text = "Fertig";
            this.btn_End_Fertig.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_End_Fertig.UseVisualStyleBackColor = true;
            this.btn_End_Fertig.Click += new System.EventHandler(this.btn_End_Fertig_Click);
            // 
            // lbl_End_Prozent
            // 
            this.lbl_End_Prozent.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_End_Prozent.Location = new System.Drawing.Point(-1, 130);
            this.lbl_End_Prozent.Name = "lbl_End_Prozent";
            this.lbl_End_Prozent.Size = new System.Drawing.Size(411, 32);
            this.lbl_End_Prozent.TabIndex = 2;
            this.lbl_End_Prozent.Text = "Das sind 100%!";
            this.lbl_End_Prozent.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_End_vonRichtig
            // 
            this.lbl_End_vonRichtig.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_End_vonRichtig.Location = new System.Drawing.Point(-1, 96);
            this.lbl_End_vonRichtig.Name = "lbl_End_vonRichtig";
            this.lbl_End_vonRichtig.Size = new System.Drawing.Size(411, 34);
            this.lbl_End_vonRichtig.TabIndex = 1;
            this.lbl_End_vonRichtig.Text = "xyz von xyz richtig!";
            this.lbl_End_vonRichtig.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_Ergebnis
            // 
            this.lbl_Ergebnis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Ergebnis.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Ergebnis.Location = new System.Drawing.Point(0, 0);
            this.lbl_Ergebnis.Name = "lbl_Ergebnis";
            this.lbl_Ergebnis.Size = new System.Drawing.Size(410, 74);
            this.lbl_Ergebnis.TabIndex = 0;
            this.lbl_Ergebnis.Text = "Hier ist dein Ergebnis!";
            this.lbl_Ergebnis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frm_Kinderrechner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 315);
            this.Controls.Add(this.pnl_End);
            this.Controls.Add(this.pnl_Aufg);
            this.Controls.Add(this.pnl_Main);
            this.Name = "frm_Kinderrechner";
            this.Text = "Rechnen Lernen!";
            this.pnl_Main.ResumeLayout(false);
            this.pnl_Main.PerformLayout();
            this.pnl_Aufg.ResumeLayout(false);
            this.pnl_Aufg.PerformLayout();
            this.grb_Lösung.ResumeLayout(false);
            this.pnl_End.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Main;
        private System.Windows.Forms.Label lbl_Main_Rechenarten;
        private System.Windows.Forms.Button btn_Main_geteilt;
        private System.Windows.Forms.Button btn_Main_mal;
        private System.Windows.Forms.Button btn_Main_minus;
        private System.Windows.Forms.Button btn_Main_plus;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.ComboBox cbb_Schwierigkeit;
        private System.Windows.Forms.Button btn_Main_Los;
        private System.Windows.Forms.Label lbl_Main_Zahlen;
        private System.Windows.Forms.Panel pnl_Aufg;
        private System.Windows.Forms.Label lbl_Aufg_header;
        private System.Windows.Forms.Label lbl_Aufg_progress;
        private System.Windows.Forms.TextBox txb_antwort;
        private System.Windows.Forms.Button btn_enter;
        private System.Windows.Forms.TextBox txb_Fragen;
        private System.Windows.Forms.Label lbl_Main_fragen;
        private System.Windows.Forms.ProgressBar pgb_progress;
        private System.Windows.Forms.Label lbl_vonRichtig;
        private System.Windows.Forms.Label lbl_richtigFalsch;
        private System.Windows.Forms.Button btn_weiter;
        private System.Windows.Forms.GroupBox grb_Lösung;
        private System.Windows.Forms.Panel pnl_End;
        private System.Windows.Forms.Button btn_End_Fertig;
        private System.Windows.Forms.Label lbl_End_Prozent;
        private System.Windows.Forms.Label lbl_End_vonRichtig;
        private System.Windows.Forms.Label lbl_Ergebnis;
        private System.Windows.Forms.TextBox txb_AntwortRest;
        private System.Windows.Forms.TextBox txb_AntwortDivide;
        private System.Windows.Forms.Label lbl_Rest;
    }
}

