/*
* MATLAB Compiler: 4.18.1 (R2013a)
* Date: Wed Mar 02 13:18:04 2016
* Arguments: "-B" "macro_default" "-W" "dotnet:MPE,MPEclassClass,0.0,private" "-T"
* "link:lib" "-d" "D:\Project\HONUS\Matlabresurce\MPE\MPE\src" "-w"
* "enable:specified_file_mismatch" "-w" "enable:repeated_file" "-w"
* "enable:switch_ignored" "-w" "enable:missing_lib_sentinel" "-w" "enable:demo_license"
* "-v"
* "class{MPEclassClass:D:\Project\HONUS\Matlabresurce\MPE\APFibrous5para.m,D:\Project\HONU
* S\Matlabresurce\MPE\ElasticMeritCalc.m,D:\Project\HONUS\Matlabresurce\MPE\FuncTest.m,D:\
* Project\HONUS\Matlabresurce\MPE\MeritCalc.m,D:\Project\HONUS\Matlabresurce\MPE\PEElastic
* Solid.m,D:\Project\HONUS\Matlabresurce\MPE\PolyFitting.m}" 
*/
using System;
using System.Reflection;
using System.IO;
using MathWorks.MATLAB.NET.Arrays;
using MathWorks.MATLAB.NET.Utility;

#if SHARED
[assembly: System.Reflection.AssemblyKeyFile(@"")]
#endif

namespace MPE
{

  /// <summary>
  /// The MPEclassClass class provides a CLS compliant, MWArray interface to the MATLAB
  /// functions contained in the files:
  /// <newpara></newpara>
  /// D:\Project\HONUS\Matlabresurce\MPE\APFibrous5para.m
  /// <newpara></newpara>
  /// D:\Project\HONUS\Matlabresurce\MPE\ElasticMeritCalc.m
  /// <newpara></newpara>
  /// D:\Project\HONUS\Matlabresurce\MPE\FuncTest.m
  /// <newpara></newpara>
  /// D:\Project\HONUS\Matlabresurce\MPE\MeritCalc.m
  /// <newpara></newpara>
  /// D:\Project\HONUS\Matlabresurce\MPE\PEElasticSolid.m
  /// <newpara></newpara>
  /// D:\Project\HONUS\Matlabresurce\MPE\PolyFitting.m
  /// <newpara></newpara>
  /// deployprint.m
  /// <newpara></newpara>
  /// printdlg.m
  /// </summary>
  /// <remarks>
  /// @Version 0.0
  /// </remarks>
  public class MPEclassClass : IDisposable
  {
    #region Constructors

    /// <summary internal= "true">
    /// The static constructor instantiates and initializes the MATLAB Compiler Runtime
    /// instance.
    /// </summary>
    static MPEclassClass()
    {
      if (MWMCR.MCRAppInitialized)
      {
        try
        {
          Assembly assembly= Assembly.GetExecutingAssembly();

          string ctfFilePath= assembly.Location;

          int lastDelimiter= ctfFilePath.LastIndexOf(@"\");

          ctfFilePath= ctfFilePath.Remove(lastDelimiter, (ctfFilePath.Length - lastDelimiter));

          string ctfFileName = "MPE.ctf";

          Stream embeddedCtfStream = null;

          String[] resourceStrings = assembly.GetManifestResourceNames();

          foreach (String name in resourceStrings)
          {
            if (name.Contains(ctfFileName))
            {
              embeddedCtfStream = assembly.GetManifestResourceStream(name);
              break;
            }
          }
          mcr= new MWMCR("",
                         ctfFilePath, embeddedCtfStream, true);
        }
        catch(Exception ex)
        {
          ex_ = new Exception("MWArray assembly failed to be initialized", ex);
        }
      }
      else
      {
        ex_ = new ApplicationException("MWArray assembly could not be initialized");
      }
    }


    /// <summary>
    /// Constructs a new instance of the MPEclassClass class.
    /// </summary>
    public MPEclassClass()
    {
      if(ex_ != null)
      {
        throw ex_;
      }
    }


    #endregion Constructors

    #region Finalize

    /// <summary internal= "true">
    /// Class destructor called by the CLR garbage collector.
    /// </summary>
    ~MPEclassClass()
    {
      Dispose(false);
    }


    /// <summary>
    /// Frees the native resources associated with this object
    /// </summary>
    public void Dispose()
    {
      Dispose(true);

      GC.SuppressFinalize(this);
    }


    /// <summary internal= "true">
    /// Internal dispose function
    /// </summary>
    protected virtual void Dispose(bool disposing)
    {
      if (!disposed)
      {
        disposed= true;

        if (disposing)
        {
          // Free managed resources;
        }

        // Free native resources
      }
    }


    #endregion Finalize

    #region Methods

    /// <summary>
    /// Provides a single output, 0-input MWArrayinterface to the APFibrous5para MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray APFibrous5para()
    {
      return mcr.EvaluateFunction("APFibrous5para", new MWArray[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input MWArrayinterface to the APFibrous5para MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="B">Input argument #1</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray APFibrous5para(MWArray B)
    {
      return mcr.EvaluateFunction("APFibrous5para", B);
    }


    /// <summary>
    /// Provides a single output, 2-input MWArrayinterface to the APFibrous5para MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="B">Input argument #1</param>
    /// <param name="c1">Input argument #2</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray APFibrous5para(MWArray B, MWArray c1)
    {
      return mcr.EvaluateFunction("APFibrous5para", B, c1);
    }


    /// <summary>
    /// Provides a single output, 3-input MWArrayinterface to the APFibrous5para MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="B">Input argument #1</param>
    /// <param name="c1">Input argument #2</param>
    /// <param name="c2">Input argument #3</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray APFibrous5para(MWArray B, MWArray c1, MWArray c2)
    {
      return mcr.EvaluateFunction("APFibrous5para", B, c1, c2);
    }


    /// <summary>
    /// Provides a single output, 4-input MWArrayinterface to the APFibrous5para MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="B">Input argument #1</param>
    /// <param name="c1">Input argument #2</param>
    /// <param name="c2">Input argument #3</param>
    /// <param name="Density1">Input argument #4</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray APFibrous5para(MWArray B, MWArray c1, MWArray c2, MWArray Density1)
    {
      return mcr.EvaluateFunction("APFibrous5para", B, c1, c2, Density1);
    }


    /// <summary>
    /// Provides a single output, 5-input MWArrayinterface to the APFibrous5para MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="B">Input argument #1</param>
    /// <param name="c1">Input argument #2</param>
    /// <param name="c2">Input argument #3</param>
    /// <param name="Density1">Input argument #4</param>
    /// <param name="Densityo">Input argument #5</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray APFibrous5para(MWArray B, MWArray c1, MWArray c2, MWArray Density1, 
                            MWArray Densityo)
    {
      return mcr.EvaluateFunction("APFibrous5para", B, c1, c2, Density1, Densityo);
    }


    /// <summary>
    /// Provides a single output, 6-input MWArrayinterface to the APFibrous5para MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="B">Input argument #1</param>
    /// <param name="c1">Input argument #2</param>
    /// <param name="c2">Input argument #3</param>
    /// <param name="Density1">Input argument #4</param>
    /// <param name="Densityo">Input argument #5</param>
    /// <param name="FlowRes">Input argument #6</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray APFibrous5para(MWArray B, MWArray c1, MWArray c2, MWArray Density1, 
                            MWArray Densityo, MWArray FlowRes)
    {
      return mcr.EvaluateFunction("APFibrous5para", B, c1, c2, Density1, Densityo, FlowRes);
    }


    /// <summary>
    /// Provides a single output, 7-input MWArrayinterface to the APFibrous5para MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="B">Input argument #1</param>
    /// <param name="c1">Input argument #2</param>
    /// <param name="c2">Input argument #3</param>
    /// <param name="Density1">Input argument #4</param>
    /// <param name="Densityo">Input argument #5</param>
    /// <param name="FlowRes">Input argument #6</param>
    /// <param name="fre">Input argument #7</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray APFibrous5para(MWArray B, MWArray c1, MWArray c2, MWArray Density1, 
                            MWArray Densityo, MWArray FlowRes, MWArray fre)
    {
      return mcr.EvaluateFunction("APFibrous5para", B, c1, c2, Density1, Densityo, FlowRes, fre);
    }


    /// <summary>
    /// Provides a single output, 8-input MWArrayinterface to the APFibrous5para MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="B">Input argument #1</param>
    /// <param name="c1">Input argument #2</param>
    /// <param name="c2">Input argument #3</param>
    /// <param name="Density1">Input argument #4</param>
    /// <param name="Densityo">Input argument #5</param>
    /// <param name="FlowRes">Input argument #6</param>
    /// <param name="fre">Input argument #7</param>
    /// <param name="h">Input argument #8</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray APFibrous5para(MWArray B, MWArray c1, MWArray c2, MWArray Density1, 
                            MWArray Densityo, MWArray FlowRes, MWArray fre, MWArray h)
    {
      return mcr.EvaluateFunction("APFibrous5para", B, c1, c2, Density1, Densityo, FlowRes, fre, h);
    }


    /// <summary>
    /// Provides a single output, 9-input MWArrayinterface to the APFibrous5para MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="B">Input argument #1</param>
    /// <param name="c1">Input argument #2</param>
    /// <param name="c2">Input argument #3</param>
    /// <param name="Density1">Input argument #4</param>
    /// <param name="Densityo">Input argument #5</param>
    /// <param name="FlowRes">Input argument #6</param>
    /// <param name="fre">Input argument #7</param>
    /// <param name="h">Input argument #8</param>
    /// <param name="HeatRatio">Input argument #9</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray APFibrous5para(MWArray B, MWArray c1, MWArray c2, MWArray Density1, 
                            MWArray Densityo, MWArray FlowRes, MWArray fre, MWArray h, 
                            MWArray HeatRatio)
    {
      return mcr.EvaluateFunction("APFibrous5para", B, c1, c2, Density1, Densityo, FlowRes, fre, h, HeatRatio);
    }


    /// <summary>
    /// Provides a single output, 10-input MWArrayinterface to the APFibrous5para MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="B">Input argument #1</param>
    /// <param name="c1">Input argument #2</param>
    /// <param name="c2">Input argument #3</param>
    /// <param name="Density1">Input argument #4</param>
    /// <param name="Densityo">Input argument #5</param>
    /// <param name="FlowRes">Input argument #6</param>
    /// <param name="fre">Input argument #7</param>
    /// <param name="h">Input argument #8</param>
    /// <param name="HeatRatio">Input argument #9</param>
    /// <param name="ItaAir">Input argument #10</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray APFibrous5para(MWArray B, MWArray c1, MWArray c2, MWArray Density1, 
                            MWArray Densityo, MWArray FlowRes, MWArray fre, MWArray h, 
                            MWArray HeatRatio, MWArray ItaAir)
    {
      return mcr.EvaluateFunction("APFibrous5para", B, c1, c2, Density1, Densityo, FlowRes, fre, h, HeatRatio, ItaAir);
    }


    /// <summary>
    /// Provides a single output, 11-input MWArrayinterface to the APFibrous5para MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="B">Input argument #1</param>
    /// <param name="c1">Input argument #2</param>
    /// <param name="c2">Input argument #3</param>
    /// <param name="Density1">Input argument #4</param>
    /// <param name="Densityo">Input argument #5</param>
    /// <param name="FlowRes">Input argument #6</param>
    /// <param name="fre">Input argument #7</param>
    /// <param name="h">Input argument #8</param>
    /// <param name="HeatRatio">Input argument #9</param>
    /// <param name="ItaAir">Input argument #10</param>
    /// <param name="L">Input argument #11</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray APFibrous5para(MWArray B, MWArray c1, MWArray c2, MWArray Density1, 
                            MWArray Densityo, MWArray FlowRes, MWArray fre, MWArray h, 
                            MWArray HeatRatio, MWArray ItaAir, MWArray L)
    {
      return mcr.EvaluateFunction("APFibrous5para", B, c1, c2, Density1, Densityo, FlowRes, fre, h, HeatRatio, ItaAir, L);
    }


    /// <summary>
    /// Provides a single output, 12-input MWArrayinterface to the APFibrous5para MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="B">Input argument #1</param>
    /// <param name="c1">Input argument #2</param>
    /// <param name="c2">Input argument #3</param>
    /// <param name="Density1">Input argument #4</param>
    /// <param name="Densityo">Input argument #5</param>
    /// <param name="FlowRes">Input argument #6</param>
    /// <param name="fre">Input argument #7</param>
    /// <param name="h">Input argument #8</param>
    /// <param name="HeatRatio">Input argument #9</param>
    /// <param name="ItaAir">Input argument #10</param>
    /// <param name="L">Input argument #11</param>
    /// <param name="Npr">Input argument #12</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray APFibrous5para(MWArray B, MWArray c1, MWArray c2, MWArray Density1, 
                            MWArray Densityo, MWArray FlowRes, MWArray fre, MWArray h, 
                            MWArray HeatRatio, MWArray ItaAir, MWArray L, MWArray Npr)
    {
      return mcr.EvaluateFunction("APFibrous5para", B, c1, c2, Density1, Densityo, FlowRes, fre, h, HeatRatio, ItaAir, L, Npr);
    }


    /// <summary>
    /// Provides a single output, 13-input MWArrayinterface to the APFibrous5para MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="B">Input argument #1</param>
    /// <param name="c1">Input argument #2</param>
    /// <param name="c2">Input argument #3</param>
    /// <param name="Density1">Input argument #4</param>
    /// <param name="Densityo">Input argument #5</param>
    /// <param name="FlowRes">Input argument #6</param>
    /// <param name="fre">Input argument #7</param>
    /// <param name="h">Input argument #8</param>
    /// <param name="HeatRatio">Input argument #9</param>
    /// <param name="ItaAir">Input argument #10</param>
    /// <param name="L">Input argument #11</param>
    /// <param name="Npr">Input argument #12</param>
    /// <param name="P0">Input argument #13</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray APFibrous5para(MWArray B, MWArray c1, MWArray c2, MWArray Density1, 
                            MWArray Densityo, MWArray FlowRes, MWArray fre, MWArray h, 
                            MWArray HeatRatio, MWArray ItaAir, MWArray L, MWArray Npr, 
                            MWArray P0)
    {
      return mcr.EvaluateFunction("APFibrous5para", B, c1, c2, Density1, Densityo, FlowRes, fre, h, HeatRatio, ItaAir, L, Npr, P0);
    }


    /// <summary>
    /// Provides a single output, 14-input MWArrayinterface to the APFibrous5para MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="B">Input argument #1</param>
    /// <param name="c1">Input argument #2</param>
    /// <param name="c2">Input argument #3</param>
    /// <param name="Density1">Input argument #4</param>
    /// <param name="Densityo">Input argument #5</param>
    /// <param name="FlowRes">Input argument #6</param>
    /// <param name="fre">Input argument #7</param>
    /// <param name="h">Input argument #8</param>
    /// <param name="HeatRatio">Input argument #9</param>
    /// <param name="ItaAir">Input argument #10</param>
    /// <param name="L">Input argument #11</param>
    /// <param name="Npr">Input argument #12</param>
    /// <param name="P0">Input argument #13</param>
    /// <param name="SFactor">Input argument #14</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray APFibrous5para(MWArray B, MWArray c1, MWArray c2, MWArray Density1, 
                            MWArray Densityo, MWArray FlowRes, MWArray fre, MWArray h, 
                            MWArray HeatRatio, MWArray ItaAir, MWArray L, MWArray Npr, 
                            MWArray P0, MWArray SFactor)
    {
      return mcr.EvaluateFunction("APFibrous5para", B, c1, c2, Density1, Densityo, FlowRes, fre, h, HeatRatio, ItaAir, L, Npr, P0, SFactor);
    }


    /// <summary>
    /// Provides a single output, 15-input MWArrayinterface to the APFibrous5para MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="B">Input argument #1</param>
    /// <param name="c1">Input argument #2</param>
    /// <param name="c2">Input argument #3</param>
    /// <param name="Density1">Input argument #4</param>
    /// <param name="Densityo">Input argument #5</param>
    /// <param name="FlowRes">Input argument #6</param>
    /// <param name="fre">Input argument #7</param>
    /// <param name="h">Input argument #8</param>
    /// <param name="HeatRatio">Input argument #9</param>
    /// <param name="ItaAir">Input argument #10</param>
    /// <param name="L">Input argument #11</param>
    /// <param name="Npr">Input argument #12</param>
    /// <param name="P0">Input argument #13</param>
    /// <param name="SFactor">Input argument #14</param>
    /// <param name="Z0">Input argument #15</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray APFibrous5para(MWArray B, MWArray c1, MWArray c2, MWArray Density1, 
                            MWArray Densityo, MWArray FlowRes, MWArray fre, MWArray h, 
                            MWArray HeatRatio, MWArray ItaAir, MWArray L, MWArray Npr, 
                            MWArray P0, MWArray SFactor, MWArray Z0)
    {
      return mcr.EvaluateFunction("APFibrous5para", B, c1, c2, Density1, Densityo, FlowRes, fre, h, HeatRatio, ItaAir, L, Npr, P0, SFactor, Z0);
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the APFibrous5para MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] APFibrous5para(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "APFibrous5para", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 1-input MWArray interface to the APFibrous5para MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="B">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] APFibrous5para(int numArgsOut, MWArray B)
    {
      return mcr.EvaluateFunction(numArgsOut, "APFibrous5para", B);
    }


    /// <summary>
    /// Provides the standard 2-input MWArray interface to the APFibrous5para MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="B">Input argument #1</param>
    /// <param name="c1">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] APFibrous5para(int numArgsOut, MWArray B, MWArray c1)
    {
      return mcr.EvaluateFunction(numArgsOut, "APFibrous5para", B, c1);
    }


    /// <summary>
    /// Provides the standard 3-input MWArray interface to the APFibrous5para MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="B">Input argument #1</param>
    /// <param name="c1">Input argument #2</param>
    /// <param name="c2">Input argument #3</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] APFibrous5para(int numArgsOut, MWArray B, MWArray c1, MWArray c2)
    {
      return mcr.EvaluateFunction(numArgsOut, "APFibrous5para", B, c1, c2);
    }


    /// <summary>
    /// Provides the standard 4-input MWArray interface to the APFibrous5para MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="B">Input argument #1</param>
    /// <param name="c1">Input argument #2</param>
    /// <param name="c2">Input argument #3</param>
    /// <param name="Density1">Input argument #4</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] APFibrous5para(int numArgsOut, MWArray B, MWArray c1, MWArray c2, 
                              MWArray Density1)
    {
      return mcr.EvaluateFunction(numArgsOut, "APFibrous5para", B, c1, c2, Density1);
    }


    /// <summary>
    /// Provides the standard 5-input MWArray interface to the APFibrous5para MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="B">Input argument #1</param>
    /// <param name="c1">Input argument #2</param>
    /// <param name="c2">Input argument #3</param>
    /// <param name="Density1">Input argument #4</param>
    /// <param name="Densityo">Input argument #5</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] APFibrous5para(int numArgsOut, MWArray B, MWArray c1, MWArray c2, 
                              MWArray Density1, MWArray Densityo)
    {
      return mcr.EvaluateFunction(numArgsOut, "APFibrous5para", B, c1, c2, Density1, Densityo);
    }


    /// <summary>
    /// Provides the standard 6-input MWArray interface to the APFibrous5para MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="B">Input argument #1</param>
    /// <param name="c1">Input argument #2</param>
    /// <param name="c2">Input argument #3</param>
    /// <param name="Density1">Input argument #4</param>
    /// <param name="Densityo">Input argument #5</param>
    /// <param name="FlowRes">Input argument #6</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] APFibrous5para(int numArgsOut, MWArray B, MWArray c1, MWArray c2, 
                              MWArray Density1, MWArray Densityo, MWArray FlowRes)
    {
      return mcr.EvaluateFunction(numArgsOut, "APFibrous5para", B, c1, c2, Density1, Densityo, FlowRes);
    }


    /// <summary>
    /// Provides the standard 7-input MWArray interface to the APFibrous5para MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="B">Input argument #1</param>
    /// <param name="c1">Input argument #2</param>
    /// <param name="c2">Input argument #3</param>
    /// <param name="Density1">Input argument #4</param>
    /// <param name="Densityo">Input argument #5</param>
    /// <param name="FlowRes">Input argument #6</param>
    /// <param name="fre">Input argument #7</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] APFibrous5para(int numArgsOut, MWArray B, MWArray c1, MWArray c2, 
                              MWArray Density1, MWArray Densityo, MWArray FlowRes, 
                              MWArray fre)
    {
      return mcr.EvaluateFunction(numArgsOut, "APFibrous5para", B, c1, c2, Density1, Densityo, FlowRes, fre);
    }


    /// <summary>
    /// Provides the standard 8-input MWArray interface to the APFibrous5para MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="B">Input argument #1</param>
    /// <param name="c1">Input argument #2</param>
    /// <param name="c2">Input argument #3</param>
    /// <param name="Density1">Input argument #4</param>
    /// <param name="Densityo">Input argument #5</param>
    /// <param name="FlowRes">Input argument #6</param>
    /// <param name="fre">Input argument #7</param>
    /// <param name="h">Input argument #8</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] APFibrous5para(int numArgsOut, MWArray B, MWArray c1, MWArray c2, 
                              MWArray Density1, MWArray Densityo, MWArray FlowRes, 
                              MWArray fre, MWArray h)
    {
      return mcr.EvaluateFunction(numArgsOut, "APFibrous5para", B, c1, c2, Density1, Densityo, FlowRes, fre, h);
    }


    /// <summary>
    /// Provides the standard 9-input MWArray interface to the APFibrous5para MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="B">Input argument #1</param>
    /// <param name="c1">Input argument #2</param>
    /// <param name="c2">Input argument #3</param>
    /// <param name="Density1">Input argument #4</param>
    /// <param name="Densityo">Input argument #5</param>
    /// <param name="FlowRes">Input argument #6</param>
    /// <param name="fre">Input argument #7</param>
    /// <param name="h">Input argument #8</param>
    /// <param name="HeatRatio">Input argument #9</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] APFibrous5para(int numArgsOut, MWArray B, MWArray c1, MWArray c2, 
                              MWArray Density1, MWArray Densityo, MWArray FlowRes, 
                              MWArray fre, MWArray h, MWArray HeatRatio)
    {
      return mcr.EvaluateFunction(numArgsOut, "APFibrous5para", B, c1, c2, Density1, Densityo, FlowRes, fre, h, HeatRatio);
    }


    /// <summary>
    /// Provides the standard 10-input MWArray interface to the APFibrous5para MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="B">Input argument #1</param>
    /// <param name="c1">Input argument #2</param>
    /// <param name="c2">Input argument #3</param>
    /// <param name="Density1">Input argument #4</param>
    /// <param name="Densityo">Input argument #5</param>
    /// <param name="FlowRes">Input argument #6</param>
    /// <param name="fre">Input argument #7</param>
    /// <param name="h">Input argument #8</param>
    /// <param name="HeatRatio">Input argument #9</param>
    /// <param name="ItaAir">Input argument #10</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] APFibrous5para(int numArgsOut, MWArray B, MWArray c1, MWArray c2, 
                              MWArray Density1, MWArray Densityo, MWArray FlowRes, 
                              MWArray fre, MWArray h, MWArray HeatRatio, MWArray ItaAir)
    {
      return mcr.EvaluateFunction(numArgsOut, "APFibrous5para", B, c1, c2, Density1, Densityo, FlowRes, fre, h, HeatRatio, ItaAir);
    }


    /// <summary>
    /// Provides the standard 11-input MWArray interface to the APFibrous5para MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="B">Input argument #1</param>
    /// <param name="c1">Input argument #2</param>
    /// <param name="c2">Input argument #3</param>
    /// <param name="Density1">Input argument #4</param>
    /// <param name="Densityo">Input argument #5</param>
    /// <param name="FlowRes">Input argument #6</param>
    /// <param name="fre">Input argument #7</param>
    /// <param name="h">Input argument #8</param>
    /// <param name="HeatRatio">Input argument #9</param>
    /// <param name="ItaAir">Input argument #10</param>
    /// <param name="L">Input argument #11</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] APFibrous5para(int numArgsOut, MWArray B, MWArray c1, MWArray c2, 
                              MWArray Density1, MWArray Densityo, MWArray FlowRes, 
                              MWArray fre, MWArray h, MWArray HeatRatio, MWArray ItaAir, 
                              MWArray L)
    {
      return mcr.EvaluateFunction(numArgsOut, "APFibrous5para", B, c1, c2, Density1, Densityo, FlowRes, fre, h, HeatRatio, ItaAir, L);
    }


    /// <summary>
    /// Provides the standard 12-input MWArray interface to the APFibrous5para MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="B">Input argument #1</param>
    /// <param name="c1">Input argument #2</param>
    /// <param name="c2">Input argument #3</param>
    /// <param name="Density1">Input argument #4</param>
    /// <param name="Densityo">Input argument #5</param>
    /// <param name="FlowRes">Input argument #6</param>
    /// <param name="fre">Input argument #7</param>
    /// <param name="h">Input argument #8</param>
    /// <param name="HeatRatio">Input argument #9</param>
    /// <param name="ItaAir">Input argument #10</param>
    /// <param name="L">Input argument #11</param>
    /// <param name="Npr">Input argument #12</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] APFibrous5para(int numArgsOut, MWArray B, MWArray c1, MWArray c2, 
                              MWArray Density1, MWArray Densityo, MWArray FlowRes, 
                              MWArray fre, MWArray h, MWArray HeatRatio, MWArray ItaAir, 
                              MWArray L, MWArray Npr)
    {
      return mcr.EvaluateFunction(numArgsOut, "APFibrous5para", B, c1, c2, Density1, Densityo, FlowRes, fre, h, HeatRatio, ItaAir, L, Npr);
    }


    /// <summary>
    /// Provides the standard 13-input MWArray interface to the APFibrous5para MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="B">Input argument #1</param>
    /// <param name="c1">Input argument #2</param>
    /// <param name="c2">Input argument #3</param>
    /// <param name="Density1">Input argument #4</param>
    /// <param name="Densityo">Input argument #5</param>
    /// <param name="FlowRes">Input argument #6</param>
    /// <param name="fre">Input argument #7</param>
    /// <param name="h">Input argument #8</param>
    /// <param name="HeatRatio">Input argument #9</param>
    /// <param name="ItaAir">Input argument #10</param>
    /// <param name="L">Input argument #11</param>
    /// <param name="Npr">Input argument #12</param>
    /// <param name="P0">Input argument #13</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] APFibrous5para(int numArgsOut, MWArray B, MWArray c1, MWArray c2, 
                              MWArray Density1, MWArray Densityo, MWArray FlowRes, 
                              MWArray fre, MWArray h, MWArray HeatRatio, MWArray ItaAir, 
                              MWArray L, MWArray Npr, MWArray P0)
    {
      return mcr.EvaluateFunction(numArgsOut, "APFibrous5para", B, c1, c2, Density1, Densityo, FlowRes, fre, h, HeatRatio, ItaAir, L, Npr, P0);
    }


    /// <summary>
    /// Provides the standard 14-input MWArray interface to the APFibrous5para MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="B">Input argument #1</param>
    /// <param name="c1">Input argument #2</param>
    /// <param name="c2">Input argument #3</param>
    /// <param name="Density1">Input argument #4</param>
    /// <param name="Densityo">Input argument #5</param>
    /// <param name="FlowRes">Input argument #6</param>
    /// <param name="fre">Input argument #7</param>
    /// <param name="h">Input argument #8</param>
    /// <param name="HeatRatio">Input argument #9</param>
    /// <param name="ItaAir">Input argument #10</param>
    /// <param name="L">Input argument #11</param>
    /// <param name="Npr">Input argument #12</param>
    /// <param name="P0">Input argument #13</param>
    /// <param name="SFactor">Input argument #14</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] APFibrous5para(int numArgsOut, MWArray B, MWArray c1, MWArray c2, 
                              MWArray Density1, MWArray Densityo, MWArray FlowRes, 
                              MWArray fre, MWArray h, MWArray HeatRatio, MWArray ItaAir, 
                              MWArray L, MWArray Npr, MWArray P0, MWArray SFactor)
    {
      return mcr.EvaluateFunction(numArgsOut, "APFibrous5para", B, c1, c2, Density1, Densityo, FlowRes, fre, h, HeatRatio, ItaAir, L, Npr, P0, SFactor);
    }


    /// <summary>
    /// Provides the standard 15-input MWArray interface to the APFibrous5para MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="B">Input argument #1</param>
    /// <param name="c1">Input argument #2</param>
    /// <param name="c2">Input argument #3</param>
    /// <param name="Density1">Input argument #4</param>
    /// <param name="Densityo">Input argument #5</param>
    /// <param name="FlowRes">Input argument #6</param>
    /// <param name="fre">Input argument #7</param>
    /// <param name="h">Input argument #8</param>
    /// <param name="HeatRatio">Input argument #9</param>
    /// <param name="ItaAir">Input argument #10</param>
    /// <param name="L">Input argument #11</param>
    /// <param name="Npr">Input argument #12</param>
    /// <param name="P0">Input argument #13</param>
    /// <param name="SFactor">Input argument #14</param>
    /// <param name="Z0">Input argument #15</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] APFibrous5para(int numArgsOut, MWArray B, MWArray c1, MWArray c2, 
                              MWArray Density1, MWArray Densityo, MWArray FlowRes, 
                              MWArray fre, MWArray h, MWArray HeatRatio, MWArray ItaAir, 
                              MWArray L, MWArray Npr, MWArray P0, MWArray SFactor, 
                              MWArray Z0)
    {
      return mcr.EvaluateFunction(numArgsOut, "APFibrous5para", B, c1, c2, Density1, Densityo, FlowRes, fre, h, HeatRatio, ItaAir, L, Npr, P0, SFactor, Z0);
    }


    /// <summary>
    /// Provides an interface for the APFibrous5para function in which the input and
    /// output
    /// arguments are specified as an array of MWArrays.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of MWArray output arguments</param>
    /// <param name= "argsIn">Array of MWArray input arguments</param>
    ///
    public void APFibrous5para(int numArgsOut, ref MWArray[] argsOut, MWArray[] argsIn)
    {
      mcr.EvaluateFunction("APFibrous5para", numArgsOut, ref argsOut, argsIn);
    }


    /// <summary>
    /// Provides a single output, 0-input MWArrayinterface to the ElasticMeritCalc MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// SurfaceImpedance=abs(Z);
    /// </remarks>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray ElasticMeritCalc()
    {
      return mcr.EvaluateFunction("ElasticMeritCalc", new MWArray[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input MWArrayinterface to the ElasticMeritCalc MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// SurfaceImpedance=abs(Z);
    /// </remarks>
    /// <param name="c">Input argument #1</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray ElasticMeritCalc(MWArray c)
    {
      return mcr.EvaluateFunction("ElasticMeritCalc", c);
    }


    /// <summary>
    /// Provides a single output, 2-input MWArrayinterface to the ElasticMeritCalc MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// SurfaceImpedance=abs(Z);
    /// </remarks>
    /// <param name="c">Input argument #1</param>
    /// <param name="c1">Input argument #2</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray ElasticMeritCalc(MWArray c, MWArray c1)
    {
      return mcr.EvaluateFunction("ElasticMeritCalc", c, c1);
    }


    /// <summary>
    /// Provides a single output, 3-input MWArrayinterface to the ElasticMeritCalc MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// SurfaceImpedance=abs(Z);
    /// </remarks>
    /// <param name="c">Input argument #1</param>
    /// <param name="c1">Input argument #2</param>
    /// <param name="c2">Input argument #3</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray ElasticMeritCalc(MWArray c, MWArray c1, MWArray c2)
    {
      return mcr.EvaluateFunction("ElasticMeritCalc", c, c1, c2);
    }


    /// <summary>
    /// Provides a single output, 4-input MWArrayinterface to the ElasticMeritCalc MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// SurfaceImpedance=abs(Z);
    /// </remarks>
    /// <param name="c">Input argument #1</param>
    /// <param name="c1">Input argument #2</param>
    /// <param name="c2">Input argument #3</param>
    /// <param name="Density1">Input argument #4</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray ElasticMeritCalc(MWArray c, MWArray c1, MWArray c2, MWArray Density1)
    {
      return mcr.EvaluateFunction("ElasticMeritCalc", c, c1, c2, Density1);
    }


    /// <summary>
    /// Provides a single output, 5-input MWArrayinterface to the ElasticMeritCalc MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// SurfaceImpedance=abs(Z);
    /// </remarks>
    /// <param name="c">Input argument #1</param>
    /// <param name="c1">Input argument #2</param>
    /// <param name="c2">Input argument #3</param>
    /// <param name="Density1">Input argument #4</param>
    /// <param name="DensityA">Input argument #5</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray ElasticMeritCalc(MWArray c, MWArray c1, MWArray c2, MWArray Density1, 
                              MWArray DensityA)
    {
      return mcr.EvaluateFunction("ElasticMeritCalc", c, c1, c2, Density1, DensityA);
    }


    /// <summary>
    /// Provides a single output, 6-input MWArrayinterface to the ElasticMeritCalc MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// SurfaceImpedance=abs(Z);
    /// </remarks>
    /// <param name="c">Input argument #1</param>
    /// <param name="c1">Input argument #2</param>
    /// <param name="c2">Input argument #3</param>
    /// <param name="Density1">Input argument #4</param>
    /// <param name="DensityA">Input argument #5</param>
    /// <param name="Densityo">Input argument #6</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray ElasticMeritCalc(MWArray c, MWArray c1, MWArray c2, MWArray Density1, 
                              MWArray DensityA, MWArray Densityo)
    {
      return mcr.EvaluateFunction("ElasticMeritCalc", c, c1, c2, Density1, DensityA, Densityo);
    }


    /// <summary>
    /// Provides a single output, 7-input MWArrayinterface to the ElasticMeritCalc MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// SurfaceImpedance=abs(Z);
    /// </remarks>
    /// <param name="c">Input argument #1</param>
    /// <param name="c1">Input argument #2</param>
    /// <param name="c2">Input argument #3</param>
    /// <param name="Density1">Input argument #4</param>
    /// <param name="DensityA">Input argument #5</param>
    /// <param name="Densityo">Input argument #6</param>
    /// <param name="Em">Input argument #7</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray ElasticMeritCalc(MWArray c, MWArray c1, MWArray c2, MWArray Density1, 
                              MWArray DensityA, MWArray Densityo, MWArray Em)
    {
      return mcr.EvaluateFunction("ElasticMeritCalc", c, c1, c2, Density1, DensityA, Densityo, Em);
    }


    /// <summary>
    /// Provides a single output, 8-input MWArrayinterface to the ElasticMeritCalc MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// SurfaceImpedance=abs(Z);
    /// </remarks>
    /// <param name="c">Input argument #1</param>
    /// <param name="c1">Input argument #2</param>
    /// <param name="c2">Input argument #3</param>
    /// <param name="Density1">Input argument #4</param>
    /// <param name="DensityA">Input argument #5</param>
    /// <param name="Densityo">Input argument #6</param>
    /// <param name="Em">Input argument #7</param>
    /// <param name="FlowRes">Input argument #8</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray ElasticMeritCalc(MWArray c, MWArray c1, MWArray c2, MWArray Density1, 
                              MWArray DensityA, MWArray Densityo, MWArray Em, MWArray 
                              FlowRes)
    {
      return mcr.EvaluateFunction("ElasticMeritCalc", c, c1, c2, Density1, DensityA, Densityo, Em, FlowRes);
    }


    /// <summary>
    /// Provides a single output, 9-input MWArrayinterface to the ElasticMeritCalc MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// SurfaceImpedance=abs(Z);
    /// </remarks>
    /// <param name="c">Input argument #1</param>
    /// <param name="c1">Input argument #2</param>
    /// <param name="c2">Input argument #3</param>
    /// <param name="Density1">Input argument #4</param>
    /// <param name="DensityA">Input argument #5</param>
    /// <param name="Densityo">Input argument #6</param>
    /// <param name="Em">Input argument #7</param>
    /// <param name="FlowRes">Input argument #8</param>
    /// <param name="freq">Input argument #9</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray ElasticMeritCalc(MWArray c, MWArray c1, MWArray c2, MWArray Density1, 
                              MWArray DensityA, MWArray Densityo, MWArray Em, MWArray 
                              FlowRes, MWArray freq)
    {
      return mcr.EvaluateFunction("ElasticMeritCalc", c, c1, c2, Density1, DensityA, Densityo, Em, FlowRes, freq);
    }


    /// <summary>
    /// Provides a single output, 10-input MWArrayinterface to the ElasticMeritCalc
    /// MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// SurfaceImpedance=abs(Z);
    /// </remarks>
    /// <param name="c">Input argument #1</param>
    /// <param name="c1">Input argument #2</param>
    /// <param name="c2">Input argument #3</param>
    /// <param name="Density1">Input argument #4</param>
    /// <param name="DensityA">Input argument #5</param>
    /// <param name="Densityo">Input argument #6</param>
    /// <param name="Em">Input argument #7</param>
    /// <param name="FlowRes">Input argument #8</param>
    /// <param name="freq">Input argument #9</param>
    /// <param name="h">Input argument #10</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray ElasticMeritCalc(MWArray c, MWArray c1, MWArray c2, MWArray Density1, 
                              MWArray DensityA, MWArray Densityo, MWArray Em, MWArray 
                              FlowRes, MWArray freq, MWArray h)
    {
      return mcr.EvaluateFunction("ElasticMeritCalc", c, c1, c2, Density1, DensityA, Densityo, Em, FlowRes, freq, h);
    }


    /// <summary>
    /// Provides a single output, 11-input MWArrayinterface to the ElasticMeritCalc
    /// MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// SurfaceImpedance=abs(Z);
    /// </remarks>
    /// <param name="c">Input argument #1</param>
    /// <param name="c1">Input argument #2</param>
    /// <param name="c2">Input argument #3</param>
    /// <param name="Density1">Input argument #4</param>
    /// <param name="DensityA">Input argument #5</param>
    /// <param name="Densityo">Input argument #6</param>
    /// <param name="Em">Input argument #7</param>
    /// <param name="FlowRes">Input argument #8</param>
    /// <param name="freq">Input argument #9</param>
    /// <param name="h">Input argument #10</param>
    /// <param name="HeatRatio">Input argument #11</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray ElasticMeritCalc(MWArray c, MWArray c1, MWArray c2, MWArray Density1, 
                              MWArray DensityA, MWArray Densityo, MWArray Em, MWArray 
                              FlowRes, MWArray freq, MWArray h, MWArray HeatRatio)
    {
      return mcr.EvaluateFunction("ElasticMeritCalc", c, c1, c2, Density1, DensityA, Densityo, Em, FlowRes, freq, h, HeatRatio);
    }


    /// <summary>
    /// Provides a single output, 12-input MWArrayinterface to the ElasticMeritCalc
    /// MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// SurfaceImpedance=abs(Z);
    /// </remarks>
    /// <param name="c">Input argument #1</param>
    /// <param name="c1">Input argument #2</param>
    /// <param name="c2">Input argument #3</param>
    /// <param name="Density1">Input argument #4</param>
    /// <param name="DensityA">Input argument #5</param>
    /// <param name="Densityo">Input argument #6</param>
    /// <param name="Em">Input argument #7</param>
    /// <param name="FlowRes">Input argument #8</param>
    /// <param name="freq">Input argument #9</param>
    /// <param name="h">Input argument #10</param>
    /// <param name="HeatRatio">Input argument #11</param>
    /// <param name="L">Input argument #12</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray ElasticMeritCalc(MWArray c, MWArray c1, MWArray c2, MWArray Density1, 
                              MWArray DensityA, MWArray Densityo, MWArray Em, MWArray 
                              FlowRes, MWArray freq, MWArray h, MWArray HeatRatio, 
                              MWArray L)
    {
      return mcr.EvaluateFunction("ElasticMeritCalc", c, c1, c2, Density1, DensityA, Densityo, Em, FlowRes, freq, h, HeatRatio, L);
    }


    /// <summary>
    /// Provides a single output, 13-input MWArrayinterface to the ElasticMeritCalc
    /// MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// SurfaceImpedance=abs(Z);
    /// </remarks>
    /// <param name="c">Input argument #1</param>
    /// <param name="c1">Input argument #2</param>
    /// <param name="c2">Input argument #3</param>
    /// <param name="Density1">Input argument #4</param>
    /// <param name="DensityA">Input argument #5</param>
    /// <param name="Densityo">Input argument #6</param>
    /// <param name="Em">Input argument #7</param>
    /// <param name="FlowRes">Input argument #8</param>
    /// <param name="freq">Input argument #9</param>
    /// <param name="h">Input argument #10</param>
    /// <param name="HeatRatio">Input argument #11</param>
    /// <param name="L">Input argument #12</param>
    /// <param name="LFactor">Input argument #13</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray ElasticMeritCalc(MWArray c, MWArray c1, MWArray c2, MWArray Density1, 
                              MWArray DensityA, MWArray Densityo, MWArray Em, MWArray 
                              FlowRes, MWArray freq, MWArray h, MWArray HeatRatio, 
                              MWArray L, MWArray LFactor)
    {
      return mcr.EvaluateFunction("ElasticMeritCalc", c, c1, c2, Density1, DensityA, Densityo, Em, FlowRes, freq, h, HeatRatio, L, LFactor);
    }


    /// <summary>
    /// Provides a single output, 14-input MWArrayinterface to the ElasticMeritCalc
    /// MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// SurfaceImpedance=abs(Z);
    /// </remarks>
    /// <param name="c">Input argument #1</param>
    /// <param name="c1">Input argument #2</param>
    /// <param name="c2">Input argument #3</param>
    /// <param name="Density1">Input argument #4</param>
    /// <param name="DensityA">Input argument #5</param>
    /// <param name="Densityo">Input argument #6</param>
    /// <param name="Em">Input argument #7</param>
    /// <param name="FlowRes">Input argument #8</param>
    /// <param name="freq">Input argument #9</param>
    /// <param name="h">Input argument #10</param>
    /// <param name="HeatRatio">Input argument #11</param>
    /// <param name="L">Input argument #12</param>
    /// <param name="LFactor">Input argument #13</param>
    /// <param name="MeasuredAbsorption">Input argument #14</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray ElasticMeritCalc(MWArray c, MWArray c1, MWArray c2, MWArray Density1, 
                              MWArray DensityA, MWArray Densityo, MWArray Em, MWArray 
                              FlowRes, MWArray freq, MWArray h, MWArray HeatRatio, 
                              MWArray L, MWArray LFactor, MWArray MeasuredAbsorption)
    {
      return mcr.EvaluateFunction("ElasticMeritCalc", c, c1, c2, Density1, DensityA, Densityo, Em, FlowRes, freq, h, HeatRatio, L, LFactor, MeasuredAbsorption);
    }


    /// <summary>
    /// Provides a single output, 15-input MWArrayinterface to the ElasticMeritCalc
    /// MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// SurfaceImpedance=abs(Z);
    /// </remarks>
    /// <param name="c">Input argument #1</param>
    /// <param name="c1">Input argument #2</param>
    /// <param name="c2">Input argument #3</param>
    /// <param name="Density1">Input argument #4</param>
    /// <param name="DensityA">Input argument #5</param>
    /// <param name="Densityo">Input argument #6</param>
    /// <param name="Em">Input argument #7</param>
    /// <param name="FlowRes">Input argument #8</param>
    /// <param name="freq">Input argument #9</param>
    /// <param name="h">Input argument #10</param>
    /// <param name="HeatRatio">Input argument #11</param>
    /// <param name="L">Input argument #12</param>
    /// <param name="LFactor">Input argument #13</param>
    /// <param name="MeasuredAbsorption">Input argument #14</param>
    /// <param name="Npr">Input argument #15</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray ElasticMeritCalc(MWArray c, MWArray c1, MWArray c2, MWArray Density1, 
                              MWArray DensityA, MWArray Densityo, MWArray Em, MWArray 
                              FlowRes, MWArray freq, MWArray h, MWArray HeatRatio, 
                              MWArray L, MWArray LFactor, MWArray MeasuredAbsorption, 
                              MWArray Npr)
    {
      return mcr.EvaluateFunction("ElasticMeritCalc", c, c1, c2, Density1, DensityA, Densityo, Em, FlowRes, freq, h, HeatRatio, L, LFactor, MeasuredAbsorption, Npr);
    }


    /// <summary>
    /// Provides a single output, 16-input MWArrayinterface to the ElasticMeritCalc
    /// MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// SurfaceImpedance=abs(Z);
    /// </remarks>
    /// <param name="c">Input argument #1</param>
    /// <param name="c1">Input argument #2</param>
    /// <param name="c2">Input argument #3</param>
    /// <param name="Density1">Input argument #4</param>
    /// <param name="DensityA">Input argument #5</param>
    /// <param name="Densityo">Input argument #6</param>
    /// <param name="Em">Input argument #7</param>
    /// <param name="FlowRes">Input argument #8</param>
    /// <param name="freq">Input argument #9</param>
    /// <param name="h">Input argument #10</param>
    /// <param name="HeatRatio">Input argument #11</param>
    /// <param name="L">Input argument #12</param>
    /// <param name="LFactor">Input argument #13</param>
    /// <param name="MeasuredAbsorption">Input argument #14</param>
    /// <param name="Npr">Input argument #15</param>
    /// <param name="PRatio">Input argument #16</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray ElasticMeritCalc(MWArray c, MWArray c1, MWArray c2, MWArray Density1, 
                              MWArray DensityA, MWArray Densityo, MWArray Em, MWArray 
                              FlowRes, MWArray freq, MWArray h, MWArray HeatRatio, 
                              MWArray L, MWArray LFactor, MWArray MeasuredAbsorption, 
                              MWArray Npr, MWArray PRatio)
    {
      return mcr.EvaluateFunction("ElasticMeritCalc", c, c1, c2, Density1, DensityA, Densityo, Em, FlowRes, freq, h, HeatRatio, L, LFactor, MeasuredAbsorption, Npr, PRatio);
    }


    /// <summary>
    /// Provides a single output, 17-input MWArrayinterface to the ElasticMeritCalc
    /// MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// SurfaceImpedance=abs(Z);
    /// </remarks>
    /// <param name="c">Input argument #1</param>
    /// <param name="c1">Input argument #2</param>
    /// <param name="c2">Input argument #3</param>
    /// <param name="Density1">Input argument #4</param>
    /// <param name="DensityA">Input argument #5</param>
    /// <param name="Densityo">Input argument #6</param>
    /// <param name="Em">Input argument #7</param>
    /// <param name="FlowRes">Input argument #8</param>
    /// <param name="freq">Input argument #9</param>
    /// <param name="h">Input argument #10</param>
    /// <param name="HeatRatio">Input argument #11</param>
    /// <param name="L">Input argument #12</param>
    /// <param name="LFactor">Input argument #13</param>
    /// <param name="MeasuredAbsorption">Input argument #14</param>
    /// <param name="Npr">Input argument #15</param>
    /// <param name="PRatio">Input argument #16</param>
    /// <param name="SFactor">Input argument #17</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray ElasticMeritCalc(MWArray c, MWArray c1, MWArray c2, MWArray Density1, 
                              MWArray DensityA, MWArray Densityo, MWArray Em, MWArray 
                              FlowRes, MWArray freq, MWArray h, MWArray HeatRatio, 
                              MWArray L, MWArray LFactor, MWArray MeasuredAbsorption, 
                              MWArray Npr, MWArray PRatio, MWArray SFactor)
    {
      return mcr.EvaluateFunction("ElasticMeritCalc", c, c1, c2, Density1, DensityA, Densityo, Em, FlowRes, freq, h, HeatRatio, L, LFactor, MeasuredAbsorption, Npr, PRatio, SFactor);
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the ElasticMeritCalc MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// SurfaceImpedance=abs(Z);
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] ElasticMeritCalc(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "ElasticMeritCalc", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 1-input MWArray interface to the ElasticMeritCalc MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// SurfaceImpedance=abs(Z);
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="c">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] ElasticMeritCalc(int numArgsOut, MWArray c)
    {
      return mcr.EvaluateFunction(numArgsOut, "ElasticMeritCalc", c);
    }


    /// <summary>
    /// Provides the standard 2-input MWArray interface to the ElasticMeritCalc MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// SurfaceImpedance=abs(Z);
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="c">Input argument #1</param>
    /// <param name="c1">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] ElasticMeritCalc(int numArgsOut, MWArray c, MWArray c1)
    {
      return mcr.EvaluateFunction(numArgsOut, "ElasticMeritCalc", c, c1);
    }


    /// <summary>
    /// Provides the standard 3-input MWArray interface to the ElasticMeritCalc MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// SurfaceImpedance=abs(Z);
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="c">Input argument #1</param>
    /// <param name="c1">Input argument #2</param>
    /// <param name="c2">Input argument #3</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] ElasticMeritCalc(int numArgsOut, MWArray c, MWArray c1, MWArray c2)
    {
      return mcr.EvaluateFunction(numArgsOut, "ElasticMeritCalc", c, c1, c2);
    }


    /// <summary>
    /// Provides the standard 4-input MWArray interface to the ElasticMeritCalc MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// SurfaceImpedance=abs(Z);
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="c">Input argument #1</param>
    /// <param name="c1">Input argument #2</param>
    /// <param name="c2">Input argument #3</param>
    /// <param name="Density1">Input argument #4</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] ElasticMeritCalc(int numArgsOut, MWArray c, MWArray c1, MWArray c2, 
                                MWArray Density1)
    {
      return mcr.EvaluateFunction(numArgsOut, "ElasticMeritCalc", c, c1, c2, Density1);
    }


    /// <summary>
    /// Provides the standard 5-input MWArray interface to the ElasticMeritCalc MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// SurfaceImpedance=abs(Z);
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="c">Input argument #1</param>
    /// <param name="c1">Input argument #2</param>
    /// <param name="c2">Input argument #3</param>
    /// <param name="Density1">Input argument #4</param>
    /// <param name="DensityA">Input argument #5</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] ElasticMeritCalc(int numArgsOut, MWArray c, MWArray c1, MWArray c2, 
                                MWArray Density1, MWArray DensityA)
    {
      return mcr.EvaluateFunction(numArgsOut, "ElasticMeritCalc", c, c1, c2, Density1, DensityA);
    }


    /// <summary>
    /// Provides the standard 6-input MWArray interface to the ElasticMeritCalc MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// SurfaceImpedance=abs(Z);
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="c">Input argument #1</param>
    /// <param name="c1">Input argument #2</param>
    /// <param name="c2">Input argument #3</param>
    /// <param name="Density1">Input argument #4</param>
    /// <param name="DensityA">Input argument #5</param>
    /// <param name="Densityo">Input argument #6</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] ElasticMeritCalc(int numArgsOut, MWArray c, MWArray c1, MWArray c2, 
                                MWArray Density1, MWArray DensityA, MWArray Densityo)
    {
      return mcr.EvaluateFunction(numArgsOut, "ElasticMeritCalc", c, c1, c2, Density1, DensityA, Densityo);
    }


    /// <summary>
    /// Provides the standard 7-input MWArray interface to the ElasticMeritCalc MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// SurfaceImpedance=abs(Z);
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="c">Input argument #1</param>
    /// <param name="c1">Input argument #2</param>
    /// <param name="c2">Input argument #3</param>
    /// <param name="Density1">Input argument #4</param>
    /// <param name="DensityA">Input argument #5</param>
    /// <param name="Densityo">Input argument #6</param>
    /// <param name="Em">Input argument #7</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] ElasticMeritCalc(int numArgsOut, MWArray c, MWArray c1, MWArray c2, 
                                MWArray Density1, MWArray DensityA, MWArray Densityo, 
                                MWArray Em)
    {
      return mcr.EvaluateFunction(numArgsOut, "ElasticMeritCalc", c, c1, c2, Density1, DensityA, Densityo, Em);
    }


    /// <summary>
    /// Provides the standard 8-input MWArray interface to the ElasticMeritCalc MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// SurfaceImpedance=abs(Z);
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="c">Input argument #1</param>
    /// <param name="c1">Input argument #2</param>
    /// <param name="c2">Input argument #3</param>
    /// <param name="Density1">Input argument #4</param>
    /// <param name="DensityA">Input argument #5</param>
    /// <param name="Densityo">Input argument #6</param>
    /// <param name="Em">Input argument #7</param>
    /// <param name="FlowRes">Input argument #8</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] ElasticMeritCalc(int numArgsOut, MWArray c, MWArray c1, MWArray c2, 
                                MWArray Density1, MWArray DensityA, MWArray Densityo, 
                                MWArray Em, MWArray FlowRes)
    {
      return mcr.EvaluateFunction(numArgsOut, "ElasticMeritCalc", c, c1, c2, Density1, DensityA, Densityo, Em, FlowRes);
    }


    /// <summary>
    /// Provides the standard 9-input MWArray interface to the ElasticMeritCalc MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// SurfaceImpedance=abs(Z);
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="c">Input argument #1</param>
    /// <param name="c1">Input argument #2</param>
    /// <param name="c2">Input argument #3</param>
    /// <param name="Density1">Input argument #4</param>
    /// <param name="DensityA">Input argument #5</param>
    /// <param name="Densityo">Input argument #6</param>
    /// <param name="Em">Input argument #7</param>
    /// <param name="FlowRes">Input argument #8</param>
    /// <param name="freq">Input argument #9</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] ElasticMeritCalc(int numArgsOut, MWArray c, MWArray c1, MWArray c2, 
                                MWArray Density1, MWArray DensityA, MWArray Densityo, 
                                MWArray Em, MWArray FlowRes, MWArray freq)
    {
      return mcr.EvaluateFunction(numArgsOut, "ElasticMeritCalc", c, c1, c2, Density1, DensityA, Densityo, Em, FlowRes, freq);
    }


    /// <summary>
    /// Provides the standard 10-input MWArray interface to the ElasticMeritCalc MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// SurfaceImpedance=abs(Z);
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="c">Input argument #1</param>
    /// <param name="c1">Input argument #2</param>
    /// <param name="c2">Input argument #3</param>
    /// <param name="Density1">Input argument #4</param>
    /// <param name="DensityA">Input argument #5</param>
    /// <param name="Densityo">Input argument #6</param>
    /// <param name="Em">Input argument #7</param>
    /// <param name="FlowRes">Input argument #8</param>
    /// <param name="freq">Input argument #9</param>
    /// <param name="h">Input argument #10</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] ElasticMeritCalc(int numArgsOut, MWArray c, MWArray c1, MWArray c2, 
                                MWArray Density1, MWArray DensityA, MWArray Densityo, 
                                MWArray Em, MWArray FlowRes, MWArray freq, MWArray h)
    {
      return mcr.EvaluateFunction(numArgsOut, "ElasticMeritCalc", c, c1, c2, Density1, DensityA, Densityo, Em, FlowRes, freq, h);
    }


    /// <summary>
    /// Provides the standard 11-input MWArray interface to the ElasticMeritCalc MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// SurfaceImpedance=abs(Z);
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="c">Input argument #1</param>
    /// <param name="c1">Input argument #2</param>
    /// <param name="c2">Input argument #3</param>
    /// <param name="Density1">Input argument #4</param>
    /// <param name="DensityA">Input argument #5</param>
    /// <param name="Densityo">Input argument #6</param>
    /// <param name="Em">Input argument #7</param>
    /// <param name="FlowRes">Input argument #8</param>
    /// <param name="freq">Input argument #9</param>
    /// <param name="h">Input argument #10</param>
    /// <param name="HeatRatio">Input argument #11</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] ElasticMeritCalc(int numArgsOut, MWArray c, MWArray c1, MWArray c2, 
                                MWArray Density1, MWArray DensityA, MWArray Densityo, 
                                MWArray Em, MWArray FlowRes, MWArray freq, MWArray h, 
                                MWArray HeatRatio)
    {
      return mcr.EvaluateFunction(numArgsOut, "ElasticMeritCalc", c, c1, c2, Density1, DensityA, Densityo, Em, FlowRes, freq, h, HeatRatio);
    }


    /// <summary>
    /// Provides the standard 12-input MWArray interface to the ElasticMeritCalc MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// SurfaceImpedance=abs(Z);
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="c">Input argument #1</param>
    /// <param name="c1">Input argument #2</param>
    /// <param name="c2">Input argument #3</param>
    /// <param name="Density1">Input argument #4</param>
    /// <param name="DensityA">Input argument #5</param>
    /// <param name="Densityo">Input argument #6</param>
    /// <param name="Em">Input argument #7</param>
    /// <param name="FlowRes">Input argument #8</param>
    /// <param name="freq">Input argument #9</param>
    /// <param name="h">Input argument #10</param>
    /// <param name="HeatRatio">Input argument #11</param>
    /// <param name="L">Input argument #12</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] ElasticMeritCalc(int numArgsOut, MWArray c, MWArray c1, MWArray c2, 
                                MWArray Density1, MWArray DensityA, MWArray Densityo, 
                                MWArray Em, MWArray FlowRes, MWArray freq, MWArray h, 
                                MWArray HeatRatio, MWArray L)
    {
      return mcr.EvaluateFunction(numArgsOut, "ElasticMeritCalc", c, c1, c2, Density1, DensityA, Densityo, Em, FlowRes, freq, h, HeatRatio, L);
    }


    /// <summary>
    /// Provides the standard 13-input MWArray interface to the ElasticMeritCalc MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// SurfaceImpedance=abs(Z);
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="c">Input argument #1</param>
    /// <param name="c1">Input argument #2</param>
    /// <param name="c2">Input argument #3</param>
    /// <param name="Density1">Input argument #4</param>
    /// <param name="DensityA">Input argument #5</param>
    /// <param name="Densityo">Input argument #6</param>
    /// <param name="Em">Input argument #7</param>
    /// <param name="FlowRes">Input argument #8</param>
    /// <param name="freq">Input argument #9</param>
    /// <param name="h">Input argument #10</param>
    /// <param name="HeatRatio">Input argument #11</param>
    /// <param name="L">Input argument #12</param>
    /// <param name="LFactor">Input argument #13</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] ElasticMeritCalc(int numArgsOut, MWArray c, MWArray c1, MWArray c2, 
                                MWArray Density1, MWArray DensityA, MWArray Densityo, 
                                MWArray Em, MWArray FlowRes, MWArray freq, MWArray h, 
                                MWArray HeatRatio, MWArray L, MWArray LFactor)
    {
      return mcr.EvaluateFunction(numArgsOut, "ElasticMeritCalc", c, c1, c2, Density1, DensityA, Densityo, Em, FlowRes, freq, h, HeatRatio, L, LFactor);
    }


    /// <summary>
    /// Provides the standard 14-input MWArray interface to the ElasticMeritCalc MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// SurfaceImpedance=abs(Z);
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="c">Input argument #1</param>
    /// <param name="c1">Input argument #2</param>
    /// <param name="c2">Input argument #3</param>
    /// <param name="Density1">Input argument #4</param>
    /// <param name="DensityA">Input argument #5</param>
    /// <param name="Densityo">Input argument #6</param>
    /// <param name="Em">Input argument #7</param>
    /// <param name="FlowRes">Input argument #8</param>
    /// <param name="freq">Input argument #9</param>
    /// <param name="h">Input argument #10</param>
    /// <param name="HeatRatio">Input argument #11</param>
    /// <param name="L">Input argument #12</param>
    /// <param name="LFactor">Input argument #13</param>
    /// <param name="MeasuredAbsorption">Input argument #14</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] ElasticMeritCalc(int numArgsOut, MWArray c, MWArray c1, MWArray c2, 
                                MWArray Density1, MWArray DensityA, MWArray Densityo, 
                                MWArray Em, MWArray FlowRes, MWArray freq, MWArray h, 
                                MWArray HeatRatio, MWArray L, MWArray LFactor, MWArray 
                                MeasuredAbsorption)
    {
      return mcr.EvaluateFunction(numArgsOut, "ElasticMeritCalc", c, c1, c2, Density1, DensityA, Densityo, Em, FlowRes, freq, h, HeatRatio, L, LFactor, MeasuredAbsorption);
    }


    /// <summary>
    /// Provides the standard 15-input MWArray interface to the ElasticMeritCalc MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// SurfaceImpedance=abs(Z);
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="c">Input argument #1</param>
    /// <param name="c1">Input argument #2</param>
    /// <param name="c2">Input argument #3</param>
    /// <param name="Density1">Input argument #4</param>
    /// <param name="DensityA">Input argument #5</param>
    /// <param name="Densityo">Input argument #6</param>
    /// <param name="Em">Input argument #7</param>
    /// <param name="FlowRes">Input argument #8</param>
    /// <param name="freq">Input argument #9</param>
    /// <param name="h">Input argument #10</param>
    /// <param name="HeatRatio">Input argument #11</param>
    /// <param name="L">Input argument #12</param>
    /// <param name="LFactor">Input argument #13</param>
    /// <param name="MeasuredAbsorption">Input argument #14</param>
    /// <param name="Npr">Input argument #15</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] ElasticMeritCalc(int numArgsOut, MWArray c, MWArray c1, MWArray c2, 
                                MWArray Density1, MWArray DensityA, MWArray Densityo, 
                                MWArray Em, MWArray FlowRes, MWArray freq, MWArray h, 
                                MWArray HeatRatio, MWArray L, MWArray LFactor, MWArray 
                                MeasuredAbsorption, MWArray Npr)
    {
      return mcr.EvaluateFunction(numArgsOut, "ElasticMeritCalc", c, c1, c2, Density1, DensityA, Densityo, Em, FlowRes, freq, h, HeatRatio, L, LFactor, MeasuredAbsorption, Npr);
    }


    /// <summary>
    /// Provides the standard 16-input MWArray interface to the ElasticMeritCalc MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// SurfaceImpedance=abs(Z);
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="c">Input argument #1</param>
    /// <param name="c1">Input argument #2</param>
    /// <param name="c2">Input argument #3</param>
    /// <param name="Density1">Input argument #4</param>
    /// <param name="DensityA">Input argument #5</param>
    /// <param name="Densityo">Input argument #6</param>
    /// <param name="Em">Input argument #7</param>
    /// <param name="FlowRes">Input argument #8</param>
    /// <param name="freq">Input argument #9</param>
    /// <param name="h">Input argument #10</param>
    /// <param name="HeatRatio">Input argument #11</param>
    /// <param name="L">Input argument #12</param>
    /// <param name="LFactor">Input argument #13</param>
    /// <param name="MeasuredAbsorption">Input argument #14</param>
    /// <param name="Npr">Input argument #15</param>
    /// <param name="PRatio">Input argument #16</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] ElasticMeritCalc(int numArgsOut, MWArray c, MWArray c1, MWArray c2, 
                                MWArray Density1, MWArray DensityA, MWArray Densityo, 
                                MWArray Em, MWArray FlowRes, MWArray freq, MWArray h, 
                                MWArray HeatRatio, MWArray L, MWArray LFactor, MWArray 
                                MeasuredAbsorption, MWArray Npr, MWArray PRatio)
    {
      return mcr.EvaluateFunction(numArgsOut, "ElasticMeritCalc", c, c1, c2, Density1, DensityA, Densityo, Em, FlowRes, freq, h, HeatRatio, L, LFactor, MeasuredAbsorption, Npr, PRatio);
    }


    /// <summary>
    /// Provides the standard 17-input MWArray interface to the ElasticMeritCalc MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// SurfaceImpedance=abs(Z);
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="c">Input argument #1</param>
    /// <param name="c1">Input argument #2</param>
    /// <param name="c2">Input argument #3</param>
    /// <param name="Density1">Input argument #4</param>
    /// <param name="DensityA">Input argument #5</param>
    /// <param name="Densityo">Input argument #6</param>
    /// <param name="Em">Input argument #7</param>
    /// <param name="FlowRes">Input argument #8</param>
    /// <param name="freq">Input argument #9</param>
    /// <param name="h">Input argument #10</param>
    /// <param name="HeatRatio">Input argument #11</param>
    /// <param name="L">Input argument #12</param>
    /// <param name="LFactor">Input argument #13</param>
    /// <param name="MeasuredAbsorption">Input argument #14</param>
    /// <param name="Npr">Input argument #15</param>
    /// <param name="PRatio">Input argument #16</param>
    /// <param name="SFactor">Input argument #17</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] ElasticMeritCalc(int numArgsOut, MWArray c, MWArray c1, MWArray c2, 
                                MWArray Density1, MWArray DensityA, MWArray Densityo, 
                                MWArray Em, MWArray FlowRes, MWArray freq, MWArray h, 
                                MWArray HeatRatio, MWArray L, MWArray LFactor, MWArray 
                                MeasuredAbsorption, MWArray Npr, MWArray PRatio, MWArray 
                                SFactor)
    {
      return mcr.EvaluateFunction(numArgsOut, "ElasticMeritCalc", c, c1, c2, Density1, DensityA, Densityo, Em, FlowRes, freq, h, HeatRatio, L, LFactor, MeasuredAbsorption, Npr, PRatio, SFactor);
    }


    /// <summary>
    /// Provides an interface for the ElasticMeritCalc function in which the input and
    /// output
    /// arguments are specified as an array of MWArrays.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// M-Documentation:
    /// SurfaceImpedance=abs(Z);
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of MWArray output arguments</param>
    /// <param name= "argsIn">Array of MWArray input arguments</param>
    ///
    public void ElasticMeritCalc(int numArgsOut, ref MWArray[] argsOut, MWArray[] argsIn)
    {
      mcr.EvaluateFunction("ElasticMeritCalc", numArgsOut, ref argsOut, argsIn);
    }


    /// <summary>
    /// Provides a single output, 0-input MWArrayinterface to the FuncTest MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// UNTITLED Summary of this function goes here
    /// Detailed explanation goes here
    /// </remarks>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray FuncTest()
    {
      return mcr.EvaluateFunction("FuncTest", new MWArray[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input MWArrayinterface to the FuncTest MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// UNTITLED Summary of this function goes here
    /// Detailed explanation goes here
    /// </remarks>
    /// <param name="input">Input argument #1</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray FuncTest(MWArray input)
    {
      return mcr.EvaluateFunction("FuncTest", input);
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the FuncTest MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// UNTITLED Summary of this function goes here
    /// Detailed explanation goes here
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] FuncTest(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "FuncTest", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 1-input MWArray interface to the FuncTest MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// UNTITLED Summary of this function goes here
    /// Detailed explanation goes here
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="input">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] FuncTest(int numArgsOut, MWArray input)
    {
      return mcr.EvaluateFunction(numArgsOut, "FuncTest", input);
    }


    /// <summary>
    /// Provides an interface for the FuncTest function in which the input and output
    /// arguments are specified as an array of MWArrays.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// M-Documentation:
    /// UNTITLED Summary of this function goes here
    /// Detailed explanation goes here
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of MWArray output arguments</param>
    /// <param name= "argsIn">Array of MWArray input arguments</param>
    ///
    public void FuncTest(int numArgsOut, ref MWArray[] argsOut, MWArray[] argsIn)
    {
      mcr.EvaluateFunction("FuncTest", numArgsOut, ref argsOut, argsIn);
    }


    /// <summary>
    /// Provides a single output, 0-input MWArrayinterface to the MeritCalc MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Density1=BulkDensity;      INSUNG
    /// </remarks>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray MeritCalc()
    {
      return mcr.EvaluateFunction("MeritCalc", new MWArray[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input MWArrayinterface to the MeritCalc MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Density1=BulkDensity;      INSUNG
    /// </remarks>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray MeritCalc(MWArray BulkDensity)
    {
      return mcr.EvaluateFunction("MeritCalc", BulkDensity);
    }


    /// <summary>
    /// Provides a single output, 2-input MWArrayinterface to the MeritCalc MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Density1=BulkDensity;      INSUNG
    /// </remarks>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="B">Input argument #2</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray MeritCalc(MWArray BulkDensity, MWArray B)
    {
      return mcr.EvaluateFunction("MeritCalc", BulkDensity, B);
    }


    /// <summary>
    /// Provides a single output, 3-input MWArrayinterface to the MeritCalc MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Density1=BulkDensity;      INSUNG
    /// </remarks>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="B">Input argument #2</param>
    /// <param name="c1">Input argument #3</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray MeritCalc(MWArray BulkDensity, MWArray B, MWArray c1)
    {
      return mcr.EvaluateFunction("MeritCalc", BulkDensity, B, c1);
    }


    /// <summary>
    /// Provides a single output, 4-input MWArrayinterface to the MeritCalc MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Density1=BulkDensity;      INSUNG
    /// </remarks>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="B">Input argument #2</param>
    /// <param name="c1">Input argument #3</param>
    /// <param name="c2">Input argument #4</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray MeritCalc(MWArray BulkDensity, MWArray B, MWArray c1, MWArray c2)
    {
      return mcr.EvaluateFunction("MeritCalc", BulkDensity, B, c1, c2);
    }


    /// <summary>
    /// Provides a single output, 5-input MWArrayinterface to the MeritCalc MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Density1=BulkDensity;      INSUNG
    /// </remarks>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="B">Input argument #2</param>
    /// <param name="c1">Input argument #3</param>
    /// <param name="c2">Input argument #4</param>
    /// <param name="Densityo">Input argument #5</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray MeritCalc(MWArray BulkDensity, MWArray B, MWArray c1, MWArray c2, 
                       MWArray Densityo)
    {
      return mcr.EvaluateFunction("MeritCalc", BulkDensity, B, c1, c2, Densityo);
    }


    /// <summary>
    /// Provides a single output, 6-input MWArrayinterface to the MeritCalc MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Density1=BulkDensity;      INSUNG
    /// </remarks>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="B">Input argument #2</param>
    /// <param name="c1">Input argument #3</param>
    /// <param name="c2">Input argument #4</param>
    /// <param name="Densityo">Input argument #5</param>
    /// <param name="FlowRes">Input argument #6</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray MeritCalc(MWArray BulkDensity, MWArray B, MWArray c1, MWArray c2, 
                       MWArray Densityo, MWArray FlowRes)
    {
      return mcr.EvaluateFunction("MeritCalc", BulkDensity, B, c1, c2, Densityo, FlowRes);
    }


    /// <summary>
    /// Provides a single output, 7-input MWArrayinterface to the MeritCalc MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Density1=BulkDensity;      INSUNG
    /// </remarks>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="B">Input argument #2</param>
    /// <param name="c1">Input argument #3</param>
    /// <param name="c2">Input argument #4</param>
    /// <param name="Densityo">Input argument #5</param>
    /// <param name="FlowRes">Input argument #6</param>
    /// <param name="freq">Input argument #7</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray MeritCalc(MWArray BulkDensity, MWArray B, MWArray c1, MWArray c2, 
                       MWArray Densityo, MWArray FlowRes, MWArray freq)
    {
      return mcr.EvaluateFunction("MeritCalc", BulkDensity, B, c1, c2, Densityo, FlowRes, freq);
    }


    /// <summary>
    /// Provides a single output, 8-input MWArrayinterface to the MeritCalc MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Density1=BulkDensity;      INSUNG
    /// </remarks>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="B">Input argument #2</param>
    /// <param name="c1">Input argument #3</param>
    /// <param name="c2">Input argument #4</param>
    /// <param name="Densityo">Input argument #5</param>
    /// <param name="FlowRes">Input argument #6</param>
    /// <param name="freq">Input argument #7</param>
    /// <param name="h">Input argument #8</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray MeritCalc(MWArray BulkDensity, MWArray B, MWArray c1, MWArray c2, 
                       MWArray Densityo, MWArray FlowRes, MWArray freq, MWArray h)
    {
      return mcr.EvaluateFunction("MeritCalc", BulkDensity, B, c1, c2, Densityo, FlowRes, freq, h);
    }


    /// <summary>
    /// Provides a single output, 9-input MWArrayinterface to the MeritCalc MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Density1=BulkDensity;      INSUNG
    /// </remarks>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="B">Input argument #2</param>
    /// <param name="c1">Input argument #3</param>
    /// <param name="c2">Input argument #4</param>
    /// <param name="Densityo">Input argument #5</param>
    /// <param name="FlowRes">Input argument #6</param>
    /// <param name="freq">Input argument #7</param>
    /// <param name="h">Input argument #8</param>
    /// <param name="HeatRatio">Input argument #9</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray MeritCalc(MWArray BulkDensity, MWArray B, MWArray c1, MWArray c2, 
                       MWArray Densityo, MWArray FlowRes, MWArray freq, MWArray h, 
                       MWArray HeatRatio)
    {
      return mcr.EvaluateFunction("MeritCalc", BulkDensity, B, c1, c2, Densityo, FlowRes, freq, h, HeatRatio);
    }


    /// <summary>
    /// Provides a single output, 10-input MWArrayinterface to the MeritCalc MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Density1=BulkDensity;      INSUNG
    /// </remarks>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="B">Input argument #2</param>
    /// <param name="c1">Input argument #3</param>
    /// <param name="c2">Input argument #4</param>
    /// <param name="Densityo">Input argument #5</param>
    /// <param name="FlowRes">Input argument #6</param>
    /// <param name="freq">Input argument #7</param>
    /// <param name="h">Input argument #8</param>
    /// <param name="HeatRatio">Input argument #9</param>
    /// <param name="ItaAir">Input argument #10</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray MeritCalc(MWArray BulkDensity, MWArray B, MWArray c1, MWArray c2, 
                       MWArray Densityo, MWArray FlowRes, MWArray freq, MWArray h, 
                       MWArray HeatRatio, MWArray ItaAir)
    {
      return mcr.EvaluateFunction("MeritCalc", BulkDensity, B, c1, c2, Densityo, FlowRes, freq, h, HeatRatio, ItaAir);
    }


    /// <summary>
    /// Provides a single output, 11-input MWArrayinterface to the MeritCalc MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Density1=BulkDensity;      INSUNG
    /// </remarks>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="B">Input argument #2</param>
    /// <param name="c1">Input argument #3</param>
    /// <param name="c2">Input argument #4</param>
    /// <param name="Densityo">Input argument #5</param>
    /// <param name="FlowRes">Input argument #6</param>
    /// <param name="freq">Input argument #7</param>
    /// <param name="h">Input argument #8</param>
    /// <param name="HeatRatio">Input argument #9</param>
    /// <param name="ItaAir">Input argument #10</param>
    /// <param name="L">Input argument #11</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray MeritCalc(MWArray BulkDensity, MWArray B, MWArray c1, MWArray c2, 
                       MWArray Densityo, MWArray FlowRes, MWArray freq, MWArray h, 
                       MWArray HeatRatio, MWArray ItaAir, MWArray L)
    {
      return mcr.EvaluateFunction("MeritCalc", BulkDensity, B, c1, c2, Densityo, FlowRes, freq, h, HeatRatio, ItaAir, L);
    }


    /// <summary>
    /// Provides a single output, 12-input MWArrayinterface to the MeritCalc MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Density1=BulkDensity;      INSUNG
    /// </remarks>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="B">Input argument #2</param>
    /// <param name="c1">Input argument #3</param>
    /// <param name="c2">Input argument #4</param>
    /// <param name="Densityo">Input argument #5</param>
    /// <param name="FlowRes">Input argument #6</param>
    /// <param name="freq">Input argument #7</param>
    /// <param name="h">Input argument #8</param>
    /// <param name="HeatRatio">Input argument #9</param>
    /// <param name="ItaAir">Input argument #10</param>
    /// <param name="L">Input argument #11</param>
    /// <param name="MAbsorption">Input argument #12</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray MeritCalc(MWArray BulkDensity, MWArray B, MWArray c1, MWArray c2, 
                       MWArray Densityo, MWArray FlowRes, MWArray freq, MWArray h, 
                       MWArray HeatRatio, MWArray ItaAir, MWArray L, MWArray MAbsorption)
    {
      return mcr.EvaluateFunction("MeritCalc", BulkDensity, B, c1, c2, Densityo, FlowRes, freq, h, HeatRatio, ItaAir, L, MAbsorption);
    }


    /// <summary>
    /// Provides a single output, 13-input MWArrayinterface to the MeritCalc MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Density1=BulkDensity;      INSUNG
    /// </remarks>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="B">Input argument #2</param>
    /// <param name="c1">Input argument #3</param>
    /// <param name="c2">Input argument #4</param>
    /// <param name="Densityo">Input argument #5</param>
    /// <param name="FlowRes">Input argument #6</param>
    /// <param name="freq">Input argument #7</param>
    /// <param name="h">Input argument #8</param>
    /// <param name="HeatRatio">Input argument #9</param>
    /// <param name="ItaAir">Input argument #10</param>
    /// <param name="L">Input argument #11</param>
    /// <param name="MAbsorption">Input argument #12</param>
    /// <param name="Npr">Input argument #13</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray MeritCalc(MWArray BulkDensity, MWArray B, MWArray c1, MWArray c2, 
                       MWArray Densityo, MWArray FlowRes, MWArray freq, MWArray h, 
                       MWArray HeatRatio, MWArray ItaAir, MWArray L, MWArray MAbsorption, 
                       MWArray Npr)
    {
      return mcr.EvaluateFunction("MeritCalc", BulkDensity, B, c1, c2, Densityo, FlowRes, freq, h, HeatRatio, ItaAir, L, MAbsorption, Npr);
    }


    /// <summary>
    /// Provides a single output, 14-input MWArrayinterface to the MeritCalc MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Density1=BulkDensity;      INSUNG
    /// </remarks>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="B">Input argument #2</param>
    /// <param name="c1">Input argument #3</param>
    /// <param name="c2">Input argument #4</param>
    /// <param name="Densityo">Input argument #5</param>
    /// <param name="FlowRes">Input argument #6</param>
    /// <param name="freq">Input argument #7</param>
    /// <param name="h">Input argument #8</param>
    /// <param name="HeatRatio">Input argument #9</param>
    /// <param name="ItaAir">Input argument #10</param>
    /// <param name="L">Input argument #11</param>
    /// <param name="MAbsorption">Input argument #12</param>
    /// <param name="Npr">Input argument #13</param>
    /// <param name="P0">Input argument #14</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray MeritCalc(MWArray BulkDensity, MWArray B, MWArray c1, MWArray c2, 
                       MWArray Densityo, MWArray FlowRes, MWArray freq, MWArray h, 
                       MWArray HeatRatio, MWArray ItaAir, MWArray L, MWArray MAbsorption, 
                       MWArray Npr, MWArray P0)
    {
      return mcr.EvaluateFunction("MeritCalc", BulkDensity, B, c1, c2, Densityo, FlowRes, freq, h, HeatRatio, ItaAir, L, MAbsorption, Npr, P0);
    }


    /// <summary>
    /// Provides a single output, 15-input MWArrayinterface to the MeritCalc MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Density1=BulkDensity;      INSUNG
    /// </remarks>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="B">Input argument #2</param>
    /// <param name="c1">Input argument #3</param>
    /// <param name="c2">Input argument #4</param>
    /// <param name="Densityo">Input argument #5</param>
    /// <param name="FlowRes">Input argument #6</param>
    /// <param name="freq">Input argument #7</param>
    /// <param name="h">Input argument #8</param>
    /// <param name="HeatRatio">Input argument #9</param>
    /// <param name="ItaAir">Input argument #10</param>
    /// <param name="L">Input argument #11</param>
    /// <param name="MAbsorption">Input argument #12</param>
    /// <param name="Npr">Input argument #13</param>
    /// <param name="P0">Input argument #14</param>
    /// <param name="SFactor">Input argument #15</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray MeritCalc(MWArray BulkDensity, MWArray B, MWArray c1, MWArray c2, 
                       MWArray Densityo, MWArray FlowRes, MWArray freq, MWArray h, 
                       MWArray HeatRatio, MWArray ItaAir, MWArray L, MWArray MAbsorption, 
                       MWArray Npr, MWArray P0, MWArray SFactor)
    {
      return mcr.EvaluateFunction("MeritCalc", BulkDensity, B, c1, c2, Densityo, FlowRes, freq, h, HeatRatio, ItaAir, L, MAbsorption, Npr, P0, SFactor);
    }


    /// <summary>
    /// Provides a single output, 16-input MWArrayinterface to the MeritCalc MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Density1=BulkDensity;      INSUNG
    /// </remarks>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="B">Input argument #2</param>
    /// <param name="c1">Input argument #3</param>
    /// <param name="c2">Input argument #4</param>
    /// <param name="Densityo">Input argument #5</param>
    /// <param name="FlowRes">Input argument #6</param>
    /// <param name="freq">Input argument #7</param>
    /// <param name="h">Input argument #8</param>
    /// <param name="HeatRatio">Input argument #9</param>
    /// <param name="ItaAir">Input argument #10</param>
    /// <param name="L">Input argument #11</param>
    /// <param name="MAbsorption">Input argument #12</param>
    /// <param name="Npr">Input argument #13</param>
    /// <param name="P0">Input argument #14</param>
    /// <param name="SFactor">Input argument #15</param>
    /// <param name="Z0">Input argument #16</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray MeritCalc(MWArray BulkDensity, MWArray B, MWArray c1, MWArray c2, 
                       MWArray Densityo, MWArray FlowRes, MWArray freq, MWArray h, 
                       MWArray HeatRatio, MWArray ItaAir, MWArray L, MWArray MAbsorption, 
                       MWArray Npr, MWArray P0, MWArray SFactor, MWArray Z0)
    {
      return mcr.EvaluateFunction("MeritCalc", BulkDensity, B, c1, c2, Densityo, FlowRes, freq, h, HeatRatio, ItaAir, L, MAbsorption, Npr, P0, SFactor, Z0);
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the MeritCalc MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Density1=BulkDensity;      INSUNG
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] MeritCalc(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "MeritCalc", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 1-input MWArray interface to the MeritCalc MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Density1=BulkDensity;      INSUNG
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] MeritCalc(int numArgsOut, MWArray BulkDensity)
    {
      return mcr.EvaluateFunction(numArgsOut, "MeritCalc", BulkDensity);
    }


    /// <summary>
    /// Provides the standard 2-input MWArray interface to the MeritCalc MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Density1=BulkDensity;      INSUNG
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="B">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] MeritCalc(int numArgsOut, MWArray BulkDensity, MWArray B)
    {
      return mcr.EvaluateFunction(numArgsOut, "MeritCalc", BulkDensity, B);
    }


    /// <summary>
    /// Provides the standard 3-input MWArray interface to the MeritCalc MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Density1=BulkDensity;      INSUNG
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="B">Input argument #2</param>
    /// <param name="c1">Input argument #3</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] MeritCalc(int numArgsOut, MWArray BulkDensity, MWArray B, MWArray c1)
    {
      return mcr.EvaluateFunction(numArgsOut, "MeritCalc", BulkDensity, B, c1);
    }


    /// <summary>
    /// Provides the standard 4-input MWArray interface to the MeritCalc MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Density1=BulkDensity;      INSUNG
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="B">Input argument #2</param>
    /// <param name="c1">Input argument #3</param>
    /// <param name="c2">Input argument #4</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] MeritCalc(int numArgsOut, MWArray BulkDensity, MWArray B, MWArray 
                         c1, MWArray c2)
    {
      return mcr.EvaluateFunction(numArgsOut, "MeritCalc", BulkDensity, B, c1, c2);
    }


    /// <summary>
    /// Provides the standard 5-input MWArray interface to the MeritCalc MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Density1=BulkDensity;      INSUNG
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="B">Input argument #2</param>
    /// <param name="c1">Input argument #3</param>
    /// <param name="c2">Input argument #4</param>
    /// <param name="Densityo">Input argument #5</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] MeritCalc(int numArgsOut, MWArray BulkDensity, MWArray B, MWArray 
                         c1, MWArray c2, MWArray Densityo)
    {
      return mcr.EvaluateFunction(numArgsOut, "MeritCalc", BulkDensity, B, c1, c2, Densityo);
    }


    /// <summary>
    /// Provides the standard 6-input MWArray interface to the MeritCalc MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Density1=BulkDensity;      INSUNG
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="B">Input argument #2</param>
    /// <param name="c1">Input argument #3</param>
    /// <param name="c2">Input argument #4</param>
    /// <param name="Densityo">Input argument #5</param>
    /// <param name="FlowRes">Input argument #6</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] MeritCalc(int numArgsOut, MWArray BulkDensity, MWArray B, MWArray 
                         c1, MWArray c2, MWArray Densityo, MWArray FlowRes)
    {
      return mcr.EvaluateFunction(numArgsOut, "MeritCalc", BulkDensity, B, c1, c2, Densityo, FlowRes);
    }


    /// <summary>
    /// Provides the standard 7-input MWArray interface to the MeritCalc MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Density1=BulkDensity;      INSUNG
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="B">Input argument #2</param>
    /// <param name="c1">Input argument #3</param>
    /// <param name="c2">Input argument #4</param>
    /// <param name="Densityo">Input argument #5</param>
    /// <param name="FlowRes">Input argument #6</param>
    /// <param name="freq">Input argument #7</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] MeritCalc(int numArgsOut, MWArray BulkDensity, MWArray B, MWArray 
                         c1, MWArray c2, MWArray Densityo, MWArray FlowRes, MWArray freq)
    {
      return mcr.EvaluateFunction(numArgsOut, "MeritCalc", BulkDensity, B, c1, c2, Densityo, FlowRes, freq);
    }


    /// <summary>
    /// Provides the standard 8-input MWArray interface to the MeritCalc MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Density1=BulkDensity;      INSUNG
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="B">Input argument #2</param>
    /// <param name="c1">Input argument #3</param>
    /// <param name="c2">Input argument #4</param>
    /// <param name="Densityo">Input argument #5</param>
    /// <param name="FlowRes">Input argument #6</param>
    /// <param name="freq">Input argument #7</param>
    /// <param name="h">Input argument #8</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] MeritCalc(int numArgsOut, MWArray BulkDensity, MWArray B, MWArray 
                         c1, MWArray c2, MWArray Densityo, MWArray FlowRes, MWArray freq, 
                         MWArray h)
    {
      return mcr.EvaluateFunction(numArgsOut, "MeritCalc", BulkDensity, B, c1, c2, Densityo, FlowRes, freq, h);
    }


    /// <summary>
    /// Provides the standard 9-input MWArray interface to the MeritCalc MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Density1=BulkDensity;      INSUNG
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="B">Input argument #2</param>
    /// <param name="c1">Input argument #3</param>
    /// <param name="c2">Input argument #4</param>
    /// <param name="Densityo">Input argument #5</param>
    /// <param name="FlowRes">Input argument #6</param>
    /// <param name="freq">Input argument #7</param>
    /// <param name="h">Input argument #8</param>
    /// <param name="HeatRatio">Input argument #9</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] MeritCalc(int numArgsOut, MWArray BulkDensity, MWArray B, MWArray 
                         c1, MWArray c2, MWArray Densityo, MWArray FlowRes, MWArray freq, 
                         MWArray h, MWArray HeatRatio)
    {
      return mcr.EvaluateFunction(numArgsOut, "MeritCalc", BulkDensity, B, c1, c2, Densityo, FlowRes, freq, h, HeatRatio);
    }


    /// <summary>
    /// Provides the standard 10-input MWArray interface to the MeritCalc MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Density1=BulkDensity;      INSUNG
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="B">Input argument #2</param>
    /// <param name="c1">Input argument #3</param>
    /// <param name="c2">Input argument #4</param>
    /// <param name="Densityo">Input argument #5</param>
    /// <param name="FlowRes">Input argument #6</param>
    /// <param name="freq">Input argument #7</param>
    /// <param name="h">Input argument #8</param>
    /// <param name="HeatRatio">Input argument #9</param>
    /// <param name="ItaAir">Input argument #10</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] MeritCalc(int numArgsOut, MWArray BulkDensity, MWArray B, MWArray 
                         c1, MWArray c2, MWArray Densityo, MWArray FlowRes, MWArray freq, 
                         MWArray h, MWArray HeatRatio, MWArray ItaAir)
    {
      return mcr.EvaluateFunction(numArgsOut, "MeritCalc", BulkDensity, B, c1, c2, Densityo, FlowRes, freq, h, HeatRatio, ItaAir);
    }


    /// <summary>
    /// Provides the standard 11-input MWArray interface to the MeritCalc MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Density1=BulkDensity;      INSUNG
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="B">Input argument #2</param>
    /// <param name="c1">Input argument #3</param>
    /// <param name="c2">Input argument #4</param>
    /// <param name="Densityo">Input argument #5</param>
    /// <param name="FlowRes">Input argument #6</param>
    /// <param name="freq">Input argument #7</param>
    /// <param name="h">Input argument #8</param>
    /// <param name="HeatRatio">Input argument #9</param>
    /// <param name="ItaAir">Input argument #10</param>
    /// <param name="L">Input argument #11</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] MeritCalc(int numArgsOut, MWArray BulkDensity, MWArray B, MWArray 
                         c1, MWArray c2, MWArray Densityo, MWArray FlowRes, MWArray freq, 
                         MWArray h, MWArray HeatRatio, MWArray ItaAir, MWArray L)
    {
      return mcr.EvaluateFunction(numArgsOut, "MeritCalc", BulkDensity, B, c1, c2, Densityo, FlowRes, freq, h, HeatRatio, ItaAir, L);
    }


    /// <summary>
    /// Provides the standard 12-input MWArray interface to the MeritCalc MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Density1=BulkDensity;      INSUNG
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="B">Input argument #2</param>
    /// <param name="c1">Input argument #3</param>
    /// <param name="c2">Input argument #4</param>
    /// <param name="Densityo">Input argument #5</param>
    /// <param name="FlowRes">Input argument #6</param>
    /// <param name="freq">Input argument #7</param>
    /// <param name="h">Input argument #8</param>
    /// <param name="HeatRatio">Input argument #9</param>
    /// <param name="ItaAir">Input argument #10</param>
    /// <param name="L">Input argument #11</param>
    /// <param name="MAbsorption">Input argument #12</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] MeritCalc(int numArgsOut, MWArray BulkDensity, MWArray B, MWArray 
                         c1, MWArray c2, MWArray Densityo, MWArray FlowRes, MWArray freq, 
                         MWArray h, MWArray HeatRatio, MWArray ItaAir, MWArray L, MWArray 
                         MAbsorption)
    {
      return mcr.EvaluateFunction(numArgsOut, "MeritCalc", BulkDensity, B, c1, c2, Densityo, FlowRes, freq, h, HeatRatio, ItaAir, L, MAbsorption);
    }


    /// <summary>
    /// Provides the standard 13-input MWArray interface to the MeritCalc MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Density1=BulkDensity;      INSUNG
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="B">Input argument #2</param>
    /// <param name="c1">Input argument #3</param>
    /// <param name="c2">Input argument #4</param>
    /// <param name="Densityo">Input argument #5</param>
    /// <param name="FlowRes">Input argument #6</param>
    /// <param name="freq">Input argument #7</param>
    /// <param name="h">Input argument #8</param>
    /// <param name="HeatRatio">Input argument #9</param>
    /// <param name="ItaAir">Input argument #10</param>
    /// <param name="L">Input argument #11</param>
    /// <param name="MAbsorption">Input argument #12</param>
    /// <param name="Npr">Input argument #13</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] MeritCalc(int numArgsOut, MWArray BulkDensity, MWArray B, MWArray 
                         c1, MWArray c2, MWArray Densityo, MWArray FlowRes, MWArray freq, 
                         MWArray h, MWArray HeatRatio, MWArray ItaAir, MWArray L, MWArray 
                         MAbsorption, MWArray Npr)
    {
      return mcr.EvaluateFunction(numArgsOut, "MeritCalc", BulkDensity, B, c1, c2, Densityo, FlowRes, freq, h, HeatRatio, ItaAir, L, MAbsorption, Npr);
    }


    /// <summary>
    /// Provides the standard 14-input MWArray interface to the MeritCalc MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Density1=BulkDensity;      INSUNG
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="B">Input argument #2</param>
    /// <param name="c1">Input argument #3</param>
    /// <param name="c2">Input argument #4</param>
    /// <param name="Densityo">Input argument #5</param>
    /// <param name="FlowRes">Input argument #6</param>
    /// <param name="freq">Input argument #7</param>
    /// <param name="h">Input argument #8</param>
    /// <param name="HeatRatio">Input argument #9</param>
    /// <param name="ItaAir">Input argument #10</param>
    /// <param name="L">Input argument #11</param>
    /// <param name="MAbsorption">Input argument #12</param>
    /// <param name="Npr">Input argument #13</param>
    /// <param name="P0">Input argument #14</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] MeritCalc(int numArgsOut, MWArray BulkDensity, MWArray B, MWArray 
                         c1, MWArray c2, MWArray Densityo, MWArray FlowRes, MWArray freq, 
                         MWArray h, MWArray HeatRatio, MWArray ItaAir, MWArray L, MWArray 
                         MAbsorption, MWArray Npr, MWArray P0)
    {
      return mcr.EvaluateFunction(numArgsOut, "MeritCalc", BulkDensity, B, c1, c2, Densityo, FlowRes, freq, h, HeatRatio, ItaAir, L, MAbsorption, Npr, P0);
    }


    /// <summary>
    /// Provides the standard 15-input MWArray interface to the MeritCalc MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Density1=BulkDensity;      INSUNG
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="B">Input argument #2</param>
    /// <param name="c1">Input argument #3</param>
    /// <param name="c2">Input argument #4</param>
    /// <param name="Densityo">Input argument #5</param>
    /// <param name="FlowRes">Input argument #6</param>
    /// <param name="freq">Input argument #7</param>
    /// <param name="h">Input argument #8</param>
    /// <param name="HeatRatio">Input argument #9</param>
    /// <param name="ItaAir">Input argument #10</param>
    /// <param name="L">Input argument #11</param>
    /// <param name="MAbsorption">Input argument #12</param>
    /// <param name="Npr">Input argument #13</param>
    /// <param name="P0">Input argument #14</param>
    /// <param name="SFactor">Input argument #15</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] MeritCalc(int numArgsOut, MWArray BulkDensity, MWArray B, MWArray 
                         c1, MWArray c2, MWArray Densityo, MWArray FlowRes, MWArray freq, 
                         MWArray h, MWArray HeatRatio, MWArray ItaAir, MWArray L, MWArray 
                         MAbsorption, MWArray Npr, MWArray P0, MWArray SFactor)
    {
      return mcr.EvaluateFunction(numArgsOut, "MeritCalc", BulkDensity, B, c1, c2, Densityo, FlowRes, freq, h, HeatRatio, ItaAir, L, MAbsorption, Npr, P0, SFactor);
    }


    /// <summary>
    /// Provides the standard 16-input MWArray interface to the MeritCalc MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Density1=BulkDensity;      INSUNG
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="B">Input argument #2</param>
    /// <param name="c1">Input argument #3</param>
    /// <param name="c2">Input argument #4</param>
    /// <param name="Densityo">Input argument #5</param>
    /// <param name="FlowRes">Input argument #6</param>
    /// <param name="freq">Input argument #7</param>
    /// <param name="h">Input argument #8</param>
    /// <param name="HeatRatio">Input argument #9</param>
    /// <param name="ItaAir">Input argument #10</param>
    /// <param name="L">Input argument #11</param>
    /// <param name="MAbsorption">Input argument #12</param>
    /// <param name="Npr">Input argument #13</param>
    /// <param name="P0">Input argument #14</param>
    /// <param name="SFactor">Input argument #15</param>
    /// <param name="Z0">Input argument #16</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] MeritCalc(int numArgsOut, MWArray BulkDensity, MWArray B, MWArray 
                         c1, MWArray c2, MWArray Densityo, MWArray FlowRes, MWArray freq, 
                         MWArray h, MWArray HeatRatio, MWArray ItaAir, MWArray L, MWArray 
                         MAbsorption, MWArray Npr, MWArray P0, MWArray SFactor, MWArray 
                         Z0)
    {
      return mcr.EvaluateFunction(numArgsOut, "MeritCalc", BulkDensity, B, c1, c2, Densityo, FlowRes, freq, h, HeatRatio, ItaAir, L, MAbsorption, Npr, P0, SFactor, Z0);
    }


    /// <summary>
    /// Provides an interface for the MeritCalc function in which the input and output
    /// arguments are specified as an array of MWArrays.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// M-Documentation:
    /// Density1=BulkDensity;      INSUNG
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of MWArray output arguments</param>
    /// <param name= "argsIn">Array of MWArray input arguments</param>
    ///
    public void MeritCalc(int numArgsOut, ref MWArray[] argsOut, MWArray[] argsIn)
    {
      mcr.EvaluateFunction("MeritCalc", numArgsOut, ref argsOut, argsIn);
    }


    /// <summary>
    /// Provides a single output, 0-input MWArrayinterface to the PEElasticSolid MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Density1=BulkDensity;    INSUNG
    /// </remarks>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray PEElasticSolid()
    {
      return mcr.EvaluateFunction("PEElasticSolid", new MWArray[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input MWArrayinterface to the PEElasticSolid MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Density1=BulkDensity;    INSUNG
    /// </remarks>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray PEElasticSolid(MWArray BulkDensity)
    {
      return mcr.EvaluateFunction("PEElasticSolid", BulkDensity);
    }


    /// <summary>
    /// Provides a single output, 2-input MWArrayinterface to the PEElasticSolid MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Density1=BulkDensity;    INSUNG
    /// </remarks>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="L">Input argument #2</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray PEElasticSolid(MWArray BulkDensity, MWArray L)
    {
      return mcr.EvaluateFunction("PEElasticSolid", BulkDensity, L);
    }


    /// <summary>
    /// Provides a single output, 3-input MWArrayinterface to the PEElasticSolid MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Density1=BulkDensity;    INSUNG
    /// </remarks>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="L">Input argument #2</param>
    /// <param name="ResonanceFrequency">Input argument #3</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray PEElasticSolid(MWArray BulkDensity, MWArray L, MWArray 
                            ResonanceFrequency)
    {
      return mcr.EvaluateFunction("PEElasticSolid", BulkDensity, L, ResonanceFrequency);
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the PEElasticSolid MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Density1=BulkDensity;    INSUNG
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] PEElasticSolid(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "PEElasticSolid", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 1-input MWArray interface to the PEElasticSolid MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Density1=BulkDensity;    INSUNG
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] PEElasticSolid(int numArgsOut, MWArray BulkDensity)
    {
      return mcr.EvaluateFunction(numArgsOut, "PEElasticSolid", BulkDensity);
    }


    /// <summary>
    /// Provides the standard 2-input MWArray interface to the PEElasticSolid MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Density1=BulkDensity;    INSUNG
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="L">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] PEElasticSolid(int numArgsOut, MWArray BulkDensity, MWArray L)
    {
      return mcr.EvaluateFunction(numArgsOut, "PEElasticSolid", BulkDensity, L);
    }


    /// <summary>
    /// Provides the standard 3-input MWArray interface to the PEElasticSolid MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Density1=BulkDensity;    INSUNG
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="L">Input argument #2</param>
    /// <param name="ResonanceFrequency">Input argument #3</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] PEElasticSolid(int numArgsOut, MWArray BulkDensity, MWArray L, 
                              MWArray ResonanceFrequency)
    {
      return mcr.EvaluateFunction(numArgsOut, "PEElasticSolid", BulkDensity, L, ResonanceFrequency);
    }


    /// <summary>
    /// Provides an interface for the PEElasticSolid function in which the input and
    /// output
    /// arguments are specified as an array of MWArrays.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// M-Documentation:
    /// Density1=BulkDensity;    INSUNG
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of MWArray output arguments</param>
    /// <param name= "argsIn">Array of MWArray input arguments</param>
    ///
    public void PEElasticSolid(int numArgsOut, ref MWArray[] argsOut, MWArray[] argsIn)
    {
      mcr.EvaluateFunction("PEElasticSolid", numArgsOut, ref argsOut, argsIn);
    }


    /// <summary>
    /// Provides a single output, 0-input MWArrayinterface to the PolyFitting MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray PolyFitting()
    {
      return mcr.EvaluateFunction("PolyFitting", new MWArray[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input MWArrayinterface to the PolyFitting MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="DataSampled">Input argument #1</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray PolyFitting(MWArray DataSampled)
    {
      return mcr.EvaluateFunction("PolyFitting", DataSampled);
    }


    /// <summary>
    /// Provides a single output, 2-input MWArrayinterface to the PolyFitting MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="DataSampled">Input argument #1</param>
    /// <param name="FrequencyFitted">Input argument #2</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray PolyFitting(MWArray DataSampled, MWArray FrequencyFitted)
    {
      return mcr.EvaluateFunction("PolyFitting", DataSampled, FrequencyFitted);
    }


    /// <summary>
    /// Provides a single output, 3-input MWArrayinterface to the PolyFitting MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="DataSampled">Input argument #1</param>
    /// <param name="FrequencyFitted">Input argument #2</param>
    /// <param name="FrequencySampled">Input argument #3</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray PolyFitting(MWArray DataSampled, MWArray FrequencyFitted, MWArray 
                         FrequencySampled)
    {
      return mcr.EvaluateFunction("PolyFitting", DataSampled, FrequencyFitted, FrequencySampled);
    }


    /// <summary>
    /// Provides a single output, 4-input MWArrayinterface to the PolyFitting MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="DataSampled">Input argument #1</param>
    /// <param name="FrequencyFitted">Input argument #2</param>
    /// <param name="FrequencySampled">Input argument #3</param>
    /// <param name="n">Input argument #4</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray PolyFitting(MWArray DataSampled, MWArray FrequencyFitted, MWArray 
                         FrequencySampled, MWArray n)
    {
      return mcr.EvaluateFunction("PolyFitting", DataSampled, FrequencyFitted, FrequencySampled, n);
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the PolyFitting MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] PolyFitting(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "PolyFitting", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 1-input MWArray interface to the PolyFitting MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="DataSampled">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] PolyFitting(int numArgsOut, MWArray DataSampled)
    {
      return mcr.EvaluateFunction(numArgsOut, "PolyFitting", DataSampled);
    }


    /// <summary>
    /// Provides the standard 2-input MWArray interface to the PolyFitting MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="DataSampled">Input argument #1</param>
    /// <param name="FrequencyFitted">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] PolyFitting(int numArgsOut, MWArray DataSampled, MWArray 
                           FrequencyFitted)
    {
      return mcr.EvaluateFunction(numArgsOut, "PolyFitting", DataSampled, FrequencyFitted);
    }


    /// <summary>
    /// Provides the standard 3-input MWArray interface to the PolyFitting MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="DataSampled">Input argument #1</param>
    /// <param name="FrequencyFitted">Input argument #2</param>
    /// <param name="FrequencySampled">Input argument #3</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] PolyFitting(int numArgsOut, MWArray DataSampled, MWArray 
                           FrequencyFitted, MWArray FrequencySampled)
    {
      return mcr.EvaluateFunction(numArgsOut, "PolyFitting", DataSampled, FrequencyFitted, FrequencySampled);
    }


    /// <summary>
    /// Provides the standard 4-input MWArray interface to the PolyFitting MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="DataSampled">Input argument #1</param>
    /// <param name="FrequencyFitted">Input argument #2</param>
    /// <param name="FrequencySampled">Input argument #3</param>
    /// <param name="n">Input argument #4</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] PolyFitting(int numArgsOut, MWArray DataSampled, MWArray 
                           FrequencyFitted, MWArray FrequencySampled, MWArray n)
    {
      return mcr.EvaluateFunction(numArgsOut, "PolyFitting", DataSampled, FrequencyFitted, FrequencySampled, n);
    }


    /// <summary>
    /// Provides an interface for the PolyFitting function in which the input and output
    /// arguments are specified as an array of MWArrays.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of MWArray output arguments</param>
    /// <param name= "argsIn">Array of MWArray input arguments</param>
    ///
    public void PolyFitting(int numArgsOut, ref MWArray[] argsOut, MWArray[] argsIn)
    {
      mcr.EvaluateFunction("PolyFitting", numArgsOut, ref argsOut, argsIn);
    }



    /// <summary>
    /// This method will cause a MATLAB figure window to behave as a modal dialog box.
    /// The method will not return until all the figure windows associated with this
    /// component have been closed.
    /// </summary>
    /// <remarks>
    /// An application should only call this method when required to keep the
    /// MATLAB figure window from disappearing.  Other techniques, such as calling
    /// Console.ReadLine() from the application should be considered where
    /// possible.</remarks>
    ///
    public void WaitForFiguresToDie()
    {
      mcr.WaitForFiguresToDie();
    }



    #endregion Methods

    #region Class Members

    private static MWMCR mcr= null;

    private static Exception ex_= null;

    private bool disposed= false;

    #endregion Class Members
  }
}
