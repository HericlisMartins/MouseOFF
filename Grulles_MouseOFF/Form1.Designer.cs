namespace Grulles_MouseOFF
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnDesativarAgora = new MetroFramework.Controls.MetroButton();
            this.btnAtivar = new MetroFramework.Controls.MetroButton();
            this.btnDesativar = new MetroFramework.Controls.MetroButton();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(23, 16);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(98, 25);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Mouse OFF";
            // 
            // btnDesativarAgora
            // 
            this.btnDesativarAgora.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDesativarAgora.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnDesativarAgora.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDesativarAgora.Location = new System.Drawing.Point(23, 222);
            this.btnDesativarAgora.Name = "btnDesativarAgora";
            this.btnDesativarAgora.Size = new System.Drawing.Size(446, 50);
            this.btnDesativarAgora.Style = MetroFramework.MetroColorStyle.Yellow;
            this.btnDesativarAgora.TabIndex = 1;
            this.btnDesativarAgora.Text = "Desativar Agora";
            this.btnDesativarAgora.UseSelectable = true;
            this.btnDesativarAgora.Click += new System.EventHandler(this.btnDesativarAgora_Click);
            // 
            // btnAtivar
            // 
            this.btnAtivar.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnAtivar.Location = new System.Drawing.Point(265, 85);
            this.btnAtivar.Name = "btnAtivar";
            this.btnAtivar.Size = new System.Drawing.Size(204, 47);
            this.btnAtivar.TabIndex = 2;
            this.btnAtivar.Text = "Ativar";
            this.btnAtivar.UseSelectable = true;
            this.btnAtivar.Click += new System.EventHandler(this.btnAtivar_Click);
            // 
            // btnDesativar
            // 
            this.btnDesativar.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnDesativar.Location = new System.Drawing.Point(265, 138);
            this.btnDesativar.Name = "btnDesativar";
            this.btnDesativar.Size = new System.Drawing.Size(204, 47);
            this.btnDesativar.TabIndex = 3;
            this.btnDesativar.Text = "Desativar";
            this.btnDesativar.UseSelectable = true;
            this.btnDesativar.Click += new System.EventHandler(this.btnDesativar_Click);
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(23, 85);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(236, 100);
            this.metroTile1.TabIndex = 4;
            this.metroTile1.UseSelectable = true;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 295);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.btnDesativar);
            this.Controls.Add(this.btnAtivar);
            this.Controls.Add(this.btnDesativarAgora);
            this.Controls.Add(this.metroLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.Resizable = false;
            this.Text = "                                           ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnDesativarAgora;
        private MetroFramework.Controls.MetroButton btnAtivar;
        private MetroFramework.Controls.MetroButton btnDesativar;
        private MetroFramework.Controls.MetroTile metroTile1;


    }
}

