using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Tesseract;
using DarrenLee.Media;
using System.Data;

namespace Camera
{
    public partial class Form1 : Form
    {
        string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\OCR\";
        int count = 0;
        DarrenLee.Media.Camera camera = new DarrenLee.Media.Camera();
        public Form1()
        {
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);
            InitializeComponent();
            GetInfo();
            camera.OnFrameArrived += Camera_OnFrameArrived;
        }

        private void GetInfo() 
        {
            var cameraDevices = camera.GetCameraSources();
            var cameraResolutions = camera.GetSupportedResolutions();

            foreach (var device in cameraDevices) 
                CMB_Devices.Items.Add(device);

            foreach (var res in cameraResolutions)
                CMB_Resolution.Items.Add(res);

            CMB_Resolution.SelectedIndex = 0;
            CMB_Devices.SelectedIndex = 0;

        }

        private void Camera_OnFrameArrived(object source, FrameArrivedEventArgs e)
        {
            Image img = e.GetFrame();
            PXB_Picture.Image = img;
        }

        private void CMB_Devices_SelectedIndexChanged(object sender, EventArgs e)
        {
            camera.ChangeCamera(CMB_Devices.SelectedIndex);
        }

        private void CMB_Resolution_SelectedIndexChanged(object sender, EventArgs e)
        {
            camera.Start(CMB_Resolution.SelectedIndex);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            camera.Stop();
        }

        private void BTN_Save_Click_1(object sender, EventArgs e)
        {
            string filename = path + @"\img_ocr" + count.ToString();
            camera.Capture(filename);

            Bitmap img = (Bitmap)Bitmap.FromFile(filename + ".jpg");
            img.RotateFlip(RotateFlipType.Rotate180FlipY);

            Tesseract.TesseractEngine tesseract = new Tesseract.TesseractEngine("./dataset", "eng",Tesseract.EngineMode.TesseractOnly);
            var page = tesseract.Process(img);
            listBox1.Items.Add(page.GetText());

            img.Dispose();
            File.Delete(filename + ".jpg");
            count++;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
