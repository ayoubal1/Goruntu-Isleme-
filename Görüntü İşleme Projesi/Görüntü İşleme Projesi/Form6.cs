using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace odev
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Bitmap GirisResmi, CikisResmiXY, CikisResmiX, CikisResmiY;
            GirisResmi = new Bitmap(pictureBox1.Image);
            int ResimGenisligi = GirisResmi.Width;
            int ResimYuksekligi = GirisResmi.Height;
            CikisResmiX = new Bitmap(ResimGenisligi, ResimYuksekligi);
            CikisResmiY = new Bitmap(ResimGenisligi, ResimYuksekligi);
            CikisResmiXY = new Bitmap(ResimGenisligi, ResimYuksekligi);
            int SablonBoyutu = 3;
            int ElemanSayisi = SablonBoyutu * SablonBoyutu;
            int x, y;
            Color Renk;
            int P1, P2, P3, P4, P5, P6, P7, P8, P9;
            for (x = (SablonBoyutu - 1) / 2; x < ResimGenisligi - (SablonBoyutu - 1) / 2; x++) //Re  taramaya şablonun yarısı kadar dış kenarlardan içeride başlayacak ve bitirecek.
 {
                for (y = (SablonBoyutu - 1) / 2; y < ResimYuksekligi - (SablonBoyutu - 1) / 2; y++)
                {
                    Renk = GirisResmi.GetPixel(x - 1, y - 1);
                    P1 = (Renk.R + Renk.G + Renk.B) / 3;
                    Renk = GirisResmi.GetPixel(x, y - 1);
                    P2 = (Renk.R + Renk.G + Renk.B) / 3;
                    Renk = GirisResmi.GetPixel(x + 1, y - 1);
                    P3 = (Renk.R + Renk.G + Renk.B) / 3;
                    Renk = GirisResmi.GetPixel(x - 1, y);
                    P4 = (Renk.R + Renk.G + Renk.B) / 3;
                    Renk = GirisResmi.GetPixel(x, y);
                    P5 = (Renk.R + Renk.G + Renk.B) / 3;
                    Renk = GirisResmi.GetPixel(x + 1, y);
                    P6 = (Renk.R + Renk.G + Renk.B) / 3;
                    Renk = GirisResmi.GetPixel(x - 1, y + 1);
                    P7 = (Renk.R + Renk.G + Renk.B) / 3;
                    Renk = GirisResmi.GetPixel(x, y + 1);
                    P8 = (Renk.R + Renk.G + Renk.B) / 3;
                    Renk = GirisResmi.GetPixel(x + 1, y + 1);
                    P9 = (Renk.R + Renk.G + Renk.B) / 3;
                    //Hesaplamayı yapan Sobel Temsili matrisi ve formülü.
                    int Gx = Math.Abs(-P1 + P3 - 2 * P4 + 2 * P6 - P7 + P9); //Dikey çizgiler
                    int Gy = Math.Abs(P1 + 2 * P2 + P3 - P7 - 2 * P8 - P9); //Yatay Çizgiler
                                                                           
                    int Gxy = Gx + Gy;
                    //if (Gxy > Esikleme)
                    // Gxy = 255;
                    //else
                    // Gxy = 0;
                    //Renkler sınırların dışına çıktıysa, sınır değer alınacak. Negatif olamaz,  formüllerde mutlak değer vardır.
                     if (Gx > 255) Gx = 255;
                    if (Gy > 255) Gy = 255;
                    if (Gxy > 255) Gxy = 255;
                    //int TetaRadyan = 0;
                    //if (Gy != 0)
                    // TetaRadyan = Convert.ToInt32(Math.Atan(Gx / Gy));
                    //else
                    // TetaRadyan = Convert.ToInt32(Math.Atan(Gx));
                    //int TetaDerece = Convert.ToInt32((TetaRadyan * 360) / (2 * Math.PI));
                    //if (TetaDerece >= 0 && TetaDerece < 45)
                    // CikisResmiXY.SetPixel(x, y, Color.FromArgb(0, 0, 0));
                    //if (TetaDerece >= 45 && TetaDerece < 90)
                    // CikisResmiXY.SetPixel(x, y, Color.FromArgb(0, 255, 0));
                    //if (TetaDerece >= 90 && TetaDerece < 135)
                    // CikisResmiXY.SetPixel(x, y, Color.FromArgb(0, 0, 255));
                    //if (TetaDerece >= 135 && TetaDerece < 180)
                    // CikisResmiXY.SetPixel(x, y, Color.FromArgb(255, 255, 0));
                    CikisResmiX.SetPixel(x, y, Color.FromArgb(Gx, Gx, Gx));
                    CikisResmiY.SetPixel(x, y, Color.FromArgb(Gy, Gy, Gy));
                    CikisResmiXY.SetPixel(x, y, Color.FromArgb(Gxy, Gxy, Gxy));
                }
            }
            pictureBox2.Image = CikisResmiXY;
            pictureBox3.Image = CikisResmiX;
            pictureBox4.Image = CikisResmiY;




        }
    }
}
