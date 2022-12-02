namespace geometrietrigonometrieproiectcomplet
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
            this.canvas = new graphiccontrol.UserControl1();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drawToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.punctToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unghiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.triunghiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patrulaterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cercToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // canvas
            // 
            this.canvas.BackColor = System.Drawing.Color.White;
            this.canvas.Location = new System.Drawing.Point(31, 68);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(534, 404);
            this.canvas.TabIndex = 0;
            this.canvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseDown);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 478);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(614, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.drawToolStripMenuItem,
            this.formatToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.windowToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(614, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // formatToolStripMenuItem
            // 
            this.formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            this.formatToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.formatToolStripMenuItem.Text = "Format";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // windowToolStripMenuItem
            // 
            this.windowToolStripMenuItem.Name = "windowToolStripMenuItem";
            this.windowToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.windowToolStripMenuItem.Text = "Window";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // drawToolStripMenuItem
            // 
            this.drawToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.punctToolStripMenuItem,
            this.linieToolStripMenuItem,
            this.unghiToolStripMenuItem,
            this.triunghiToolStripMenuItem,
            this.patrulaterToolStripMenuItem,
            this.cercToolStripMenuItem});
            this.drawToolStripMenuItem.Name = "drawToolStripMenuItem";
            this.drawToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.drawToolStripMenuItem.Text = "Draw";
            // 
            // punctToolStripMenuItem
            // 
            this.punctToolStripMenuItem.Name = "punctToolStripMenuItem";
            this.punctToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.punctToolStripMenuItem.Text = "Punct";
            this.punctToolStripMenuItem.Click += new System.EventHandler(this.punctToolStripMenuItem_Click);
            // 
            // linieToolStripMenuItem
            // 
            this.linieToolStripMenuItem.Name = "linieToolStripMenuItem";
            this.linieToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.linieToolStripMenuItem.Text = "Linie";
            this.linieToolStripMenuItem.Click += new System.EventHandler(this.linieToolStripMenuItem_Click);
            // 
            // unghiToolStripMenuItem
            // 
            this.unghiToolStripMenuItem.Name = "unghiToolStripMenuItem";
            this.unghiToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.unghiToolStripMenuItem.Text = "Unghi";
            this.unghiToolStripMenuItem.Click += new System.EventHandler(this.unghiToolStripMenuItem_Click);
            // 
            // triunghiToolStripMenuItem
            // 
            this.triunghiToolStripMenuItem.Name = "triunghiToolStripMenuItem";
            this.triunghiToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.triunghiToolStripMenuItem.Text = "Triunghi";
            this.triunghiToolStripMenuItem.Click += new System.EventHandler(this.triunghiToolStripMenuItem_Click);
            // 
            // patrulaterToolStripMenuItem
            // 
            this.patrulaterToolStripMenuItem.Name = "patrulaterToolStripMenuItem";
            this.patrulaterToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.patrulaterToolStripMenuItem.Text = "Patrulater";
            this.patrulaterToolStripMenuItem.Click += new System.EventHandler(this.patrulaterToolStripMenuItem_Click);
            // 
            // cercToolStripMenuItem
            // 
            this.cercToolStripMenuItem.Name = "cercToolStripMenuItem";
            this.cercToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cercToolStripMenuItem.Text = "Cerc";
            this.cercToolStripMenuItem.Click += new System.EventHandler(this.cercToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 500);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.canvas);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Drawings";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private graphiccontrol.UserControl1 canvas;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem drawToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem punctToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem linieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unghiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem triunghiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patrulaterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cercToolStripMenuItem;
    }
}

