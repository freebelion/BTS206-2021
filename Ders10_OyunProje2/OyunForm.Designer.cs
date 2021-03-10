
namespace Ders10_OyunProje2
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OyunForm));
         this.kontrolPaneli = new System.Windows.Forms.Panel();
         this.oyunPaneli = new System.Windows.Forms.Panel();
         this.resimListe = new System.Windows.Forms.ImageList(this.components);
         this.numMatrisBoyutu = new System.Windows.Forms.NumericUpDown();
         this.kontrolPaneli.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.numMatrisBoyutu)).BeginInit();
         this.SuspendLayout();
         // 
         // kontrolPaneli
         // 
         this.kontrolPaneli.BackColor = System.Drawing.Color.Gainsboro;
         this.kontrolPaneli.Controls.Add(this.numMatrisBoyutu);
         this.kontrolPaneli.Dock = System.Windows.Forms.DockStyle.Left;
         this.kontrolPaneli.Location = new System.Drawing.Point(0, 0);
         this.kontrolPaneli.Name = "kontrolPaneli";
         this.kontrolPaneli.Size = new System.Drawing.Size(75, 450);
         this.kontrolPaneli.TabIndex = 0;
         // 
         // oyunPaneli
         // 
         this.oyunPaneli.AllowDrop = true;
         this.oyunPaneli.BackColor = System.Drawing.Color.White;
         this.oyunPaneli.Dock = System.Windows.Forms.DockStyle.Fill;
         this.oyunPaneli.Location = new System.Drawing.Point(75, 0);
         this.oyunPaneli.Name = "oyunPaneli";
         this.oyunPaneli.Size = new System.Drawing.Size(464, 450);
         this.oyunPaneli.TabIndex = 1;
         // 
         // resimListe
         // 
         this.resimListe.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("resimListe.ImageStream")));
         this.resimListe.TransparentColor = System.Drawing.Color.Transparent;
         this.resimListe.Images.SetKeyName(0, "renk1.bmp");
         this.resimListe.Images.SetKeyName(1, "renk2.bmp");
         this.resimListe.Images.SetKeyName(2, "renk3.bmp");
         // 
         // numMatrisBoyutu
         // 
         this.numMatrisBoyutu.Location = new System.Drawing.Point(13, 13);
         this.numMatrisBoyutu.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
         this.numMatrisBoyutu.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
         this.numMatrisBoyutu.Name = "numMatrisBoyutu";
         this.numMatrisBoyutu.Size = new System.Drawing.Size(53, 26);
         this.numMatrisBoyutu.TabIndex = 0;
         this.numMatrisBoyutu.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
         this.numMatrisBoyutu.ValueChanged += new System.EventHandler(this.numMatrisBoyutu_ValueChanged);
         // 
         // OyunForm
         // 
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
         this.ClientSize = new System.Drawing.Size(539, 450);
         this.Controls.Add(this.oyunPaneli);
         this.Controls.Add(this.kontrolPaneli);
         this.DoubleBuffered = true;
         this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
         this.Name = "OyunForm";
         this.Text = "Form1";
         this.Load += new System.EventHandler(this.OyunForm_Load);
         this.kontrolPaneli.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.numMatrisBoyutu)).EndInit();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.Panel kontrolPaneli;
      private System.Windows.Forms.Panel oyunPaneli;
      private System.Windows.Forms.ImageList resimListe;
      private System.Windows.Forms.NumericUpDown numMatrisBoyutu;
   }
}

