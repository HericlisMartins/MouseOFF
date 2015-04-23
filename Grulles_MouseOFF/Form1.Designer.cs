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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnDesativarAgora = new MetroFramework.Controls.MetroButton();
            this.btnAtivar = new MetroFramework.Controls.MetroButton();
            this.btnDesativar = new MetroFramework.Controls.MetroButton();
            this.lblContador = new MetroFramework.Controls.MetroTile();
            this.lblInterface = new System.Windows.Forms.Label();
            this.tmpTimer = new System.Windows.Forms.Timer(this.components);
            this.txtReceptor = new System.Windows.Forms.TextBox();
            this.lblContador.SuspendLayout();
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
            this.btnDesativar.Enabled = false;
            this.btnDesativar.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnDesativar.Location = new System.Drawing.Point(265, 138);
            this.btnDesativar.Name = "btnDesativar";
            this.btnDesativar.Size = new System.Drawing.Size(204, 47);
            this.btnDesativar.TabIndex = 3;
            this.btnDesativar.Text = "Cancelar";
            this.btnDesativar.UseSelectable = true;
            this.btnDesativar.Click += new System.EventHandler(this.btnDesativar_Click);
            // 
            // lblContador
            // 
            this.lblContador.ActiveControl = null;
            this.lblContador.Controls.Add(this.lblInterface);
            this.lblContador.Location = new System.Drawing.Point(23, 85);
            this.lblContador.Name = "lblContador";
            this.lblContador.Size = new System.Drawing.Size(236, 47);
            this.lblContador.TabIndex = 4;
            this.lblContador.UseSelectable = true;
            // 
            // lblInterface
            // 
            this.lblInterface.AutoSize = true;
            this.lblInterface.BackColor = System.Drawing.Color.Transparent;
            this.lblInterface.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInterface.ForeColor = System.Drawing.Color.White;
            this.lblInterface.Location = new System.Drawing.Point(100, 6);
            this.lblInterface.Name = "lblInterface";
            this.lblInterface.Size = new System.Drawing.Size(30, 36);
            this.lblInterface.TabIndex = 0;
            this.lblInterface.Text = "0";
            this.lblInterface.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tmpTimer
            // 
            this.tmpTimer.Interval = 1000;
            this.tmpTimer.Tick += new System.EventHandler(this.tmpTimer_Tick);
            // 
            // txtReceptor
            // 
            this.txtReceptor.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReceptor.Location = new System.Drawing.Point(24, 139);
            this.txtReceptor.Multiline = true;
            this.txtReceptor.Name = "txtReceptor";
            this.txtReceptor.Size = new System.Drawing.Size(235, 45);
            this.txtReceptor.TabIndex = 5;
            this.txtReceptor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtReceptor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtReceptor_KeyPress);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 295);
            this.Controls.Add(this.txtReceptor);
            this.Controls.Add(this.lblContador);
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
            this.lblContador.ResumeLayout(false);
            this.lblContador.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnDesativarAgora;
        private MetroFramework.Controls.MetroButton btnAtivar;
        private MetroFramework.Controls.MetroButton btnDesativar;
        private MetroFramework.Controls.MetroTile lblContador;
        private System.Windows.Forms.Timer tmpTimer;
        private System.Windows.Forms.Label lblInterface;
        private System.Windows.Forms.TextBox txtReceptor;


    }
}

