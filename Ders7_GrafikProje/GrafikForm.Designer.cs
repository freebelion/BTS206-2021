
namespace Ders7_GrafikProje
{
   partial class GrafikForm
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
         this.UstPanel = new System.Windows.Forms.Panel();
         this.rdSurekliCizgiler = new System.Windows.Forms.RadioButton();
         this.rdKirikCizgi = new System.Windows.Forms.RadioButton();
         this.CizimPaneli = new System.Windows.Forms.Panel();
         this.UstPanel.SuspendLayout();
         this.SuspendLayout();
         // 
         // UstPanel
         // 
         this.UstPanel.BackColor = System.Drawing.Color.Gray;
         this.UstPanel.Controls.Add(this.rdSurekliCizgiler);
         this.UstPanel.Controls.Add(this.rdKirikCizgi);
         this.UstPanel.Dock = System.Windows.Forms.DockStyle.Top;
         this.UstPanel.Location = new System.Drawing.Point(0, 0);
         this.UstPanel.Name = "UstPanel";
         this.UstPanel.Size = new System.Drawing.Size(800, 70);
         this.UstPanel.TabIndex = 0;
         // 
         // rdSurekliCizgiler
         // 
         this.rdSurekliCizgiler.AutoSize = true;
         this.rdSurekliCizgiler.Location = new System.Drawing.Point(12, 35);
         this.rdSurekliCizgiler.Name = "rdSurekliCizgiler";
         this.rdSurekliCizgiler.Size = new System.Drawing.Size(93, 17);
         this.rdSurekliCizgiler.TabIndex = 1;
         this.rdSurekliCizgiler.TabStop = true;
         this.rdSurekliCizgiler.Text = "Sürekli Çizgiler";
         this.rdSurekliCizgiler.UseVisualStyleBackColor = true;
         this.rdSurekliCizgiler.CheckedChanged += new System.EventHandler(this.rdSurekliCizgiler_CheckedChanged);
         // 
         // rdKirikCizgi
         // 
         this.rdKirikCizgi.AutoSize = true;
         this.rdKirikCizgi.Location = new System.Drawing.Point(12, 12);
         this.rdKirikCizgi.Name = "rdKirikCizgi";
         this.rdKirikCizgi.Size = new System.Drawing.Size(81, 17);
         this.rdKirikCizgi.TabIndex = 0;
         this.rdKirikCizgi.TabStop = true;
         this.rdKirikCizgi.Text = "Kırık Çizgiler";
         this.rdKirikCizgi.UseVisualStyleBackColor = true;
         this.rdKirikCizgi.CheckedChanged += new System.EventHandler(this.rdKirikCizgi_CheckedChanged);
         // 
         // CizimPaneli
         // 
         this.CizimPaneli.BackColor = System.Drawing.Color.BlanchedAlmond;
         this.CizimPaneli.Dock = System.Windows.Forms.DockStyle.Fill;
         this.CizimPaneli.Location = new System.Drawing.Point(0, 70);
         this.CizimPaneli.Name = "CizimPaneli";
         this.CizimPaneli.Size = new System.Drawing.Size(800, 380);
         this.CizimPaneli.TabIndex = 1;
         this.CizimPaneli.Paint += new System.Windows.Forms.PaintEventHandler(this.CizimPaneli_Paint);
         this.CizimPaneli.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CizimPaneli_MouseDown);
         this.CizimPaneli.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CizimPaneli_MouseMove);
         this.CizimPaneli.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CizimPaneli_MouseUp);
         // 
         // GrafikForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(800, 450);
         this.Controls.Add(this.CizimPaneli);
         this.Controls.Add(this.UstPanel);
         this.Name = "GrafikForm";
         this.Text = "Grafik Form";
         this.Load += new System.EventHandler(this.GrafikForm_Load);
         this.UstPanel.ResumeLayout(false);
         this.UstPanel.PerformLayout();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.Panel UstPanel;
      private System.Windows.Forms.RadioButton rdSurekliCizgiler;
      private System.Windows.Forms.RadioButton rdKirikCizgi;
      private System.Windows.Forms.Panel CizimPaneli;
   }
}

