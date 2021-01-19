
namespace kusanovicLenardP
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
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.btnNatrag = new System.Windows.Forms.Button();
            this.btnNaprijed = new System.Windows.Forms.Button();
            this.lblAdresa = new System.Windows.Forms.Label();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.ButtonGo = new System.Windows.Forms.Button();
            this.btnGmail = new System.Windows.Forms.Button();
            this.btnWebmail = new System.Windows.Forms.Button();
            this.btnIspis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNatrag
            // 
            this.btnNatrag.Location = new System.Drawing.Point(12, 12);
            this.btnNatrag.Name = "btnNatrag";
            this.btnNatrag.Size = new System.Drawing.Size(75, 23);
            this.btnNatrag.TabIndex = 0;
            this.btnNatrag.Text = "Natrag";
            this.btnNatrag.UseVisualStyleBackColor = true;
            this.btnNatrag.Click += new System.EventHandler(this.btnNatrag_Click);
            // 
            // btnNaprijed
            // 
            this.btnNaprijed.Location = new System.Drawing.Point(111, 12);
            this.btnNaprijed.Name = "btnNaprijed";
            this.btnNaprijed.Size = new System.Drawing.Size(75, 23);
            this.btnNaprijed.TabIndex = 1;
            this.btnNaprijed.Text = "Naprijed";
            this.btnNaprijed.UseVisualStyleBackColor = true;
            this.btnNaprijed.Click += new System.EventHandler(this.btnNaprijed_Click);
            // 
            // lblAdresa
            // 
            this.lblAdresa.AutoSize = true;
            this.lblAdresa.Location = new System.Drawing.Point(208, 17);
            this.lblAdresa.Name = "lblAdresa";
            this.lblAdresa.Size = new System.Drawing.Size(43, 13);
            this.lblAdresa.TabIndex = 2;
            this.lblAdresa.Text = "Adresa:";
            this.lblAdresa.Click += new System.EventHandler(this.lblAdresa_Click);
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(249, 14);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(383, 20);
            this.textBoxAddress.TabIndex = 3;
            this.textBoxAddress.TextChanged += new System.EventHandler(this.textBoxAddress_TextChanged);
            // 
            // ButtonGo
            // 
            this.ButtonGo.Location = new System.Drawing.Point(638, 11);
            this.ButtonGo.Name = "ButtonGo";
            this.ButtonGo.Size = new System.Drawing.Size(75, 23);
            this.ButtonGo.TabIndex = 4;
            this.ButtonGo.Text = "Idi";
            this.ButtonGo.UseVisualStyleBackColor = true;
            this.ButtonGo.Click += new System.EventHandler(this.ButtonGo_Click);
            // 
            // btnGmail
            // 
            this.btnGmail.Location = new System.Drawing.Point(835, 12);
            this.btnGmail.Name = "btnGmail";
            this.btnGmail.Size = new System.Drawing.Size(75, 23);
            this.btnGmail.TabIndex = 5;
            this.btnGmail.Text = "Gmail";
            this.btnGmail.UseVisualStyleBackColor = true;
            this.btnGmail.Click += new System.EventHandler(this.btnGmail_Click);
            // 
            // btnWebmail
            // 
            this.btnWebmail.Location = new System.Drawing.Point(916, 11);
            this.btnWebmail.Name = "btnWebmail";
            this.btnWebmail.Size = new System.Drawing.Size(75, 23);
            this.btnWebmail.TabIndex = 6;
            this.btnWebmail.Text = "Webmail";
            this.btnWebmail.UseVisualStyleBackColor = true;
            this.btnWebmail.Click += new System.EventHandler(this.btnWebmail_Click);
            // 
            // btnIspis
            // 
            this.btnIspis.Location = new System.Drawing.Point(997, 11);
            this.btnIspis.Name = "btnIspis";
            this.btnIspis.Size = new System.Drawing.Size(75, 23);
            this.btnIspis.TabIndex = 7;
            this.btnIspis.Text = "Ispis";
            this.btnIspis.UseVisualStyleBackColor = true;
            this.btnIspis.Click += new System.EventHandler(this.btnIspis_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 575);
            this.Controls.Add(this.btnIspis);
            this.Controls.Add(this.btnWebmail);
            this.Controls.Add(this.btnGmail);
            this.Controls.Add(this.ButtonGo);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.lblAdresa);
            this.Controls.Add(this.btnNaprijed);
            this.Controls.Add(this.btnNatrag);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.Button btnNatrag;
        private System.Windows.Forms.Button btnNaprijed;
        private System.Windows.Forms.Label lblAdresa;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Button ButtonGo;
        private System.Windows.Forms.Button btnGmail;
        private System.Windows.Forms.Button btnWebmail;
        private System.Windows.Forms.Button btnIspis;
    }
}

