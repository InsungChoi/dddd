echo off
echo Deploying project TM, version 1_0
echo Running MCRInstaller if present...
MCRInstaller.exe
echo Registering DLL's
set path=%path%;.\MATLAB Component Runtime\v70\runtime\win32
regsvr32 TM_1_0.dll
echo Installation complete.
echo Please refer to documentation for any additional setup steps.