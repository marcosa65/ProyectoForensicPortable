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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void HTMLViewer_Click(object sender, EventArgs e)
        {
            HTMLViewer View = new HTMLViewer
            { 
                TopMost = true 
            };
            View.Show();
        }

        private void SisInfoButton_Click(object sender, EventArgs e)
        {
            if (Globals.DestDrive == "")
            {
                MessageBox.Show("Debe seleccionar un Directorio de Destino \n para generar los reportes de la PC a analizar","Advertencia", 
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                SysInfo Sys = new SysInfo
                {
                    TopMost = true
                };
                Sys.Show();
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            try
            {
                string Agency = File.ReadAllText(@".\res/agency.txt");
                Globals.AppIcon = new System.Drawing.Icon(@".\res/logo.ico");
                Globals.Agency = Agency;
                this.Text = "Forensic Portable - " + Globals.Agency;
                this.Icon = Globals.AppIcon;

            }
            catch (FileNotFoundException ex_1)
            {
                MessageBox.Show(ex_1.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex_2) 
            {
                MessageBox.Show(ex_2.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            };
        }

        private void DriveSelectionButton_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog Fold = new FolderBrowserDialog
                {
                    Description = "Seleccione Carpeta para guardar resultados",
                    RootFolder = Environment.SpecialFolder.MyComputer
        
                };
                Fold.ShowDialog();
                if (Fold.SelectedPath == "")
                {
                    MessageBox.Show("Debe seleccionar un directorio valido de trabajo", "Directorio Invalido", 
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                Globals.DestDrive = Fold.SelectedPath;
                string folder = Globals.DestDrive + "/" + Environment.MachineName;
                if (!Directory.Exists(folder))
                {
                    Directory.CreateDirectory(folder);
                }
                
                Globals.DestDrive = folder;
                MessageBox.Show("El directorio destino se ha establecido en: " + Globals.DestDrive, "Directorio Establecido", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (IOException ex_1) 
            {
                MessageBox.Show(ex_1.Message, "No se puede crear la carpeta", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FCButton_Click(object sender, EventArgs e)
        {
            if (Globals.DestDrive == "")
            {
                MessageBox.Show("Debe seleccionar un Directorio de Destino \n para la copia Forense de Datos", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                ForensicCopy FC = new ForensicCopy
                {
                    TopMost = true
                };
                FC.Show();
            }
        }

        // Salgo de la aplicacion
        private void On_Closed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        // Prevengo al usuario que se esta por cerrar toda la aplicacion y no solo la ventana
        private void On_Closing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Esto cerrara todas las ventanas relacionada al proyecto,\n esta seguro?",
                "Desea Salir?",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if ( dialog == DialogResult.No) 
            {
                e.Cancel = true;
            }
            else if (dialog == DialogResult.Yes)
            {
                e.Cancel = false;
            }
        }
    }

    // Clase estatica no instanciable que se usa en toda la aplicacion conteniendo variables "Globales"
    public static class Globals
    {
        public static string DestDrive = "";
        public static string ExpNum = "";
        public static System.Drawing.Icon AppIcon;
        public static string Agency = "";
    }

}
