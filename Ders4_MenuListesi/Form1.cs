using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders4_MenuListesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDosyaMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnAcMenuItem_Click(object sender, EventArgs e)
        {
            tbEditor.LoadFile("dosya.rtf");
        }

        private void btnKaydetMenuItem_Click(object sender, EventArgs e)
        {
            tbEditor.SaveFile("dosya.rtf");
        }

        private void btnKalinYazi_Click(object sender, EventArgs e)
        {
            Font seciliYaziTipi = tbEditor.SelectionFont;
            tbEditor.SelectionFont = new Font(seciliYaziTipi, FontStyle.Bold);
        }

        private void btnItalikYazi_Click(object sender, EventArgs e)
        {
            Font seciliYaziTipi = tbEditor.SelectionFont;
            tbEditor.SelectionFont = new Font(seciliYaziTipi, FontStyle.Italic);
        }

        private void btnCizgiliYazi_Click(object sender, EventArgs e)
        {
            Font seciliYaziTipi = tbEditor.SelectionFont;
            tbEditor.SelectionFont = new Font(seciliYaziTipi, FontStyle.Underline);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            Font seciliYaziTipi = tbEditor.SelectionFont;
            tbEditor.SelectionFont = new Font(seciliYaziTipi.FontFamily, trackBar1.Value);
        }
    }
}
