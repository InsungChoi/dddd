

/* this ALWAYS GENERATED file contains the definitions for the interfaces */


 /* File created by MIDL compiler version 6.00.0361 */
/* at Tue Nov 08 19:27:33 2005
 */
/* Compiler settings for C:/HONUS/Matlabresurce/MPE/MPE/src\mpe_idl.idl:
    Oicf, W1, Zp8, env=Win32 (32b run)
    protocol : dce , ms_ext, c_ext, robust
    error checks: allocation ref bounds_check enum stub_data 
    VC __declspec() decoration level: 
         __declspec(uuid()), __declspec(selectany), __declspec(novtable)
         DECLSPEC_UUID(), MIDL_INTERFACE()
*/
//@@MIDL_FILE_HEADING(  )

#pragma warning( disable: 4049 )  /* more than 64k source lines */


/* verify that the <rpcndr.h> version is high enough to compile this file*/
#ifndef __REQUIRED_RPCNDR_H_VERSION__
#define __REQUIRED_RPCNDR_H_VERSION__ 475
#endif

#include "rpc.h"
#include "rpcndr.h"

#ifndef __RPCNDR_H_VERSION__
#error this stub requires an updated version of <rpcndr.h>
#endif // __RPCNDR_H_VERSION__

#ifndef COM_NO_WINDOWS_H
#include "windows.h"
#include "ole2.h"
#endif /*COM_NO_WINDOWS_H*/

#ifndef __mpe_idl_h__
#define __mpe_idl_h__

#if defined(_MSC_VER) && (_MSC_VER >= 1020)
#pragma once
#endif

/* Forward Declarations */ 

#ifndef __IMPEclass_FWD_DEFINED__
#define __IMPEclass_FWD_DEFINED__
typedef interface IMPEclass IMPEclass;
#endif 	/* __IMPEclass_FWD_DEFINED__ */


#ifndef __MPEclass_FWD_DEFINED__
#define __MPEclass_FWD_DEFINED__

#ifdef __cplusplus
typedef class MPEclass MPEclass;
#else
typedef struct MPEclass MPEclass;
#endif /* __cplusplus */

#endif 	/* __MPEclass_FWD_DEFINED__ */


/* header files for imported files */
#include "oaidl.h"
#include "ocidl.h"
#include "mwcomtypes.h"

#ifdef __cplusplus
extern "C"{
#endif 

void * __RPC_USER MIDL_user_allocate(size_t);
void __RPC_USER MIDL_user_free( void * ); 

#ifndef __IMPEclass_INTERFACE_DEFINED__
#define __IMPEclass_INTERFACE_DEFINED__

/* interface IMPEclass */
/* [unique][helpstring][dual][uuid][object] */ 


EXTERN_C const IID IID_IMPEclass;

#if defined(__cplusplus) && !defined(CINTERFACE)
    
    MIDL_INTERFACE("80C1A351-2237-417E-A0DD-8BA48F222C68")
    IMPEclass : public IDispatch
    {
    public:
        virtual /* [helpstring][id][propget] */ HRESULT STDMETHODCALLTYPE get_MWFlags( 
            /* [retval][out] */ IMWFlags **ppvFlags) = 0;
        
        virtual /* [helpstring][id][propput] */ HRESULT STDMETHODCALLTYPE put_MWFlags( 
            /* [in] */ IMWFlags *pvFlags) = 0;
        
        virtual /* [helpstring][id] */ HRESULT STDMETHODCALLTYPE apfibrous5para( 
            /* [in] */ VARIANT L,
            /* [in] */ VARIANT BulkDensity,
            /* [in] */ VARIANT FlowRes,
            /* [in] */ VARIANT SFactor,
            /* [in] */ VARIANT h,
            /* [in] */ VARIANT c1,
            /* [in] */ VARIANT c2,
            /* [in] */ VARIANT fre) = 0;
        
        virtual /* [helpstring][id] */ HRESULT STDMETHODCALLTYPE elasticmeritcalc( 
            /* [in] */ VARIANT freq,
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
            /* [in] */ VARIANT L) = 0;
        
        virtual /* [helpstring][id] */ HRESULT STDMETHODCALLTYPE meritcalc( 
            /* [in] */ VARIANT freq,
            /* [in] */ VARIANT MAbsorption,
            /* [in] */ VARIANT BulkDensity,
            /* [in] */ VARIANT FlowRes,
            /* [in] */ VARIANT SFactor,
            /* [in] */ VARIANT h,
            /* [in] */ VARIANT c1,
            /* [in] */ VARIANT c2,
            /* [in] */ VARIANT L) = 0;
        
        virtual /* [helpstring][id] */ HRESULT STDMETHODCALLTYPE pecalc( 
            /* [in] */ VARIANT PrevError) = 0;
        
        virtual /* [helpstring][id] */ HRESULT STDMETHODCALLTYPE peelasticsolid( 
            /* [in] */ VARIANT L,
            /* [in] */ VARIANT BulkDensity,
            /* [in] */ VARIANT h,
            /* [in] */ VARIANT ResonanceFrequency) = 0;
        
        virtual /* [helpstring][id] */ HRESULT STDMETHODCALLTYPE polyfitting( 
            /* [in] */ VARIANT FrequencyFitted,
            /* [in] */ VARIANT FrequencySampled,
            /* [in] */ VARIANT DataSampled,
            /* [in] */ VARIANT n) = 0;
        
        virtual /* [helpstring][id] */ HRESULT STDMETHODCALLTYPE totalmeritcalc( 
            /* [in] */ VARIANT Freq1,
            /* [in] */ VARIANT Freq2,
            /* [in] */ VARIANT tFlowRes,
            /* [in] */ VARIANT tSFactor,
            /* [in] */ VARIANT h,
            /* [in] */ VARIANT c1,
            /* [in] */ VARIANT c2) = 0;
        
        virtual /* [helpstring][id][propget] */ HRESULT STDMETHODCALLTYPE get_ItaAir( 
            /* [retval][out] */ VARIANT *ItaAir) = 0;
        
        virtual /* [helpstring][id][propput] */ HRESULT STDMETHODCALLTYPE put_ItaAir( 
            /* [in] */ VARIANT ItaAir) = 0;
        
        virtual /* [helpstring][id][propget] */ HRESULT STDMETHODCALLTYPE get_P0( 
            /* [retval][out] */ VARIANT *P0) = 0;
        
        virtual /* [helpstring][id][propput] */ HRESULT STDMETHODCALLTYPE put_P0( 
            /* [in] */ VARIANT P0) = 0;
        
        virtual /* [helpstring][id][propget] */ HRESULT STDMETHODCALLTYPE get_Densityo( 
            /* [retval][out] */ VARIANT *Densityo) = 0;
        
        virtual /* [helpstring][id][propput] */ HRESULT STDMETHODCALLTYPE put_Densityo( 
            /* [in] */ VARIANT Densityo) = 0;
        
        virtual /* [helpstring][id][propget] */ HRESULT STDMETHODCALLTYPE get_Z0( 
            /* [retval][out] */ VARIANT *Z0) = 0;
        
        virtual /* [helpstring][id][propput] */ HRESULT STDMETHODCALLTYPE put_Z0( 
            /* [in] */ VARIANT Z0) = 0;
        
        virtual /* [helpstring][id][propget] */ HRESULT STDMETHODCALLTYPE get_MAbsorption( 
            /* [retval][out] */ VARIANT *MAbsorption) = 0;
        
        virtual /* [helpstring][id][propput] */ HRESULT STDMETHODCALLTYPE put_MAbsorption( 
            /* [in] */ VARIANT MAbsorption) = 0;
        
        virtual /* [helpstring][id][propget] */ HRESULT STDMETHODCALLTYPE get_B( 
            /* [retval][out] */ VARIANT *B) = 0;
        
        virtual /* [helpstring][id][propput] */ HRESULT STDMETHODCALLTYPE put_B( 
            /* [in] */ VARIANT B) = 0;
        
        virtual /* [helpstring][id][propget] */ HRESULT STDMETHODCALLTYPE get_c( 
            /* [retval][out] */ VARIANT *c) = 0;
        
        virtual /* [helpstring][id][propput] */ HRESULT STDMETHODCALLTYPE put_c( 
            /* [in] */ VARIANT c) = 0;
        
        virtual /* [helpstring][id][propget] */ HRESULT STDMETHODCALLTYPE get_Npr( 
            /* [retval][out] */ VARIANT *Npr) = 0;
        
        virtual /* [helpstring][id][propput] */ HRESULT STDMETHODCALLTYPE put_Npr( 
            /* [in] */ VARIANT Npr) = 0;
        
        virtual /* [helpstring][id][propget] */ HRESULT STDMETHODCALLTYPE get_Density1( 
            /* [retval][out] */ VARIANT *Density1) = 0;
        
        virtual /* [helpstring][id][propput] */ HRESULT STDMETHODCALLTYPE put_Density1( 
            /* [in] */ VARIANT Density1) = 0;
        
        virtual /* [helpstring][id][propget] */ HRESULT STDMETHODCALLTYPE get_DensityA( 
            /* [retval][out] */ VARIANT *DensityA) = 0;
        
        virtual /* [helpstring][id][propput] */ HRESULT STDMETHODCALLTYPE put_DensityA( 
            /* [in] */ VARIANT DensityA) = 0;
        
        virtual /* [helpstring][id][propget] */ HRESULT STDMETHODCALLTYPE get_HeatRatio( 
            /* [retval][out] */ VARIANT *HeatRatio) = 0;
        
        virtual /* [helpstring][id][propput] */ HRESULT STDMETHODCALLTYPE put_HeatRatio( 
            /* [in] */ VARIANT HeatRatio) = 0;
        
        virtual /* [helpstring][id][propget] */ HRESULT STDMETHODCALLTYPE get_APFibrous( 
            /* [retval][out] */ VARIANT *APFibrous) = 0;
        
        virtual /* [helpstring][id][propput] */ HRESULT STDMETHODCALLTYPE put_APFibrous( 
            /* [in] */ VARIANT APFibrous) = 0;
        
        virtual /* [helpstring][id][propget] */ HRESULT STDMETHODCALLTYPE get_Merit( 
            /* [retval][out] */ VARIANT *Merit) = 0;
        
        virtual /* [helpstring][id][propput] */ HRESULT STDMETHODCALLTYPE put_Merit( 
            /* [in] */ VARIANT Merit) = 0;
        
        virtual /* [helpstring][id][propget] */ HRESULT STDMETHODCALLTYPE get_Absorption( 
            /* [retval][out] */ VARIANT *Absorption) = 0;
        
        virtual /* [helpstring][id][propput] */ HRESULT STDMETHODCALLTYPE put_Absorption( 
            /* [in] */ VARIANT Absorption) = 0;
        
        virtual /* [helpstring][id][propget] */ HRESULT STDMETHODCALLTYPE get_RealSurfaceImpedance( 
            /* [retval][out] */ VARIANT *RealSurfaceImpedance) = 0;
        
        virtual /* [helpstring][id][propput] */ HRESULT STDMETHODCALLTYPE put_RealSurfaceImpedance( 
            /* [in] */ VARIANT RealSurfaceImpedance) = 0;
        
        virtual /* [helpstring][id][propget] */ HRESULT STDMETHODCALLTYPE get_ImagSurfaceImpedance( 
            /* [retval][out] */ VARIANT *ImagSurfaceImpedance) = 0;
        
        virtual /* [helpstring][id][propput] */ HRESULT STDMETHODCALLTYPE put_ImagSurfaceImpedance( 
            /* [in] */ VARIANT ImagSurfaceImpedance) = 0;
        
        virtual /* [helpstring][id][propget] */ HRESULT STDMETHODCALLTYPE get_BulkDensity( 
            /* [retval][out] */ VARIANT *BulkDensity) = 0;
        
        virtual /* [helpstring][id][propput] */ HRESULT STDMETHODCALLTYPE put_BulkDensity( 
            /* [in] */ VARIANT BulkDensity) = 0;
        
        virtual /* [helpstring][id][propget] */ HRESULT STDMETHODCALLTYPE get_Thickness( 
            /* [retval][out] */ VARIANT *Thickness) = 0;
        
        virtual /* [helpstring][id][propput] */ HRESULT STDMETHODCALLTYPE put_Thickness( 
            /* [in] */ VARIANT Thickness) = 0;
        
        virtual /* [helpstring][id][propget] */ HRESULT STDMETHODCALLTYPE get_FlowRes( 
            /* [retval][out] */ VARIANT *FlowRes) = 0;
        
        virtual /* [helpstring][id][propput] */ HRESULT STDMETHODCALLTYPE put_FlowRes( 
            /* [in] */ VARIANT FlowRes) = 0;
        
        virtual /* [helpstring][id][propget] */ HRESULT STDMETHODCALLTYPE get_SFactor( 
            /* [retval][out] */ VARIANT *SFactor) = 0;
        
        virtual /* [helpstring][id][propput] */ HRESULT STDMETHODCALLTYPE put_SFactor( 
            /* [in] */ VARIANT SFactor) = 0;
        
        virtual /* [helpstring][id][propget] */ HRESULT STDMETHODCALLTYPE get_Porosity( 
            /* [retval][out] */ VARIANT *Porosity) = 0;
        
        virtual /* [helpstring][id][propput] */ HRESULT STDMETHODCALLTYPE put_Porosity( 
            /* [in] */ VARIANT Porosity) = 0;
        
        virtual /* [helpstring][id][propget] */ HRESULT STDMETHODCALLTYPE get_ViscousCL( 
            /* [retval][out] */ VARIANT *ViscousCL) = 0;
        
        virtual /* [helpstring][id][propput] */ HRESULT STDMETHODCALLTYPE put_ViscousCL( 
            /* [in] */ VARIANT ViscousCL) = 0;
        
        virtual /* [helpstring][id][propget] */ HRESULT STDMETHODCALLTYPE get_ThermalCL( 
            /* [retval][out] */ VARIANT *ThermalCL) = 0;
        
        virtual /* [helpstring][id][propput] */ HRESULT STDMETHODCALLTYPE put_ThermalCL( 
            /* [in] */ VARIANT ThermalCL) = 0;
        
        virtual /* [helpstring][id][propget] */ HRESULT STDMETHODCALLTYPE get_FlowResEst( 
            /* [retval][out] */ VARIANT *FlowResEst) = 0;
        
        virtual /* [helpstring][id][propput] */ HRESULT STDMETHODCALLTYPE put_FlowResEst( 
            /* [in] */ VARIANT FlowResEst) = 0;
        
        virtual /* [helpstring][id][propget] */ HRESULT STDMETHODCALLTYPE get_SFactorEst( 
            /* [retval][out] */ VARIANT *SFactorEst) = 0;
        
        virtual /* [helpstring][id][propput] */ HRESULT STDMETHODCALLTYPE put_SFactorEst( 
            /* [in] */ VARIANT SFactorEst) = 0;
        
        virtual /* [helpstring][id][propget] */ HRESULT STDMETHODCALLTYPE get_PorosityEst( 
            /* [retval][out] */ VARIANT *PorosityEst) = 0;
        
        virtual /* [helpstring][id][propput] */ HRESULT STDMETHODCALLTYPE put_PorosityEst( 
            /* [in] */ VARIANT PorosityEst) = 0;
        
        virtual /* [helpstring][id][propget] */ HRESULT STDMETHODCALLTYPE get_ViscousCLEst( 
            /* [retval][out] */ VARIANT *ViscousCLEst) = 0;
        
        virtual /* [helpstring][id][propput] */ HRESULT STDMETHODCALLTYPE put_ViscousCLEst( 
            /* [in] */ VARIANT ViscousCLEst) = 0;
        
        virtual /* [helpstring][id][propget] */ HRESULT STDMETHODCALLTYPE get_ThermalCLEst( 
            /* [retval][out] */ VARIANT *ThermalCLEst) = 0;
        
        virtual /* [helpstring][id][propput] */ HRESULT STDMETHODCALLTYPE put_ThermalCLEst( 
            /* [in] */ VARIANT ThermalCLEst) = 0;
        
        virtual /* [helpstring][id][propget] */ HRESULT STDMETHODCALLTYPE get_freq( 
            /* [retval][out] */ VARIANT *freq) = 0;
        
        virtual /* [helpstring][id][propput] */ HRESULT STDMETHODCALLTYPE put_freq( 
            /* [in] */ VARIANT freq) = 0;
        
        virtual /* [helpstring][id][propget] */ HRESULT STDMETHODCALLTYPE get_Frequency( 
            /* [retval][out] */ VARIANT *Frequency) = 0;
        
        virtual /* [helpstring][id][propput] */ HRESULT STDMETHODCALLTYPE put_Frequency( 
            /* [in] */ VARIANT Frequency) = 0;
        
        virtual /* [helpstring][id][propget] */ HRESULT STDMETHODCALLTYPE get_SurfaceImpedance( 
            /* [retval][out] */ VARIANT *SurfaceImpedance) = 0;
        
        virtual /* [helpstring][id][propput] */ HRESULT STDMETHODCALLTYPE put_SurfaceImpedance( 
            /* [in] */ VARIANT SurfaceImpedance) = 0;
        
        virtual /* [helpstring][id][propget] */ HRESULT STDMETHODCALLTYPE get_TotalMerit( 
            /* [retval][out] */ VARIANT *TotalMerit) = 0;
        
        virtual /* [helpstring][id][propput] */ HRESULT STDMETHODCALLTYPE put_TotalMerit( 
            /* [in] */ VARIANT TotalMerit) = 0;
        
        virtual /* [helpstring][id][propget] */ HRESULT STDMETHODCALLTYPE get_SolidPara( 
            /* [retval][out] */ VARIANT *SolidPara) = 0;
        
        virtual /* [helpstring][id][propput] */ HRESULT STDMETHODCALLTYPE put_SolidPara( 
            /* [in] */ VARIANT SolidPara) = 0;
        
        virtual /* [helpstring][id][propget] */ HRESULT STDMETHODCALLTYPE get_DataFitted( 
            /* [retval][out] */ VARIANT *DataFitted) = 0;
        
        virtual /* [helpstring][id][propput] */ HRESULT STDMETHODCALLTYPE put_DataFitted( 
            /* [in] */ VARIANT DataFitted) = 0;
        
    };
    
#else 	/* C style interface */

    typedef struct IMPEclassVtbl
    {
        BEGIN_INTERFACE
        
        HRESULT ( STDMETHODCALLTYPE *QueryInterface )( 
            IMPEclass * This,
            /* [in] */ REFIID riid,
            /* [iid_is][out] */ void **ppvObject);
        
        ULONG ( STDMETHODCALLTYPE *AddRef )( 
            IMPEclass * This);
        
        ULONG ( STDMETHODCALLTYPE *Release )( 
            IMPEclass * This);
        
        HRESULT ( STDMETHODCALLTYPE *GetTypeInfoCount )( 
            IMPEclass * This,
            /* [out] */ UINT *pctinfo);
        
        HRESULT ( STDMETHODCALLTYPE *GetTypeInfo )( 
            IMPEclass * This,
            /* [in] */ UINT iTInfo,
            /* [in] */ LCID lcid,
            /* [out] */ ITypeInfo **ppTInfo);
        
        HRESULT ( STDMETHODCALLTYPE *GetIDsOfNames )( 
            IMPEclass * This,
            /* [in] */ REFIID riid,
            /* [size_is][in] */ LPOLESTR *rgszNames,
            /* [in] */ UINT cNames,
            /* [in] */ LCID lcid,
            /* [size_is][out] */ DISPID *rgDispId);
        
        /* [local] */ HRESULT ( STDMETHODCALLTYPE *Invoke )( 
            IMPEclass * This,
            /* [in] */ DISPID dispIdMember,
            /* [in] */ REFIID riid,
            /* [in] */ LCID lcid,
            /* [in] */ WORD wFlags,
            /* [out][in] */ DISPPARAMS *pDispParams,
            /* [out] */ VARIANT *pVarResult,
            /* [out] */ EXCEPINFO *pExcepInfo,
            /* [out] */ UINT *puArgErr);
        
        /* [helpstring][id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_MWFlags )( 
            IMPEclass * This,
            /* [retval][out] */ IMWFlags **ppvFlags);
        
        /* [helpstring][id][propput] */ HRESULT ( STDMETHODCALLTYPE *put_MWFlags )( 
            IMPEclass * This,
            /* [in] */ IMWFlags *pvFlags);
        
        /* [helpstring][id] */ HRESULT ( STDMETHODCALLTYPE *apfibrous5para )( 
            IMPEclass * This,
            /* [in] */ VARIANT L,
            /* [in] */ VARIANT BulkDensity,
            /* [in] */ VARIANT FlowRes,
            /* [in] */ VARIANT SFactor,
            /* [in] */ VARIANT h,
            /* [in] */ VARIANT c1,
            /* [in] */ VARIANT c2,
            /* [in] */ VARIANT fre);
        
        /* [helpstring][id] */ HRESULT ( STDMETHODCALLTYPE *elasticmeritcalc )( 
            IMPEclass * This,
            /* [in] */ VARIANT freq,
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
        
        /* [helpstring][id] */ HRESULT ( STDMETHODCALLTYPE *meritcalc )( 
            IMPEclass * This,
            /* [in] */ VARIANT freq,
            /* [in] */ VARIANT MAbsorption,
            /* [in] */ VARIANT BulkDensity,
            /* [in] */ VARIANT FlowRes,
            /* [in] */ VARIANT SFactor,
            /* [in] */ VARIANT h,
            /* [in] */ VARIANT c1,
            /* [in] */ VARIANT c2,
            /* [in] */ VARIANT L);
        
        /* [helpstring][id] */ HRESULT ( STDMETHODCALLTYPE *pecalc )( 
            IMPEclass * This,
            /* [in] */ VARIANT PrevError);
        
        /* [helpstring][id] */ HRESULT ( STDMETHODCALLTYPE *peelasticsolid )( 
            IMPEclass * This,
            /* [in] */ VARIANT L,
            /* [in] */ VARIANT BulkDensity,
            /* [in] */ VARIANT h,
            /* [in] */ VARIANT ResonanceFrequency);
        
        /* [helpstring][id] */ HRESULT ( STDMETHODCALLTYPE *polyfitting )( 
            IMPEclass * This,
            /* [in] */ VARIANT FrequencyFitted,
            /* [in] */ VARIANT FrequencySampled,
            /* [in] */ VARIANT DataSampled,
            /* [in] */ VARIANT n);
        
        /* [helpstring][id] */ HRESULT ( STDMETHODCALLTYPE *totalmeritcalc )( 
            IMPEclass * This,
            /* [in] */ VARIANT Freq1,
            /* [in] */ VARIANT Freq2,
            /* [in] */ VARIANT tFlowRes,
            /* [in] */ VARIANT tSFactor,
            /* [in] */ VARIANT h,
            /* [in] */ VARIANT c1,
            /* [in] */ VARIANT c2);
        
        /* [helpstring][id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_ItaAir )( 
            IMPEclass * This,
            /* [retval][out] */ VARIANT *ItaAir);
        
        /* [helpstring][id][propput] */ HRESULT ( STDMETHODCALLTYPE *put_ItaAir )( 
            IMPEclass * This,
            /* [in] */ VARIANT ItaAir);
        
        /* [helpstring][id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_P0 )( 
            IMPEclass * This,
            /* [retval][out] */ VARIANT *P0);
        
        /* [helpstring][id][propput] */ HRESULT ( STDMETHODCALLTYPE *put_P0 )( 
            IMPEclass * This,
            /* [in] */ VARIANT P0);
        
        /* [helpstring][id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_Densityo )( 
            IMPEclass * This,
            /* [retval][out] */ VARIANT *Densityo);
        
        /* [helpstring][id][propput] */ HRESULT ( STDMETHODCALLTYPE *put_Densityo )( 
            IMPEclass * This,
            /* [in] */ VARIANT Densityo);
        
        /* [helpstring][id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_Z0 )( 
            IMPEclass * This,
            /* [retval][out] */ VARIANT *Z0);
        
        /* [helpstring][id][propput] */ HRESULT ( STDMETHODCALLTYPE *put_Z0 )( 
            IMPEclass * This,
            /* [in] */ VARIANT Z0);
        
        /* [helpstring][id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_MAbsorption )( 
            IMPEclass * This,
            /* [retval][out] */ VARIANT *MAbsorption);
        
        /* [helpstring][id][propput] */ HRESULT ( STDMETHODCALLTYPE *put_MAbsorption )( 
            IMPEclass * This,
            /* [in] */ VARIANT MAbsorption);
        
        /* [helpstring][id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_B )( 
            IMPEclass * This,
            /* [retval][out] */ VARIANT *B);
        
        /* [helpstring][id][propput] */ HRESULT ( STDMETHODCALLTYPE *put_B )( 
            IMPEclass * This,
            /* [in] */ VARIANT B);
        
        /* [helpstring][id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_c )( 
            IMPEclass * This,
            /* [retval][out] */ VARIANT *c);
        
        /* [helpstring][id][propput] */ HRESULT ( STDMETHODCALLTYPE *put_c )( 
            IMPEclass * This,
            /* [in] */ VARIANT c);
        
        /* [helpstring][id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_Npr )( 
            IMPEclass * This,
            /* [retval][out] */ VARIANT *Npr);
        
        /* [helpstring][id][propput] */ HRESULT ( STDMETHODCALLTYPE *put_Npr )( 
            IMPEclass * This,
            /* [in] */ VARIANT Npr);
        
        /* [helpstring][id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_Density1 )( 
            IMPEclass * This,
            /* [retval][out] */ VARIANT *Density1);
        
        /* [helpstring][id][propput] */ HRESULT ( STDMETHODCALLTYPE *put_Density1 )( 
            IMPEclass * This,
            /* [in] */ VARIANT Density1);
        
        /* [helpstring][id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_DensityA )( 
            IMPEclass * This,
            /* [retval][out] */ VARIANT *DensityA);
        
        /* [helpstring][id][propput] */ HRESULT ( STDMETHODCALLTYPE *put_DensityA )( 
            IMPEclass * This,
            /* [in] */ VARIANT DensityA);
        
        /* [helpstring][id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_HeatRatio )( 
            IMPEclass * This,
            /* [retval][out] */ VARIANT *HeatRatio);
        
        /* [helpstring][id][propput] */ HRESULT ( STDMETHODCALLTYPE *put_HeatRatio )( 
            IMPEclass * This,
            /* [in] */ VARIANT HeatRatio);
        
        /* [helpstring][id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_APFibrous )( 
            IMPEclass * This,
            /* [retval][out] */ VARIANT *APFibrous);
        
        /* [helpstring][id][propput] */ HRESULT ( STDMETHODCALLTYPE *put_APFibrous )( 
            IMPEclass * This,
            /* [in] */ VARIANT APFibrous);
        
        /* [helpstring][id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_Merit )( 
            IMPEclass * This,
            /* [retval][out] */ VARIANT *Merit);
        
        /* [helpstring][id][propput] */ HRESULT ( STDMETHODCALLTYPE *put_Merit )( 
            IMPEclass * This,
            /* [in] */ VARIANT Merit);
        
        /* [helpstring][id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_Absorption )( 
            IMPEclass * This,
            /* [retval][out] */ VARIANT *Absorption);
        
        /* [helpstring][id][propput] */ HRESULT ( STDMETHODCALLTYPE *put_Absorption )( 
            IMPEclass * This,
            /* [in] */ VARIANT Absorption);
        
        /* [helpstring][id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_RealSurfaceImpedance )( 
            IMPEclass * This,
            /* [retval][out] */ VARIANT *RealSurfaceImpedance);
        
        /* [helpstring][id][propput] */ HRESULT ( STDMETHODCALLTYPE *put_RealSurfaceImpedance )( 
            IMPEclass * This,
            /* [in] */ VARIANT RealSurfaceImpedance);
        
        /* [helpstring][id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_ImagSurfaceImpedance )( 
            IMPEclass * This,
            /* [retval][out] */ VARIANT *ImagSurfaceImpedance);
        
        /* [helpstring][id][propput] */ HRESULT ( STDMETHODCALLTYPE *put_ImagSurfaceImpedance )( 
            IMPEclass * This,
            /* [in] */ VARIANT ImagSurfaceImpedance);
        
        /* [helpstring][id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_BulkDensity )( 
            IMPEclass * This,
            /* [retval][out] */ VARIANT *BulkDensity);
        
        /* [helpstring][id][propput] */ HRESULT ( STDMETHODCALLTYPE *put_BulkDensity )( 
            IMPEclass * This,
            /* [in] */ VARIANT BulkDensity);
        
        /* [helpstring][id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_Thickness )( 
            IMPEclass * This,
            /* [retval][out] */ VARIANT *Thickness);
        
        /* [helpstring][id][propput] */ HRESULT ( STDMETHODCALLTYPE *put_Thickness )( 
            IMPEclass * This,
            /* [in] */ VARIANT Thickness);
        
        /* [helpstring][id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_FlowRes )( 
            IMPEclass * This,
            /* [retval][out] */ VARIANT *FlowRes);
        
        /* [helpstring][id][propput] */ HRESULT ( STDMETHODCALLTYPE *put_FlowRes )( 
            IMPEclass * This,
            /* [in] */ VARIANT FlowRes);
        
        /* [helpstring][id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_SFactor )( 
            IMPEclass * This,
            /* [retval][out] */ VARIANT *SFactor);
        
        /* [helpstring][id][propput] */ HRESULT ( STDMETHODCALLTYPE *put_SFactor )( 
            IMPEclass * This,
            /* [in] */ VARIANT SFactor);
        
        /* [helpstring][id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_Porosity )( 
            IMPEclass * This,
            /* [retval][out] */ VARIANT *Porosity);
        
        /* [helpstring][id][propput] */ HRESULT ( STDMETHODCALLTYPE *put_Porosity )( 
            IMPEclass * This,
            /* [in] */ VARIANT Porosity);
        
        /* [helpstring][id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_ViscousCL )( 
            IMPEclass * This,
            /* [retval][out] */ VARIANT *ViscousCL);
        
        /* [helpstring][id][propput] */ HRESULT ( STDMETHODCALLTYPE *put_ViscousCL )( 
            IMPEclass * This,
            /* [in] */ VARIANT ViscousCL);
        
        /* [helpstring][id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_ThermalCL )( 
            IMPEclass * This,
            /* [retval][out] */ VARIANT *ThermalCL);
        
        /* [helpstring][id][propput] */ HRESULT ( STDMETHODCALLTYPE *put_ThermalCL )( 
            IMPEclass * This,
            /* [in] */ VARIANT ThermalCL);
        
        /* [helpstring][id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_FlowResEst )( 
            IMPEclass * This,
            /* [retval][out] */ VARIANT *FlowResEst);
        
        /* [helpstring][id][propput] */ HRESULT ( STDMETHODCALLTYPE *put_FlowResEst )( 
            IMPEclass * This,
            /* [in] */ VARIANT FlowResEst);
        
        /* [helpstring][id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_SFactorEst )( 
            IMPEclass * This,
            /* [retval][out] */ VARIANT *SFactorEst);
        
        /* [helpstring][id][propput] */ HRESULT ( STDMETHODCALLTYPE *put_SFactorEst )( 
            IMPEclass * This,
            /* [in] */ VARIANT SFactorEst);
        
        /* [helpstring][id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_PorosityEst )( 
            IMPEclass * This,
            /* [retval][out] */ VARIANT *PorosityEst);
        
        /* [helpstring][id][propput] */ HRESULT ( STDMETHODCALLTYPE *put_PorosityEst )( 
            IMPEclass * This,
            /* [in] */ VARIANT PorosityEst);
        
        /* [helpstring][id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_ViscousCLEst )( 
            IMPEclass * This,
            /* [retval][out] */ VARIANT *ViscousCLEst);
        
        /* [helpstring][id][propput] */ HRESULT ( STDMETHODCALLTYPE *put_ViscousCLEst )( 
            IMPEclass * This,
            /* [in] */ VARIANT ViscousCLEst);
        
        /* [helpstring][id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_ThermalCLEst )( 
            IMPEclass * This,
            /* [retval][out] */ VARIANT *ThermalCLEst);
        
        /* [helpstring][id][propput] */ HRESULT ( STDMETHODCALLTYPE *put_ThermalCLEst )( 
            IMPEclass * This,
            /* [in] */ VARIANT ThermalCLEst);
        
        /* [helpstring][id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_freq )( 
            IMPEclass * This,
            /* [retval][out] */ VARIANT *freq);
        
        /* [helpstring][id][propput] */ HRESULT ( STDMETHODCALLTYPE *put_freq )( 
            IMPEclass * This,
            /* [in] */ VARIANT freq);
        
        /* [helpstring][id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_Frequency )( 
            IMPEclass * This,
            /* [retval][out] */ VARIANT *Frequency);
        
        /* [helpstring][id][propput] */ HRESULT ( STDMETHODCALLTYPE *put_Frequency )( 
            IMPEclass * This,
            /* [in] */ VARIANT Frequency);
        
        /* [helpstring][id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_SurfaceImpedance )( 
            IMPEclass * This,
            /* [retval][out] */ VARIANT *SurfaceImpedance);
        
        /* [helpstring][id][propput] */ HRESULT ( STDMETHODCALLTYPE *put_SurfaceImpedance )( 
            IMPEclass * This,
            /* [in] */ VARIANT SurfaceImpedance);
        
        /* [helpstring][id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_TotalMerit )( 
            IMPEclass * This,
            /* [retval][out] */ VARIANT *TotalMerit);
        
        /* [helpstring][id][propput] */ HRESULT ( STDMETHODCALLTYPE *put_TotalMerit )( 
            IMPEclass * This,
            /* [in] */ VARIANT TotalMerit);
        
        /* [helpstring][id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_SolidPara )( 
            IMPEclass * This,
            /* [retval][out] */ VARIANT *SolidPara);
        
        /* [helpstring][id][propput] */ HRESULT ( STDMETHODCALLTYPE *put_SolidPara )( 
            IMPEclass * This,
            /* [in] */ VARIANT SolidPara);
        
        /* [helpstring][id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_DataFitted )( 
            IMPEclass * This,
            /* [retval][out] */ VARIANT *DataFitted);
        
        /* [helpstring][id][propput] */ HRESULT ( STDMETHODCALLTYPE *put_DataFitted )( 
            IMPEclass * This,
            /* [in] */ VARIANT DataFitted);
        
        END_INTERFACE
    } IMPEclassVtbl;

    interface IMPEclass
    {
        CONST_VTBL struct IMPEclassVtbl *lpVtbl;
    };

    

#ifdef COBJMACROS


#define IMPEclass_QueryInterface(This,riid,ppvObject)	\
    (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)

#define IMPEclass_AddRef(This)	\
    (This)->lpVtbl -> AddRef(This)

#define IMPEclass_Release(This)	\
    (This)->lpVtbl -> Release(This)


#define IMPEclass_GetTypeInfoCount(This,pctinfo)	\
    (This)->lpVtbl -> GetTypeInfoCount(This,pctinfo)

#define IMPEclass_GetTypeInfo(This,iTInfo,lcid,ppTInfo)	\
    (This)->lpVtbl -> GetTypeInfo(This,iTInfo,lcid,ppTInfo)

#define IMPEclass_GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId)	\
    (This)->lpVtbl -> GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId)

#define IMPEclass_Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr)	\
    (This)->lpVtbl -> Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr)


#define IMPEclass_get_MWFlags(This,ppvFlags)	\
    (This)->lpVtbl -> get_MWFlags(This,ppvFlags)

#define IMPEclass_put_MWFlags(This,pvFlags)	\
    (This)->lpVtbl -> put_MWFlags(This,pvFlags)

#define IMPEclass_apfibrous5para(This,L,BulkDensity,FlowRes,SFactor,h,c1,c2,fre)	\
    (This)->lpVtbl -> apfibrous5para(This,L,BulkDensity,FlowRes,SFactor,h,c1,c2,fre)

#define IMPEclass_elasticmeritcalc(This,freq,MeasuredAbsorption,BulkDensity,FlowRes,SFactor,h,c1,c2,Em,LFactor,PRatio,L)	\
    (This)->lpVtbl -> elasticmeritcalc(This,freq,MeasuredAbsorption,BulkDensity,FlowRes,SFactor,h,c1,c2,Em,LFactor,PRatio,L)

#define IMPEclass_meritcalc(This,freq,MAbsorption,BulkDensity,FlowRes,SFactor,h,c1,c2,L)	\
    (This)->lpVtbl -> meritcalc(This,freq,MAbsorption,BulkDensity,FlowRes,SFactor,h,c1,c2,L)

#define IMPEclass_pecalc(This,PrevError)	\
    (This)->lpVtbl -> pecalc(This,PrevError)

#define IMPEclass_peelasticsolid(This,L,BulkDensity,h,ResonanceFrequency)	\
    (This)->lpVtbl -> peelasticsolid(This,L,BulkDensity,h,ResonanceFrequency)

#define IMPEclass_polyfitting(This,FrequencyFitted,FrequencySampled,DataSampled,n)	\
    (This)->lpVtbl -> polyfitting(This,FrequencyFitted,FrequencySampled,DataSampled,n)

#define IMPEclass_totalmeritcalc(This,Freq1,Freq2,tFlowRes,tSFactor,h,c1,c2)	\
    (This)->lpVtbl -> totalmeritcalc(This,Freq1,Freq2,tFlowRes,tSFactor,h,c1,c2)

#define IMPEclass_get_ItaAir(This,ItaAir)	\
    (This)->lpVtbl -> get_ItaAir(This,ItaAir)

#define IMPEclass_put_ItaAir(This,ItaAir)	\
    (This)->lpVtbl -> put_ItaAir(This,ItaAir)

#define IMPEclass_get_P0(This,P0)	\
    (This)->lpVtbl -> get_P0(This,P0)

#define IMPEclass_put_P0(This,P0)	\
    (This)->lpVtbl -> put_P0(This,P0)

#define IMPEclass_get_Densityo(This,Densityo)	\
    (This)->lpVtbl -> get_Densityo(This,Densityo)

#define IMPEclass_put_Densityo(This,Densityo)	\
    (This)->lpVtbl -> put_Densityo(This,Densityo)

#define IMPEclass_get_Z0(This,Z0)	\
    (This)->lpVtbl -> get_Z0(This,Z0)

#define IMPEclass_put_Z0(This,Z0)	\
    (This)->lpVtbl -> put_Z0(This,Z0)

#define IMPEclass_get_MAbsorption(This,MAbsorption)	\
    (This)->lpVtbl -> get_MAbsorption(This,MAbsorption)

#define IMPEclass_put_MAbsorption(This,MAbsorption)	\
    (This)->lpVtbl -> put_MAbsorption(This,MAbsorption)

#define IMPEclass_get_B(This,B)	\
    (This)->lpVtbl -> get_B(This,B)

#define IMPEclass_put_B(This,B)	\
    (This)->lpVtbl -> put_B(This,B)

#define IMPEclass_get_c(This,c)	\
    (This)->lpVtbl -> get_c(This,c)

#define IMPEclass_put_c(This,c)	\
    (This)->lpVtbl -> put_c(This,c)

#define IMPEclass_get_Npr(This,Npr)	\
    (This)->lpVtbl -> get_Npr(This,Npr)

#define IMPEclass_put_Npr(This,Npr)	\
    (This)->lpVtbl -> put_Npr(This,Npr)

#define IMPEclass_get_Density1(This,Density1)	\
    (This)->lpVtbl -> get_Density1(This,Density1)

#define IMPEclass_put_Density1(This,Density1)	\
    (This)->lpVtbl -> put_Density1(This,Density1)

#define IMPEclass_get_DensityA(This,DensityA)	\
    (This)->lpVtbl -> get_DensityA(This,DensityA)

#define IMPEclass_put_DensityA(This,DensityA)	\
    (This)->lpVtbl -> put_DensityA(This,DensityA)

#define IMPEclass_get_HeatRatio(This,HeatRatio)	\
    (This)->lpVtbl -> get_HeatRatio(This,HeatRatio)

#define IMPEclass_put_HeatRatio(This,HeatRatio)	\
    (This)->lpVtbl -> put_HeatRatio(This,HeatRatio)

#define IMPEclass_get_APFibrous(This,APFibrous)	\
    (This)->lpVtbl -> get_APFibrous(This,APFibrous)

#define IMPEclass_put_APFibrous(This,APFibrous)	\
    (This)->lpVtbl -> put_APFibrous(This,APFibrous)

#define IMPEclass_get_Merit(This,Merit)	\
    (This)->lpVtbl -> get_Merit(This,Merit)

#define IMPEclass_put_Merit(This,Merit)	\
    (This)->lpVtbl -> put_Merit(This,Merit)

#define IMPEclass_get_Absorption(This,Absorption)	\
    (This)->lpVtbl -> get_Absorption(This,Absorption)

#define IMPEclass_put_Absorption(This,Absorption)	\
    (This)->lpVtbl -> put_Absorption(This,Absorption)

#define IMPEclass_get_RealSurfaceImpedance(This,RealSurfaceImpedance)	\
    (This)->lpVtbl -> get_RealSurfaceImpedance(This,RealSurfaceImpedance)

#define IMPEclass_put_RealSurfaceImpedance(This,RealSurfaceImpedance)	\
    (This)->lpVtbl -> put_RealSurfaceImpedance(This,RealSurfaceImpedance)

#define IMPEclass_get_ImagSurfaceImpedance(This,ImagSurfaceImpedance)	\
    (This)->lpVtbl -> get_ImagSurfaceImpedance(This,ImagSurfaceImpedance)

#define IMPEclass_put_ImagSurfaceImpedance(This,ImagSurfaceImpedance)	\
    (This)->lpVtbl -> put_ImagSurfaceImpedance(This,ImagSurfaceImpedance)

#define IMPEclass_get_BulkDensity(This,BulkDensity)	\
    (This)->lpVtbl -> get_BulkDensity(This,BulkDensity)

#define IMPEclass_put_BulkDensity(This,BulkDensity)	\
    (This)->lpVtbl -> put_BulkDensity(This,BulkDensity)

#define IMPEclass_get_Thickness(This,Thickness)	\
    (This)->lpVtbl -> get_Thickness(This,Thickness)

#define IMPEclass_put_Thickness(This,Thickness)	\
    (This)->lpVtbl -> put_Thickness(This,Thickness)

#define IMPEclass_get_FlowRes(This,FlowRes)	\
    (This)->lpVtbl -> get_FlowRes(This,FlowRes)

#define IMPEclass_put_FlowRes(This,FlowRes)	\
    (This)->lpVtbl -> put_FlowRes(This,FlowRes)

#define IMPEclass_get_SFactor(This,SFactor)	\
    (This)->lpVtbl -> get_SFactor(This,SFactor)

#define IMPEclass_put_SFactor(This,SFactor)	\
    (This)->lpVtbl -> put_SFactor(This,SFactor)

#define IMPEclass_get_Porosity(This,Porosity)	\
    (This)->lpVtbl -> get_Porosity(This,Porosity)

#define IMPEclass_put_Porosity(This,Porosity)	\
    (This)->lpVtbl -> put_Porosity(This,Porosity)

#define IMPEclass_get_ViscousCL(This,ViscousCL)	\
    (This)->lpVtbl -> get_ViscousCL(This,ViscousCL)

#define IMPEclass_put_ViscousCL(This,ViscousCL)	\
    (This)->lpVtbl -> put_ViscousCL(This,ViscousCL)

#define IMPEclass_get_ThermalCL(This,ThermalCL)	\
    (This)->lpVtbl -> get_ThermalCL(This,ThermalCL)

#define IMPEclass_put_ThermalCL(This,ThermalCL)	\
    (This)->lpVtbl -> put_ThermalCL(This,ThermalCL)

#define IMPEclass_get_FlowResEst(This,FlowResEst)	\
    (This)->lpVtbl -> get_FlowResEst(This,FlowResEst)

#define IMPEclass_put_FlowResEst(This,FlowResEst)	\
    (This)->lpVtbl -> put_FlowResEst(This,FlowResEst)

#define IMPEclass_get_SFactorEst(This,SFactorEst)	\
    (This)->lpVtbl -> get_SFactorEst(This,SFactorEst)

#define IMPEclass_put_SFactorEst(This,SFactorEst)	\
    (This)->lpVtbl -> put_SFactorEst(This,SFactorEst)

#define IMPEclass_get_PorosityEst(This,PorosityEst)	\
    (This)->lpVtbl -> get_PorosityEst(This,PorosityEst)

#define IMPEclass_put_PorosityEst(This,PorosityEst)	\
    (This)->lpVtbl -> put_PorosityEst(This,PorosityEst)

#define IMPEclass_get_ViscousCLEst(This,ViscousCLEst)	\
    (This)->lpVtbl -> get_ViscousCLEst(This,ViscousCLEst)

#define IMPEclass_put_ViscousCLEst(This,ViscousCLEst)	\
    (This)->lpVtbl -> put_ViscousCLEst(This,ViscousCLEst)

#define IMPEclass_get_ThermalCLEst(This,ThermalCLEst)	\
    (This)->lpVtbl -> get_ThermalCLEst(This,ThermalCLEst)

#define IMPEclass_put_ThermalCLEst(This,ThermalCLEst)	\
    (This)->lpVtbl -> put_ThermalCLEst(This,ThermalCLEst)

#define IMPEclass_get_freq(This,freq)	\
    (This)->lpVtbl -> get_freq(This,freq)

#define IMPEclass_put_freq(This,freq)	\
    (This)->lpVtbl -> put_freq(This,freq)

#define IMPEclass_get_Frequency(This,Frequency)	\
    (This)->lpVtbl -> get_Frequency(This,Frequency)

#define IMPEclass_put_Frequency(This,Frequency)	\
    (This)->lpVtbl -> put_Frequency(This,Frequency)

#define IMPEclass_get_SurfaceImpedance(This,SurfaceImpedance)	\
    (This)->lpVtbl -> get_SurfaceImpedance(This,SurfaceImpedance)

#define IMPEclass_put_SurfaceImpedance(This,SurfaceImpedance)	\
    (This)->lpVtbl -> put_SurfaceImpedance(This,SurfaceImpedance)

#define IMPEclass_get_TotalMerit(This,TotalMerit)	\
    (This)->lpVtbl -> get_TotalMerit(This,TotalMerit)

#define IMPEclass_put_TotalMerit(This,TotalMerit)	\
    (This)->lpVtbl -> put_TotalMerit(This,TotalMerit)

#define IMPEclass_get_SolidPara(This,SolidPara)	\
    (This)->lpVtbl -> get_SolidPara(This,SolidPara)

#define IMPEclass_put_SolidPara(This,SolidPara)	\
    (This)->lpVtbl -> put_SolidPara(This,SolidPara)

#define IMPEclass_get_DataFitted(This,DataFitted)	\
    (This)->lpVtbl -> get_DataFitted(This,DataFitted)

#define IMPEclass_put_DataFitted(This,DataFitted)	\
    (This)->lpVtbl -> put_DataFitted(This,DataFitted)

#endif /* COBJMACROS */


#endif 	/* C style interface */



/* [helpstring][id][propget] */ HRESULT STDMETHODCALLTYPE IMPEclass_get_MWFlags_Proxy( 
    IMPEclass * This,
    /* [retval][out] */ IMWFlags **ppvFlags);


void __RPC_STUB IMPEclass_get_MWFlags_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [helpstring][id][propput] */ HRESULT STDMETHODCALLTYPE IMPEclass_put_MWFlags_Proxy( 
    IMPEclass * This,
    /* [in] */ IMWFlags *pvFlags);


void __RPC_STUB IMPEclass_put_MWFlags_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [helpstring][id] */ HRESULT STDMETHODCALLTYPE IMPEclass_apfibrous5para_Proxy( 
    IMPEclass * This,
    /* [in] */ VARIANT L,
    /* [in] */ VARIANT BulkDensity,
    /* [in] */ VARIANT FlowRes,
    /* [in] */ VARIANT SFactor,
    /* [in] */ VARIANT h,
    /* [in] */ VARIANT c1,
    /* [in] */ VARIANT c2,
    /* [in] */ VARIANT fre);


void __RPC_STUB IMPEclass_apfibrous5para_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [helpstring][id] */ HRESULT STDMETHODCALLTYPE IMPEclass_elasticmeritcalc_Proxy( 
    IMPEclass * This,
    /* [in] */ VARIANT freq,
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


void __RPC_STUB IMPEclass_elasticmeritcalc_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [helpstring][id] */ HRESULT STDMETHODCALLTYPE IMPEclass_meritcalc_Proxy( 
    IMPEclass * This,
    /* [in] */ VARIANT freq,
    /* [in] */ VARIANT MAbsorption,
    /* [in] */ VARIANT BulkDensity,
    /* [in] */ VARIANT FlowRes,
    /* [in] */ VARIANT SFactor,
    /* [in] */ VARIANT h,
    /* [in] */ VARIANT c1,
    /* [in] */ VARIANT c2,
    /* [in] */ VARIANT L);


void __RPC_STUB IMPEclass_meritcalc_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [helpstring][id] */ HRESULT STDMETHODCALLTYPE IMPEclass_pecalc_Proxy( 
    IMPEclass * This,
    /* [in] */ VARIANT PrevError);


void __RPC_STUB IMPEclass_pecalc_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [helpstring][id] */ HRESULT STDMETHODCALLTYPE IMPEclass_peelasticsolid_Proxy( 
    IMPEclass * This,
    /* [in] */ VARIANT L,
    /* [in] */ VARIANT BulkDensity,
    /* [in] */ VARIANT h,
    /* [in] */ VARIANT ResonanceFrequency);


void __RPC_STUB IMPEclass_peelasticsolid_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [helpstring][id] */ HRESULT STDMETHODCALLTYPE IMPEclass_polyfitting_Proxy( 
    IMPEclass * This,
    /* [in] */ VARIANT FrequencyFitted,
    /* [in] */ VARIANT FrequencySampled,
    /* [in] */ VARIANT DataSampled,
    /* [in] */ VARIANT n);


void __RPC_STUB IMPEclass_polyfitting_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [helpstring][id] */ HRESULT STDMETHODCALLTYPE IMPEclass_totalmeritcalc_Proxy( 
    IMPEclass * This,
    /* [in] */ VARIANT Freq1,
    /* [in] */ VARIANT Freq2,
    /* [in] */ VARIANT tFlowRes,
    /* [in] */ VARIANT tSFactor,
    /* [in] */ VARIANT h,
    /* [in] */ VARIANT c1,
    /* [in] */ VARIANT c2);


void __RPC_STUB IMPEclass_totalmeritcalc_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [helpstring][id][propget] */ HRESULT STDMETHODCALLTYPE IMPEclass_get_ItaAir_Proxy( 
    IMPEclass * This,
    /* [retval][out] */ VARIANT *ItaAir);


void __RPC_STUB IMPEclass_get_ItaAir_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [helpstring][id][propput] */ HRESULT STDMETHODCALLTYPE IMPEclass_put_ItaAir_Proxy( 
    IMPEclass * This,
    /* [in] */ VARIANT ItaAir);


void __RPC_STUB IMPEclass_put_ItaAir_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [helpstring][id][propget] */ HRESULT STDMETHODCALLTYPE IMPEclass_get_P0_Proxy( 
    IMPEclass * This,
    /* [retval][out] */ VARIANT *P0);


void __RPC_STUB IMPEclass_get_P0_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [helpstring][id][propput] */ HRESULT STDMETHODCALLTYPE IMPEclass_put_P0_Proxy( 
    IMPEclass * This,
    /* [in] */ VARIANT P0);


void __RPC_STUB IMPEclass_put_P0_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [helpstring][id][propget] */ HRESULT STDMETHODCALLTYPE IMPEclass_get_Densityo_Proxy( 
    IMPEclass * This,
    /* [retval][out] */ VARIANT *Densityo);


void __RPC_STUB IMPEclass_get_Densityo_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [helpstring][id][propput] */ HRESULT STDMETHODCALLTYPE IMPEclass_put_Densityo_Proxy( 
    IMPEclass * This,
    /* [in] */ VARIANT Densityo);


void __RPC_STUB IMPEclass_put_Densityo_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [helpstring][id][propget] */ HRESULT STDMETHODCALLTYPE IMPEclass_get_Z0_Proxy( 
    IMPEclass * This,
    /* [retval][out] */ VARIANT *Z0);


void __RPC_STUB IMPEclass_get_Z0_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [helpstring][id][propput] */ HRESULT STDMETHODCALLTYPE IMPEclass_put_Z0_Proxy( 
    IMPEclass * This,
    /* [in] */ VARIANT Z0);


void __RPC_STUB IMPEclass_put_Z0_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [helpstring][id][propget] */ HRESULT STDMETHODCALLTYPE IMPEclass_get_MAbsorption_Proxy( 
    IMPEclass * This,
    /* [retval][out] */ VARIANT *MAbsorption);


void __RPC_STUB IMPEclass_get_MAbsorption_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [helpstring][id][propput] */ HRESULT STDMETHODCALLTYPE IMPEclass_put_MAbsorption_Proxy( 
    IMPEclass * This,
    /* [in] */ VARIANT MAbsorption);


void __RPC_STUB IMPEclass_put_MAbsorption_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [helpstring][id][propget] */ HRESULT STDMETHODCALLTYPE IMPEclass_get_B_Proxy( 
    IMPEclass * This,
    /* [retval][out] */ VARIANT *B);


void __RPC_STUB IMPEclass_get_B_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [helpstring][id][propput] */ HRESULT STDMETHODCALLTYPE IMPEclass_put_B_Proxy( 
    IMPEclass * This,
    /* [in] */ VARIANT B);


void __RPC_STUB IMPEclass_put_B_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [helpstring][id][propget] */ HRESULT STDMETHODCALLTYPE IMPEclass_get_c_Proxy( 
    IMPEclass * This,
    /* [retval][out] */ VARIANT *c);


void __RPC_STUB IMPEclass_get_c_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [helpstring][id][propput] */ HRESULT STDMETHODCALLTYPE IMPEclass_put_c_Proxy( 
    IMPEclass * This,
    /* [in] */ VARIANT c);


void __RPC_STUB IMPEclass_put_c_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [helpstring][id][propget] */ HRESULT STDMETHODCALLTYPE IMPEclass_get_Npr_Proxy( 
    IMPEclass * This,
    /* [retval][out] */ VARIANT *Npr);


void __RPC_STUB IMPEclass_get_Npr_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [helpstring][id][propput] */ HRESULT STDMETHODCALLTYPE IMPEclass_put_Npr_Proxy( 
    IMPEclass * This,
    /* [in] */ VARIANT Npr);


void __RPC_STUB IMPEclass_put_Npr_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [helpstring][id][propget] */ HRESULT STDMETHODCALLTYPE IMPEclass_get_Density1_Proxy( 
    IMPEclass * This,
    /* [retval][out] */ VARIANT *Density1);


void __RPC_STUB IMPEclass_get_Density1_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [helpstring][id][propput] */ HRESULT STDMETHODCALLTYPE IMPEclass_put_Density1_Proxy( 
    IMPEclass * This,
    /* [in] */ VARIANT Density1);


void __RPC_STUB IMPEclass_put_Density1_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [helpstring][id][propget] */ HRESULT STDMETHODCALLTYPE IMPEclass_get_DensityA_Proxy( 
    IMPEclass * This,
    /* [retval][out] */ VARIANT *DensityA);


void __RPC_STUB IMPEclass_get_DensityA_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [helpstring][id][propput] */ HRESULT STDMETHODCALLTYPE IMPEclass_put_DensityA_Proxy( 
    IMPEclass * This,
    /* [in] */ VARIANT DensityA);


void __RPC_STUB IMPEclass_put_DensityA_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [helpstring][id][propget] */ HRESULT STDMETHODCALLTYPE IMPEclass_get_HeatRatio_Proxy( 
    IMPEclass * This,
    /* [retval][out] */ VARIANT *HeatRatio);


void __RPC_STUB IMPEclass_get_HeatRatio_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [helpstring][id][propput] */ HRESULT STDMETHODCALLTYPE IMPEclass_put_HeatRatio_Proxy( 
    IMPEclass * This,
    /* [in] */ VARIANT HeatRatio);


void __RPC_STUB IMPEclass_put_HeatRatio_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [helpstring][id][propget] */ HRESULT STDMETHODCALLTYPE IMPEclass_get_APFibrous_Proxy( 
    IMPEclass * This,
    /* [retval][out] */ VARIANT *APFibrous);


void __RPC_STUB IMPEclass_get_APFibrous_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [helpstring][id][propput] */ HRESULT STDMETHODCALLTYPE IMPEclass_put_APFibrous_Proxy( 
    IMPEclass * This,
    /* [in] */ VARIANT APFibrous);


void __RPC_STUB IMPEclass_put_APFibrous_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [helpstring][id][propget] */ HRESULT STDMETHODCALLTYPE IMPEclass_get_Merit_Proxy( 
    IMPEclass * This,
    /* [retval][out] */ VARIANT *Merit);


void __RPC_STUB IMPEclass_get_Merit_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [helpstring][id][propput] */ HRESULT STDMETHODCALLTYPE IMPEclass_put_Merit_Proxy( 
    IMPEclass * This,
    /* [in] */ VARIANT Merit);


void __RPC_STUB IMPEclass_put_Merit_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [helpstring][id][propget] */ HRESULT STDMETHODCALLTYPE IMPEclass_get_Absorption_Proxy( 
    IMPEclass * This,
    /* [retval][out] */ VARIANT *Absorption);


void __RPC_STUB IMPEclass_get_Absorption_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [helpstring][id][propput] */ HRESULT STDMETHODCALLTYPE IMPEclass_put_Absorption_Proxy( 
    IMPEclass * This,
    /* [in] */ VARIANT Absorption);


void __RPC_STUB IMPEclass_put_Absorption_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [helpstring][id][propget] */ HRESULT STDMETHODCALLTYPE IMPEclass_get_RealSurfaceImpedance_Proxy( 
    IMPEclass * This,
    /* [retval][out] */ VARIANT *RealSurfaceImpedance);


void __RPC_STUB IMPEclass_get_RealSurfaceImpedance_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [helpstring][id][propput] */ HRESULT STDMETHODCALLTYPE IMPEclass_put_RealSurfaceImpedance_Proxy( 
    IMPEclass * This,
    /* [in] */ VARIANT RealSurfaceImpedance);


void __RPC_STUB IMPEclass_put_RealSurfaceImpedance_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [helpstring][id][propget] */ HRESULT STDMETHODCALLTYPE IMPEclass_get_ImagSurfaceImpedance_Proxy( 
    IMPEclass * This,
    /* [retval][out] */ VARIANT *ImagSurfaceImpedance);


void __RPC_STUB IMPEclass_get_ImagSurfaceImpedance_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [helpstring][id][propput] */ HRESULT STDMETHODCALLTYPE IMPEclass_put_ImagSurfaceImpedance_Proxy( 
    IMPEclass * This,
    /* [in] */ VARIANT ImagSurfaceImpedance);


void __RPC_STUB IMPEclass_put_ImagSurfaceImpedance_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [helpstring][id][propget] */ HRESULT STDMETHODCALLTYPE IMPEclass_get_BulkDensity_Proxy( 
    IMPEclass * This,
    /* [retval][out] */ VARIANT *BulkDensity);


void __RPC_STUB IMPEclass_get_BulkDensity_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [helpstring][id][propput] */ HRESULT STDMETHODCALLTYPE IMPEclass_put_BulkDensity_Proxy( 
    IMPEclass * This,
    /* [in] */ VARIANT BulkDensity);


void __RPC_STUB IMPEclass_put_BulkDensity_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [helpstring][id][propget] */ HRESULT STDMETHODCALLTYPE IMPEclass_get_Thickness_Proxy( 
    IMPEclass * This,
    /* [retval][out] */ VARIANT *Thickness);


void __RPC_STUB IMPEclass_get_Thickness_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [helpstring][id][propput] */ HRESULT STDMETHODCALLTYPE IMPEclass_put_Thickness_Proxy( 
    IMPEclass * This,
    /* [in] */ VARIANT Thickness);


void __RPC_STUB IMPEclass_put_Thickness_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [helpstring][id][propget] */ HRESULT STDMETHODCALLTYPE IMPEclass_get_FlowRes_Proxy( 
    IMPEclass * This,
    /* [retval][out] */ VARIANT *FlowRes);


void __RPC_STUB IMPEclass_get_FlowRes_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [helpstring][id][propput] */ HRESULT STDMETHODCALLTYPE IMPEclass_put_FlowRes_Proxy( 
    IMPEclass * This,
    /* [in] */ VARIANT FlowRes);


void __RPC_STUB IMPEclass_put_FlowRes_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [helpstring][id][propget] */ HRESULT STDMETHODCALLTYPE IMPEclass_get_SFactor_Proxy( 
    IMPEclass * This,
    /* [retval][out] */ VARIANT *SFactor);


void __RPC_STUB IMPEclass_get_SFactor_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [helpstring][id][propput] */ HRESULT STDMETHODCALLTYPE IMPEclass_put_SFactor_Proxy( 
    IMPEclass * This,
    /* [in] */ VARIANT SFactor);


void __RPC_STUB IMPEclass_put_SFactor_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [helpstring][id][propget] */ HRESULT STDMETHODCALLTYPE IMPEclass_get_Porosity_Proxy( 
    IMPEclass * This,
    /* [retval][out] */ VARIANT *Porosity);


void __RPC_STUB IMPEclass_get_Porosity_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [helpstring][id][propput] */ HRESULT STDMETHODCALLTYPE IMPEclass_put_Porosity_Proxy( 
    IMPEclass * This,
    /* [in] */ VARIANT Porosity);


void __RPC_STUB IMPEclass_put_Porosity_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [helpstring][id][propget] */ HRESULT STDMETHODCALLTYPE IMPEclass_get_ViscousCL_Proxy( 
    IMPEclass * This,
    /* [retval][out] */ VARIANT *ViscousCL);


void __RPC_STUB IMPEclass_get_ViscousCL_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [helpstring][id][propput] */ HRESULT STDMETHODCALLTYPE IMPEclass_put_ViscousCL_Proxy( 
    IMPEclass * This,
    /* [in] */ VARIANT ViscousCL);


void __RPC_STUB IMPEclass_put_ViscousCL_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [helpstring][id][propget] */ HRESULT STDMETHODCALLTYPE IMPEclass_get_ThermalCL_Proxy( 
    IMPEclass * This,
    /* [retval][out] */ VARIANT *ThermalCL);


void __RPC_STUB IMPEclass_get_ThermalCL_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [helpstring][id][propput] */ HRESULT STDMETHODCALLTYPE IMPEclass_put_ThermalCL_Proxy( 
    IMPEclass * This,
    /* [in] */ VARIANT ThermalCL);


void __RPC_STUB IMPEclass_put_ThermalCL_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [helpstring][id][propget] */ HRESULT STDMETHODCALLTYPE IMPEclass_get_FlowResEst_Proxy( 
    IMPEclass * This,
    /* [retval][out] */ VARIANT *FlowResEst);


void __RPC_STUB IMPEclass_get_FlowResEst_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [helpstring][id][propput] */ HRESULT STDMETHODCALLTYPE IMPEclass_put_FlowResEst_Proxy( 
    IMPEclass * This,
    /* [in] */ VARIANT FlowResEst);


void __RPC_STUB IMPEclass_put_FlowResEst_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [helpstring][id][propget] */ HRESULT STDMETHODCALLTYPE IMPEclass_get_SFactorEst_Proxy( 
    IMPEclass * This,
    /* [retval][out] */ VARIANT *SFactorEst);


void __RPC_STUB IMPEclass_get_SFactorEst_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [helpstring][id][propput] */ HRESULT STDMETHODCALLTYPE IMPEclass_put_SFactorEst_Proxy( 
    IMPEclass * This,
    /* [in] */ VARIANT SFactorEst);


void __RPC_STUB IMPEclass_put_SFactorEst_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [helpstring][id][propget] */ HRESULT STDMETHODCALLTYPE IMPEclass_get_PorosityEst_Proxy( 
    IMPEclass * This,
    /* [retval][out] */ VARIANT *PorosityEst);


void __RPC_STUB IMPEclass_get_PorosityEst_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [helpstring][id][propput] */ HRESULT STDMETHODCALLTYPE IMPEclass_put_PorosityEst_Proxy( 
    IMPEclass * This,
    /* [in] */ VARIANT PorosityEst);


void __RPC_STUB IMPEclass_put_PorosityEst_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [helpstring][id][propget] */ HRESULT STDMETHODCALLTYPE IMPEclass_get_ViscousCLEst_Proxy( 
    IMPEclass * This,
    /* [retval][out] */ VARIANT *ViscousCLEst);


void __RPC_STUB IMPEclass_get_ViscousCLEst_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [helpstring][id][propput] */ HRESULT STDMETHODCALLTYPE IMPEclass_put_ViscousCLEst_Proxy( 
    IMPEclass * This,
    /* [in] */ VARIANT ViscousCLEst);


void __RPC_STUB IMPEclass_put_ViscousCLEst_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [helpstring][id][propget] */ HRESULT STDMETHODCALLTYPE IMPEclass_get_ThermalCLEst_Proxy( 
    IMPEclass * This,
    /* [retval][out] */ VARIANT *ThermalCLEst);


void __RPC_STUB IMPEclass_get_ThermalCLEst_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [helpstring][id][propput] */ HRESULT STDMETHODCALLTYPE IMPEclass_put_ThermalCLEst_Proxy( 
    IMPEclass * This,
    /* [in] */ VARIANT ThermalCLEst);


void __RPC_STUB IMPEclass_put_ThermalCLEst_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [helpstring][id][propget] */ HRESULT STDMETHODCALLTYPE IMPEclass_get_freq_Proxy( 
    IMPEclass * This,
    /* [retval][out] */ VARIANT *freq);


void __RPC_STUB IMPEclass_get_freq_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [helpstring][id][propput] */ HRESULT STDMETHODCALLTYPE IMPEclass_put_freq_Proxy( 
    IMPEclass * This,
    /* [in] */ VARIANT freq);


void __RPC_STUB IMPEclass_put_freq_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [helpstring][id][propget] */ HRESULT STDMETHODCALLTYPE IMPEclass_get_Frequency_Proxy( 
    IMPEclass * This,
    /* [retval][out] */ VARIANT *Frequency);


void __RPC_STUB IMPEclass_get_Frequency_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [helpstring][id][propput] */ HRESULT STDMETHODCALLTYPE IMPEclass_put_Frequency_Proxy( 
    IMPEclass * This,
    /* [in] */ VARIANT Frequency);


void __RPC_STUB IMPEclass_put_Frequency_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [helpstring][id][propget] */ HRESULT STDMETHODCALLTYPE IMPEclass_get_SurfaceImpedance_Proxy( 
    IMPEclass * This,
    /* [retval][out] */ VARIANT *SurfaceImpedance);


void __RPC_STUB IMPEclass_get_SurfaceImpedance_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [helpstring][id][propput] */ HRESULT STDMETHODCALLTYPE IMPEclass_put_SurfaceImpedance_Proxy( 
    IMPEclass * This,
    /* [in] */ VARIANT SurfaceImpedance);


void __RPC_STUB IMPEclass_put_SurfaceImpedance_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [helpstring][id][propget] */ HRESULT STDMETHODCALLTYPE IMPEclass_get_TotalMerit_Proxy( 
    IMPEclass * This,
    /* [retval][out] */ VARIANT *TotalMerit);


void __RPC_STUB IMPEclass_get_TotalMerit_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [helpstring][id][propput] */ HRESULT STDMETHODCALLTYPE IMPEclass_put_TotalMerit_Proxy( 
    IMPEclass * This,
    /* [in] */ VARIANT TotalMerit);


void __RPC_STUB IMPEclass_put_TotalMerit_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [helpstring][id][propget] */ HRESULT STDMETHODCALLTYPE IMPEclass_get_SolidPara_Proxy( 
    IMPEclass * This,
    /* [retval][out] */ VARIANT *SolidPara);


void __RPC_STUB IMPEclass_get_SolidPara_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [helpstring][id][propput] */ HRESULT STDMETHODCALLTYPE IMPEclass_put_SolidPara_Proxy( 
    IMPEclass * This,
    /* [in] */ VARIANT SolidPara);


void __RPC_STUB IMPEclass_put_SolidPara_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [helpstring][id][propget] */ HRESULT STDMETHODCALLTYPE IMPEclass_get_DataFitted_Proxy( 
    IMPEclass * This,
    /* [retval][out] */ VARIANT *DataFitted);


void __RPC_STUB IMPEclass_get_DataFitted_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [helpstring][id][propput] */ HRESULT STDMETHODCALLTYPE IMPEclass_put_DataFitted_Proxy( 
    IMPEclass * This,
    /* [in] */ VARIANT DataFitted);


void __RPC_STUB IMPEclass_put_DataFitted_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);



#endif 	/* __IMPEclass_INTERFACE_DEFINED__ */



#ifndef __MPE_LIBRARY_DEFINED__
#define __MPE_LIBRARY_DEFINED__

/* library MPE */
/* [helpstring][version][uuid] */ 


EXTERN_C const IID LIBID_MPE;

EXTERN_C const CLSID CLSID_MPEclass;

#ifdef __cplusplus

class DECLSPEC_UUID("BC5CDAF7-66A6-48F2-AFCA-5C85D1249E67")
MPEclass;
#endif
#endif /* __MPE_LIBRARY_DEFINED__ */

/* Additional Prototypes for ALL interfaces */

unsigned long             __RPC_USER  VARIANT_UserSize(     unsigned long *, unsigned long            , VARIANT * ); 
unsigned char * __RPC_USER  VARIANT_UserMarshal(  unsigned long *, unsigned char *, VARIANT * ); 
unsigned char * __RPC_USER  VARIANT_UserUnmarshal(unsigned long *, unsigned char *, VARIANT * ); 
void                      __RPC_USER  VARIANT_UserFree(     unsigned long *, VARIANT * ); 

/* end of Additional Prototypes */

#ifdef __cplusplus
}
#endif

#endif


