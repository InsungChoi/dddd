#ifndef _TM_TMclass_com_HPP
#define _TM_com_HPP 1

#include <windows.h>
#include "tm_idl.h"
#include "mclcommain.h"
#include "mclcomclass.h"

class CTMclass : public CMCLClassImpl<ITMclass, &IID_ITMclass,
                                      CTMclass, &CLSID_TMclass>
{
public:
    CTMclass();
    ~CTMclass();

    HRESULT __stdcall tmair(/* [in] */ VARIANT freq,
                            /* [in] */ VARIANT theta, /* [in] */ VARIANT L);
    

    HRESULT __stdcall tmcalc(/* [in] */ VARIANT freq,
                             /* [in] */ VARIANT theta,
                             /* [in] */ VARIANT TotalThickness);
    

    HRESULT __stdcall tmcheck();
    

    HRESULT __stdcall tmelastic(/* [in] */ VARIANT freq,
                                /* [in] */ VARIANT theta,
                                /* [in] */ VARIANT L,
                                /* [in] */ VARIANT BulkDensity,
                                /* [in] */ VARIANT FlowRes,
                                /* [in] */ VARIANT SFactor,
                                /* [in] */ VARIANT h, /* [in] */ VARIANT VCL,
                                /* [in] */ VARIANT TCL, /* [in] */ VARIANT Em,
                                /* [in] */ VARIANT LFactor,
                                /* [in] */ VARIANT PRatio);
    

    HRESULT __stdcall tmelasticpanel(/* [in] */ VARIANT freq,
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
                                     /* [in] */ VARIANT PRatiop);
    

    HRESULT __stdcall tmeye();
    

    HRESULT __stdcall tmimpermemb(/* [in] */ VARIANT freq,
                                  /* [in] */ VARIANT theta,
                                  /* [in] */ VARIANT L,
                                  /* [in] */ VARIANT Density);
    

    HRESULT __stdcall tminit();
    

    HRESULT __stdcall tmlimp(/* [in] */ VARIANT freq,
                             /* [in] */ VARIANT theta, /* [in] */ VARIANT L,
                             /* [in] */ VARIANT BulkDensity,
                             /* [in] */ VARIANT FlowRes,
                             /* [in] */ VARIANT SFactor, /* [in] */ VARIANT h,
                             /* [in] */ VARIANT VCL, /* [in] */ VARIANT TCL);
    

    HRESULT __stdcall tmmul();
    

    HRESULT __stdcall tmpanel(/* [in] */ VARIANT freq,
                              /* [in] */ VARIANT theta, /* [in] */ VARIANT L,
                              /* [in] */ VARIANT Density,
                              /* [in] */ VARIANT Em,
                              /* [in] */ VARIANT PRatio);
    

    HRESULT __stdcall tmpanelelastic(/* [in] */ VARIANT freq,
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
                                     /* [in] */ VARIANT LFactor);
    

    HRESULT __stdcall tmpanelelasticpanel(/* [in] */ VARIANT freq,
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
                                          /* [in] */ VARIANT PRatiop2);
    

    HRESULT __stdcall tmpermemb(/* [in] */ VARIANT freq,
                                /* [in] */ VARIANT theta,
                                /* [in] */ VARIANT L,
                                /* [in] */ VARIANT Density,
                                /* [in] */ VARIANT FlowRes);
    

    HRESULT __stdcall tmrigid(/* [in] */ VARIANT freq,
                              /* [in] */ VARIANT theta, /* [in] */ VARIANT L,
                              /* [in] */ VARIANT BulkDensity,
                              /* [in] */ VARIANT FlowRes,
                              /* [in] */ VARIANT SFactor,
                              /* [in] */ VARIANT h, /* [in] */ VARIANT VCL,
                              /* [in] */ VARIANT TCL);
    

    HRESULT __stdcall get_TM(/* [out, retval] */ VARIANT* TM);
    HRESULT __stdcall put_TM(/* [in] */ VARIANT TM);
    
    HRESULT __stdcall get_c(/* [out, retval] */ VARIANT* c);
    HRESULT __stdcall put_c(/* [in] */ VARIANT c);
    
    HRESULT __stdcall get_Densityo(/* [out, retval] */ VARIANT* Densityo);
    HRESULT __stdcall put_Densityo(/* [in] */ VARIANT Densityo);
    
    HRESULT __stdcall get_HeatRatio(/* [out, retval] */ VARIANT* HeatRatio);
    HRESULT __stdcall put_HeatRatio(/* [in] */ VARIANT HeatRatio);
    
    HRESULT __stdcall get_Npr(/* [out, retval] */ VARIANT* Npr);
    HRESULT __stdcall put_Npr(/* [in] */ VARIANT Npr);
    
    HRESULT __stdcall get_ItaAir(/* [out, retval] */ VARIANT* ItaAir);
    HRESULT __stdcall put_ItaAir(/* [in] */ VARIANT ItaAir);
    
    HRESULT __stdcall get_P0(/* [out, retval] */ VARIANT* P0);
    HRESULT __stdcall put_P0(/* [in] */ VARIANT P0);
    
    HRESULT __stdcall get_Result(/* [out, retval] */ VARIANT* Result);
    HRESULT __stdcall put_Result(/* [in] */ VARIANT Result);
    
    HRESULT __stdcall get_Rigid(/* [out, retval] */ VARIANT* Rigid);
    HRESULT __stdcall put_Rigid(/* [in] */ VARIANT Rigid);
    
    HRESULT __stdcall get_Anechoic(/* [out, retval] */ VARIANT* Anechoic);
    HRESULT __stdcall put_Anechoic(/* [in] */ VARIANT Anechoic);
    
    HRESULT __stdcall get_TL(/* [out, retval] */ VARIANT* TL);
    HRESULT __stdcall put_TL(/* [in] */ VARIANT TL);
    
    HRESULT __stdcall get_TM11(/* [out, retval] */ VARIANT* TM11);
    HRESULT __stdcall put_TM11(/* [in] */ VARIANT TM11);
    
    HRESULT __stdcall get_TM12(/* [out, retval] */ VARIANT* TM12);
    HRESULT __stdcall put_TM12(/* [in] */ VARIANT TM12);
    
    HRESULT __stdcall get_TM21(/* [out, retval] */ VARIANT* TM21);
    HRESULT __stdcall put_TM21(/* [in] */ VARIANT TM21);
    
    HRESULT __stdcall get_TM22(/* [out, retval] */ VARIANT* TM22);
    HRESULT __stdcall put_TM22(/* [in] */ VARIANT TM22);
    
    HRESULT __stdcall get_Result11(/* [out, retval] */ VARIANT* Result11);
    HRESULT __stdcall put_Result11(/* [in] */ VARIANT Result11);
    
    HRESULT __stdcall get_Result12(/* [out, retval] */ VARIANT* Result12);
    HRESULT __stdcall put_Result12(/* [in] */ VARIANT Result12);
    
    HRESULT __stdcall get_Result21(/* [out, retval] */ VARIANT* Result21);
    HRESULT __stdcall put_Result21(/* [in] */ VARIANT Result21);
    
    HRESULT __stdcall get_Result22(/* [out, retval] */ VARIANT* Result22);
    HRESULT __stdcall put_Result22(/* [in] */ VARIANT Result22);
    };
#endif
