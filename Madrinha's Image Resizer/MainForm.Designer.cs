namespace Madrinha_s_Image_Resizer
{
    partial class MainForm
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
            this.imagesBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.labelHeight = new System.Windows.Forms.Label();
            this.labelWidth = new System.Windows.Forms.Label();
            this.PathDestinationtextBox = new System.Windows.Forms.TextBox();
            this.labelDestination = new System.Windows.Forms.Label();
            this.PathOrigintextBox = new System.Windows.Forms.TextBox();
            this.labelOrigin = new System.Windows.Forms.Label();
            this.buttonBrowseOrigin = new System.Windows.Forms.Button();
            this.buttonBrowseDestination = new System.Windows.Forms.Button();
            this.Processbutton = new System.Windows.Forms.Button();
            this.numericUpDownHeight = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownWidth = new System.Windows.Forms.NumericUpDown();
            this.statusLabel = new System.Windows.Forms.Label();
            this.GeneralProgressBar = new System.Windows.Forms.ProgressBar();
            this.labelX = new System.Windows.Forms.Label();
            this.backgroundWorkerImages = new System.ComponentModel.BackgroundWorker();
            this.cancelbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWidth)).BeginInit();
            this.SuspendLayout();
            // 
            // labelHeight
            // 
            this.labelHeight.AutoSize = true;
            this.labelHeight.Location = new System.Drawing.Point(179, 117);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(72, 13);
            this.labelHeight.TabIndex = 2;
            this.labelHeight.Text = "Altura Imagen";
            // 
            // labelWidth
            // 
            this.labelWidth.AutoSize = true;
            this.labelWidth.Location = new System.Drawing.Point(9, 117);
            this.labelWidth.Name = "labelWidth";
            this.labelWidth.Size = new System.Drawing.Size(85, 13);
            this.labelWidth.TabIndex = 3;
            this.labelWidth.Text = "Anchura Imagen";
            // 
            // PathDestinationtextBox
            // 
            this.PathDestinationtextBox.Enabled = false;
            this.PathDestinationtextBox.Location = new System.Drawing.Point(12, 85);
            this.PathDestinationtextBox.Name = "PathDestinationtextBox";
            this.PathDestinationtextBox.Size = new System.Drawing.Size(242, 20);
            this.PathDestinationtextBox.TabIndex = 4;
            // 
            // labelDestination
            // 
            this.labelDestination.AutoSize = true;
            this.labelDestination.Location = new System.Drawing.Point(9, 69);
            this.labelDestination.Name = "labelDestination";
            this.labelDestination.Size = new System.Drawing.Size(89, 13);
            this.labelDestination.TabIndex = 5;
            this.labelDestination.Text = "Directorio destino";
            // 
            // PathOrigintextBox
            // 
            this.PathOrigintextBox.Enabled = false;
            this.PathOrigintextBox.Location = new System.Drawing.Point(12, 31);
            this.PathOrigintextBox.Name = "PathOrigintextBox";
            this.PathOrigintextBox.Size = new System.Drawing.Size(242, 20);
            this.PathOrigintextBox.TabIndex = 6;
            // 
            // labelOrigin
            // 
            this.labelOrigin.AutoSize = true;
            this.labelOrigin.Location = new System.Drawing.Point(9, 15);
            this.labelOrigin.Name = "labelOrigin";
            this.labelOrigin.Size = new System.Drawing.Size(84, 13);
            this.labelOrigin.TabIndex = 7;
            this.labelOrigin.Text = "Directorio origen";
            // 
            // buttonBrowseOrigin
            // 
            this.buttonBrowseOrigin.Location = new System.Drawing.Point(256, 30);
            this.buttonBrowseOrigin.Name = "buttonBrowseOrigin";
            this.buttonBrowseOrigin.Size = new System.Drawing.Size(24, 23);
            this.buttonBrowseOrigin.TabIndex = 0;
            this.buttonBrowseOrigin.Text = "...";
            this.buttonBrowseOrigin.UseVisualStyleBackColor = true;
            this.buttonBrowseOrigin.Click += new System.EventHandler(this.buttonBrowseOrigin_Click);
            // 
            // buttonBrowseDestination
            // 
            this.buttonBrowseDestination.Location = new System.Drawing.Point(256, 84);
            this.buttonBrowseDestination.Name = "buttonBrowseDestination";
            this.buttonBrowseDestination.Size = new System.Drawing.Size(24, 23);
            this.buttonBrowseDestination.TabIndex = 1;
            this.buttonBrowseDestination.Text = "...";
            this.buttonBrowseDestination.UseVisualStyleBackColor = true;
            this.buttonBrowseDestination.Click += new System.EventHandler(this.buttonBrowseDestination_Click);
            // 
            // Processbutton
            // 
            this.Processbutton.Location = new System.Drawing.Point(66, 237);
            this.Processbutton.Name = "Processbutton";
            this.Processbutton.Size = new System.Drawing.Size(75, 23);
            this.Processbutton.TabIndex = 4;
            this.Processbutton.Text = "Procesar";
            this.Processbutton.UseVisualStyleBackColor = true;
            this.Processbutton.Click += new System.EventHandler(this.Processbutton_Click);
            // 
            // numericUpDownHeight
            // 
            this.numericUpDownHeight.Location = new System.Drawing.Point(182, 133);
            this.numericUpDownHeight.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownHeight.Name = "numericUpDownHeight";
            this.numericUpDownHeight.Size = new System.Drawing.Size(99, 20);
            this.numericUpDownHeight.TabIndex = 2;
            this.numericUpDownHeight.Value = new decimal(new int[] {
            480,
            0,
            0,
            0});
            // 
            // numericUpDownWidth
            // 
            this.numericUpDownWidth.Location = new System.Drawing.Point(12, 133);
            this.numericUpDownWidth.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownWidth.Name = "numericUpDownWidth";
            this.numericUpDownWidth.Size = new System.Drawing.Size(99, 20);
            this.numericUpDownWidth.TabIndex = 3;
            this.numericUpDownWidth.Value = new decimal(new int[] {
            640,
            0,
            0,
            0});
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(12, 174);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(40, 13);
            this.statusLabel.TabIndex = 15;
            this.statusLabel.Text = "Status:";
            // 
            // GeneralProgressBar
            // 
            this.GeneralProgressBar.Location = new System.Drawing.Point(12, 190);
            this.GeneralProgressBar.Name = "GeneralProgressBar";
            this.GeneralProgressBar.Size = new System.Drawing.Size(268, 23);
            this.GeneralProgressBar.TabIndex = 14;
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Location = new System.Drawing.Point(140, 135);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(14, 13);
            this.labelX.TabIndex = 16;
            this.labelX.Text = "X";
            // 
            // backgroundWorkerImages
            // 
            this.backgroundWorkerImages.WorkerReportsProgress = true;
            this.backgroundWorkerImages.WorkerSupportsCancellation = true;
            this.backgroundWorkerImages.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerImages_DoWork);
            this.backgroundWorkerImages.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorkerImages_ProgressChanged);
            this.backgroundWorkerImages.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerImages_RunWorkerCompleted);
            // 
            // cancelbutton
            // 
            this.cancelbutton.Enabled = false;
            this.cancelbutton.Location = new System.Drawing.Point(153, 237);
            this.cancelbutton.Name = "cancelbutton";
            this.cancelbutton.Size = new System.Drawing.Size(75, 23);
            this.cancelbutton.TabIndex = 5;
            this.cancelbutton.Text = "Cancelar";
            this.cancelbutton.UseVisualStyleBackColor = true;
            this.cancelbutton.Click += new System.EventHandler(this.cancelbutton_Click);
            // 
            // MainForm
            // 
            this.AcceptButton = this.Processbutton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 272);
            this.Controls.Add(this.cancelbutton);
            this.Controls.Add(this.labelX);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.GeneralProgressBar);
            this.Controls.Add(this.numericUpDownWidth);
            this.Controls.Add(this.numericUpDownHeight);
            this.Controls.Add(this.Processbutton);
            this.Controls.Add(this.buttonBrowseDestination);
            this.Controls.Add(this.buttonBrowseOrigin);
            this.Controls.Add(this.labelOrigin);
            this.Controls.Add(this.PathOrigintextBox);
            this.Controls.Add(this.labelDestination);
            this.Controls.Add(this.PathDestinationtextBox);
            this.Controls.Add(this.labelWidth);
            this.Controls.Add(this.labelHeight);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Madrinha\'s Image Resizer";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWidth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog imagesBrowserDialog;
        private System.Windows.Forms.Label labelHeight;
        private System.Windows.Forms.Label labelWidth;
        private System.Windows.Forms.TextBox PathDestinationtextBox;
        private System.Windows.Forms.Label labelDestination;
        private System.Windows.Forms.TextBox PathOrigintextBox;
        private System.Windows.Forms.Label labelOrigin;
        private System.Windows.Forms.Button buttonBrowseOrigin;
        private System.Windows.Forms.Button buttonBrowseDestination;
        private System.Windows.Forms.Button Processbutton;
        private System.Windows.Forms.NumericUpDown numericUpDownHeight;
        private System.Windows.Forms.NumericUpDown numericUpDownWidth;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.ProgressBar GeneralProgressBar;
        private System.Windows.Forms.Label labelX;
        private System.ComponentModel.BackgroundWorker backgroundWorkerImages;
        private System.Windows.Forms.Button cancelbutton;
    }
}

