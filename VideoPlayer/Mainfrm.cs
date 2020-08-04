using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using MiM_iVision;

namespace Warp_Csharp
{
    public partial class Mainfrm : Form
    {
        iMatchDialog ncc;

        public IntPtr GrayImg = iImage.CreateGrayiImage();
        public IntPtr ColorImg = iImage.CreateColoriImage();
        public IntPtr hbitmap;
        public IntPtr NCCmodel = iMatch.CreateNCCMatch();
        public IntPtr TrainROITool = iROI.CreateiROIManager();
        public IntPtr MatchingROITool = iROI.CreateiROIManager();

        public bool UsingColor = false;
        public IntPtr hDC;

        public Mainfrm()
        {
            InitializeComponent();
            //ncc = new iMatchDialog(this);
        }

        private void openNCCDialogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ncc.Show();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void keyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int serial = 0;
            E_iVision_ERRORS err = iVision.iGetKeySerial(ref serial);

            MessageBox.Show("Key State:" + err.ToString() + " Serial:" + serial.ToString(), "Information");
        }

        private void getVersionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IntPtr ptr = iVision.iGetiMatchVersion();
            string str = Marshal.PtrToStringAnsi(ptr);

            ptr = iVision.iGetiMatchVersionDate();
            string strdate = Marshal.PtrToStringAnsi(ptr);

            MessageBox.Show(str.ToString()+ "   "+ strdate.ToString(), "Information");
        }

        private void Mainfrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            iMatch.DestroyNCCMatch(NCCmodel);
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

