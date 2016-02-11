

/* this ALWAYS GENERATED file contains the definitions for the interfaces */


 /* File created by MIDL compiler version 6.00.0361 */
/* at Mon Jul 31 14:27:08 2006
 */
/* Compiler settings for C:/HONUS/Matlabresurce/TMsourcefiles//src\tm_idl.idl:
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

#ifndef __tm_idl_h__
#define __tm_idl_h__

#if defined(_MSC_VER) && (_MSC_VER >= 1020)
#pragma once
#endif

/* Forward Declarations */ 

#ifndef __ITMclass_FWD_DEFINED__
#define __ITMclass_FWD_DEFINED__
typedef interface ITMclass ITMclass;
#endif 	/* __ITMclass_FWD_DEFINED__ */


#ifndef __TMclass_FWD_DEFINED__
#define __TMclass_FWD_DEFINED__

#ifdef __cplusplus
typedef class TMclass TMclass;
#else
typedef struct TMclass TMclass;
#endif /* __cplusplus */

#endif 	/* __TMclass_FWD_DEFINED__ */


/* header files for imported files */
#include "oaidl.h"
#include "ocidl.h"
#include "mwcomtypes.h"

#ifdef __cplusplus
extern "C"{
#endif 

void * __RPC_USER MIDL_user_allocate(size_t);
void __RPC_USER MIDL_user_free( void * ); 

#ifndef __ITMclass_INTERFACE_DEFINED__
#define __ITMclass_INTERFACE_DEFINED__

/* interface ITMclass */
/* [unique][helpstring][dual][uuid][object] */ 


EXTERN_C const IID IID_ITMclass;

#if defined(__cplusplus) && !defined(CINTERFACE)
    
    MIDL_INTERFACE("F03D82B3-EBFC-4612-8D41-4B25DE0FF4C0")
    ITMclass : public IDispatch
    {
    public:
        virtual /* [helpstring][id][propget] */ HRESULT STDMETHODCALLTYPE get_MWFlags( 
            /* [retval][out] */ IMWFlags **ppvFlags) = 0;
        
        virtual /* [helpstring][id][propput] */ HRESULT STDMETHODCALLTYPE put_MWFlags( 
            /* [in] */ IMWFlags *pvFlags) = 0;
        
        virtual /* [helpstring][id] */ HRESULT STDMETHODCALLTYPE tmair( 
            /* [in] */ VARIANT freq,
            /* [in] */ VARIANT theta,
            /* [in] */ VARIANT L) = 0;
        
        virtual /* [helpstring][id] */ HRESULT STDMETHODCALLTYPE tmcalc( 
            /* [in] */ VARIANT freq,
            /* [in] */ VARIANT theta,
            /* [in] */ VARIANT TotalThickness) = 0;
        
        virtual /* [helpstring][id] */ HRESULT STDMETHODCALLTYPE tmcheck( void) = 0;
        
        virtual /* [helpstring][id] */ HRESULT STDMETHODCALLTYPE tmelastic( 
            /* [in] */ VARIANT freq,
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
            /* [in] */ VARIANT PRatio) = 0;
        
        virtual /* [helpstring][id] */ HRESULT STDMETHODCALLTYPE tmelasticpanel( 
            /* [in] */ VARIANT freq,
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
            /* [in] */ VARIANT PRatiop) = 0;
        
        virtual /* [helpstring][id] */ HRESULT STDMETHODCALLTYPE tmeye( void) = 0;
        
        virtual /* [helpstring][id] */ HRESULT STDMETHODCALLTYPE tmimpermemb( 
            /* [in] */ VARIANT freq,
            /* [in] */ VARIANT theta,
            /* [in] */ VARIANT L,
            /* [in] */ VARIANT Density) = 0;
        
        virtual /* [helpstring][id] */ HRESULT STDMETHODCALLTYPE tminit( void) = 0;
        
        virtual /* [helpstring][id] */ HRESULT STDMETHODCALLTYPE tmlimp( 
            /* [in] */ VARIANT freq,
            /* [in] */ VARIANT theta,
            /* [in] */ VARIANT L,
            /* [in] */ VARIANT BulkDensity,
            /* [in] */ VARIANT FlowRes,
            /* [in] */ VARIANT SFactor,
            /* [in] */ VARIANT h,
            /* [in] */ VARIANT VCL,
            /* [in] */ VARIANT TCL) = 0;
        
        virtual /* [helpstring][id] */ HRESULT STDMETHODCALLTYPE tmmul( void) = 0;
        
        virtual /* [helpstring][id] */ HRESULT STDMETHODCALLTYPE tmpanel( 
            /* [in] */ VARIANT freq,
            /* [in] */ VARIANT theta,
            /* [in] */ VARIANT L,
            /* [in] */ VARIANT Density,
            /* [in] */ VARIANT Em,
            /* [in] */ VARIANT PRatio) = 0;
        
        virtual /* [helpstring][id] */ HRESULT STDMETHODCALLTYPE tmpanelelastic( 
            /* [in] */ VARIANT freq,
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
            /* [in] */ VARIANT LFactor) = 0;
        
        virtual /* [helpstring][id] */ HRESULT STDMETHODCALLTYPE tmpanelelasticpanel( 
            /* [in] */ VARIANT freq,
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
            /* [in] */ VARIANT PRatiop2) = 0;
        
        virtual /* [helpstring][id] */ HRESULT STDMETHODCALLTYPE tmpermemb( 
            /* [in] */ VARIANT freq,
            /* [in] */ VARIANT theta,
            /* [in] */ VARIANT L,
            /* [in] */ VARIANT Density,
            /* [in] */ VARIANT FlowRes) = 0;
        
        virtual /* [helpstring][id] */ HRESULT STDMETHODCALLTYPE tmrigid( 
            /* [in] */ VARIANT freq,
            /* [in] */ VARIANT theta,
            /* [in] */ VARIANT L,
            /* [in] */ VARIANT BulkDensity,
            /* [in] */ VARIANT FlowRes,
            /* [in] */ VARIANT SFactor,
            /* [in] */ VARIANT h,
            /* [in] */ VARIANT VCL,
            /* [in] */ VARIANT TCL) = 0;
        
        virtual /* [helpstring][id][propget] */ HRESULT STDMETHODCALLTYPE get_TM( 
            /* [retval][out] */ VARIANT *TM) = 0;
        
        virtual /* [helpstring][id][propput] */ HRESULT STDMETHODCALLTYPE put_TM( 
            /* [in] */ VARIANT TM) = 0;
        
        virtual /* [helpstring][id][propget] */ HRESULT STDMETHODCALLTYPE get_c( 
            /* [retval][out] */ VARIANT *c) = 0;
        
        virtual /* [helpstring][id][propput] */ HRESULT STDMETHODCALLTYPE put_c( 
            /* [in] */ VARIANT c) = 0;
        
        virtual /* [helpstring][id][propget] */ HRESULT STDMETHODCALLTYPE get_Densityo( 
            /* [retval][out] */ VARIANT *Densityo) = 0;
        
        virtual /* [helpstring][id][propput] */ HRESULT STDMETHODCALLTYPE put_Densityo( 
            /* [in] */ VARIANT Densityo) = 0;
        
        virtual /* [helpstring][id][propget] */ HRESULT STDMETHODCALLTYPE get_HeatRatio( 
            /* [retval][out] */ VARIANT *HeatRatio) = 0;
        
        virtual /* [helpstring][id][propput] */ HRESULT STDMETHODCALLTYPE put_HeatRatio( 
            /* [in] */ VARIANT HeatRatio) = 0;
        
        virtual /* [helpstring][id][propget] */ HRESULT STDMETHODCALLTYPE get_Npr( 
            /* [retval][out] */ VARIANT *Npr) = 0;
        
        virtual /* [helpstring][id][propput] */ HRESULT STDMETHODCALLTYPE put_Npr( 
            /* [in] */ VARIANT Npr) = 0;
        
        virtual /* [helpstring][id][propget] */ HRESULT STDMETHODCALLTYPE get_ItaAir( 
            /* [retval][out] */ VARIANT *ItaAir) = 0;
        
        virtual /* [helpstring][id][propput] */ HRESULT STDMETHODCALLTYPE put_ItaAir( 
            /* [in] */ VARIANT ItaAir) = 0;
        
        virtual /* [helpstring][id][propget] */ HRESULT STDMETHODCALLTYPE get_P0( 
            /* [retval][out] */ VARIANT *P0) = 0;
        
        virtual /* [helpstring][id][propput] */ HRESULT STDMETHODCALLTYPE put_P0( 
            /* [in] */ VARIANT P0) = 0;
        
        virtual /* [helpstring][id][propget] */ HRESULT STDMETHODCALLTYPE get_Result( 
            /* [retval][out] */ VARIANT *Result) = 0;
        
        virtual /* [helpstring][id][propput] */ HRESULT STDMETHODCALLTYPE put_Result( 
            /* [in] */ VARIANT Result) = 0;
        
        virtual /* [helpstring][id][propget] */ HRESULT STDMETHODCALLTYPE get_Rigid( 
            /* [retval][out] */ VARIANT *Rigid) = 0;
        
        virtual /* [helpstring][id][propput] */ HRESULT STDMETHODCALLTYPE put_Rigid( 
            /* [in] */ VARIANT Rigid) = 0;
        
        virtual /* [helpstring][id][propget] */ HRESULT STDMETHODCALLTYPE get_Anechoic( 
            /* [retval][out] */ VARIANT *Anechoic) = 0;
        
        virtual /* [helpstring][id][propput] */ HRESULT STDMETHODCALLTYPE put_Anechoic( 
            /* [in] */ VARIANT Anechoic) = 0;
        
        virtual /* [helpstring][id][propget] */ HRESULT STDMETHODCALLTYPE get_TL( 
            /* [retval][out] */ VARIANT *TL) = 0;
        
        virtual /* [helpstring][id][propput] */ HRESULT STDMETHODCALLTYPE put_TL( 
            /* [in] */ VARIANT TL) = 0;
        
        virtual /* [helpstring][id][propget] */ HRESULT STDMETHODCALLTYPE get_TM11( 
            /* [retval][out] */ VARIANT *TM11) = 0;
        
        virtual /* [helpstring][id][propput] */ HRESULT STDMETHODCALLTYPE put_TM11( 
            /* [in] */ VARIANT TM11) = 0;
        
        virtual /* [helpstring][id][propget] */ HRESULT STDMETHODCALLTYPE get_TM12( 
            /* [retval][out] */ VARIANT *TM12) = 0;
        
        virtual /* [helpstring][id][propput] */ HRESULT STDMETHODCALLTYPE put_TM12( 
            /* [in] */ VARIANT TM12) = 0;
        
        virtual /* [helpstring][id][propget] */ HRESULT STDMETHODCALLTYPE get_TM21( 
            /* [retval][out] */ VARIANT *TM21) = 0;
        
        virtual /* [helpstring][id][propput] */ HRESULT STDMETHODCALLTYPE put_TM21( 
            /* [in] */ VARIANT TM21) = 0;
        
        virtual /* [helpstring][id][propget] */ HRESULT STDMETHODCALLTYPE get_TM22( 
            /* [retval][out] */ VARIANT *TM22) = 0;
        
        virtual /* [helpstring][id][propput] */ HRESULT STDMETHODCALLTYPE put_TM22( 
            /* [in] */ VARIANT TM22) = 0;
        
        virtual /* [helpstring][id][propget] */ HRESULT STDMETHODCALLTYPE get_Result11( 
            /* [retval][out] */ VARIANT *Result11) = 0;
        
        virtual /* [helpstring][id][propput] */ HRESULT STDMETHODCALLTYPE put_Result11( 
            /* [in] */ VARIANT Result11) = 0;
        
        virtual /* [helpstring][id][propget] */ HRESULT STDMETHODCALLTYPE get_Result12( 
            /* [retval][out] */ VARIANT *Result12) = 0;
        
        virtual /* [helpstring][id][propput] */ HRESULT STDMETHODCALLTYPE put_Result12( 
            /* [in] */ VARIANT Result12) = 0;
        
        virtual /* [helpstring][id][propget] */ HRESULT STDMETHODCALLTYPE get_Result21( 
            /* [retval][out] */ VARIANT *Result21) = 0;
        
        virtual /* [helpstring][id][propput] */ HRESULT STDMETHODCALLTYPE put_Result21( 
            /* [in] */ VARIANT Result21) = 0;
        
        virtual /* [helpstring][id][propget] */ HRESULT STDMETHODCALLTYPE get_Result22( 
            /* [retval][out] */ VARIANT *Result22) = 0;
        
        virtual /* [helpstring][id][propput] */ HRESULT STDMETHODCALLTYPE put_Result22( 
            /* [in] */ VARIANT Result22) = 0;
        
    };
    
#else 	/* C style interface */

    typedef struct ITMclassVtbl
    {
        BEGIN_INTERFACE
        
        HRESULT ( STDMETHODCALLTYPE *QueryInterface )( 
            ITMclass * This,
            /* [in] */ REFIID riid,
            /* [iid_is][out] */ void **ppvObject);
        
        ULONG ( STDMETHODCALLTYPE *AddRef )( 
            ITMclass * This);
        
        ULONG ( STDMETHODCALLTYPE *Release )( 
            ITMclass * This);
        
        HRESULT ( STDMETHODCALLTYPE *GetTypeInfoCount )( 
            ITMclass * This,
            /* [out] */ UINT *pctinfo);
        
        HRESULT ( STDMETHODCALLTYPE *GetTypeInfo )( 
            ITMclass * This,
            /* [in] */ UINT iTInfo,
            /* [in] */ LCID lcid,
            /* [out] */ ITypeInfo **ppTInfo);
        
        HRESULT ( STDMETHODCALLTYPE *GetIDsOfNames )( 
            ITMclass * This,
            /* [in] */ REFIID riid,
            /* [size_is][in] */ LPOLESTR *rgszNames,
            /* [in] */ UINT cNames,
            /* [in] */ LCID lcid,
            /* [size_is][out] */ DISPID *rgDispId);
        
        /* [local] */ HRESULT ( STDMETHODCALLTYPE *Invoke )( 
            ITMclass * This,
            /* [in] */ DISPID dispIdMember,
            /* [in] */ REFIID riid,
            /* [in] */ LCID lcid,
            /* [in] */ WORD wFlags,
            /* [out][in] */ DISPPARAMS *pDispParams,
            /* [out] */ VARIANT *pVarResult,
            /* [out] */ EXCEPINFO *pExcepInfo,
            /* [out] */ UINT *puArgErr);
        
        /* [helpstring][id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_MWFlags )( 
            ITMclass * This,
            /* [retval][out] */ IMWFlags **ppvFlags);
        
        /* [helpstring][id][propput] */ HRESULT ( STDMETHODCALLTYPE *put_MWFlags )( 
            ITMclass * This,
            /* [in] */ IMWFlags *pvFlags);
        
        /* [helpstring][id] */ HRESULT ( STDMETHODCALLTYPE *tmair )( 
            ITMclass * This,
            /* [in] */ VARIANT freq,
            /* [in] */ VARIANT theta,
            /* [in] */ VARIANT L);
        
        /* [helpstring][id] */ HRESULT ( STDMETHODCALLTYPE *tmcalc )( 
            ITMclass * This,
            /* [in] */ VARIANT freq,
            /* [in] */ VARIANT theta,
            /* [in] */ VARIANT TotalThickness);
        
        /* [helpstring][id] */ HRESULT ( STDMETHODCALLTYPE *tmcheck )( 
            ITMclass * This);
        
        /* [helpstring][id] */ HRESULT ( STDMETHODCALLTYPE *tmelastic )( 
            ITMclass * This,
            /* [in] */ VARIANT freq,
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
            /* [in] */ VARIANT PRatio);
        
        /* [helpstring][id] */ HRESULT ( STDMETHODCALLTYPE *tmelasticpanel )( 
            ITMclass * This,
            /* [in] */ VARIANT freq,
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
        
        /* [helpstring][id] */ HRESULT ( STDMETHODCALLTYPE *tmeye )( 
            ITMclass * This);
        
        /* [helpstring][id] */ HRESULT ( STDMETHODCALLTYPE *tmimpermemb )( 
            ITMclass * This,
            /* [in] */ VARIANT freq,
            /* [in] */ VARIANT theta,
            /* [in] */ VARIANT L,
            /* [in] */ VARIANT Density);
        
        /* [helpstring][id] */ HRESULT ( STDMETHODCALLTYPE *tminit )( 
            ITMclass * This);
        
        /* [helpstring][id] */ HRESULT ( STDMETHODCALLTYPE *tmlimp )( 
            ITMclass * This,
            /* [in] */ VARIANT freq,
            /* [in] */ VARIANT theta,
            /* [in] */ VARIANT L,
            /* [in] */ VARIANT BulkDensity,
            /* [in] */ VARIANT FlowRes,
            /* [in] */ VARIANT SFactor,
            /* [in] */ VARIANT h,
            /* [in] */ VARIANT VCL,
            /* [in] */ VARIANT TCL);
        
        /* [helpstring][id] */ HRESULT ( STDMETHODCALLTYPE *tmmul )( 
            ITMclass * This);
        
        /* [helpstring][id] */ HRESULT ( STDMETHODCALLTYPE *tmpanel )( 
            ITMclass * This,
            /* [in] */ VARIANT freq,
            /* [in] */ VARIANT theta,
            /* [in] */ VARIANT L,
            /* [in] */ VARIANT Density,
            /* [in] */ VARIANT Em,
            /* [in] */ VARIANT PRatio);
        
        /* [helpstring][id] */ HRESULT ( STDMETHODCALLTYPE *tmpanelelastic )( 
            ITMclass * This,
            /* [in] */ VARIANT freq,
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
        
        /* [helpstring][id] */ HRESULT ( STDMETHODCALLTYPE *tmpanelelasticpanel )( 
            ITMclass * This,
            /* [in] */ VARIANT freq,
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
        
        /* [helpstring][id] */ HRESULT ( STDMETHODCALLTYPE *tmpermemb )( 
            ITMclass * This,
            /* [in] */ VARIANT freq,
            /* [in] */ VARIANT theta,
            /* [in] */ VARIANT L,
            /* [in] */ VARIANT Density,
            /* [in] */ VARIANT FlowRes);
        
        /* [helpstring][id] */ HRESULT ( STDMETHODCALLTYPE *tmrigid )( 
            ITMclass * This,
            /* [in] */ VARIANT freq,
            /* [in] */ VARIANT theta,
            /* [in] */ VARIANT L,
            /* [in] */ VARIANT BulkDensity,
            /* [in] */ VARIANT FlowRes,
            /* [in] */ VARIANT SFactor,
            /* [in] */ VARIANT h,
            /* [in] */ VARIANT VCL,
            /* [in] */ VARIANT TCL);
        
        /* [helpstring][id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_TM )( 
            ITMclass * This,
            /* [retval][out] */ VARIANT *TM);
        
        /* [helpstring][id][propput] */ HRESULT ( STDMETHODCALLTYPE *put_TM )( 
            ITMclass * This,
            /* [in] */ VARIANT TM);
        
        /* [helpstring][id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_c )( 
            ITMclass * This,
            /* [retval][out] */ VARIANT *c);
        
        /* [helpstring][id][propput] */ HRESULT ( STDMETHODCALLTYPE *put_c )( 
            ITMclass * This,
            /* [in] */ VARIANT c);
        
        /* [helpstring][id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_Densityo )( 
            ITMclass * This,
            /* [retval][out] */ VARIANT *Densityo);
        
        /* [helpstring][id][propput] */ HRESULT ( STDMETHODCALLTYPE *put_Densityo )( 
            ITMclass * This,
            /* [in] */ VARIANT Densityo);
        
        /* [helpstring][id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_HeatRatio )( 
            ITMclass * This,
            /* [retval][out] */ VARIANT *HeatRatio);
        
        /* [helpstring][id][propput] */ HRESULT ( STDMETHODCALLTYPE *put_HeatRatio )( 
            ITMclass * This,
            /* [in] */ VARIANT HeatRatio);
        
        /* [helpstring][id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_Npr )( 
            ITMclass * This,
            /* [retval][out] */ VARIANT *Npr);
        
        /* [helpstring][id][propput] */ HRESULT ( STDMETHODCALLTYPE *put_Npr )( 
            ITMclass * This,
            /* [in] */ VARIANT Npr);
        
        /* [helpstring][id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_ItaAir )( 
            ITMclass * This,
            /* [retval][out] */ VARIANT *ItaAir);
        
        /* [helpstring][id][propput] */ HRESULT ( STDMETHODCALLTYPE *put_ItaAir )( 
            ITMclass * This,
            /* [in] */ VARIANT ItaAir);
        
        /* [helpstring][id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_P0 )( 
            ITMclass * This,
            /* [retval][out] */ VARIANT *P0);
        
        /* [helpstring][id][propput] */ HRESULT ( STDMETHODCALLTYPE *put_P0 )( 
            ITMclass * This,
            /* [in] */ VARIANT P0);
        
        /* [helpstring][id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_Result )( 
            ITMclass * This,
            /* [retval][out] */ VARIANT *Result);
        
        /* [helpstring][id][propput] */ HRESULT ( STDMETHODCALLTYPE *put_Result )( 
            ITMclass * This,
            /* [in] */ VARIANT Result);
        
        /* [helpstring][id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_Rigid )( 
            ITMclass * This,
            /* [retval][out] */ VARIANT *Rigid);
        
        /* [helpstring][id][propput] */ HRESULT ( STDMETHODCALLTYPE *put_Rigid )( 
            ITMclass * This,
            /* [in] */ VARIANT Rigid);
        
        /* [helpstring][id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_Anechoic )( 
            ITMclass * This,
            /* [retval][out] */ VARIANT *Anechoic);
        
        /* [helpstring][id][propput] */ HRESULT ( STDMETHODCALLTYPE *put_Anechoic )( 
            ITMclass * This,
            /* [in] */ VARIANT Anechoic);
        
        /* [helpstring][id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_TL )( 
            ITMclass * This,
            /* [retval][out] */ VARIANT *TL);
        
        /* [helpstring][id][propput] */ HRESULT ( STDMETHODCALLTYPE *put_TL )( 
            ITMclass * This,
            /* [in] */ VARIANT TL);
        
        /* [helpstring][id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_TM11 )( 
            ITMclass * This,
            /* [retval][out] */ VARIANT *TM11);
        
        /* [helpstring][id][propput] */ HRESULT ( STDMETHODCALLTYPE *put_TM11 )( 
            ITMclass * This,
            /* [in] */ VARIANT TM11);
        
        /* [helpstring][id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_TM12 )( 
            ITMclass * This,
            /* [retval][out] */ VARIANT *TM12);
        
        /* [helpstring][id][propput] */ HRESULT ( STDMETHODCALLTYPE *put_TM12 )( 
            ITMclass * This,
            /* [in] */ VARIANT TM12);
        
        /* [helpstring][id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_TM21 )( 
            ITMclass * This,
            /* [retval][out] */ VARIANT *TM21);
        
        /* [helpstring][id][propput] */ HRESULT ( STDMETHODCALLTYPE *put_TM21 )( 
            ITMclass * This,
            /* [in] */ VARIANT TM21);
        
        /* [helpstring][id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_TM22 )( 
            ITMclass * This,
            /* [retval][out] */ VARIANT *TM22);
        
        /* [helpstring][id][propput] */ HRESULT ( STDMETHODCALLTYPE *put_TM22 )( 
            ITMclass * This,
            /* [in] */ VARIANT TM22);
        
        /* [helpstring][id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_Result11 )( 
            ITMclass * This,
            /* [retval][out] */ VARIANT *Result11);
        
        /* [helpstring][id][propput] */ HRESULT ( STDMETHODCALLTYPE *put_Result11 )( 
            ITMclass * This,
            /* [in] */ VARIANT Result11);
        
        /* [helpstring][id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_Result12 )( 
            ITMclass * This,
            /* [retval][out] */ VARIANT *Result12);
        
        /* [helpstring][id][propput] */ HRESULT ( STDMETHODCALLTYPE *put_Result12 )( 
            ITMclass * This,
            /* [in] */ VARIANT Result12);
        
        /* [helpstring][id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_Result21 )( 
            ITMclass * This,
            /* [retval][out] */ VARIANT *Result21);
        
        /* [helpstring][id][propput] */ HRESULT ( STDMETHODCALLTYPE *put_Result21 )( 
            ITMclass * This,
            /* [in] */ VARIANT Result21);
        
        /* [helpstring][id][propget] */ HRESULT ( STDMETHODCALLTYPE *get_Result22 )( 
            ITMclass * This,
            /* [retval][out] */ VARIANT *Result22);
        
        /* [helpstring][id][propput] */ HRESULT ( STDMETHODCALLTYPE *put_Result22 )( 
            ITMclass * This,
            /* [in] */ VARIANT Result22);
        
        END_INTERFACE
    } ITMclassVtbl;

    interface ITMclass
    {
        CONST_VTBL struct ITMclassVtbl *lpVtbl;
    };

    

#ifdef COBJMACROS


#define ITMclass_QueryInterface(This,riid,ppvObject)	\
    (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)

#define ITMclass_AddRef(This)	\
    (This)->lpVtbl -> AddRef(This)

#define ITMclass_Release(This)	\
    (This)->lpVtbl -> Release(This)


#define ITMclass_GetTypeInfoCount(This,pctinfo)	\
    (This)->lpVtbl -> GetTypeInfoCount(This,pctinfo)

#define ITMclass_GetTypeInfo(This,iTInfo,lcid,ppTInfo)	\
    (This)->lpVtbl -> GetTypeInfo(This,iTInfo,lcid,ppTInfo)

#define ITMclass_GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId)	\
    (This)->lpVtbl -> GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId)

#define ITMclass_Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr)	\
    (This)->lpVtbl -> Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr)


#define ITMclass_get_MWFlags(This,ppvFlags)	\
    (This)->lpVtbl -> get_MWFlags(This,ppvFlags)

#define ITMclass_put_MWFlags(This,pvFlags)	\
    (This)->lpVtbl -> put_MWFlags(This,pvFlags)

#define ITMclass_tmair(This,freq,theta,L)	\
    (This)->lpVtbl -> tmair(This,freq,theta,L)

#define ITMclass_tmcalc(This,freq,theta,TotalThickness)	\
    (This)->lpVtbl -> tmcalc(This,freq,theta,TotalThickness)

#define ITMclass_tmcheck(This)	\
    (This)->lpVtbl -> tmcheck(This)

#define ITMclass_tmelastic(This,freq,theta,L,BulkDensity,FlowRes,SFactor,h,VCL,TCL,Em,LFactor,PRatio)	\
    (This)->lpVtbl -> tmelastic(This,freq,theta,L,BulkDensity,FlowRes,SFactor,h,VCL,TCL,Em,LFactor,PRatio)

#define ITMclass_tmelasticpanel(This,freq,theta,L,BulkDensity,FlowRes,SFactor,h,VCL,TCL,Em,PRatio,LFactor,hp,Densityp,Ep,PRatiop)	\
    (This)->lpVtbl -> tmelasticpanel(This,freq,theta,L,BulkDensity,FlowRes,SFactor,h,VCL,TCL,Em,PRatio,LFactor,hp,Densityp,Ep,PRatiop)

#define ITMclass_tmeye(This)	\
    (This)->lpVtbl -> tmeye(This)

#define ITMclass_tmimpermemb(This,freq,theta,L,Density)	\
    (This)->lpVtbl -> tmimpermemb(This,freq,theta,L,Density)

#define ITMclass_tminit(This)	\
    (This)->lpVtbl -> tminit(This)

#define ITMclass_tmlimp(This,freq,theta,L,BulkDensity,FlowRes,SFactor,h,VCL,TCL)	\
    (This)->lpVtbl -> tmlimp(This,freq,theta,L,BulkDensity,FlowRes,SFactor,h,VCL,TCL)

#define ITMclass_tmmul(This)	\
    (This)->lpVtbl -> tmmul(This)

#define ITMclass_tmpanel(This,freq,theta,L,Density,Em,PRatio)	\
    (This)->lpVtbl -> tmpanel(This,freq,theta,L,Density,Em,PRatio)

#define ITMclass_tmpanelelastic(This,freq,theta,hp,Densityp,Ep,PRatiop,L,BulkDensity,FlowRes,SFactor,h,VCL,TCL,Em,PRatio,LFactor)	\
    (This)->lpVtbl -> tmpanelelastic(This,freq,theta,hp,Densityp,Ep,PRatiop,L,BulkDensity,FlowRes,SFactor,h,VCL,TCL,Em,PRatio,LFactor)

#define ITMclass_tmpanelelasticpanel(This,freq,theta,hp1,Densityp1,Ep1,PRatiop1,L,BulkDensity,FlowRes,SFactor,h,VCL,TCL,Em,PRatio,LFactor,hp2,Densityp2,Ep2,PRatiop2)	\
    (This)->lpVtbl -> tmpanelelasticpanel(This,freq,theta,hp1,Densityp1,Ep1,PRatiop1,L,BulkDensity,FlowRes,SFactor,h,VCL,TCL,Em,PRatio,LFactor,hp2,Densityp2,Ep2,PRatiop2)

#define ITMclass_tmpermemb(This,freq,theta,L,Density,FlowRes)	\
    (This)->lpVtbl -> tmpermemb(This,freq,theta,L,Density,FlowRes)

#define ITMclass_tmrigid(This,freq,theta,L,BulkDensity,FlowRes,SFactor,h,VCL,TCL)	\
    (This)->lpVtbl -> tmrigid(This,freq,theta,L,BulkDensity,FlowRes,SFactor,h,VCL,TCL)

#define ITMclass_get_TM(This,TM)	\
    (This)->lpVtbl -> get_TM(This,TM)

#define ITMclass_put_TM(This,TM)	\
    (This)->lpVtbl -> put_TM(This,TM)

#define ITMclass_get_c(This,c)	\
    (This)->lpVtbl -> get_c(This,c)

#define ITMclass_put_c(This,c)	\
    (This)->lpVtbl -> put_c(This,c)

#define ITMclass_get_Densityo(This,Densityo)	\
    (This)->lpVtbl -> get_Densityo(This,Densityo)

#define ITMclass_put_Densityo(This,Densityo)	\
    (This)->lpVtbl -> put_Densityo(This,Densityo)

#define ITMclass_get_HeatRatio(This,HeatRatio)	\
    (This)->lpVtbl -> get_HeatRatio(This,HeatRatio)

#define ITMclass_put_HeatRatio(This,HeatRatio)	\
    (This)->lpVtbl -> put_HeatRatio(This,HeatRatio)

#define ITMclass_get_Npr(This,Npr)	\
    (This)->lpVtbl -> get_Npr(This,Npr)

#define ITMclass_put_Npr(This,Npr)	\
    (This)->lpVtbl -> put_Npr(This,Npr)

#define ITMclass_get_ItaAir(This,ItaAir)	\
    (This)->lpVtbl -> get_ItaAir(This,ItaAir)

#define ITMclass_put_ItaAir(This,ItaAir)	\
    (This)->lpVtbl -> put_ItaAir(This,ItaAir)

#define ITMclass_get_P0(This,P0)	\
    (This)->lpVtbl -> get_P0(This,P0)

#define ITMclass_put_P0(This,P0)	\
    (This)->lpVtbl -> put_P0(This,P0)

#define ITMclass_get_Result(This,Result)	\
    (This)->lpVtbl -> get_Result(This,Result)

#define ITMclass_put_Result(This,Result)	\
    (This)->lpVtbl -> put_Result(This,Result)

#define ITMclass_get_Rigid(This,Rigid)	\
    (This)->lpVtbl -> get_Rigid(This,Rigid)

#define ITMclass_put_Rigid(This,Rigid)	\
    (This)->lpVtbl -> put_Rigid(This,Rigid)

#define ITMclass_get_Anechoic(This,Anechoic)	\
    (This)->lpVtbl -> get_Anechoic(This,Anechoic)

#define ITMclass_put_Anechoic(This,Anechoic)	\
    (This)->lpVtbl -> put_Anechoic(This,Anechoic)

#define ITMclass_get_TL(This,TL)	\
    (This)->lpVtbl -> get_TL(This,TL)

#define ITMclass_put_TL(This,TL)	\
    (This)->lpVtbl -> put_TL(This,TL)

#define ITMclass_get_TM11(This,TM11)	\
    (This)->lpVtbl -> get_TM11(This,TM11)

#define ITMclass_put_TM11(This,TM11)	\
    (This)->lpVtbl -> put_TM11(This,TM11)

#define ITMclass_get_TM12(This,TM12)	\
    (This)->lpVtbl -> get_TM12(This,TM12)

#define ITMclass_put_TM12(This,TM12)	\
    (This)->lpVtbl -> put_TM12(This,TM12)

#define ITMclass_get_TM21(This,TM21)	\
    (This)->lpVtbl -> get_TM21(This,TM21)

#define ITMclass_put_TM21(This,TM21)	\
    (This)->lpVtbl -> put_TM21(This,TM21)

#define ITMclass_get_TM22(This,TM22)	\
    (This)->lpVtbl -> get_TM22(This,TM22)

#define ITMclass_put_TM22(This,TM22)	\
    (This)->lpVtbl -> put_TM22(This,TM22)

#define ITMclass_get_Result11(This,Result11)	\
    (This)->lpVtbl -> get_Result11(This,Result11)

#define ITMclass_put_Result11(This,Result11)	\
    (This)->lpVtbl -> put_Result11(This,Result11)

#define ITMclass_get_Result12(This,Result12)	\
    (This)->lpVtbl -> get_Result12(This,Result12)

#define ITMclass_put_Result12(This,Result12)	\
    (This)->lpVtbl -> put_Result12(This,Result12)

#define ITMclass_get_Result21(This,Result21)	\
    (This)->lpVtbl -> get_Result21(This,Result21)

#define ITMclass_put_Result21(This,Result21)	\
    (This)->lpVtbl -> put_Result21(This,Result21)

#define ITMclass_get_Result22(This,Result22)	\
    (This)->lpVtbl -> get_Result22(This,Result22)

#define ITMclass_put_Result22(This,Result22)	\
    (This)->lpVtbl -> put_Result22(This,Result22)

#endif /* COBJMACROS */


#endif 	/* C style interface */



/* [helpstring][id][propget] */ HRESULT STDMETHODCALLTYPE ITMclass_get_MWFlags_Proxy( 
    ITMclass * This,
    /* [retval][out] */ IMWFlags **ppvFlags);


void __RPC_STUB ITMclass_get_MWFlags_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [helpstring][id][propput] */ HRESULT STDMETHODCALLTYPE ITMclass_put_MWFlags_Proxy( 
    ITMclass * This,
    /* [in] */ IMWFlags *pvFlags);


void __RPC_STUB ITMclass_put_MWFlags_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [helpstring][id] */ HRESULT STDMETHODCALLTYPE ITMclass_tmair_Proxy( 
    ITMclass * This,
    /* [in] */ VARIANT freq,
    /* [in] */ VARIANT theta,
    /* [in] */ VARIANT L);


void __RPC_STUB ITMclass_tmair_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [helpstring][id] */ HRESULT STDMETHODCALLTYPE ITMclass_tmcalc_Proxy( 
    ITMclass * This,
    /* [in] */ VARIANT freq,
    /* [in] */ VARIANT theta,
    /* [in] */ VARIANT TotalThickness);


void __RPC_STUB ITMclass_tmcalc_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [helpstring][id] */ HRESULT STDMETHODCALLTYPE ITMclass_tmcheck_Proxy( 
    ITMclass * This);


void __RPC_STUB ITMclass_tmcheck_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [helpstring][id] */ HRESULT STDMETHODCALLTYPE ITMclass_tmelastic_Proxy( 
    ITMclass * This,
    /* [in] */ VARIANT freq,
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
    /* [in] */ VARIANT PRatio);


void __RPC_STUB ITMclass_tmelastic_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [helpstring][id] */ HRESULT STDMETHODCALLTYPE ITMclass_tmelasticpanel_Proxy( 
    ITMclass * This,
    /* [in] */ VARIANT freq,
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


void __RPC_STUB ITMclass_tmelasticpanel_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [helpstring][id] */ HRESULT STDMETHODCALLTYPE ITMclass_tmeye_Proxy( 
    ITMclass * This);


void __RPC_STUB ITMclass_tmeye_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [helpstring][id] */ HRESULT STDMETHODCALLTYPE ITMclass_tmimpermemb_Proxy( 
    ITMclass * This,
    /* [in] */ VARIANT freq,
    /* [in] */ VARIANT theta,
    /* [in] */ VARIANT L,
    /* [in] */ VARIANT Density);


void __RPC_STUB ITMclass_tmimpermemb_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [helpstring][id] */ HRESULT STDMETHODCALLTYPE ITMclass_tminit_Proxy( 
    ITMclass * This);


void __RPC_STUB ITMclass_tminit_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [helpstring][id] */ HRESULT STDMETHODCALLTYPE ITMclass_tmlimp_Proxy( 
    ITMclass * This,
    /* [in] */ VARIANT freq,
    /* [in] */ VARIANT theta,
    /* [in] */ VARIANT L,
    /* [in] */ VARIANT BulkDensity,
    /* [in] */ VARIANT FlowRes,
    /* [in] */ VARIANT SFactor,
    /* [in] */ VARIANT h,
    /* [in] */ VARIANT VCL,
    /* [in] */ VARIANT TCL);


void __RPC_STUB ITMclass_tmlimp_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [helpstring][id] */ HRESULT STDMETHODCALLTYPE ITMclass_tmmul_Proxy( 
    ITMclass * This);


void __RPC_STUB ITMclass_tmmul_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [helpstring][id] */ HRESULT STDMETHODCALLTYPE ITMclass_tmpanel_Proxy( 
    ITMclass * This,
    /* [in] */ VARIANT freq,
    /* [in] */ VARIANT theta,
    /* [in] */ VARIANT L,
    /* [in] */ VARIANT Density,
    /* [in] */ VARIANT Em,
    /* [in] */ VARIANT PRatio);


void __RPC_STUB ITMclass_tmpanel_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [helpstring][id] */ HRESULT STDMETHODCALLTYPE ITMclass_tmpanelelastic_Proxy( 
    ITMclass * This,
    /* [in] */ VARIANT freq,
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


void __RPC_STUB ITMclass_tmpanelelastic_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [helpstring][id] */ HRESULT STDMETHODCALLTYPE ITMclass_tmpanelelasticpanel_Proxy( 
    ITMclass * This,
    /* [in] */ VARIANT freq,
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


void __RPC_STUB ITMclass_tmpanelelasticpanel_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [helpstring][id] */ HRESULT STDMETHODCALLTYPE ITMclass_tmpermemb_Proxy( 
    ITMclass * This,
    /* [in] */ VARIANT freq,
    /* [in] */ VARIANT theta,
    /* [in] */ VARIANT L,
    /* [in] */ VARIANT Density,
    /* [in] */ VARIANT FlowRes);


void __RPC_STUB ITMclass_tmpermemb_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [helpstring][id] */ HRESULT STDMETHODCALLTYPE ITMclass_tmrigid_Proxy( 
    ITMclass * This,
    /* [in] */ VARIANT freq,
    /* [in] */ VARIANT theta,
    /* [in] */ VARIANT L,
    /* [in] */ VARIANT BulkDensity,
    /* [in] */ VARIANT FlowRes,
    /* [in] */ VARIANT SFactor,
    /* [in] */ VARIANT h,
    /* [in] */ VARIANT VCL,
    /* [in] */ VARIANT TCL);


void __RPC_STUB ITMclass_tmrigid_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [helpstring][id][propget] */ HRESULT STDMETHODCALLTYPE ITMclass_get_TM_Proxy( 
    ITMclass * This,
    /* [retval][out] */ VARIANT *TM);


void __RPC_STUB ITMclass_get_TM_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [helpstring][id][propput] */ HRESULT STDMETHODCALLTYPE ITMclass_put_TM_Proxy( 
    ITMclass * This,
    /* [in] */ VARIANT TM);


void __RPC_STUB ITMclass_put_TM_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [helpstring][id][propget] */ HRESULT STDMETHODCALLTYPE ITMclass_get_c_Proxy( 
    ITMclass * This,
    /* [retval][out] */ VARIANT *c);


void __RPC_STUB ITMclass_get_c_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [helpstring][id][propput] */ HRESULT STDMETHODCALLTYPE ITMclass_put_c_Proxy( 
    ITMclass * This,
    /* [in] */ VARIANT c);


void __RPC_STUB ITMclass_put_c_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [helpstring][id][propget] */ HRESULT STDMETHODCALLTYPE ITMclass_get_Densityo_Proxy( 
    ITMclass * This,
    /* [retval][out] */ VARIANT *Densityo);


void __RPC_STUB ITMclass_get_Densityo_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [helpstring][id][propput] */ HRESULT STDMETHODCALLTYPE ITMclass_put_Densityo_Proxy( 
    ITMclass * This,
    /* [in] */ VARIANT Densityo);


void __RPC_STUB ITMclass_put_Densityo_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [helpstring][id][propget] */ HRESULT STDMETHODCALLTYPE ITMclass_get_HeatRatio_Proxy( 
    ITMclass * This,
    /* [retval][out] */ VARIANT *HeatRatio);


void __RPC_STUB ITMclass_get_HeatRatio_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [helpstring][id][propput] */ HRESULT STDMETHODCALLTYPE ITMclass_put_HeatRatio_Proxy( 
    ITMclass * This,
    /* [in] */ VARIANT HeatRatio);


void __RPC_STUB ITMclass_put_HeatRatio_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [helpstring][id][propget] */ HRESULT STDMETHODCALLTYPE ITMclass_get_Npr_Proxy( 
    ITMclass * This,
    /* [retval][out] */ VARIANT *Npr);


void __RPC_STUB ITMclass_get_Npr_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [helpstring][id][propput] */ HRESULT STDMETHODCALLTYPE ITMclass_put_Npr_Proxy( 
    ITMclass * This,
    /* [in] */ VARIANT Npr);


void __RPC_STUB ITMclass_put_Npr_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [helpstring][id][propget] */ HRESULT STDMETHODCALLTYPE ITMclass_get_ItaAir_Proxy( 
    ITMclass * This,
    /* [retval][out] */ VARIANT *ItaAir);


void __RPC_STUB ITMclass_get_ItaAir_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [helpstring][id][propput] */ HRESULT STDMETHODCALLTYPE ITMclass_put_ItaAir_Proxy( 
    ITMclass * This,
    /* [in] */ VARIANT ItaAir);


void __RPC_STUB ITMclass_put_ItaAir_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [helpstring][id][propget] */ HRESULT STDMETHODCALLTYPE ITMclass_get_P0_Proxy( 
    ITMclass * This,
    /* [retval][out] */ VARIANT *P0);


void __RPC_STUB ITMclass_get_P0_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [helpstring][id][propput] */ HRESULT STDMETHODCALLTYPE ITMclass_put_P0_Proxy( 
    ITMclass * This,
    /* [in] */ VARIANT P0);


void __RPC_STUB ITMclass_put_P0_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [helpstring][id][propget] */ HRESULT STDMETHODCALLTYPE ITMclass_get_Result_Proxy( 
    ITMclass * This,
    /* [retval][out] */ VARIANT *Result);


void __RPC_STUB ITMclass_get_Result_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [helpstring][id][propput] */ HRESULT STDMETHODCALLTYPE ITMclass_put_Result_Proxy( 
    ITMclass * This,
    /* [in] */ VARIANT Result);


void __RPC_STUB ITMclass_put_Result_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [helpstring][id][propget] */ HRESULT STDMETHODCALLTYPE ITMclass_get_Rigid_Proxy( 
    ITMclass * This,
    /* [retval][out] */ VARIANT *Rigid);


void __RPC_STUB ITMclass_get_Rigid_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [helpstring][id][propput] */ HRESULT STDMETHODCALLTYPE ITMclass_put_Rigid_Proxy( 
    ITMclass * This,
    /* [in] */ VARIANT Rigid);


void __RPC_STUB ITMclass_put_Rigid_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [helpstring][id][propget] */ HRESULT STDMETHODCALLTYPE ITMclass_get_Anechoic_Proxy( 
    ITMclass * This,
    /* [retval][out] */ VARIANT *Anechoic);


void __RPC_STUB ITMclass_get_Anechoic_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [helpstring][id][propput] */ HRESULT STDMETHODCALLTYPE ITMclass_put_Anechoic_Proxy( 
    ITMclass * This,
    /* [in] */ VARIANT Anechoic);


void __RPC_STUB ITMclass_put_Anechoic_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [helpstring][id][propget] */ HRESULT STDMETHODCALLTYPE ITMclass_get_TL_Proxy( 
    ITMclass * This,
    /* [retval][out] */ VARIANT *TL);


void __RPC_STUB ITMclass_get_TL_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [helpstring][id][propput] */ HRESULT STDMETHODCALLTYPE ITMclass_put_TL_Proxy( 
    ITMclass * This,
    /* [in] */ VARIANT TL);


void __RPC_STUB ITMclass_put_TL_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [helpstring][id][propget] */ HRESULT STDMETHODCALLTYPE ITMclass_get_TM11_Proxy( 
    ITMclass * This,
    /* [retval][out] */ VARIANT *TM11);


void __RPC_STUB ITMclass_get_TM11_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [helpstring][id][propput] */ HRESULT STDMETHODCALLTYPE ITMclass_put_TM11_Proxy( 
    ITMclass * This,
    /* [in] */ VARIANT TM11);


void __RPC_STUB ITMclass_put_TM11_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [helpstring][id][propget] */ HRESULT STDMETHODCALLTYPE ITMclass_get_TM12_Proxy( 
    ITMclass * This,
    /* [retval][out] */ VARIANT *TM12);


void __RPC_STUB ITMclass_get_TM12_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [helpstring][id][propput] */ HRESULT STDMETHODCALLTYPE ITMclass_put_TM12_Proxy( 
    ITMclass * This,
    /* [in] */ VARIANT TM12);


void __RPC_STUB ITMclass_put_TM12_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [helpstring][id][propget] */ HRESULT STDMETHODCALLTYPE ITMclass_get_TM21_Proxy( 
    ITMclass * This,
    /* [retval][out] */ VARIANT *TM21);


void __RPC_STUB ITMclass_get_TM21_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [helpstring][id][propput] */ HRESULT STDMETHODCALLTYPE ITMclass_put_TM21_Proxy( 
    ITMclass * This,
    /* [in] */ VARIANT TM21);


void __RPC_STUB ITMclass_put_TM21_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [helpstring][id][propget] */ HRESULT STDMETHODCALLTYPE ITMclass_get_TM22_Proxy( 
    ITMclass * This,
    /* [retval][out] */ VARIANT *TM22);


void __RPC_STUB ITMclass_get_TM22_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [helpstring][id][propput] */ HRESULT STDMETHODCALLTYPE ITMclass_put_TM22_Proxy( 
    ITMclass * This,
    /* [in] */ VARIANT TM22);


void __RPC_STUB ITMclass_put_TM22_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [helpstring][id][propget] */ HRESULT STDMETHODCALLTYPE ITMclass_get_Result11_Proxy( 
    ITMclass * This,
    /* [retval][out] */ VARIANT *Result11);


void __RPC_STUB ITMclass_get_Result11_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [helpstring][id][propput] */ HRESULT STDMETHODCALLTYPE ITMclass_put_Result11_Proxy( 
    ITMclass * This,
    /* [in] */ VARIANT Result11);


void __RPC_STUB ITMclass_put_Result11_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [helpstring][id][propget] */ HRESULT STDMETHODCALLTYPE ITMclass_get_Result12_Proxy( 
    ITMclass * This,
    /* [retval][out] */ VARIANT *Result12);


void __RPC_STUB ITMclass_get_Result12_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [helpstring][id][propput] */ HRESULT STDMETHODCALLTYPE ITMclass_put_Result12_Proxy( 
    ITMclass * This,
    /* [in] */ VARIANT Result12);


void __RPC_STUB ITMclass_put_Result12_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [helpstring][id][propget] */ HRESULT STDMETHODCALLTYPE ITMclass_get_Result21_Proxy( 
    ITMclass * This,
    /* [retval][out] */ VARIANT *Result21);


void __RPC_STUB ITMclass_get_Result21_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [helpstring][id][propput] */ HRESULT STDMETHODCALLTYPE ITMclass_put_Result21_Proxy( 
    ITMclass * This,
    /* [in] */ VARIANT Result21);


void __RPC_STUB ITMclass_put_Result21_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [helpstring][id][propget] */ HRESULT STDMETHODCALLTYPE ITMclass_get_Result22_Proxy( 
    ITMclass * This,
    /* [retval][out] */ VARIANT *Result22);


void __RPC_STUB ITMclass_get_Result22_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [helpstring][id][propput] */ HRESULT STDMETHODCALLTYPE ITMclass_put_Result22_Proxy( 
    ITMclass * This,
    /* [in] */ VARIANT Result22);


void __RPC_STUB ITMclass_put_Result22_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);



#endif 	/* __ITMclass_INTERFACE_DEFINED__ */



#ifndef __TM_LIBRARY_DEFINED__
#define __TM_LIBRARY_DEFINED__

/* library TM */
/* [helpstring][version][uuid] */ 


EXTERN_C const IID LIBID_TM;

EXTERN_C const CLSID CLSID_TMclass;

#ifdef __cplusplus

class DECLSPEC_UUID("21B24D28-FD47-4A40-84DB-A3C0729DA73A")
TMclass;
#endif
#endif /* __TM_LIBRARY_DEFINED__ */

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


