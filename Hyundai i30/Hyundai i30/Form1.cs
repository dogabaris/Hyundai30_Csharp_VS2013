using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Hyundai_i30
{
    public partial class Hyundai30 : Form
    {
        bool TusKontrol;
        int   hizaci,benzinaci, sicaklikaci;
        float deviraci,yuzde;
        double KM, mesafe;
        

        public Hyundai30()
        {
            InitializeComponent();
        }

        private void Devir_Paint(object sender, PaintEventArgs e)
        {
            string dizin = Directory.GetParent(Directory.GetParent(Environment.CurrentDirectory).Parent.FullName).Parent.FullName + "\\gosterge\\ibre1.png";
            Bitmap ibre = new Bitmap(dizin);
            
            Point hedefNoktasi = new Point(-ibre.Width / 2, ibre.Width / 2);

            Size nSize = ibre.Size;
            Size pSize = Devir.ClientSize;

            int transX = pSize.Width / 2; // Burdan başlangıç noktası ayarlanacak
            int transY = pSize.Height - nSize.Width / 2;

            e.Graphics.TranslateTransform(transX, transY);
            e.Graphics.RotateTransform(deviraci + 90);

            e.Graphics.DrawImage(ibre, hedefNoktasi);
        }

        private void Hiz_Paint(object sender, PaintEventArgs e)
        {
            string dizin = Directory.GetParent(Directory.GetParent(Environment.CurrentDirectory).Parent.FullName).Parent.FullName + "\\gosterge\\ibre2.png";
            Bitmap ibre = new Bitmap(dizin);
            hizaci = hizTrackbar.Value;
            KM = hizaci * 1.35;
            hizLabel.Text = KM.ToString("###0");
            mesafeLabel.Text = mesafe.ToString("###0");
            
           
            Point hedefNoktasi = new Point(-ibre.Width / 2, ibre.Width / 2);

            Size nSize = ibre.Size;
            Size pSize = Hiz.ClientSize;

            int transX = pSize.Width / 2; // Burdan başlangıç noktası ayarlanacak
            int transY = pSize.Height - nSize.Width / 2;
     
            e.Graphics.TranslateTransform(transX, transY);
            e.Graphics.RotateTransform(hizaci + 90);
  
            e.Graphics.DrawImage(ibre, hedefNoktasi);
            
        }

        private void sicaklikPB_Paint(object sender, PaintEventArgs e)
        {
            string dizin = Directory.GetParent(Directory.GetParent(Environment.CurrentDirectory).Parent.FullName).Parent.FullName + "\\gosterge\\ibre3.png";
            Bitmap ibre = new Bitmap(dizin);
            sicaklikaci = sicaklikTrackbar.Value;
    
            Point hedefNoktasi = new Point(-ibre.Width / 2, ibre.Width / 2);
    
            Size nSize = ibre.Size;
            Size pSize = sicaklikPB.ClientSize;
  
            int transX = pSize.Width / 2; // Burdan başlangıç noktası ayarlanacak
            int transY = pSize.Height - nSize.Width / 2;

            e.Graphics.TranslateTransform(transX, transY);
            e.Graphics.RotateTransform(sicaklikaci + 90);

            e.Graphics.DrawImage(ibre, hedefNoktasi);

        }

        private void benzinPB_Paint(object sender, PaintEventArgs e)
        {
            string dizin = Directory.GetParent(Directory.GetParent(Environment.CurrentDirectory).Parent.FullName).Parent.FullName + "\\gosterge\\ibre4.png";
            Bitmap ibre = new Bitmap(dizin);
            benzinaci = benzinTrackbar.Value;


            Point hedefNoktasi = new Point(-ibre.Width / 2, ibre.Width / 2);

            Size nSize = ibre.Size;
            Size pSize = benzinPB.ClientSize;

            
            int transX = pSize.Width / 2; // Burdan başlangıç noktası ayarlanacak
            int transY = pSize.Height - nSize.Width / 2;

            
            e.Graphics.TranslateTransform(transX, transY);
            e.Graphics.RotateTransform(benzinaci + 90);

            
            e.Graphics.DrawImage(ibre, hedefNoktasi);

        }



        private void Form_yukle(object sender, EventArgs e)
        {

            string dizin = Directory.GetParent(Directory.GetParent(Environment.CurrentDirectory).Parent.FullName).Parent.FullName + "\\gosterge\\digital_7\\digital-7.ttf";

            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile(dizin);
            hizLabel.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            mesafeLabel.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            
            if (sicaklikTrackbar.Value > 90 && HizZamanlayici.Enabled == true)
                sicaklik.Visible = true;
            else if (sicaklikTrackbar.Value <= 90 && HizZamanlayici.Enabled == true)
                sicaklik.Visible = false;

            
            TusKontrol = false;
        }

        private void Form_TusBasildiginda(object sender, KeyEventArgs e)
        {
            
            switch (e.KeyCode)
            {
                case Keys.Up:
                    TusKontrol = true;
                    break;

                case Keys.F12:
                    if (uzunfar.Visible == true)
                        uzunfar.Visible = false;
                    else
                        uzunfar.Visible = true;
                    break;

                case Keys.F11:
                    if (abs.Visible == true)
                        abs.Visible = false;
                    else
                        abs.Visible = true;
                    break;
                case Keys.F10:
                    if (aku.Visible == true)
                        aku.Visible = false;
                    else
                        aku.Visible = true;
                    break;
                case Keys.F9:
                    if (emniyet_kemeri.Visible == true)
                        emniyet_kemeri.Visible = false;
                    else
                        emniyet_kemeri.Visible = true;
                    break;
                case Keys.F8:
                    if (eps.Visible == true)
                        eps.Visible = false;
                    else
                        eps.Visible = true;
                    break;
                case Keys.F7:
                    if (tpms_uyari.Visible == true)
                        tpms_uyari.Visible = false;
                    else
                        tpms_uyari.Visible = true;
                    break;
                case Keys.F6:
                    if (tpms.Visible == true)
                        tpms.Visible = false;
                    else
                        tpms.Visible = true;
                    break;
                case Keys.F5:
                    if (ariza_gostergesi.Visible == true)
                        ariza_gostergesi.Visible = false;
                    else
                        ariza_gostergesi.Visible = true;
                    break;
                case Keys.F4:
                    if (motoryag_basinci.Visible == true)
                        motoryag_basinci.Visible = false;
                    else
                        motoryag_basinci.Visible = true;
                    break;
                case Keys.F3:
                    if (hava_yastigi.Visible == true)
                        hava_yastigi.Visible = false;
                    else
                        hava_yastigi.Visible = true;
                    break;
                case Keys.F2:
                    if (el_freni.Visible == true)
                        el_freni.Visible = false;
                    else
                        el_freni.Visible = true;
                    break;
                case Keys.F1:
                    if (on_isitma.Visible == true)
                        on_isitma.Visible = false;
                    else
                        on_isitma.Visible = true;
                    break;
                case Keys.D1:
                    if (solarkakapi.Visible == true)
                        solarkakapi.Visible = false;
                    else
                        solarkakapi.Visible = true;
                    break;
                case Keys.D2:
                    if (sagarkakapi.Visible == true)
                        sagarkakapi.Visible = false;
                    else
                        sagarkakapi.Visible = true;
                    break;
                case Keys.D3:
                    if (solonkapi.Visible == true)
                        solonkapi.Visible = false;
                    else
                        solonkapi.Visible = true;
                    break;
                case Keys.D4:
                    if (sagonkapi.Visible == true)
                        sagonkapi.Visible = false;
                    else
                        sagonkapi.Visible = true;
                    break;
                case Keys.D5:
                    if (sicaklik.Visible == true)
                        sicaklik.Visible = false;
                    else
                        sicaklik.Visible = true;
                    break;
                case Keys.D6:
                    if (benzin.Visible == true)
                        benzin.Visible = false;
                    else
                        benzin.Visible = true;
                    break;
                case Keys.D7:
                    if (esp.Visible == true)
                        esp.Visible = false;
                    else
                        esp.Visible = true;
                    break;
                case Keys.D8:
                    if (espoff.Visible == true)
                        espoff.Visible = false;
                    else
                        espoff.Visible = true;
                    break;
                case Keys.D9:
                    if (immobilizer.Visible == true)
                        immobilizer.Visible = false;
                    else
                        immobilizer.Visible = true;
                    break;
                case Keys.D0:
                    if (onsisfar.Visible == true)
                        onsisfar.Visible = false;
                    else
                        onsisfar.Visible = true;
                    break;
                case Keys.Q:
                    if (sol_sinyal.Visible == true)
                        sol_sinyal.Visible = false;
                    else
                        sol_sinyal.Visible = true;
                    break;
                case Keys.E:
                    if (sag_sinyal.Visible == true)
                        sag_sinyal.Visible = false;
                    else
                        sag_sinyal.Visible = true;
                    break;
            }
        }
        

        private void hizTrackbar_ValueChanged(object sender, EventArgs e)
        {
            Hiz.Refresh();//Hiz ibresi çizimini yaptıktan sonra yeniler.
            

            if (hizTrackbar.Value > 0)
            {
                HizZamanlayici.Enabled = true;
                HizZamanlayici.Interval = 1000;
                HizAzaltma.Enabled = true;
                HizAzaltma.Interval = 100;
                BenzinSaati.Enabled = true;
                BenzinSaati.Interval = 1500;
                DevirSaati.Enabled = true;
                DevirSaati.Interval = 100;
                HizDevir.Enabled = true;
                HizDevir.Interval = 100;
                SicaklikSaati.Enabled = true;
                SicaklikSaati.Interval = 5000;
            }
            else
                HizZamanlayici.Enabled = false;
                
        }

        private void BenzinSaati_Tick(object sender, EventArgs e)
        {
            benzinPB.Refresh();
            if (benzinTrackbar.Value > 0)
                benzinTrackbar.Value = benzinTrackbar.Value - 1;
            else
                BenzinSaati.Enabled = false;

            if (hizTrackbar.Value == 0)
                BenzinSaati.Enabled = false;

            if (benzinTrackbar.Value < 10 && hizTrackbar.Value != 0)
                benzin.Visible = true;
            else if (benzinTrackbar.Value > 10 && hizTrackbar.Value != 0)
                benzin.Visible = false;

            if (benzinTrackbar.Value == 0)
                hizTrackbar.Enabled = false;
                
        }

        private void DevirSaati_Tick(object sender, EventArgs e)
        {
            Devir.Refresh();
            
        }

        private void HizAzaltma_Tick(object sender, EventArgs e)
        {
            
            if (hizTrackbar.Value > 0)
            {
                hizTrackbar.Value = hizTrackbar.Value - 1;
            }
            else
            {
                HizZamanlayici.Enabled = false;
            }
        }

        private void HizZamanlayici_Tick(object sender, EventArgs e)
        {
            mesafe = mesafe + KM / 3600;
        }

        private void HizDevir_Tick(object sender, EventArgs e)
        {
            yuzde = (float)(KM / 100);


            if (KM > 0 && KM < 20)
            {
                
                if (deviraci < 30)
                {
                    if (TusKontrol == true)
                        deviraci = deviraci + 5;
                    else
                        deviraci = deviraci - 1;
                  
                }

                else
                {
                    deviraci = 30;
                }
                TusKontrol = false;
            }

            else if (KM > 20 && KM < 60)
            {
                
                if (deviraci < 60)
                {
                    if (TusKontrol == true)
                    {
                        deviraci = deviraci + 7;
                    }
                    if (deviraci > 35)
                    {
                        deviraci = deviraci - 1;
                    }
                    
                }

                else
                {
                    deviraci = 60;
                }
                TusKontrol = false;
            }
            else if (KM > 60 && KM < 120)
            {
                
                if (deviraci < 90)
                {
                    if (TusKontrol == true)
                    {
                        deviraci = deviraci + 10;
                    }
                    if (deviraci > 35)
                    {
                        deviraci = deviraci - (float)0.6;
                    }
                }
                else
                {
                    deviraci = 90;
                }
                TusKontrol = false;
                
            }
            else if (KM > 120 && KM < 180)
            {
                
                if (deviraci < 120)
                {
                    if (TusKontrol == true)
                    {
                        deviraci = deviraci + 10;
                    }
                    if (deviraci > 35)
                    {
                        deviraci = deviraci - (float)0.6;
                    }

                }

                else
                {
                    deviraci = 120;
                }
                TusKontrol = false;
            }
            else if (KM > 180 && KM < 240)
            {
                
                if (deviraci < 150)
                {
                    if (TusKontrol == true)
                    {
                            deviraci = deviraci + 10;
                    }
                    if (deviraci > 35)
                    {
                        deviraci = deviraci - 1;
                    }

                }
                else
                {
                    deviraci = 140;
                }
                TusKontrol = false;
            }
            if(deviraci > 0)
            {
                deviraci = deviraci - (float)0.4;
            }
            

            if (deviraci < 0)
                deviraci = 0;

            TusKontrol = false;
             
        }

        private void SicaklikSaati_Tick(object sender, EventArgs e)
        {
            sicaklikPB.Refresh();
            int yuzde = (int)KM / 100;
            if(KM > 120)
            {            
                sicaklikTrackbar.Value = sicaklikTrackbar.Value + yuzde;
            }
            else
            {
                if (sicaklikTrackbar.Value > 0)
                sicaklikTrackbar.Value = sicaklikTrackbar.Value - 1;
            }

            if (sicaklikTrackbar.Value < 100 && hizTrackbar.Value != 0)
                sicaklik.Visible = false;
            else if (sicaklikTrackbar.Value >= 100 && hizTrackbar.Value != 0)
                sicaklik.Visible = true;
        }

    }
}