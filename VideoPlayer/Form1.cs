using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;

using MiM_iVision;

using Warp_Csharp;

namespace VideoPlayer
{
    public partial class Form1 : Form
    {
        /**
         * 
         * 
         * MIM
         * 
         */
        delegate void SetTextCallback(TextBox textbox, string value);
        delegate void UpdataPictureImage_delegate(Image bmp);
        delegate void UpdataPicturePtr_delegate(IntPtr hbitbmp);


        iMatchDialog ncc;

        public IntPtr GrayImg = iImage.CreateGrayiImage();
        public IntPtr ColorImg = iImage.CreateColoriImage();
        public IntPtr hbitmap;
        public IntPtr Matchmodel = iMatch.CreateNCCMatch();
        public IntPtr TrainROITool = iROI.CreateiROIManager();
        public IntPtr MatchingROITool = iROI.CreateiROIManager();
        public IntPtr Snap_GrayImg = iImage.CreateGrayiImage();
        public bool UsingColor = false;
        public IntPtr hDC;
        public bool m_bRefresh = false;
        public bool m_bPause = true;
        public bool m_bRTMatch = false;

        public bool m_bColorSensor = false;
        /*
         
         
         */


        Image m_Drawimg = null;
        Bitmap m_Drawbmp = null;
        Graphics m_Drawg = null;

        Font drawfont = new Font("Arial", 12);
        Brush drawbrush = new SolidBrush(Color.Red);

        double DrawScale;
        double TotalFrame;
        double Fps;
        int FrameNo;
        bool IsReadingFrame;
        string path = "";
        VideoCapture capture;
        Image<Gray, byte> CurrentImg;
        private Mat _frame;
        private Mat _grayFrame;
        internal Graphics m_g;

        public Form1()
        {

            InitializeComponent();
            CvInvoke.UseOpenCL = false;
            ncc = new iMatchDialog(this);
            _frame = new Mat();
            _grayFrame = new Mat();
        }
       
        private void Load_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                if (capture!=null)
                {
                    capture.Dispose();
                }
                capture = new VideoCapture(ofd.FileName);
                Mat m = new Mat();
                //capture.ImageGrabbed += Capture_ImageGrabbed;
                capture.Read(m);
                pictureBox1.Image = Emgu.CV.BitmapExtension.ToBitmap(m);

                TotalFrame = capture.GetCaptureProperty(Emgu.CV.CvEnum.CapProp.FrameCount);
                Fps = capture.GetCaptureProperty(Emgu.CV.CvEnum.CapProp.Fps);
                capture.SetCaptureProperty(CapProp.Fps, 30);
                Fps = capture.GetCaptureProperty(Emgu.CV.CvEnum.CapProp.Fps);
                iImage.iImageResize(Snap_GrayImg, m.Width, m.Height);

            }
        }

        private void Capture_ImageGrabbed(object sender, EventArgs e)
        {
            try
            {
                Mat m = new Mat();
                capture.Read(m);

                if (!m.IsEmpty)
                {
                    pictureBox1.Image = m.ToBitmap();
                    FrameNo += Convert.ToInt16(numericUpDown1.Value);
                    // double fps = capture.GetCaptureProperty(Emgu.CV.CvEnum.CapProp.Fps);
                    // await Task.Delay(1000 / Convert.ToInt32(fps));
                    Thread.Sleep(1000 / Convert.ToInt32(30));

                    label1.Text = FrameNo.ToString() + "/" + TotalFrame.ToString();
                }
                else
                {
                   
                }
                //pictureBox1.Image = m.ToBitmap();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                throw;
            }
           
        }

        private void Play_Click(object sender, EventArgs e)
        {
            if (capture == null)
            {
                return;
            }
            IsReadingFrame = true;
            ReadAllFrames();
            m_bPause = false;
            //capture.Start();


        }

        private void Stop_Click(object sender, EventArgs e)
        {
            IsReadingFrame = false;
            FrameNo = 0;
            capture.Stop();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            capture.Pause();
            IsReadingFrame = false;
            m_bPause = true;
        }






        private async void ReadAllFrames()
        {
            Mat m = new Mat();
            while (IsReadingFrame == true && FrameNo < TotalFrame)
            {
                FrameNo += Convert.ToInt16(numericUpDown1.Value);
                capture.SetCaptureProperty(Emgu.CV.CvEnum.CapProp.PosFrames, FrameNo);
                capture.Read(m);
                CvInvoke.CvtColor(m, _grayFrame, ColorConversion.Bgr2Gray);
                //GrayScale(m.ToImage<Bgr, byte>(), out Image<Gray, byte> grayImage);
               // var bm = Emgu.CV.BitmapExtension.ToBitmap(m);
                CurrentImg = _grayFrame.ToImage<Gray,byte>();
               // var bm = grayImage.ToBitmap();
               //byte* ptr = (byte*)grayImg.MIplImage.ImageData;

                byte[,] Graymatrix = new byte[CurrentImg.Height, CurrentImg.Width];
                //byte[,] Graymatrix = new byte[CurrentImg.Width, CurrentImg.Height];
                //byte[] Graymatrix = new byte[grayImage.Height * grayImage.Width];
                for (int v = 0; v < CurrentImg.Height; v++)
                 {
                     for (int u = 0; u < CurrentImg.Width; u++)
                     {
                         byte a = CurrentImg.Data[v, u, 0]; //Get Pixel Color | fast way
                         Graymatrix[v, u] = a;
                        //Graymatrix[u, v] = a;
                    }
                 }

                E_iVision_ERRORS err2 = iImage.iImageResize(GrayImg, CurrentImg.Width, CurrentImg.Height);
                unsafe
                 {
                     fixed (byte* bufPointer = &Graymatrix[0,0])
                     {
                         var err = iImage.iPointerToiImage(GrayImg, (IntPtr)bufPointer, CurrentImg.Width, CurrentImg.Height);
                         if (err != E_iVision_ERRORS.E_OK)
                         {
                             MessageBox.Show(err.ToString(), "ERROR");
                          //   return IntPtr.Zero;
                         }
                    }
                 }
                m_Drawimg = System.Drawing.Image.FromHbitmap(iImage.iGetBitmapAddress(GrayImg));

                if (m_bRTMatch)
                {
                    m_Drawbmp = new Bitmap(CurrentImg.Width, CurrentImg.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
                    m_Drawg = Graphics.FromImage(m_Drawbmp);
                    m_Drawg.DrawImage(m_Drawimg, 0, 0, CurrentImg.Width, CurrentImg.Height);

                    E_iVision_ERRORS err;
                    int objnum = 0;
                    NCCFind objdata = new NCCFind();
                    iDPoint ResultPoint = new iDPoint();
                    iDPoint[] RegPoint = new iDPoint[4];
                    double[] Fang = new double[4];
                    int i;

                    if (m_bColorSensor)
                        err = iMatch.MatchNCCModel(ColorImg, Matchmodel);
                    else
                        err = iMatch.MatchNCCModel(GrayImg, Matchmodel);

                    if (err != E_iVision_ERRORS.E_OK)
                        m_bRTMatch = false;

                    iMatch.iGetNCCMatchNum(Matchmodel, ref objnum);

                    for (i = 0; i < objnum; i++)
                    {
                        iMatch.iGetNCCMatchResults(Matchmodel, i, ref objdata);

                        ResultPoint.x = objdata.CX;
                        ResultPoint.y = objdata.CY;

                        SetTextCoordinates(textBox1, objdata.CX.ToString("0.00"));
                        SetTextCoordinates(textBox2, objdata.CY.ToString("0.00"));
                        SetTextCoordinates(textBox3, objdata.Angle.ToString("0.00"));

                        m_Drawg.DrawString("score:" + objdata.Score.ToString("0.00"), drawfont, drawbrush, Convert.ToInt32(ResultPoint.x - 50), Convert.ToInt32(ResultPoint.y - 60));
                        m_Drawg.DrawString("angle:" + objdata.Angle.ToString("0.00"), drawfont, drawbrush, Convert.ToInt32(ResultPoint.x - 50), Convert.ToInt32(ResultPoint.y - 40));
                        m_Drawg.DrawString("scale:" + objdata.Scale.ToString("0.00"), drawfont, drawbrush, Convert.ToInt32(ResultPoint.x - 50), Convert.ToInt32(ResultPoint.y - 20));
                    }


                    iMatch.iDrawiMatchResults(Matchmodel, m_Drawg.GetHdc(), 1);
                    RefreshPictureImage(m_Drawbmp);
                    m_Drawg.Dispose();

                }
                else
                {
                    RefreshPicturePtr(iImage.iGetBitmapAddress(GrayImg));
                    await Task.Delay(1000 / Convert.ToInt16(30));
                    label1.Text = FrameNo.ToString() + "/" + TotalFrame.ToString();
                }

                await Task.Delay(1000 / Convert.ToInt16(30));
                label1.Text = FrameNo.ToString() + "/" + TotalFrame.ToString();

                //DrawScale = (double)Convert.ToDouble(txb.Text);
                ///DrawScaledImage(bm, (float)DrawScale, out Bitmap l_Bitmap);

                //pictureBox1.Image = l_Bitmap;
                /*
                 pictureBox1.Image = _grayFrame.ToBitmap();
                 await Task.Delay(1000 / Convert.ToInt16(30));
                 label1.Text = FrameNo.ToString() + "/" + TotalFrame.ToString();
                */
                // bm.Dispose();
                //l_Bitmap.Dispose();
            }
        }
        public void RefreshPictureImage(Image img)
        {
            if (img == null) return;
            if (this.pictureBox1.InvokeRequired)
            {
                UpdataPictureImage_delegate d = new UpdataPictureImage_delegate(RefreshPictureImage);
                try { this.Invoke(d, new object[] { img }); }
                catch (Exception e) { }
            }
            else
            {
                if (this.pictureBox1.Image != null)
                    this.pictureBox1.Image.Dispose();

                this.pictureBox1.Image = img;
            }
        }

        public void RefreshPicturePtr(IntPtr hbitmap)
        {
            if (hbitmap == IntPtr.Zero) return;
            if (this.pictureBox1.InvokeRequired)
            {
                UpdataPicturePtr_delegate d = new UpdataPicturePtr_delegate(RefreshPicturePtr);
                try { this.Invoke(d, new object[] { hbitmap }); }
                catch (Exception e) { }
            }
            else
            {
                if (this.pictureBox1.Image != null)
                    this.pictureBox1.Image.Dispose();

                this.pictureBox1.Image = System.Drawing.Image.FromHbitmap(hbitmap); ;
            }
        }
        private void Image_FinalStepResize(byte[,] Final_Graymatrix, int FinalWid, int FinalHei)
        {
            E_iVision_ERRORS err2 = iImage.iImageResize(GrayImg, FinalWid, FinalHei);
            unsafe
            {
                fixed (byte* bufPointer = &Final_Graymatrix[0, 0])
                {
                    err2 = iImage.iPointerToiImage(GrayImg, (IntPtr)bufPointer, FinalWid, FinalHei);
                    if (err2 != E_iVision_ERRORS.E_OK)
                    {
                        MessageBox.Show(err2.ToString(), "Error");
                        return;
                    }
                    hbitmap = iImage.iGetBitmapAddress(GrayImg);
                    pictureBox1.Image = System.Drawing.Image.FromHbitmap(hbitmap);
                    pictureBox1.Refresh();
                }
            }
            //txt_Buffersize.Text = Convert.ToString(buffersize);
           // txt_height.Text = Convert.ToString(FinalHei);
           // txt_width.Text = Convert.ToString(FinalWid);
        }//

        private void SetTextCoordinates(TextBox textbox, string value)
        {
            if (textbox.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetTextCoordinates);
                this.Invoke(d, new object[] { textbox, value });
            }
            else
            {
                textbox.Text = value;
            }
        }

        private void GrayScale(Image<Bgr,byte> img , out Image<Gray,byte> grayImg)
        {
            //Image<Gray,byte> gray = 
            Image<Gray, byte> grayImage = img.Convert<Gray,byte>();
           // grayImage.ThresholdBinary(new Gray(149), new Gray(255));
            grayImg = grayImage;
        }

        public void DrawScaledImage(Bitmap hBitmap, float a_scale, out Bitmap l_Bitmap)
        {
            if (hBitmap != null)
            {
                Image img = Image.FromHbitmap(hBitmap.GetHbitmap());

                int width = (int)(img.Width * a_scale);
                int height = (int)(img.Height * a_scale);

                l_Bitmap = new Bitmap(width,
                                             height,
                                             PixelFormat.Format32bppArgb);
                using (Graphics graph = Graphics.FromImage(l_Bitmap))
                {
                    Rectangle dest_rect = new Rectangle(0, 0, width, height);
                    graph.ScaleTransform(a_scale, a_scale);
                    graph.DrawImageUnscaled(img, 0, 0);
                    graph.Dispose();
                }
                img.Dispose();
            }
            else
            {
                l_Bitmap = null;
            }
        }

        private void btnCapture_Click(object sender, EventArgs e)
        {
           
          
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
           

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ncc.Show();
        }

        internal Image<Gray, byte> GetImageFromVideo()
        {
            return CurrentImg;
        }

        internal Graphics GetGraphics()
        {
            return pictureBox1.CreateGraphics();
        }

        internal double GetScale()
        {
            return DrawScale;
        }

        private void Mainfrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            iMatch.DestroyNCCMatch(Matchmodel);
            iImage.DestroyiImage(ColorImg);
            iImage.DestroyiImage(GrayImg);
            iROI.DestroyiROIManager(TrainROITool);
            iROI.DestroyiROIManager(MatchingROITool);
        }

        private void Picbox_MouseDown(object sender, MouseEventArgs e)
        {
            if (iImage.iImageIsNULL(GrayImg) == E_iVision_ERRORS.E_FALSE ||
                iImage.iImageIsNULL(ColorImg) == E_iVision_ERRORS.E_FALSE)
            {
                iROI.iROIMouseDown(TrainROITool, hDC, e.X, e.Y);
                iROI.iROIMouseDown(MatchingROITool, hDC, e.X, e.Y);
            }
        }

        private void Picbox_MouseMove(object sender, MouseEventArgs e)
        {
            if (iImage.iImageIsNULL(GrayImg) == E_iVision_ERRORS.E_FALSE ||
                iImage.iImageIsNULL(ColorImg) == E_iVision_ERRORS.E_FALSE)
            {
                iROI.iROIMouseMove(TrainROITool, hDC, e.X, e.Y);
                iROI.iROIMouseMove(MatchingROITool, hDC, e.X, e.Y);
            }
        }
    }
}
