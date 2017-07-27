using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_odev2
{
    public partial class PersonelForm2 : Form
    {
        public PersonelForm2()
        {
            InitializeComponent();
        }

        private void ResimEkle()
        {
            openFileDialog1.Title = "Resim seçiniz";                                                //title ile görünecek alan yazısı yazdık
            openFileDialog1.Filter = "(*.jpg)|*.jpg | (*.png)|*.png |Tüm dosyalar (*.*)|*.*";       //filter ile hangi uzantıya sahip dosyaları çağırdığımızı yazıyoeuz

            if (openFileDialog1.ShowDialog() == DialogResult.OK)                                     //eğer openfiledialog penceresi açıldığında evete eşit olursa
            {
                pcresim.Image = new Bitmap(openFileDialog1.OpenFile());                             //bitmap nesnesi oluşturup pictureboxa atıyoruz
            }
        }
        private void btnekle_Click(object sender, EventArgs e)
        {
            ResimEkle();
        }

        private void ResimKaldir()
        {
            pcresim.Image = null;                       // pictureboxı boş olarak tanımlıyoruz
        }
        private void btnkaldir_Click(object sender, EventArgs e)
        {
            ResimKaldir();
        }

       // txttcno.Text,txtad.Text,txtsoyad.Text, dtpdogumtarih.Value, msktelefon.Text,txtemail.Text,txtadres.Text,dtpisegiris.Value,cmbdepartman.SelectedIndex
        private void Ekle()
        {          
            try
            {
                PersonelClass personel = new PersonelClass(); //personel tanımlamalarını try catch bloğuna aldık textboxlarına ve ilgili giriş yerlerine atadık

                personel.tcno = long.Parse(txttcno.Text);
                personel.Ad = txtad.Text;
                personel.Soyad = txtsoyad.Text;
                personel.DogumTarihi = dtpdogumtarih.Value;
                personel.telefon = msktelefon.Text;
                personel.email = txtemail.Text;
                personel.adres = txtadres.Text;
                personel.IseGirisTarihi = DateTime.Parse(dtpisegiris.Text);
                personel.Unvan = txtunvan.Text;
                personel.Departman = cmbdepartman.SelectedIndex;
                lstlistele.Items.Add(personel.ToString());
                MessageBox.Show("Kaydedildi!");
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }

            HelperTemizle tmz = new HelperTemizle();
            tmz.temizle(this);
        }
        private void btnkaydet_Click(object sender, EventArgs e)
        {
            Ekle();
        }

        PersonelClass personel;
        private void lstlistele_SelectedIndexChanged(object sender, EventArgs e)
        {
            personel= new PersonelClass();

            txttcno.Text = personel.tcno.ToString();           
            txtad.Text = personel.Ad;
            txtsoyad.Text = personel.Soyad;         
            msktelefon.Text = personel.telefon;
            txtemail.Text = personel.email;
            txtadres.Text = personel.adres;         
            txtunvan.Text = personel.Unvan;
            cmbdepartman.SelectedIndex = personel.Departman;         
        }
         
        private void lstlistele_DoubleClick(object sender, EventArgs e)
        {
            
            if (lstlistele.SelectedItems.Count > 0)
            {
                btnkaydet.Text = "Güncelle";
                txttcno.Text = personel.tcno.ToString();           //textboxları ata
                txtad.Text = personel.Ad;
                txtsoyad.Text = personel.Soyad;
                msktelefon.Text = personel.telefon;
                txtemail.Text = personel.email;
                txtadres.Text = personel.adres;
                txtunvan.Text = personel.Unvan;
                cmbdepartman.SelectedIndex = personel.Departman;            
            }        
        }

        private void Guncelle()
        {
            personel.tcno = long.Parse(txttcno.Text);
            personel.Ad = txtad.Text;
            personel.Soyad = txtsoyad.Text;
            personel.DogumTarihi = dtpdogumtarih.Value;
            personel.telefon = msktelefon.Text;
            personel.email = txtemail.Text;
            personel.adres = txtadres.Text;
            personel.IseGirisTarihi = DateTime.Parse(dtpisegiris.Text);
            personel.Unvan = txtunvan.Text;
            personel.Departman = cmbdepartman.SelectedIndex;

             int index = lstlistele.SelectedIndex;
             lstlistele.Items.RemoveAt(index);
             lstlistele.Items.Insert(index, personel.ToString());
        }
        
    }
}
