using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;

namespace Madrinha_s_Image_Resizer
{
    public partial class MainForm : Form
    {
        #region Constructor
        public MainForm()
        {
            InitializeComponent();
        }
        #endregion

        #region Control Related Stuff

        private void buttonBrowseOrigin_Click(object sender, EventArgs e)
        {
            imagesBrowserDialog.Description = "Selecciona el directorio de origen";

            if (imagesBrowserDialog.ShowDialog() == DialogResult.OK)
                PathOrigintextBox.Text = imagesBrowserDialog.SelectedPath;
        }

        private void buttonBrowseDestination_Click(object sender, EventArgs e)
        {
            imagesBrowserDialog.Description = "Selecciona el directorio de destino";

            if (imagesBrowserDialog.ShowDialog() == DialogResult.OK)
                PathDestinationtextBox.Text = imagesBrowserDialog.SelectedPath;
        }

        private void Processbutton_Click(object sender, EventArgs e)
        {
            if (!ValidatePaths())
                return;

            DirectoryInfo imagesdirectory = new DirectoryInfo(PathOrigintextBox.Text);

            var allowedextensions = Properties.Settings.Default.AllowedExtensions.Split('|');

            IList<FileInfo> FileCollection = imagesdirectory.GetFiles("*.*", SearchOption.AllDirectories)
                                                            .Where(x => allowedextensions.Contains(x.Extension, StringComparer.OrdinalIgnoreCase)).ToList();

            if (FileCollection.Count == 0)
            {
                MessageBox.Show("No existen ficheros en el directorio de origen para procesar", "Imagenes en origen", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (backgroundWorkerImages.IsBusy != true)
            {
                EnableControls(false);

                GeneralProgressBar.Value = 0;
                GeneralProgressBar.Maximum = FileCollection.Count;
                GeneralProgressBar.Minimum = 0;
                GeneralProgressBar.Step = 1;

                backgroundWorkerImages.RunWorkerAsync(FileCollection);
            }
        }

        private void cancelbutton_Click(object sender, EventArgs e)
        {
            backgroundWorkerImages.CancelAsync();
        }

        private void EnableControls(bool enabled)
        {
            buttonBrowseDestination.Enabled = enabled;
            buttonBrowseOrigin.Enabled = enabled;
            Processbutton.Enabled = enabled;
            numericUpDownHeight.Enabled = enabled;
            numericUpDownWidth.Enabled = enabled;
            cancelbutton.Enabled = !enabled;
        }

#endregion

        #region Validation Stuff
        private bool ValidatePaths()
        {
            if (!Directory.Exists(PathOrigintextBox.Text)
                || String.IsNullOrEmpty(PathOrigintextBox.Text))
            {
                MessageBox.Show("El directorio de origen no existe");
                return false;
            }

            if (!Directory.Exists(PathDestinationtextBox.Text)
                || String.IsNullOrEmpty(PathDestinationtextBox.Text))
            {
                MessageBox.Show("El directorio de destino no existe");
                return false;
            }

            return true;
        }
        #endregion

        #region Image Functions

        private Image GetResizedImage(Image image, int width, int height)
        {
            //return image.GetThumbnailImage(width, height, null, IntPtr.Zero);
            return resizeImage(image, new Size(width, height));
        }

        private static Image resizeImage(Image imgToResize, Size size)
        {
            int sourceWidth = imgToResize.Width;
            int sourceHeight = imgToResize.Height;

            float nPercent = 0;
            float nPercentW = 0;
            float nPercentH = 0;

            nPercentW = ((float)size.Width / (float)sourceWidth);
            nPercentH = ((float)size.Height / (float)sourceHeight);

            if (nPercentH < nPercentW)
                nPercent = nPercentH;
            else
                nPercent = nPercentW;

            int destWidth = (int)(sourceWidth * nPercent);
            int destHeight = (int)(sourceHeight * nPercent);

            Bitmap b = new Bitmap(destWidth, destHeight);
            Graphics g = Graphics.FromImage((Image)b);
            
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.PixelOffsetMode = PixelOffsetMode.HighQuality;
            
            g.DrawImage(imgToResize, 0, 0, destWidth, destHeight);
            g.Dispose();

            return (Image)b;
        }

        #endregion

        #region BackgroundWorker Events

        private void backgroundWorkerImages_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;

            IList<FileInfo> FileCollection = e.Argument as IList<FileInfo>;

            foreach (FileInfo File in FileCollection)
            {
                if ((worker.CancellationPending == true))
                {
                    e.Cancel = true;
                    break;
                }
                else
                {
                    try
                    {
                        Image image = Image.FromFile(File.FullName);

                        if (image.Height > numericUpDownHeight.Value || image.Width > numericUpDownWidth.Value)
                        {
                            //Keep the ratio aspect
                            decimal ratio = (decimal)image.Height / (decimal)image.Width;
                            Image NewImage;

                            NewImage = GetResizedImage(image,
                                                       (int)numericUpDownWidth.Value,
                                                       (int)numericUpDownHeight.Value);

                            NewImage.Save(Path.Combine(PathDestinationtextBox.Text,
                                                       Properties.Settings.Default.ResizedPrefix + File.Name));
                            //ImageFormat.Jpeg);
                        }

                        image.Dispose();
                        worker.ReportProgress(1);
                    }

                    catch (Exception ex)
                    {
                        /*MessageBox.Show("Se produjo la siguiente excepción: ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        backgroundWorkerImages.CancelAsync();*/
                    }
                }
            }
        }

        private void backgroundWorkerImages_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            GeneralProgressBar.PerformStep();
        }

        private void backgroundWorkerImages_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if ((e.Cancelled == true))
            {
                MessageBox.Show("Proceso cancelado por el usuario", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GeneralProgressBar.Value = 0;
                EnableControls(true);
            }

            else if (!(e.Error == null))
            {
                MessageBox.Show("Se ha producido el siguiente error: " + e.Error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                GeneralProgressBar.Value = 0;
                EnableControls(true);
            }

            else
            {
                MessageBox.Show("¡Proceso terminado con éxito! :D :D", "Fin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                EnableControls(true);
            }
        }

        #endregion
    }
}
