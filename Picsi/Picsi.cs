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
        private string pathFile;
        public Picsi()
        {
            InitializeComponent();
        }

        private void Picsi_Load(object sender, EventArgs e)
        {

        }
        
        private void buttonChooseFile_Click(object sender, EventArgs e)
        {
            DialogResult result = picBrowserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                textBoxInfos.Text = "";
                try
                {
                    pathFile = picBrowserDialog.FileName;
                    var picM = new PicManager();
                    var info = picM.GetInfos(pathFile);
                    foreach (var prop in info.GetType().GetProperties())
                    {
                        textBoxInfos.AppendText(prop.Name + ": " + prop.GetValue(info) + "\r\n");
                    }
                    pictureBox.Image = new Bitmap(pathFile);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur : " + ex.Message);
                }
            }
        }
    }
}
