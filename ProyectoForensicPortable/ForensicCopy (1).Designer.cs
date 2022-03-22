namespace ProyectoForensicPortable
{
    partial class ForensicCopy
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForensicCopy));
            this.SelectionButton = new System.Windows.Forms.Button();
            this.RadioImag = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RadioAudio = new System.Windows.Forms.RadioButton();
            this.RadioDoc = new System.Windows.Forms.RadioButton();
            this.radiovid = new System.Windows.Forms.RadioButton();
            this.SelDirLabel = new System.Windows.Forms.Label();
            this.StartButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SelectAllButton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.PicturePreview = new System.Windows.Forms.PictureBox();
            this.ListboxLabel = new System.Windows.Forms.Label();
            this.PreviewLabel = new System.Windows.Forms.Label();
            this.UnselectAllButton = new System.Windows.Forms.Button();
            this.CopySelectedButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Label_File_Info = new System.Windows.Forms.Label();
            this.WMP = new AxWMPLib.AxWindowsMediaPlayer();
            this.statusInfo = new System.Windows.Forms.StatusStrip();
            this.StatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.DocViewer = new Spire.DocViewer.Forms.DocDocumentViewer();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.PDFViewer = new AxAcroPDFLib.AxAcroPDF();
            this.LabelDocs = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DestDriveLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicturePreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WMP)).BeginInit();
            this.statusInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PDFViewer)).BeginInit();
            this.SuspendLayout();
            // 
            // SelectionButton
            // 
            this.SelectionButton.Location = new System.Drawing.Point(12, 507);
            this.SelectionButton.Name = "SelectionButton";
            this.SelectionButton.Size = new System.Drawing.Size(132, 79);
            this.SelectionButton.TabIndex = 0;
            this.SelectionButton.Text = "Seleccione Unidad o Carpeta de Origen";
            this.SelectionButton.UseVisualStyleBackColor = true;
            this.SelectionButton.Click += new System.EventHandler(this.SelectionButton_Click);
            // 
            // RadioImag
            // 
            this.RadioImag.AutoSize = true;
            this.RadioImag.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioImag.Location = new System.Drawing.Point(6, 19);
            this.RadioImag.Name = "RadioImag";
            this.RadioImag.Size = new System.Drawing.Size(123, 20);
            this.RadioImag.TabIndex = 1;
            this.RadioImag.TabStop = true;
            this.RadioImag.Text = "Obtener Imagenes";
            this.RadioImag.UseVisualStyleBackColor = true;
            this.RadioImag.CheckedChanged += new System.EventHandler(this.RadioImag_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RadioAudio);
            this.groupBox1.Controls.Add(this.RadioDoc);
            this.groupBox1.Controls.Add(this.radiovid);
            this.groupBox1.Controls.Add(this.RadioImag);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(408, 242);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones de Captura";
            // 
            // RadioAudio
            // 
            this.RadioAudio.AutoSize = true;
            this.RadioAudio.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioAudio.Location = new System.Drawing.Point(6, 95);
            this.RadioAudio.Name = "RadioAudio";
            this.RadioAudio.Size = new System.Drawing.Size(104, 20);
            this.RadioAudio.TabIndex = 4;
            this.RadioAudio.TabStop = true;
            this.RadioAudio.Text = "Obtener Audio";
            this.RadioAudio.UseVisualStyleBackColor = true;
            this.RadioAudio.CheckedChanged += new System.EventHandler(this.RadioAudio_CheckedChanged);
            // 
            // RadioDoc
            // 
            this.RadioDoc.AutoSize = true;
            this.RadioDoc.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioDoc.Location = new System.Drawing.Point(6, 69);
            this.RadioDoc.Name = "RadioDoc";
            this.RadioDoc.Size = new System.Drawing.Size(140, 20);
            this.RadioDoc.TabIndex = 3;
            this.RadioDoc.TabStop = true;
            this.RadioDoc.Text = "Obtener Documentos";
            this.RadioDoc.UseVisualStyleBackColor = true;
            this.RadioDoc.CheckedChanged += new System.EventHandler(this.RadioDoc_CheckedChanged);
            // 
            // radiovid
            // 
            this.radiovid.AutoSize = true;
            this.radiovid.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiovid.Location = new System.Drawing.Point(6, 43);
            this.radiovid.Name = "radiovid";
            this.radiovid.Size = new System.Drawing.Size(107, 20);
            this.radiovid.TabIndex = 2;
            this.radiovid.TabStop = true;
            this.radiovid.Text = "Obtener Videos";
            this.radiovid.UseVisualStyleBackColor = true;
            this.radiovid.CheckedChanged += new System.EventHandler(this.radiovid_CheckedChanged);
            // 
            // SelDirLabel
            // 
            this.SelDirLabel.AutoSize = true;
            this.SelDirLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelDirLabel.Location = new System.Drawing.Point(9, 312);
            this.SelDirLabel.Name = "SelDirLabel";
            this.SelDirLabel.Size = new System.Drawing.Size(101, 16);
            this.SelDirLabel.TabIndex = 3;
            this.SelDirLabel.Text = "Source Drive Path";
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(150, 507);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(132, 79);
            this.StartButton.TabIndex = 4;
            this.StartButton.Text = "Iniciar Busqueda";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(288, 507);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(132, 79);
            this.ExitButton.TabIndex = 5;
            this.ExitButton.Text = "Salir";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 281);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Unidad / Directorio de Origen:";
            // 
            // SelectAllButton
            // 
            this.SelectAllButton.Location = new System.Drawing.Point(427, 542);
            this.SelectAllButton.Name = "SelectAllButton";
            this.SelectAllButton.Size = new System.Drawing.Size(106, 44);
            this.SelectAllButton.TabIndex = 9;
            this.SelectAllButton.Text = "Seleccionar Todos";
            this.SelectAllButton.UseVisualStyleBackColor = true;
            this.SelectAllButton.Click += new System.EventHandler(this.SelectAllButton_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.Location = new System.Drawing.Point(426, 38);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBox1.Size = new System.Drawing.Size(314, 498);
            this.listBox1.TabIndex = 11;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.ListBox1_SelectedIndexChanged);
            // 
            // PicturePreview
            // 
            this.PicturePreview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PicturePreview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PicturePreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PicturePreview.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PicturePreview.Location = new System.Drawing.Point(746, 38);
            this.PicturePreview.Name = "PicturePreview";
            this.PicturePreview.Size = new System.Drawing.Size(313, 290);
            this.PicturePreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicturePreview.TabIndex = 12;
            this.PicturePreview.TabStop = false;
            // 
            // ListboxLabel
            // 
            this.ListboxLabel.AutoSize = true;
            this.ListboxLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListboxLabel.Location = new System.Drawing.Point(427, 19);
            this.ListboxLabel.Name = "ListboxLabel";
            this.ListboxLabel.Size = new System.Drawing.Size(130, 16);
            this.ListboxLabel.TabIndex = 13;
            this.ListboxLabel.Text = "Archivos Encontrados:";
            // 
            // PreviewLabel
            // 
            this.PreviewLabel.AutoSize = true;
            this.PreviewLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PreviewLabel.Location = new System.Drawing.Point(746, 19);
            this.PreviewLabel.Name = "PreviewLabel";
            this.PreviewLabel.Size = new System.Drawing.Size(139, 16);
            this.PreviewLabel.TabIndex = 14;
            this.PreviewLabel.Text = "Vista Previa de Archivo:";
            // 
            // UnselectAllButton
            // 
            this.UnselectAllButton.Location = new System.Drawing.Point(539, 542);
            this.UnselectAllButton.Name = "UnselectAllButton";
            this.UnselectAllButton.Size = new System.Drawing.Size(106, 44);
            this.UnselectAllButton.TabIndex = 15;
            this.UnselectAllButton.Text = "Deseleccionar Todos";
            this.UnselectAllButton.UseVisualStyleBackColor = true;
            this.UnselectAllButton.Click += new System.EventHandler(this.UnselectAllButton_Click);
            // 
            // CopySelectedButton
            // 
            this.CopySelectedButton.Location = new System.Drawing.Point(746, 542);
            this.CopySelectedButton.Name = "CopySelectedButton";
            this.CopySelectedButton.Size = new System.Drawing.Size(106, 44);
            this.CopySelectedButton.TabIndex = 16;
            this.CopySelectedButton.Text = "Copiar seleccionados";
            this.CopySelectedButton.UseVisualStyleBackColor = true;
            this.CopySelectedButton.Click += new System.EventHandler(this.CopySelectedButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(746, 343);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Informacion de Archivo:";
            // 
            // Label_File_Info
            // 
            this.Label_File_Info.AutoSize = true;
            this.Label_File_Info.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_File_Info.Location = new System.Drawing.Point(743, 365);
            this.Label_File_Info.Name = "Label_File_Info";
            this.Label_File_Info.Size = new System.Drawing.Size(50, 16);
            this.Label_File_Info.TabIndex = 18;
            this.Label_File_Info.Text = "File Info";
            // 
            // WMP
            // 
            this.WMP.Enabled = true;
            this.WMP.Location = new System.Drawing.Point(746, 38);
            this.WMP.Name = "WMP";
            this.WMP.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WMP.OcxState")));
            this.WMP.Size = new System.Drawing.Size(313, 290);
            this.WMP.TabIndex = 19;
            this.WMP.Visible = false;
            // 
            // statusInfo
            // 
            this.statusInfo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel1,
            this.StatusLabel2,
            this.StatusProgressBar});
            this.statusInfo.Location = new System.Drawing.Point(0, 589);
            this.statusInfo.Name = "statusInfo";
            this.statusInfo.Size = new System.Drawing.Size(1388, 22);
            this.statusInfo.TabIndex = 20;
            this.statusInfo.Text = "statusStrip1";
            // 
            // StatusLabel1
            // 
            this.StatusLabel1.Name = "StatusLabel1";
            this.StatusLabel1.Size = new System.Drawing.Size(35, 17);
            this.StatusLabel1.Text = "Listo!";
            // 
            // StatusLabel2
            // 
            this.StatusLabel2.Name = "StatusLabel2";
            this.StatusLabel2.Size = new System.Drawing.Size(17, 17);
            this.StatusLabel2.Text = "--";
            // 
            // StatusProgressBar
            // 
            this.StatusProgressBar.Name = "StatusProgressBar";
            this.StatusProgressBar.Size = new System.Drawing.Size(100, 16);
            // 
            // DocViewer
            // 
            this.DocViewer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.DocViewer.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.DocViewer.EnableHandTools = false;
            this.DocViewer.Location = new System.Drawing.Point(1065, 38);
            this.DocViewer.Name = "DocViewer";
            this.DocViewer.Size = new System.Drawing.Size(313, 290);
            this.DocViewer.TabIndex = 21;
            this.DocViewer.Text = "docDocumentViewer1";
            this.DocViewer.ToPdfParameterList = null;
            this.DocViewer.ZoomMode = Spire.DocViewer.Forms.ZoomMode.FitPage;
            // 
            // PDFViewer
            // 
            this.PDFViewer.Enabled = true;
            this.PDFViewer.Location = new System.Drawing.Point(1065, 345);
            this.PDFViewer.Name = "PDFViewer";
            this.PDFViewer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("PDFViewer.OcxState")));
            this.PDFViewer.Size = new System.Drawing.Size(313, 241);
            this.PDFViewer.TabIndex = 22;
            // 
            // LabelDocs
            // 
            this.LabelDocs.AutoSize = true;
            this.LabelDocs.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDocs.Location = new System.Drawing.Point(1062, 19);
            this.LabelDocs.Name = "LabelDocs";
            this.LabelDocs.Size = new System.Drawing.Size(167, 16);
            this.LabelDocs.TabIndex = 23;
            this.LabelDocs.Text = "Vista Previa de Documentos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 343);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 16);
            this.label3.TabIndex = 24;
            this.label3.Text = "Unidad / Directorio de Destino:";
            // 
            // DestDriveLabel
            // 
            this.DestDriveLabel.AutoSize = true;
            this.DestDriveLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DestDriveLabel.Location = new System.Drawing.Point(9, 375);
            this.DestDriveLabel.Name = "DestDriveLabel";
            this.DestDriveLabel.Size = new System.Drawing.Size(125, 16);
            this.DestDriveLabel.TabIndex = 25;
            this.DestDriveLabel.Text = "Destination Drive Path";
            // 
            // ForensicCopy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1388, 611);
            this.Controls.Add(this.DestDriveLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LabelDocs);
            this.Controls.Add(this.PDFViewer);
            this.Controls.Add(this.DocViewer);
            this.Controls.Add(this.statusInfo);
            this.Controls.Add(this.WMP);
            this.Controls.Add(this.Label_File_Info);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CopySelectedButton);
            this.Controls.Add(this.UnselectAllButton);
            this.Controls.Add(this.PreviewLabel);
            this.Controls.Add(this.ListboxLabel);
            this.Controls.Add(this.PicturePreview);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.SelectAllButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.SelDirLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.SelectionButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ForensicCopy";
            this.Text = "Modulo de Copia Forense";
            this.Load += new System.EventHandler(this.CopiaForense_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicturePreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WMP)).EndInit();
            this.statusInfo.ResumeLayout(false);
            this.statusInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PDFViewer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SelectionButton;
        private System.Windows.Forms.RadioButton RadioImag;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RadioAudio;
        private System.Windows.Forms.RadioButton RadioDoc;
        private System.Windows.Forms.RadioButton radiovid;
        private System.Windows.Forms.Label SelDirLabel;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SelectAllButton;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.PictureBox PicturePreview;
        private System.Windows.Forms.Label ListboxLabel;
        private System.Windows.Forms.Label PreviewLabel;
        private System.Windows.Forms.Button UnselectAllButton;
        private System.Windows.Forms.Button CopySelectedButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Label_File_Info;
        private AxWMPLib.AxWindowsMediaPlayer WMP;
        private System.Windows.Forms.StatusStrip statusInfo;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel2;
        private System.Windows.Forms.ToolStripProgressBar StatusProgressBar;
        private Spire.DocViewer.Forms.DocDocumentViewer DocViewer;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private AxAcroPDFLib.AxAcroPDF PDFViewer;
        private System.Windows.Forms.Label LabelDocs;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label DestDriveLabel;
    }
}