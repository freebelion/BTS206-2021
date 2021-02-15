
namespace Ders3_ListeKutusu
{
   partial class AnaForm
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
         this.lbListe = new System.Windows.Forms.ListBox();
         this.SuspendLayout();
         // 
         // tbMetin
         // 
         this.tbMetin.BackColor = System.Drawing.Color.MistyRose;
         this.tbMetin.Dock = System.Windows.Forms.DockStyle.Top;
         this.tbMetin.Location = new System.Drawing.Point(0, 0);
         this.tbMetin.Name = "tbMetin";
         this.tbMetin.ReadOnly = true;
         this.tbMetin.Size = new System.Drawing.Size(334, 29);
         this.tbMetin.TabIndex = 0;
         // 
         // lbListe
         // 
         this.lbListe.BackColor = System.Drawing.Color.Coral;
         this.lbListe.Dock = System.Windows.Forms.DockStyle.Fill;
         this.lbListe.FormattingEnabled = true;
         this.lbListe.ItemHeight = 24;
         this.lbListe.Items.AddRange(new object[] {
            "Recai",
            "Mesai",
            "Dubai",
            "Nevai",
            "Sezai",
            "Rubai"});
         this.lbListe.Location = new System.Drawing.Point(0, 29);
         this.lbListe.Name = "lbListe";
         this.lbListe.Size = new System.Drawing.Size(334, 332);
         this.lbListe.TabIndex = 1;
         this.lbListe.SelectedIndexChanged += new System.EventHandler(this.lbListe_SelectedIndexChanged);
         this.lbListe.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ListeTusaBasildi);
         // 
         // AnaForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(334, 361);
         this.Controls.Add(this.lbListe);
         this.Controls.Add(this.tbMetin);
         this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
         this.Margin = new System.Windows.Forms.Padding(6);
         this.MinimumSize = new System.Drawing.Size(300, 350);
         this.Name = "AnaForm";
         this.Text = "Form1";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.TextBox tbMetin;
      private System.Windows.Forms.ListBox lbListe;
   }
}

