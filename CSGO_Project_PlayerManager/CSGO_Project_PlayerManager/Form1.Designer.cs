namespace CSGO_Project_PlayerManager
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
            this.CreatePlayer = new System.Windows.Forms.Button();
            this.Cost = new System.Windows.Forms.TextBox();
            this._Name = new System.Windows.Forms.TextBox();
            this.PortraitSelect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TeamDropDown = new System.Windows.Forms.ComboBox();
            this.Accuracy = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Stamina = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.XMLSelect = new System.Windows.Forms.Button();
            this.XMLdisplay = new System.Windows.Forms.Label();
            this.PortraitDisplay = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PortraitDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // CreatePlayer
            // 
            this.CreatePlayer.Location = new System.Drawing.Point(172, 226);
            this.CreatePlayer.Name = "CreatePlayer";
            this.CreatePlayer.Size = new System.Drawing.Size(75, 23);
            this.CreatePlayer.TabIndex = 0;
            this.CreatePlayer.Text = "Save";
            this.CreatePlayer.UseVisualStyleBackColor = true;
            this.CreatePlayer.Click += new System.EventHandler(this.CreatePlayer_Click);
            // 
            // Cost
            // 
            this.Cost.Location = new System.Drawing.Point(172, 181);
            this.Cost.Name = "Cost";
            this.Cost.Size = new System.Drawing.Size(100, 20);
            this.Cost.TabIndex = 2;
            this.Cost.TextChanged += new System.EventHandler(this.Cost_TextChanged);
            this.Cost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Cost_KeyPress);
            // 
            // _Name
            // 
            this._Name.Location = new System.Drawing.Point(172, 21);
            this._Name.Name = "_Name";
            this._Name.Size = new System.Drawing.Size(100, 20);
            this._Name.TabIndex = 3;
            this._Name.TextChanged += new System.EventHandler(this.Name_TextChanged);
            // 
            // PortraitSelect
            // 
            this.PortraitSelect.Location = new System.Drawing.Point(12, 103);
            this.PortraitSelect.Name = "PortraitSelect";
            this.PortraitSelect.Size = new System.Drawing.Size(89, 23);
            this.PortraitSelect.TabIndex = 5;
            this.PortraitSelect.Text = "Select Portrait";
            this.PortraitSelect.UseVisualStyleBackColor = true;
            this.PortraitSelect.Click += new System.EventHandler(this.PortraitSelect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(169, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(169, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Team";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(169, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Cost";
            // 
            // TeamDropDown
            // 
            this.TeamDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TeamDropDown.FormattingEnabled = true;
            this.TeamDropDown.Location = new System.Drawing.Point(172, 64);
            this.TeamDropDown.Name = "TeamDropDown";
            this.TeamDropDown.Size = new System.Drawing.Size(100, 21);
            this.TeamDropDown.TabIndex = 9;
            this.TeamDropDown.SelectedIndexChanged += new System.EventHandler(this.TeamDropDown_SelectedIndexChanged);
            // 
            // Accuracy
            // 
            this.Accuracy.Location = new System.Drawing.Point(172, 103);
            this.Accuracy.Name = "Accuracy";
            this.Accuracy.Size = new System.Drawing.Size(100, 20);
            this.Accuracy.TabIndex = 10;
            this.Accuracy.TextChanged += new System.EventHandler(this.Accuracy_TextChanged);
            this.Accuracy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Accuracy_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(169, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Accuracy";
            // 
            // Stamina
            // 
            this.Stamina.Location = new System.Drawing.Point(172, 142);
            this.Stamina.Name = "Stamina";
            this.Stamina.Size = new System.Drawing.Size(100, 20);
            this.Stamina.TabIndex = 12;
            this.Stamina.TextChanged += new System.EventHandler(this.Stamina_TextChanged);
            this.Stamina.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Stamina_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(169, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Stamina";
            // 
            // XMLSelect
            // 
            this.XMLSelect.Location = new System.Drawing.Point(12, 165);
            this.XMLSelect.Name = "XMLSelect";
            this.XMLSelect.Size = new System.Drawing.Size(75, 23);
            this.XMLSelect.TabIndex = 14;
            this.XMLSelect.Text = "Select XML";
            this.XMLSelect.UseVisualStyleBackColor = true;
            this.XMLSelect.Click += new System.EventHandler(this.XMLSelect_Click);
            // 
            // XMLdisplay
            // 
            this.XMLdisplay.AutoSize = true;
            this.XMLdisplay.Location = new System.Drawing.Point(12, 149);
            this.XMLdisplay.Name = "XMLdisplay";
            this.XMLdisplay.Size = new System.Drawing.Size(43, 13);
            this.XMLdisplay.TabIndex = 15;
            this.XMLdisplay.Text = "XML dir";
            // 
            // PortraitDisplay
            // 
            this.PortraitDisplay.Location = new System.Drawing.Point(12, 11);
            this.PortraitDisplay.Name = "PortraitDisplay";
            this.PortraitDisplay.Size = new System.Drawing.Size(100, 86);
            this.PortraitDisplay.TabIndex = 16;
            this.PortraitDisplay.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.PortraitDisplay);
            this.Controls.Add(this.XMLdisplay);
            this.Controls.Add(this.XMLSelect);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Stamina);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Accuracy);
            this.Controls.Add(this.TeamDropDown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PortraitSelect);
            this.Controls.Add(this._Name);
            this.Controls.Add(this.Cost);
            this.Controls.Add(this.CreatePlayer);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PortraitDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CreatePlayer;
        private System.Windows.Forms.TextBox Cost;
        private System.Windows.Forms.TextBox _Name;
        private System.Windows.Forms.Button PortraitSelect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox TeamDropDown;
        private System.Windows.Forms.TextBox Accuracy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Stamina;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button XMLSelect;
        private System.Windows.Forms.Label XMLdisplay;
        private System.Windows.Forms.PictureBox PortraitDisplay;
    }
}

