namespace ApplicationM2L1
{
    partial class FormTresoriers
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
            this.formulaireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Nom = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNomTrésorier = new System.Windows.Forms.TextBox();
            this.textBoxPrénomTrésorier = new System.Windows.Forms.TextBox();
            this.Accepter = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formulaireToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // formulaireToolStripMenuItem
            // 
            this.formulaireToolStripMenuItem.Name = "formulaireToolStripMenuItem";
            this.formulaireToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.formulaireToolStripMenuItem.Text = "Formulaire";
            // 
            // Nom
            // 
            this.Nom.AutoSize = true;
            this.Nom.Location = new System.Drawing.Point(190, 109);
            this.Nom.Name = "Nom";
            this.Nom.Size = new System.Drawing.Size(84, 13);
            this.Nom.TabIndex = 1;
            this.Nom.Text = "Nom du trésorier";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(190, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Prénom du trésorier";
            // 
            // textBoxNomTrésorier
            // 
            this.textBoxNomTrésorier.Location = new System.Drawing.Point(316, 106);
            this.textBoxNomTrésorier.Name = "textBoxNomTrésorier";
            this.textBoxNomTrésorier.Size = new System.Drawing.Size(100, 20);
            this.textBoxNomTrésorier.TabIndex = 3;
            // 
            // textBoxPrénomTrésorier
            // 
            this.textBoxPrénomTrésorier.Location = new System.Drawing.Point(316, 155);
            this.textBoxPrénomTrésorier.Name = "textBoxPrénomTrésorier";
            this.textBoxPrénomTrésorier.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrénomTrésorier.TabIndex = 4;
            // 
            // Accepter
            // 
            this.Accepter.Location = new System.Drawing.Point(316, 227);
            this.Accepter.Name = "Accepter";
            this.Accepter.Size = new System.Drawing.Size(75, 23);
            this.Accepter.TabIndex = 5;
            this.Accepter.Text = "Accepter";
            this.Accepter.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(450, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Refuser";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(252, 316);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(232, 96);
            this.textBox1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(290, 291);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Commentaires";
            // 
            // FormTresoriers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Accepter);
            this.Controls.Add(this.textBoxPrénomTrésorier);
            this.Controls.Add(this.textBoxNomTrésorier);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Nom);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormTresoriers";
            this.Text = "FormTresoriers";
            this.Load += new System.EventHandler(this.FormTresoriers_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem formulaireToolStripMenuItem;
        private System.Windows.Forms.Label Nom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNomTrésorier;
        private System.Windows.Forms.TextBox textBoxPrénomTrésorier;
        private System.Windows.Forms.Button Accepter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}