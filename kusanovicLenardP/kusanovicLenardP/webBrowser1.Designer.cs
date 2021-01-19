
namespace kusanovicLenardP
{
    partial class webBrowser1
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
            this.btnIspis = new System.Windows.Forms.Button();
            this.btnWebmail = new System.Windows.Forms.Button();
            this.btnGmail = new System.Windows.Forms.Button();
            this.ButtonGo = new System.Windows.Forms.Button();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.lblAdresa = new System.Windows.Forms.Label();
            this.btnNaprijed = new System.Windows.Forms.Button();
            this.btnNatrag = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnIspis
            // 
            this.btnIspis.Location = new System.Drawing.Point(989, 9);
            this.btnIspis.Name = "btnIspis";
            this.btnIspis.Size = new System.Drawing.Size(75, 23);
            this.btnIspis.TabIndex = 15;
            this.btnIspis.Text = "Ispis";
            this.btnIspis.UseVisualStyleBackColor = true;
            // 
            // btnWebmail
            // 
            this.btnWebmail.Location = new System.Drawing.Point(908, 9);
            this.btnWebmail.Name = "btnWebmail";
            this.btnWebmail.Size = new System.Drawing.Size(75, 23);
            this.btnWebmail.TabIndex = 14;
            this.btnWebmail.Text = "Webmail";
            this.btnWebmail.UseVisualStyleBackColor = true;
            // 
            // btnGmail
            // 
            this.btnGmail.Location = new System.Drawing.Point(827, 10);
            this.btnGmail.Name = "btnGmail";
            this.btnGmail.Size = new System.Drawing.Size(75, 23);
            this.btnGmail.TabIndex = 13;
            this.btnGmail.Text = "Gmail";
            this.btnGmail.UseVisualStyleBackColor = true;
            // 
            // ButtonGo
            // 
            this.ButtonGo.Location = new System.Drawing.Point(630, 9);
            this.ButtonGo.Name = "ButtonGo";
            this.ButtonGo.Size = new System.Drawing.Size(75, 23);
            this.ButtonGo.TabIndex = 12;
            this.ButtonGo.Text = "Idi";
            this.ButtonGo.UseVisualStyleBackColor = true;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(241, 12);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(383, 20);
            this.textBoxAddress.TabIndex = 11;
            // 
            // lblAdresa
            // 
            this.lblAdresa.AutoSize = true;
            this.lblAdresa.Location = new System.Drawing.Point(200, 15);
            this.lblAdresa.Name = "lblAdresa";
            this.lblAdresa.Size = new System.Drawing.Size(43, 13);
            this.lblAdresa.TabIndex = 10;
            this.lblAdresa.Text = "Adresa:";
            // 
            // btnNaprijed
            // 
            this.btnNaprijed.Location = new System.Drawing.Point(103, 10);
            this.btnNaprijed.Name = "btnNaprijed";
            this.btnNaprijed.Size = new System.Drawing.Size(75, 23);
            this.btnNaprijed.TabIndex = 9;
            this.btnNaprijed.Text = "Naprijed";
            this.btnNaprijed.UseVisualStyleBackColor = true;
            // 
            // btnNatrag
            // 
            this.btnNatrag.Location = new System.Drawing.Point(4, 10);
            this.btnNatrag.Name = "btnNatrag";
            this.btnNatrag.Size = new System.Drawing.Size(75, 23);
            this.btnNatrag.TabIndex = 8;
            this.btnNatrag.Text = "Natrag";
            this.btnNatrag.UseVisualStyleBackColor = true;
            // 
            // webBrowser1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 567);
            this.Controls.Add(this.btnIspis);
            this.Controls.Add(this.btnWebmail);
            this.Controls.Add(this.btnGmail);
            this.Controls.Add(this.ButtonGo);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.lblAdresa);
            this.Controls.Add(this.btnNaprijed);
            this.Controls.Add(this.btnNatrag);
            this.Name = "webBrowser1";
            this.Text = "webBrowser1";
            this.Load += new System.EventHandler(this.webBrowser1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIspis;
        private System.Windows.Forms.Button btnWebmail;
        private System.Windows.Forms.Button btnGmail;
        private System.Windows.Forms.Button ButtonGo;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Label lblAdresa;
        private System.Windows.Forms.Button btnNaprijed;
        private System.Windows.Forms.Button btnNatrag;
    }
}