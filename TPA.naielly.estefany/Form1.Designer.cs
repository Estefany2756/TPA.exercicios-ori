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
            this.tsmisair = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmilivraria = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiacrescimo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiprogramas,
            this.tsmisair});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiprogramas
            // 
            this.tsmiprogramas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmilivraria,
            this.tsmiacrescimo});
            this.tsmiprogramas.Name = "tsmiprogramas";
            this.tsmiprogramas.Size = new System.Drawing.Size(76, 20);
            this.tsmiprogramas.Text = "Programas";
            // 
            // tsmisair
            // 
            this.tsmisair.Name = "tsmisair";
            this.tsmisair.Size = new System.Drawing.Size(37, 20);
            this.tsmisair.Text = "sair";
            this.tsmisair.Click += new System.EventHandler(this.tsmisair_Click);
            // 
            // tsmilivraria
            // 
            this.tsmilivraria.Name = "tsmilivraria";
            this.tsmilivraria.Size = new System.Drawing.Size(180, 22);
            this.tsmilivraria.Text = "Livraria";
            this.tsmilivraria.Click += new System.EventHandler(this.tsmilivraria_Click);
            // 
            // tsmiacrescimo
            // 
            this.tsmiacrescimo.Name = "tsmiacrescimo";
            this.tsmiacrescimo.Size = new System.Drawing.Size(180, 22);
            this.tsmiacrescimo.Text = "Acréscimo";
            this.tsmiacrescimo.Click += new System.EventHandler(this.tsmiacrescimo_Click);
            // 
            // frmmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmmenu";
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
    }
}

