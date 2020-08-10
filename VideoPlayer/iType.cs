using System;
using System.Runtime.InteropServices;

namespace MVC.Vision.MiM
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public struct iRGB24
    {
        public byte b;
        public byte g;
        public byte r;
    };
    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public struct iIPoint
    {
        public int x;
        public int y;
    }
    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public struct iDPoint
    {
        public double x;
        public double y;
    }
    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public struct iFPoint
    {
        public float x;
        public float y;
    }
    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public struct iFP_rect
    {
        public iFPoint pos1;
        public iFPoint pos2;
        public iFPoint pos3;
        public iFPoint pos4;
    };
    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public struct iMBR
    {
        public iFPoint cp;
        public float height;
        public float width;
        public float angle;
        public iFP_rect MBR_point;
    };
    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public struct iColorMean
    {
        public double r;
        public double g;
        public double b;
    };
    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public struct iRect
    {
        public int top;
        public int bottom;
        public int left;
        public int right;
    }
    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public struct iNCCFound
    {
        public int width;
        public int height;

        public iDPoint cp;
        public double angle;
        public double scale;
        public double score;
    }
    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public struct iGeometryFound
    {
        public iDPoint cp;
        public double score;
        public double angle;
        public double scale;
    }
    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public struct iCircle
    {
        public iDPoint cp;
        public double diameter;
        public double roundness;
        public double PL_Difference;
    }
    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public struct iLine
    {
        public iDPoint p1;
        public iDPoint p2;
        public iDPoint midpoint;
        public double a;
        public double b;
        public double c;
        public double angle;
    }
    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public struct iLinePair
    {
        public double width;
        public iLine line1;
        public iLine line2;
        public iLine center_line;
    }
    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public struct iTriangle
    {
        public iIPoint crosspoint;
        public double angle;
    };
    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public struct iCircle2Line
    {
        public iIPoint p1;
        public iIPoint p2;
        public double distance;
    }
    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public struct iBaseROI
    {
        public int org_x;
        public int org_y;
        public int width;
        public int height;
    }
    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public struct iAdvanceROI
    {
        public iIPoint cp;
        public int width;
        public int height;
        public double angle;
    }
    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public struct iAdvPairROI
    {
        public iIPoint base_cp;
        public int distance;
        public int base_width;
        public int base_height;
        public int target_width;
        public int target_height;
        public double angle;
    }
    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public struct iTriAdvPairROI
    {
        public iIPoint base_cp;
        public int base_width;
        public int base_height;
        public double base_angle;
        public iIPoint target_cp;
        public int target_width;
        public int target_height;
        public double target_angle;
    }
    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public struct iRectangleROI
    {
        public iIPoint cp;
        public int width;
        public int height;
        public int gap;
        public double angle;
    }
    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public struct iRingROI
    {
        public iIPoint cp;
        public int inner_radius;
        public int outer_radius;
    }
    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public struct iAdvRingROI
    {
        public iIPoint cp;
        public double start_angle;
        public double end_angle;
        public int inner_radius;
        public int outer_radius;
    }
    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public struct iCircleROI
    {
        public iIPoint cp;
        public double radius;
    }

    public enum iROIType
    {
        UnknownROIType = 0,
        BaseROI,
        AdvanceROI,
        AdvPairROI,
        CircleROI,
        RingROI,
        AdvRingROI,
        TriAdvPairROI
    };

    public enum iObjectColor
    {
        OBJ_Black = 0,
        OBJ_White = 255
    };

    [StructLayout(LayoutKind.Sequential)]
    public struct iObjectFEA
    {
        public long area;
        public iDPoint cp;
        public iMBR MBR;
        public int index;
    }

    public enum iIgnoreType

    {
        UnknownIgnoreType = 0,
        InnerRectangle = 1,
        OuterRectangle = 2,
        InnerCircle = 3,
        OuterCircle = 4
    };

    [StructLayout(LayoutKind.Sequential)]
    public struct iIgnore
    {
        public iAdvanceROI advance;
        public iCircleROI circle;
        public iIgnoreType ignore_type;
    }

    enum iTransitionType
    {
        BlackToWhite = 0,
        WhiteToBlack = 1,
        Both = 2
    };

    enum iCharColor
    {
        LightOnDark = 0,
        DarkOnLight = 1
    };


    
}

