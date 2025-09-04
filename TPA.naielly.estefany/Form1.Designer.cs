namespace TPA.naielly.estefany
{
    partial class frmmenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiprogramas = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmilivraria = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiacrescimo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmisair = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmilanchonete = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiimc = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiprogramas,
            this.tsmisair});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1067, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiprogramas
            // 
            this.tsmiprogramas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmilivraria,
            this.tsmiacrescimo,
            this.tsmilanchonete,
            this.tsmiimc});
            this.tsmiprogramas.Name = "tsmiprogramas";
            this.tsmiprogramas.Size = new System.Drawing.Size(94, 24);
            this.tsmiprogramas.Text = "Programas";
            // 
            // tsmilivraria
            // 
            this.tsmilivraria.Name = "tsmilivraria";
            this.tsmilivraria.Size = new System.Drawing.Size(224, 26);
            this.tsmilivraria.Text = "Livraria";
            this.tsmilivraria.Click += new System.EventHandler(this.tsmilivraria_Click);
            // 
            // tsmiacrescimo
            // 
            this.tsmiacrescimo.Name = "tsmiacrescimo";
            this.tsmiacrescimo.Size = new System.Drawing.Size(224, 26);
            this.tsmiacrescimo.Text = "Acréscimo";
            this.tsmiacrescimo.Click += new System.EventHandler(this.tsmiacrescimo_Click);
            // 
            // tsmisair
            // 
            this.tsmisair.Name = "tsmisair";
            this.tsmisair.Size = new System.Drawing.Size(46, 24);
            this.tsmisair.Text = "sair";
            this.tsmisair.Click += new System.EventHandler(this.tsmisair_Click);
            // 
            // tsmilanchonete
            // 
            this.tsmilanchonete.Name = "tsmilanchonete";
            this.tsmilanchonete.Size = new System.Drawing.Size(224, 26);
            this.tsmilanchonete.Text = "Lanchonete";
            this.tsmilanchonete.Click += new System.EventHandler(this.tsmilanchonete_Click);
            // 
            // tsmiimc
            // 
            this.tsmiimc.Name = "tsmiimc";
            this.tsmiimc.Size = new System.Drawing.Size(224, 26);
            this.tsmiimc.Text = "IMC";
            this.tsmiimc.Click += new System.EventHandler(this.tsmiimc_Click);
            // 
            // frmmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmmenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiprogramas;
        private System.Windows.Forms.ToolStripMenuItem tsmilivraria;
        private System.Windows.Forms.ToolStripMenuItem tsmisair;
        private System.Windows.Forms.ToolStripMenuItem tsmiacrescimo;
        private System.Windows.Forms.ToolStripMenuItem tsmilanchonete;
        private System.Windows.Forms.ToolStripMenuItem tsmiimc;
    }
}

