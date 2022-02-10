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
namespace SistemaDeArchivo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAbriDocumento_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Archivo de texto|*.txt";
            dialog.Title = "Abrir archivo de texto";
            dialog.InitialDirectory =
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string ruta = dialog.FileName;
                if (!File.Exists(ruta))
                {
                    MessageBox.Show("El archivo no existe");
                }
            }
        }

        private void btnAbrirFolder_Click(object sender, EventArgs e)
        {
             FolderBrowserDialog dialog = new FolderBrowserDialog();
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                lblRuta.Text = dialog.SelectedPath;
                DirectoryInfo di = new DirectoryInfo(dialog.SelectedPath);
                if (di.Exists)
                {
                    FileInfo[] archivos= di.EnumerateFiles("*.txt").ToArray();
                    lstArchivos.DataSource = archivos;
                    lstArchivos.DisplayMember="Name";
                }
            }
        }
    }
}
