#ifndef _MPE_MPEclass_com_HPP
#define _MPE_com_HPP 1

#include <windows.h>
#include "mpe_idl.h"
#include "mclcommain.h"
#include "mclcomclass.h"

class CMPEclass : public CMCLClassImpl<IMPEclass, &IID_IMPEclass,
                                       CMPEclass, &CLSID_MPEclass>
{
public:
    CMPEclass();
    ~CMPEclass();

    HRESULT __stdcall apfibrous5para(/* [in] */ VARIANT L,
                                     /* [in] */ VARIANT BulkDensity,
                                     /* [in] */ VARIANT FlowRes,
                                     /* [in] */ VARIANT SFactor,
                                     /* [in] */ VARIANT h,
                                     /* [in] */ VARIANT c1,
                                     /* [in] */ VARIANT c2,
                                     /* [in] */ VARIANT fre);
    

    HRESULT __stdcall elasticmeritcalc(/* [in] */ VARIANT freq,
                                       /* [in] */ VARIANT MeasuredAbsorption,
                                       /* [in] */ VARIANT BulkDensity,
                                       /* [in] */ VARIANT FlowRes,
                                       /* [in] */ VARIANT SFactor,
                                       /* [in] */ VARIANT h,
                                       /* [in] */ VARIANT c1,
                                       /* [in] */ VARIANT c2,
                                       /* [in] */ VARIANT Em,
                                       /* [in] */ VARIANT LFactor,
                                       /* [in] */ VARIANT PRatio,
                                       /* [in] */ VARIANT L);
    

    HRESULT __stdcall meritcalc(/* [in] */ VARIANT freq,
                                /* [in] */ VARIANT MAbsorption,
                                /* [in] */ VARIANT BulkDensity,
                                /* [in] */ VARIANT FlowRes,
                                /* [in] */ VARIANT SFactor,
                                /* [in] */ VARIANT h, /* [in] */ VARIANT c1,
                                /* [in] */ VARIANT c2, /* [in] */ VARIANT L);
    

    HRESULT __stdcall pecalc(/* [in] */ VARIANT PrevError);
    

    HRESULT __stdcall peelasticsolid(/* [in] */ VARIANT L,
                                     /* [in] */ VARIANT BulkDensity,
                                     /* [in] */ VARIANT h,
                                     /* [in] */ VARIANT ResonanceFrequency);
    

    HRESULT __stdcall polyfitting(/* [in] */ VARIANT FrequencyFitted,
                                  /* [in] */ VARIANT FrequencySampled,
                                  /* [in] */ VARIANT DataSampled,
                                  /* [in] */ VARIANT n);
    

    HRESULT __stdcall totalmeritcalc(/* [in] */ VARIANT Freq1,
                                     /* [in] */ VARIANT Freq2,
                                     /* [in] */ VARIANT tFlowRes,
                                     /* [in] */ VARIANT tSFactor,
                                     /* [in] */ VARIANT h,
                                     /* [in] */ VARIANT c1,
                                     /* [in] */ VARIANT c2);
    

    HRESULT __stdcall get_ItaAir(/* [out, retval] */ VARIANT* ItaAir);
    HRESULT __stdcall put_ItaAir(/* [in] */ VARIANT ItaAir);
    
    HRESULT __stdcall get_P0(/* [out, retval] */ VARIANT* P0);
    HRESULT __stdcall put_P0(/* [in] */ VARIANT P0);
    
    HRESULT __stdcall get_Densityo(/* [out, retval] */ VARIANT* Densityo);
    HRESULT __stdcall put_Densityo(/* [in] */ VARIANT Densityo);
    
    HRESULT __stdcall get_Z0(/* [out, retval] */ VARIANT* Z0);
    HRESULT __stdcall put_Z0(/* [in] */ VARIANT Z0);
    
    HRESULT __stdcall get_MAbsorption(/* [out, retval] */ VARIANT* MAbsorption);
    HRESULT __stdcall put_MAbsorption(/* [in] */ VARIANT MAbsorption);
    
    HRESULT __stdcall get_B(/* [out, retval] */ VARIANT* B);
    HRESULT __stdcall put_B(/* [in] */ VARIANT B);
    
    HRESULT __stdcall get_c(/* [out, retval] */ VARIANT* c);
    HRESULT __stdcall put_c(/* [in] */ VARIANT c);
    
    HRESULT __stdcall get_Npr(/* [out, retval] */ VARIANT* Npr);
    HRESULT __stdcall put_Npr(/* [in] */ VARIANT Npr);
    
    HRESULT __stdcall get_Density1(/* [out, retval] */ VARIANT* Density1);
    HRESULT __stdcall put_Density1(/* [in] */ VARIANT Density1);
    
    HRESULT __stdcall get_DensityA(/* [out, retval] */ VARIANT* DensityA);
    HRESULT __stdcall put_DensityA(/* [in] */ VARIANT DensityA);
    
    HRESULT __stdcall get_HeatRatio(/* [out, retval] */ VARIANT* HeatRatio);
    HRESULT __stdcall put_HeatRatio(/* [in] */ VARIANT HeatRatio);
    
    HRESULT __stdcall get_APFibrous(/* [out, retval] */ VARIANT* APFibrous);
    HRESULT __stdcall put_APFibrous(/* [in] */ VARIANT APFibrous);
    
    HRESULT __stdcall get_Merit(/* [out, retval] */ VARIANT* Merit);
    HRESULT __stdcall put_Merit(/* [in] */ VARIANT Merit);
    
    HRESULT __stdcall get_Absorption(/* [out, retval] */ VARIANT* Absorption);
    HRESULT __stdcall put_Absorption(/* [in] */ VARIANT Absorption);
    
    HRESULT __stdcall get_RealSurfaceImpedance(/* [out, retval] */ VARIANT* RealSurfaceImpedance);
    HRESULT __stdcall put_RealSurfaceImpedance(/* [in] */ VARIANT RealSurfaceImpedance);
    
    HRESULT __stdcall get_ImagSurfaceImpedance(/* [out, retval] */ VARIANT* ImagSurfaceImpedance);
    HRESULT __stdcall put_ImagSurfaceImpedance(/* [in] */ VARIANT ImagSurfaceImpedance);
    
    HRESULT __stdcall get_BulkDensity(/* [out, retval] */ VARIANT* BulkDensity);
    HRESULT __stdcall put_BulkDensity(/* [in] */ VARIANT BulkDensity);
    
    HRESULT __stdcall get_Thickness(/* [out, retval] */ VARIANT* Thickness);
    HRESULT __stdcall put_Thickness(/* [in] */ VARIANT Thickness);
    
    HRESULT __stdcall get_FlowRes(/* [out, retval] */ VARIANT* FlowRes);
    HRESULT __stdcall put_FlowRes(/* [in] */ VARIANT FlowRes);
    
    HRESULT __stdcall get_SFactor(/* [out, retval] */ VARIANT* SFactor);
    HRESULT __stdcall put_SFactor(/* [in] */ VARIANT SFactor);
    
    HRESULT __stdcall get_Porosity(/* [out, retval] */ VARIANT* Porosity);
    HRESULT __stdcall put_Porosity(/* [in] */ VARIANT Porosity);
    
    HRESULT __stdcall get_ViscousCL(/* [out, retval] */ VARIANT* ViscousCL);
    HRESULT __stdcall put_ViscousCL(/* [in] */ VARIANT ViscousCL);
    
    HRESULT __stdcall get_ThermalCL(/* [out, retval] */ VARIANT* ThermalCL);
    HRESULT __stdcall put_ThermalCL(/* [in] */ VARIANT ThermalCL);
    
    HRESULT __stdcall get_FlowResEst(/* [out, retval] */ VARIANT* FlowResEst);
    HRESULT __stdcall put_FlowResEst(/* [in] */ VARIANT FlowResEst);
    
    HRESULT __stdcall get_SFactorEst(/* [out, retval] */ VARIANT* SFactorEst);
    HRESULT __stdcall put_SFactorEst(/* [in] */ VARIANT SFactorEst);
    
    HRESULT __stdcall get_PorosityEst(/* [out, retval] */ VARIANT* PorosityEst);
    HRESULT __stdcall put_PorosityEst(/* [in] */ VARIANT PorosityEst);
    
    HRESULT __stdcall get_ViscousCLEst(/* [out, retval] */ VARIANT* ViscousCLEst);
    HRESULT __stdcall put_ViscousCLEst(/* [in] */ VARIANT ViscousCLEst);
    
    HRESULT __stdcall get_ThermalCLEst(/* [out, retval] */ VARIANT* ThermalCLEst);
    HRESULT __stdcall put_ThermalCLEst(/* [in] */ VARIANT ThermalCLEst);
    
    HRESULT __stdcall get_freq(/* [out, retval] */ VARIANT* freq);
    HRESULT __stdcall put_freq(/* [in] */ VARIANT freq);
    
    HRESULT __stdcall get_Frequency(/* [out, retval] */ VARIANT* Frequency);
    HRESULT __stdcall put_Frequency(/* [in] */ VARIANT Frequency);
    
    HRESULT __stdcall get_SurfaceImpedance(/* [out, retval] */ VARIANT* SurfaceImpedance);
    HRESULT __stdcall put_SurfaceImpedance(/* [in] */ VARIANT SurfaceImpedance);
    
    HRESULT __stdcall get_TotalMerit(/* [out, retval] */ VARIANT* TotalMerit);
    HRESULT __stdcall put_TotalMerit(/* [in] */ VARIANT TotalMerit);
    
    HRESULT __stdcall get_SolidPara(/* [out, retval] */ VARIANT* SolidPara);
    HRESULT __stdcall put_SolidPara(/* [in] */ VARIANT SolidPara);
    
    HRESULT __stdcall get_DataFitted(/* [out, retval] */ VARIANT* DataFitted);
    HRESULT __stdcall put_DataFitted(/* [in] */ VARIANT DataFitted);
    };
#endif
