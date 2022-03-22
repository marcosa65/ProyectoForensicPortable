namespace ProyectoForensicPortable
{
    partial class SysInfo
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.StartButton = new System.Windows.Forms.Button();
            this.NombrePCLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NombreUsLabel = new System.Windows.Forms.Label();
            this.VersionSOLabel = new System.Windows.Forms.Label();
            this.CantProcLabel = new System.Windows.Forms.Label();
            this.DirSisLabel = new System.Windows.Forms.Label();
            this.HTMLViewerButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CheckUSBConections = new System.Windows.Forms.CheckBox();
            this.CheckWifiPass = new System.Windows.Forms.CheckBox();
            this.checkOpenSave = new System.Windows.Forms.CheckBox();
            this.CheckLastSearches = new System.Windows.Forms.CheckBox();
            this.CheckUserAct = new System.Windows.Forms.CheckBox();
            this.checkPassWeb = new System.Windows.Forms.CheckBox();
            this.checkHistNav = new System.Windows.Forms.CheckBox();
            this.labelDiscos = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.ExitButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartButton.ForeColor = System.Drawing.Color.Black;
            this.StartButton.Location = new System.Drawing.Point(12, 354);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(165, 70);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Iniciar Captura de Datos";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // NombrePCLabel
            // 
            this.NombrePCLabel.AutoSize = true;
            this.NombrePCLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombrePCLabel.ForeColor = System.Drawing.Color.White;
            this.NombrePCLabel.Location = new System.Drawing.Point(366, 65);
            this.NombrePCLabel.Name = "NombrePCLabel";
            this.NombrePCLabel.Size = new System.Drawing.Size(129, 19);
            this.NombrePCLabel.TabIndex = 5;
            this.NombrePCLabel.Text = "Nombre Maquina:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(366, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "Informacion General del Sistema";
            // 
            // NombreUsLabel
            // 
            this.NombreUsLabel.AutoSize = true;
            this.NombreUsLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreUsLabel.ForeColor = System.Drawing.Color.White;
            this.NombreUsLabel.Location = new System.Drawing.Point(366, 117);
            this.NombreUsLabel.Name = "NombreUsLabel";
            this.NombreUsLabel.Size = new System.Drawing.Size(121, 19);
            this.NombreUsLabel.TabIndex = 10;
            this.NombreUsLabel.Text = "Nombre Usuario:";
            // 
            // VersionSOLabel
            // 
            this.VersionSOLabel.AutoSize = true;
            this.VersionSOLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VersionSOLabel.ForeColor = System.Drawing.Color.White;
            this.VersionSOLabel.Location = new System.Drawing.Point(366, 165);
            this.VersionSOLabel.Name = "VersionSOLabel";
            this.VersionSOLabel.Size = new System.Drawing.Size(187, 19);
            this.VersionSOLabel.TabIndex = 11;
            this.VersionSOLabel.Text = "Version Sistema Operativo:";
            // 
            // CantProcLabel
            // 
            this.CantProcLabel.AutoSize = true;
            this.CantProcLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CantProcLabel.ForeColor = System.Drawing.Color.White;
            this.CantProcLabel.Location = new System.Drawing.Point(366, 215);
            this.CantProcLabel.Name = "CantProcLabel";
            this.CantProcLabel.Size = new System.Drawing.Size(185, 19);
            this.CantProcLabel.TabIndex = 12;
            this.CantProcLabel.Text = "Cantidad de Procesadores:";
            // 
            // DirSisLabel
            // 
            this.DirSisLabel.AutoSize = true;
            this.DirSisLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DirSisLabel.ForeColor = System.Drawing.Color.White;
            this.DirSisLabel.Location = new System.Drawing.Point(366, 266);
            this.DirSisLabel.Name = "DirSisLabel";
            this.DirSisLabel.Size = new System.Drawing.Size(139, 19);
            this.DirSisLabel.TabIndex = 13;
            this.DirSisLabel.Text = "Carpeta de sistema:";
            // 
            // HTMLViewerButton
            // 
            this.HTMLViewerButton.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HTMLViewerButton.ForeColor = System.Drawing.Color.Black;
            this.HTMLViewerButton.Location = new System.Drawing.Point(183, 354);
            this.HTMLViewerButton.Name = "HTMLViewerButton";
            this.HTMLViewerButton.Size = new System.Drawing.Size(166, 70);
            this.HTMLViewerButton.TabIndex = 14;
            this.HTMLViewerButton.Text = "Ver Resultados";
            this.HTMLViewerButton.UseVisualStyleBackColor = true;
            this.HTMLViewerButton.Click += new System.EventHandler(this.HTMLViewer_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(114)))), ((int)(((byte)(169)))));
            this.groupBox1.Controls.Add(this.CheckUSBConections);
            this.groupBox1.Controls.Add(this.CheckWifiPass);
            this.groupBox1.Controls.Add(this.checkOpenSave);
            this.groupBox1.Controls.Add(this.CheckLastSearches);
            this.groupBox1.Controls.Add(this.CheckUserAct);
            this.groupBox1.Controls.Add(this.checkPassWeb);
            this.groupBox1.Controls.Add(this.checkHistNav);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(337, 309);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione Datos del Sistema";
            // 
            // CheckUSBConections
            // 
            this.CheckUSBConections.AutoSize = true;
            this.CheckUSBConections.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckUSBConections.Location = new System.Drawing.Point(6, 170);
            this.CheckUSBConections.Name = "CheckUSBConections";
            this.CheckUSBConections.Size = new System.Drawing.Size(179, 20);
            this.CheckUSBConections.TabIndex = 6;
            this.CheckUSBConections.Text = "Unidades USB conectadas";
            this.CheckUSBConections.UseVisualStyleBackColor = true;
            // 
            // CheckWifiPass
            // 
            this.CheckWifiPass.AutoSize = true;
            this.CheckWifiPass.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckWifiPass.Location = new System.Drawing.Point(5, 144);
            this.CheckWifiPass.Name = "CheckWifiPass";
            this.CheckWifiPass.Size = new System.Drawing.Size(243, 20);
            this.CheckWifiPass.TabIndex = 5;
            this.CheckWifiPass.Text = "Redes Wifi conectadas y contraseñas";
            this.CheckWifiPass.UseVisualStyleBackColor = true;
            // 
            // checkOpenSave
            // 
            this.checkOpenSave.AutoSize = true;
            this.checkOpenSave.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkOpenSave.Location = new System.Drawing.Point(5, 118);
            this.checkOpenSave.Name = "checkOpenSave";
            this.checkOpenSave.Size = new System.Drawing.Size(294, 20);
            this.checkOpenSave.TabIndex = 4;
            this.checkOpenSave.Text = "Ultimos Archivos abiertos creados o editados";
            this.checkOpenSave.UseVisualStyleBackColor = true;
            // 
            // CheckLastSearches
            // 
            this.CheckLastSearches.AutoSize = true;
            this.CheckLastSearches.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckLastSearches.Location = new System.Drawing.Point(5, 95);
            this.CheckLastSearches.Name = "CheckLastSearches";
            this.CheckLastSearches.Size = new System.Drawing.Size(201, 20);
            this.CheckLastSearches.TabIndex = 3;
            this.CheckLastSearches.Text = "Ultimas busquedas realizadas";
            this.CheckLastSearches.UseVisualStyleBackColor = true;
            // 
            // CheckUserAct
            // 
            this.CheckUserAct.AutoSize = true;
            this.CheckUserAct.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckUserAct.Location = new System.Drawing.Point(6, 72);
            this.CheckUserAct.Name = "CheckUserAct";
            this.CheckUserAct.Size = new System.Drawing.Size(181, 20);
            this.CheckUserAct.TabIndex = 2;
            this.CheckUserAct.Text = "Historial Actividad Usuario";
            this.CheckUserAct.UseVisualStyleBackColor = true;
            // 
            // checkPassWeb
            // 
            this.checkPassWeb.AutoSize = true;
            this.checkPassWeb.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkPassWeb.Location = new System.Drawing.Point(6, 49);
            this.checkPassWeb.Name = "checkPassWeb";
            this.checkPassWeb.Size = new System.Drawing.Size(180, 20);
            this.checkPassWeb.TabIndex = 1;
            this.checkPassWeb.Text = "Contraseñas Almacenadas";
            this.checkPassWeb.UseVisualStyleBackColor = true;
            // 
            // checkHistNav
            // 
            this.checkHistNav.AutoSize = true;
            this.checkHistNav.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkHistNav.Location = new System.Drawing.Point(6, 26);
            this.checkHistNav.Name = "checkHistNav";
            this.checkHistNav.Size = new System.Drawing.Size(188, 20);
            this.checkHistNav.TabIndex = 0;
            this.checkHistNav.Text = "Historial Navegadores WEB";
            this.checkHistNav.UseVisualStyleBackColor = true;
            // 
            // labelDiscos
            // 
            this.labelDiscos.AutoSize = true;
            this.labelDiscos.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDiscos.ForeColor = System.Drawing.Color.White;
            this.labelDiscos.Location = new System.Drawing.Point(366, 314);
            this.labelDiscos.Name = "labelDiscos";
            this.labelDiscos.Size = new System.Drawing.Size(110, 19);
            this.labelDiscos.TabIndex = 16;
            this.labelDiscos.Text = "Discos Logicos:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(114)))), ((int)(((byte)(169)))));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel1,
            this.StatusProgressBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 439);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(829, 22);
            this.statusStrip1.TabIndex = 18;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StatusLabel1
            // 
            this.StatusLabel1.Name = "StatusLabel1";
            this.StatusLabel1.Size = new System.Drawing.Size(57, 17);
            this.StatusLabel1.Text = "En espera";
            // 
            // StatusProgressBar
            // 
            this.StatusProgressBar.Name = "StatusProgressBar";
            this.StatusProgressBar.Size = new System.Drawing.Size(100, 16);
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.ForeColor = System.Drawing.Color.Black;
            this.ExitButton.Location = new System.Drawing.Point(355, 354);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(166, 70);
            this.ExitButton.TabIndex = 19;
            this.ExitButton.Text = "Salir";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // SysInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(50)))), ((int)(((byte)(119)))));
            this.ClientSize = new System.Drawing.Size(829, 461);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.labelDiscos);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.HTMLViewerButton);
            this.Controls.Add(this.DirSisLabel);
            this.Controls.Add(this.CantProcLabel);
            this.Controls.Add(this.VersionSOLabel);
            this.Controls.Add(this.NombreUsLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NombrePCLabel);
            this.Controls.Add(this.StartButton);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "SysInfo";
            this.Text = "Portable Forensic ";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Label NombrePCLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label NombreUsLabel;
        private System.Windows.Forms.Label VersionSOLabel;
        private System.Windows.Forms.Label CantProcLabel;
        private System.Windows.Forms.Label DirSisLabel;
        private System.Windows.Forms.Button HTMLViewerButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkHistNav;
        private System.Windows.Forms.CheckBox checkPassWeb;
        private System.Windows.Forms.CheckBox CheckUserAct;
        private System.Windows.Forms.CheckBox CheckLastSearches;
        private System.Windows.Forms.CheckBox checkOpenSave;
        private System.Windows.Forms.Label labelDiscos;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel1;
        private System.Windows.Forms.ToolStripProgressBar StatusProgressBar;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.CheckBox CheckUSBConections;
        private System.Windows.Forms.CheckBox CheckWifiPass;
    }
}

