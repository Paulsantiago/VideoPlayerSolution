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

using MVC.Vision.MiM;
using MVC.Vision.MiM.MiM_iVision;

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
        Graphics g_rectangle;




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
                iImage.Resize(Snap_GrayImg, m.Width, m.Height);

            
              
                //hDC = g.GetHdc();

           
                //iROI.Plot(TrainROITool, hDC);
                //pictureBox1.Refresh();

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
          
            m_g = pictureBox1.CreateGraphics();
            hDC = m_g.GetHdc();
            iROI.Attached(TrainROITool, Snap_GrayImg, hDC);
            iROI.Attached(TrainROITool, GrayImg, hDC);
            ncc.AddBaseROI(sender, e);
            timerSPEED.Start();

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


        public void TransformFromImgCVToGrayImage(Image<Gray, byte> CurrentImg )
        {
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
            E_iVision_ERRORS err2 = iImage.Resize(GrayImg, CurrentImg.Width, CurrentImg.Height);
            unsafe
            {
                fixed (byte* bufPointer = &Graymatrix[0, 0])
                {
                    var err = iImage.PointerToiImage(GrayImg, (IntPtr)bufPointer, CurrentImg.Width, CurrentImg.Height);
                    if (err != E_iVision_ERRORS.E_OK)
                    {
                        MessageBox.Show(err.ToString(), "ERROR");
                        //   return IntPtr.Zero;
                    }
                }
            }
        }

        iDPoint ResultPoint;

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


                TransformFromImgCVToGrayImage(CurrentImg);


                m_Drawimg = System.Drawing.Image.FromHbitmap(iImage.GetBitmapAddress(GrayImg));

                if (m_bRTMatch)
                {
                    m_Drawbmp = new Bitmap(CurrentImg.Width, CurrentImg.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
                    m_Drawg = Graphics.FromImage(m_Drawbmp);
                    m_Drawg.DrawImage(m_Drawimg, 0, 0, CurrentImg.Width, CurrentImg.Height);

                    E_iVision_ERRORS err;
                    int objnum = 0;
                    iNCCFound objdata = new iNCCFound();
                    ResultPoint = new iDPoint();
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

                        ResultPoint.x = objdata.cp.x;
                        ResultPoint.y = objdata.cp.y;

                        SetTextCoordinates(textBox1, objdata.cp.x.ToString("0.00"));
                        SetTextCoordinates(textBox2, objdata.cp.y.ToString("0.00"));
                        SetTextCoordinates(textBox3, objdata.angle.ToString("0.00"));

                        m_Drawg.DrawString("score:" + objdata.score.ToString("0.00"), drawfont, drawbrush, Convert.ToInt32(ResultPoint.x - 50), Convert.ToInt32(ResultPoint.y - 60));
                        m_Drawg.DrawString("angle:" + objdata.angle.ToString("0.00"), drawfont, drawbrush, Convert.ToInt32(ResultPoint.x - 50), Convert.ToInt32(ResultPoint.y - 40));
                        m_Drawg.DrawString("scale:" + objdata.scale.ToString("0.00"), drawfont, drawbrush, Convert.ToInt32(ResultPoint.x - 50), Convert.ToInt32(ResultPoint.y - 20));
                    }


                    iMatch.iDrawiMatchResults(Matchmodel, m_Drawg.GetHdc(), 1);
                    RefreshPictureImage(m_Drawbmp);
                    m_Drawg.Dispose();

                }
                else
                {
                    RefreshPicturePtr(iImage.GetBitmapAddress(GrayImg));
                    await Task.Delay(1000 / Convert.ToInt16(30));
                    label1.Text = FrameNo.ToString() + "/" + TotalFrame.ToString();
                }

                await Task.Delay(1000 / Convert.ToInt16(30));
                label1.Text = FrameNo.ToString() + "/" + TotalFrame.ToString();

                pixelSpeedX = ResultPoint.x - lastPositionX;
                pixelSpeedY = ResultPoint.y - lastPositionY;
                TBXSPEEDX.Text = pixelSpeedX.ToString("F2");
                TBSSPEEDY.Text = pixelSpeedY.ToString("F2");
                lastPositionX = (int)ResultPoint.x;
                lastPositionY = (int)ResultPoint.y;
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
            E_iVision_ERRORS err2 = iImage.Resize(GrayImg, FinalWid, FinalHei);
            unsafe
            {
                fixed (byte* bufPointer = &Final_Graymatrix[0, 0])
                {
                    err2 = iImage.PointerToiImage(GrayImg, (IntPtr)bufPointer, FinalWid, FinalHei);
                    if (err2 != E_iVision_ERRORS.E_OK)
                    {
                        MessageBox.Show(err2.ToString(), "Error");
                        return;
                    }
                    hbitmap = iImage.GetBitmapAddress(GrayImg);
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
            if (iImage.IsNULL(GrayImg) == E_iVision_ERRORS.E_FALSE ||
                iImage.IsNULL(ColorImg) == E_iVision_ERRORS.E_FALSE)
            {
                iROI.MouseDown(TrainROITool, hDC, e.X, e.Y);
                iROI.MouseDown(MatchingROITool, hDC, e.X, e.Y);
            }
        }

        private void Picbox_MouseMove(object sender, MouseEventArgs e)
        {
            if (iImage.IsNULL(GrayImg) == E_iVision_ERRORS.E_FALSE ||
                iImage.IsNULL(ColorImg) == E_iVision_ERRORS.E_FALSE)
            {
                if (iROI.Size(TrainROITool) != 0)
                {
              
                    iROI.MouseMove(TrainROITool, hDC, e.X, e.Y);
                    iROI.MouseMove(MatchingROITool, hDC, e.X, e.Y);
                    ChangePositionOfROI(e.X, e.Y);
                }
            }
        }

        private void ChangePositionOfROI(int x, int y)
        {
            iBaseROI crect = (iBaseROI)GetROIinfoByType(iROIType.BaseROI);
            crect.org_x = x;
            crect.org_y = y;
            var err = iROI.AssignBaseROI(TrainROITool, crect);
            if (err != E_iVision_ERRORS.E_OK)
            {
                return ;
            }
          
        }

        public object GetROIinfoByType(iROIType type)
        {
            IntPtr pnt;
            switch (type)
            {
                case iROIType.UnknownROIType:
                    break;
                case iROIType.BaseROI:
                    iBaseROI baseROI = new iBaseROI();
                    pnt = Marshal.AllocHGlobal(Marshal.SizeOf(baseROI));
                    Marshal.StructureToPtr(baseROI, pnt, false);
                    iROI.GetInfo(TrainROITool, pnt);
                    iBaseROI BASEROI = (iBaseROI)Marshal.PtrToStructure(pnt, typeof(iBaseROI));
                    Marshal.FreeHGlobal(pnt);
                    return BASEROI;
              
                default:
                    break;
            }
            return null;


        }
        Rectangle rect = new Rectangle
        {
            X = 0,
            Y = 0,
            Width = 40,
            Height = 20
        };
        private double pixelSpeedX;
        private double pixelSpeedY;
        private double lastPositionX = 0;
        private double lastPositionY = 0;

        private void DrawRectangle(int x, int y)
        {
           
            Invalidate();

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Point local = this.PointToClient(Cursor.Position);
            e.Graphics.DrawRectangle(Pens.Red, local.X - 80, local.Y - 150, 100, 100);
            //e.Graphics.DrawEllipse(Pens.Red, local.X , local.Y , 20, 20);
          
        }

        private void pictureBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button==MouseButtons.Right)
            {
                Console.WriteLine(" create img ");
                TransformFromImgCVToGrayImage(GetImageFromVideo());
                Image<Gray, byte> imgCV = GetImageFromVideo();
                string path = @"C:\\Users\\E100_AR VR\\Pictures\\test.bmp";
                imgCV.Save(path);
                var err = iImage.ReadImage(Snap_GrayImg, path);
                if (err == E_iVision_ERRORS.E_OK)
                {
                    hbitmap = iImage.GetBitmapAddress(GrayImg);
                    if (pictureBox2.Image != null) pictureBox2.Image.Dispose();
                    pictureBox2.Image = System.Drawing.Image.FromHbitmap(hbitmap);
                }
                pictureBox2.Refresh();

                Graphics g = GetGraphics();
                hDC = g.GetHdc();

                iROI.Attached(TrainROITool, GrayImg, hDC);
                Console.WriteLine(" training ");
                ncc.btn_NCCtraining_Click(sender, e);
                Console.WriteLine(" matching");
                ncc.btn_NCCmatching_Click(sender, e);
            }
        }
        public void GetImage()
        {
            Image<Gray, byte> imgCV = GetImageFromVideo();
            string path = @"C:\\Users\\E100_AR VR\\Pictures\\test.bmp";
            imgCV.Save(path);


        }
        private void addROI(object sender, EventArgs e)
        {
            var err = iImage.ReadImage(Snap_GrayImg, path);
            if (err == E_iVision_ERRORS.E_OK)
            {
                hbitmap = iImage.GetBitmapAddress(GrayImg);
                if (pictureBox2.Image != null) pictureBox2.Image.Dispose();
                pictureBox2.Image = System.Drawing.Image.FromHbitmap(hbitmap);
            }
            pictureBox2.Refresh();


       
        }
        double xlastP = 0;
        double xcurrent = 0;
        private void timerSPEED_Tick(object sender, EventArgs e)
        {
            xcurrent = ResultPoint.x - xlastP;   /// SPPED WOULD BE  ResultPoint.x/PPI(PIXEL PER INCHES or per cm) - xlastP
            xlastP = ResultPoint.x;
            txbspeed.Text = xcurrent.ToString("F2");
        }
    }
}
