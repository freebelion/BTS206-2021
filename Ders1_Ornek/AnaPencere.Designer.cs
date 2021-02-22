
namespace Ders1_Ornek
{
   partial class AnaPencere
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
            this.tbMetin = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.lbListe = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbMetin
            // 
            this.tbMetin.Location = new System.Drawing.Point(4, 5);
            this.tbMetin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbMetin.Name = "tbMetin";
            this.tbMetin.Size = new System.Drawing.Size(179, 26);
            this.tbMetin.TabIndex = 0;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(191, 5);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(60, 26);
            this.btnEkle.TabIndex = 1;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // lbListe
            // 
            this.lbListe.FormattingEnabled = true;
            this.lbListe.ItemHeight = 20;
            this.lbListe.Location = new System.Drawing.Point(4, 40);
            this.lbListe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbListe.Name = "lbListe";
            this.lbListe.Size = new System.Drawing.Size(247, 124);
            this.lbListe.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(87, 221);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // AnaPencere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 321);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbListe);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.tbMetin);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AnaPencere";
            this.Text = "Uygulama Penceresi";
            this.Load += new System.EventHandler(this.PencereYuklendi);
            this.ResumeLayout(false);
            this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.TextBox tbMetin;
      private System.Windows.Forms.Button btnEkle;
      private System.Windows.Forms.ListBox lbListe;
        private System.Windows.Forms.Button button1;
    }
}

