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
        public Form1()
        {
            InitializeComponent();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosya = new OpenFileDialog();
            dosya.Filter = "Atak USB KEY dosyası |*.veri";
            dosya.Title = "Patchlenecek keyi seçin.";
            dosya.ShowDialog();
            if (dosya.ShowDialog() == DialogResult.OK)
            {
                string dosyaYolu = dosya.FileName;

            }
        }
    }
}
