﻿namespace sustavZaPreporukuVideoIgara.Forme
{
    partial class PetnaestoPitanje
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PetnaestoPitanje));
            this.lblDrugoPitanje = new System.Windows.Forms.Label();
            this.cbJakoVazno = new System.Windows.Forms.CheckBox();
            this.cbVazno = new System.Windows.Forms.CheckBox();
            this.cbSvejedno = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBrojPitanja = new System.Windows.Forms.Label();
            this.btnSljedece = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDrugoPitanje
            // 
            this.lblDrugoPitanje.AutoSize = true;
            this.lblDrugoPitanje.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDrugoPitanje.Location = new System.Drawing.Point(42, 42);
            this.lblDrugoPitanje.Name = "lblDrugoPitanje";
            this.lblDrugoPitanje.Size = new System.Drawing.Size(400, 29);
            this.lblDrugoPitanje.TabIndex = 25;
            this.lblDrugoPitanje.Text = "Koliko ti je bitna popularnost igrice ?";
            // 
            // cbJakoVazno
            // 
            this.cbJakoVazno.AutoSize = true;
            this.cbJakoVazno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbJakoVazno.Location = new System.Drawing.Point(93, 193);
            this.cbJakoVazno.Name = "cbJakoVazno";
            this.cbJakoVazno.Size = new System.Drawing.Size(135, 29);
            this.cbJakoVazno.TabIndex = 38;
            this.cbJakoVazno.Text = "Jako važno";
            this.cbJakoVazno.UseVisualStyleBackColor = true;
            this.cbJakoVazno.CheckedChanged += new System.EventHandler(this.cbJakoVazno_CheckedChanged);
            // 
            // cbVazno
            // 
            this.cbVazno.AutoSize = true;
            this.cbVazno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbVazno.Location = new System.Drawing.Point(93, 149);
            this.cbVazno.Name = "cbVazno";
            this.cbVazno.Size = new System.Drawing.Size(91, 29);
            this.cbVazno.TabIndex = 37;
            this.cbVazno.Text = "Važno";
            this.cbVazno.UseVisualStyleBackColor = true;
            this.cbVazno.CheckedChanged += new System.EventHandler(this.cbVazno_CheckedChanged);
            // 
            // cbSvejedno
            // 
            this.cbSvejedno.AutoSize = true;
            this.cbSvejedno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSvejedno.Location = new System.Drawing.Point(93, 105);
            this.cbSvejedno.Name = "cbSvejedno";
            this.cbSvejedno.Size = new System.Drawing.Size(117, 29);
            this.cbSvejedno.TabIndex = 36;
            this.cbSvejedno.Text = "Svejedno";
            this.cbSvejedno.UseVisualStyleBackColor = true;
            this.cbSvejedno.CheckedChanged += new System.EventHandler(this.cbSvejedno_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 252);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 25);
            this.label1.TabIndex = 39;
            this.label1.Text = "Moguće označiti samo 1 opciju. ";
            // 
            // lblBrojPitanja
            // 
            this.lblBrojPitanja.AutoSize = true;
            this.lblBrojPitanja.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrojPitanja.Location = new System.Drawing.Point(22, 484);
            this.lblBrojPitanja.Name = "lblBrojPitanja";
            this.lblBrojPitanja.Size = new System.Drawing.Size(84, 29);
            this.lblBrojPitanja.TabIndex = 40;
            this.lblBrojPitanja.Text = "15 / 16";
            // 
            // btnSljedece
            // 
            this.btnSljedece.Location = new System.Drawing.Point(656, 481);
            this.btnSljedece.Name = "btnSljedece";
            this.btnSljedece.Size = new System.Drawing.Size(125, 42);
            this.btnSljedece.TabIndex = 46;
            this.btnSljedece.Text = "Sljedeće";
            this.btnSljedece.UseVisualStyleBackColor = true;
            this.btnSljedece.Click += new System.EventHandler(this.btnSljedece_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(112, 481);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(125, 42);
            this.btnOdustani.TabIndex = 45;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // PetnaestoPitanje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(804, 542);
            this.Controls.Add(this.btnSljedece);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.lblBrojPitanja);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbJakoVazno);
            this.Controls.Add(this.cbVazno);
            this.Controls.Add(this.cbSvejedno);
            this.Controls.Add(this.lblDrugoPitanje);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(822, 589);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(822, 589);
            this.Name = "PetnaestoPitanje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Popularnost";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDrugoPitanje;
        private System.Windows.Forms.CheckBox cbJakoVazno;
        private System.Windows.Forms.CheckBox cbVazno;
        private System.Windows.Forms.CheckBox cbSvejedno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBrojPitanja;
        private System.Windows.Forms.Button btnSljedece;
        private System.Windows.Forms.Button btnOdustani;
    }
}