#include "mpeclass_com.hpp"


CMPEclass::CMPEclass()
{
    if (!g_pModule->InitializeComponentInstance(&m_hinst))
        Error("Could not create MCR instance");
}
CMPEclass::~CMPEclass()
{
    if (m_hinst)
        g_pModule->TerminateInstance(&m_hinst);
}

HRESULT __stdcall CMPEclass::apfibrous5para(/* [in] */ VARIANT L,
                                            /* [in] */ VARIANT BulkDensity,
                                            /* [in] */ VARIANT FlowRes,
                                            /* [in] */ VARIANT SFactor,
                                            /* [in] */ VARIANT h,
                                            /* [in] */ VARIANT c1,
                                            /* [in] */ VARIANT c2,
                                            /* [in] */ VARIANT fre) {
    return( CallComFcn( "apfibrous5para", 0, 0, 8, &L, &BulkDensity,
                        &FlowRes, &SFactor, &h, &c1, &c2, &fre ) );
}


HRESULT __stdcall CMPEclass::elasticmeritcalc(/* [in] */ VARIANT freq,
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
                                              /* [in] */ VARIANT L) {
    return( CallComFcn( "elasticmeritcalc", 0, 0, 12, &freq,
                        &MeasuredAbsorption, &BulkDensity, &FlowRes, &SFactor,
                        &h, &c1, &c2, &Em, &LFactor, &PRatio, &L ) );
}


HRESULT __stdcall CMPEclass::meritcalc(/* [in] */ VARIANT freq,
                                       /* [in] */ VARIANT MAbsorption,
                                       /* [in] */ VARIANT BulkDensity,
                                       /* [in] */ VARIANT FlowRes,
                                       /* [in] */ VARIANT SFactor,
                                       /* [in] */ VARIANT h,
                                       /* [in] */ VARIANT c1,
                                       /* [in] */ VARIANT c2,
                                       /* [in] */ VARIANT L) {
    return( CallComFcn( "meritcalc", 0, 0, 9, &freq,
                        &MAbsorption, &BulkDensity, &FlowRes,
                        &SFactor, &h, &c1, &c2, &L ) );
}


HRESULT __stdcall CMPEclass::pecalc(/* [in] */ VARIANT PrevError) {
    return( CallComFcn( "pecalc", 0, 0, 1, &PrevError ) );
}


HRESULT __stdcall CMPEclass::peelasticsolid(/* [in] */ VARIANT L,
                                            /* [in] */ VARIANT BulkDensity,
                                            /* [in] */ VARIANT h,
                                            /* [in] */ VARIANT ResonanceFrequency) {
    return( CallComFcn( "peelasticsolid", 0, 0, 4, &L,
                        &BulkDensity, &h, &ResonanceFrequency ) );
}


HRESULT __stdcall CMPEclass::polyfitting(/* [in] */ VARIANT FrequencyFitted,
                                         /* [in] */ VARIANT FrequencySampled,
                                         /* [in] */ VARIANT DataSampled,
                                         /* [in] */ VARIANT n) {
    return( CallComFcn( "polyfitting", 0, 0, 4, &FrequencyFitted,
                        &FrequencySampled, &DataSampled, &n ) );
}


HRESULT __stdcall CMPEclass::totalmeritcalc(/* [in] */ VARIANT Freq1,
                                            /* [in] */ VARIANT Freq2,
                                            /* [in] */ VARIANT tFlowRes,
                                            /* [in] */ VARIANT tSFactor,
                                            /* [in] */ VARIANT h,
                                            /* [in] */ VARIANT c1,
                                            /* [in] */ VARIANT c2) {
    return( CallComFcn( "totalmeritcalc", 0, 0, 7, &Freq1, &Freq2,
                        &tFlowRes, &tSFactor, &h, &c1, &c2 ) );
}


HRESULT __stdcall CMPEclass::get_ItaAir(/* [out, retval] */ VARIANT* ItaAir) {
    return( GetProperty( "ItaAir", ItaAir ) );
}
HRESULT __stdcall CMPEclass::put_ItaAir(/* [in] */ VARIANT ItaAir) {
    return( PutProperty( "ItaAir", &ItaAir ) );
}

HRESULT __stdcall CMPEclass::get_P0(/* [out, retval] */ VARIANT* P0) {
    return( GetProperty( "P0", P0 ) );
}
HRESULT __stdcall CMPEclass::put_P0(/* [in] */ VARIANT P0) {
    return( PutProperty( "P0", &P0 ) );
}

HRESULT __stdcall CMPEclass::get_Densityo(/* [out, retval] */ VARIANT* Densityo) {
    return( GetProperty( "Densityo", Densityo ) );
}
HRESULT __stdcall CMPEclass::put_Densityo(/* [in] */ VARIANT Densityo) {
    return( PutProperty( "Densityo", &Densityo ) );
}

HRESULT __stdcall CMPEclass::get_Z0(/* [out, retval] */ VARIANT* Z0) {
    return( GetProperty( "Z0", Z0 ) );
}
HRESULT __stdcall CMPEclass::put_Z0(/* [in] */ VARIANT Z0) {
    return( PutProperty( "Z0", &Z0 ) );
}

HRESULT __stdcall CMPEclass::get_MAbsorption(/* [out, retval] */ VARIANT* MAbsorption) {
    return( GetProperty( "MAbsorption", MAbsorption ) );
}
HRESULT __stdcall CMPEclass::put_MAbsorption(/* [in] */ VARIANT MAbsorption) {
    return( PutProperty( "MAbsorption", &MAbsorption ) );
}

HRESULT __stdcall CMPEclass::get_B(/* [out, retval] */ VARIANT* B) {
    return( GetProperty( "B", B ) );
}
HRESULT __stdcall CMPEclass::put_B(/* [in] */ VARIANT B) {
    return( PutProperty( "B", &B ) );
}

HRESULT __stdcall CMPEclass::get_c(/* [out, retval] */ VARIANT* c) {
    return( GetProperty( "c", c ) );
}
HRESULT __stdcall CMPEclass::put_c(/* [in] */ VARIANT c) {
    return( PutProperty( "c", &c ) );
}

HRESULT __stdcall CMPEclass::get_Npr(/* [out, retval] */ VARIANT* Npr) {
    return( GetProperty( "Npr", Npr ) );
}
HRESULT __stdcall CMPEclass::put_Npr(/* [in] */ VARIANT Npr) {
    return( PutProperty( "Npr", &Npr ) );
}

HRESULT __stdcall CMPEclass::get_Density1(/* [out, retval] */ VARIANT* Density1) {
    return( GetProperty( "Density1", Density1 ) );
}
HRESULT __stdcall CMPEclass::put_Density1(/* [in] */ VARIANT Density1) {
    return( PutProperty( "Density1", &Density1 ) );
}

HRESULT __stdcall CMPEclass::get_DensityA(/* [out, retval] */ VARIANT* DensityA) {
    return( GetProperty( "DensityA", DensityA ) );
}
HRESULT __stdcall CMPEclass::put_DensityA(/* [in] */ VARIANT DensityA) {
    return( PutProperty( "DensityA", &DensityA ) );
}

HRESULT __stdcall CMPEclass::get_HeatRatio(/* [out, retval] */ VARIANT* HeatRatio) {
    return( GetProperty( "HeatRatio", HeatRatio ) );
}
HRESULT __stdcall CMPEclass::put_HeatRatio(/* [in] */ VARIANT HeatRatio) {
    return( PutProperty( "HeatRatio", &HeatRatio ) );
}

HRESULT __stdcall CMPEclass::get_APFibrous(/* [out, retval] */ VARIANT* APFibrous) {
    return( GetProperty( "APFibrous", APFibrous ) );
}
HRESULT __stdcall CMPEclass::put_APFibrous(/* [in] */ VARIANT APFibrous) {
    return( PutProperty( "APFibrous", &APFibrous ) );
}

HRESULT __stdcall CMPEclass::get_Merit(/* [out, retval] */ VARIANT* Merit) {
    return( GetProperty( "Merit", Merit ) );
}
HRESULT __stdcall CMPEclass::put_Merit(/* [in] */ VARIANT Merit) {
    return( PutProperty( "Merit", &Merit ) );
}

HRESULT __stdcall CMPEclass::get_Absorption(/* [out, retval] */ VARIANT* Absorption) {
    return( GetProperty( "Absorption", Absorption ) );
}
HRESULT __stdcall CMPEclass::put_Absorption(/* [in] */ VARIANT Absorption) {
    return( PutProperty( "Absorption", &Absorption ) );
}

HRESULT __stdcall CMPEclass::get_RealSurfaceImpedance(/* [out, retval] */ VARIANT* RealSurfaceImpedance) {
    return( GetProperty( "RealSurfaceImpedance", RealSurfaceImpedance ) );
}
HRESULT __stdcall CMPEclass::put_RealSurfaceImpedance(/* [in] */ VARIANT RealSurfaceImpedance) {
    return( PutProperty( "RealSurfaceImpedance", &RealSurfaceImpedance ) );
}

HRESULT __stdcall CMPEclass::get_ImagSurfaceImpedance(/* [out, retval] */ VARIANT* ImagSurfaceImpedance) {
    return( GetProperty( "ImagSurfaceImpedance", ImagSurfaceImpedance ) );
}
HRESULT __stdcall CMPEclass::put_ImagSurfaceImpedance(/* [in] */ VARIANT ImagSurfaceImpedance) {
    return( PutProperty( "ImagSurfaceImpedance", &ImagSurfaceImpedance ) );
}

HRESULT __stdcall CMPEclass::get_BulkDensity(/* [out, retval] */ VARIANT* BulkDensity) {
    return( GetProperty( "BulkDensity", BulkDensity ) );
}
HRESULT __stdcall CMPEclass::put_BulkDensity(/* [in] */ VARIANT BulkDensity) {
    return( PutProperty( "BulkDensity", &BulkDensity ) );
}

HRESULT __stdcall CMPEclass::get_Thickness(/* [out, retval] */ VARIANT* Thickness) {
    return( GetProperty( "Thickness", Thickness ) );
}
HRESULT __stdcall CMPEclass::put_Thickness(/* [in] */ VARIANT Thickness) {
    return( PutProperty( "Thickness", &Thickness ) );
}

HRESULT __stdcall CMPEclass::get_FlowRes(/* [out, retval] */ VARIANT* FlowRes) {
    return( GetProperty( "FlowRes", FlowRes ) );
}
HRESULT __stdcall CMPEclass::put_FlowRes(/* [in] */ VARIANT FlowRes) {
    return( PutProperty( "FlowRes", &FlowRes ) );
}

HRESULT __stdcall CMPEclass::get_SFactor(/* [out, retval] */ VARIANT* SFactor) {
    return( GetProperty( "SFactor", SFactor ) );
}
HRESULT __stdcall CMPEclass::put_SFactor(/* [in] */ VARIANT SFactor) {
    return( PutProperty( "SFactor", &SFactor ) );
}

HRESULT __stdcall CMPEclass::get_Porosity(/* [out, retval] */ VARIANT* Porosity) {
    return( GetProperty( "Porosity", Porosity ) );
}
HRESULT __stdcall CMPEclass::put_Porosity(/* [in] */ VARIANT Porosity) {
    return( PutProperty( "Porosity", &Porosity ) );
}

HRESULT __stdcall CMPEclass::get_ViscousCL(/* [out, retval] */ VARIANT* ViscousCL) {
    return( GetProperty( "ViscousCL", ViscousCL ) );
}
HRESULT __stdcall CMPEclass::put_ViscousCL(/* [in] */ VARIANT ViscousCL) {
    return( PutProperty( "ViscousCL", &ViscousCL ) );
}

HRESULT __stdcall CMPEclass::get_ThermalCL(/* [out, retval] */ VARIANT* ThermalCL) {
    return( GetProperty( "ThermalCL", ThermalCL ) );
}
HRESULT __stdcall CMPEclass::put_ThermalCL(/* [in] */ VARIANT ThermalCL) {
    return( PutProperty( "ThermalCL", &ThermalCL ) );
}

HRESULT __stdcall CMPEclass::get_FlowResEst(/* [out, retval] */ VARIANT* FlowResEst) {
    return( GetProperty( "FlowResEst", FlowResEst ) );
}
HRESULT __stdcall CMPEclass::put_FlowResEst(/* [in] */ VARIANT FlowResEst) {
    return( PutProperty( "FlowResEst", &FlowResEst ) );
}

HRESULT __stdcall CMPEclass::get_SFactorEst(/* [out, retval] */ VARIANT* SFactorEst) {
    return( GetProperty( "SFactorEst", SFactorEst ) );
}
HRESULT __stdcall CMPEclass::put_SFactorEst(/* [in] */ VARIANT SFactorEst) {
    return( PutProperty( "SFactorEst", &SFactorEst ) );
}

HRESULT __stdcall CMPEclass::get_PorosityEst(/* [out, retval] */ VARIANT* PorosityEst) {
    return( GetProperty( "PorosityEst", PorosityEst ) );
}
HRESULT __stdcall CMPEclass::put_PorosityEst(/* [in] */ VARIANT PorosityEst) {
    return( PutProperty( "PorosityEst", &PorosityEst ) );
}

HRESULT __stdcall CMPEclass::get_ViscousCLEst(/* [out, retval] */ VARIANT* ViscousCLEst) {
    return( GetProperty( "ViscousCLEst", ViscousCLEst ) );
}
HRESULT __stdcall CMPEclass::put_ViscousCLEst(/* [in] */ VARIANT ViscousCLEst) {
    return( PutProperty( "ViscousCLEst", &ViscousCLEst ) );
}

HRESULT __stdcall CMPEclass::get_ThermalCLEst(/* [out, retval] */ VARIANT* ThermalCLEst) {
    return( GetProperty( "ThermalCLEst", ThermalCLEst ) );
}
HRESULT __stdcall CMPEclass::put_ThermalCLEst(/* [in] */ VARIANT ThermalCLEst) {
    return( PutProperty( "ThermalCLEst", &ThermalCLEst ) );
}

HRESULT __stdcall CMPEclass::get_freq(/* [out, retval] */ VARIANT* freq) {
    return( GetProperty( "freq", freq ) );
}
HRESULT __stdcall CMPEclass::put_freq(/* [in] */ VARIANT freq) {
    return( PutProperty( "freq", &freq ) );
}

HRESULT __stdcall CMPEclass::get_Frequency(/* [out, retval] */ VARIANT* Frequency) {
    return( GetProperty( "Frequency", Frequency ) );
}
HRESULT __stdcall CMPEclass::put_Frequency(/* [in] */ VARIANT Frequency) {
    return( PutProperty( "Frequency", &Frequency ) );
}

HRESULT __stdcall CMPEclass::get_SurfaceImpedance(/* [out, retval] */ VARIANT* SurfaceImpedance) {
    return( GetProperty( "SurfaceImpedance", SurfaceImpedance ) );
}
HRESULT __stdcall CMPEclass::put_SurfaceImpedance(/* [in] */ VARIANT SurfaceImpedance) {
    return( PutProperty( "SurfaceImpedance", &SurfaceImpedance ) );
}

HRESULT __stdcall CMPEclass::get_TotalMerit(/* [out, retval] */ VARIANT* TotalMerit) {
    return( GetProperty( "TotalMerit", TotalMerit ) );
}
HRESULT __stdcall CMPEclass::put_TotalMerit(/* [in] */ VARIANT TotalMerit) {
    return( PutProperty( "TotalMerit", &TotalMerit ) );
}

HRESULT __stdcall CMPEclass::get_SolidPara(/* [out, retval] */ VARIANT* SolidPara) {
    return( GetProperty( "SolidPara", SolidPara ) );
}
HRESULT __stdcall CMPEclass::put_SolidPara(/* [in] */ VARIANT SolidPara) {
    return( PutProperty( "SolidPara", &SolidPara ) );
}

HRESULT __stdcall CMPEclass::get_DataFitted(/* [out, retval] */ VARIANT* DataFitted) {
    return( GetProperty( "DataFitted", DataFitted ) );
}
HRESULT __stdcall CMPEclass::put_DataFitted(/* [in] */ VARIANT DataFitted) {
    return( PutProperty( "DataFitted", &DataFitted ) );
}

