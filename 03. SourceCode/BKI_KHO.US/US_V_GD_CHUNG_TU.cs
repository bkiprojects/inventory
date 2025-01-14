///************************************************
/// Generated by: tuyendv
/// Date: 12/05/2014 05:29:28
/// Goal: Create User Service Class for V_GD_CHUNG_TU
///************************************************
/// <summary>
/// Create User Service Class for V_GD_CHUNG_TU
/// </summary>

using System;
using BKI_KHO.DS;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;



namespace BKI_KHO.US{

public class US_V_GD_CHUNG_TU : US_Object
{
	private const string c_TableName = "V_GD_CHUNG_TU";
#region "Public Properties"
    public decimal dcID
    {
        get
        {
            return CNull.RowNVLDecimal(pm_objDR, "ID", IPConstants.c_DefaultDecimal);
        }
        set
        {
            pm_objDR["ID"] = value;
        }
    }

    public bool IsIDNull()
    {
        return pm_objDR.IsNull("ID");
    }

    public void SetIDNull()
    {
        pm_objDR["ID"] = System.Convert.DBNull;
    }

    public decimal dcID_LOAI_CT
    {
        get
        {
            return CNull.RowNVLDecimal(pm_objDR, "ID_LOAI_CT", IPConstants.c_DefaultDecimal);
        }
        set
        {
            pm_objDR["ID_LOAI_CT"] = value;
        }
    }

    public bool IsID_LOAI_CTNull()
    {
        return pm_objDR.IsNull("ID_LOAI_CT");
    }

    public void SetID_LOAI_CTNull()
    {
        pm_objDR["ID_LOAI_CT"] = System.Convert.DBNull;
    }

    public string strMA_CT
    {
        get
        {
            return CNull.RowNVLString(pm_objDR, "MA_CT", IPConstants.c_DefaultString);
        }
        set
        {
            pm_objDR["MA_CT"] = value;
        }
    }

    public bool IsMA_CTNull()
    {
        return pm_objDR.IsNull("MA_CT");
    }

    public void SetMA_CTNull()
    {
        pm_objDR["MA_CT"] = System.Convert.DBNull;
    }

    public DateTime datNGAY_CT
    {
        get
        {
            return CNull.RowNVLDate(pm_objDR, "NGAY_CT", IPConstants.c_DefaultDate);
        }
        set
        {
            pm_objDR["NGAY_CT"] = value;
        }
    }

    public bool IsNGAY_CTNull()
    {
        return pm_objDR.IsNull("NGAY_CT");
    }

    public void SetNGAY_CTNull()
    {
        pm_objDR["NGAY_CT"] = System.Convert.DBNull;
    }

    public string strDIEN_GIAI
    {
        get
        {
            return CNull.RowNVLString(pm_objDR, "DIEN_GIAI", IPConstants.c_DefaultString);
        }
        set
        {
            pm_objDR["DIEN_GIAI"] = value;
        }
    }

    public bool IsDIEN_GIAINull()
    {
        return pm_objDR.IsNull("DIEN_GIAI");
    }

    public void SetDIEN_GIAINull()
    {
        pm_objDR["DIEN_GIAI"] = System.Convert.DBNull;
    }

    public decimal dcTONG_TIEN
    {
        get
        {
            return CNull.RowNVLDecimal(pm_objDR, "TONG_TIEN", IPConstants.c_DefaultDecimal);
        }
        set
        {
            pm_objDR["TONG_TIEN"] = value;
        }
    }

    public bool IsTONG_TIENNull()
    {
        return pm_objDR.IsNull("TONG_TIEN");
    }

    public void SetTONG_TIENNull()
    {
        pm_objDR["TONG_TIEN"] = System.Convert.DBNull;
    }

    public decimal dcID_TO_CHUC_NGUON
    {
        get
        {
            return CNull.RowNVLDecimal(pm_objDR, "ID_TO_CHUC_NGUON", IPConstants.c_DefaultDecimal);
        }
        set
        {
            pm_objDR["ID_TO_CHUC_NGUON"] = value;
        }
    }

    public bool IsID_TO_CHUC_NGUONNull()
    {
        return pm_objDR.IsNull("ID_TO_CHUC_NGUON");
    }

    public void SetID_TO_CHUC_NGUONNull()
    {
        pm_objDR["ID_TO_CHUC_NGUON"] = System.Convert.DBNull;
    }

    public decimal dcID_NGUOI_GIAO_DICH
    {
        get
        {
            return CNull.RowNVLDecimal(pm_objDR, "ID_NGUOI_GIAO_DICH", IPConstants.c_DefaultDecimal);
        }
        set
        {
            pm_objDR["ID_NGUOI_GIAO_DICH"] = value;
        }
    }

    public bool IsID_NGUOI_GIAO_DICHNull()
    {
        return pm_objDR.IsNull("ID_NGUOI_GIAO_DICH");
    }

    public void SetID_NGUOI_GIAO_DICHNull()
    {
        pm_objDR["ID_NGUOI_GIAO_DICH"] = System.Convert.DBNull;
    }

    public decimal dcID_TO_CHUC_DICH
    {
        get
        {
            return CNull.RowNVLDecimal(pm_objDR, "ID_TO_CHUC_DICH", IPConstants.c_DefaultDecimal);
        }
        set
        {
            pm_objDR["ID_TO_CHUC_DICH"] = value;
        }
    }

    public bool IsID_TO_CHUC_DICHNull()
    {
        return pm_objDR.IsNull("ID_TO_CHUC_DICH");
    }

    public void SetID_TO_CHUC_DICHNull()
    {
        pm_objDR["ID_TO_CHUC_DICH"] = System.Convert.DBNull;
    }

    public decimal dcID_NGUOI_NHAP
    {
        get
        {
            return CNull.RowNVLDecimal(pm_objDR, "ID_NGUOI_NHAP", IPConstants.c_DefaultDecimal);
        }
        set
        {
            pm_objDR["ID_NGUOI_NHAP"] = value;
        }
    }

    public bool IsID_NGUOI_NHAPNull()
    {
        return pm_objDR.IsNull("ID_NGUOI_NHAP");
    }

    public void SetID_NGUOI_NHAPNull()
    {
        pm_objDR["ID_NGUOI_NHAP"] = System.Convert.DBNull;
    }

    public DateTime datNGAY_NHAP
    {
        get
        {
            return CNull.RowNVLDate(pm_objDR, "NGAY_NHAP", IPConstants.c_DefaultDate);
        }
        set
        {
            pm_objDR["NGAY_NHAP"] = value;
        }
    }

    public bool IsNGAY_NHAPNull()
    {
        return pm_objDR.IsNull("NGAY_NHAP");
    }

    public void SetNGAY_NHAPNull()
    {
        pm_objDR["NGAY_NHAP"] = System.Convert.DBNull;
    }

    public DateTime datNGAY_NHAP_CUOI
    {
        get
        {
            return CNull.RowNVLDate(pm_objDR, "NGAY_NHAP_CUOI", IPConstants.c_DefaultDate);
        }
        set
        {
            pm_objDR["NGAY_NHAP_CUOI"] = value;
        }
    }

    public bool IsNGAY_NHAP_CUOINull()
    {
        return pm_objDR.IsNull("NGAY_NHAP_CUOI");
    }

    public void SetNGAY_NHAP_CUOINull()
    {
        pm_objDR["NGAY_NHAP_CUOI"] = System.Convert.DBNull;
    }

    public string strGHI_CHU_1
    {
        get
        {
            return CNull.RowNVLString(pm_objDR, "GHI_CHU_1", IPConstants.c_DefaultString);
        }
        set
        {
            pm_objDR["GHI_CHU_1"] = value;
        }
    }

    public bool IsGHI_CHU_1Null()
    {
        return pm_objDR.IsNull("GHI_CHU_1");
    }

    public void SetGHI_CHU_1Null()
    {
        pm_objDR["GHI_CHU_1"] = System.Convert.DBNull;
    }

    public string strGHI_CHU_2
    {
        get
        {
            return CNull.RowNVLString(pm_objDR, "GHI_CHU_2", IPConstants.c_DefaultString);
        }
        set
        {
            pm_objDR["GHI_CHU_2"] = value;
        }
    }

    public bool IsGHI_CHU_2Null()
    {
        return pm_objDR.IsNull("GHI_CHU_2");
    }

    public void SetGHI_CHU_2Null()
    {
        pm_objDR["GHI_CHU_2"] = System.Convert.DBNull;
    }

    public string strGHI_CHU_3
    {
        get
        {
            return CNull.RowNVLString(pm_objDR, "GHI_CHU_3", IPConstants.c_DefaultString);
        }
        set
        {
            pm_objDR["GHI_CHU_3"] = value;
        }
    }

    public bool IsGHI_CHU_3Null()
    {
        return pm_objDR.IsNull("GHI_CHU_3");
    }

    public void SetGHI_CHU_3Null()
    {
        pm_objDR["GHI_CHU_3"] = System.Convert.DBNull;
    }

    public decimal dcID_CHUNG_TU_DETAIL
    {
        get
        {
            return CNull.RowNVLDecimal(pm_objDR, "ID_CHUNG_TU_DETAIL", IPConstants.c_DefaultDecimal);
        }
        set
        {
            pm_objDR["ID_CHUNG_TU_DETAIL"] = value;
        }
    }

    public bool IsID_CHUNG_TU_DETAILNull()
    {
        return pm_objDR.IsNull("ID_CHUNG_TU_DETAIL");
    }

    public void SetID_CHUNG_TU_DETAILNull()
    {
        pm_objDR["ID_CHUNG_TU_DETAIL"] = System.Convert.DBNull;
    }

    public decimal dcID_HANG_HOA
    {
        get
        {
            return CNull.RowNVLDecimal(pm_objDR, "ID_HANG_HOA", IPConstants.c_DefaultDecimal);
        }
        set
        {
            pm_objDR["ID_HANG_HOA"] = value;
        }
    }

    public bool IsID_HANG_HOANull()
    {
        return pm_objDR.IsNull("ID_HANG_HOA");
    }

    public void SetID_HANG_HOANull()
    {
        pm_objDR["ID_HANG_HOA"] = System.Convert.DBNull;
    }

    public decimal dcSO_LUONG
    {
        get
        {
            return CNull.RowNVLDecimal(pm_objDR, "SO_LUONG", IPConstants.c_DefaultDecimal);
        }
        set
        {
            pm_objDR["SO_LUONG"] = value;
        }
    }

    public bool IsSO_LUONGNull()
    {
        return pm_objDR.IsNull("SO_LUONG");
    }

    public void SetSO_LUONGNull()
    {
        pm_objDR["SO_LUONG"] = System.Convert.DBNull;
    }

    public decimal dcGIA_GIAO_DICH
    {
        get
        {
            return CNull.RowNVLDecimal(pm_objDR, "GIA_GIAO_DICH", IPConstants.c_DefaultDecimal);
        }
        set
        {
            pm_objDR["GIA_GIAO_DICH"] = value;
        }
    }

    public bool IsGIA_GIAO_DICHNull()
    {
        return pm_objDR.IsNull("GIA_GIAO_DICH");
    }

    public void SetGIA_GIAO_DICHNull()
    {
        pm_objDR["GIA_GIAO_DICH"] = System.Convert.DBNull;
    }

    public decimal dcID_DON_VI_TINH
    {
        get
        {
            return CNull.RowNVLDecimal(pm_objDR, "ID_DON_VI_TINH", IPConstants.c_DefaultDecimal);
        }
        set
        {
            pm_objDR["ID_DON_VI_TINH"] = value;
        }
    }

    public bool IsID_DON_VI_TINHNull()
    {
        return pm_objDR.IsNull("ID_DON_VI_TINH");
    }

    public void SetID_DON_VI_TINHNull()
    {
        pm_objDR["ID_DON_VI_TINH"] = System.Convert.DBNull;
    }

    public string strSO_SERI
    {
        get
        {
            return CNull.RowNVLString(pm_objDR, "SO_SERI", IPConstants.c_DefaultString);
        }
        set
        {
            pm_objDR["SO_SERI"] = value;
        }
    }

    public bool IsSO_SERINull()
    {
        return pm_objDR.IsNull("SO_SERI");
    }

    public void SetSO_SERINull()
    {
        pm_objDR["SO_SERI"] = System.Convert.DBNull;
    }

    public decimal dcTHOI_GIAN_BH
    {
        get
        {
            return CNull.RowNVLDecimal(pm_objDR, "THOI_GIAN_BH", IPConstants.c_DefaultDecimal);
        }
        set
        {
            pm_objDR["THOI_GIAN_BH"] = value;
        }
    }

    public bool IsTHOI_GIAN_BHNull()
    {
        return pm_objDR.IsNull("THOI_GIAN_BH");
    }

    public void SetTHOI_GIAN_BHNull()
    {
        pm_objDR["THOI_GIAN_BH"] = System.Convert.DBNull;
    }

    public decimal dcID_DVT_THOI_GIAN
    {
        get
        {
            return CNull.RowNVLDecimal(pm_objDR, "ID_DVT_THOI_GIAN", IPConstants.c_DefaultDecimal);
        }
        set
        {
            pm_objDR["ID_DVT_THOI_GIAN"] = value;
        }
    }

    public bool IsID_DVT_THOI_GIANNull()
    {
        return pm_objDR.IsNull("ID_DVT_THOI_GIAN");
    }

    public void SetID_DVT_THOI_GIANNull()
    {
        pm_objDR["ID_DVT_THOI_GIAN"] = System.Convert.DBNull;
    }

    public string strGHI_CHU
    {
        get
        {
            return CNull.RowNVLString(pm_objDR, "GHI_CHU", IPConstants.c_DefaultString);
        }
        set
        {
            pm_objDR["GHI_CHU"] = value;
        }
    }

    public bool IsGHI_CHUNull()
    {
        return pm_objDR.IsNull("GHI_CHU");
    }

    public void SetGHI_CHUNull()
    {
        pm_objDR["GHI_CHU"] = System.Convert.DBNull;
    }

    public string strMA_LOAI_CT
    {
        get
        {
            return CNull.RowNVLString(pm_objDR, "MA_LOAI_CT", IPConstants.c_DefaultString);
        }
        set
        {
            pm_objDR["MA_LOAI_CT"] = value;
        }
    }

    public bool IsMA_LOAI_CTNull()
    {
        return pm_objDR.IsNull("MA_LOAI_CT");
    }

    public void SetMA_LOAI_CTNull()
    {
        pm_objDR["MA_LOAI_CT"] = System.Convert.DBNull;
    }

    public string strTEN_LOAI_CT
    {
        get
        {
            return CNull.RowNVLString(pm_objDR, "TEN_LOAI_CT", IPConstants.c_DefaultString);
        }
        set
        {
            pm_objDR["TEN_LOAI_CT"] = value;
        }
    }

    public bool IsTEN_LOAI_CTNull()
    {
        return pm_objDR.IsNull("TEN_LOAI_CT");
    }

    public void SetTEN_LOAI_CTNull()
    {
        pm_objDR["TEN_LOAI_CT"] = System.Convert.DBNull;
    }

    public decimal dcID_NHOM_GOC
    {
        get
        {
            return CNull.RowNVLDecimal(pm_objDR, "ID_NHOM_GOC", IPConstants.c_DefaultDecimal);
        }
        set
        {
            pm_objDR["ID_NHOM_GOC"] = value;
        }
    }

    public bool IsID_NHOM_GOCNull()
    {
        return pm_objDR.IsNull("ID_NHOM_GOC");
    }

    public void SetID_NHOM_GOCNull()
    {
        pm_objDR["ID_NHOM_GOC"] = System.Convert.DBNull;
    }

    public decimal dcID_NHOM
    {
        get
        {
            return CNull.RowNVLDecimal(pm_objDR, "ID_NHOM", IPConstants.c_DefaultDecimal);
        }
        set
        {
            pm_objDR["ID_NHOM"] = value;
        }
    }

    public bool IsID_NHOMNull()
    {
        return pm_objDR.IsNull("ID_NHOM");
    }

    public void SetID_NHOMNull()
    {
        pm_objDR["ID_NHOM"] = System.Convert.DBNull;
    }

    public string strMA_HANG
    {
        get
        {
            return CNull.RowNVLString(pm_objDR, "MA_HANG", IPConstants.c_DefaultString);
        }
        set
        {
            pm_objDR["MA_HANG"] = value;
        }
    }

    public bool IsMA_HANGNull()
    {
        return pm_objDR.IsNull("MA_HANG");
    }

    public void SetMA_HANGNull()
    {
        pm_objDR["MA_HANG"] = System.Convert.DBNull;
    }

    public string strTEN_HANG_VN
    {
        get
        {
            return CNull.RowNVLString(pm_objDR, "TEN_HANG_VN", IPConstants.c_DefaultString);
        }
        set
        {
            pm_objDR["TEN_HANG_VN"] = value;
        }
    }

    public bool IsTEN_HANG_VNNull()
    {
        return pm_objDR.IsNull("TEN_HANG_VN");
    }

    public void SetTEN_HANG_VNNull()
    {
        pm_objDR["TEN_HANG_VN"] = System.Convert.DBNull;
    }

    public string strTEN_HANG_EN
    {
        get
        {
            return CNull.RowNVLString(pm_objDR, "TEN_HANG_EN", IPConstants.c_DefaultString);
        }
        set
        {
            pm_objDR["TEN_HANG_EN"] = value;
        }
    }

    public bool IsTEN_HANG_ENNull()
    {
        return pm_objDR.IsNull("TEN_HANG_EN");
    }

    public void SetTEN_HANG_ENNull()
    {
        pm_objDR["TEN_HANG_EN"] = System.Convert.DBNull;
    }

    public string strIMAGE
    {
        get
        {
            return CNull.RowNVLString(pm_objDR, "IMAGE", IPConstants.c_DefaultString);
        }
        set
        {
            pm_objDR["IMAGE"] = value;
        }
    }

    public bool IsIMAGENull()
    {
        return pm_objDR.IsNull("IMAGE");
    }

    public void SetIMAGENull()
    {
        pm_objDR["IMAGE"] = System.Convert.DBNull;
    }

    public string strMO_TA
    {
        get
        {
            return CNull.RowNVLString(pm_objDR, "MO_TA", IPConstants.c_DefaultString);
        }
        set
        {
            pm_objDR["MO_TA"] = value;
        }
    }

    public bool IsMO_TANull()
    {
        return pm_objDR.IsNull("MO_TA");
    }

    public void SetMO_TANull()
    {
        pm_objDR["MO_TA"] = System.Convert.DBNull;
    }

    public decimal dcID_NHA_CUNG_CAP
    {
        get
        {
            return CNull.RowNVLDecimal(pm_objDR, "ID_NHA_CUNG_CAP", IPConstants.c_DefaultDecimal);
        }
        set
        {
            pm_objDR["ID_NHA_CUNG_CAP"] = value;
        }
    }

    public bool IsID_NHA_CUNG_CAPNull()
    {
        return pm_objDR.IsNull("ID_NHA_CUNG_CAP");
    }

    public void SetID_NHA_CUNG_CAPNull()
    {
        pm_objDR["ID_NHA_CUNG_CAP"] = System.Convert.DBNull;
    }

    public string strBARCODE
    {
        get
        {
            return CNull.RowNVLString(pm_objDR, "BARCODE", IPConstants.c_DefaultString);
        }
        set
        {
            pm_objDR["BARCODE"] = value;
        }
    }

    public bool IsBARCODENull()
    {
        return pm_objDR.IsNull("BARCODE");
    }

    public void SetBARCODENull()
    {
        pm_objDR["BARCODE"] = System.Convert.DBNull;
    }

    public decimal dcID_DON_VI
    {
        get
        {
            return CNull.RowNVLDecimal(pm_objDR, "ID_DON_VI", IPConstants.c_DefaultDecimal);
        }
        set
        {
            pm_objDR["ID_DON_VI"] = value;
        }
    }

    public bool IsID_DON_VINull()
    {
        return pm_objDR.IsNull("ID_DON_VI");
    }

    public void SetID_DON_VINull()
    {
        pm_objDR["ID_DON_VI"] = System.Convert.DBNull;
    }

    public decimal dcGIA_NHAP
    {
        get
        {
            return CNull.RowNVLDecimal(pm_objDR, "GIA_NHAP", IPConstants.c_DefaultDecimal);
        }
        set
        {
            pm_objDR["GIA_NHAP"] = value;
        }
    }

    public bool IsGIA_NHAPNull()
    {
        return pm_objDR.IsNull("GIA_NHAP");
    }

    public void SetGIA_NHAPNull()
    {
        pm_objDR["GIA_NHAP"] = System.Convert.DBNull;
    }

    public decimal dcGIA_BAN
    {
        get
        {
            return CNull.RowNVLDecimal(pm_objDR, "GIA_BAN", IPConstants.c_DefaultDecimal);
        }
        set
        {
            pm_objDR["GIA_BAN"] = value;
        }
    }

    public bool IsGIA_BANNull()
    {
        return pm_objDR.IsNull("GIA_BAN");
    }

    public void SetGIA_BANNull()
    {
        pm_objDR["GIA_BAN"] = System.Convert.DBNull;
    }

    public decimal dcGIA_BAN_LE
    {
        get
        {
            return CNull.RowNVLDecimal(pm_objDR, "GIA_BAN_LE", IPConstants.c_DefaultDecimal);
        }
        set
        {
            pm_objDR["GIA_BAN_LE"] = value;
        }
    }

    public bool IsGIA_BAN_LENull()
    {
        return pm_objDR.IsNull("GIA_BAN_LE");
    }

    public void SetGIA_BAN_LENull()
    {
        pm_objDR["GIA_BAN_LE"] = System.Convert.DBNull;
    }

    public decimal dcID_TRANG_THAI
    {
        get
        {
            return CNull.RowNVLDecimal(pm_objDR, "ID_TRANG_THAI", IPConstants.c_DefaultDecimal);
        }
        set
        {
            pm_objDR["ID_TRANG_THAI"] = value;
        }
    }

    public bool IsID_TRANG_THAINull()
    {
        return pm_objDR.IsNull("ID_TRANG_THAI");
    }

    public void SetID_TRANG_THAINull()
    {
        pm_objDR["ID_TRANG_THAI"] = System.Convert.DBNull;
    }

    public decimal dcID_NHOM_CHA
    {
        get
        {
            return CNull.RowNVLDecimal(pm_objDR, "ID_NHOM_CHA", IPConstants.c_DefaultDecimal);
        }
        set
        {
            pm_objDR["ID_NHOM_CHA"] = value;
        }
    }

    public bool IsID_NHOM_CHANull()
    {
        return pm_objDR.IsNull("ID_NHOM_CHA");
    }

    public void SetID_NHOM_CHANull()
    {
        pm_objDR["ID_NHOM_CHA"] = System.Convert.DBNull;
    }

    public string strTEN
    {
        get
        {
            return CNull.RowNVLString(pm_objDR, "TEN", IPConstants.c_DefaultString);
        }
        set
        {
            pm_objDR["TEN"] = value;
        }
    }

    public bool IsTENNull()
    {
        return pm_objDR.IsNull("TEN");
    }

    public void SetTENNull()
    {
        pm_objDR["TEN"] = System.Convert.DBNull;
    }

    public decimal dcSTT
    {
        get
        {
            return CNull.RowNVLDecimal(pm_objDR, "STT", IPConstants.c_DefaultDecimal);
        }
        set
        {
            pm_objDR["STT"] = value;
        }
    }

    public bool IsSTTNull()
    {
        return pm_objDR.IsNull("STT");
    }

    public void SetSTTNull()
    {
        pm_objDR["STT"] = System.Convert.DBNull;
    }

    public decimal dcLEVEL_MODE
    {
        get
        {
            return CNull.RowNVLDecimal(pm_objDR, "LEVEL_MODE", IPConstants.c_DefaultDecimal);
        }
        set
        {
            pm_objDR["LEVEL_MODE"] = value;
        }
    }

    public bool IsLEVEL_MODENull()
    {
        return pm_objDR.IsNull("LEVEL_MODE");
    }

    public void SetLEVEL_MODENull()
    {
        pm_objDR["LEVEL_MODE"] = System.Convert.DBNull;
    }

#endregion
   
#region "Init Functions"
	public US_V_GD_CHUNG_TU() 
	{
		pm_objDS = new DS_V_GD_CHUNG_TU();
		pm_strTableName = c_TableName;
		pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
	}

	public US_V_GD_CHUNG_TU(DataRow i_objDR): this()
	{
		this.DataRow2Me(i_objDR);
	}

	public US_V_GD_CHUNG_TU(decimal i_dbID) 
	{
		pm_objDS = new DS_V_GD_CHUNG_TU();
		pm_strTableName = c_TableName;
		IMakeSelectCmd v_objMkCmd = new CMakeAndSelectCmd(pm_objDS, c_TableName);
		v_objMkCmd.AddCondition("ID", i_dbID, eKieuDuLieu.KieuNumber, eKieuSoSanh.Bang);
		SqlCommand v_cmdSQL;
		v_cmdSQL = v_objMkCmd.getSelectCmd();
		this.FillDatasetByCommand(pm_objDS, v_cmdSQL);
		pm_objDR = getRowClone(pm_objDS.Tables[pm_strTableName].Rows[0]);
	}
#endregion
    #region Methods
    /// <summary>
    /// Delete Hàng hóa, chi tiết chứng từ, nhân viên chứng từ, chứng từ
    /// </summary>
    /// <param name="ip_id_chungtu"></param>
    public void Delete_By_ID( decimal ip_id_chungtu)
    {
        CStoredProc v_stored_proc = new CStoredProc("pr_V_GD_CHUNG_TU_Delete_By_ID_CHUNG_TU");
        
        v_stored_proc.addDecimalInputParam("@ID_CHUNG_TU", ip_id_chungtu);
        v_stored_proc.ExecuteCommand(this);
    }
    /// <summary>
    /// Delete Hàng hóa, chi tiết chứng từ, nhân viên chứng từ
    /// </summary>
    /// <param name="ip_id_chungtu"></param>
    public void Delete_Detail_by_ID_CHUNG_TU(decimal ip_id_chungtu) {
        CStoredProc v_stored_proc = new CStoredProc("pr_V_GD_CHUNG_TU_Delete_Detail_by_ID_CHUNG_TU");

        v_stored_proc.addDecimalInputParam("@ID_CHUNG_TU", ip_id_chungtu);
        v_stored_proc.ExecuteCommand(this);
    }
    public void deleteGD_NHAN_VIEN_CHUNG_TU_By_Id(decimal ip_id_nhan_vien,decimal ip_id_chungtu)
    {
        CStoredProc v_stored_proc = new CStoredProc("deleteGD_NHAN_VIEN_CHUNG_TU_By_Id");
        v_stored_proc.addDecimalInputParam("@ID_NHAN_VIEN", ip_id_nhan_vien);
        v_stored_proc.addDecimalInputParam("@ID_CHUNG_TU", ip_id_chungtu);
        v_stored_proc.ExecuteCommand(this);
    }
    public void deleteGD_CHI_TIET_CHUNG_TU_By_Id(decimal ip_id_gd_chi_tiet_chung_tu)
    {
        CStoredProc v_stored_proc = new CStoredProc("deleteGD_CHI_TIET_CHUNG_TU_By_Id");
        v_stored_proc.addDecimalInputParam("@id", ip_id_gd_chi_tiet_chung_tu);
        v_stored_proc.ExecuteCommand(this);
    }
    public void Filldataset_by_search(decimal ip_id_loai_chung_tu
                                    , string ma_chung_tu
                                    , DS_V_GD_CHUNG_TU i_ds)
    {
        CStoredProc v_store_proc = new CStoredProc("Filldata_Bysearch");
        v_store_proc.addDecimalInputParam("@id_loai_ct", ip_id_loai_chung_tu);
        v_store_proc.addNVarcharInputParam("@ma_ct", ma_chung_tu);

        v_store_proc.fillDataSetByCommand(this,i_ds);  
    }

    public void delete_v_gd_chung_tu(decimal ip_id_chung_tu
                                   , decimal ip_id_chung_tu_detail
                                   , decimal ip_id_nhan_vien)
    {
        CStoredProc v_store_proc = new CStoredProc("pr_V_GD_CHUNG_TU_Delete");
        v_store_proc.addDecimalInputParam("@ID_CHI_TIET_CHUNG_TU", ip_id_chung_tu_detail);
        v_store_proc.addDecimalInputParam("@ID_NHAN_VIEN", ip_id_nhan_vien);
        v_store_proc.addNVarcharInputParam("@ID_CHUNG_TU", ip_id_chung_tu);

        v_store_proc.ExecuteCommand(this);
    }
    #endregion
}
}
