namespace ADW09_TAKE_HOME
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbTeam = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblTeam = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblNation = new System.Windows.Forms.Label();
            this.lblNum = new System.Windows.Forms.Label();
            this.lblYC = new System.Windows.Forms.Label();
            this.lblRC = new System.Windows.Forms.Label();
            this.lblGO = new System.Windows.Forms.Label();
            this.lblPM = new System.Windows.Forms.Label();
            this.cmbPlayer = new System.Windows.Forms.ComboBox();
            this.lblGW = new System.Windows.Forms.Label();
            this.lblGP = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Euclid Circular B Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Team :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Euclid Circular B Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select Player :";
            // 
            // cmbTeam
            // 
            this.cmbTeam.FormattingEnabled = true;
            this.cmbTeam.Location = new System.Drawing.Point(190, 27);
            this.cmbTeam.Name = "cmbTeam";
            this.cmbTeam.Size = new System.Drawing.Size(268, 28);
            this.cmbTeam.TabIndex = 2;
            this.cmbTeam.SelectedIndexChanged += new System.EventHandler(this.cmbTeam_SelectedIndexChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Olive;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Euclid Circular B Medium", 7.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(522, 51);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(96, 46);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Euclid Circular B Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(13, 134);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(18, 23);
            this.lblName.TabIndex = 14;
            this.lblName.Text = "-";
            // 
            // lblTeam
            // 
            this.lblTeam.AutoSize = true;
            this.lblTeam.Font = new System.Drawing.Font("Euclid Circular B Medium", 9F, System.Drawing.FontStyle.Bold);
            this.lblTeam.Location = new System.Drawing.Point(13, 186);
            this.lblTeam.Name = "lblTeam";
            this.lblTeam.Size = new System.Drawing.Size(18, 23);
            this.lblTeam.TabIndex = 15;
            this.lblTeam.Text = "-";
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Font = new System.Drawing.Font("Euclid Circular B Medium", 9F, System.Drawing.FontStyle.Bold);
            this.lblPosition.Location = new System.Drawing.Point(13, 244);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(18, 23);
            this.lblPosition.TabIndex = 16;
            this.lblPosition.Text = "-";
            // 
            // lblNation
            // 
            this.lblNation.AutoSize = true;
            this.lblNation.Font = new System.Drawing.Font("Euclid Circular B Medium", 9F, System.Drawing.FontStyle.Bold);
            this.lblNation.Location = new System.Drawing.Point(13, 299);
            this.lblNation.Name = "lblNation";
            this.lblNation.Size = new System.Drawing.Size(18, 23);
            this.lblNation.TabIndex = 17;
            this.lblNation.Text = "-";
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Font = new System.Drawing.Font("Euclid Circular B Medium", 9F, System.Drawing.FontStyle.Bold);
            this.lblNum.Location = new System.Drawing.Point(13, 356);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(18, 23);
            this.lblNum.TabIndex = 18;
            this.lblNum.Text = "-";
            // 
            // lblYC
            // 
            this.lblYC.AutoSize = true;
            this.lblYC.Font = new System.Drawing.Font("Euclid Circular B Medium", 9F, System.Drawing.FontStyle.Bold);
            this.lblYC.Location = new System.Drawing.Point(412, 134);
            this.lblYC.Name = "lblYC";
            this.lblYC.Size = new System.Drawing.Size(18, 23);
            this.lblYC.TabIndex = 19;
            this.lblYC.Text = "-";
            // 
            // lblRC
            // 
            this.lblRC.AutoSize = true;
            this.lblRC.Font = new System.Drawing.Font("Euclid Circular B Medium", 9F, System.Drawing.FontStyle.Bold);
            this.lblRC.Location = new System.Drawing.Point(412, 186);
            this.lblRC.Name = "lblRC";
            this.lblRC.Size = new System.Drawing.Size(18, 23);
            this.lblRC.TabIndex = 20;
            this.lblRC.Text = "-";
            // 
            // lblGO
            // 
            this.lblGO.AutoSize = true;
            this.lblGO.Font = new System.Drawing.Font("Euclid Circular B Medium", 9F, System.Drawing.FontStyle.Bold);
            this.lblGO.Location = new System.Drawing.Point(412, 244);
            this.lblGO.Name = "lblGO";
            this.lblGO.Size = new System.Drawing.Size(18, 23);
            this.lblGO.TabIndex = 21;
            this.lblGO.Text = "-";
            // 
            // lblPM
            // 
            this.lblPM.AutoSize = true;
            this.lblPM.Font = new System.Drawing.Font("Euclid Circular B Medium", 9F, System.Drawing.FontStyle.Bold);
            this.lblPM.Location = new System.Drawing.Point(412, 299);
            this.lblPM.Name = "lblPM";
            this.lblPM.Size = new System.Drawing.Size(18, 23);
            this.lblPM.TabIndex = 22;
            this.lblPM.Text = "-";
            // 
            // cmbPlayer
            // 
            this.cmbPlayer.FormattingEnabled = true;
            this.cmbPlayer.Location = new System.Drawing.Point(190, 69);
            this.cmbPlayer.Name = "cmbPlayer";
            this.cmbPlayer.Size = new System.Drawing.Size(268, 28);
            this.cmbPlayer.TabIndex = 23;
            this.cmbPlayer.SelectedIndexChanged += new System.EventHandler(this.cmbPlayer_SelectedIndexChanged);
            // 
            // lblGW
            // 
            this.lblGW.AutoSize = true;
            this.lblGW.Font = new System.Drawing.Font("Euclid Circular B Medium", 9F, System.Drawing.FontStyle.Bold);
            this.lblGW.Location = new System.Drawing.Point(412, 356);
            this.lblGW.Name = "lblGW";
            this.lblGW.Size = new System.Drawing.Size(18, 23);
            this.lblGW.TabIndex = 24;
            this.lblGW.Text = "-";
            // 
            // lblGP
            // 
            this.lblGP.AutoSize = true;
            this.lblGP.Font = new System.Drawing.Font("Euclid Circular B Medium", 9F, System.Drawing.FontStyle.Bold);
            this.lblGP.Location = new System.Drawing.Point(412, 409);
            this.lblGP.Name = "lblGP";
            this.lblGP.Size = new System.Drawing.Size(18, 23);
            this.lblGP.TabIndex = 25;
            this.lblGP.Text = "-";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(1107, 493);
            this.Controls.Add(this.lblGP);
            this.Controls.Add(this.lblGW);
            this.Controls.Add(this.cmbPlayer);
            this.Controls.Add(this.lblPM);
            this.Controls.Add(this.lblGO);
            this.Controls.Add(this.lblRC);
            this.Controls.Add(this.lblYC);
            this.Controls.Add(this.lblNum);
            this.Controls.Add(this.lblNation);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.lblTeam);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cmbTeam);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbTeam;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblTeam;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label lblNation;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.Label lblYC;
        private System.Windows.Forms.Label lblRC;
        private System.Windows.Forms.Label lblGO;
        private System.Windows.Forms.Label lblPM;
        private System.Windows.Forms.ComboBox cmbPlayer;
        private System.Windows.Forms.Label lblGW;
        private System.Windows.Forms.Label lblGP;
    }
}