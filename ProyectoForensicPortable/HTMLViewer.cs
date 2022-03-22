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

namespace ProyectoForensicPortable
{
    public partial class HTMLViewer : Form
    {
        public HTMLViewer()
        {
            InitializeComponent();
        }
        

        private void Resultados_Load(object sender, EventArgs e)
        {
            this.Icon = Globals.AppIcon;
            this.Text += "-" + Globals.Agency;

        }

        private void ComboRes_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string linea;
                string[] registro;
                string Archivo;
                GridRes.Rows.Clear();
                GridRes.Columns.Clear();
                Archivo = ComboRes.SelectedItem.ToString();
                webBrowser.Url = new Uri(Archivo);
                StreamReader OBJREADER = new StreamReader(Archivo.Replace(".csv", ".html"));
                linea = OBJREADER.ReadLine();
                if (linea != null)
                {
                    foreach (string columna in linea.Split(','))
                    {
                        GridRes.Columns.Add(columna, columna);
                    }
                    while ((linea = OBJREADER.ReadLine()) != null)
                    {
                        registro = linea.Split(',');
                        GridRes.Rows.Add(registro);
                    }
                    GridRes.Update(); 
                }

            }
            catch (IOException error_1)
            {
                MessageBox.Show(error_1.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentNullException error_2)
            {
                MessageBox.Show(error_2.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DefaultButton_Click(object sender, EventArgs e)
        {
            string dir;
            dir = Globals.DestDrive;
            if (dir != "")
            {
                string[] files = Directory.GetFiles(dir, "*.csv");
                foreach (string Archivo in files)
                {
                    ComboRes.Items.Add(Archivo);
                }
            }
        }

        private void SelectButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog Fold = new FolderBrowserDialog
            {
                Description = "Seleccione la ubicacion de los archivos HTML a visualizar",
                RootFolder = Environment.SpecialFolder.MyComputer,
            };
            string dir;
            Fold.ShowDialog();
            dir = Fold.SelectedPath;
            try
            {
                if (dir != "")
                {
                    string[] files = Directory.GetFiles(dir, "*.html");
                    foreach (string Archivo in files)
                    {
                        ComboRes.Items.Add(Archivo);
                    }

                    MessageBox.Show("Se han cargado todos los archivos HTML \n encontrados en el directorio", "Archivos Cargados", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else 
                {
                    MessageBox.Show("No ha seleccionado un directorio valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void webBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}
