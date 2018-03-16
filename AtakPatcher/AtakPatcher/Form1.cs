using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AtakPatcher
{
    public partial class Form1 : Form
    {
        static void satirDegistir(string newText, string fileName, int line_to_edit)
        {
            string[] arrLine = File.ReadAllLines(fileName);
            arrLine[line_to_edit - 1] = newText;
            File.WriteAllLines(fileName, arrLine);
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            //8.satırda şifrelenen seri no tutuluyor o değiştirilmeli.
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = 1;
            MessageBox.Show("Patchlemek istediğiniz atak.veri dosyasını seçiniz(USB kökünde gizli olarak bulunur.)");
            OpenFileDialog hedef = new OpenFileDialog();


            hedef.Filter = "Atak USB KEY dosyası |*.veri";
            hedef.Title = "Patchlenecek atak.veri'yi seçiniz.";
            if (hedef.ShowDialog() == DialogResult.OK)
            {
                x++;
            }
            MessageBox.Show("Kendi ürettiğiniz atak.veri dosyasını seçiniz(Atak 1.09 sürümünden üretebilirsiniz.)");
            OpenFileDialog kendidosyasi = new OpenFileDialog();
            kendidosyasi.Filter = "Atak USB KEY dosyası |*.veri";
            hedef.Title = "Kendi atak.verinizi seçiniz.";

            if (kendidosyasi.ShowDialog() == DialogResult.OK & x == 2)
            {
                string anapath = hedef.FileName;
                string kendipath = kendidosyasi.FileName;
                MessageBox.Show(anapath + "     " + kendipath);
                x = 1;
                string usbserino = File.ReadLines(kendipath).Skip(7).Take(1).First();
                MessageBox.Show("Dosyalar seçildi, patchlenme işlemi yapılıyor.");
                satirDegistir(usbserino, anapath, 8);
                MessageBox.Show("Patchlenme işlemi tamamnlandı.");
            }
            else { MessageBox.Show("Her iki dosyayıda seçmelisiniz.");
            }
            


            }
        }
    }

