using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Picsi
{
    public partial class Picsi : Form
    {
        public Picsi()
        {
            InitializeComponent();
        }

        private void Picsi_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenue :)");
        }

        private void BtnGetInfo_Click(object sender, EventArgs e)
        {
            var picM = new PicManager();
            var info = picM.GetInfos(@"C:\Temp\photo.jpg");
            MessageBox.Show("Informations");
            MessageBox.Show(info.Path);
            MessageBox.Show(info.Name);
            MessageBox.Show(info.Extension);
            MessageBox.Show(info.ShotDate.ToShortDateString());
        }
    }
}
