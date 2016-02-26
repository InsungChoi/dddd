/*
* MATLAB Compiler: 4.15 (R2011a)
* Date: Fri Feb 26 21:44:40 2016
* Arguments: "-B" "macro_default" "-W" "dotnet:MPETest,test,0.0,private" "-T" "link:lib"
* "-d" "C:\Users\Shi Hyoseok\Documents\GitHub\Seoul University
* Honus\dddd\HONUS\Matlabresurce\MPE\MPETest\src" "-w" "enable:specified_file_mismatch"
* "-w" "enable:repeated_file" "-w" "enable:switch_ignored" "-w"
* "enable:missing_lib_sentinel" "-w" "enable:demo_license" "-v" "class{test:C:\Users\Shi
* Hyoseok\Documents\GitHub\Seoul University
* Honus\dddd\HONUS\Matlabresurce\MPE\APFibrous5para.m,C:\Users\Shi
* Hyoseok\Documents\GitHub\Seoul University
* Honus\dddd\HONUS\Matlabresurce\MPE\ElasticMeritCalc.m,C:\Users\Shi
* Hyoseok\Documents\GitHub\Seoul University
* Honus\dddd\HONUS\Matlabresurce\MPE\MeritCalc.m,C:\Users\Shi
* Hyoseok\Documents\GitHub\Seoul University
* Honus\dddd\HONUS\Matlabresurce\MPE\PEElasticSolid.m,C:\Users\Shi
* Hyoseok\Documents\GitHub\Seoul University
* Honus\dddd\HONUS\Matlabresurce\MPE\PolyFitting.m}" 
*/
using System;
using System.Reflection;
using System.IO;
using MathWorks.MATLAB.NET.Arrays;
using MathWorks.MATLAB.NET.Utility;

#if SHARED
[assembly: System.Reflection.AssemblyKeyFile(@"")]
#endif

namespace MPETestNative
{

  /// <summary>
  /// The test class provides a CLS compliant, Object (native) interface to the
  /// M-functions contained in the files:
  /// <newpara></newpara>
  /// C:\Users\Shi Hyoseok\Documents\GitHub\Seoul University
  /// Honus\dddd\HONUS\Matlabresurce\MPE\APFibrous5para.m
  /// <newpara></newpara>
  /// C:\Users\Shi Hyoseok\Documents\GitHub\Seoul University
  /// Honus\dddd\HONUS\Matlabresurce\MPE\ElasticMeritCalc.m
  /// <newpara></newpara>
  /// C:\Users\Shi Hyoseok\Documents\GitHub\Seoul University
  /// Honus\dddd\HONUS\Matlabresurce\MPE\MeritCalc.m
  /// <newpara></newpara>
  /// C:\Users\Shi Hyoseok\Documents\GitHub\Seoul University
  /// Honus\dddd\HONUS\Matlabresurce\MPE\PEElasticSolid.m
  /// <newpara></newpara>
  /// C:\Users\Shi Hyoseok\Documents\GitHub\Seoul University
  /// Honus\dddd\HONUS\Matlabresurce\MPE\PolyFitting.m
  /// <newpara></newpara>
  /// deployprint.m
  /// <newpara></newpara>
  /// printdlg.m
  /// </summary>
  /// <remarks>
  /// @Version 0.0
  /// </remarks>
  public class test : IDisposable
  {
    #region Constructors

    /// <summary internal= "true">
    /// The static constructor instantiates and initializes the MATLAB Compiler Runtime
    /// instance.
    /// </summary>
    static test()
    {
      if (MWMCR.MCRAppInitialized)
      {
        Assembly assembly= Assembly.GetExecutingAssembly();

        string ctfFilePath= assembly.Location;

        int lastDelimiter= ctfFilePath.LastIndexOf(@"\");

        ctfFilePath= ctfFilePath.Remove(lastDelimiter, (ctfFilePath.Length - lastDelimiter));

        string ctfFileName = "MPETest.ctf";

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
      else
      {
        throw new ApplicationException("MWArray assembly could not be initialized");
      }
    }


    /// <summary>
    /// Constructs a new instance of the test class.
    /// </summary>
    public test()
    {
    }


    #endregion Constructors

    #region Finalize

    /// <summary internal= "true">
    /// Class destructor called by the CLR garbage collector.
    /// </summary>
    ~test()
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
    /// Provides a single output, 0-input Objectinterface to the APFibrous5para
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object APFibrous5para()
    {
      return mcr.EvaluateFunction("APFibrous5para", new Object[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input Objectinterface to the APFibrous5para
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="B">Input argument #1</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object APFibrous5para(Object B)
    {
      return mcr.EvaluateFunction("APFibrous5para", B);
    }


    /// <summary>
    /// Provides a single output, 2-input Objectinterface to the APFibrous5para
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="B">Input argument #1</param>
    /// <param name="c1">Input argument #2</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object APFibrous5para(Object B, Object c1)
    {
      return mcr.EvaluateFunction("APFibrous5para", B, c1);
    }


    /// <summary>
    /// Provides a single output, 3-input Objectinterface to the APFibrous5para
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="B">Input argument #1</param>
    /// <param name="c1">Input argument #2</param>
    /// <param name="c2">Input argument #3</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object APFibrous5para(Object B, Object c1, Object c2)
    {
      return mcr.EvaluateFunction("APFibrous5para", B, c1, c2);
    }


    /// <summary>
    /// Provides a single output, 4-input Objectinterface to the APFibrous5para
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="B">Input argument #1</param>
    /// <param name="c1">Input argument #2</param>
    /// <param name="c2">Input argument #3</param>
    /// <param name="Density1">Input argument #4</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object APFibrous5para(Object B, Object c1, Object c2, Object Density1)
    {
      return mcr.EvaluateFunction("APFibrous5para", B, c1, c2, Density1);
    }


    /// <summary>
    /// Provides a single output, 5-input Objectinterface to the APFibrous5para
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="B">Input argument #1</param>
    /// <param name="c1">Input argument #2</param>
    /// <param name="c2">Input argument #3</param>
    /// <param name="Density1">Input argument #4</param>
    /// <param name="Densityo">Input argument #5</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object APFibrous5para(Object B, Object c1, Object c2, Object Density1, Object 
                           Densityo)
    {
      return mcr.EvaluateFunction("APFibrous5para", B, c1, c2, Density1, Densityo);
    }


    /// <summary>
    /// Provides a single output, 6-input Objectinterface to the APFibrous5para
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="B">Input argument #1</param>
    /// <param name="c1">Input argument #2</param>
    /// <param name="c2">Input argument #3</param>
    /// <param name="Density1">Input argument #4</param>
    /// <param name="Densityo">Input argument #5</param>
    /// <param name="FlowRes">Input argument #6</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object APFibrous5para(Object B, Object c1, Object c2, Object Density1, Object 
                           Densityo, Object FlowRes)
    {
      return mcr.EvaluateFunction("APFibrous5para", B, c1, c2, Density1, Densityo, FlowRes);
    }


    /// <summary>
    /// Provides a single output, 7-input Objectinterface to the APFibrous5para
    /// M-function.
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
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object APFibrous5para(Object B, Object c1, Object c2, Object Density1, Object 
                           Densityo, Object FlowRes, Object fre)
    {
      return mcr.EvaluateFunction("APFibrous5para", B, c1, c2, Density1, Densityo, FlowRes, fre);
    }


    /// <summary>
    /// Provides a single output, 8-input Objectinterface to the APFibrous5para
    /// M-function.
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
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object APFibrous5para(Object B, Object c1, Object c2, Object Density1, Object 
                           Densityo, Object FlowRes, Object fre, Object h)
    {
      return mcr.EvaluateFunction("APFibrous5para", B, c1, c2, Density1, Densityo, FlowRes, fre, h);
    }


    /// <summary>
    /// Provides a single output, 9-input Objectinterface to the APFibrous5para
    /// M-function.
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
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object APFibrous5para(Object B, Object c1, Object c2, Object Density1, Object 
                           Densityo, Object FlowRes, Object fre, Object h, Object 
                           HeatRatio)
    {
      return mcr.EvaluateFunction("APFibrous5para", B, c1, c2, Density1, Densityo, FlowRes, fre, h, HeatRatio);
    }


    /// <summary>
    /// Provides a single output, 10-input Objectinterface to the APFibrous5para
    /// M-function.
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
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object APFibrous5para(Object B, Object c1, Object c2, Object Density1, Object 
                           Densityo, Object FlowRes, Object fre, Object h, Object 
                           HeatRatio, Object ItaAir)
    {
      return mcr.EvaluateFunction("APFibrous5para", B, c1, c2, Density1, Densityo, FlowRes, fre, h, HeatRatio, ItaAir);
    }


    /// <summary>
    /// Provides a single output, 11-input Objectinterface to the APFibrous5para
    /// M-function.
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
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object APFibrous5para(Object B, Object c1, Object c2, Object Density1, Object 
                           Densityo, Object FlowRes, Object fre, Object h, Object 
                           HeatRatio, Object ItaAir, Object L)
    {
      return mcr.EvaluateFunction("APFibrous5para", B, c1, c2, Density1, Densityo, FlowRes, fre, h, HeatRatio, ItaAir, L);
    }


    /// <summary>
    /// Provides a single output, 12-input Objectinterface to the APFibrous5para
    /// M-function.
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
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object APFibrous5para(Object B, Object c1, Object c2, Object Density1, Object 
                           Densityo, Object FlowRes, Object fre, Object h, Object 
                           HeatRatio, Object ItaAir, Object L, Object Npr)
    {
      return mcr.EvaluateFunction("APFibrous5para", B, c1, c2, Density1, Densityo, FlowRes, fre, h, HeatRatio, ItaAir, L, Npr);
    }


    /// <summary>
    /// Provides a single output, 13-input Objectinterface to the APFibrous5para
    /// M-function.
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
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object APFibrous5para(Object B, Object c1, Object c2, Object Density1, Object 
                           Densityo, Object FlowRes, Object fre, Object h, Object 
                           HeatRatio, Object ItaAir, Object L, Object Npr, Object P0)
    {
      return mcr.EvaluateFunction("APFibrous5para", B, c1, c2, Density1, Densityo, FlowRes, fre, h, HeatRatio, ItaAir, L, Npr, P0);
    }


    /// <summary>
    /// Provides a single output, 14-input Objectinterface to the APFibrous5para
    /// M-function.
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
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object APFibrous5para(Object B, Object c1, Object c2, Object Density1, Object 
                           Densityo, Object FlowRes, Object fre, Object h, Object 
                           HeatRatio, Object ItaAir, Object L, Object Npr, Object P0, 
                           Object SFactor)
    {
      return mcr.EvaluateFunction("APFibrous5para", B, c1, c2, Density1, Densityo, FlowRes, fre, h, HeatRatio, ItaAir, L, Npr, P0, SFactor);
    }


    /// <summary>
    /// Provides a single output, 15-input Objectinterface to the APFibrous5para
    /// M-function.
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
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object APFibrous5para(Object B, Object c1, Object c2, Object Density1, Object 
                           Densityo, Object FlowRes, Object fre, Object h, Object 
                           HeatRatio, Object ItaAir, Object L, Object Npr, Object P0, 
                           Object SFactor, Object Z0)
    {
      return mcr.EvaluateFunction("APFibrous5para", B, c1, c2, Density1, Densityo, FlowRes, fre, h, HeatRatio, ItaAir, L, Npr, P0, SFactor, Z0);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the APFibrous5para M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] APFibrous5para(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "APFibrous5para", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the APFibrous5para M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="B">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] APFibrous5para(int numArgsOut, Object B)
    {
      return mcr.EvaluateFunction(numArgsOut, "APFibrous5para", B);
    }


    /// <summary>
    /// Provides the standard 2-input Object interface to the APFibrous5para M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="B">Input argument #1</param>
    /// <param name="c1">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] APFibrous5para(int numArgsOut, Object B, Object c1)
    {
      return mcr.EvaluateFunction(numArgsOut, "APFibrous5para", B, c1);
    }


    /// <summary>
    /// Provides the standard 3-input Object interface to the APFibrous5para M-function.
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
    public Object[] APFibrous5para(int numArgsOut, Object B, Object c1, Object c2)
    {
      return mcr.EvaluateFunction(numArgsOut, "APFibrous5para", B, c1, c2);
    }


    /// <summary>
    /// Provides the standard 4-input Object interface to the APFibrous5para M-function.
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
    public Object[] APFibrous5para(int numArgsOut, Object B, Object c1, Object c2, Object 
                             Density1)
    {
      return mcr.EvaluateFunction(numArgsOut, "APFibrous5para", B, c1, c2, Density1);
    }


    /// <summary>
    /// Provides the standard 5-input Object interface to the APFibrous5para M-function.
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
    public Object[] APFibrous5para(int numArgsOut, Object B, Object c1, Object c2, Object 
                             Density1, Object Densityo)
    {
      return mcr.EvaluateFunction(numArgsOut, "APFibrous5para", B, c1, c2, Density1, Densityo);
    }


    /// <summary>
    /// Provides the standard 6-input Object interface to the APFibrous5para M-function.
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
    public Object[] APFibrous5para(int numArgsOut, Object B, Object c1, Object c2, Object 
                             Density1, Object Densityo, Object FlowRes)
    {
      return mcr.EvaluateFunction(numArgsOut, "APFibrous5para", B, c1, c2, Density1, Densityo, FlowRes);
    }


    /// <summary>
    /// Provides the standard 7-input Object interface to the APFibrous5para M-function.
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
    public Object[] APFibrous5para(int numArgsOut, Object B, Object c1, Object c2, Object 
                             Density1, Object Densityo, Object FlowRes, Object fre)
    {
      return mcr.EvaluateFunction(numArgsOut, "APFibrous5para", B, c1, c2, Density1, Densityo, FlowRes, fre);
    }


    /// <summary>
    /// Provides the standard 8-input Object interface to the APFibrous5para M-function.
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
    public Object[] APFibrous5para(int numArgsOut, Object B, Object c1, Object c2, Object 
                             Density1, Object Densityo, Object FlowRes, Object fre, 
                             Object h)
    {
      return mcr.EvaluateFunction(numArgsOut, "APFibrous5para", B, c1, c2, Density1, Densityo, FlowRes, fre, h);
    }


    /// <summary>
    /// Provides the standard 9-input Object interface to the APFibrous5para M-function.
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
    public Object[] APFibrous5para(int numArgsOut, Object B, Object c1, Object c2, Object 
                             Density1, Object Densityo, Object FlowRes, Object fre, 
                             Object h, Object HeatRatio)
    {
      return mcr.EvaluateFunction(numArgsOut, "APFibrous5para", B, c1, c2, Density1, Densityo, FlowRes, fre, h, HeatRatio);
    }


    /// <summary>
    /// Provides the standard 10-input Object interface to the APFibrous5para M-function.
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
    public Object[] APFibrous5para(int numArgsOut, Object B, Object c1, Object c2, Object 
                             Density1, Object Densityo, Object FlowRes, Object fre, 
                             Object h, Object HeatRatio, Object ItaAir)
    {
      return mcr.EvaluateFunction(numArgsOut, "APFibrous5para", B, c1, c2, Density1, Densityo, FlowRes, fre, h, HeatRatio, ItaAir);
    }


    /// <summary>
    /// Provides the standard 11-input Object interface to the APFibrous5para M-function.
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
    public Object[] APFibrous5para(int numArgsOut, Object B, Object c1, Object c2, Object 
                             Density1, Object Densityo, Object FlowRes, Object fre, 
                             Object h, Object HeatRatio, Object ItaAir, Object L)
    {
      return mcr.EvaluateFunction(numArgsOut, "APFibrous5para", B, c1, c2, Density1, Densityo, FlowRes, fre, h, HeatRatio, ItaAir, L);
    }


    /// <summary>
    /// Provides the standard 12-input Object interface to the APFibrous5para M-function.
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
    public Object[] APFibrous5para(int numArgsOut, Object B, Object c1, Object c2, Object 
                             Density1, Object Densityo, Object FlowRes, Object fre, 
                             Object h, Object HeatRatio, Object ItaAir, Object L, Object 
                             Npr)
    {
      return mcr.EvaluateFunction(numArgsOut, "APFibrous5para", B, c1, c2, Density1, Densityo, FlowRes, fre, h, HeatRatio, ItaAir, L, Npr);
    }


    /// <summary>
    /// Provides the standard 13-input Object interface to the APFibrous5para M-function.
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
    public Object[] APFibrous5para(int numArgsOut, Object B, Object c1, Object c2, Object 
                             Density1, Object Densityo, Object FlowRes, Object fre, 
                             Object h, Object HeatRatio, Object ItaAir, Object L, Object 
                             Npr, Object P0)
    {
      return mcr.EvaluateFunction(numArgsOut, "APFibrous5para", B, c1, c2, Density1, Densityo, FlowRes, fre, h, HeatRatio, ItaAir, L, Npr, P0);
    }


    /// <summary>
    /// Provides the standard 14-input Object interface to the APFibrous5para M-function.
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
    public Object[] APFibrous5para(int numArgsOut, Object B, Object c1, Object c2, Object 
                             Density1, Object Densityo, Object FlowRes, Object fre, 
                             Object h, Object HeatRatio, Object ItaAir, Object L, Object 
                             Npr, Object P0, Object SFactor)
    {
      return mcr.EvaluateFunction(numArgsOut, "APFibrous5para", B, c1, c2, Density1, Densityo, FlowRes, fre, h, HeatRatio, ItaAir, L, Npr, P0, SFactor);
    }


    /// <summary>
    /// Provides the standard 15-input Object interface to the APFibrous5para M-function.
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
    public Object[] APFibrous5para(int numArgsOut, Object B, Object c1, Object c2, Object 
                             Density1, Object Densityo, Object FlowRes, Object fre, 
                             Object h, Object HeatRatio, Object ItaAir, Object L, Object 
                             Npr, Object P0, Object SFactor, Object Z0)
    {
      return mcr.EvaluateFunction(numArgsOut, "APFibrous5para", B, c1, c2, Density1, Densityo, FlowRes, fre, h, HeatRatio, ItaAir, L, Npr, P0, SFactor, Z0);
    }


    /// <summary>
    /// Provides an interface for the APFibrous5para function in which the input and
    /// output
    /// arguments are specified as an array of Objects.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of Object output arguments</param>
    /// <param name= "argsIn">Array of Object input arguments</param>
    /// <param name= "varArgsIn">Array of Object representing variable input
    /// arguments</param>
    ///
    [MATLABSignature("APFibrous5para", 15, 1, 0)]
    protected void APFibrous5para(int numArgsOut, ref Object[] argsOut, Object[] argsIn, params Object[] varArgsIn)
    {
        mcr.EvaluateFunctionForTypeSafeCall("APFibrous5para", numArgsOut, ref argsOut, argsIn, varArgsIn);
    }
    /// <summary>
    /// Provides a single output, 0-input Objectinterface to the ElasticMeritCalc
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// SurfaceImpedance=abs(Z);
    /// </remarks>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object ElasticMeritCalc()
    {
      return mcr.EvaluateFunction("ElasticMeritCalc", new Object[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input Objectinterface to the ElasticMeritCalc
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// SurfaceImpedance=abs(Z);
    /// </remarks>
    /// <param name="c">Input argument #1</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object ElasticMeritCalc(Object c)
    {
      return mcr.EvaluateFunction("ElasticMeritCalc", c);
    }


    /// <summary>
    /// Provides a single output, 2-input Objectinterface to the ElasticMeritCalc
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// SurfaceImpedance=abs(Z);
    /// </remarks>
    /// <param name="c">Input argument #1</param>
    /// <param name="c1">Input argument #2</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object ElasticMeritCalc(Object c, Object c1)
    {
      return mcr.EvaluateFunction("ElasticMeritCalc", c, c1);
    }


    /// <summary>
    /// Provides a single output, 3-input Objectinterface to the ElasticMeritCalc
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// SurfaceImpedance=abs(Z);
    /// </remarks>
    /// <param name="c">Input argument #1</param>
    /// <param name="c1">Input argument #2</param>
    /// <param name="c2">Input argument #3</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object ElasticMeritCalc(Object c, Object c1, Object c2)
    {
      return mcr.EvaluateFunction("ElasticMeritCalc", c, c1, c2);
    }


    /// <summary>
    /// Provides a single output, 4-input Objectinterface to the ElasticMeritCalc
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// SurfaceImpedance=abs(Z);
    /// </remarks>
    /// <param name="c">Input argument #1</param>
    /// <param name="c1">Input argument #2</param>
    /// <param name="c2">Input argument #3</param>
    /// <param name="Density1">Input argument #4</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object ElasticMeritCalc(Object c, Object c1, Object c2, Object Density1)
    {
      return mcr.EvaluateFunction("ElasticMeritCalc", c, c1, c2, Density1);
    }


    /// <summary>
    /// Provides a single output, 5-input Objectinterface to the ElasticMeritCalc
    /// M-function.
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
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object ElasticMeritCalc(Object c, Object c1, Object c2, Object Density1, 
                             Object DensityA)
    {
      return mcr.EvaluateFunction("ElasticMeritCalc", c, c1, c2, Density1, DensityA);
    }


    /// <summary>
    /// Provides a single output, 6-input Objectinterface to the ElasticMeritCalc
    /// M-function.
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
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object ElasticMeritCalc(Object c, Object c1, Object c2, Object Density1, 
                             Object DensityA, Object Densityo)
    {
      return mcr.EvaluateFunction("ElasticMeritCalc", c, c1, c2, Density1, DensityA, Densityo);
    }


    /// <summary>
    /// Provides a single output, 7-input Objectinterface to the ElasticMeritCalc
    /// M-function.
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
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object ElasticMeritCalc(Object c, Object c1, Object c2, Object Density1, 
                             Object DensityA, Object Densityo, Object Em)
    {
      return mcr.EvaluateFunction("ElasticMeritCalc", c, c1, c2, Density1, DensityA, Densityo, Em);
    }


    /// <summary>
    /// Provides a single output, 8-input Objectinterface to the ElasticMeritCalc
    /// M-function.
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
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object ElasticMeritCalc(Object c, Object c1, Object c2, Object Density1, 
                             Object DensityA, Object Densityo, Object Em, Object FlowRes)
    {
      return mcr.EvaluateFunction("ElasticMeritCalc", c, c1, c2, Density1, DensityA, Densityo, Em, FlowRes);
    }


    /// <summary>
    /// Provides a single output, 9-input Objectinterface to the ElasticMeritCalc
    /// M-function.
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
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object ElasticMeritCalc(Object c, Object c1, Object c2, Object Density1, 
                             Object DensityA, Object Densityo, Object Em, Object FlowRes, 
                             Object freq)
    {
      return mcr.EvaluateFunction("ElasticMeritCalc", c, c1, c2, Density1, DensityA, Densityo, Em, FlowRes, freq);
    }


    /// <summary>
    /// Provides a single output, 10-input Objectinterface to the ElasticMeritCalc
    /// M-function.
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
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object ElasticMeritCalc(Object c, Object c1, Object c2, Object Density1, 
                             Object DensityA, Object Densityo, Object Em, Object FlowRes, 
                             Object freq, Object h)
    {
      return mcr.EvaluateFunction("ElasticMeritCalc", c, c1, c2, Density1, DensityA, Densityo, Em, FlowRes, freq, h);
    }


    /// <summary>
    /// Provides a single output, 11-input Objectinterface to the ElasticMeritCalc
    /// M-function.
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
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object ElasticMeritCalc(Object c, Object c1, Object c2, Object Density1, 
                             Object DensityA, Object Densityo, Object Em, Object FlowRes, 
                             Object freq, Object h, Object HeatRatio)
    {
      return mcr.EvaluateFunction("ElasticMeritCalc", c, c1, c2, Density1, DensityA, Densityo, Em, FlowRes, freq, h, HeatRatio);
    }


    /// <summary>
    /// Provides a single output, 12-input Objectinterface to the ElasticMeritCalc
    /// M-function.
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
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object ElasticMeritCalc(Object c, Object c1, Object c2, Object Density1, 
                             Object DensityA, Object Densityo, Object Em, Object FlowRes, 
                             Object freq, Object h, Object HeatRatio, Object L)
    {
      return mcr.EvaluateFunction("ElasticMeritCalc", c, c1, c2, Density1, DensityA, Densityo, Em, FlowRes, freq, h, HeatRatio, L);
    }


    /// <summary>
    /// Provides a single output, 13-input Objectinterface to the ElasticMeritCalc
    /// M-function.
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
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object ElasticMeritCalc(Object c, Object c1, Object c2, Object Density1, 
                             Object DensityA, Object Densityo, Object Em, Object FlowRes, 
                             Object freq, Object h, Object HeatRatio, Object L, Object 
                             LFactor)
    {
      return mcr.EvaluateFunction("ElasticMeritCalc", c, c1, c2, Density1, DensityA, Densityo, Em, FlowRes, freq, h, HeatRatio, L, LFactor);
    }


    /// <summary>
    /// Provides a single output, 14-input Objectinterface to the ElasticMeritCalc
    /// M-function.
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
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object ElasticMeritCalc(Object c, Object c1, Object c2, Object Density1, 
                             Object DensityA, Object Densityo, Object Em, Object FlowRes, 
                             Object freq, Object h, Object HeatRatio, Object L, Object 
                             LFactor, Object MeasuredAbsorption)
    {
      return mcr.EvaluateFunction("ElasticMeritCalc", c, c1, c2, Density1, DensityA, Densityo, Em, FlowRes, freq, h, HeatRatio, L, LFactor, MeasuredAbsorption);
    }


    /// <summary>
    /// Provides a single output, 15-input Objectinterface to the ElasticMeritCalc
    /// M-function.
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
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object ElasticMeritCalc(Object c, Object c1, Object c2, Object Density1, 
                             Object DensityA, Object Densityo, Object Em, Object FlowRes, 
                             Object freq, Object h, Object HeatRatio, Object L, Object 
                             LFactor, Object MeasuredAbsorption, Object Npr)
    {
      return mcr.EvaluateFunction("ElasticMeritCalc", c, c1, c2, Density1, DensityA, Densityo, Em, FlowRes, freq, h, HeatRatio, L, LFactor, MeasuredAbsorption, Npr);
    }


    /// <summary>
    /// Provides a single output, 16-input Objectinterface to the ElasticMeritCalc
    /// M-function.
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
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object ElasticMeritCalc(Object c, Object c1, Object c2, Object Density1, 
                             Object DensityA, Object Densityo, Object Em, Object FlowRes, 
                             Object freq, Object h, Object HeatRatio, Object L, Object 
                             LFactor, Object MeasuredAbsorption, Object Npr, Object 
                             PRatio)
    {
      return mcr.EvaluateFunction("ElasticMeritCalc", c, c1, c2, Density1, DensityA, Densityo, Em, FlowRes, freq, h, HeatRatio, L, LFactor, MeasuredAbsorption, Npr, PRatio);
    }


    /// <summary>
    /// Provides a single output, 17-input Objectinterface to the ElasticMeritCalc
    /// M-function.
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
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object ElasticMeritCalc(Object c, Object c1, Object c2, Object Density1, 
                             Object DensityA, Object Densityo, Object Em, Object FlowRes, 
                             Object freq, Object h, Object HeatRatio, Object L, Object 
                             LFactor, Object MeasuredAbsorption, Object Npr, Object 
                             PRatio, Object SFactor)
    {
      return mcr.EvaluateFunction("ElasticMeritCalc", c, c1, c2, Density1, DensityA, Densityo, Em, FlowRes, freq, h, HeatRatio, L, LFactor, MeasuredAbsorption, Npr, PRatio, SFactor);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the ElasticMeritCalc
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// SurfaceImpedance=abs(Z);
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] ElasticMeritCalc(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "ElasticMeritCalc", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the ElasticMeritCalc
    /// M-function.
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
    public Object[] ElasticMeritCalc(int numArgsOut, Object c)
    {
      return mcr.EvaluateFunction(numArgsOut, "ElasticMeritCalc", c);
    }


    /// <summary>
    /// Provides the standard 2-input Object interface to the ElasticMeritCalc
    /// M-function.
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
    public Object[] ElasticMeritCalc(int numArgsOut, Object c, Object c1)
    {
      return mcr.EvaluateFunction(numArgsOut, "ElasticMeritCalc", c, c1);
    }


    /// <summary>
    /// Provides the standard 3-input Object interface to the ElasticMeritCalc
    /// M-function.
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
    public Object[] ElasticMeritCalc(int numArgsOut, Object c, Object c1, Object c2)
    {
      return mcr.EvaluateFunction(numArgsOut, "ElasticMeritCalc", c, c1, c2);
    }


    /// <summary>
    /// Provides the standard 4-input Object interface to the ElasticMeritCalc
    /// M-function.
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
    public Object[] ElasticMeritCalc(int numArgsOut, Object c, Object c1, Object c2, 
                               Object Density1)
    {
      return mcr.EvaluateFunction(numArgsOut, "ElasticMeritCalc", c, c1, c2, Density1);
    }


    /// <summary>
    /// Provides the standard 5-input Object interface to the ElasticMeritCalc
    /// M-function.
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
    public Object[] ElasticMeritCalc(int numArgsOut, Object c, Object c1, Object c2, 
                               Object Density1, Object DensityA)
    {
      return mcr.EvaluateFunction(numArgsOut, "ElasticMeritCalc", c, c1, c2, Density1, DensityA);
    }


    /// <summary>
    /// Provides the standard 6-input Object interface to the ElasticMeritCalc
    /// M-function.
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
    public Object[] ElasticMeritCalc(int numArgsOut, Object c, Object c1, Object c2, 
                               Object Density1, Object DensityA, Object Densityo)
    {
      return mcr.EvaluateFunction(numArgsOut, "ElasticMeritCalc", c, c1, c2, Density1, DensityA, Densityo);
    }


    /// <summary>
    /// Provides the standard 7-input Object interface to the ElasticMeritCalc
    /// M-function.
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
    public Object[] ElasticMeritCalc(int numArgsOut, Object c, Object c1, Object c2, 
                               Object Density1, Object DensityA, Object Densityo, Object 
                               Em)
    {
      return mcr.EvaluateFunction(numArgsOut, "ElasticMeritCalc", c, c1, c2, Density1, DensityA, Densityo, Em);
    }


    /// <summary>
    /// Provides the standard 8-input Object interface to the ElasticMeritCalc
    /// M-function.
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
    public Object[] ElasticMeritCalc(int numArgsOut, Object c, Object c1, Object c2, 
                               Object Density1, Object DensityA, Object Densityo, Object 
                               Em, Object FlowRes)
    {
      return mcr.EvaluateFunction(numArgsOut, "ElasticMeritCalc", c, c1, c2, Density1, DensityA, Densityo, Em, FlowRes);
    }


    /// <summary>
    /// Provides the standard 9-input Object interface to the ElasticMeritCalc
    /// M-function.
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
    public Object[] ElasticMeritCalc(int numArgsOut, Object c, Object c1, Object c2, 
                               Object Density1, Object DensityA, Object Densityo, Object 
                               Em, Object FlowRes, Object freq)
    {
      return mcr.EvaluateFunction(numArgsOut, "ElasticMeritCalc", c, c1, c2, Density1, DensityA, Densityo, Em, FlowRes, freq);
    }


    /// <summary>
    /// Provides the standard 10-input Object interface to the ElasticMeritCalc
    /// M-function.
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
    public Object[] ElasticMeritCalc(int numArgsOut, Object c, Object c1, Object c2, 
                               Object Density1, Object DensityA, Object Densityo, Object 
                               Em, Object FlowRes, Object freq, Object h)
    {
      return mcr.EvaluateFunction(numArgsOut, "ElasticMeritCalc", c, c1, c2, Density1, DensityA, Densityo, Em, FlowRes, freq, h);
    }


    /// <summary>
    /// Provides the standard 11-input Object interface to the ElasticMeritCalc
    /// M-function.
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
    public Object[] ElasticMeritCalc(int numArgsOut, Object c, Object c1, Object c2, 
                               Object Density1, Object DensityA, Object Densityo, Object 
                               Em, Object FlowRes, Object freq, Object h, Object 
                               HeatRatio)
    {
      return mcr.EvaluateFunction(numArgsOut, "ElasticMeritCalc", c, c1, c2, Density1, DensityA, Densityo, Em, FlowRes, freq, h, HeatRatio);
    }


    /// <summary>
    /// Provides the standard 12-input Object interface to the ElasticMeritCalc
    /// M-function.
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
    public Object[] ElasticMeritCalc(int numArgsOut, Object c, Object c1, Object c2, 
                               Object Density1, Object DensityA, Object Densityo, Object 
                               Em, Object FlowRes, Object freq, Object h, Object 
                               HeatRatio, Object L)
    {
      return mcr.EvaluateFunction(numArgsOut, "ElasticMeritCalc", c, c1, c2, Density1, DensityA, Densityo, Em, FlowRes, freq, h, HeatRatio, L);
    }


    /// <summary>
    /// Provides the standard 13-input Object interface to the ElasticMeritCalc
    /// M-function.
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
    public Object[] ElasticMeritCalc(int numArgsOut, Object c, Object c1, Object c2, 
                               Object Density1, Object DensityA, Object Densityo, Object 
                               Em, Object FlowRes, Object freq, Object h, Object 
                               HeatRatio, Object L, Object LFactor)
    {
      return mcr.EvaluateFunction(numArgsOut, "ElasticMeritCalc", c, c1, c2, Density1, DensityA, Densityo, Em, FlowRes, freq, h, HeatRatio, L, LFactor);
    }


    /// <summary>
    /// Provides the standard 14-input Object interface to the ElasticMeritCalc
    /// M-function.
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
    public Object[] ElasticMeritCalc(int numArgsOut, Object c, Object c1, Object c2, 
                               Object Density1, Object DensityA, Object Densityo, Object 
                               Em, Object FlowRes, Object freq, Object h, Object 
                               HeatRatio, Object L, Object LFactor, Object 
                               MeasuredAbsorption)
    {
      return mcr.EvaluateFunction(numArgsOut, "ElasticMeritCalc", c, c1, c2, Density1, DensityA, Densityo, Em, FlowRes, freq, h, HeatRatio, L, LFactor, MeasuredAbsorption);
    }


    /// <summary>
    /// Provides the standard 15-input Object interface to the ElasticMeritCalc
    /// M-function.
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
    public Object[] ElasticMeritCalc(int numArgsOut, Object c, Object c1, Object c2, 
                               Object Density1, Object DensityA, Object Densityo, Object 
                               Em, Object FlowRes, Object freq, Object h, Object 
                               HeatRatio, Object L, Object LFactor, Object 
                               MeasuredAbsorption, Object Npr)
    {
      return mcr.EvaluateFunction(numArgsOut, "ElasticMeritCalc", c, c1, c2, Density1, DensityA, Densityo, Em, FlowRes, freq, h, HeatRatio, L, LFactor, MeasuredAbsorption, Npr);
    }


    /// <summary>
    /// Provides the standard 16-input Object interface to the ElasticMeritCalc
    /// M-function.
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
    public Object[] ElasticMeritCalc(int numArgsOut, Object c, Object c1, Object c2, 
                               Object Density1, Object DensityA, Object Densityo, Object 
                               Em, Object FlowRes, Object freq, Object h, Object 
                               HeatRatio, Object L, Object LFactor, Object 
                               MeasuredAbsorption, Object Npr, Object PRatio)
    {
      return mcr.EvaluateFunction(numArgsOut, "ElasticMeritCalc", c, c1, c2, Density1, DensityA, Densityo, Em, FlowRes, freq, h, HeatRatio, L, LFactor, MeasuredAbsorption, Npr, PRatio);
    }


    /// <summary>
    /// Provides the standard 17-input Object interface to the ElasticMeritCalc
    /// M-function.
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
    public Object[] ElasticMeritCalc(int numArgsOut, Object c, Object c1, Object c2, 
                               Object Density1, Object DensityA, Object Densityo, Object 
                               Em, Object FlowRes, Object freq, Object h, Object 
                               HeatRatio, Object L, Object LFactor, Object 
                               MeasuredAbsorption, Object Npr, Object PRatio, Object 
                               SFactor)
    {
      return mcr.EvaluateFunction(numArgsOut, "ElasticMeritCalc", c, c1, c2, Density1, DensityA, Densityo, Em, FlowRes, freq, h, HeatRatio, L, LFactor, MeasuredAbsorption, Npr, PRatio, SFactor);
    }


    /// <summary>
    /// Provides an interface for the ElasticMeritCalc function in which the input and
    /// output
    /// arguments are specified as an array of Objects.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// M-Documentation:
    /// SurfaceImpedance=abs(Z);
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of Object output arguments</param>
    /// <param name= "argsIn">Array of Object input arguments</param>
    /// <param name= "varArgsIn">Array of Object representing variable input
    /// arguments</param>
    ///
    [MATLABSignature("ElasticMeritCalc", 17, 1, 0)]
    protected void ElasticMeritCalc(int numArgsOut, ref Object[] argsOut, Object[] argsIn, params Object[] varArgsIn)
    {
        mcr.EvaluateFunctionForTypeSafeCall("ElasticMeritCalc", numArgsOut, ref argsOut, argsIn, varArgsIn);
    }
    /// <summary>
    /// Provides a single output, 0-input Objectinterface to the MeritCalc M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object MeritCalc()
    {
      return mcr.EvaluateFunction("MeritCalc", new Object[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input Objectinterface to the MeritCalc M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object MeritCalc(Object BulkDensity)
    {
      return mcr.EvaluateFunction("MeritCalc", BulkDensity);
    }


    /// <summary>
    /// Provides a single output, 2-input Objectinterface to the MeritCalc M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="B">Input argument #2</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object MeritCalc(Object BulkDensity, Object B)
    {
      return mcr.EvaluateFunction("MeritCalc", BulkDensity, B);
    }


    /// <summary>
    /// Provides a single output, 3-input Objectinterface to the MeritCalc M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="B">Input argument #2</param>
    /// <param name="c1">Input argument #3</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object MeritCalc(Object BulkDensity, Object B, Object c1)
    {
      return mcr.EvaluateFunction("MeritCalc", BulkDensity, B, c1);
    }


    /// <summary>
    /// Provides a single output, 4-input Objectinterface to the MeritCalc M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="B">Input argument #2</param>
    /// <param name="c1">Input argument #3</param>
    /// <param name="c2">Input argument #4</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object MeritCalc(Object BulkDensity, Object B, Object c1, Object c2)
    {
      return mcr.EvaluateFunction("MeritCalc", BulkDensity, B, c1, c2);
    }


    /// <summary>
    /// Provides a single output, 5-input Objectinterface to the MeritCalc M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="B">Input argument #2</param>
    /// <param name="c1">Input argument #3</param>
    /// <param name="c2">Input argument #4</param>
    /// <param name="Densityo">Input argument #5</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object MeritCalc(Object BulkDensity, Object B, Object c1, Object c2, Object 
                      Densityo)
    {
      return mcr.EvaluateFunction("MeritCalc", BulkDensity, B, c1, c2, Densityo);
    }


    /// <summary>
    /// Provides a single output, 6-input Objectinterface to the MeritCalc M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="B">Input argument #2</param>
    /// <param name="c1">Input argument #3</param>
    /// <param name="c2">Input argument #4</param>
    /// <param name="Densityo">Input argument #5</param>
    /// <param name="FlowRes">Input argument #6</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object MeritCalc(Object BulkDensity, Object B, Object c1, Object c2, Object 
                      Densityo, Object FlowRes)
    {
      return mcr.EvaluateFunction("MeritCalc", BulkDensity, B, c1, c2, Densityo, FlowRes);
    }


    /// <summary>
    /// Provides a single output, 7-input Objectinterface to the MeritCalc M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="B">Input argument #2</param>
    /// <param name="c1">Input argument #3</param>
    /// <param name="c2">Input argument #4</param>
    /// <param name="Densityo">Input argument #5</param>
    /// <param name="FlowRes">Input argument #6</param>
    /// <param name="freq">Input argument #7</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object MeritCalc(Object BulkDensity, Object B, Object c1, Object c2, Object 
                      Densityo, Object FlowRes, Object freq)
    {
      return mcr.EvaluateFunction("MeritCalc", BulkDensity, B, c1, c2, Densityo, FlowRes, freq);
    }


    /// <summary>
    /// Provides a single output, 8-input Objectinterface to the MeritCalc M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="B">Input argument #2</param>
    /// <param name="c1">Input argument #3</param>
    /// <param name="c2">Input argument #4</param>
    /// <param name="Densityo">Input argument #5</param>
    /// <param name="FlowRes">Input argument #6</param>
    /// <param name="freq">Input argument #7</param>
    /// <param name="h">Input argument #8</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object MeritCalc(Object BulkDensity, Object B, Object c1, Object c2, Object 
                      Densityo, Object FlowRes, Object freq, Object h)
    {
      return mcr.EvaluateFunction("MeritCalc", BulkDensity, B, c1, c2, Densityo, FlowRes, freq, h);
    }


    /// <summary>
    /// Provides a single output, 9-input Objectinterface to the MeritCalc M-function.
    /// </summary>
    /// <remarks>
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
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object MeritCalc(Object BulkDensity, Object B, Object c1, Object c2, Object 
                      Densityo, Object FlowRes, Object freq, Object h, Object HeatRatio)
    {
      return mcr.EvaluateFunction("MeritCalc", BulkDensity, B, c1, c2, Densityo, FlowRes, freq, h, HeatRatio);
    }


    /// <summary>
    /// Provides a single output, 10-input Objectinterface to the MeritCalc M-function.
    /// </summary>
    /// <remarks>
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
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object MeritCalc(Object BulkDensity, Object B, Object c1, Object c2, Object 
                      Densityo, Object FlowRes, Object freq, Object h, Object HeatRatio, 
                      Object ItaAir)
    {
      return mcr.EvaluateFunction("MeritCalc", BulkDensity, B, c1, c2, Densityo, FlowRes, freq, h, HeatRatio, ItaAir);
    }


    /// <summary>
    /// Provides a single output, 11-input Objectinterface to the MeritCalc M-function.
    /// </summary>
    /// <remarks>
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
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object MeritCalc(Object BulkDensity, Object B, Object c1, Object c2, Object 
                      Densityo, Object FlowRes, Object freq, Object h, Object HeatRatio, 
                      Object ItaAir, Object L)
    {
      return mcr.EvaluateFunction("MeritCalc", BulkDensity, B, c1, c2, Densityo, FlowRes, freq, h, HeatRatio, ItaAir, L);
    }


    /// <summary>
    /// Provides a single output, 12-input Objectinterface to the MeritCalc M-function.
    /// </summary>
    /// <remarks>
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
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object MeritCalc(Object BulkDensity, Object B, Object c1, Object c2, Object 
                      Densityo, Object FlowRes, Object freq, Object h, Object HeatRatio, 
                      Object ItaAir, Object L, Object MAbsorption)
    {
      return mcr.EvaluateFunction("MeritCalc", BulkDensity, B, c1, c2, Densityo, FlowRes, freq, h, HeatRatio, ItaAir, L, MAbsorption);
    }


    /// <summary>
    /// Provides a single output, 13-input Objectinterface to the MeritCalc M-function.
    /// </summary>
    /// <remarks>
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
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object MeritCalc(Object BulkDensity, Object B, Object c1, Object c2, Object 
                      Densityo, Object FlowRes, Object freq, Object h, Object HeatRatio, 
                      Object ItaAir, Object L, Object MAbsorption, Object Npr)
    {
      return mcr.EvaluateFunction("MeritCalc", BulkDensity, B, c1, c2, Densityo, FlowRes, freq, h, HeatRatio, ItaAir, L, MAbsorption, Npr);
    }


    /// <summary>
    /// Provides a single output, 14-input Objectinterface to the MeritCalc M-function.
    /// </summary>
    /// <remarks>
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
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object MeritCalc(Object BulkDensity, Object B, Object c1, Object c2, Object 
                      Densityo, Object FlowRes, Object freq, Object h, Object HeatRatio, 
                      Object ItaAir, Object L, Object MAbsorption, Object Npr, Object P0)
    {
      return mcr.EvaluateFunction("MeritCalc", BulkDensity, B, c1, c2, Densityo, FlowRes, freq, h, HeatRatio, ItaAir, L, MAbsorption, Npr, P0);
    }


    /// <summary>
    /// Provides a single output, 15-input Objectinterface to the MeritCalc M-function.
    /// </summary>
    /// <remarks>
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
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object MeritCalc(Object BulkDensity, Object B, Object c1, Object c2, Object 
                      Densityo, Object FlowRes, Object freq, Object h, Object HeatRatio, 
                      Object ItaAir, Object L, Object MAbsorption, Object Npr, Object P0, 
                      Object SFactor)
    {
      return mcr.EvaluateFunction("MeritCalc", BulkDensity, B, c1, c2, Densityo, FlowRes, freq, h, HeatRatio, ItaAir, L, MAbsorption, Npr, P0, SFactor);
    }


    /// <summary>
    /// Provides a single output, 16-input Objectinterface to the MeritCalc M-function.
    /// </summary>
    /// <remarks>
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
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object MeritCalc(Object BulkDensity, Object B, Object c1, Object c2, Object 
                      Densityo, Object FlowRes, Object freq, Object h, Object HeatRatio, 
                      Object ItaAir, Object L, Object MAbsorption, Object Npr, Object P0, 
                      Object SFactor, Object Z0)
    {
      return mcr.EvaluateFunction("MeritCalc", BulkDensity, B, c1, c2, Densityo, FlowRes, freq, h, HeatRatio, ItaAir, L, MAbsorption, Npr, P0, SFactor, Z0);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the MeritCalc M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] MeritCalc(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "MeritCalc", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the MeritCalc M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] MeritCalc(int numArgsOut, Object BulkDensity)
    {
      return mcr.EvaluateFunction(numArgsOut, "MeritCalc", BulkDensity);
    }


    /// <summary>
    /// Provides the standard 2-input Object interface to the MeritCalc M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="B">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] MeritCalc(int numArgsOut, Object BulkDensity, Object B)
    {
      return mcr.EvaluateFunction(numArgsOut, "MeritCalc", BulkDensity, B);
    }


    /// <summary>
    /// Provides the standard 3-input Object interface to the MeritCalc M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="B">Input argument #2</param>
    /// <param name="c1">Input argument #3</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] MeritCalc(int numArgsOut, Object BulkDensity, Object B, Object c1)
    {
      return mcr.EvaluateFunction(numArgsOut, "MeritCalc", BulkDensity, B, c1);
    }


    /// <summary>
    /// Provides the standard 4-input Object interface to the MeritCalc M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="B">Input argument #2</param>
    /// <param name="c1">Input argument #3</param>
    /// <param name="c2">Input argument #4</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] MeritCalc(int numArgsOut, Object BulkDensity, Object B, Object c1, 
                        Object c2)
    {
      return mcr.EvaluateFunction(numArgsOut, "MeritCalc", BulkDensity, B, c1, c2);
    }


    /// <summary>
    /// Provides the standard 5-input Object interface to the MeritCalc M-function.
    /// </summary>
    /// <remarks>
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
    public Object[] MeritCalc(int numArgsOut, Object BulkDensity, Object B, Object c1, 
                        Object c2, Object Densityo)
    {
      return mcr.EvaluateFunction(numArgsOut, "MeritCalc", BulkDensity, B, c1, c2, Densityo);
    }


    /// <summary>
    /// Provides the standard 6-input Object interface to the MeritCalc M-function.
    /// </summary>
    /// <remarks>
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
    public Object[] MeritCalc(int numArgsOut, Object BulkDensity, Object B, Object c1, 
                        Object c2, Object Densityo, Object FlowRes)
    {
      return mcr.EvaluateFunction(numArgsOut, "MeritCalc", BulkDensity, B, c1, c2, Densityo, FlowRes);
    }


    /// <summary>
    /// Provides the standard 7-input Object interface to the MeritCalc M-function.
    /// </summary>
    /// <remarks>
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
    public Object[] MeritCalc(int numArgsOut, Object BulkDensity, Object B, Object c1, 
                        Object c2, Object Densityo, Object FlowRes, Object freq)
    {
      return mcr.EvaluateFunction(numArgsOut, "MeritCalc", BulkDensity, B, c1, c2, Densityo, FlowRes, freq);
    }


    /// <summary>
    /// Provides the standard 8-input Object interface to the MeritCalc M-function.
    /// </summary>
    /// <remarks>
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
    public Object[] MeritCalc(int numArgsOut, Object BulkDensity, Object B, Object c1, 
                        Object c2, Object Densityo, Object FlowRes, Object freq, Object h)
    {
      return mcr.EvaluateFunction(numArgsOut, "MeritCalc", BulkDensity, B, c1, c2, Densityo, FlowRes, freq, h);
    }


    /// <summary>
    /// Provides the standard 9-input Object interface to the MeritCalc M-function.
    /// </summary>
    /// <remarks>
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
    public Object[] MeritCalc(int numArgsOut, Object BulkDensity, Object B, Object c1, 
                        Object c2, Object Densityo, Object FlowRes, Object freq, Object 
                        h, Object HeatRatio)
    {
      return mcr.EvaluateFunction(numArgsOut, "MeritCalc", BulkDensity, B, c1, c2, Densityo, FlowRes, freq, h, HeatRatio);
    }


    /// <summary>
    /// Provides the standard 10-input Object interface to the MeritCalc M-function.
    /// </summary>
    /// <remarks>
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
    public Object[] MeritCalc(int numArgsOut, Object BulkDensity, Object B, Object c1, 
                        Object c2, Object Densityo, Object FlowRes, Object freq, Object 
                        h, Object HeatRatio, Object ItaAir)
    {
      return mcr.EvaluateFunction(numArgsOut, "MeritCalc", BulkDensity, B, c1, c2, Densityo, FlowRes, freq, h, HeatRatio, ItaAir);
    }


    /// <summary>
    /// Provides the standard 11-input Object interface to the MeritCalc M-function.
    /// </summary>
    /// <remarks>
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
    public Object[] MeritCalc(int numArgsOut, Object BulkDensity, Object B, Object c1, 
                        Object c2, Object Densityo, Object FlowRes, Object freq, Object 
                        h, Object HeatRatio, Object ItaAir, Object L)
    {
      return mcr.EvaluateFunction(numArgsOut, "MeritCalc", BulkDensity, B, c1, c2, Densityo, FlowRes, freq, h, HeatRatio, ItaAir, L);
    }


    /// <summary>
    /// Provides the standard 12-input Object interface to the MeritCalc M-function.
    /// </summary>
    /// <remarks>
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
    public Object[] MeritCalc(int numArgsOut, Object BulkDensity, Object B, Object c1, 
                        Object c2, Object Densityo, Object FlowRes, Object freq, Object 
                        h, Object HeatRatio, Object ItaAir, Object L, Object MAbsorption)
    {
      return mcr.EvaluateFunction(numArgsOut, "MeritCalc", BulkDensity, B, c1, c2, Densityo, FlowRes, freq, h, HeatRatio, ItaAir, L, MAbsorption);
    }


    /// <summary>
    /// Provides the standard 13-input Object interface to the MeritCalc M-function.
    /// </summary>
    /// <remarks>
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
    public Object[] MeritCalc(int numArgsOut, Object BulkDensity, Object B, Object c1, 
                        Object c2, Object Densityo, Object FlowRes, Object freq, Object 
                        h, Object HeatRatio, Object ItaAir, Object L, Object MAbsorption, 
                        Object Npr)
    {
      return mcr.EvaluateFunction(numArgsOut, "MeritCalc", BulkDensity, B, c1, c2, Densityo, FlowRes, freq, h, HeatRatio, ItaAir, L, MAbsorption, Npr);
    }


    /// <summary>
    /// Provides the standard 14-input Object interface to the MeritCalc M-function.
    /// </summary>
    /// <remarks>
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
    public Object[] MeritCalc(int numArgsOut, Object BulkDensity, Object B, Object c1, 
                        Object c2, Object Densityo, Object FlowRes, Object freq, Object 
                        h, Object HeatRatio, Object ItaAir, Object L, Object MAbsorption, 
                        Object Npr, Object P0)
    {
      return mcr.EvaluateFunction(numArgsOut, "MeritCalc", BulkDensity, B, c1, c2, Densityo, FlowRes, freq, h, HeatRatio, ItaAir, L, MAbsorption, Npr, P0);
    }


    /// <summary>
    /// Provides the standard 15-input Object interface to the MeritCalc M-function.
    /// </summary>
    /// <remarks>
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
    public Object[] MeritCalc(int numArgsOut, Object BulkDensity, Object B, Object c1, 
                        Object c2, Object Densityo, Object FlowRes, Object freq, Object 
                        h, Object HeatRatio, Object ItaAir, Object L, Object MAbsorption, 
                        Object Npr, Object P0, Object SFactor)
    {
      return mcr.EvaluateFunction(numArgsOut, "MeritCalc", BulkDensity, B, c1, c2, Densityo, FlowRes, freq, h, HeatRatio, ItaAir, L, MAbsorption, Npr, P0, SFactor);
    }


    /// <summary>
    /// Provides the standard 16-input Object interface to the MeritCalc M-function.
    /// </summary>
    /// <remarks>
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
    public Object[] MeritCalc(int numArgsOut, Object BulkDensity, Object B, Object c1, 
                        Object c2, Object Densityo, Object FlowRes, Object freq, Object 
                        h, Object HeatRatio, Object ItaAir, Object L, Object MAbsorption, 
                        Object Npr, Object P0, Object SFactor, Object Z0)
    {
      return mcr.EvaluateFunction(numArgsOut, "MeritCalc", BulkDensity, B, c1, c2, Densityo, FlowRes, freq, h, HeatRatio, ItaAir, L, MAbsorption, Npr, P0, SFactor, Z0);
    }


    /// <summary>
    /// Provides an interface for the MeritCalc function in which the input and output
    /// arguments are specified as an array of Objects.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of Object output arguments</param>
    /// <param name= "argsIn">Array of Object input arguments</param>
    /// <param name= "varArgsIn">Array of Object representing variable input
    /// arguments</param>
    ///
    [MATLABSignature("MeritCalc", 16, 1, 0)]
    protected void MeritCalc(int numArgsOut, ref Object[] argsOut, Object[] argsIn, params Object[] varArgsIn)
    {
        mcr.EvaluateFunctionForTypeSafeCall("MeritCalc", numArgsOut, ref argsOut, argsIn, varArgsIn);
    }
    /// <summary>
    /// Provides a single output, 0-input Objectinterface to the PEElasticSolid
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// [C I]=min(ResonFreErrorTemp);
    /// [C2 I2]=min(C);
    /// tPRatio=I2*0.01;
    /// tLFactor=I(I2)*0.01;
    /// </remarks>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object PEElasticSolid()
    {
      return mcr.EvaluateFunction("PEElasticSolid", new Object[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input Objectinterface to the PEElasticSolid
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// [C I]=min(ResonFreErrorTemp);
    /// [C2 I2]=min(C);
    /// tPRatio=I2*0.01;
    /// tLFactor=I(I2)*0.01;
    /// </remarks>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object PEElasticSolid(Object BulkDensity)
    {
      return mcr.EvaluateFunction("PEElasticSolid", BulkDensity);
    }


    /// <summary>
    /// Provides a single output, 2-input Objectinterface to the PEElasticSolid
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// [C I]=min(ResonFreErrorTemp);
    /// [C2 I2]=min(C);
    /// tPRatio=I2*0.01;
    /// tLFactor=I(I2)*0.01;
    /// </remarks>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="L">Input argument #2</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object PEElasticSolid(Object BulkDensity, Object L)
    {
      return mcr.EvaluateFunction("PEElasticSolid", BulkDensity, L);
    }


    /// <summary>
    /// Provides a single output, 3-input Objectinterface to the PEElasticSolid
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// [C I]=min(ResonFreErrorTemp);
    /// [C2 I2]=min(C);
    /// tPRatio=I2*0.01;
    /// tLFactor=I(I2)*0.01;
    /// </remarks>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="L">Input argument #2</param>
    /// <param name="ResonanceFrequency">Input argument #3</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object PEElasticSolid(Object BulkDensity, Object L, Object ResonanceFrequency)
    {
      return mcr.EvaluateFunction("PEElasticSolid", BulkDensity, L, ResonanceFrequency);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the PEElasticSolid M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// [C I]=min(ResonFreErrorTemp);
    /// [C2 I2]=min(C);
    /// tPRatio=I2*0.01;
    /// tLFactor=I(I2)*0.01;
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] PEElasticSolid(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "PEElasticSolid", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the PEElasticSolid M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// [C I]=min(ResonFreErrorTemp);
    /// [C2 I2]=min(C);
    /// tPRatio=I2*0.01;
    /// tLFactor=I(I2)*0.01;
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] PEElasticSolid(int numArgsOut, Object BulkDensity)
    {
      return mcr.EvaluateFunction(numArgsOut, "PEElasticSolid", BulkDensity);
    }


    /// <summary>
    /// Provides the standard 2-input Object interface to the PEElasticSolid M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// [C I]=min(ResonFreErrorTemp);
    /// [C2 I2]=min(C);
    /// tPRatio=I2*0.01;
    /// tLFactor=I(I2)*0.01;
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="L">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] PEElasticSolid(int numArgsOut, Object BulkDensity, Object L)
    {
      return mcr.EvaluateFunction(numArgsOut, "PEElasticSolid", BulkDensity, L);
    }


    /// <summary>
    /// Provides the standard 3-input Object interface to the PEElasticSolid M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// [C I]=min(ResonFreErrorTemp);
    /// [C2 I2]=min(C);
    /// tPRatio=I2*0.01;
    /// tLFactor=I(I2)*0.01;
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="L">Input argument #2</param>
    /// <param name="ResonanceFrequency">Input argument #3</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] PEElasticSolid(int numArgsOut, Object BulkDensity, Object L, Object 
                             ResonanceFrequency)
    {
      return mcr.EvaluateFunction(numArgsOut, "PEElasticSolid", BulkDensity, L, ResonanceFrequency);
    }


    /// <summary>
    /// Provides an interface for the PEElasticSolid function in which the input and
    /// output
    /// arguments are specified as an array of Objects.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// M-Documentation:
    /// [C I]=min(ResonFreErrorTemp);
    /// [C2 I2]=min(C);
    /// tPRatio=I2*0.01;
    /// tLFactor=I(I2)*0.01;
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of Object output arguments</param>
    /// <param name= "argsIn">Array of Object input arguments</param>
    /// <param name= "varArgsIn">Array of Object representing variable input
    /// arguments</param>
    ///
    [MATLABSignature("PEElasticSolid", 3, 1, 0)]
    protected void PEElasticSolid(int numArgsOut, ref Object[] argsOut, Object[] argsIn, params Object[] varArgsIn)
    {
        mcr.EvaluateFunctionForTypeSafeCall("PEElasticSolid", numArgsOut, ref argsOut, argsIn, varArgsIn);
    }
    /// <summary>
    /// Provides a single output, 0-input Objectinterface to the PolyFitting M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object PolyFitting()
    {
      return mcr.EvaluateFunction("PolyFitting", new Object[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input Objectinterface to the PolyFitting M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="DataSampled">Input argument #1</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object PolyFitting(Object DataSampled)
    {
      return mcr.EvaluateFunction("PolyFitting", DataSampled);
    }


    /// <summary>
    /// Provides a single output, 2-input Objectinterface to the PolyFitting M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="DataSampled">Input argument #1</param>
    /// <param name="FrequencyFitted">Input argument #2</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object PolyFitting(Object DataSampled, Object FrequencyFitted)
    {
      return mcr.EvaluateFunction("PolyFitting", DataSampled, FrequencyFitted);
    }


    /// <summary>
    /// Provides a single output, 3-input Objectinterface to the PolyFitting M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="DataSampled">Input argument #1</param>
    /// <param name="FrequencyFitted">Input argument #2</param>
    /// <param name="FrequencySampled">Input argument #3</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object PolyFitting(Object DataSampled, Object FrequencyFitted, Object 
                        FrequencySampled)
    {
      return mcr.EvaluateFunction("PolyFitting", DataSampled, FrequencyFitted, FrequencySampled);
    }


    /// <summary>
    /// Provides a single output, 4-input Objectinterface to the PolyFitting M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="DataSampled">Input argument #1</param>
    /// <param name="FrequencyFitted">Input argument #2</param>
    /// <param name="FrequencySampled">Input argument #3</param>
    /// <param name="n">Input argument #4</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object PolyFitting(Object DataSampled, Object FrequencyFitted, Object 
                        FrequencySampled, Object n)
    {
      return mcr.EvaluateFunction("PolyFitting", DataSampled, FrequencyFitted, FrequencySampled, n);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the PolyFitting M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] PolyFitting(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "PolyFitting", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the PolyFitting M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="DataSampled">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] PolyFitting(int numArgsOut, Object DataSampled)
    {
      return mcr.EvaluateFunction(numArgsOut, "PolyFitting", DataSampled);
    }


    /// <summary>
    /// Provides the standard 2-input Object interface to the PolyFitting M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="DataSampled">Input argument #1</param>
    /// <param name="FrequencyFitted">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] PolyFitting(int numArgsOut, Object DataSampled, Object 
                          FrequencyFitted)
    {
      return mcr.EvaluateFunction(numArgsOut, "PolyFitting", DataSampled, FrequencyFitted);
    }


    /// <summary>
    /// Provides the standard 3-input Object interface to the PolyFitting M-function.
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
    public Object[] PolyFitting(int numArgsOut, Object DataSampled, Object 
                          FrequencyFitted, Object FrequencySampled)
    {
      return mcr.EvaluateFunction(numArgsOut, "PolyFitting", DataSampled, FrequencyFitted, FrequencySampled);
    }


    /// <summary>
    /// Provides the standard 4-input Object interface to the PolyFitting M-function.
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
    public Object[] PolyFitting(int numArgsOut, Object DataSampled, Object 
                          FrequencyFitted, Object FrequencySampled, Object n)
    {
      return mcr.EvaluateFunction(numArgsOut, "PolyFitting", DataSampled, FrequencyFitted, FrequencySampled, n);
    }


    /// <summary>
    /// Provides an interface for the PolyFitting function in which the input and output
    /// arguments are specified as an array of Objects.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of Object output arguments</param>
    /// <param name= "argsIn">Array of Object input arguments</param>
    /// <param name= "varArgsIn">Array of Object representing variable input
    /// arguments</param>
    ///
    [MATLABSignature("PolyFitting", 4, 1, 0)]
    protected void PolyFitting(int numArgsOut, ref Object[] argsOut, Object[] argsIn, params Object[] varArgsIn)
    {
        mcr.EvaluateFunctionForTypeSafeCall("PolyFitting", numArgsOut, ref argsOut, argsIn, varArgsIn);
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

    private bool disposed= false;

    #endregion Class Members
  }
}
