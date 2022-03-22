
namespace ProyectoForensicPortable
{
    partial class Main
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
            this.SisInfoButton = new System.Windows.Forms.Button();
            this.HTMLViewer = new System.Windows.Forms.Button();
            this.FCButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.DriveSelectionButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // SisInfoButton
            // 
            this.SisInfoButton.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SisInfoButton.ForeColor = System.Drawing.Color.Black;
            this.SisInfoButton.Location = new System.Drawing.Point(66, 77);
            this.SisInfoButton.Name = "SisInfoButton";
            this.SisInfoButton.Size = new System.Drawing.Size(159, 75);
            this.SisInfoButton.TabIndex = 0;
            this.SisInfoButton.Text = "Recuperar Informacion del Sistema";
            this.SisInfoButton.UseVisualStyleBackColor = true;
            this.SisInfoButton.Click += new System.EventHandler(this.SisInfoButton_Click);
            // 
            // HTMLViewer
            // 
            this.HTMLViewer.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HTMLViewer.ForeColor = System.Drawing.Color.Black;
            this.HTMLViewer.Location = new System.Drawing.Point(260, 77);
            this.HTMLViewer.Name = "HTMLViewer";
            this.HTMLViewer.Size = new System.Drawing.Size(159, 75);
            this.HTMLViewer.TabIndex = 1;
            this.HTMLViewer.Text = "Visualizar HTML";
            this.HTMLViewer.UseVisualStyleBackColor = true;
            this.HTMLViewer.Click += new System.EventHandler(this.HTMLViewer_Click);
            // 
            // FCButton
            // 
            this.FCButton.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FCButton.ForeColor = System.Drawing.Color.Black;
            this.FCButton.Location = new System.Drawing.Point(446, 77);
            this.FCButton.Name = "FCButton";
            this.FCButton.Size = new System.Drawing.Size(159, 75);
            this.FCButton.TabIndex = 2;
            this.FCButton.Text = "Copia Forense de Archivos";
            this.FCButton.UseVisualStyleBackColor = true;
            this.FCButton.Click += new System.EventHandler(this.FCButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.ForeColor = System.Drawing.Color.Black;
            this.ExitButton.Location = new System.Drawing.Point(389, 63);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(159, 69);
            this.ExitButton.TabIndex = 3;
            this.ExitButton.Text = "Salir";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // DriveSelectionButton
            // 
            this.DriveSelectionButton.ForeColor = System.Drawing.Color.Black;
            this.DriveSelectionButton.Location = new System.Drawing.Point(138, 62);
            this.DriveSelectionButton.Name = "DriveSelectionButton";
            this.DriveSelectionButton.Size = new System.Drawing.Size(159, 69);
            this.DriveSelectionButton.TabIndex = 4;
            this.DriveSelectionButton.Text = "Seleccionar";
            this.DriveSelectionButton.UseVisualStyleBackColor = true;
            this.DriveSelectionButton.Click += new System.EventHandler(this.DriveSelectionButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(114)))), ((int)(((byte)(169)))));
            this.groupBox1.Controls.Add(this.DriveSelectionButton);
            this.groupBox1.Controls.Add(this.ExitButton);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(661, 198);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "1 - Seleccione una Carpeta de Destino";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(114)))), ((int)(((byte)(169)))));
            this.groupBox2.Controls.Add(this.FCButton);
            this.groupBox2.Controls.Add(this.SisInfoButton);
            this.groupBox2.Controls.Add(this.HTMLViewer);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(12, 223);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(661, 226);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "2 - Recupere Datos del Sistema";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(50)))), ((int)(((byte)(119)))));
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MinimumSize = new System.Drawing.Size(700, 500);
            this.Name = "Main";
            this.Text = "Main";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.On_Closing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.On_Closed);
            this.Load += new System.EventHandler(this.Main_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SisInfoButton;
        private System.Windows.Forms.Button HTMLViewer;
        private System.Windows.Forms.Button FCButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button DriveSelectionButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}