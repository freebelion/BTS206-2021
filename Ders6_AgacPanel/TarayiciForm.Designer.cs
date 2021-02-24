
namespace Ders6_AgacPanel
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
         this.components = new System.ComponentModel.Container();
         this.BolmeliPanel = new System.Windows.Forms.SplitContainer();
         this.KlasorPanel = new System.Windows.Forms.TreeView();
         this.DosyaPanel = new System.Windows.Forms.ListView();
         this.klasorSimgeleri = new System.Windows.Forms.ImageList(this.components);
         ((System.ComponentModel.ISupportInitialize)(this.BolmeliPanel)).BeginInit();
         this.BolmeliPanel.Panel1.SuspendLayout();
         this.BolmeliPanel.Panel2.SuspendLayout();
         this.BolmeliPanel.SuspendLayout();
         this.SuspendLayout();
         // 
         // BolmeliPanel
         // 
         this.BolmeliPanel.Dock = System.Windows.Forms.DockStyle.Fill;
         this.BolmeliPanel.Location = new System.Drawing.Point(0, 0);
         this.BolmeliPanel.Name = "BolmeliPanel";
         // 
         // BolmeliPanel.Panel1
         // 
         this.BolmeliPanel.Panel1.Controls.Add(this.KlasorPanel);
         // 
         // BolmeliPanel.Panel2
         // 
         this.BolmeliPanel.Panel2.Controls.Add(this.DosyaPanel);
         this.BolmeliPanel.Size = new System.Drawing.Size(580, 338);
         this.BolmeliPanel.SplitterDistance = 193;
         this.BolmeliPanel.TabIndex = 0;
         // 
         // KlasorPanel
         // 
         this.KlasorPanel.BackColor = System.Drawing.Color.PeachPuff;
         this.KlasorPanel.Dock = System.Windows.Forms.DockStyle.Fill;
         this.KlasorPanel.ImageIndex = 0;
         this.KlasorPanel.ImageList = this.klasorSimgeleri;
         this.KlasorPanel.Location = new System.Drawing.Point(0, 0);
         this.KlasorPanel.Name = "KlasorPanel";
         this.KlasorPanel.SelectedImageIndex = 0;
         this.KlasorPanel.Size = new System.Drawing.Size(193, 338);
         this.KlasorPanel.TabIndex = 0;
         this.KlasorPanel.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.KlasorPanel_AfterSelect);
         // 
         // DosyaPanel
         // 
         this.DosyaPanel.BackColor = System.Drawing.Color.Khaki;
         this.DosyaPanel.Dock = System.Windows.Forms.DockStyle.Fill;
         this.DosyaPanel.HideSelection = false;
         this.DosyaPanel.Location = new System.Drawing.Point(0, 0);
         this.DosyaPanel.Name = "DosyaPanel";
         this.DosyaPanel.Size = new System.Drawing.Size(383, 338);
         this.DosyaPanel.TabIndex = 0;
         this.DosyaPanel.UseCompatibleStateImageBehavior = false;
         this.DosyaPanel.View = System.Windows.Forms.View.List;
         // 
         // klasorSimgeleri
         // 
         this.klasorSimgeleri.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
         this.klasorSimgeleri.ImageSize = new System.Drawing.Size(32, 32);
         this.klasorSimgeleri.TransparentColor = System.Drawing.Color.Transparent;
         // 
         // TarayiciForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(580, 338);
         this.Controls.Add(this.BolmeliPanel);
         this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
         this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.Name = "TarayiciForm";
         this.Text = "Dosya Tarayıcı Form";
         this.Load += new System.EventHandler(this.TarayiciForm_Load);
         this.BolmeliPanel.Panel1.ResumeLayout(false);
         this.BolmeliPanel.Panel2.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.BolmeliPanel)).EndInit();
         this.BolmeliPanel.ResumeLayout(false);
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.SplitContainer BolmeliPanel;
      private System.Windows.Forms.TreeView KlasorPanel;
      private System.Windows.Forms.ListView DosyaPanel;
      private System.Windows.Forms.ImageList klasorSimgeleri;
   }
}

