using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.Windows.Forms;
using System.Management;
using System.Collections;
using System.Runtime.InteropServices;
using System.IO;

namespace ProyectoForensicPortable
{
    
    public partial class SysInfo : Form
    {
        private string cParams1;
        private string cParams1CSV;
        private string cParams2;
        private string cParams2CSV;
        private string cParams3;
        private string cParams3CSV;
        private string cParams4;
        private string cParams4CSV;
        private string cParams5;
        private string cParams5CSV;
        private string cParams6;
        private string cParams6CSV;
        private string cParams7;
        private string cParams7CSV;
        private string folder;
           
        // Inicializa el formulario
        public SysInfo()
        {
            InitializeComponent();
        }
       
        // aqui manejo el click del boton y hago tal tal tal cosa
        private void StartButton_Click(object sender, EventArgs e)
        {
            //Itero sobre los controles check para ver si alguno esta seleccionado
            int checknum = 0;
            if (checkHistNav.Checked || checkPassWeb.Checked || 
                CheckUserAct.Checked || checkOpenSave.Checked || 
                CheckLastSearches.Checked || CheckWifiPass.Checked || 
                CheckUSBConections.Checked) 
            { 
                checknum += 1; 
            }

            if (checknum == 0) 
            {
                MessageBox.Show("No selecciono ninguna opcion", "Atencion",MessageBoxButtons.OK , MessageBoxIcon.Exclamation );
                return;
            }
            
            //Parametros para cada ejecutable
            cParams1 = "/shtml " + "\"" + folder + "/PasswordNav.html\"";
            cParams1CSV = "/scomma " + "\"" + folder + "/PasswordNav.csv\"";
            cParams2 = "/shtml " + "\"" + folder + "/HistorialNav.html\"";
            cParams2CSV = "/scomma " + "\"" + folder + "/HistorialNav.csv\"";
            cParams3 = "/shtml " + "\"" + folder + "/UltimasAct.html\"";
            cParams3CSV = "/scomma " + "\"" + folder + "/UltimasAct.csv\"";
            cParams4 = "/shtml " + "\"" + folder + "/UltimasBusquedas.html\"";
            cParams4CSV = "/scomma " + "\"" + folder + "/UltimasBusquedas.csv\"";
            cParams5 = "/shtml " + "\"" + folder + "/ArchivosAbiertos.html\"";
            cParams5CSV = "/scomma " + "\"" + folder + "/ArchivosAbiertos.csv\"";
            cParams6 = "/shtml " + "\"" + folder + "/WifiPassword.html\"";
            cParams6CSV = "/scomma " + "\"" + folder + "/WifiPassword.csv\"";
            cParams7 = "/shtml " + "\"" + folder + "/USBConectados.html\"";
            cParams7CSV = "/scomma " + "\"" + folder + "/USBConcetados.csv\"";

            //Asigno las aplicaciones a ejecutar para cada proceso
            string path_1 = @".\tools/WebBrowserPassView.exe";
            string path_2 = @".\tools/BrowsingHistoryView.exe";
            string path_3 = @".\tools/LastActivityView.exe";
            string path_4 = @".\tools/MyLastSearch.exe";
            string path_5 = @".\tools/OpenedFilesView.exe";
            string path_6 = @".\tools/WirelessKeyView.exe";
            string path_7 = @".\tools/USBDeview.exe";

            ProcessStartInfo startInfo1 = new ProcessStartInfo(path_1);
            ProcessStartInfo startInfo2 = new ProcessStartInfo(path_2);
            ProcessStartInfo startInfo3 = new ProcessStartInfo(path_3);
            ProcessStartInfo startInfo4 = new ProcessStartInfo(path_4);
            ProcessStartInfo startInfo5 = new ProcessStartInfo(path_5);
            ProcessStartInfo startInfo6 = new ProcessStartInfo(path_6);
            ProcessStartInfo startInfo7 = new ProcessStartInfo(path_7);

            StatusLabel1.Text = "Procesando.......";
            StatusProgressBar.Value = 10;
            startInfo1.Arguments = cParams1;
            if (checkPassWeb.Checked) Process.Start(startInfo1);
            startInfo1.Arguments = cParams1CSV;
            if (checkPassWeb.Checked) Process.Start(startInfo1);
            StatusProgressBar.Value = 15;
            startInfo2.Arguments = cParams2;
            if (checkHistNav.Checked) Process.Start(startInfo2);
            startInfo2.Arguments = cParams2CSV;
            if (checkHistNav.Checked) Process.Start(startInfo2);
            StatusProgressBar.Value = 25;
            startInfo3.Arguments = cParams3;
            if (CheckUserAct.Checked) Process.Start(startInfo3);
            startInfo3.Arguments = cParams3CSV;
            if (CheckUserAct.Checked) Process.Start(startInfo3);
            StatusProgressBar.Value = 45;
            startInfo4.Arguments = cParams4;
            if (CheckLastSearches.Checked) Process.Start(startInfo4);
            startInfo4.Arguments = cParams4CSV;
            if (CheckLastSearches.Checked) Process.Start(startInfo4);
            StatusProgressBar.Value = 65;
            startInfo5.Arguments = cParams5;
            if (checkOpenSave.Checked) Process.Start(startInfo5);
            startInfo5.Arguments = cParams5CSV;
            if (checkOpenSave.Checked) Process.Start(startInfo5);
            StatusProgressBar.Value = 75;
            startInfo6.Arguments = cParams6;
            if (CheckWifiPass.Checked) Process.Start(startInfo6);
            startInfo6.Arguments = cParams6CSV;
            if (CheckWifiPass.Checked) Process.Start(startInfo6);
            StatusProgressBar.Value = 85;
            startInfo7.Arguments = cParams7;
            if (CheckUSBConections.Checked) Process.Start(startInfo7);
            startInfo7.Arguments = cParams7CSV;
            if (CheckUSBConections.Checked) Process.Start(startInfo7);
            StatusProgressBar.Value = 100;
            MessageBox.Show("Informacion Recopilada","Listo!",MessageBoxButtons.OK,MessageBoxIcon.Information);
            StatusLabel1.Text = "Listo!!";
            StartTimerOnce(2000,1);
            
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            try
            {
                this.folder = Globals.DestDrive + "/Reportes_HTML";
                if (!Directory.Exists(folder)) Directory.CreateDirectory(folder);
                this.Text = "Forensic Copy - " + Globals.Agency;
                this.Icon = Globals.AppIcon;
                NombrePCLabel.Text += " " + Environment.MachineName;
                NombreUsLabel.Text += " " + Environment.UserName;
                VersionSOLabel.Text += " " + Environment.OSVersion;
                CantProcLabel.Text += " " + Environment.ProcessorCount;
                DirSisLabel.Text += " " + Environment.SystemDirectory;
                foreach (string x in Environment.GetLogicalDrives())
                {
                    labelDiscos.Text += " " + x;
                }
            }
            catch (FileNotFoundException  ex_1)
            {
                MessageBox.Show(ex_1.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (IOException ex_2)
            {
                MessageBox.Show(ex_2.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
         }

        
        void StartTimerOnce(int interval, int action)
        {
            Timer tmrOnce = new Timer();
            if (action == 1)
            {
                tmrOnce.Tick += Action_1_tick;
            }
            else if (action == 2)
            {
                tmrOnce.Tick += Action_2_tick;
            }
            tmrOnce.Interval = interval;
            tmrOnce.Start();
        }

        //evento timer
        void Action_1_tick(object sender, EventArgs e)
        {
            //accion 1
            StatusLabel1.Text = "En espera ";
            StatusProgressBar.Value = 0;
            ((Timer)sender).Dispose();
        }

        //evento timer
        void Action_2_tick(object sender, EventArgs e)
        {
            //accion 2 
            StatusLabel1.Text = "En espera ";
            StatusProgressBar.Value = 0;
            ((Timer)sender).Dispose();
        }

        private void HTMLViewer_Click(object sender, EventArgs e)
        {
            HTMLViewer Res = new HTMLViewer
            {
                TopMost = true
            };
            Res.Show();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
