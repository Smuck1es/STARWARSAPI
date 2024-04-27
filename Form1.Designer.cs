namespace StarWarsAPI
{
    partial class Form1
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
            this.lblInfo.Location = new System.Drawing.Point(43, 131);
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
            this.GetAllSpecies_btn.Location = new System.Drawing.Point(258, 54);
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
            this.lsbSpecies.Location = new System.Drawing.Point(477, 54);
            this.lsbSpecies.Name = "lsbSpecies";
            this.lsbSpecies.Size = new System.Drawing.Size(496, 355);
            this.lsbSpecies.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Input ID:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 506);
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
    }
}

