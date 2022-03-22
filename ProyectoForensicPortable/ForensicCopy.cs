using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections;
using System.Windows.Threading;

namespace ProyectoForensicPortable
{

    public partial class ForensicCopy : Form
    {
        
        String WorkingDir = "";
        string SearchTypes = "";
        FileInfo MyFile;
        int TotalFilesCopied = 0;
        string Fold = "";
       
        public ForensicCopy()
        {
            InitializeComponent();
        }

        private void SelectionButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog Dialog = new FolderBrowserDialog
            {
                Description = "Seleccione carpeta o unidad para realizar la busqueda",
                RootFolder = Environment.SpecialFolder.MyComputer
            };
            try
            {
                if (Dialog.ShowDialog() == DialogResult.OK)
                {
                    WorkingDir = Dialog.SelectedPath;
                    SelDirLabel.Text = WorkingDir;
                }
                else
                {
                    MessageBox.Show("Ha seleccionado una unidad o directorio invalido", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message, "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void CopiaForense_Load(object sender, EventArgs e)
        {
            
            Fold = Globals.DestDrive + "/Archivos";
            try
            {
                if (!Directory.Exists(Fold))
                {
                    Directory.CreateDirectory(Fold);
                }

                DestDriveLabel.Text = Fold;
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message, "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private void StartButton_Click(object sender, EventArgs e)
        {
            Enable_Controls(false);

            if (listBox1.Items.Count > 0)
            {
                listBox1.Items.Clear();
            }

            if (SearchTypes == "")
            {
                MessageBox.Show("No selecciono ningun tipo de documento", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string Filtro = SearchTypes;
            List<string> result;
            result = DirSearch(WorkingDir,Filtro);
            StatusLabel1.Text = "Busqueda Comenzada";
            StatusLabel2.Text = "--";
            StatusProgressBar.Value = 50;
            
            foreach (string file in result)
            {
                listBox1.Items.Add(file);
            }

            StatusLabel1.Text = "Operacion completada";
            StatusProgressBar.Value = 100;
            Enable_Controls(true);
        }

        //busqueda recursiva de directorios
        private List<string> DirSearch(string sDir,string filtro)
        {
            List<string> files = new List<string>();
            try
            {
                string[] filtros = filtro.Split('|');
                //busqueda por cada tipo de archivo
                foreach (string val in filtros){
                    foreach (string f in Directory.GetFiles(sDir, val))
                    {
                        files.Add(f);
                    }
                   
                }
                foreach (string d in Directory.GetDirectories(sDir))
                {
                    files.AddRange(DirSearch(d,filtro));
                }
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
           return files;
        }


        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
            {
                return;
            }

            //contenido segun lo que se selecciona en los radiobuttons
            if (RadioImag.Checked)
            {
                PicturePreview.ImageLocation = listBox1.SelectedItem.ToString();
                PicturePreview.Refresh();
            }
            else if (radiovid.Checked)
            {
                WMP.URL = listBox1.SelectedItem.ToString();
                WMP.Refresh();
            }
            else if (RadioDoc.Checked)
            {
                string file = listBox1.SelectedItem.ToString();

                if (file.Contains(".doc") || file.Contains(".docx") || file.Contains(".txt"))
                {
                    DocViewer.LoadFromFile(file);
                    DocViewer.Refresh();
                }
                else if (file.Contains(".pdf")) 
                {
                    pdfViewer.LoadFromFile(file);
                    pdfViewer.Refresh();
                }

            }
            else if (RadioAudio.Checked)
            {
                WMP.URL = listBox1.SelectedItem.ToString();
                WMP.Refresh();
            }
            
            //reuno informacion de cada archivo
            if (listBox1.SelectedItem == null) 
            {
                return;
            }
            MyFile = new FileInfo(listBox1.SelectedItem.ToString());
            Label_File_Info.Text = "Nombre de archivo: " + "\n" + MyFile.Name + "\n" +
                "Ubicacion: " + "\n" + MyFile.DirectoryName + "\n" +"Tipo de archivo: " +
                MyFile.Extension + "\n" + "Tamaño: " + MyFile.Length / 1024 + " KB" + "\n" + 
                "Fecha de Creacion: " + MyFile.CreationTime + "\n " + "Fecha de Modificacion " + 
                MyFile.LastWriteTime + "\n" + "Ultimo acceso: " + MyFile.LastAccessTime;

            //obtengo tamaño en KB de los archivos actualmente seleccionados
            ListBox.SelectedObjectCollection SelectedItems = listBox1.SelectedItems;
            long SizeCounter = 0;
            foreach (string item in SelectedItems) 
            {
                SizeCounter += new FileInfo(item).Length;
            }
            StatusLabel1.Text = "Selected FileSize: ";
            StatusLabel2.Text = (SizeCounter / 1024).ToString() + " KB";
        }

        
        private void radiovid_CheckedChanged(object sender, EventArgs e)
        {
            if (radiovid.Checked)
            {
                SearchTypes = "*.mp4|*.mov|*.wmv|*.avi|*.mkv|*.flv|*.f4v|*.swf";
                StatusLabel1.Text = "Se selecciono: Videos";
                StatusLabel2.Text = SearchTypes.Replace('|', ' ');
                PicturePreview.Visible = false;
                WMP.Visible = true;
            }
        }

        
        private void RadioImag_CheckedChanged(object sender, EventArgs e)
        {

            if (RadioImag.Checked)
            {
                
                SearchTypes = "*.jpg|*.jpeg|*.png|*.gif|*.raw|*.cr2|*.nef|*.tif|*.tiff|*.hdr";
                StatusLabel1.Text = "Se selecciono: Imagenes";
                StatusLabel2.Text = SearchTypes.Replace('|', ' ');
                PicturePreview.Visible = true;
                WMP.Visible = false;
            
            }
        }

        
        private void RadioDoc_CheckedChanged(object sender, EventArgs e)
        {
            
            SearchTypes = "*.doc|*.txt|*.pdf|*.htm|*.ppt|*.xls";
            StatusLabel1.Text = "Se selecciono: Documentos";
            StatusLabel2.Text = SearchTypes.Replace('|', ' ');
            
        }

        
        private void RadioAudio_CheckedChanged(object sender, EventArgs e)
        {
            SearchTypes = "*.m4a|*.ogg|*.mp3|*.flac|*.wav|*.wma|*.acc|*.alac|*.aif";
            StatusLabel1.Text = "Se selecciono: Audios";
            StatusLabel2.Text = SearchTypes.Replace('|', ' ');
            PicturePreview.Visible = false;
            WMP.Visible = true;
        }

        
        private void SelectAllButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                listBox1.SetSelected(i, true);
            }
        }


        private void UnselectAllButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                listBox1.SetSelected(i, false);
            }
        }

        //Operacion de copia forense usando ROBOCOPY se mantienen los timestamps originales de los archivos y la informacion de  
        private void CopySelectedButton_Click(object sender, EventArgs e)
        {
            Enable_Controls(false);
            ListBox.SelectedObjectCollection obj = listBox1.SelectedItems;
            int filetotal = listBox1.SelectedItems.Count;
            int filecount = 0;
            TotalFilesCopied = 0;
            StatusLabel1.Text = "Copiando archivos Seleccionados";
            StatusLabel2.Text = "0 % Completado";
            StatusProgressBar.Value = 0;
            foreach (string i in obj)
            {
                FileInfo File = new FileInfo(i);
                Process p = new Process(); 
                p.StartInfo.FileName = @".\tools/Robocopy.exe";
                p.StartInfo.Arguments = " \"" + File.DirectoryName + "\" \"" + 
                    Fold + "\" \"" + File.Name + "\" /zb /copy:dat /r:0 /w:0 /fp /np /LOG+:" + 
                    Fold + "/copy_data.log";
                p.StartInfo.CreateNoWindow = true;
                p.StartInfo.UseShellExecute = false;
                p.Start();
                p.WaitForExit();
                filecount += 1;
                StatusProgressBar.Value = (filecount * 100)/filetotal;
                StatusLabel2.Text = StatusProgressBar.Value.ToString() + "% Completado";
                Console.WriteLine(filecount + " " + p.StartInfo.Arguments);
            }
            TotalFilesCopied = filecount;
            StartTimerOnce(2000, 1);
            StartTimerOnce(5000, 2);
            Enable_Controls(true);
        }

        // Objeto timer para llamar acciones que suceden en un intervalo determinado
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

        // Conjunto de acciones o subprocesos que puede llamar el evento timer
        void Action_1_tick(object sender, EventArgs e)
        {
            //accion 1
            StatusLabel1.Text = "Operacion Completada ";
            StatusLabel2.Text = "Se copiaron " + TotalFilesCopied + " Archivos";
            StatusProgressBar.Value = 0;
            ((Timer)sender).Dispose();
        }

        void Action_2_tick(object sender, EventArgs e)
        {
            //accion 2 
            StatusLabel1.Text = "Listo ";
            StatusLabel2.Text = "--";
            StatusProgressBar.Value = 0;
            ((Timer)sender).Dispose();
        }

        private void Enable_Controls(bool value)
        {
            foreach (Control c in this.Controls)
            {
                if (c is RadioButton || c is Button) c.Enabled = value;
            }
        }
    
    }
}
    


