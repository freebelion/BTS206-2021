
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
            this.btnKalinMenuItem = new System.Windows.Forms.ToolStripButton();
            this.btnItalikMenuItem = new System.Windows.Forms.ToolStripButton();
            this.btnCizgiliMenuItem = new System.Windows.Forms.ToolStripButton();
            this.btnKucultMenuItem = new System.Windows.Forms.ToolStripButton();
            this.btnBuyutMenuItem = new System.Windows.Forms.ToolStripButton();
            this.tbEditor = new System.Windows.Forms.RichTextBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(826, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // btnDosyaMenuItem
            // 
            this.btnDosyaMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAcMenuItem,
            this.btnKaydetMenuItem});
            this.btnDosyaMenuItem.Name = "btnDosyaMenuItem";
            this.btnDosyaMenuItem.Size = new System.Drawing.Size(51, 19);
            this.btnDosyaMenuItem.Text = "Dosya";
            this.btnDosyaMenuItem.Click += new System.EventHandler(this.btnDosyaMenuItem_Click);
            // 
            // btnAcMenuItem
            // 
            this.btnAcMenuItem.Name = "btnAcMenuItem";
            this.btnAcMenuItem.Size = new System.Drawing.Size(110, 22);
            this.btnAcMenuItem.Text = "Aç";
            this.btnAcMenuItem.Click += new System.EventHandler(this.btnAcMenuItem_Click);
            // 
            // btnKaydetMenuItem
            // 
            this.btnKaydetMenuItem.Name = "btnKaydetMenuItem";
            this.btnKaydetMenuItem.Size = new System.Drawing.Size(110, 22);
            this.btnKaydetMenuItem.Text = "Kaydet";
            this.btnKaydetMenuItem.Click += new System.EventHandler(this.btnKaydetMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnKalinMenuItem,
            this.btnItalikMenuItem,
            this.btnCizgiliMenuItem,
            this.btnKucultMenuItem,
            this.btnBuyutMenuItem});
            this.toolStrip1.Location = new System.Drawing.Point(0, 25);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip1.Size = new System.Drawing.Size(826, 28);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnKalinMenuItem
            // 
            this.btnKalinMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnKalinMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKalinMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnKalinMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("btnKalinMenuItem.Image")));
            this.btnKalinMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnKalinMenuItem.Name = "btnKalinMenuItem";
            this.btnKalinMenuItem.Size = new System.Drawing.Size(24, 25);
            this.btnKalinMenuItem.Text = "K";
            this.btnKalinMenuItem.Click += new System.EventHandler(this.btnKalinMenuItem_Click);
            // 
            // btnItalikMenuItem
            // 
            this.btnItalikMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnItalikMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnItalikMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("btnItalikMenuItem.Image")));
            this.btnItalikMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnItalikMenuItem.Name = "btnItalikMenuItem";
            this.btnItalikMenuItem.Size = new System.Drawing.Size(23, 25);
            this.btnItalikMenuItem.Text = "I";
            this.btnItalikMenuItem.Click += new System.EventHandler(this.btnItalikMenuItem_Click);
            // 
            // btnCizgiliMenuItem
            // 
            this.btnCizgiliMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnCizgiliMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCizgiliMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("btnCizgiliMenuItem.Image")));
            this.btnCizgiliMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCizgiliMenuItem.Name = "btnCizgiliMenuItem";
            this.btnCizgiliMenuItem.Size = new System.Drawing.Size(24, 25);
            this.btnCizgiliMenuItem.Text = "A";
            this.btnCizgiliMenuItem.Click += new System.EventHandler(this.btnCizgiliMenuItem_Click);
            // 
            // btnKucultMenuItem
            // 
            this.btnKucultMenuItem.Name = "btnKucultMenuItem";
            this.btnKucultMenuItem.Size = new System.Drawing.Size(23, 25);
            // 
            // btnBuyutMenuItem
            // 
            this.btnBuyutMenuItem.Name = "btnBuyutMenuItem";
            this.btnBuyutMenuItem.Size = new System.Drawing.Size(23, 25);
            // 
            // tbEditor
            // 
            this.tbEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbEditor.Location = new System.Drawing.Point(0, 53);
            this.tbEditor.Name = "tbEditor";
            this.tbEditor.Size = new System.Drawing.Size(826, 413);
            this.tbEditor.TabIndex = 3;
            this.tbEditor.Text = "";
            this.tbEditor.TextChanged += new System.EventHandler(this.tbEditor_TextChanged);
            // 
            // trackBar1
            // 
            this.trackBar1.BackColor = System.Drawing.Color.White;
            this.trackBar1.Location = new System.Drawing.Point(114, 8);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Minimum = 10;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(233, 45);
            this.trackBar1.TabIndex = 4;
            this.trackBar1.TickFrequency = 5;
            this.trackBar1.Value = 10;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 466);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.tbEditor);
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
        private System.Windows.Forms.ToolStripButton btnKalinMenuItem;
        private System.Windows.Forms.ToolStripButton btnItalikMenuItem;
        private System.Windows.Forms.ToolStripButton btnCizgiliMenuItem;
        private System.Windows.Forms.RichTextBox tbEditor;
        private System.Windows.Forms.ToolStripButton btnKucultMenuItem;
        private System.Windows.Forms.ToolStripButton btnBuyutMenuItem;
        private System.Windows.Forms.TrackBar trackBar1;
    }
}

