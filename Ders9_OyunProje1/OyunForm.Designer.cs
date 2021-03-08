
namespace Ders9_OyunProje1
{
   partial class OyunForm
   {
      /// <summary>
      ///Gerekli tasarımcı değişkeni.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      ///Kullanılan tüm kaynakları temizleyin.
      /// </summary>
      ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer üretilen kod

      /// <summary>
      /// Tasarımcı desteği için gerekli metot - bu metodun 
      ///içeriğini kod düzenleyici ile değiştirmeyin.
      /// </summary>
      private void InitializeComponent()
      {
         this.components = new System.ComponentModel.Container();
         this.KontrolSeriti = new System.Windows.Forms.ToolStrip();
         this.btnBaslat = new System.Windows.Forms.ToolStripButton();
         this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
         this.tbZamanAralik = new System.Windows.Forms.ToolStripTextBox();
         this.Zamanlayici = new System.Windows.Forms.Timer(this.components);
         this.OyunPanel = new System.Windows.Forms.Panel();
         this.KontrolSeriti.SuspendLayout();
         this.SuspendLayout();
         // 
         // KontrolSeriti
         // 
         this.KontrolSeriti.BackColor = System.Drawing.Color.Peru;
         this.KontrolSeriti.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnBaslat,
            this.toolStripLabel1,
            this.tbZamanAralik});
         this.KontrolSeriti.Location = new System.Drawing.Point(0, 0);
         this.KontrolSeriti.Name = "KontrolSeriti";
         this.KontrolSeriti.Size = new System.Drawing.Size(800, 25);
         this.KontrolSeriti.TabIndex = 0;
         this.KontrolSeriti.Text = "toolStrip1";
         // 
         // btnBaslat
         // 
         this.btnBaslat.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.btnBaslat.Image = global::Ders9_OyunProje1.Properties.Resources.imgBaslat;
         this.btnBaslat.ImageTransparentColor = System.Drawing.Color.Magenta;
         this.btnBaslat.Name = "btnBaslat";
         this.btnBaslat.Size = new System.Drawing.Size(23, 22);
         this.btnBaslat.Text = "Başlat";
         this.btnBaslat.Click += new System.EventHandler(this.btnBaslat_Click);
         // 
         // toolStripLabel1
         // 
         this.toolStripLabel1.Name = "toolStripLabel1";
         this.toolStripLabel1.Size = new System.Drawing.Size(84, 22);
         this.toolStripLabel1.Text = "Zaman Aralığı ";
         // 
         // tbZamanAralik
         // 
         this.tbZamanAralik.Font = new System.Drawing.Font("Segoe UI", 9F);
         this.tbZamanAralik.Name = "tbZamanAralik";
         this.tbZamanAralik.Size = new System.Drawing.Size(100, 25);
         this.tbZamanAralik.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbZamanAralik_KeyDown);
         // 
         // Zamanlayici
         // 
         this.Zamanlayici.Interval = 500;
         this.Zamanlayici.Tick += new System.EventHandler(this.Zamanlayici_Tick);
         // 
         // OyunPanel
         // 
         this.OyunPanel.BackColor = System.Drawing.Color.MediumBlue;
         this.OyunPanel.Dock = System.Windows.Forms.DockStyle.Fill;
         this.OyunPanel.Location = new System.Drawing.Point(0, 25);
         this.OyunPanel.Name = "OyunPanel";
         this.OyunPanel.Size = new System.Drawing.Size(800, 425);
         this.OyunPanel.TabIndex = 1;
         // 
         // OyunForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(800, 450);
         this.Controls.Add(this.OyunPanel);
         this.Controls.Add(this.KontrolSeriti);
         this.Name = "OyunForm";
         this.Text = "Hedef Vurma Oyunu";
         this.Load += new System.EventHandler(this.OyunForm_Load);
         this.KontrolSeriti.ResumeLayout(false);
         this.KontrolSeriti.PerformLayout();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.ToolStrip KontrolSeriti;
      private System.Windows.Forms.ToolStripButton btnBaslat;
      private System.Windows.Forms.Timer Zamanlayici;
      private System.Windows.Forms.Panel OyunPanel;
      private System.Windows.Forms.ToolStripLabel toolStripLabel1;
      private System.Windows.Forms.ToolStripTextBox tbZamanAralik;
   }
}

