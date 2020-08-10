﻿/// <summary>
/// E_iVision_ERRORS VALUES enum
/// </summary>
namespace MVC.Vision.MiM
{
   
    public enum E_iVision_ERRORS : uint
    {
        E_OK = 0,
        E_FAILED,
        E_NULL,
        E_TRUE,
        E_FALSE,
        E_KEY_FAILD,
        //IIMAGE
        E_IIMAGE_NULL,
        E_IIMAGE_GETSUBIMAGE_FAILED,
        E_IIMAGE_RESIZE_FAILED,
        E_IIMAGE_SAVE_FAILED,
        E_IIMAGE_MEM_ERROR,
        E_IIMAGE_READIMAGE_FAILD,
        E_IIMAGE_SVAEIMAGE_FAILD,
        //iMatch
        E_IMATCH_IMAGE_NULL,
        E_IMTACH_CREATENCCMODEL_FAILED,
        E_IMATCH_INITIALMODEL_FAILED,
        E_IMATCH_PROCESS_FAILED,
        E_IMATCH_MODEL_MISMATCH,
        E_IMATCH_MEM_ERROR,
        E_IMATCH_VALUE_OUTOFRANGE,
        E_IMATCH_NON_TRAINING,
        //iFind
        E_IFIND_IMAGE_NULL,
        E_IFIND_IMAGE_TYPE_ERR,
        E_IFIND_INITIALMODEL_FAILED,
        E_IFIND_MEM_ERROR,
        E_IFIND_PROCESS_FAILED,
        E_IFIND_VALUE_OUTOFRANGE
    }
}