using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace kalorihtiyaci
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_hesapla_Click(object sender, EventArgs e)
        {
            
            
            int yas, boy, kilo;
            double carpim, sonuc;
            yas = Convert.ToInt32(txt_yas.Text);
            boy = Convert.ToInt32(txt_boy.Text);
            kilo = Convert.ToInt32(txt_kilo.Text);
           

            if (Convert.ToInt32(drp_cinsiyet.SelectedValue) == -1)
            {
                if(Convert.ToInt32(drp_aktivite.SelectedValue) == -1)
                {
                    txt_sonuc.Text = "Lütfen Geçerli bir cinsiyet/aktivite giriniz.";
                }
                else
                {
                    txt_sonuc.Text = "Lütfen geçerli bir cinsiyet giriniz.";
                }
            }
            if (Convert.ToInt32(drp_cinsiyet.SelectedValue)==0)
            {
                
                carpim = 88.362 + (13.397 * kilo) + (4.799 * boy) - (5.677 * yas);
                switch (Convert.ToInt32(drp_aktivite.SelectedValue))
                {
                    case -1:
                        if (Convert.ToInt32(drp_cinsiyet.SelectedValue) == -1)
                        {
                            txt_sonuc.Text = "Lütfen Geçerli bir Cinsiyet/Aktivite seçiniz.";
                        }
                        else
                        {
                            txt_sonuc.Text = "Lütfen Geçerli bir aktivite seçiniz.";
                        }
                        break;
                    case 0:
                        sonuc = carpim * 1.2;
                        txt_sonuc.Text = Convert.ToString(sonuc);
                        break;
                    case 1:
                        sonuc = carpim * 1.375;
                        txt_sonuc.Text = Convert.ToString(sonuc);
                        break;
                    case 2:
                        sonuc = carpim * 1.55;
                        txt_sonuc.Text = Convert.ToString(sonuc);
                        break;
                    case 3:
                        sonuc = carpim * 1.725;
                        txt_sonuc.Text = Convert.ToString(sonuc);
                        break;
                    case 4:
                        sonuc = carpim * 1.9;
                        txt_sonuc.Text = Convert.ToString(sonuc);
                        break;
                }
            }
            if(Convert.ToInt32(drp_cinsiyet.SelectedValue) == 1)
            {
                carpim = 447.593 + (9.247 * kilo)+ (3.098*kilo)-(4.330*yas);
                switch (Convert.ToInt32(drp_aktivite.SelectedValue))
                {
                    case -1:
                        if (Convert.ToInt32(drp_cinsiyet.SelectedValue) == -1)
                        {
                            txt_sonuc.Text = "Lütfen Geçerli bir Cinsiyet/Aktivite seçiniz.";
                        }
                        else
                        {
                            txt_sonuc.Text = "Lütfen Geçerli bir aktivite seçiniz.";
                        }
                        break;
                    case 0:
                        sonuc = carpim * 1.2;
                        txt_sonuc.Text = Convert.ToString(sonuc);
                        break;
                    case 1:
                        sonuc = carpim * 1.375;
                        txt_sonuc.Text = Convert.ToString(sonuc);
                        break;
                    case 2:
                        sonuc = carpim * 1.55;
                        txt_sonuc.Text = Convert.ToString(sonuc);
                        break;
                    case 3:
                        sonuc = carpim * 1.725;
                        txt_sonuc.Text = Convert.ToString(sonuc);
                        break;
                    case 4:
                        sonuc = carpim * 1.9;
                        txt_sonuc.Text = Convert.ToString(sonuc);
                        break;
                }
            }
        }
    }
}