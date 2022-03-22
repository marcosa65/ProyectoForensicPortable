namespace ProyectoForensicPortable
{
    partial class HTMLViewer
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.SelectButton = new System.Windows.Forms.Button();
            this.ComboRes = new System.Windows.Forms.ComboBox();
            this.GridRes = new System.Windows.Forms.DataGridView();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.DefaultButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridRes)).BeginInit();
            this.SuspendLayout();
            // 
            // SelectButton
            // 
            this.SelectButton.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectButton.Location = new System.Drawing.Point(436, 10);
            this.SelectButton.Name = "SelectButton";
            this.SelectButton.Size = new System.Drawing.Size(145, 23);
            this.SelectButton.TabIndex = 0;
            this.SelectButton.Text = "Seleccione Carpeta";
            this.SelectButton.UseVisualStyleBackColor = true;
            this.SelectButton.Click += new System.EventHandler(this.SelectButton_Click);
            // 
            // ComboRes
            // 
            this.ComboRes.FormattingEnabled = true;
            this.ComboRes.Location = new System.Drawing.Point(13, 10);
            this.ComboRes.Name = "ComboRes";
            this.ComboRes.Size = new System.Drawing.Size(417, 21);
            this.ComboRes.TabIndex = 1;
            this.ComboRes.SelectedIndexChanged += new System.EventHandler(this.ComboRes_SelectedIndexChanged);
            // 
            // GridRes
            // 
            this.GridRes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridRes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GridRes.Location = new System.Drawing.Point(225, 90);
            this.GridRes.Name = "GridRes";
            this.GridRes.Size = new System.Drawing.Size(368, 435);
            this.GridRes.TabIndex = 2;
            // 
            // webBrowser
            // 
            this.webBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser.Location = new System.Drawing.Point(13, 38);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(1286, 589);
            this.webBrowser.TabIndex = 3;
            this.webBrowser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser_DocumentCompleted);
            // 
            // DefaultButton
            // 
            this.DefaultButton.Enabled = false;
            this.DefaultButton.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DefaultButton.Location = new System.Drawing.Point(587, 10);
            this.DefaultButton.Name = "DefaultButton";
            this.DefaultButton.Size = new System.Drawing.Size(145, 23);
            this.DefaultButton.TabIndex = 4;
            this.DefaultButton.Text = "Cargar Desde DS ";
            this.DefaultButton.UseVisualStyleBackColor = true;
            this.DefaultButton.Click += new System.EventHandler(this.DefaultButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(738, 10);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(145, 23);
            this.ExitButton.TabIndex = 5;
            this.ExitButton.Text = "Salir";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // HTMLViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1311, 639);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.DefaultButton);
            this.Controls.Add(this.webBrowser);
            this.Controls.Add(this.GridRes);
            this.Controls.Add(this.ComboRes);
            this.Controls.Add(this.SelectButton);
            this.MinimumSize = new System.Drawing.Size(300, 600);
            this.Name = "HTMLViewer";
            this.Text = "Visor HTML";
            this.Load += new System.EventHandler(this.Resultados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridRes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SelectButton;
        private System.Windows.Forms.ComboBox ComboRes;
        private System.Windows.Forms.DataGridView GridRes;
        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.Button DefaultButton;
        private System.Windows.Forms.Button ExitButton;
    }
}