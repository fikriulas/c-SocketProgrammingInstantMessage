using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SocketProgrammingClient
{
    public partial class Form1 : Form
    {
        NetworkStream serverBaglan;  // stream ve tcpclient tanımlanır.     
        TcpClient client;
        Thread thread;
        string kullaniciAdi;
        Boolean bagliMi = false; // bağlılık durumuna göre bazı butanların visible özelliği değişir.

        public Form1()
        {
            InitializeComponent();
            if (!bagliMi)
            { // client bağlı değilse bilgi butonlarının gözükmemesi sağlanır.
                btnBagli.Visible = false;
                lblBagli.Visible = false;
            }
        }

        private void btnBaglan_Click(object sender, EventArgs e)
        {
            if(ValidateChildren(ValidationConstraints.Enabled))
            { // kullanıcı adı ve port numara bilgisi alınmadan bağlantı gerçekleşmemesi için
                // validate doğrulaması gerekir.
                btnBagli.Visible = true;
                lblBagli.Visible = true;
                btnBagliDegil.Visible = false;
                lblBagliDegil.Visible = false; // bağlantı sağlandığı için ilgili bilgi butonları gözükür.

                int port = Int32.Parse(txtPort.Text);
                kullaniciAdi = txtKullaniciAdi.Text;
                string ipAdres = txtip.Text;
                IPAddress ip = IPAddress.Parse(ipAdres);
                client = new TcpClient();
                client.Connect(ip, port);
                serverBaglan = client.GetStream();
                bagliMi = true; //port bilgisi ve kullanıcı adı bilgisi alınıp server'a bağlantı sağlanır.

                thread = new Thread(o => veriAl((TcpClient)o));  
                if (!thread.IsAlive) // çalışan thread tekrar çalışmaması için kullanıldı.
                {//bağlantı sağlandıktan sonra verial methodu thread üzerinde çalıştırılır.
                    thread.Start(client);
                }
                string gonderKullaniciBilgisi = kullaniciAdi + " Baglandi!";
                byte[] buffer = Encoding.ASCII.GetBytes(gonderKullaniciBilgisi);
                serverBaglan.Write(buffer, 0, buffer.Length);    // server'a bağlantı bilgisi gönderildi.
            }
                            
        }
        void veriAl(TcpClient client)
        {
            NetworkStream serverBaglan = client.GetStream(); // serverdan stream alındı.
            byte[] byteAl = new byte[30774];
            int byteBoyut;
            while ((byteBoyut = serverBaglan.Read(byteAl, 0, byteAl.Length)) > 0) // stream'dan veri alındı.
            {
                if (byteAl[0] < 200)
                { // byte verinin ilk indis değeri 200'den küçük ise fotoğraf olmadığı anlaşılır.                    
                    this.Invoke(new MethodInvoker(delegate()
                        {
                            string gelenMesaj = Encoding.ASCII.GetString(byteAl, 0, byteBoyut);// byte veri string'e dönüştür.
                            listGelenMesaj.Items.Add(gelenMesaj); // listbox'a yaz.
                        }));
                }
                else
                { // eğer 200'den büyükse fotoğraf olduğu anlaşılır. 
                    MemoryStream imageMemoryStream = new MemoryStream(byteAl); // byte veriyi memoryStream'a dönüştür.
                    Image imgFromStream = Image.FromStream(imageMemoryStream); // memoryStream'ı image'e dönüştür.
                    picResim.Image = imgFromStream; // picturebox'a yaz.
                }
            }
            client.Client.Shutdown(SocketShutdown.Send);
            thread.Join();
            serverBaglan.Close();            
            client.Close();
        }

        private void btnMesaj_Click(object sender, EventArgs e)
        { // bu method client mesajlarını server'a gönderir.
            if (bagliMi)
            {
                if (!thread.IsAlive)
                {
                    thread.Start(client);
                }
                string mesaj = txtMesaj.Text;
                string mesajGonder = kullaniciAdi + ": " + mesaj;
                byte[] buffer = Encoding.ASCII.GetBytes(mesajGonder);
                serverBaglan.Write(buffer, 0, buffer.Length);
                txtMesaj.Text = "";
            }
            else
            { // server'a bağlı değilse veri gönderimi hataya neden olacağından, bağlı olmama durumunda messageBox'a gönderilir.
                MessageBox.Show("Resim Gönderebilmek İçin Giriş Yapmanı Gerekir!", "Bağlantı Durumu", MessageBoxButtons.OK);
            }
        }

        private void btnResim_Click(object sender, EventArgs e)
        {
            if (bagliMi)
            { // kullanıcı server'a bağlı ise openfiledialog ile resim dosya yolu alınır.
                OpenFileDialog dosya = new OpenFileDialog();
                dosya.Filter = "Resim Dosyasi |*.jpg;*.nef;*.png| Video|*.avi| Tüm Dosyalar |*.*";
                dosya.Title = "Göndereceğiniz Resmi Seçin";
                dosya.ShowDialog();
                string DosyaYolu = dosya.FileName;
                if (!thread.IsAlive)
                {
                    thread.Start(client);
                }                
                Image image = Image.FromFile(DosyaYolu); // resim image'e dönüşür.
                MemoryStream ms = new MemoryStream();
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg); // memoryStream'a dönüşür.
                byte[] byte1 = ms.ToArray(); //ms üzerinden byte verisine dönüştürülür.
                serverBaglan.Write(byte1, 0, byte1.Length); // stream'a yazılır. Ve gönderilir.
            }
            else
            {// server'a bağlı değilse veri gönderimi hataya neden olacağından, bağlı olmama durumunda messageBox'a gönderilir.
                MessageBox.Show("Resim Gönderebilmek İçin Giriş Yapmanı Gerekir!", "Bağlantı Durumu", MessageBoxButtons.OK);
            }
        }

        private void btnBagliDegil_Click(object sender, EventArgs e)
        { // bilgi butonu messageBox üzerinden bilgi verir.
            MessageBox.Show("Mesaj Gönderebilmek İçin Giriş Yapmanı Gerekir!", "Bağlantı Durumu", MessageBoxButtons.OK);
        }

        private void txtPort_Validating(object sender, CancelEventArgs e)
        {  // port ve kullanıcı adı verileri önemli olduğunda validation ayarlandı.
            if (string.IsNullOrEmpty(txtPort.Text))
            {
                e.Cancel = true;
                txtPort.Focus();
                errorProvider1.SetError(txtPort, "Lütfen Port Bilgisini Girin");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtPort, null);
            }
        }

        private void txtKullaniciAdi_Validating(object sender, CancelEventArgs e)
        { // port ve kullanıcı adı verileri önemli olduğunda validation ayarlandı.
            if (string.IsNullOrEmpty(txtKullaniciAdi.Text))
            {
                e.Cancel = true;
                txtPort.Focus();
                errorProvider2.SetError(txtKullaniciAdi, "Lütfen Kullanici Adı Bilgisini Girin");
            }
            else
            {
                e.Cancel = false;
                errorProvider2.SetError(txtKullaniciAdi, null);
            }
        }

        private void btnBagli_Click(object sender, EventArgs e)
        {// bilgi butonu messageBox üzerinden bilgi verir.
            MessageBox.Show("Bağlantı Başarıyla Kuruldu!", "Bağlantı Durumu", MessageBoxButtons.OK);
        }
    }
}
