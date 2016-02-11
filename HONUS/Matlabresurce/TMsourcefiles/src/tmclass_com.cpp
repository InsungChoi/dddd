#include "tmclass_com.hpp"


CTMclass::CTMclass()
{
    if (!g_pModule->InitializeComponentInstance(&m_hinst))
        Error("Could not create MCR instance");
}
CTMclass::~CTMclass()
{
    if (m_hinst)
        g_pModule->TerminateInstance(&m_hinst);
}

HRESULT __stdcall CTMclass::tmair(/* [in] */ VARIANT freq,
                                  /* [in] */ VARIANT theta,
                                  /* [in] */ VARIANT L) {
    return( CallComFcn( "tmair", 0, 0, 3, &freq, &theta, &L ) );
}


HRESULT __stdcall CTMclass::tmcalc(/* [in] */ VARIANT freq,
                                   /* [in] */ VARIANT theta,
                                   /* [in] */ VARIANT TotalThickness) {
    return( CallComFcn( "tmcalc", 0, 0, 3, &freq, &theta, &TotalThickness ) );
}


HRESULT __stdcall CTMclass::tmcheck() {
    return( CallComFcn( "tmcheck", 0, 0, 0 ) );
}


HRESULT __stdcall CTMclass::tmelastic(/* [in] */ VARIANT freq,
                                      /* [in] */ VARIANT theta,
                                      /* [in] */ VARIANT L,
                                      /* [in] */ VARIANT BulkDensity,
                                      /* [in] */ VARIANT FlowRes,
                                      /* [in] */ VARIANT SFactor,
                                      /* [in] */ VARIANT h,
                                      /* [in] */ VARIANT VCL,
                                      /* [in] */ VARIANT TCL,
                                      /* [in] */ VARIANT Em,
                                      /* [in] */ VARIANT LFactor,
                                      /* [in] */ VARIANT PRatio) {
    return( CallComFcn( "tmelastic", 0, 0, 12, &freq, &theta, &L,
                        &BulkDensity, &FlowRes, &SFactor, &h,
                        &VCL, &TCL, &Em, &LFactor, &PRatio ) );
}


HRESULT __stdcall CTMclass::tmelasticpanel(/* [in] */ VARIANT freq,
                                           /* [in] */ VARIANT theta,
                                           /* [in] */ VARIANT L,
                                           /* [in] */ VARIANT BulkDensity,
                                           /* [in] */ VARIANT FlowRes,
                                           /* [in] */ VARIANT SFactor,
                                           /* [in] */ VARIANT h,
                                           /* [in] */ VARIANT VCL,
                                           /* [in] */ VARIANT TCL,
                                           /* [in] */ VARIANT Em,
                                           /* [in] */ VARIANT PRatio,
                                           /* [in] */ VARIANT LFactor,
                                           /* [in] */ VARIANT hp,
                                           /* [in] */ VARIANT Densityp,
                                           /* [in] */ VARIANT Ep,
                                           /* [in] */ VARIANT PRatiop) {
    return( CallComFcn( "tmelasticpanel", 0, 0, 16, &freq, &theta, &L,
                        &BulkDensity, &FlowRes, &SFactor, &h, &VCL, &TCL, &Em,
                        &PRatio, &LFactor, &hp, &Densityp, &Ep, &PRatiop ) );
}


HRESULT __stdcall CTMclass::tmeye() {
    return( CallComFcn( "tmeye", 0, 0, 0 ) );
}


HRESULT __stdcall CTMclass::tmimpermemb(/* [in] */ VARIANT freq,
                                        /* [in] */ VARIANT theta,
                                        /* [in] */ VARIANT L,
                                        /* [in] */ VARIANT Density) {
    return( CallComFcn( "tmimpermemb", 0, 0, 4, &freq,
                        &theta, &L, &Density ) );
}


HRESULT __stdcall CTMclass::tminit() {
    return( CallComFcn( "tminit", 0, 0, 0 ) );
}


HRESULT __stdcall CTMclass::tmlimp(/* [in] */ VARIANT freq,
                                   /* [in] */ VARIANT theta,
                                   /* [in] */ VARIANT L,
                                   /* [in] */ VARIANT BulkDensity,
                                   /* [in] */ VARIANT FlowRes,
                                   /* [in] */ VARIANT SFactor,
                                   /* [in] */ VARIANT h,
                                   /* [in] */ VARIANT VCL,
                                   /* [in] */ VARIANT TCL) {
    return( CallComFcn( "tmlimp", 0, 0, 9, &freq, &theta, &L, &BulkDensity,
                        &FlowRes, &SFactor, &h, &VCL, &TCL ) );
}


HRESULT __stdcall CTMclass::tmmul() {
    return( CallComFcn( "tmmul", 0, 0, 0 ) );
}


HRESULT __stdcall CTMclass::tmpanel(/* [in] */ VARIANT freq,
                                    /* [in] */ VARIANT theta,
                                    /* [in] */ VARIANT L,
                                    /* [in] */ VARIANT Density,
                                    /* [in] */ VARIANT Em,
                                    /* [in] */ VARIANT PRatio) {
    return( CallComFcn( "tmpanel", 0, 0, 6, &freq, &theta,
                        &L, &Density, &Em, &PRatio ) );
}


HRESULT __stdcall CTMclass::tmpanelelastic(/* [in] */ VARIANT freq,
                                           /* [in] */ VARIANT theta,
                                           /* [in] */ VARIANT hp,
                                           /* [in] */ VARIANT Densityp,
                                           /* [in] */ VARIANT Ep,
                                           /* [in] */ VARIANT PRatiop,
                                           /* [in] */ VARIANT L,
                                           /* [in] */ VARIANT BulkDensity,
                                           /* [in] */ VARIANT FlowRes,
                                           /* [in] */ VARIANT SFactor,
                                           /* [in] */ VARIANT h,
                                           /* [in] */ VARIANT VCL,
                                           /* [in] */ VARIANT TCL,
                                           /* [in] */ VARIANT Em,
                                           /* [in] */ VARIANT PRatio,
                                           /* [in] */ VARIANT LFactor) {
    return( CallComFcn( "tmpanelelastic", 0, 0, 16, &freq, &theta, &hp,
                        &Densityp, &Ep, &PRatiop, &L, &BulkDensity, &FlowRes,
                        &SFactor, &h, &VCL, &TCL, &Em, &PRatio, &LFactor ) );
}


HRESULT __stdcall CTMclass::tmpanelelasticpanel(/* [in] */ VARIANT freq,
                                                /* [in] */ VARIANT theta,
                                                /* [in] */ VARIANT hp1,
                                                /* [in] */ VARIANT Densityp1,
                                                /* [in] */ VARIANT Ep1,
                                                /* [in] */ VARIANT PRatiop1,
                                                /* [in] */ VARIANT L,
                                                /* [in] */ VARIANT BulkDensity,
                                                /* [in] */ VARIANT FlowRes,
                                                /* [in] */ VARIANT SFactor,
                                                /* [in] */ VARIANT h,
                                                /* [in] */ VARIANT VCL,
                                                /* [in] */ VARIANT TCL,
                                                /* [in] */ VARIANT Em,
                                                /* [in] */ VARIANT PRatio,
                                                /* [in] */ VARIANT LFactor,
                                                /* [in] */ VARIANT hp2,
                                                /* [in] */ VARIANT Densityp2,
                                                /* [in] */ VARIANT Ep2,
                                                /* [in] */ VARIANT PRatiop2) {
    return( CallComFcn( "tmpanelelasticpanel", 0, 0, 20, &freq, &theta,
                        &hp1, &Densityp1, &Ep1, &PRatiop1, &L, &BulkDensity,
                        &FlowRes, &SFactor, &h, &VCL, &TCL, &Em, &PRatio,
                        &LFactor, &hp2, &Densityp2, &Ep2, &PRatiop2 ) );
}


HRESULT __stdcall CTMclass::tmpermemb(/* [in] */ VARIANT freq,
                                      /* [in] */ VARIANT theta,
                                      /* [in] */ VARIANT L,
                                      /* [in] */ VARIANT Density,
                                      /* [in] */ VARIANT FlowRes) {
    return( CallComFcn( "tmpermemb", 0, 0, 5, &freq,
                        &theta, &L, &Density, &FlowRes ) );
}


HRESULT __stdcall CTMclass::tmrigid(/* [in] */ VARIANT freq,
                                    /* [in] */ VARIANT theta,
                                    /* [in] */ VARIANT L,
                                    /* [in] */ VARIANT BulkDensity,
                                    /* [in] */ VARIANT FlowRes,
                                    /* [in] */ VARIANT SFactor,
                                    /* [in] */ VARIANT h,
                                    /* [in] */ VARIANT VCL,
                                    /* [in] */ VARIANT TCL) {
    return( CallComFcn( "tmrigid", 0, 0, 9, &freq, &theta, &L, &BulkDensity,
                        &FlowRes, &SFactor, &h, &VCL, &TCL ) );
}


HRESULT __stdcall CTMclass::get_TM(/* [out, retval] */ VARIANT* TM) {
    return( GetProperty( "TM", TM ) );
}
HRESULT __stdcall CTMclass::put_TM(/* [in] */ VARIANT TM) {
    return( PutProperty( "TM", &TM ) );
}

HRESULT __stdcall CTMclass::get_c(/* [out, retval] */ VARIANT* c) {
    return( GetProperty( "c", c ) );
}
HRESULT __stdcall CTMclass::put_c(/* [in] */ VARIANT c) {
    return( PutProperty( "c", &c ) );
}

HRESULT __stdcall CTMclass::get_Densityo(/* [out, retval] */ VARIANT* Densityo) {
    return( GetProperty( "Densityo", Densityo ) );
}
HRESULT __stdcall CTMclass::put_Densityo(/* [in] */ VARIANT Densityo) {
    return( PutProperty( "Densityo", &Densityo ) );
}

HRESULT __stdcall CTMclass::get_HeatRatio(/* [out, retval] */ VARIANT* HeatRatio) {
    return( GetProperty( "HeatRatio", HeatRatio ) );
}
HRESULT __stdcall CTMclass::put_HeatRatio(/* [in] */ VARIANT HeatRatio) {
    return( PutProperty( "HeatRatio", &HeatRatio ) );
}

HRESULT __stdcall CTMclass::get_Npr(/* [out, retval] */ VARIANT* Npr) {
    return( GetProperty( "Npr", Npr ) );
}
HRESULT __stdcall CTMclass::put_Npr(/* [in] */ VARIANT Npr) {
    return( PutProperty( "Npr", &Npr ) );
}

HRESULT __stdcall CTMclass::get_ItaAir(/* [out, retval] */ VARIANT* ItaAir) {
    return( GetProperty( "ItaAir", ItaAir ) );
}
HRESULT __stdcall CTMclass::put_ItaAir(/* [in] */ VARIANT ItaAir) {
    return( PutProperty( "ItaAir", &ItaAir ) );
}

HRESULT __stdcall CTMclass::get_P0(/* [out, retval] */ VARIANT* P0) {
    return( GetProperty( "P0", P0 ) );
}
HRESULT __stdcall CTMclass::put_P0(/* [in] */ VARIANT P0) {
    return( PutProperty( "P0", &P0 ) );
}

HRESULT __stdcall CTMclass::get_Result(/* [out, retval] */ VARIANT* Result) {
    return( GetProperty( "Result", Result ) );
}
HRESULT __stdcall CTMclass::put_Result(/* [in] */ VARIANT Result) {
    return( PutProperty( "Result", &Result ) );
}

HRESULT __stdcall CTMclass::get_Rigid(/* [out, retval] */ VARIANT* Rigid) {
    return( GetProperty( "Rigid", Rigid ) );
}
HRESULT __stdcall CTMclass::put_Rigid(/* [in] */ VARIANT Rigid) {
    return( PutProperty( "Rigid", &Rigid ) );
}

HRESULT __stdcall CTMclass::get_Anechoic(/* [out, retval] */ VARIANT* Anechoic) {
    return( GetProperty( "Anechoic", Anechoic ) );
}
HRESULT __stdcall CTMclass::put_Anechoic(/* [in] */ VARIANT Anechoic) {
    return( PutProperty( "Anechoic", &Anechoic ) );
}

HRESULT __stdcall CTMclass::get_TL(/* [out, retval] */ VARIANT* TL) {
    return( GetProperty( "TL", TL ) );
}
HRESULT __stdcall CTMclass::put_TL(/* [in] */ VARIANT TL) {
    return( PutProperty( "TL", &TL ) );
}

HRESULT __stdcall CTMclass::get_TM11(/* [out, retval] */ VARIANT* TM11) {
    return( GetProperty( "TM11", TM11 ) );
}
HRESULT __stdcall CTMclass::put_TM11(/* [in] */ VARIANT TM11) {
    return( PutProperty( "TM11", &TM11 ) );
}

HRESULT __stdcall CTMclass::get_TM12(/* [out, retval] */ VARIANT* TM12) {
    return( GetProperty( "TM12", TM12 ) );
}
HRESULT __stdcall CTMclass::put_TM12(/* [in] */ VARIANT TM12) {
    return( PutProperty( "TM12", &TM12 ) );
}

HRESULT __stdcall CTMclass::get_TM21(/* [out, retval] */ VARIANT* TM21) {
    return( GetProperty( "TM21", TM21 ) );
}
HRESULT __stdcall CTMclass::put_TM21(/* [in] */ VARIANT TM21) {
    return( PutProperty( "TM21", &TM21 ) );
}

HRESULT __stdcall CTMclass::get_TM22(/* [out, retval] */ VARIANT* TM22) {
    return( GetProperty( "TM22", TM22 ) );
}
HRESULT __stdcall CTMclass::put_TM22(/* [in] */ VARIANT TM22) {
    return( PutProperty( "TM22", &TM22 ) );
}

HRESULT __stdcall CTMclass::get_Result11(/* [out, retval] */ VARIANT* Result11) {
    return( GetProperty( "Result11", Result11 ) );
}
HRESULT __stdcall CTMclass::put_Result11(/* [in] */ VARIANT Result11) {
    return( PutProperty( "Result11", &Result11 ) );
}

HRESULT __stdcall CTMclass::get_Result12(/* [out, retval] */ VARIANT* Result12) {
    return( GetProperty( "Result12", Result12 ) );
}
HRESULT __stdcall CTMclass::put_Result12(/* [in] */ VARIANT Result12) {
    return( PutProperty( "Result12", &Result12 ) );
}

HRESULT __stdcall CTMclass::get_Result21(/* [out, retval] */ VARIANT* Result21) {
    return( GetProperty( "Result21", Result21 ) );
}
HRESULT __stdcall CTMclass::put_Result21(/* [in] */ VARIANT Result21) {
    return( PutProperty( "Result21", &Result21 ) );
}

HRESULT __stdcall CTMclass::get_Result22(/* [out, retval] */ VARIANT* Result22) {
    return( GetProperty( "Result22", Result22 ) );
}
HRESULT __stdcall CTMclass::put_Result22(/* [in] */ VARIANT Result22) {
    return( PutProperty( "Result22", &Result22 ) );
}

