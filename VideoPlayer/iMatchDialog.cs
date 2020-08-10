using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Globalization;

using System.Diagnostics;
using VideoPlayer;
using Emgu.CV.Structure;
using Emgu.CV;
using MVC.Vision.MiM.MiM_iVision;
using MVC.Vision.MiM;

namespace Warp_Csharp
{
    public partial class iMatchDialog :Form 
    {
        public Form1 TheMainfrm;
        Stopwatch sw = new Stopwatch();

        string path;

        //For matching
        bool UsingMask;
        bool UsingRotation;
        bool UsingScale;
        bool UsingRobust;
        bool UsingCS;
        bool UsingSubpixel;
        int  ColorSensitivy;

        int  Max_objs;
        double MaxAng, MinAng;
        double MaxScale, MinScale;
        double MinScore;
        int DontCarevalue;
        int MinReduceArea;
        int FindReduction;

        iNCCFound objfind;

        bool TrainingFromROI = false;

        public iMatchDialog(Form1 frmptr)
        {
            InitializeComponent();

            TheMainfrm = frmptr;

            label2.Text = "NULL";
            dataGridView1.Rows.Clear();

            UsingMask = false;
            UsingRotation = false;
            UsingScale = false;

            cbx_rotation.CheckState = CheckState.Unchecked;
            cbx_scale.CheckState = CheckState.Unchecked;
            cbx_dontcare.CheckState = CheckState.Unchecked;
            cbx_usingrobust.CheckState = CheckState.Unchecked;
            cbx_ColorSimilarity.CheckState = CheckState.Unchecked;
            cbx_usingsubpixel.CheckState = CheckState.Checked;

            iMatch.iGetOccurrence(TheMainfrm.Matchmodel, ref Max_objs);
            iMatch.iGetAngle(TheMainfrm.Matchmodel, ref MaxAng, ref MinAng);
            iMatch.iGetScale(TheMainfrm.Matchmodel, ref MaxScale, ref MinScale);
            iMatch.iGetMinScore(TheMainfrm.Matchmodel, ref MinScore);
            iMatch.iGetDontCareThreshold(TheMainfrm.Matchmodel, ref DontCarevalue);
            iMatch.iGetMinReduceArea(TheMainfrm.Matchmodel, ref MinReduceArea);
            iMatch.iGetIsRotated(TheMainfrm.Matchmodel, ref UsingRotation);
            iMatch.iGetIsScaled(TheMainfrm.Matchmodel, ref UsingScale);
            iMatch.iGetIsDontArea(TheMainfrm.Matchmodel, ref UsingMask);
            iMatch.iGetRobustness(TheMainfrm.Matchmodel, ref UsingRotation);
            iMatch.iGetColorSimilarity(TheMainfrm.Matchmodel, ref UsingCS);
            iMatch.iGetSubPixel(TheMainfrm.Matchmodel, ref UsingSubpixel);
            iMatch.iGetColorSensitivity(TheMainfrm.Matchmodel, ref ColorSensitivy);
            iMatch.iGetFinalReduction(TheMainfrm.Matchmodel, ref FindReduction);

            tbx_objnums.Text = Max_objs.ToString();
            tbx_maxang.Text = MaxAng.ToString();
            tbx_minang.Text = MinAng.ToString();
            tbx_maxscale.Text = MaxScale.ToString();
            tbx_minscale.Text = MinScale.ToString();
            tbx_minscore.Text = MinScore.ToString();
            tbx_dontcarethreshold.Text = DontCarevalue.ToString();
            tbx_MinReduceArea.Text = MinReduceArea.ToString();
            tbx_sensitivy.Text = ColorSensitivy.ToString();
            tbx_FinalReduction.Text = FindReduction.ToString();
        }

        private void btn_Load_Click(object sender, EventArgs e)
        {
           /* TheMainfrm.openFileDialog1.Filter = "BMP file |*.bmp|Jpeg Files(*.jpeg)|*.jpeg|Jpeg Files(*.jpg)|*.jpg|Png Files(*.png)|*.png|TIFF Files(*.tiff)|*.tiff|TIFF Files(*.tif)|*.tif";
            E_iVision_ERRORS err = E_iVision_ERRORS.E_NULL;
            Graphics g;
            if (TheMainfrm.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                path = TheMainfrm.openFileDialog1.FileName;
                err = iImage.iReadImage(TheMainfrm.ColorImg, path);
                if (err == E_iVision_ERRORS.E_OK)
                {
                    TheMainfrm.hbitmap = iImage.iGetBitmapAddress(TheMainfrm.ColorImg);
                    if (TheMainfrm.picturebox.Image != null)
                        TheMainfrm.picturebox.Image.Dispose();
                    TheMainfrm.picturebox.Image = System.Drawing.Image.FromHbitmap(TheMainfrm.hbitmap);
                    TheMainfrm.UsingColor = true;
                    TheMainfrm.picturebox.Refresh();
                    g = TheMainfrm.picturebox.CreateGraphics();
                    TheMainfrm.hDC = g.GetHdc();

                    iROI.iROIAttached(TheMainfrm.TrainROITool, TheMainfrm.ColorImg, TheMainfrm.hDC);
                    iROI.iROIAttached(TheMainfrm.MatchingROITool, TheMainfrm.ColorImg, TheMainfrm.hDC);
                }
                else
                {
                    MessageBox.Show(err.ToString(), "Error");
                    label2.Text = "Error";
                }
            }*/
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_LoadGrayImg_Click(object sender, EventArgs e)
        {

            //       err = iImage.iReadImage(TheMainfrm.GrayImg, path);
            Image<Gray,byte> imgCV =   TheMainfrm.GetImageFromVideo();
            string path = @"C:\\Users\\E100_AR VR\\Pictures\\test.bmp";
            imgCV.Save(path);

            //IntPtr aux = CvInvoke.cvCreateImage(imgCV.Size, Emgu.CV.CvEnum.IplDepth.IplDepth_8U, 2);
            // IntPtr imgOut = (IntPtr) Marshal.PtrToStructure(imgCV.Ptr, typeof(IntPtr));
            // //IntPtr pnt =  Marshal.AllocHGlobal(Marshal.SizeOf(imgCV.Ptr));

            //// Marshal.StructureToPtr(imgCV.Ptr, pnt, false);


            // var err = iImage.iPointerToiImage(TheMainfrm.GrayImg, imgOut, imgCV.Width, imgCV.Width);
            // if (err != E_iVision_ERRORS.E_OK)
            // {
            //     MessageBox.Show(err.ToString(), "ERROR");
            //     return;
            // }
            var err = iImage.ReadImage(TheMainfrm.Snap_GrayImg, path);
            if (err == E_iVision_ERRORS.E_OK)
            {
                TheMainfrm.hbitmap = iImage.GetBitmapAddress(TheMainfrm.GrayImg);
                if (TheMainfrm.pictureBox2.Image != null) TheMainfrm.pictureBox2.Image.Dispose();
                TheMainfrm.pictureBox2.Image = System.Drawing.Image.FromHbitmap(TheMainfrm.hbitmap);
            }
            TheMainfrm.pictureBox2.Refresh();
           
            
            iImage.ReadImage(TheMainfrm.GrayImg, path);
            Graphics g = TheMainfrm.GetGraphics();
            TheMainfrm.hDC = g.GetHdc();

            iROI.Attached(TheMainfrm.TrainROITool, TheMainfrm.GrayImg, TheMainfrm.hDC);
            iROI.Attached(TheMainfrm.MatchingROITool, TheMainfrm.GrayImg, TheMainfrm.hDC);

        }

        public void btn_NCCtraining_Click(object sender, EventArgs e)
        {
            E_iVision_ERRORS err = E_iVision_ERRORS.E_NULL;
            //UpData_NCC_Parameter();
            MinReduceArea = Convert.ToInt32(tbx_MinReduceArea.Text);
            err = iMatch.iSetMinReduceArea(TheMainfrm.Matchmodel, MinReduceArea);
            if (err != E_iVision_ERRORS.E_OK)
            { MessageBox.Show(err.ToString(), "Error"); label2.Text = "Error"; }
            else label2.Text = "E_OK";

            err = iMatch.iSetDontCareThreshold(TheMainfrm.Matchmodel, DontCarevalue);
            if (err != E_iVision_ERRORS.E_OK)
            { MessageBox.Show(err.ToString(), "Error"); label2.Text = "Error"; }
            else label2.Text = "E_OK";

            if (chk_TrainingFromROI.CheckState == CheckState.Checked)
            {
                iBaseROI l_rect = new iBaseROI();
                double[] l_data = new double[10];
                if (iROI.Size(TheMainfrm.TrainROITool) == 0)
                {
                    label2.Text = "ERROR: the size of ROI is 0.";
                    return;
                }
                l_rect = (iBaseROI)TheMainfrm.GetROIinfoByType(iROIType.BaseROI);
               

                iRect rect;
                rect.top = l_rect.org_y;
                rect.bottom = l_rect.org_y + l_rect.height;
                rect.left = l_rect.org_x;
                rect.right = l_rect.org_x + l_rect.width;

                if (TheMainfrm.UsingColor)
                {
                    err = iMatch.CreateNCCModelFromROI(TheMainfrm.ColorImg, TheMainfrm.Matchmodel, rect, UsingMask);
                    if (err != E_iVision_ERRORS.E_OK)
                    { MessageBox.Show(err.ToString(), "Error"); label2.Text = "Error"; }
                    else label2.Text = "E_OK";
                }
                else
                {
                    err = iMatch.CreateNCCModelFromROI(TheMainfrm.GrayImg, TheMainfrm.Matchmodel, rect, UsingMask);
                    if (err != E_iVision_ERRORS.E_OK)
                    { MessageBox.Show(err.ToString(), "Error"); label2.Text = "Error"; }
                    else label2.Text = "E_OK";
                }
                iROI.DeleteROI(TheMainfrm.TrainROITool);
                iROI.Plot(TheMainfrm.TrainROITool, TheMainfrm.hDC);
            }
            else
            {
                if (TheMainfrm.UsingColor)
                {
                    err = iMatch.CreateNCCModel(TheMainfrm.ColorImg, TheMainfrm.Matchmodel, UsingMask);
                    if (err != E_iVision_ERRORS.E_OK)
                    { MessageBox.Show(err.ToString(), "Error"); label2.Text = "Error"; }
                    else label2.Text = "E_OK";
                }
                else
                {
                    err = iMatch.CreateNCCModel(TheMainfrm.GrayImg, TheMainfrm.Matchmodel, UsingMask);
                    if (err != E_iVision_ERRORS.E_OK)
                    { MessageBox.Show(err.ToString(), "Error"); label2.Text = "Error"; }
                    else label2.Text = "E_OK";
                }
            }
        }


        void UpData_NCC_Parameter()
        {
            if (cbx_rotation.CheckState == CheckState.Checked) 
                UsingRotation = true;
            else 
                UsingRotation = false;

            if (cbx_scale.CheckState == CheckState.Checked)
                UsingScale = true;
            else
                UsingScale = false;

            if (cbx_dontcare.CheckState == CheckState.Checked)
                UsingMask = true;
            else
                UsingMask = false;

            if (chk_TrainingFromROI.CheckState == CheckState.Checked)
                TrainingFromROI = true;
             else
                TrainingFromROI = false;

            if (cbx_usingrobust.CheckState == CheckState.Checked)
                UsingRobust = true;
            else
                UsingRobust = false;

            if (cbx_ColorSimilarity.CheckState == CheckState.Checked)
                UsingCS = true;
            else
                UsingCS = false;

            if (cbx_usingsubpixel.CheckState == CheckState.Checked)
                UsingSubpixel = true;
            else
                UsingSubpixel = false;

            if (this.cbx_ColorSimilarity.CheckState == CheckState.Checked)
                UsingCS = true;
            else
                UsingCS = false;

            Max_objs = Convert.ToInt32(tbx_objnums.Text);
            MaxAng = Convert.ToDouble(tbx_maxang.Text);
            MinAng = Convert.ToDouble(tbx_minang.Text);
            MaxScale = Convert.ToDouble(tbx_maxscale.Text);
            MinScale = Convert.ToDouble(tbx_minscale.Text);
            MinScore = Convert.ToDouble(tbx_minscore.Text);
            DontCarevalue = Convert.ToInt32(tbx_dontcarethreshold.Text);
            ColorSensitivy = Convert.ToInt32(tbx_sensitivy.Text);
            FindReduction = Convert.ToInt32(tbx_FinalReduction.Text);
        }

        public void btn_NCCmatching_Click(object sender, EventArgs e)
        {
            E_iVision_ERRORS err = E_iVision_ERRORS.E_NULL;
            UpData_NCC_Parameter();

            iMatch.iSetMinScore(TheMainfrm.Matchmodel, MinScore);
            iMatch.iSetIsRotated(TheMainfrm.Matchmodel, UsingRotation);
            iMatch.iSetIsScaled(TheMainfrm.Matchmodel, UsingScale);
            iMatch.iSetOccurrence(TheMainfrm.Matchmodel, Max_objs);
            iMatch.iSetAngle(TheMainfrm.Matchmodel, MaxAng, MinAng);
            iMatch.iSetScale(TheMainfrm.Matchmodel, MaxScale, MinScale);
            iMatch.iSetDontCareThreshold(TheMainfrm.Matchmodel, DontCarevalue);
            iMatch.iSetRobustness(TheMainfrm.Matchmodel, UsingRobust);
            iMatch.iSetSubPixel(TheMainfrm.Matchmodel, UsingSubpixel);
            iMatch.iSetColorSimilarity(TheMainfrm.Matchmodel, UsingCS);
            iMatch.iSetColorSensitivity(TheMainfrm.Matchmodel, ColorSensitivy);
            iMatch.iSetFinalReduction(TheMainfrm.Matchmodel, FindReduction);

            err = iMatch.iIsPatternLearn(TheMainfrm.Matchmodel);
            if (err != E_iVision_ERRORS.E_TRUE)
            {
                MessageBox.Show(err.ToString(), "Error");
                 label2.Text = "Error";
                return;
            }

            if (!TheMainfrm.m_bPause)
            {
                TheMainfrm.m_bRTMatch = !TheMainfrm.m_bRTMatch;
                if (TheMainfrm.m_bRTMatch)
                    btn_NCCmatching.Text = "Stop";
                else
                    btn_NCCmatching.Text = "Matching";
                return;
            }


            int findnum = 0;
            string[] str = new string[6];
            double Execute_time = 0;

            dataGridView1.Rows.Clear();
            TheMainfrm.pictureBox1.Refresh();
            Graphics g = TheMainfrm.pictureBox1.CreateGraphics();

            if (TheMainfrm.m_bColorSensor)
            {
                sw.Reset();
                sw.Start();
                err = iMatch.MatchNCCModel(TheMainfrm.ColorImg, TheMainfrm.Matchmodel);
                sw.Stop();
                Execute_time = sw.ElapsedMilliseconds;
            }
            else
            {
                sw.Reset();
                sw.Start();
                err = iMatch.MatchNCCModel(TheMainfrm.GrayImg, TheMainfrm.Matchmodel);
                sw.Stop();
                Execute_time = sw.ElapsedMilliseconds;
            }

            if (err != E_iVision_ERRORS.E_OK)
            {
                MessageBox.Show(err.ToString(), "Error");
                label2.Text = "Error";
                return;
            }
            else label2.Text = E_iVision_ERRORS.E_OK.ToString();

            err = iMatch.iDrawiMatchResults(TheMainfrm.Matchmodel, g.GetHdc(), 1);

            err = iMatch.iGetNCCMatchNum(TheMainfrm.Matchmodel, ref findnum);
            if (err != E_iVision_ERRORS.E_OK)
            {
                MessageBox.Show(err.ToString(), "Error");
                label2.Text = "Error";
                return;
            }

            Execute_time /= findnum;
            for (int i = 0; i < findnum; i++)
            {
                err = iMatch.iGetNCCMatchResults(TheMainfrm.Matchmodel, i, ref objfind);

                str[0] = objfind.score.ToString("0.00");
                str[1] = objfind.cp.x.ToString("0.00");
                str[2] = objfind.cp.y.ToString("0.00");
                str[3] = objfind.angle.ToString("0.00");
                str[4] = objfind.scale.ToString("0.00");
                str[5] = Execute_time.ToString("0.00");

                dataGridView1.Rows.Add(str[0], str[1], str[2], str[3], str[4], str[5]);
            }
        }

        private void btn_ReadModel_Click(object sender, EventArgs e)
        {
           /* TheMainfrm.openFileDialog1.Filter = "iMatchModel file |*.imm";
            E_iVision_ERRORS err = E_iVision_ERRORS.E_NULL;
            if (TheMainfrm.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                path = TheMainfrm.openFileDialog1.FileName;

                err = iMatch.LoadiMatchModel(TheMainfrm.Matchmodel, path);

                if (err == E_iVision_ERRORS.E_OK)
                {
                    //更新參數到介面
                    iMatch.iGetOccurrence(TheMainfrm.Matchmodel,ref Max_objs);
                    iMatch.iGetAngle(TheMainfrm.Matchmodel, ref MaxAng, ref MinAng);
                    iMatch.iGetScale(TheMainfrm.Matchmodel, ref MaxScale, ref MinScale);
                    iMatch.iGetMinScore(TheMainfrm.Matchmodel, ref MinScore);
                    iMatch.iGetDontCareThreshold(TheMainfrm.Matchmodel, ref DontCarevalue);
                    iMatch.iGetMinReduceArea(TheMainfrm.Matchmodel, ref MinReduceArea);
                    iMatch.iGetIsRotated(TheMainfrm.Matchmodel,ref UsingRotation);
                    iMatch.iGetIsScaled(TheMainfrm.Matchmodel,ref UsingScale);
                    iMatch.iGetIsDontArea(TheMainfrm.Matchmodel, ref UsingMask);
                    iMatch.iGetRobustness(TheMainfrm.Matchmodel, ref UsingRotation);
                    iMatch.iGetColorSimilarity(TheMainfrm.Matchmodel, ref UsingCS);
                    iMatch.iGetSubPixel(TheMainfrm.Matchmodel, ref UsingSubpixel);
                    iMatch.iGetColorSensitivity(TheMainfrm.Matchmodel, ref ColorSensitivy);
                    iMatch.iGetFinalReduction(TheMainfrm.Matchmodel, ref FindReduction);

                    tbx_objnums.Text = Max_objs.ToString();
                    tbx_maxang.Text = MaxAng.ToString();
                    tbx_minang.Text = MinAng.ToString();
                    tbx_maxscale.Text = MaxScale.ToString();
                    tbx_minscale.Text = MinScale.ToString();
                    tbx_minscore.Text = MinScore.ToString();
                    tbx_dontcarethreshold.Text = DontCarevalue.ToString();
                    tbx_MinReduceArea.Text = MinReduceArea.ToString();
                    tbx_sensitivy.Text = ColorSensitivy.ToString();
                    tbx_FinalReduction.Text = FindReduction.ToString();
                    if (UsingRotation)
                        cbx_rotation.CheckState = CheckState.Checked;
                    else
                        cbx_rotation.CheckState = CheckState.Unchecked;

                    if (UsingScale)
                        cbx_scale.CheckState = CheckState.Checked;
                    else
                        cbx_scale.CheckState = CheckState.Unchecked;

                    if (UsingMask)
                        cbx_dontcare.CheckState = CheckState.Checked;
                    else
                        cbx_dontcare.CheckState = CheckState.Unchecked;

                    if (cbx_usingrobust.CheckState == CheckState.Checked)
                        UsingRobust = true;
                    else
                        UsingRobust = false;

                    if (cbx_ColorSimilarity.CheckState == CheckState.Checked)
                        UsingCS = true;
                    else
                        UsingCS = false;

                    if (cbx_usingsubpixel.CheckState == CheckState.Checked)
                        UsingSubpixel = true;
                    else
                        UsingSubpixel = false;

                    label2.Text = "OK";
                }
                else
                {
                    MessageBox.Show(err.ToString(), "Error");
                    label2.Text = "Error";
                }
            }*/
        }

        private void btn_SaveModel_Click(object sender, EventArgs e)
        {
           /* TheMainfrm.saveFileDialog1.Filter = "iMatchModel file |*.imm";
            TheMainfrm.saveFileDialog1.AddExtension = true;
            E_iVision_ERRORS err = E_iVision_ERRORS.E_NULL;
 
            UpData_NCC_Parameter();

            iMatch.iSetMinReduceArea(TheMainfrm.Matchmodel, MinReduceArea);
            iMatch.iSetMinScore(TheMainfrm.Matchmodel, MinScore);
            iMatch.iSetIsRotated(TheMainfrm.Matchmodel, UsingRotation);
            iMatch.iSetIsScaled(TheMainfrm.Matchmodel, UsingScale);
            iMatch.iSetIsDontArea(TheMainfrm.Matchmodel,UsingMask);
            iMatch.iSetOccurrence(TheMainfrm.Matchmodel, Max_objs);
            iMatch.iSetAngle(TheMainfrm.Matchmodel, MaxAng, MinAng);
            iMatch.iSetScale(TheMainfrm.Matchmodel, MaxScale, MinScale);
            iMatch.iSetDontCareThreshold(TheMainfrm.Matchmodel, DontCarevalue);
            iMatch.iSetRobustness(TheMainfrm.Matchmodel, UsingRotation);
            iMatch.iSetColorSimilarity(TheMainfrm.Matchmodel, UsingCS);
            iMatch.iSetSubPixel(TheMainfrm.Matchmodel, UsingSubpixel);
            iMatch.iSetColorSensitivity(TheMainfrm.Matchmodel, ColorSensitivy);
            iMatch.iSetFinalReduction(TheMainfrm.Matchmodel,  FindReduction);

            if (TheMainfrm.saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                path = TheMainfrm.saveFileDialog1.FileName;

                if (TheMainfrm.UsingColor)
                {
                    err = iImage.iImageIsNULL(TheMainfrm.ColorImg);
                    if (err == E_iVision_ERRORS.E_TRUE)
                    {
                        MessageBox.Show(err.ToString(), "Error");
                        label2.Text = "Error";
                        return;
                    }
                }
                else
                {
                    err = iImage.iImageIsNULL(TheMainfrm.GrayImg);
                    if (err == E_iVision_ERRORS.E_TRUE)
                    {
                        MessageBox.Show(err.ToString(), "Error");
                        label2.Text = "Error";
                        return;
                    }
                }

                err = iMatch.SaveiMatchModel(TheMainfrm.Matchmodel, path);
                if (err != E_iVision_ERRORS.E_OK)
                {
                    MessageBox.Show(err.ToString(), "Error");
                    label2.Text = "Error";
                }
                else
                    label2.Text = "OK";

            }*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            E_iVision_ERRORS err = E_iVision_ERRORS.E_NULL;

            err = iMatch.iVisitingKey();
            if (err != E_iVision_ERRORS.E_OK)
            {
                MessageBox.Show(err.ToString(), "Error");
                label2.Text = "Error";
            }
            else
                label2.Text = "OK";
        }

        public void AddBaseROI(object sender, EventArgs e)
        {
           // TheMainfrm.pictureBox2.Image = 
            //iROI.iROIManagerSetDrawScale(TheMainfrm.TrainROITool, TheMainfrm.hDC, TheMainfrm.GetScale());
            if (iROI.Size(TheMainfrm.TrainROITool) == 0)
            {
                iBaseROI l_base_roi;
                l_base_roi.org_x = 50;
                l_base_roi.org_y = 50;
                l_base_roi.width = 150;
                l_base_roi.height = 50;
                //TheMainfrm.pictureBox1.Refresh();
                iROI.AddBaseROI(TheMainfrm.TrainROITool, l_base_roi);
                iROI.Plot(TheMainfrm.TrainROITool, TheMainfrm.hDC);
            }
            else
                label2.Text = "the size of ROI is > 1.";
        }

        private void btn_MatchingROI_Click(object sender, EventArgs e)
        {
            iROI.SetDrawScale(TheMainfrm.MatchingROITool, TheMainfrm.hDC, TheMainfrm.GetScale());
            if (iROI.Size(TheMainfrm.MatchingROITool) == 0)
            {
                iBaseROI l_base_roi;
                l_base_roi.org_x = 50;
                l_base_roi.org_y = 50;
                l_base_roi.width = 50;
                l_base_roi.height = 50;
                iROI.AddBaseROI(TheMainfrm.MatchingROITool, l_base_roi);
                iROI.Plot(TheMainfrm.MatchingROITool, TheMainfrm.hDC);
            }
            else
                label2.Text = "the size of ROI is > 1.";
            
        }

        private void btn_DeleteMatchingROI_Click(object sender, EventArgs e)
        {
            iROI.DeleteROI(TheMainfrm.MatchingROITool);
            iROI.Plot(TheMainfrm.MatchingROITool, TheMainfrm.hDC);
        }


    }
}
