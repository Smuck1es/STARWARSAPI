namespace StarWarsAPI
{
    partial class StarWarsInfo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GetPlanet_btn = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.txbID = new System.Windows.Forms.TextBox();
            this.GetPerson_btn = new System.Windows.Forms.Button();
            this.GetSpecies_btn = new System.Windows.Forms.Button();
            this.GetAllSpecies_btn = new System.Windows.Forms.Button();
            this.lsbSpecies = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GetFilmInfo_btn = new System.Windows.Forms.Button();
            this.txbFilmID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.compareStarship_btn = new System.Windows.Forms.Button();
            this.starshipOne_txb = new System.Windows.Forms.TextBox();
            this.starshipTwo_txb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.resultLbl = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GetPlanet_btn
            // 
            this.GetPlanet_btn.Location = new System.Drawing.Point(46, 25);
            this.GetPlanet_btn.Name = "GetPlanet_btn";
            this.GetPlanet_btn.Size = new System.Drawing.Size(75, 23);
            this.GetPlanet_btn.TabIndex = 0;
            this.GetPlanet_btn.Text = "Get Planet";
            this.GetPlanet_btn.UseVisualStyleBackColor = true;
            this.GetPlanet_btn.Click += new System.EventHandler(this.GetPlanet_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(12, 138);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(0, 13);
            this.lblInfo.TabIndex = 1;
            this.lblInfo.Click += new System.EventHandler(this.lblname_Click);
            // 
            // txbID
            // 
            this.txbID.Location = new System.Drawing.Point(134, 54);
            this.txbID.Name = "txbID";
            this.txbID.Size = new System.Drawing.Size(100, 20);
            this.txbID.TabIndex = 2;
            this.txbID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // GetPerson_btn
            // 
            this.GetPerson_btn.Location = new System.Drawing.Point(46, 54);
            this.GetPerson_btn.Name = "GetPerson_btn";
            this.GetPerson_btn.Size = new System.Drawing.Size(75, 23);
            this.GetPerson_btn.TabIndex = 3;
            this.GetPerson_btn.Text = "Get Person";
            this.GetPerson_btn.UseVisualStyleBackColor = true;
            this.GetPerson_btn.Click += new System.EventHandler(this.GetPerson_btn_Click);
            // 
            // GetSpecies_btn
            // 
            this.GetSpecies_btn.Location = new System.Drawing.Point(46, 83);
            this.GetSpecies_btn.Name = "GetSpecies_btn";
            this.GetSpecies_btn.Size = new System.Drawing.Size(75, 23);
            this.GetSpecies_btn.TabIndex = 4;
            this.GetSpecies_btn.Text = "Get Species";
            this.GetSpecies_btn.UseVisualStyleBackColor = true;
            this.GetSpecies_btn.Click += new System.EventHandler(this.GetSpecies_btn_Click);
            // 
            // GetAllSpecies_btn
            // 
            this.GetAllSpecies_btn.Location = new System.Drawing.Point(11, 112);
            this.GetAllSpecies_btn.Name = "GetAllSpecies_btn";
            this.GetAllSpecies_btn.Size = new System.Drawing.Size(110, 23);
            this.GetAllSpecies_btn.TabIndex = 5;
            this.GetAllSpecies_btn.Text = "Show All Species";
            this.GetAllSpecies_btn.UseVisualStyleBackColor = true;
            this.GetAllSpecies_btn.Click += new System.EventHandler(this.GetAllSpecies_btn_Click);
            // 
            // lsbSpecies
            // 
            this.lsbSpecies.FormattingEnabled = true;
            this.lsbSpecies.Location = new System.Drawing.Point(515, 54);
            this.lsbSpecies.Name = "lsbSpecies";
            this.lsbSpecies.Size = new System.Drawing.Size(496, 355);
            this.lsbSpecies.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Input ID:";
            // 
            // GetFilmInfo_btn
            // 
            this.GetFilmInfo_btn.Location = new System.Drawing.Point(255, 54);
            this.GetFilmInfo_btn.Name = "GetFilmInfo_btn";
            this.GetFilmInfo_btn.Size = new System.Drawing.Size(110, 23);
            this.GetFilmInfo_btn.TabIndex = 8;
            this.GetFilmInfo_btn.Text = "Display Film Info";
            this.GetFilmInfo_btn.UseVisualStyleBackColor = true;
            this.GetFilmInfo_btn.Click += new System.EventHandler(this.GetFilmInfo_btn_Click);
            // 
            // txbFilmID
            // 
            this.txbFilmID.Location = new System.Drawing.Point(383, 56);
            this.txbFilmID.Name = "txbFilmID";
            this.txbFilmID.Size = new System.Drawing.Size(100, 20);
            this.txbFilmID.TabIndex = 9;
            this.txbFilmID.TextChanged += new System.EventHandler(this.txbFilmID_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(380, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Movie:";
            // 
            // compareStarship_btn
            // 
            this.compareStarship_btn.Location = new System.Drawing.Point(181, 88);
            this.compareStarship_btn.Name = "compareStarship_btn";
            this.compareStarship_btn.Size = new System.Drawing.Size(110, 44);
            this.compareStarship_btn.TabIndex = 11;
            this.compareStarship_btn.Text = "Compare Starship Speed";
            this.compareStarship_btn.UseVisualStyleBackColor = true;
            this.compareStarship_btn.Click += new System.EventHandler(this.compareStarship_btn_Click);
            // 
            // starshipOne_txb
            // 
            this.starshipOne_txb.Location = new System.Drawing.Point(371, 88);
            this.starshipOne_txb.Name = "starshipOne_txb";
            this.starshipOne_txb.Size = new System.Drawing.Size(100, 20);
            this.starshipOne_txb.TabIndex = 12;
            // 
            // starshipTwo_txb
            // 
            this.starshipTwo_txb.Location = new System.Drawing.Point(371, 112);
            this.starshipTwo_txb.Name = "starshipTwo_txb";
            this.starshipTwo_txb.Size = new System.Drawing.Size(100, 20);
            this.starshipTwo_txb.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(297, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Ship One ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(297, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Ship Two ID:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(468, 182);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(8, 8);
            this.tabControl1.TabIndex = 16;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(0, 0);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(0, 0);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // resultLbl
            // 
            this.resultLbl.AutoSize = true;
            this.resultLbl.Location = new System.Drawing.Point(252, 138);
            this.resultLbl.Name = "resultLbl";
            this.resultLbl.Size = new System.Drawing.Size(37, 13);
            this.resultLbl.TabIndex = 17;
            this.resultLbl.Text = "12313";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 647);
            this.Controls.Add(this.resultLbl);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.starshipTwo_txb);
            this.Controls.Add(this.starshipOne_txb);
            this.Controls.Add(this.compareStarship_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbFilmID);
            this.Controls.Add(this.GetFilmInfo_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lsbSpecies);
            this.Controls.Add(this.GetAllSpecies_btn);
            this.Controls.Add(this.GetSpecies_btn);
            this.Controls.Add(this.GetPerson_btn);
            this.Controls.Add(this.txbID);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.GetPlanet_btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GetPlanet_btn;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.TextBox txbID;
        private System.Windows.Forms.Button GetPerson_btn;
        private System.Windows.Forms.Button GetSpecies_btn;
        private System.Windows.Forms.Button GetAllSpecies_btn;
        private System.Windows.Forms.ListBox lsbSpecies;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button GetFilmInfo_btn;
        private System.Windows.Forms.TextBox txbFilmID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button compareStarship_btn;
        private System.Windows.Forms.TextBox starshipOne_txb;
        private System.Windows.Forms.TextBox starshipTwo_txb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label resultLbl;
    }
}

