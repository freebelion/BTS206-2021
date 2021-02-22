
namespace Ders5_AcilirListeKutusu
{
   partial class TarayiciForm
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
         this.cbKlasorler = new System.Windows.Forms.ComboBox();
         this.lbDosyalar = new System.Windows.Forms.ListBox();
         this.SuspendLayout();
         // 
         // cbKlasorler
         // 
         this.cbKlasorler.BackColor = System.Drawing.Color.LightGoldenrodYellow;
         this.cbKlasorler.Dock = System.Windows.Forms.DockStyle.Top;
         this.cbKlasorler.FormattingEnabled = true;
         this.cbKlasorler.Location = new System.Drawing.Point(0, 0);
         this.cbKlasorler.Name = "cbKlasorler";
         this.cbKlasorler.Size = new System.Drawing.Size(266, 28);
         this.cbKlasorler.TabIndex = 0;
         this.cbKlasorler.SelectedIndexChanged += new System.EventHandler(this.cbKlasorler_SelectedIndexChanged);
         // 
         // lbDosyalar
         // 
         this.lbDosyalar.BackColor = System.Drawing.Color.Goldenrod;
         this.lbDosyalar.Dock = System.Windows.Forms.DockStyle.Fill;
         this.lbDosyalar.FormattingEnabled = true;
         this.lbDosyalar.ItemHeight = 20;
         this.lbDosyalar.Location = new System.Drawing.Point(0, 28);
         this.lbDosyalar.Name = "lbDosyalar";
         this.lbDosyalar.Size = new System.Drawing.Size(266, 297);
         this.lbDosyalar.TabIndex = 1;
         // 
         // TarayiciForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(266, 325);
         this.Controls.Add(this.lbDosyalar);
         this.Controls.Add(this.cbKlasorler);
         this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
         this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.Name = "TarayiciForm";
         this.Text = "Küçük Dosya Tarayıcı";
         this.Load += new System.EventHandler(this.TarayiciForm_Load);
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.ComboBox cbKlasorler;
      private System.Windows.Forms.ListBox lbDosyalar;
   }
}

