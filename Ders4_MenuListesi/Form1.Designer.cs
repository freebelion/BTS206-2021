
namespace Ders4_MenuListesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnDosyaMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAcMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnKaydetMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnKalinYazi = new System.Windows.Forms.ToolStripButton();
            this.btnItalikYazi = new System.Windows.Forms.ToolStripButton();
            this.btnCizgiliYazi = new System.Windows.Forms.ToolStripButton();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.tbEditor = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnDosyaMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(825, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnDosyaMenuItem
            // 
            this.btnDosyaMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAcMenuItem,
            this.btnKaydetMenuItem});
            this.btnDosyaMenuItem.Name = "btnDosyaMenuItem";
            this.btnDosyaMenuItem.Size = new System.Drawing.Size(51, 20);
            this.btnDosyaMenuItem.Text = "Dosya";
            this.btnDosyaMenuItem.Click += new System.EventHandler(this.btnDosyaMenuItem_Click);
            // 
            // btnAcMenuItem
            // 
            this.btnAcMenuItem.Name = "btnAcMenuItem";
            this.btnAcMenuItem.Size = new System.Drawing.Size(180, 22);
            this.btnAcMenuItem.Text = "Aç";
            this.btnAcMenuItem.Click += new System.EventHandler(this.btnAcMenuItem_Click);
            // 
            // btnKaydetMenuItem
            // 
            this.btnKaydetMenuItem.Name = "btnKaydetMenuItem";
            this.btnKaydetMenuItem.Size = new System.Drawing.Size(180, 22);
            this.btnKaydetMenuItem.Text = "Kaydet";
            this.btnKaydetMenuItem.Click += new System.EventHandler(this.btnKaydetMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Pink;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnKalinYazi,
            this.btnItalikYazi,
            this.btnCizgiliYazi});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(825, 28);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnKalinYazi
            // 
            this.btnKalinYazi.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnKalinYazi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKalinYazi.Image = ((System.Drawing.Image)(resources.GetObject("btnKalinYazi.Image")));
            this.btnKalinYazi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnKalinYazi.Name = "btnKalinYazi";
            this.btnKalinYazi.Size = new System.Drawing.Size(24, 25);
            this.btnKalinYazi.Text = "K";
            this.btnKalinYazi.Click += new System.EventHandler(this.btnKalinYazi_Click);
            // 
            // btnItalikYazi
            // 
            this.btnItalikYazi.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnItalikYazi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnItalikYazi.Image = ((System.Drawing.Image)(resources.GetObject("btnItalikYazi.Image")));
            this.btnItalikYazi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnItalikYazi.Name = "btnItalikYazi";
            this.btnItalikYazi.Size = new System.Drawing.Size(23, 25);
            this.btnItalikYazi.Text = "I";
            this.btnItalikYazi.Click += new System.EventHandler(this.btnItalikYazi_Click);
            // 
            // btnCizgiliYazi
            // 
            this.btnCizgiliYazi.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnCizgiliYazi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCizgiliYazi.Image = ((System.Drawing.Image)(resources.GetObject("btnCizgiliYazi.Image")));
            this.btnCizgiliYazi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCizgiliYazi.Name = "btnCizgiliYazi";
            this.btnCizgiliYazi.Size = new System.Drawing.Size(24, 25);
            this.btnCizgiliYazi.Text = "A";
            this.btnCizgiliYazi.Click += new System.EventHandler(this.btnCizgiliYazi_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(153, 7);
            this.trackBar1.Maximum = 50;
            this.trackBar1.Minimum = 10;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(259, 45);
            this.trackBar1.TabIndex = 3;
            this.trackBar1.Value = 10;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // tbEditor
            // 
            this.tbEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbEditor.Location = new System.Drawing.Point(0, 52);
            this.tbEditor.Name = "tbEditor";
            this.tbEditor.Size = new System.Drawing.Size(825, 427);
            this.tbEditor.TabIndex = 4;
            this.tbEditor.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 479);
            this.Controls.Add(this.tbEditor);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnDosyaMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnAcMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnKaydetMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnKalinYazi;
        private System.Windows.Forms.ToolStripButton btnItalikYazi;
        private System.Windows.Forms.ToolStripButton btnCizgiliYazi;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.RichTextBox tbEditor;
    }
}

