namespace THA_W9_TJOK_SAVITRI
{
    partial class ShowMatch
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
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxMatch = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxTeam = new System.Windows.Forms.ComboBox();
            this.dgvHome = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelAway = new System.Windows.Forms.Label();
            this.labelHome = new System.Windows.Forms.Label();
            this.dgvAway = new System.Windows.Forms.DataGridView();
            this.dgvDetails = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAway)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DimGray;
            this.button1.Location = new System.Drawing.Point(344, 60);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 31);
            this.button1.TabIndex = 27;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(209, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 18);
            this.label2.TabIndex = 26;
            this.label2.Text = "Matches";
            // 
            // comboBoxMatch
            // 
            this.comboBoxMatch.Enabled = false;
            this.comboBoxMatch.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxMatch.FormattingEnabled = true;
            this.comboBoxMatch.Location = new System.Drawing.Point(209, 60);
            this.comboBoxMatch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxMatch.Name = "comboBoxMatch";
            this.comboBoxMatch.Size = new System.Drawing.Size(121, 26);
            this.comboBoxMatch.TabIndex = 25;
            this.comboBoxMatch.SelectedIndexChanged += new System.EventHandler(this.comboBoxMatch_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 18);
            this.label1.TabIndex = 24;
            this.label1.Text = "Team";
            // 
            // comboBoxTeam
            // 
            this.comboBoxTeam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTeam.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTeam.FormattingEnabled = true;
            this.comboBoxTeam.Location = new System.Drawing.Point(48, 60);
            this.comboBoxTeam.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxTeam.Name = "comboBoxTeam";
            this.comboBoxTeam.Size = new System.Drawing.Size(121, 26);
            this.comboBoxTeam.TabIndex = 23;
            this.comboBoxTeam.SelectedIndexChanged += new System.EventHandler(this.comboBoxTeam_SelectedIndexChanged);
            // 
            // dgvHome
            // 
            this.dgvHome.AllowUserToAddRows = false;
            this.dgvHome.AllowUserToDeleteRows = false;
            this.dgvHome.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHome.BackgroundColor = System.Drawing.Color.FloralWhite;
            this.dgvHome.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHome.GridColor = System.Drawing.Color.Tan;
            this.dgvHome.Location = new System.Drawing.Point(11, 144);
            this.dgvHome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvHome.Name = "dgvHome";
            this.dgvHome.ReadOnly = true;
            this.dgvHome.RowHeadersWidth = 51;
            this.dgvHome.RowTemplate.Height = 24;
            this.dgvHome.Size = new System.Drawing.Size(346, 154);
            this.dgvHome.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(121, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 18);
            this.label3.TabIndex = 29;
            this.label3.Text = "Home Team";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(528, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 18);
            this.label4.TabIndex = 30;
            this.label4.Text = "Away Team";
            // 
            // labelAway
            // 
            this.labelAway.AutoSize = true;
            this.labelAway.Location = new System.Drawing.Point(643, 115);
            this.labelAway.Name = "labelAway";
            this.labelAway.Size = new System.Drawing.Size(16, 18);
            this.labelAway.TabIndex = 31;
            this.labelAway.Text = "a";
            this.labelAway.Visible = false;
            // 
            // labelHome
            // 
            this.labelHome.AutoSize = true;
            this.labelHome.Location = new System.Drawing.Point(238, 115);
            this.labelHome.Name = "labelHome";
            this.labelHome.Size = new System.Drawing.Size(16, 18);
            this.labelHome.TabIndex = 32;
            this.labelHome.Text = "a";
            this.labelHome.Visible = false;
            // 
            // dgvAway
            // 
            this.dgvAway.AllowUserToAddRows = false;
            this.dgvAway.AllowUserToDeleteRows = false;
            this.dgvAway.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAway.BackgroundColor = System.Drawing.Color.FloralWhite;
            this.dgvAway.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAway.GridColor = System.Drawing.Color.Tan;
            this.dgvAway.Location = new System.Drawing.Point(431, 144);
            this.dgvAway.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvAway.Name = "dgvAway";
            this.dgvAway.ReadOnly = true;
            this.dgvAway.RowHeadersWidth = 51;
            this.dgvAway.RowTemplate.Height = 24;
            this.dgvAway.Size = new System.Drawing.Size(346, 154);
            this.dgvAway.TabIndex = 33;
            // 
            // dgvDetails
            // 
            this.dgvDetails.AllowUserToAddRows = false;
            this.dgvDetails.AllowUserToDeleteRows = false;
            this.dgvDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetails.BackgroundColor = System.Drawing.Color.FloralWhite;
            this.dgvDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetails.GridColor = System.Drawing.Color.Tan;
            this.dgvDetails.Location = new System.Drawing.Point(223, 343);
            this.dgvDetails.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvDetails.Name = "dgvDetails";
            this.dgvDetails.ReadOnly = true;
            this.dgvDetails.RowHeadersWidth = 51;
            this.dgvDetails.RowTemplate.Height = 24;
            this.dgvDetails.Size = new System.Drawing.Size(346, 154);
            this.dgvDetails.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(350, 316);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 18);
            this.label5.TabIndex = 35;
            this.label5.Text = "Match Details";
            // 
            // ShowMatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(801, 578);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvDetails);
            this.Controls.Add(this.dgvAway);
            this.Controls.Add(this.labelHome);
            this.Controls.Add(this.labelAway);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvHome);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxMatch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxTeam);
            this.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ShowMatch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ShowMatch";
            this.Load += new System.EventHandler(this.ShowMatch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAway)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxMatch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxTeam;
        private System.Windows.Forms.DataGridView dgvHome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelAway;
        private System.Windows.Forms.Label labelHome;
        private System.Windows.Forms.DataGridView dgvAway;
        private System.Windows.Forms.DataGridView dgvDetails;
        private System.Windows.Forms.Label label5;
    }
}