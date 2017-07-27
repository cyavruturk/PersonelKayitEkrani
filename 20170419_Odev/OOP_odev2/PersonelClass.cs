using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_odev2
{
    class PersonelClass : Insan
    {
       
        public string telefon;
      
        private string _email;
      
        public string adres;
        private DateTime _isegiris;
        private string _unvan;
        private int _departman;
        private string _resim;

       
        public override string ToString()
        {
            return this.Ad + " " + this.Soyad + " " + this.telefon + " " + this.IseGirisTarihi + " " + this.Unvan;
        } 
       
        public string email
        {
            get
            {

                return _email;
            }
            set
            {
                if (value.IndexOf("@") != -1)
                {
                    _email = value;
                }
            }
        }

        public DateTime IseGirisTarihi
        {
            get
            {
                return _isegiris;
            }
            set
            {
                if (value > DateTime.Now)
                {
                    System.Windows.Forms.MessageBox.Show("Geçersiz tarih!");
                }
                else
                {
                    _isegiris = value;
                }
            }
        }

        public string Unvan
        {
            get
            {
                return _unvan;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    System.Windows.Forms.MessageBox.Show("Unvan Boş Geçilemez");
                }
                else
                {
                    _unvan = value;
                }
            }
        }

        public int Departman
        {
            get
            {
                return _departman;
            }
            set
            {
                if (value == -1)
                {
                    System.Windows.Forms.MessageBox.Show("Departman Boş geçilemez!");

                }
                else
                {
                    _departman = value;
                }
            }
        }
    }
}
