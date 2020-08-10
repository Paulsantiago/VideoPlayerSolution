using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace MVC.Vision.MiM.MiM_iVision
{
    // Declaring iImage class
    public class iImage
    {
        const string dllName = "iImage.x64.dll";

        [DllImport(dllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode, EntryPoint = "CreateGrayiImage")]
        public extern static IntPtr CreateGrayiImage();

        [DllImport(dllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode, EntryPoint = "CreateColoriImage")]
        public extern static IntPtr CreateColoriImage();

        [DllImport(dllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode, EntryPoint = "CreateGrayiImageEx")]
        public extern static IntPtr CreateGrayiImageEx(int wid, int hei);

        [DllImport(dllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode, EntryPoint = "CreateColoriImageEx")]
        public extern static IntPtr CreateColoriImageEx(int wid, int hei);

        [DllImport(dllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode, EntryPoint = "DestroyiImage")]
        public extern static E_iVision_ERRORS DestroyiImage(IntPtr iImg);
		
        [DllImport(dllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode, EntryPoint = "iImgCopy")]
        public extern static E_iVision_ERRORS Copy(IntPtr DestImg, IntPtr SrcImg);

        [DllImport(dllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode, EntryPoint = "iImgResize")]
        public extern static E_iVision_ERRORS Resize(IntPtr iImg, int width, int height);

        [DllImport(dllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode, EntryPoint = "iImgGetSubiImage")]
        public extern static E_iVision_ERRORS GetSubiImage(IntPtr DesiImg, IntPtr SrciImg, iRect ROI);

        [DllImport(dllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode, EntryPoint = "iImgGetWidth")]
        public extern static int GetWidth(IntPtr iImg);

        [DllImport(dllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode, EntryPoint = "iImgGetHeight")]
        public extern static int GetHeight(IntPtr iImg);

        [DllImport(dllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode, EntryPoint = "iImgIsNULL")]
        public extern static E_iVision_ERRORS IsNULL(IntPtr iImg);

        [DllImport(dllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode, EntryPoint = "iImgGetBitmapAddress")]
        public extern static IntPtr GetBitmapAddress(IntPtr iImg);

        [DllImport(dllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode, EntryPoint = "iImgGetPixelValue")]
        public extern static uint GetPixelValue(IntPtr iImg, int x, int y);

        [DllImport(dllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode, EntryPoint = "iImgPointerToiImage")]
        public extern static E_iVision_ERRORS PointerToiImage(IntPtr iImg, IntPtr DataSrc, int wid, int hei);

        [DllImport(dllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode, EntryPoint = "iImgPointerToiImageEx")]
        public extern static E_iVision_ERRORS PointerToiImageEx(IntPtr iImg, IntPtr DataSrc, int wid, int hei);

        [DllImport(dllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode, EntryPoint = "iImgPointerFromiImage")]
        public extern static E_iVision_ERRORS PointerFromiImage(IntPtr iImg, ref byte Destdata, int wid, int hei);

        [DllImport(dllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "iImgReadImage")]
        public extern static E_iVision_ERRORS ReadImage(IntPtr iImg, string filename);

        [DllImport(dllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "iImgSaveImage")]
        public extern static E_iVision_ERRORS SaveImage(IntPtr iImg, string filename);

        [DllImport(dllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode, EntryPoint = "iImgVarPtr")]
        public extern static IntPtr VarPtr(ref byte ptr);

        [DllImport(dllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode, EntryPoint = "iImgGetAlignedSize")]
        public extern static E_iVision_ERRORS GetCameraAlignSize(IntPtr iImg, ref Int32 AlignWid, ref Int32 AlignHei);

        [DllImport(dllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode, EntryPoint = "iImgDoBitBlt")]
        public extern static E_iVision_ERRORS DoBitBlt(IntPtr iImg, IntPtr hdc, int nXdest, int nYdest, int width, int height,
                                                                                                        int nXsrc, int nYsrc);

        [DllImport(dllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode, EntryPoint = "iImgDoStretchBitBlt")]
        public extern static E_iVision_ERRORS DoStretchBitBlt(IntPtr iImg, IntPtr hdc, int nXdest, int nYdest,
                                     int nDestWidth, int nDestHeight, int nXsrc, int nYsrc, int xSrcWidth, int xSrcHeight);

    }

}