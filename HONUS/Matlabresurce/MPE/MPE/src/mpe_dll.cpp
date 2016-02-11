#include "mwcomtypes.h"
#include "mclcommain.h"
#include "mpeclass_com.hpp"
#include "mpe_idl_i.c"
#include "mwcomutil_i.c"
#include "mwcomtypes_i.c"



#ifdef __cplusplus
extern "C" {
#endif
extern const unsigned char __MCC_MPE_public_data[];
extern const char *__MCC_MPE_name_data;
extern const char *__MCC_MPE_root_data;
extern const unsigned char __MCC_MPE_session_data[];
extern const char *__MCC_MPE_matlabpath_data[];
extern const int __MCC_MPE_matlabpath_data_count;
extern const char *__MCC_MPE_classpath_data[];
extern const int __MCC_MPE_classpath_data_count;
extern const char *__MCC_MPE_mcr_runtime_options[];
extern const int __MCC_MPE_mcr_runtime_option_count;
extern const char *__MCC_MPE_mcr_application_options[];
extern const int __MCC_MPE_mcr_application_option_count;
#ifdef __cplusplus
}
#endif


static bool _mcr_initialize_fcn(HMCRINSTANCE* inst, const char* path_to_component)
{
    return mclInitializeComponentInstance(inst, __MCC_MPE_public_data,
                                          __MCC_MPE_name_data,
                                          __MCC_MPE_root_data,
                                          __MCC_MPE_session_data,
                                          __MCC_MPE_matlabpath_data,
                                          __MCC_MPE_matlabpath_data_count,
                                          __MCC_MPE_classpath_data,
                                          __MCC_MPE_classpath_data_count,
                                          __MCC_MPE_mcr_runtime_options,
                                          __MCC_MPE_mcr_runtime_option_count,
                                          true, COMObject, LibTarget,
                                          path_to_component, NULL, NULL);
}
static bool _mcr_terminate_fcn(HMCRINSTANCE* inst)
{
    return mclTerminateInstance(inst);
}
static CMCLModule g_Module(_mcr_initialize_fcn, _mcr_terminate_fcn);
CMCLModule* g_pModule = &g_Module;

static _MCLOBJECT_MAP_ENTRY objectmap[] = 
{
    {
        &CLSID_MPEclass, CMPEclass::RegisterClass,
        CMPEclass::UnregisterClass, CMPEclass::GetClassObject,
        "MPEclass", "MPE.MPEclass", "MPE.MPEclass.1_0"
    },
    {
        NULL, NULL, NULL, NULL, "", "", ""
    }
};

extern "C" { 

BOOL WINAPI DllMain( HINSTANCE hInstance, DWORD dwReason, void *pv )
{
    return g_pModule->InitMain(objectmap, &LIBID_MPE, 1, 0,
                               hInstance, dwReason, pv);
}

HRESULT __stdcall DllCanUnloadNow()
{
    return (g_pModule->GetLockCount()==0) ? S_OK : S_FALSE;
}

HRESULT __stdcall DllGetClassObject(REFCLSID clsid, REFIID iid, void **ppv )
{
    return g_pModule->GetClassObject( clsid, iid, ppv );
}

HRESULT __stdcall DllRegisterServer()
{
    return g_pModule->UpdateRegistry( TRUE );
}

HRESULT __stdcall DllUnregisterServer()
{
    return g_pModule->UpdateRegistry( FALSE );
}

}

