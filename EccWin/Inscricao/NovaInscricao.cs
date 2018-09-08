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
using AForge.Imaging;
using AForge.Imaging.Filters;
using AForge;
using AForge.Video.DirectShow;
using AForge.Video;

namespace EccWin.Inscricao
{
    public partial class NovaInscricao : Form
    {
        public NovaInscricao()
        {
            InitializeComponent();
        }

        private FilterInfoCollection CaptureDevice; // list of webcam
        private VideoCaptureDevice FinalFrame;

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show("Deseja Fechar o cadastro?", "Cancelar nova inscrição", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question))
            {
                case System.Windows.Forms.DialogResult.Yes:
                    this.Close();
                    break;
                case System.Windows.Forms.DialogResult.No:
                    if(MessageBox.Show("Deseja apagar o cadastro?", "Apagar campos", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==System.Windows.Forms.DialogResult.Yes)
                    ClearForm();
                    break;
                default:
                    break;
            }
        }

        private void ClearForm()
        {
            throw new NotImplementedException();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            pnlResultado.Visible = true;
        }

        private void NovaInscricao_Load(object sender, EventArgs e)
        {
            CaptureDevice = new FilterInfoCollection(FilterCategory.VideoInputDevice);//constructor

            FinalFrame = new VideoCaptureDevice();

            FinalFrame = new VideoCaptureDevice(CaptureDevice[0].MonikerString);// specified web cam and its filter moniker string
            FinalFrame.NewFrame += new NewFrameEventHandler(FinalFrame_NewFrame);// click button event is fired, 
            
        }

        void FinalFrame_NewFrame(object sender, NewFrameEventArgs eventArgs) // must be void so that it can be accessed everywhere.
        // New Frame Event Args is an constructor of a class
        {
            pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();// clone the bitmap
        }

        private void btnPicture_Click(object sender, EventArgs e)
        {
            FinalFrame.Start();
        }

        private void btnSavePicture_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                //Save First
                Bitmap varBmp = new Bitmap(pictureBox1.Image);
                Bitmap newBitmap = new Bitmap(varBmp);
                varBmp.Save(@"C:\apoio\a.png", ImageFormat.Png);
                //Now Dispose to free the memory
                varBmp.Dispose();
                varBmp = null;
                if (FinalFrame.IsRunning == true) FinalFrame.Stop();
                pictureBox1.ImageLocation = @"C:\apoio\a.png";
            }
            else
            { MessageBox.Show("null exception"); }
        }
    }
}
