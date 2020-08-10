using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace MVC.Vision.MiM.MiM_iVision
{
    // Declaring iROI class
    public class iROI
    {
        const string dllName = "iROI_x64.dll";

        [DllImport(dllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode, EntryPoint = "CreateiROIManager")]
        public extern static IntPtr CreateiROIManager();

        [DllImport(dllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode, EntryPoint = "DestroyiROIManager")]
        public extern static void DestroyiROIManager(IntPtr a_iROI);

        [DllImport(dllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode, EntryPoint = "iROIAddBaseROI")]
        public extern static E_iVision_ERRORS AddBaseROI(IntPtr a_iROI, iBaseROI a_base_roi);

        [DllImport(dllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode, EntryPoint = "iROIAddAdvanceROI")]
        public extern static E_iVision_ERRORS AddAdvanceROI(IntPtr a_iROI, iAdvanceROI a_adv_roi);

        //[DllImport(dllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode, EntryPoint = "iROIAddRectangleROI")]
        //public extern static E_iVision_ERRORS AddRectangleROI(IntPtr a_iROI, iRectangleROI a_rectangle_roi);

        [DllImport(dllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode, EntryPoint = "iROIAddAdvPairROI")]
        public extern static E_iVision_ERRORS AddAdvPairROI(IntPtr a_iROI, iAdvPairROI a_AdvPair_roi);

        [DllImport(dllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode, EntryPoint = "iROIAddTriAdvPairROI")]
        public extern static E_iVision_ERRORS AddTriAdvPairROI(IntPtr a_iROI, iTriAdvPairROI a_TriAdvPair_roi);

        [DllImport(dllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode, EntryPoint = "iROIAddAdvRingROI")]
        public extern static E_iVision_ERRORS AddAdvRingROI(IntPtr a_iROI, iAdvRingROI a_advring_roi);

        [DllImport(dllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode, EntryPoint = "iROIAddCircleROI")]
        public extern static E_iVision_ERRORS AddCircleROI(IntPtr a_iROI, iCircleROI a_circle_roi);

        [DllImport(dllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode, EntryPoint = "iROIAddRingROI")]
        public extern static E_iVision_ERRORS AddRingROI(IntPtr a_iROI, iRingROI a_ring_roi);

        [DllImport(dllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode, EntryPoint = "iROIAssignBaseROI")]
        public extern static E_iVision_ERRORS AssignBaseROI(IntPtr a_iROI, iBaseROI a_base_roi);

        [DllImport(dllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode, EntryPoint = "iROIAssignAdvanceROI")]
        public extern static E_iVision_ERRORS AssignAdvanceROI(IntPtr a_iROI, iAdvanceROI a_adv_roi);

        //[DllImport(dllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode, EntryPoint = "iROIAssignRectangleROI")]
        //public extern static E_iVision_ERRORS AssignRectangleROI(IntPtr a_iROI, iRectangleROI a_rectangle_roi);

        [DllImport(dllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode, EntryPoint = "iROIAssignAdvPairROI")]
        public extern static E_iVision_ERRORS AssignAdvPairROI(IntPtr a_iROI, iAdvPairROI a_AdvPair_roi);

        [DllImport(dllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode, EntryPoint = "iROIAssignTriAdvPairROI")]
        public extern static E_iVision_ERRORS AssignTriAdvPairROI(IntPtr a_iROI, iTriAdvPairROI a_TriAdvPair_roi);

        [DllImport(dllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode, EntryPoint = "iROIAssignAdvRingROI")]
        public extern static E_iVision_ERRORS AssignAdvRingROI(IntPtr a_iROI, iAdvRingROI a_arc_roi);

        [DllImport(dllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode, EntryPoint = "iROIAssignCircleROI")]
        public extern static E_iVision_ERRORS AssignCircleROI(IntPtr a_iROI, iCircleROI a_circle_roi);

        [DllImport(dllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode, EntryPoint = "iROIAssignRingROI")]
        public extern static E_iVision_ERRORS AssignRingROI(IntPtr a_iROI, iRingROI a_ring_roi);

        [DllImport(dllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode, EntryPoint = "iROIMouseMove")]
        public extern static E_iVision_ERRORS MouseMove(IntPtr a_iROI, IntPtr a_hDC, int a_mouse_x, int a_mouse_y);

        [DllImport(dllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode, EntryPoint = "iROIMouseDown")]
        public extern static E_iVision_ERRORS MouseDown(IntPtr a_iROI, IntPtr a_hDC, int a_mouse_x, int a_mouse_y);

        [DllImport(dllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode, EntryPoint = "iROISetFinish")]
        public extern static E_iVision_ERRORS SetFinish(IntPtr a_iROI, IntPtr a_hDC);

        [DllImport(dllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode, EntryPoint = "iROIAttached")]
        public extern static E_iVision_ERRORS Attached(IntPtr a_iROI, IntPtr a_img, IntPtr a_hDC);

        [DllImport(dllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode, EntryPoint = "iROIAttachedDC")]
        public extern static E_iVision_ERRORS AttachedDC(IntPtr a_iROI, IntPtr a_hDC, int a_wid, int a_hei);

        [DllImport(dllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode, EntryPoint = "iROISetDrawScale")]
        public extern static E_iVision_ERRORS SetDrawScale(IntPtr a_iROI, IntPtr a_hDC, double a_scale);

        [DllImport(dllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode, EntryPoint = "iROIDetached")]
        public extern static E_iVision_ERRORS Detached(IntPtr a_iROI, IntPtr a_hDC);

        [DllImport(dllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode, EntryPoint = "iROIPlot")]
        public extern static E_iVision_ERRORS Plot(IntPtr a_iROI, IntPtr a_hDC);

        [DllImport(dllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode, EntryPoint = "iROIDeleteROI")]
        public extern static E_iVision_ERRORS DeleteROI(IntPtr a_iROI);

        [DllImport(dllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode, EntryPoint = "iROIGetType")]
        public extern static iROIType GetType(IntPtr a_iROI, int a_index);

        [DllImport(dllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode, EntryPoint = "iROIGetInfo")]
        public extern static iROIType GetInfo(IntPtr a_iROI, IntPtr ap_data);

        [DllImport(dllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode, EntryPoint = "iROIGetInfoIndex")]
        public extern static iROIType GetInfoIndex(IntPtr a_iROI, int a_index, IntPtr ap_data);

        [DllImport(dllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode, EntryPoint = "iROIGetWorkingIndex")]
        public extern static int GetWorkingIndex(IntPtr a_iROI);

        [DllImport(dllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode, EntryPoint = "iROIDeleteROIIndex")]
        public extern static E_iVision_ERRORS DeleteROIIndex(IntPtr a_iROI, int a_index);

        [DllImport(dllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode, EntryPoint = "iROIDeleteAll")]
        public extern static E_iVision_ERRORS DeleteAll(IntPtr a_iROI);

        [DllImport(dllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode, EntryPoint = "iROISetActive")]
        public extern static E_iVision_ERRORS SetActive(IntPtr a_iROI, int a_index);

        [DllImport(dllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode, EntryPoint = "iROISize")]
        public extern static int Size(IntPtr a_iROI);

        [DllImport(dllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "iROISetName")]
        public extern static E_iVision_ERRORS iROISetName(IntPtr a_iROI, string a_set_name);

        [DllImport(dllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "iROILoad")]
        public extern static E_iVision_ERRORS Load(IntPtr a_iROI, string ap_file_path);

        [DllImport(dllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "iROISave")]
        public extern static E_iVision_ERRORS Save(IntPtr a_iROI, string ap_file_path);

        [DllImport(dllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode, EntryPoint = "iROI_VisitingKey")]
        public extern static E_iVision_ERRORS VisitingKey();
    }
}