namespace Lab3otravez
{
    partial class Form2
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
            menuStrip1 = new MenuStrip();
            problema1ToolStripMenuItem = new ToolStripMenuItem();
            problema2ToolStripMenuItem = new ToolStripMenuItem();
            problema3ToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { problema1ToolStripMenuItem, problema2ToolStripMenuItem, problema3ToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // problema1ToolStripMenuItem
            // 
            problema1ToolStripMenuItem.Name = "problema1ToolStripMenuItem";
            problema1ToolStripMenuItem.Size = new Size(76, 20);
            problema1ToolStripMenuItem.Text = "Problema1";
            problema1ToolStripMenuItem.Click += problema1ToolStripMenuItem_Click;
            // 
            // problema2ToolStripMenuItem
            // 
            problema2ToolStripMenuItem.Name = "problema2ToolStripMenuItem";
            problema2ToolStripMenuItem.Size = new Size(76, 20);
            problema2ToolStripMenuItem.Text = "Problema2";
            problema2ToolStripMenuItem.Click += problema2ToolStripMenuItem_Click;
            // 
            // problema3ToolStripMenuItem
            // 
            problema3ToolStripMenuItem.Name = "problema3ToolStripMenuItem";
            problema3ToolStripMenuItem.Size = new Size(76, 20);
            problema3ToolStripMenuItem.Text = "Problema3";
            problema3ToolStripMenuItem.Click += problema3ToolStripMenuItem_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Form2";
            Text = "Form2";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem problema1ToolStripMenuItem;
        private ToolStripMenuItem problema2ToolStripMenuItem;
        private ToolStripMenuItem problema3ToolStripMenuItem;
    }
}