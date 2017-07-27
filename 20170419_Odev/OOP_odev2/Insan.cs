using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_odev2
{
    class Insan
    {
        private long _tcno;
        private string _ad;
        private string _soyad;
        private DateTime _dogumtarih;

        public long tcno
        {
            get
            {
                return _tcno;
            }
            set
            {
                if (value == null && value != 11)
                {
                    System.Windows.Forms.MessageBox.Show("TC Kimlik Numarası Boş veya Eksik Geçilemez!");
                }
                else
                {
                    _tcno = value;
                }
            }
        }

        public string Ad
        {
            get
            {
                return _ad;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    System.Windows.Forms.MessageBox.Show("İsim Boş Geçilemez");
                }
                else
                {
                    _ad = value;
                }
            }
        }

        public string Soyad
        {
            get
            {
                return _soyad;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    System.Windows.Forms.MessageBox.Show("Soyad Boş Geçilemez");
                }
                else
                {
                    _soyad = value;
                }
            }
        }

        public DateTime DogumTarihi
        {
            get
            {
                return _dogumtarih;
            }
            set
            {
                if (DateTime.Now.Year - value.Year > 18 && DateTime.Now.Year - value.Year < 65)
                {
                    _dogumtarih = value;
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Yaş 18 den küçük 65den büyük olamaz!");
                    _dogumtarih = DateTime.Now;
                }
            }
        }

    }
}
