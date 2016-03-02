/*
* MATLAB Compiler: 4.18.1 (R2013a)
* Date: Wed Mar 02 13:11:01 2016
* Arguments: "-B" "macro_default" "-W" "dotnet:TM,TMclassClass,0.0,private" "-T"
* "link:lib" "-d" "D:\Project\HONUS\Matlabresurce\TMsourcefiles\TM\src" "-w"
* "enable:specified_file_mismatch" "-w" "enable:repeated_file" "-w"
* "enable:switch_ignored" "-w" "enable:missing_lib_sentinel" "-w" "enable:demo_license"
* "-v"
* "class{TMclassClass:D:\Project\HONUS\Matlabresurce\MPE\FuncTest.m,D:\Project\HONUS\Matla
* bresurce\TMsourcefiles\TMAir.m,D:\Project\HONUS\Matlabresurce\TMsourcefiles\TMCalc.m,D:\
* Project\HONUS\Matlabresurce\TMsourcefiles\TMCheck.m,D:\Project\HONUS\Matlabresurce\TMsou
* rcefiles\TMElastic.m,D:\Project\HONUS\Matlabresurce\TMsourcefiles\TMElasticPanel.m,D:\Pr
* oject\HONUS\Matlabresurce\TMsourcefiles\TMImperMemb.m,D:\Project\HONUS\Matlabresurce\TMs
* ourcefiles\TMInit.m,D:\Project\HONUS\Matlabresurce\TMsourcefiles\TMLimp.m,D:\Project\HON
* US\Matlabresurce\TMsourcefiles\TMMul.m,D:\Project\HONUS\Matlabresurce\TMsourcefiles\TMPa
* nel.m,D:\Project\HONUS\Matlabresurce\TMsourcefiles\TMPanelElastic.m,D:\Project\HONUS\Mat
* labresurce\TMsourcefiles\TMPanelElasticPanel.m,D:\Project\HONUS\Matlabresurce\TMsourcefi
* les\TMperMemb.m,D:\Project\HONUS\Matlabresurce\TMsourcefiles\TMRigid.m}" 
*/
using System;
using System.Reflection;
using System.IO;
using MathWorks.MATLAB.NET.Arrays;
using MathWorks.MATLAB.NET.Utility;

#if SHARED
[assembly: System.Reflection.AssemblyKeyFile(@"")]
#endif

namespace TM
{

  /// <summary>
  /// The TMclassClass class provides a CLS compliant, MWArray interface to the MATLAB
  /// functions contained in the files:
  /// <newpara></newpara>
  /// D:\Project\HONUS\Matlabresurce\MPE\FuncTest.m
  /// <newpara></newpara>
  /// D:\Project\HONUS\Matlabresurce\TMsourcefiles\TMAir.m
  /// <newpara></newpara>
  /// D:\Project\HONUS\Matlabresurce\TMsourcefiles\TMCalc.m
  /// <newpara></newpara>
  /// D:\Project\HONUS\Matlabresurce\TMsourcefiles\TMCheck.m
  /// <newpara></newpara>
  /// D:\Project\HONUS\Matlabresurce\TMsourcefiles\TMElastic.m
  /// <newpara></newpara>
  /// D:\Project\HONUS\Matlabresurce\TMsourcefiles\TMElasticPanel.m
  /// <newpara></newpara>
  /// D:\Project\HONUS\Matlabresurce\TMsourcefiles\TMImperMemb.m
  /// <newpara></newpara>
  /// D:\Project\HONUS\Matlabresurce\TMsourcefiles\TMInit.m
  /// <newpara></newpara>
  /// D:\Project\HONUS\Matlabresurce\TMsourcefiles\TMLimp.m
  /// <newpara></newpara>
  /// D:\Project\HONUS\Matlabresurce\TMsourcefiles\TMMul.m
  /// <newpara></newpara>
  /// D:\Project\HONUS\Matlabresurce\TMsourcefiles\TMPanel.m
  /// <newpara></newpara>
  /// D:\Project\HONUS\Matlabresurce\TMsourcefiles\TMPanelElastic.m
  /// <newpara></newpara>
  /// D:\Project\HONUS\Matlabresurce\TMsourcefiles\TMPanelElasticPanel.m
  /// <newpara></newpara>
  /// D:\Project\HONUS\Matlabresurce\TMsourcefiles\TMperMemb.m
  /// <newpara></newpara>
  /// D:\Project\HONUS\Matlabresurce\TMsourcefiles\TMRigid.m
  /// <newpara></newpara>
  /// deployprint.m
  /// <newpara></newpara>
  /// printdlg.m
  /// </summary>
  /// <remarks>
  /// @Version 0.0
  /// </remarks>
  public class TMclassClass : IDisposable
  {
    #region Constructors

    /// <summary internal= "true">
    /// The static constructor instantiates and initializes the MATLAB Compiler Runtime
    /// instance.
    /// </summary>
    static TMclassClass()
    {
      if (MWMCR.MCRAppInitialized)
      {
        try
        {
          Assembly assembly= Assembly.GetExecutingAssembly();

          string ctfFilePath= assembly.Location;

          int lastDelimiter= ctfFilePath.LastIndexOf(@"\");

          ctfFilePath= ctfFilePath.Remove(lastDelimiter, (ctfFilePath.Length - lastDelimiter));

          string ctfFileName = "TM.ctf";

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
    /// Constructs a new instance of the TMclassClass class.
    /// </summary>
    public TMclassClass()
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
    ~TMclassClass()
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
    /// Provides a single output, 0-input MWArrayinterface to the TMAir MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray TMAir()
    {
      return mcr.EvaluateFunction("TMAir", new MWArray[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input MWArrayinterface to the TMAir MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="c">Input argument #1</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray TMAir(MWArray c)
    {
      return mcr.EvaluateFunction("TMAir", c);
    }


    /// <summary>
    /// Provides a single output, 2-input MWArrayinterface to the TMAir MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="c">Input argument #1</param>
    /// <param name="Densityo">Input argument #2</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray TMAir(MWArray c, MWArray Densityo)
    {
      return mcr.EvaluateFunction("TMAir", c, Densityo);
    }


    /// <summary>
    /// Provides a single output, 3-input MWArrayinterface to the TMAir MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="c">Input argument #1</param>
    /// <param name="Densityo">Input argument #2</param>
    /// <param name="freq">Input argument #3</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray TMAir(MWArray c, MWArray Densityo, MWArray freq)
    {
      return mcr.EvaluateFunction("TMAir", c, Densityo, freq);
    }


    /// <summary>
    /// Provides a single output, 4-input MWArrayinterface to the TMAir MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="c">Input argument #1</param>
    /// <param name="Densityo">Input argument #2</param>
    /// <param name="freq">Input argument #3</param>
    /// <param name="L">Input argument #4</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray TMAir(MWArray c, MWArray Densityo, MWArray freq, MWArray L)
    {
      return mcr.EvaluateFunction("TMAir", c, Densityo, freq, L);
    }


    /// <summary>
    /// Provides a single output, 5-input MWArrayinterface to the TMAir MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="c">Input argument #1</param>
    /// <param name="Densityo">Input argument #2</param>
    /// <param name="freq">Input argument #3</param>
    /// <param name="L">Input argument #4</param>
    /// <param name="theta">Input argument #5</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray TMAir(MWArray c, MWArray Densityo, MWArray freq, MWArray L, MWArray 
                   theta)
    {
      return mcr.EvaluateFunction("TMAir", c, Densityo, freq, L, theta);
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the TMAir MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] TMAir(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "TMAir", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 1-input MWArray interface to the TMAir MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="c">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] TMAir(int numArgsOut, MWArray c)
    {
      return mcr.EvaluateFunction(numArgsOut, "TMAir", c);
    }


    /// <summary>
    /// Provides the standard 2-input MWArray interface to the TMAir MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="c">Input argument #1</param>
    /// <param name="Densityo">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] TMAir(int numArgsOut, MWArray c, MWArray Densityo)
    {
      return mcr.EvaluateFunction(numArgsOut, "TMAir", c, Densityo);
    }


    /// <summary>
    /// Provides the standard 3-input MWArray interface to the TMAir MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="c">Input argument #1</param>
    /// <param name="Densityo">Input argument #2</param>
    /// <param name="freq">Input argument #3</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] TMAir(int numArgsOut, MWArray c, MWArray Densityo, MWArray freq)
    {
      return mcr.EvaluateFunction(numArgsOut, "TMAir", c, Densityo, freq);
    }


    /// <summary>
    /// Provides the standard 4-input MWArray interface to the TMAir MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="c">Input argument #1</param>
    /// <param name="Densityo">Input argument #2</param>
    /// <param name="freq">Input argument #3</param>
    /// <param name="L">Input argument #4</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] TMAir(int numArgsOut, MWArray c, MWArray Densityo, MWArray freq, 
                     MWArray L)
    {
      return mcr.EvaluateFunction(numArgsOut, "TMAir", c, Densityo, freq, L);
    }


    /// <summary>
    /// Provides the standard 5-input MWArray interface to the TMAir MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="c">Input argument #1</param>
    /// <param name="Densityo">Input argument #2</param>
    /// <param name="freq">Input argument #3</param>
    /// <param name="L">Input argument #4</param>
    /// <param name="theta">Input argument #5</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] TMAir(int numArgsOut, MWArray c, MWArray Densityo, MWArray freq, 
                     MWArray L, MWArray theta)
    {
      return mcr.EvaluateFunction(numArgsOut, "TMAir", c, Densityo, freq, L, theta);
    }


    /// <summary>
    /// Provides an interface for the TMAir function in which the input and output
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
    public void TMAir(int numArgsOut, ref MWArray[] argsOut, MWArray[] argsIn)
    {
      mcr.EvaluateFunction("TMAir", numArgsOut, ref argsOut, argsIn);
    }


    /// <summary>
    /// Provides a single output, 0-input MWArrayinterface to the TMCalc MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray TMCalc()
    {
      return mcr.EvaluateFunction("TMCalc", new MWArray[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input MWArrayinterface to the TMCalc MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="c">Input argument #1</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray TMCalc(MWArray c)
    {
      return mcr.EvaluateFunction("TMCalc", c);
    }


    /// <summary>
    /// Provides a single output, 2-input MWArrayinterface to the TMCalc MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="c">Input argument #1</param>
    /// <param name="Densityo">Input argument #2</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray TMCalc(MWArray c, MWArray Densityo)
    {
      return mcr.EvaluateFunction("TMCalc", c, Densityo);
    }


    /// <summary>
    /// Provides a single output, 3-input MWArrayinterface to the TMCalc MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="c">Input argument #1</param>
    /// <param name="Densityo">Input argument #2</param>
    /// <param name="freq">Input argument #3</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray TMCalc(MWArray c, MWArray Densityo, MWArray freq)
    {
      return mcr.EvaluateFunction("TMCalc", c, Densityo, freq);
    }


    /// <summary>
    /// Provides a single output, 4-input MWArrayinterface to the TMCalc MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="c">Input argument #1</param>
    /// <param name="Densityo">Input argument #2</param>
    /// <param name="freq">Input argument #3</param>
    /// <param name="Result">Input argument #4</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray TMCalc(MWArray c, MWArray Densityo, MWArray freq, MWArray Result)
    {
      return mcr.EvaluateFunction("TMCalc", c, Densityo, freq, Result);
    }


    /// <summary>
    /// Provides a single output, 5-input MWArrayinterface to the TMCalc MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="c">Input argument #1</param>
    /// <param name="Densityo">Input argument #2</param>
    /// <param name="freq">Input argument #3</param>
    /// <param name="Result">Input argument #4</param>
    /// <param name="theta">Input argument #5</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray TMCalc(MWArray c, MWArray Densityo, MWArray freq, MWArray Result, 
                    MWArray theta)
    {
      return mcr.EvaluateFunction("TMCalc", c, Densityo, freq, Result, theta);
    }


    /// <summary>
    /// Provides a single output, 6-input MWArrayinterface to the TMCalc MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="c">Input argument #1</param>
    /// <param name="Densityo">Input argument #2</param>
    /// <param name="freq">Input argument #3</param>
    /// <param name="Result">Input argument #4</param>
    /// <param name="theta">Input argument #5</param>
    /// <param name="TotalThickness">Input argument #6</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray TMCalc(MWArray c, MWArray Densityo, MWArray freq, MWArray Result, 
                    MWArray theta, MWArray TotalThickness)
    {
      return mcr.EvaluateFunction("TMCalc", c, Densityo, freq, Result, theta, TotalThickness);
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the TMCalc MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] TMCalc(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "TMCalc", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 1-input MWArray interface to the TMCalc MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="c">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] TMCalc(int numArgsOut, MWArray c)
    {
      return mcr.EvaluateFunction(numArgsOut, "TMCalc", c);
    }


    /// <summary>
    /// Provides the standard 2-input MWArray interface to the TMCalc MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="c">Input argument #1</param>
    /// <param name="Densityo">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] TMCalc(int numArgsOut, MWArray c, MWArray Densityo)
    {
      return mcr.EvaluateFunction(numArgsOut, "TMCalc", c, Densityo);
    }


    /// <summary>
    /// Provides the standard 3-input MWArray interface to the TMCalc MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="c">Input argument #1</param>
    /// <param name="Densityo">Input argument #2</param>
    /// <param name="freq">Input argument #3</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] TMCalc(int numArgsOut, MWArray c, MWArray Densityo, MWArray freq)
    {
      return mcr.EvaluateFunction(numArgsOut, "TMCalc", c, Densityo, freq);
    }


    /// <summary>
    /// Provides the standard 4-input MWArray interface to the TMCalc MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="c">Input argument #1</param>
    /// <param name="Densityo">Input argument #2</param>
    /// <param name="freq">Input argument #3</param>
    /// <param name="Result">Input argument #4</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] TMCalc(int numArgsOut, MWArray c, MWArray Densityo, MWArray freq, 
                      MWArray Result)
    {
      return mcr.EvaluateFunction(numArgsOut, "TMCalc", c, Densityo, freq, Result);
    }


    /// <summary>
    /// Provides the standard 5-input MWArray interface to the TMCalc MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="c">Input argument #1</param>
    /// <param name="Densityo">Input argument #2</param>
    /// <param name="freq">Input argument #3</param>
    /// <param name="Result">Input argument #4</param>
    /// <param name="theta">Input argument #5</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] TMCalc(int numArgsOut, MWArray c, MWArray Densityo, MWArray freq, 
                      MWArray Result, MWArray theta)
    {
      return mcr.EvaluateFunction(numArgsOut, "TMCalc", c, Densityo, freq, Result, theta);
    }


    /// <summary>
    /// Provides the standard 6-input MWArray interface to the TMCalc MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="c">Input argument #1</param>
    /// <param name="Densityo">Input argument #2</param>
    /// <param name="freq">Input argument #3</param>
    /// <param name="Result">Input argument #4</param>
    /// <param name="theta">Input argument #5</param>
    /// <param name="TotalThickness">Input argument #6</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] TMCalc(int numArgsOut, MWArray c, MWArray Densityo, MWArray freq, 
                      MWArray Result, MWArray theta, MWArray TotalThickness)
    {
      return mcr.EvaluateFunction(numArgsOut, "TMCalc", c, Densityo, freq, Result, theta, TotalThickness);
    }


    /// <summary>
    /// Provides an interface for the TMCalc function in which the input and output
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
    public void TMCalc(int numArgsOut, ref MWArray[] argsOut, MWArray[] argsIn)
    {
      mcr.EvaluateFunction("TMCalc", numArgsOut, ref argsOut, argsIn);
    }


    /// <summary>
    /// Provides a void output, 0-input MWArrayinterface to the TMCheck MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    ///
    public void TMCheck()
    {
      mcr.EvaluateFunction(0, "TMCheck", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the TMCheck MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] TMCheck(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "TMCheck", new MWArray[]{});
    }


    /// <summary>
    /// Provides a single output, 0-input MWArrayinterface to the TMElastic MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Constant and variable definition
    /// </remarks>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray TMElastic()
    {
      return mcr.EvaluateFunction("TMElastic", new MWArray[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input MWArrayinterface to the TMElastic MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Constant and variable definition
    /// </remarks>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray TMElastic(MWArray BulkDensity)
    {
      return mcr.EvaluateFunction("TMElastic", BulkDensity);
    }


    /// <summary>
    /// Provides a single output, 2-input MWArrayinterface to the TMElastic MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Constant and variable definition
    /// </remarks>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray TMElastic(MWArray BulkDensity, MWArray c)
    {
      return mcr.EvaluateFunction("TMElastic", BulkDensity, c);
    }


    /// <summary>
    /// Provides a single output, 3-input MWArrayinterface to the TMElastic MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Constant and variable definition
    /// </remarks>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray TMElastic(MWArray BulkDensity, MWArray c, MWArray Densityo)
    {
      return mcr.EvaluateFunction("TMElastic", BulkDensity, c, Densityo);
    }


    /// <summary>
    /// Provides a single output, 4-input MWArrayinterface to the TMElastic MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Constant and variable definition
    /// </remarks>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="Em">Input argument #4</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray TMElastic(MWArray BulkDensity, MWArray c, MWArray Densityo, MWArray Em)
    {
      return mcr.EvaluateFunction("TMElastic", BulkDensity, c, Densityo, Em);
    }


    /// <summary>
    /// Provides a single output, 5-input MWArrayinterface to the TMElastic MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Constant and variable definition
    /// </remarks>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="Em">Input argument #4</param>
    /// <param name="FlowRes">Input argument #5</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray TMElastic(MWArray BulkDensity, MWArray c, MWArray Densityo, MWArray 
                       Em, MWArray FlowRes)
    {
      return mcr.EvaluateFunction("TMElastic", BulkDensity, c, Densityo, Em, FlowRes);
    }


    /// <summary>
    /// Provides a single output, 6-input MWArrayinterface to the TMElastic MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Constant and variable definition
    /// </remarks>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="Em">Input argument #4</param>
    /// <param name="FlowRes">Input argument #5</param>
    /// <param name="freq">Input argument #6</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray TMElastic(MWArray BulkDensity, MWArray c, MWArray Densityo, MWArray 
                       Em, MWArray FlowRes, MWArray freq)
    {
      return mcr.EvaluateFunction("TMElastic", BulkDensity, c, Densityo, Em, FlowRes, freq);
    }


    /// <summary>
    /// Provides a single output, 7-input MWArrayinterface to the TMElastic MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Constant and variable definition
    /// </remarks>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="Em">Input argument #4</param>
    /// <param name="FlowRes">Input argument #5</param>
    /// <param name="freq">Input argument #6</param>
    /// <param name="h">Input argument #7</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray TMElastic(MWArray BulkDensity, MWArray c, MWArray Densityo, MWArray 
                       Em, MWArray FlowRes, MWArray freq, MWArray h)
    {
      return mcr.EvaluateFunction("TMElastic", BulkDensity, c, Densityo, Em, FlowRes, freq, h);
    }


    /// <summary>
    /// Provides a single output, 8-input MWArrayinterface to the TMElastic MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Constant and variable definition
    /// </remarks>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="Em">Input argument #4</param>
    /// <param name="FlowRes">Input argument #5</param>
    /// <param name="freq">Input argument #6</param>
    /// <param name="h">Input argument #7</param>
    /// <param name="HeatRatio">Input argument #8</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray TMElastic(MWArray BulkDensity, MWArray c, MWArray Densityo, MWArray 
                       Em, MWArray FlowRes, MWArray freq, MWArray h, MWArray HeatRatio)
    {
      return mcr.EvaluateFunction("TMElastic", BulkDensity, c, Densityo, Em, FlowRes, freq, h, HeatRatio);
    }


    /// <summary>
    /// Provides a single output, 9-input MWArrayinterface to the TMElastic MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Constant and variable definition
    /// </remarks>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="Em">Input argument #4</param>
    /// <param name="FlowRes">Input argument #5</param>
    /// <param name="freq">Input argument #6</param>
    /// <param name="h">Input argument #7</param>
    /// <param name="HeatRatio">Input argument #8</param>
    /// <param name="ItaAir">Input argument #9</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray TMElastic(MWArray BulkDensity, MWArray c, MWArray Densityo, MWArray 
                       Em, MWArray FlowRes, MWArray freq, MWArray h, MWArray HeatRatio, 
                       MWArray ItaAir)
    {
      return mcr.EvaluateFunction("TMElastic", BulkDensity, c, Densityo, Em, FlowRes, freq, h, HeatRatio, ItaAir);
    }


    /// <summary>
    /// Provides a single output, 10-input MWArrayinterface to the TMElastic MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Constant and variable definition
    /// </remarks>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="Em">Input argument #4</param>
    /// <param name="FlowRes">Input argument #5</param>
    /// <param name="freq">Input argument #6</param>
    /// <param name="h">Input argument #7</param>
    /// <param name="HeatRatio">Input argument #8</param>
    /// <param name="ItaAir">Input argument #9</param>
    /// <param name="L">Input argument #10</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray TMElastic(MWArray BulkDensity, MWArray c, MWArray Densityo, MWArray 
                       Em, MWArray FlowRes, MWArray freq, MWArray h, MWArray HeatRatio, 
                       MWArray ItaAir, MWArray L)
    {
      return mcr.EvaluateFunction("TMElastic", BulkDensity, c, Densityo, Em, FlowRes, freq, h, HeatRatio, ItaAir, L);
    }


    /// <summary>
    /// Provides a single output, 11-input MWArrayinterface to the TMElastic MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Constant and variable definition
    /// </remarks>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="Em">Input argument #4</param>
    /// <param name="FlowRes">Input argument #5</param>
    /// <param name="freq">Input argument #6</param>
    /// <param name="h">Input argument #7</param>
    /// <param name="HeatRatio">Input argument #8</param>
    /// <param name="ItaAir">Input argument #9</param>
    /// <param name="L">Input argument #10</param>
    /// <param name="LFactor">Input argument #11</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray TMElastic(MWArray BulkDensity, MWArray c, MWArray Densityo, MWArray 
                       Em, MWArray FlowRes, MWArray freq, MWArray h, MWArray HeatRatio, 
                       MWArray ItaAir, MWArray L, MWArray LFactor)
    {
      return mcr.EvaluateFunction("TMElastic", BulkDensity, c, Densityo, Em, FlowRes, freq, h, HeatRatio, ItaAir, L, LFactor);
    }


    /// <summary>
    /// Provides a single output, 12-input MWArrayinterface to the TMElastic MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Constant and variable definition
    /// </remarks>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="Em">Input argument #4</param>
    /// <param name="FlowRes">Input argument #5</param>
    /// <param name="freq">Input argument #6</param>
    /// <param name="h">Input argument #7</param>
    /// <param name="HeatRatio">Input argument #8</param>
    /// <param name="ItaAir">Input argument #9</param>
    /// <param name="L">Input argument #10</param>
    /// <param name="LFactor">Input argument #11</param>
    /// <param name="Npr">Input argument #12</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray TMElastic(MWArray BulkDensity, MWArray c, MWArray Densityo, MWArray 
                       Em, MWArray FlowRes, MWArray freq, MWArray h, MWArray HeatRatio, 
                       MWArray ItaAir, MWArray L, MWArray LFactor, MWArray Npr)
    {
      return mcr.EvaluateFunction("TMElastic", BulkDensity, c, Densityo, Em, FlowRes, freq, h, HeatRatio, ItaAir, L, LFactor, Npr);
    }


    /// <summary>
    /// Provides a single output, 13-input MWArrayinterface to the TMElastic MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Constant and variable definition
    /// </remarks>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="Em">Input argument #4</param>
    /// <param name="FlowRes">Input argument #5</param>
    /// <param name="freq">Input argument #6</param>
    /// <param name="h">Input argument #7</param>
    /// <param name="HeatRatio">Input argument #8</param>
    /// <param name="ItaAir">Input argument #9</param>
    /// <param name="L">Input argument #10</param>
    /// <param name="LFactor">Input argument #11</param>
    /// <param name="Npr">Input argument #12</param>
    /// <param name="PRatio">Input argument #13</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray TMElastic(MWArray BulkDensity, MWArray c, MWArray Densityo, MWArray 
                       Em, MWArray FlowRes, MWArray freq, MWArray h, MWArray HeatRatio, 
                       MWArray ItaAir, MWArray L, MWArray LFactor, MWArray Npr, MWArray 
                       PRatio)
    {
      return mcr.EvaluateFunction("TMElastic", BulkDensity, c, Densityo, Em, FlowRes, freq, h, HeatRatio, ItaAir, L, LFactor, Npr, PRatio);
    }


    /// <summary>
    /// Provides a single output, 14-input MWArrayinterface to the TMElastic MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Constant and variable definition
    /// </remarks>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="Em">Input argument #4</param>
    /// <param name="FlowRes">Input argument #5</param>
    /// <param name="freq">Input argument #6</param>
    /// <param name="h">Input argument #7</param>
    /// <param name="HeatRatio">Input argument #8</param>
    /// <param name="ItaAir">Input argument #9</param>
    /// <param name="L">Input argument #10</param>
    /// <param name="LFactor">Input argument #11</param>
    /// <param name="Npr">Input argument #12</param>
    /// <param name="PRatio">Input argument #13</param>
    /// <param name="SFactor">Input argument #14</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray TMElastic(MWArray BulkDensity, MWArray c, MWArray Densityo, MWArray 
                       Em, MWArray FlowRes, MWArray freq, MWArray h, MWArray HeatRatio, 
                       MWArray ItaAir, MWArray L, MWArray LFactor, MWArray Npr, MWArray 
                       PRatio, MWArray SFactor)
    {
      return mcr.EvaluateFunction("TMElastic", BulkDensity, c, Densityo, Em, FlowRes, freq, h, HeatRatio, ItaAir, L, LFactor, Npr, PRatio, SFactor);
    }


    /// <summary>
    /// Provides a single output, 15-input MWArrayinterface to the TMElastic MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Constant and variable definition
    /// </remarks>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="Em">Input argument #4</param>
    /// <param name="FlowRes">Input argument #5</param>
    /// <param name="freq">Input argument #6</param>
    /// <param name="h">Input argument #7</param>
    /// <param name="HeatRatio">Input argument #8</param>
    /// <param name="ItaAir">Input argument #9</param>
    /// <param name="L">Input argument #10</param>
    /// <param name="LFactor">Input argument #11</param>
    /// <param name="Npr">Input argument #12</param>
    /// <param name="PRatio">Input argument #13</param>
    /// <param name="SFactor">Input argument #14</param>
    /// <param name="TCL">Input argument #15</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray TMElastic(MWArray BulkDensity, MWArray c, MWArray Densityo, MWArray 
                       Em, MWArray FlowRes, MWArray freq, MWArray h, MWArray HeatRatio, 
                       MWArray ItaAir, MWArray L, MWArray LFactor, MWArray Npr, MWArray 
                       PRatio, MWArray SFactor, MWArray TCL)
    {
      return mcr.EvaluateFunction("TMElastic", BulkDensity, c, Densityo, Em, FlowRes, freq, h, HeatRatio, ItaAir, L, LFactor, Npr, PRatio, SFactor, TCL);
    }


    /// <summary>
    /// Provides a single output, 16-input MWArrayinterface to the TMElastic MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Constant and variable definition
    /// </remarks>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="Em">Input argument #4</param>
    /// <param name="FlowRes">Input argument #5</param>
    /// <param name="freq">Input argument #6</param>
    /// <param name="h">Input argument #7</param>
    /// <param name="HeatRatio">Input argument #8</param>
    /// <param name="ItaAir">Input argument #9</param>
    /// <param name="L">Input argument #10</param>
    /// <param name="LFactor">Input argument #11</param>
    /// <param name="Npr">Input argument #12</param>
    /// <param name="PRatio">Input argument #13</param>
    /// <param name="SFactor">Input argument #14</param>
    /// <param name="TCL">Input argument #15</param>
    /// <param name="theta">Input argument #16</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray TMElastic(MWArray BulkDensity, MWArray c, MWArray Densityo, MWArray 
                       Em, MWArray FlowRes, MWArray freq, MWArray h, MWArray HeatRatio, 
                       MWArray ItaAir, MWArray L, MWArray LFactor, MWArray Npr, MWArray 
                       PRatio, MWArray SFactor, MWArray TCL, MWArray theta)
    {
      return mcr.EvaluateFunction("TMElastic", BulkDensity, c, Densityo, Em, FlowRes, freq, h, HeatRatio, ItaAir, L, LFactor, Npr, PRatio, SFactor, TCL, theta);
    }


    /// <summary>
    /// Provides a single output, 17-input MWArrayinterface to the TMElastic MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Constant and variable definition
    /// </remarks>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="Em">Input argument #4</param>
    /// <param name="FlowRes">Input argument #5</param>
    /// <param name="freq">Input argument #6</param>
    /// <param name="h">Input argument #7</param>
    /// <param name="HeatRatio">Input argument #8</param>
    /// <param name="ItaAir">Input argument #9</param>
    /// <param name="L">Input argument #10</param>
    /// <param name="LFactor">Input argument #11</param>
    /// <param name="Npr">Input argument #12</param>
    /// <param name="PRatio">Input argument #13</param>
    /// <param name="SFactor">Input argument #14</param>
    /// <param name="TCL">Input argument #15</param>
    /// <param name="theta">Input argument #16</param>
    /// <param name="VCL">Input argument #17</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray TMElastic(MWArray BulkDensity, MWArray c, MWArray Densityo, MWArray 
                       Em, MWArray FlowRes, MWArray freq, MWArray h, MWArray HeatRatio, 
                       MWArray ItaAir, MWArray L, MWArray LFactor, MWArray Npr, MWArray 
                       PRatio, MWArray SFactor, MWArray TCL, MWArray theta, MWArray VCL)
    {
      return mcr.EvaluateFunction("TMElastic", BulkDensity, c, Densityo, Em, FlowRes, freq, h, HeatRatio, ItaAir, L, LFactor, Npr, PRatio, SFactor, TCL, theta, VCL);
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the TMElastic MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Constant and variable definition
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] TMElastic(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "TMElastic", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 1-input MWArray interface to the TMElastic MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Constant and variable definition
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] TMElastic(int numArgsOut, MWArray BulkDensity)
    {
      return mcr.EvaluateFunction(numArgsOut, "TMElastic", BulkDensity);
    }


    /// <summary>
    /// Provides the standard 2-input MWArray interface to the TMElastic MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Constant and variable definition
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] TMElastic(int numArgsOut, MWArray BulkDensity, MWArray c)
    {
      return mcr.EvaluateFunction(numArgsOut, "TMElastic", BulkDensity, c);
    }


    /// <summary>
    /// Provides the standard 3-input MWArray interface to the TMElastic MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Constant and variable definition
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] TMElastic(int numArgsOut, MWArray BulkDensity, MWArray c, MWArray 
                         Densityo)
    {
      return mcr.EvaluateFunction(numArgsOut, "TMElastic", BulkDensity, c, Densityo);
    }


    /// <summary>
    /// Provides the standard 4-input MWArray interface to the TMElastic MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Constant and variable definition
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="Em">Input argument #4</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] TMElastic(int numArgsOut, MWArray BulkDensity, MWArray c, MWArray 
                         Densityo, MWArray Em)
    {
      return mcr.EvaluateFunction(numArgsOut, "TMElastic", BulkDensity, c, Densityo, Em);
    }


    /// <summary>
    /// Provides the standard 5-input MWArray interface to the TMElastic MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Constant and variable definition
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="Em">Input argument #4</param>
    /// <param name="FlowRes">Input argument #5</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] TMElastic(int numArgsOut, MWArray BulkDensity, MWArray c, MWArray 
                         Densityo, MWArray Em, MWArray FlowRes)
    {
      return mcr.EvaluateFunction(numArgsOut, "TMElastic", BulkDensity, c, Densityo, Em, FlowRes);
    }


    /// <summary>
    /// Provides the standard 6-input MWArray interface to the TMElastic MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Constant and variable definition
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="Em">Input argument #4</param>
    /// <param name="FlowRes">Input argument #5</param>
    /// <param name="freq">Input argument #6</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] TMElastic(int numArgsOut, MWArray BulkDensity, MWArray c, MWArray 
                         Densityo, MWArray Em, MWArray FlowRes, MWArray freq)
    {
      return mcr.EvaluateFunction(numArgsOut, "TMElastic", BulkDensity, c, Densityo, Em, FlowRes, freq);
    }


    /// <summary>
    /// Provides the standard 7-input MWArray interface to the TMElastic MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Constant and variable definition
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="Em">Input argument #4</param>
    /// <param name="FlowRes">Input argument #5</param>
    /// <param name="freq">Input argument #6</param>
    /// <param name="h">Input argument #7</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] TMElastic(int numArgsOut, MWArray BulkDensity, MWArray c, MWArray 
                         Densityo, MWArray Em, MWArray FlowRes, MWArray freq, MWArray h)
    {
      return mcr.EvaluateFunction(numArgsOut, "TMElastic", BulkDensity, c, Densityo, Em, FlowRes, freq, h);
    }


    /// <summary>
    /// Provides the standard 8-input MWArray interface to the TMElastic MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Constant and variable definition
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="Em">Input argument #4</param>
    /// <param name="FlowRes">Input argument #5</param>
    /// <param name="freq">Input argument #6</param>
    /// <param name="h">Input argument #7</param>
    /// <param name="HeatRatio">Input argument #8</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] TMElastic(int numArgsOut, MWArray BulkDensity, MWArray c, MWArray 
                         Densityo, MWArray Em, MWArray FlowRes, MWArray freq, MWArray h, 
                         MWArray HeatRatio)
    {
      return mcr.EvaluateFunction(numArgsOut, "TMElastic", BulkDensity, c, Densityo, Em, FlowRes, freq, h, HeatRatio);
    }


    /// <summary>
    /// Provides the standard 9-input MWArray interface to the TMElastic MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Constant and variable definition
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="Em">Input argument #4</param>
    /// <param name="FlowRes">Input argument #5</param>
    /// <param name="freq">Input argument #6</param>
    /// <param name="h">Input argument #7</param>
    /// <param name="HeatRatio">Input argument #8</param>
    /// <param name="ItaAir">Input argument #9</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] TMElastic(int numArgsOut, MWArray BulkDensity, MWArray c, MWArray 
                         Densityo, MWArray Em, MWArray FlowRes, MWArray freq, MWArray h, 
                         MWArray HeatRatio, MWArray ItaAir)
    {
      return mcr.EvaluateFunction(numArgsOut, "TMElastic", BulkDensity, c, Densityo, Em, FlowRes, freq, h, HeatRatio, ItaAir);
    }


    /// <summary>
    /// Provides the standard 10-input MWArray interface to the TMElastic MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Constant and variable definition
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="Em">Input argument #4</param>
    /// <param name="FlowRes">Input argument #5</param>
    /// <param name="freq">Input argument #6</param>
    /// <param name="h">Input argument #7</param>
    /// <param name="HeatRatio">Input argument #8</param>
    /// <param name="ItaAir">Input argument #9</param>
    /// <param name="L">Input argument #10</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] TMElastic(int numArgsOut, MWArray BulkDensity, MWArray c, MWArray 
                         Densityo, MWArray Em, MWArray FlowRes, MWArray freq, MWArray h, 
                         MWArray HeatRatio, MWArray ItaAir, MWArray L)
    {
      return mcr.EvaluateFunction(numArgsOut, "TMElastic", BulkDensity, c, Densityo, Em, FlowRes, freq, h, HeatRatio, ItaAir, L);
    }


    /// <summary>
    /// Provides the standard 11-input MWArray interface to the TMElastic MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Constant and variable definition
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="Em">Input argument #4</param>
    /// <param name="FlowRes">Input argument #5</param>
    /// <param name="freq">Input argument #6</param>
    /// <param name="h">Input argument #7</param>
    /// <param name="HeatRatio">Input argument #8</param>
    /// <param name="ItaAir">Input argument #9</param>
    /// <param name="L">Input argument #10</param>
    /// <param name="LFactor">Input argument #11</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] TMElastic(int numArgsOut, MWArray BulkDensity, MWArray c, MWArray 
                         Densityo, MWArray Em, MWArray FlowRes, MWArray freq, MWArray h, 
                         MWArray HeatRatio, MWArray ItaAir, MWArray L, MWArray LFactor)
    {
      return mcr.EvaluateFunction(numArgsOut, "TMElastic", BulkDensity, c, Densityo, Em, FlowRes, freq, h, HeatRatio, ItaAir, L, LFactor);
    }


    /// <summary>
    /// Provides the standard 12-input MWArray interface to the TMElastic MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Constant and variable definition
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="Em">Input argument #4</param>
    /// <param name="FlowRes">Input argument #5</param>
    /// <param name="freq">Input argument #6</param>
    /// <param name="h">Input argument #7</param>
    /// <param name="HeatRatio">Input argument #8</param>
    /// <param name="ItaAir">Input argument #9</param>
    /// <param name="L">Input argument #10</param>
    /// <param name="LFactor">Input argument #11</param>
    /// <param name="Npr">Input argument #12</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] TMElastic(int numArgsOut, MWArray BulkDensity, MWArray c, MWArray 
                         Densityo, MWArray Em, MWArray FlowRes, MWArray freq, MWArray h, 
                         MWArray HeatRatio, MWArray ItaAir, MWArray L, MWArray LFactor, 
                         MWArray Npr)
    {
      return mcr.EvaluateFunction(numArgsOut, "TMElastic", BulkDensity, c, Densityo, Em, FlowRes, freq, h, HeatRatio, ItaAir, L, LFactor, Npr);
    }


    /// <summary>
    /// Provides the standard 13-input MWArray interface to the TMElastic MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Constant and variable definition
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="Em">Input argument #4</param>
    /// <param name="FlowRes">Input argument #5</param>
    /// <param name="freq">Input argument #6</param>
    /// <param name="h">Input argument #7</param>
    /// <param name="HeatRatio">Input argument #8</param>
    /// <param name="ItaAir">Input argument #9</param>
    /// <param name="L">Input argument #10</param>
    /// <param name="LFactor">Input argument #11</param>
    /// <param name="Npr">Input argument #12</param>
    /// <param name="PRatio">Input argument #13</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] TMElastic(int numArgsOut, MWArray BulkDensity, MWArray c, MWArray 
                         Densityo, MWArray Em, MWArray FlowRes, MWArray freq, MWArray h, 
                         MWArray HeatRatio, MWArray ItaAir, MWArray L, MWArray LFactor, 
                         MWArray Npr, MWArray PRatio)
    {
      return mcr.EvaluateFunction(numArgsOut, "TMElastic", BulkDensity, c, Densityo, Em, FlowRes, freq, h, HeatRatio, ItaAir, L, LFactor, Npr, PRatio);
    }


    /// <summary>
    /// Provides the standard 14-input MWArray interface to the TMElastic MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Constant and variable definition
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="Em">Input argument #4</param>
    /// <param name="FlowRes">Input argument #5</param>
    /// <param name="freq">Input argument #6</param>
    /// <param name="h">Input argument #7</param>
    /// <param name="HeatRatio">Input argument #8</param>
    /// <param name="ItaAir">Input argument #9</param>
    /// <param name="L">Input argument #10</param>
    /// <param name="LFactor">Input argument #11</param>
    /// <param name="Npr">Input argument #12</param>
    /// <param name="PRatio">Input argument #13</param>
    /// <param name="SFactor">Input argument #14</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] TMElastic(int numArgsOut, MWArray BulkDensity, MWArray c, MWArray 
                         Densityo, MWArray Em, MWArray FlowRes, MWArray freq, MWArray h, 
                         MWArray HeatRatio, MWArray ItaAir, MWArray L, MWArray LFactor, 
                         MWArray Npr, MWArray PRatio, MWArray SFactor)
    {
      return mcr.EvaluateFunction(numArgsOut, "TMElastic", BulkDensity, c, Densityo, Em, FlowRes, freq, h, HeatRatio, ItaAir, L, LFactor, Npr, PRatio, SFactor);
    }


    /// <summary>
    /// Provides the standard 15-input MWArray interface to the TMElastic MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Constant and variable definition
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="Em">Input argument #4</param>
    /// <param name="FlowRes">Input argument #5</param>
    /// <param name="freq">Input argument #6</param>
    /// <param name="h">Input argument #7</param>
    /// <param name="HeatRatio">Input argument #8</param>
    /// <param name="ItaAir">Input argument #9</param>
    /// <param name="L">Input argument #10</param>
    /// <param name="LFactor">Input argument #11</param>
    /// <param name="Npr">Input argument #12</param>
    /// <param name="PRatio">Input argument #13</param>
    /// <param name="SFactor">Input argument #14</param>
    /// <param name="TCL">Input argument #15</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] TMElastic(int numArgsOut, MWArray BulkDensity, MWArray c, MWArray 
                         Densityo, MWArray Em, MWArray FlowRes, MWArray freq, MWArray h, 
                         MWArray HeatRatio, MWArray ItaAir, MWArray L, MWArray LFactor, 
                         MWArray Npr, MWArray PRatio, MWArray SFactor, MWArray TCL)
    {
      return mcr.EvaluateFunction(numArgsOut, "TMElastic", BulkDensity, c, Densityo, Em, FlowRes, freq, h, HeatRatio, ItaAir, L, LFactor, Npr, PRatio, SFactor, TCL);
    }


    /// <summary>
    /// Provides the standard 16-input MWArray interface to the TMElastic MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Constant and variable definition
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="Em">Input argument #4</param>
    /// <param name="FlowRes">Input argument #5</param>
    /// <param name="freq">Input argument #6</param>
    /// <param name="h">Input argument #7</param>
    /// <param name="HeatRatio">Input argument #8</param>
    /// <param name="ItaAir">Input argument #9</param>
    /// <param name="L">Input argument #10</param>
    /// <param name="LFactor">Input argument #11</param>
    /// <param name="Npr">Input argument #12</param>
    /// <param name="PRatio">Input argument #13</param>
    /// <param name="SFactor">Input argument #14</param>
    /// <param name="TCL">Input argument #15</param>
    /// <param name="theta">Input argument #16</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] TMElastic(int numArgsOut, MWArray BulkDensity, MWArray c, MWArray 
                         Densityo, MWArray Em, MWArray FlowRes, MWArray freq, MWArray h, 
                         MWArray HeatRatio, MWArray ItaAir, MWArray L, MWArray LFactor, 
                         MWArray Npr, MWArray PRatio, MWArray SFactor, MWArray TCL, 
                         MWArray theta)
    {
      return mcr.EvaluateFunction(numArgsOut, "TMElastic", BulkDensity, c, Densityo, Em, FlowRes, freq, h, HeatRatio, ItaAir, L, LFactor, Npr, PRatio, SFactor, TCL, theta);
    }


    /// <summary>
    /// Provides the standard 17-input MWArray interface to the TMElastic MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Constant and variable definition
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="Em">Input argument #4</param>
    /// <param name="FlowRes">Input argument #5</param>
    /// <param name="freq">Input argument #6</param>
    /// <param name="h">Input argument #7</param>
    /// <param name="HeatRatio">Input argument #8</param>
    /// <param name="ItaAir">Input argument #9</param>
    /// <param name="L">Input argument #10</param>
    /// <param name="LFactor">Input argument #11</param>
    /// <param name="Npr">Input argument #12</param>
    /// <param name="PRatio">Input argument #13</param>
    /// <param name="SFactor">Input argument #14</param>
    /// <param name="TCL">Input argument #15</param>
    /// <param name="theta">Input argument #16</param>
    /// <param name="VCL">Input argument #17</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] TMElastic(int numArgsOut, MWArray BulkDensity, MWArray c, MWArray 
                         Densityo, MWArray Em, MWArray FlowRes, MWArray freq, MWArray h, 
                         MWArray HeatRatio, MWArray ItaAir, MWArray L, MWArray LFactor, 
                         MWArray Npr, MWArray PRatio, MWArray SFactor, MWArray TCL, 
                         MWArray theta, MWArray VCL)
    {
      return mcr.EvaluateFunction(numArgsOut, "TMElastic", BulkDensity, c, Densityo, Em, FlowRes, freq, h, HeatRatio, ItaAir, L, LFactor, Npr, PRatio, SFactor, TCL, theta, VCL);
    }


    /// <summary>
    /// Provides an interface for the TMElastic function in which the input and output
    /// arguments are specified as an array of MWArrays.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// M-Documentation:
    /// Constant and variable definition
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of MWArray output arguments</param>
    /// <param name= "argsIn">Array of MWArray input arguments</param>
    ///
    public void TMElastic(int numArgsOut, ref MWArray[] argsOut, MWArray[] argsIn)
    {
      mcr.EvaluateFunction("TMElastic", numArgsOut, ref argsOut, argsIn);
    }


    /// <summary>
    /// Provides a single output, 0-input MWArrayinterface to the TMElasticPanel MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This is a function program to define the transfer matrix for foam-panel layer
    /// </remarks>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray TMElasticPanel()
    {
      return mcr.EvaluateFunction("TMElasticPanel", new MWArray[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input MWArrayinterface to the TMElasticPanel MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This is a function program to define the transfer matrix for foam-panel layer
    /// </remarks>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray TMElasticPanel(MWArray BulkDensity)
    {
      return mcr.EvaluateFunction("TMElasticPanel", BulkDensity);
    }


    /// <summary>
    /// Provides a single output, 2-input MWArrayinterface to the TMElasticPanel MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This is a function program to define the transfer matrix for foam-panel layer
    /// </remarks>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray TMElasticPanel(MWArray BulkDensity, MWArray c)
    {
      return mcr.EvaluateFunction("TMElasticPanel", BulkDensity, c);
    }


    /// <summary>
    /// Provides a single output, 3-input MWArrayinterface to the TMElasticPanel MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This is a function program to define the transfer matrix for foam-panel layer
    /// </remarks>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray TMElasticPanel(MWArray BulkDensity, MWArray c, MWArray Densityo)
    {
      return mcr.EvaluateFunction("TMElasticPanel", BulkDensity, c, Densityo);
    }


    /// <summary>
    /// Provides a single output, 4-input MWArrayinterface to the TMElasticPanel MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This is a function program to define the transfer matrix for foam-panel layer
    /// </remarks>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="Densityp">Input argument #4</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray TMElasticPanel(MWArray BulkDensity, MWArray c, MWArray Densityo, 
                            MWArray Densityp)
    {
      return mcr.EvaluateFunction("TMElasticPanel", BulkDensity, c, Densityo, Densityp);
    }


    /// <summary>
    /// Provides a single output, 5-input MWArrayinterface to the TMElasticPanel MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This is a function program to define the transfer matrix for foam-panel layer
    /// </remarks>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="Densityp">Input argument #4</param>
    /// <param name="Em">Input argument #5</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray TMElasticPanel(MWArray BulkDensity, MWArray c, MWArray Densityo, 
                            MWArray Densityp, MWArray Em)
    {
      return mcr.EvaluateFunction("TMElasticPanel", BulkDensity, c, Densityo, Densityp, Em);
    }


    /// <summary>
    /// Provides a single output, 6-input MWArrayinterface to the TMElasticPanel MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This is a function program to define the transfer matrix for foam-panel layer
    /// </remarks>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="Densityp">Input argument #4</param>
    /// <param name="Em">Input argument #5</param>
    /// <param name="Ep">Input argument #6</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray TMElasticPanel(MWArray BulkDensity, MWArray c, MWArray Densityo, 
                            MWArray Densityp, MWArray Em, MWArray Ep)
    {
      return mcr.EvaluateFunction("TMElasticPanel", BulkDensity, c, Densityo, Densityp, Em, Ep);
    }


    /// <summary>
    /// Provides a single output, 7-input MWArrayinterface to the TMElasticPanel MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This is a function program to define the transfer matrix for foam-panel layer
    /// </remarks>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="Densityp">Input argument #4</param>
    /// <param name="Em">Input argument #5</param>
    /// <param name="Ep">Input argument #6</param>
    /// <param name="FlowRes">Input argument #7</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray TMElasticPanel(MWArray BulkDensity, MWArray c, MWArray Densityo, 
                            MWArray Densityp, MWArray Em, MWArray Ep, MWArray FlowRes)
    {
      return mcr.EvaluateFunction("TMElasticPanel", BulkDensity, c, Densityo, Densityp, Em, Ep, FlowRes);
    }


    /// <summary>
    /// Provides a single output, 8-input MWArrayinterface to the TMElasticPanel MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This is a function program to define the transfer matrix for foam-panel layer
    /// </remarks>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="Densityp">Input argument #4</param>
    /// <param name="Em">Input argument #5</param>
    /// <param name="Ep">Input argument #6</param>
    /// <param name="FlowRes">Input argument #7</param>
    /// <param name="freq">Input argument #8</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray TMElasticPanel(MWArray BulkDensity, MWArray c, MWArray Densityo, 
                            MWArray Densityp, MWArray Em, MWArray Ep, MWArray FlowRes, 
                            MWArray freq)
    {
      return mcr.EvaluateFunction("TMElasticPanel", BulkDensity, c, Densityo, Densityp, Em, Ep, FlowRes, freq);
    }


    /// <summary>
    /// Provides a single output, 9-input MWArrayinterface to the TMElasticPanel MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This is a function program to define the transfer matrix for foam-panel layer
    /// </remarks>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="Densityp">Input argument #4</param>
    /// <param name="Em">Input argument #5</param>
    /// <param name="Ep">Input argument #6</param>
    /// <param name="FlowRes">Input argument #7</param>
    /// <param name="freq">Input argument #8</param>
    /// <param name="h">Input argument #9</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray TMElasticPanel(MWArray BulkDensity, MWArray c, MWArray Densityo, 
                            MWArray Densityp, MWArray Em, MWArray Ep, MWArray FlowRes, 
                            MWArray freq, MWArray h)
    {
      return mcr.EvaluateFunction("TMElasticPanel", BulkDensity, c, Densityo, Densityp, Em, Ep, FlowRes, freq, h);
    }


    /// <summary>
    /// Provides a single output, 10-input MWArrayinterface to the TMElasticPanel MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This is a function program to define the transfer matrix for foam-panel layer
    /// </remarks>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="Densityp">Input argument #4</param>
    /// <param name="Em">Input argument #5</param>
    /// <param name="Ep">Input argument #6</param>
    /// <param name="FlowRes">Input argument #7</param>
    /// <param name="freq">Input argument #8</param>
    /// <param name="h">Input argument #9</param>
    /// <param name="HeatRatio">Input argument #10</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray TMElasticPanel(MWArray BulkDensity, MWArray c, MWArray Densityo, 
                            MWArray Densityp, MWArray Em, MWArray Ep, MWArray FlowRes, 
                            MWArray freq, MWArray h, MWArray HeatRatio)
    {
      return mcr.EvaluateFunction("TMElasticPanel", BulkDensity, c, Densityo, Densityp, Em, Ep, FlowRes, freq, h, HeatRatio);
    }


    /// <summary>
    /// Provides a single output, 11-input MWArrayinterface to the TMElasticPanel MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This is a function program to define the transfer matrix for foam-panel layer
    /// </remarks>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="Densityp">Input argument #4</param>
    /// <param name="Em">Input argument #5</param>
    /// <param name="Ep">Input argument #6</param>
    /// <param name="FlowRes">Input argument #7</param>
    /// <param name="freq">Input argument #8</param>
    /// <param name="h">Input argument #9</param>
    /// <param name="HeatRatio">Input argument #10</param>
    /// <param name="hp">Input argument #11</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray TMElasticPanel(MWArray BulkDensity, MWArray c, MWArray Densityo, 
                            MWArray Densityp, MWArray Em, MWArray Ep, MWArray FlowRes, 
                            MWArray freq, MWArray h, MWArray HeatRatio, MWArray hp)
    {
      return mcr.EvaluateFunction("TMElasticPanel", BulkDensity, c, Densityo, Densityp, Em, Ep, FlowRes, freq, h, HeatRatio, hp);
    }


    /// <summary>
    /// Provides a single output, 12-input MWArrayinterface to the TMElasticPanel MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This is a function program to define the transfer matrix for foam-panel layer
    /// </remarks>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="Densityp">Input argument #4</param>
    /// <param name="Em">Input argument #5</param>
    /// <param name="Ep">Input argument #6</param>
    /// <param name="FlowRes">Input argument #7</param>
    /// <param name="freq">Input argument #8</param>
    /// <param name="h">Input argument #9</param>
    /// <param name="HeatRatio">Input argument #10</param>
    /// <param name="hp">Input argument #11</param>
    /// <param name="ItaAir">Input argument #12</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray TMElasticPanel(MWArray BulkDensity, MWArray c, MWArray Densityo, 
                            MWArray Densityp, MWArray Em, MWArray Ep, MWArray FlowRes, 
                            MWArray freq, MWArray h, MWArray HeatRatio, MWArray hp, 
                            MWArray ItaAir)
    {
      return mcr.EvaluateFunction("TMElasticPanel", BulkDensity, c, Densityo, Densityp, Em, Ep, FlowRes, freq, h, HeatRatio, hp, ItaAir);
    }


    /// <summary>
    /// Provides a single output, 13-input MWArrayinterface to the TMElasticPanel MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This is a function program to define the transfer matrix for foam-panel layer
    /// </remarks>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="Densityp">Input argument #4</param>
    /// <param name="Em">Input argument #5</param>
    /// <param name="Ep">Input argument #6</param>
    /// <param name="FlowRes">Input argument #7</param>
    /// <param name="freq">Input argument #8</param>
    /// <param name="h">Input argument #9</param>
    /// <param name="HeatRatio">Input argument #10</param>
    /// <param name="hp">Input argument #11</param>
    /// <param name="ItaAir">Input argument #12</param>
    /// <param name="L">Input argument #13</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray TMElasticPanel(MWArray BulkDensity, MWArray c, MWArray Densityo, 
                            MWArray Densityp, MWArray Em, MWArray Ep, MWArray FlowRes, 
                            MWArray freq, MWArray h, MWArray HeatRatio, MWArray hp, 
                            MWArray ItaAir, MWArray L)
    {
      return mcr.EvaluateFunction("TMElasticPanel", BulkDensity, c, Densityo, Densityp, Em, Ep, FlowRes, freq, h, HeatRatio, hp, ItaAir, L);
    }


    /// <summary>
    /// Provides a single output, 14-input MWArrayinterface to the TMElasticPanel MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This is a function program to define the transfer matrix for foam-panel layer
    /// </remarks>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="Densityp">Input argument #4</param>
    /// <param name="Em">Input argument #5</param>
    /// <param name="Ep">Input argument #6</param>
    /// <param name="FlowRes">Input argument #7</param>
    /// <param name="freq">Input argument #8</param>
    /// <param name="h">Input argument #9</param>
    /// <param name="HeatRatio">Input argument #10</param>
    /// <param name="hp">Input argument #11</param>
    /// <param name="ItaAir">Input argument #12</param>
    /// <param name="L">Input argument #13</param>
    /// <param name="LFactor">Input argument #14</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray TMElasticPanel(MWArray BulkDensity, MWArray c, MWArray Densityo, 
                            MWArray Densityp, MWArray Em, MWArray Ep, MWArray FlowRes, 
                            MWArray freq, MWArray h, MWArray HeatRatio, MWArray hp, 
                            MWArray ItaAir, MWArray L, MWArray LFactor)
    {
      return mcr.EvaluateFunction("TMElasticPanel", BulkDensity, c, Densityo, Densityp, Em, Ep, FlowRes, freq, h, HeatRatio, hp, ItaAir, L, LFactor);
    }


    /// <summary>
    /// Provides a single output, 15-input MWArrayinterface to the TMElasticPanel MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This is a function program to define the transfer matrix for foam-panel layer
    /// </remarks>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="Densityp">Input argument #4</param>
    /// <param name="Em">Input argument #5</param>
    /// <param name="Ep">Input argument #6</param>
    /// <param name="FlowRes">Input argument #7</param>
    /// <param name="freq">Input argument #8</param>
    /// <param name="h">Input argument #9</param>
    /// <param name="HeatRatio">Input argument #10</param>
    /// <param name="hp">Input argument #11</param>
    /// <param name="ItaAir">Input argument #12</param>
    /// <param name="L">Input argument #13</param>
    /// <param name="LFactor">Input argument #14</param>
    /// <param name="Npr">Input argument #15</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray TMElasticPanel(MWArray BulkDensity, MWArray c, MWArray Densityo, 
                            MWArray Densityp, MWArray Em, MWArray Ep, MWArray FlowRes, 
                            MWArray freq, MWArray h, MWArray HeatRatio, MWArray hp, 
                            MWArray ItaAir, MWArray L, MWArray LFactor, MWArray Npr)
    {
      return mcr.EvaluateFunction("TMElasticPanel", BulkDensity, c, Densityo, Densityp, Em, Ep, FlowRes, freq, h, HeatRatio, hp, ItaAir, L, LFactor, Npr);
    }


    /// <summary>
    /// Provides a single output, 16-input MWArrayinterface to the TMElasticPanel MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This is a function program to define the transfer matrix for foam-panel layer
    /// </remarks>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="Densityp">Input argument #4</param>
    /// <param name="Em">Input argument #5</param>
    /// <param name="Ep">Input argument #6</param>
    /// <param name="FlowRes">Input argument #7</param>
    /// <param name="freq">Input argument #8</param>
    /// <param name="h">Input argument #9</param>
    /// <param name="HeatRatio">Input argument #10</param>
    /// <param name="hp">Input argument #11</param>
    /// <param name="ItaAir">Input argument #12</param>
    /// <param name="L">Input argument #13</param>
    /// <param name="LFactor">Input argument #14</param>
    /// <param name="Npr">Input argument #15</param>
    /// <param name="PRatio">Input argument #16</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray TMElasticPanel(MWArray BulkDensity, MWArray c, MWArray Densityo, 
                            MWArray Densityp, MWArray Em, MWArray Ep, MWArray FlowRes, 
                            MWArray freq, MWArray h, MWArray HeatRatio, MWArray hp, 
                            MWArray ItaAir, MWArray L, MWArray LFactor, MWArray Npr, 
                            MWArray PRatio)
    {
      return mcr.EvaluateFunction("TMElasticPanel", BulkDensity, c, Densityo, Densityp, Em, Ep, FlowRes, freq, h, HeatRatio, hp, ItaAir, L, LFactor, Npr, PRatio);
    }


    /// <summary>
    /// Provides a single output, 17-input MWArrayinterface to the TMElasticPanel MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This is a function program to define the transfer matrix for foam-panel layer
    /// </remarks>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="Densityp">Input argument #4</param>
    /// <param name="Em">Input argument #5</param>
    /// <param name="Ep">Input argument #6</param>
    /// <param name="FlowRes">Input argument #7</param>
    /// <param name="freq">Input argument #8</param>
    /// <param name="h">Input argument #9</param>
    /// <param name="HeatRatio">Input argument #10</param>
    /// <param name="hp">Input argument #11</param>
    /// <param name="ItaAir">Input argument #12</param>
    /// <param name="L">Input argument #13</param>
    /// <param name="LFactor">Input argument #14</param>
    /// <param name="Npr">Input argument #15</param>
    /// <param name="PRatio">Input argument #16</param>
    /// <param name="PRatiop">Input argument #17</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray TMElasticPanel(MWArray BulkDensity, MWArray c, MWArray Densityo, 
                            MWArray Densityp, MWArray Em, MWArray Ep, MWArray FlowRes, 
                            MWArray freq, MWArray h, MWArray HeatRatio, MWArray hp, 
                            MWArray ItaAir, MWArray L, MWArray LFactor, MWArray Npr, 
                            MWArray PRatio, MWArray PRatiop)
    {
      return mcr.EvaluateFunction("TMElasticPanel", BulkDensity, c, Densityo, Densityp, Em, Ep, FlowRes, freq, h, HeatRatio, hp, ItaAir, L, LFactor, Npr, PRatio, PRatiop);
    }


    /// <summary>
    /// Provides a single output, 18-input MWArrayinterface to the TMElasticPanel MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This is a function program to define the transfer matrix for foam-panel layer
    /// </remarks>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="Densityp">Input argument #4</param>
    /// <param name="Em">Input argument #5</param>
    /// <param name="Ep">Input argument #6</param>
    /// <param name="FlowRes">Input argument #7</param>
    /// <param name="freq">Input argument #8</param>
    /// <param name="h">Input argument #9</param>
    /// <param name="HeatRatio">Input argument #10</param>
    /// <param name="hp">Input argument #11</param>
    /// <param name="ItaAir">Input argument #12</param>
    /// <param name="L">Input argument #13</param>
    /// <param name="LFactor">Input argument #14</param>
    /// <param name="Npr">Input argument #15</param>
    /// <param name="PRatio">Input argument #16</param>
    /// <param name="PRatiop">Input argument #17</param>
    /// <param name="SFactor">Input argument #18</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray TMElasticPanel(MWArray BulkDensity, MWArray c, MWArray Densityo, 
                            MWArray Densityp, MWArray Em, MWArray Ep, MWArray FlowRes, 
                            MWArray freq, MWArray h, MWArray HeatRatio, MWArray hp, 
                            MWArray ItaAir, MWArray L, MWArray LFactor, MWArray Npr, 
                            MWArray PRatio, MWArray PRatiop, MWArray SFactor)
    {
      return mcr.EvaluateFunction("TMElasticPanel", BulkDensity, c, Densityo, Densityp, Em, Ep, FlowRes, freq, h, HeatRatio, hp, ItaAir, L, LFactor, Npr, PRatio, PRatiop, SFactor);
    }


    /// <summary>
    /// Provides a single output, 19-input MWArrayinterface to the TMElasticPanel MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This is a function program to define the transfer matrix for foam-panel layer
    /// </remarks>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="Densityp">Input argument #4</param>
    /// <param name="Em">Input argument #5</param>
    /// <param name="Ep">Input argument #6</param>
    /// <param name="FlowRes">Input argument #7</param>
    /// <param name="freq">Input argument #8</param>
    /// <param name="h">Input argument #9</param>
    /// <param name="HeatRatio">Input argument #10</param>
    /// <param name="hp">Input argument #11</param>
    /// <param name="ItaAir">Input argument #12</param>
    /// <param name="L">Input argument #13</param>
    /// <param name="LFactor">Input argument #14</param>
    /// <param name="Npr">Input argument #15</param>
    /// <param name="PRatio">Input argument #16</param>
    /// <param name="PRatiop">Input argument #17</param>
    /// <param name="SFactor">Input argument #18</param>
    /// <param name="TCL">Input argument #19</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray TMElasticPanel(MWArray BulkDensity, MWArray c, MWArray Densityo, 
                            MWArray Densityp, MWArray Em, MWArray Ep, MWArray FlowRes, 
                            MWArray freq, MWArray h, MWArray HeatRatio, MWArray hp, 
                            MWArray ItaAir, MWArray L, MWArray LFactor, MWArray Npr, 
                            MWArray PRatio, MWArray PRatiop, MWArray SFactor, MWArray TCL)
    {
      return mcr.EvaluateFunction("TMElasticPanel", BulkDensity, c, Densityo, Densityp, Em, Ep, FlowRes, freq, h, HeatRatio, hp, ItaAir, L, LFactor, Npr, PRatio, PRatiop, SFactor, TCL);
    }


    /// <summary>
    /// Provides a single output, 20-input MWArrayinterface to the TMElasticPanel MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This is a function program to define the transfer matrix for foam-panel layer
    /// </remarks>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="Densityp">Input argument #4</param>
    /// <param name="Em">Input argument #5</param>
    /// <param name="Ep">Input argument #6</param>
    /// <param name="FlowRes">Input argument #7</param>
    /// <param name="freq">Input argument #8</param>
    /// <param name="h">Input argument #9</param>
    /// <param name="HeatRatio">Input argument #10</param>
    /// <param name="hp">Input argument #11</param>
    /// <param name="ItaAir">Input argument #12</param>
    /// <param name="L">Input argument #13</param>
    /// <param name="LFactor">Input argument #14</param>
    /// <param name="Npr">Input argument #15</param>
    /// <param name="PRatio">Input argument #16</param>
    /// <param name="PRatiop">Input argument #17</param>
    /// <param name="SFactor">Input argument #18</param>
    /// <param name="TCL">Input argument #19</param>
    /// <param name="theta">Input argument #20</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray TMElasticPanel(MWArray BulkDensity, MWArray c, MWArray Densityo, 
                            MWArray Densityp, MWArray Em, MWArray Ep, MWArray FlowRes, 
                            MWArray freq, MWArray h, MWArray HeatRatio, MWArray hp, 
                            MWArray ItaAir, MWArray L, MWArray LFactor, MWArray Npr, 
                            MWArray PRatio, MWArray PRatiop, MWArray SFactor, MWArray 
                            TCL, MWArray theta)
    {
      return mcr.EvaluateFunction("TMElasticPanel", BulkDensity, c, Densityo, Densityp, Em, Ep, FlowRes, freq, h, HeatRatio, hp, ItaAir, L, LFactor, Npr, PRatio, PRatiop, SFactor, TCL, theta);
    }


    /// <summary>
    /// Provides a single output, 21-input MWArrayinterface to the TMElasticPanel MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This is a function program to define the transfer matrix for foam-panel layer
    /// </remarks>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="Densityp">Input argument #4</param>
    /// <param name="Em">Input argument #5</param>
    /// <param name="Ep">Input argument #6</param>
    /// <param name="FlowRes">Input argument #7</param>
    /// <param name="freq">Input argument #8</param>
    /// <param name="h">Input argument #9</param>
    /// <param name="HeatRatio">Input argument #10</param>
    /// <param name="hp">Input argument #11</param>
    /// <param name="ItaAir">Input argument #12</param>
    /// <param name="L">Input argument #13</param>
    /// <param name="LFactor">Input argument #14</param>
    /// <param name="Npr">Input argument #15</param>
    /// <param name="PRatio">Input argument #16</param>
    /// <param name="PRatiop">Input argument #17</param>
    /// <param name="SFactor">Input argument #18</param>
    /// <param name="TCL">Input argument #19</param>
    /// <param name="theta">Input argument #20</param>
    /// <param name="VCL">Input argument #21</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray TMElasticPanel(MWArray BulkDensity, MWArray c, MWArray Densityo, 
                            MWArray Densityp, MWArray Em, MWArray Ep, MWArray FlowRes, 
                            MWArray freq, MWArray h, MWArray HeatRatio, MWArray hp, 
                            MWArray ItaAir, MWArray L, MWArray LFactor, MWArray Npr, 
                            MWArray PRatio, MWArray PRatiop, MWArray SFactor, MWArray 
                            TCL, MWArray theta, MWArray VCL)
    {
      return mcr.EvaluateFunction("TMElasticPanel", BulkDensity, c, Densityo, Densityp, Em, Ep, FlowRes, freq, h, HeatRatio, hp, ItaAir, L, LFactor, Npr, PRatio, PRatiop, SFactor, TCL, theta, VCL);
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the TMElasticPanel MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This is a function program to define the transfer matrix for foam-panel layer
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] TMElasticPanel(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "TMElasticPanel", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 1-input MWArray interface to the TMElasticPanel MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This is a function program to define the transfer matrix for foam-panel layer
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] TMElasticPanel(int numArgsOut, MWArray BulkDensity)
    {
      return mcr.EvaluateFunction(numArgsOut, "TMElasticPanel", BulkDensity);
    }


    /// <summary>
    /// Provides the standard 2-input MWArray interface to the TMElasticPanel MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This is a function program to define the transfer matrix for foam-panel layer
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] TMElasticPanel(int numArgsOut, MWArray BulkDensity, MWArray c)
    {
      return mcr.EvaluateFunction(numArgsOut, "TMElasticPanel", BulkDensity, c);
    }


    /// <summary>
    /// Provides the standard 3-input MWArray interface to the TMElasticPanel MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This is a function program to define the transfer matrix for foam-panel layer
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] TMElasticPanel(int numArgsOut, MWArray BulkDensity, MWArray c, 
                              MWArray Densityo)
    {
      return mcr.EvaluateFunction(numArgsOut, "TMElasticPanel", BulkDensity, c, Densityo);
    }


    /// <summary>
    /// Provides the standard 4-input MWArray interface to the TMElasticPanel MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This is a function program to define the transfer matrix for foam-panel layer
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="Densityp">Input argument #4</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] TMElasticPanel(int numArgsOut, MWArray BulkDensity, MWArray c, 
                              MWArray Densityo, MWArray Densityp)
    {
      return mcr.EvaluateFunction(numArgsOut, "TMElasticPanel", BulkDensity, c, Densityo, Densityp);
    }


    /// <summary>
    /// Provides the standard 5-input MWArray interface to the TMElasticPanel MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This is a function program to define the transfer matrix for foam-panel layer
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="Densityp">Input argument #4</param>
    /// <param name="Em">Input argument #5</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] TMElasticPanel(int numArgsOut, MWArray BulkDensity, MWArray c, 
                              MWArray Densityo, MWArray Densityp, MWArray Em)
    {
      return mcr.EvaluateFunction(numArgsOut, "TMElasticPanel", BulkDensity, c, Densityo, Densityp, Em);
    }


    /// <summary>
    /// Provides the standard 6-input MWArray interface to the TMElasticPanel MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This is a function program to define the transfer matrix for foam-panel layer
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="Densityp">Input argument #4</param>
    /// <param name="Em">Input argument #5</param>
    /// <param name="Ep">Input argument #6</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] TMElasticPanel(int numArgsOut, MWArray BulkDensity, MWArray c, 
                              MWArray Densityo, MWArray Densityp, MWArray Em, MWArray Ep)
    {
      return mcr.EvaluateFunction(numArgsOut, "TMElasticPanel", BulkDensity, c, Densityo, Densityp, Em, Ep);
    }


    /// <summary>
    /// Provides the standard 7-input MWArray interface to the TMElasticPanel MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This is a function program to define the transfer matrix for foam-panel layer
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="Densityp">Input argument #4</param>
    /// <param name="Em">Input argument #5</param>
    /// <param name="Ep">Input argument #6</param>
    /// <param name="FlowRes">Input argument #7</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] TMElasticPanel(int numArgsOut, MWArray BulkDensity, MWArray c, 
                              MWArray Densityo, MWArray Densityp, MWArray Em, MWArray Ep, 
                              MWArray FlowRes)
    {
      return mcr.EvaluateFunction(numArgsOut, "TMElasticPanel", BulkDensity, c, Densityo, Densityp, Em, Ep, FlowRes);
    }


    /// <summary>
    /// Provides the standard 8-input MWArray interface to the TMElasticPanel MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This is a function program to define the transfer matrix for foam-panel layer
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="Densityp">Input argument #4</param>
    /// <param name="Em">Input argument #5</param>
    /// <param name="Ep">Input argument #6</param>
    /// <param name="FlowRes">Input argument #7</param>
    /// <param name="freq">Input argument #8</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] TMElasticPanel(int numArgsOut, MWArray BulkDensity, MWArray c, 
                              MWArray Densityo, MWArray Densityp, MWArray Em, MWArray Ep, 
                              MWArray FlowRes, MWArray freq)
    {
      return mcr.EvaluateFunction(numArgsOut, "TMElasticPanel", BulkDensity, c, Densityo, Densityp, Em, Ep, FlowRes, freq);
    }


    /// <summary>
    /// Provides the standard 9-input MWArray interface to the TMElasticPanel MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This is a function program to define the transfer matrix for foam-panel layer
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="Densityp">Input argument #4</param>
    /// <param name="Em">Input argument #5</param>
    /// <param name="Ep">Input argument #6</param>
    /// <param name="FlowRes">Input argument #7</param>
    /// <param name="freq">Input argument #8</param>
    /// <param name="h">Input argument #9</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] TMElasticPanel(int numArgsOut, MWArray BulkDensity, MWArray c, 
                              MWArray Densityo, MWArray Densityp, MWArray Em, MWArray Ep, 
                              MWArray FlowRes, MWArray freq, MWArray h)
    {
      return mcr.EvaluateFunction(numArgsOut, "TMElasticPanel", BulkDensity, c, Densityo, Densityp, Em, Ep, FlowRes, freq, h);
    }


    /// <summary>
    /// Provides the standard 10-input MWArray interface to the TMElasticPanel MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This is a function program to define the transfer matrix for foam-panel layer
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="Densityp">Input argument #4</param>
    /// <param name="Em">Input argument #5</param>
    /// <param name="Ep">Input argument #6</param>
    /// <param name="FlowRes">Input argument #7</param>
    /// <param name="freq">Input argument #8</param>
    /// <param name="h">Input argument #9</param>
    /// <param name="HeatRatio">Input argument #10</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] TMElasticPanel(int numArgsOut, MWArray BulkDensity, MWArray c, 
                              MWArray Densityo, MWArray Densityp, MWArray Em, MWArray Ep, 
                              MWArray FlowRes, MWArray freq, MWArray h, MWArray HeatRatio)
    {
      return mcr.EvaluateFunction(numArgsOut, "TMElasticPanel", BulkDensity, c, Densityo, Densityp, Em, Ep, FlowRes, freq, h, HeatRatio);
    }


    /// <summary>
    /// Provides the standard 11-input MWArray interface to the TMElasticPanel MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This is a function program to define the transfer matrix for foam-panel layer
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="Densityp">Input argument #4</param>
    /// <param name="Em">Input argument #5</param>
    /// <param name="Ep">Input argument #6</param>
    /// <param name="FlowRes">Input argument #7</param>
    /// <param name="freq">Input argument #8</param>
    /// <param name="h">Input argument #9</param>
    /// <param name="HeatRatio">Input argument #10</param>
    /// <param name="hp">Input argument #11</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] TMElasticPanel(int numArgsOut, MWArray BulkDensity, MWArray c, 
                              MWArray Densityo, MWArray Densityp, MWArray Em, MWArray Ep, 
                              MWArray FlowRes, MWArray freq, MWArray h, MWArray 
                              HeatRatio, MWArray hp)
    {
      return mcr.EvaluateFunction(numArgsOut, "TMElasticPanel", BulkDensity, c, Densityo, Densityp, Em, Ep, FlowRes, freq, h, HeatRatio, hp);
    }


    /// <summary>
    /// Provides the standard 12-input MWArray interface to the TMElasticPanel MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This is a function program to define the transfer matrix for foam-panel layer
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="Densityp">Input argument #4</param>
    /// <param name="Em">Input argument #5</param>
    /// <param name="Ep">Input argument #6</param>
    /// <param name="FlowRes">Input argument #7</param>
    /// <param name="freq">Input argument #8</param>
    /// <param name="h">Input argument #9</param>
    /// <param name="HeatRatio">Input argument #10</param>
    /// <param name="hp">Input argument #11</param>
    /// <param name="ItaAir">Input argument #12</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] TMElasticPanel(int numArgsOut, MWArray BulkDensity, MWArray c, 
                              MWArray Densityo, MWArray Densityp, MWArray Em, MWArray Ep, 
                              MWArray FlowRes, MWArray freq, MWArray h, MWArray 
                              HeatRatio, MWArray hp, MWArray ItaAir)
    {
      return mcr.EvaluateFunction(numArgsOut, "TMElasticPanel", BulkDensity, c, Densityo, Densityp, Em, Ep, FlowRes, freq, h, HeatRatio, hp, ItaAir);
    }


    /// <summary>
    /// Provides the standard 13-input MWArray interface to the TMElasticPanel MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This is a function program to define the transfer matrix for foam-panel layer
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="Densityp">Input argument #4</param>
    /// <param name="Em">Input argument #5</param>
    /// <param name="Ep">Input argument #6</param>
    /// <param name="FlowRes">Input argument #7</param>
    /// <param name="freq">Input argument #8</param>
    /// <param name="h">Input argument #9</param>
    /// <param name="HeatRatio">Input argument #10</param>
    /// <param name="hp">Input argument #11</param>
    /// <param name="ItaAir">Input argument #12</param>
    /// <param name="L">Input argument #13</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] TMElasticPanel(int numArgsOut, MWArray BulkDensity, MWArray c, 
                              MWArray Densityo, MWArray Densityp, MWArray Em, MWArray Ep, 
                              MWArray FlowRes, MWArray freq, MWArray h, MWArray 
                              HeatRatio, MWArray hp, MWArray ItaAir, MWArray L)
    {
      return mcr.EvaluateFunction(numArgsOut, "TMElasticPanel", BulkDensity, c, Densityo, Densityp, Em, Ep, FlowRes, freq, h, HeatRatio, hp, ItaAir, L);
    }


    /// <summary>
    /// Provides the standard 14-input MWArray interface to the TMElasticPanel MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This is a function program to define the transfer matrix for foam-panel layer
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="Densityp">Input argument #4</param>
    /// <param name="Em">Input argument #5</param>
    /// <param name="Ep">Input argument #6</param>
    /// <param name="FlowRes">Input argument #7</param>
    /// <param name="freq">Input argument #8</param>
    /// <param name="h">Input argument #9</param>
    /// <param name="HeatRatio">Input argument #10</param>
    /// <param name="hp">Input argument #11</param>
    /// <param name="ItaAir">Input argument #12</param>
    /// <param name="L">Input argument #13</param>
    /// <param name="LFactor">Input argument #14</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] TMElasticPanel(int numArgsOut, MWArray BulkDensity, MWArray c, 
                              MWArray Densityo, MWArray Densityp, MWArray Em, MWArray Ep, 
                              MWArray FlowRes, MWArray freq, MWArray h, MWArray 
                              HeatRatio, MWArray hp, MWArray ItaAir, MWArray L, MWArray 
                              LFactor)
    {
      return mcr.EvaluateFunction(numArgsOut, "TMElasticPanel", BulkDensity, c, Densityo, Densityp, Em, Ep, FlowRes, freq, h, HeatRatio, hp, ItaAir, L, LFactor);
    }


    /// <summary>
    /// Provides the standard 15-input MWArray interface to the TMElasticPanel MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This is a function program to define the transfer matrix for foam-panel layer
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="Densityp">Input argument #4</param>
    /// <param name="Em">Input argument #5</param>
    /// <param name="Ep">Input argument #6</param>
    /// <param name="FlowRes">Input argument #7</param>
    /// <param name="freq">Input argument #8</param>
    /// <param name="h">Input argument #9</param>
    /// <param name="HeatRatio">Input argument #10</param>
    /// <param name="hp">Input argument #11</param>
    /// <param name="ItaAir">Input argument #12</param>
    /// <param name="L">Input argument #13</param>
    /// <param name="LFactor">Input argument #14</param>
    /// <param name="Npr">Input argument #15</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] TMElasticPanel(int numArgsOut, MWArray BulkDensity, MWArray c, 
                              MWArray Densityo, MWArray Densityp, MWArray Em, MWArray Ep, 
                              MWArray FlowRes, MWArray freq, MWArray h, MWArray 
                              HeatRatio, MWArray hp, MWArray ItaAir, MWArray L, MWArray 
                              LFactor, MWArray Npr)
    {
      return mcr.EvaluateFunction(numArgsOut, "TMElasticPanel", BulkDensity, c, Densityo, Densityp, Em, Ep, FlowRes, freq, h, HeatRatio, hp, ItaAir, L, LFactor, Npr);
    }


    /// <summary>
    /// Provides the standard 16-input MWArray interface to the TMElasticPanel MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This is a function program to define the transfer matrix for foam-panel layer
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="Densityp">Input argument #4</param>
    /// <param name="Em">Input argument #5</param>
    /// <param name="Ep">Input argument #6</param>
    /// <param name="FlowRes">Input argument #7</param>
    /// <param name="freq">Input argument #8</param>
    /// <param name="h">Input argument #9</param>
    /// <param name="HeatRatio">Input argument #10</param>
    /// <param name="hp">Input argument #11</param>
    /// <param name="ItaAir">Input argument #12</param>
    /// <param name="L">Input argument #13</param>
    /// <param name="LFactor">Input argument #14</param>
    /// <param name="Npr">Input argument #15</param>
    /// <param name="PRatio">Input argument #16</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] TMElasticPanel(int numArgsOut, MWArray BulkDensity, MWArray c, 
                              MWArray Densityo, MWArray Densityp, MWArray Em, MWArray Ep, 
                              MWArray FlowRes, MWArray freq, MWArray h, MWArray 
                              HeatRatio, MWArray hp, MWArray ItaAir, MWArray L, MWArray 
                              LFactor, MWArray Npr, MWArray PRatio)
    {
      return mcr.EvaluateFunction(numArgsOut, "TMElasticPanel", BulkDensity, c, Densityo, Densityp, Em, Ep, FlowRes, freq, h, HeatRatio, hp, ItaAir, L, LFactor, Npr, PRatio);
    }


    /// <summary>
    /// Provides the standard 17-input MWArray interface to the TMElasticPanel MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This is a function program to define the transfer matrix for foam-panel layer
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="Densityp">Input argument #4</param>
    /// <param name="Em">Input argument #5</param>
    /// <param name="Ep">Input argument #6</param>
    /// <param name="FlowRes">Input argument #7</param>
    /// <param name="freq">Input argument #8</param>
    /// <param name="h">Input argument #9</param>
    /// <param name="HeatRatio">Input argument #10</param>
    /// <param name="hp">Input argument #11</param>
    /// <param name="ItaAir">Input argument #12</param>
    /// <param name="L">Input argument #13</param>
    /// <param name="LFactor">Input argument #14</param>
    /// <param name="Npr">Input argument #15</param>
    /// <param name="PRatio">Input argument #16</param>
    /// <param name="PRatiop">Input argument #17</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] TMElasticPanel(int numArgsOut, MWArray BulkDensity, MWArray c, 
                              MWArray Densityo, MWArray Densityp, MWArray Em, MWArray Ep, 
                              MWArray FlowRes, MWArray freq, MWArray h, MWArray 
                              HeatRatio, MWArray hp, MWArray ItaAir, MWArray L, MWArray 
                              LFactor, MWArray Npr, MWArray PRatio, MWArray PRatiop)
    {
      return mcr.EvaluateFunction(numArgsOut, "TMElasticPanel", BulkDensity, c, Densityo, Densityp, Em, Ep, FlowRes, freq, h, HeatRatio, hp, ItaAir, L, LFactor, Npr, PRatio, PRatiop);
    }


    /// <summary>
    /// Provides the standard 18-input MWArray interface to the TMElasticPanel MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This is a function program to define the transfer matrix for foam-panel layer
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="Densityp">Input argument #4</param>
    /// <param name="Em">Input argument #5</param>
    /// <param name="Ep">Input argument #6</param>
    /// <param name="FlowRes">Input argument #7</param>
    /// <param name="freq">Input argument #8</param>
    /// <param name="h">Input argument #9</param>
    /// <param name="HeatRatio">Input argument #10</param>
    /// <param name="hp">Input argument #11</param>
    /// <param name="ItaAir">Input argument #12</param>
    /// <param name="L">Input argument #13</param>
    /// <param name="LFactor">Input argument #14</param>
    /// <param name="Npr">Input argument #15</param>
    /// <param name="PRatio">Input argument #16</param>
    /// <param name="PRatiop">Input argument #17</param>
    /// <param name="SFactor">Input argument #18</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] TMElasticPanel(int numArgsOut, MWArray BulkDensity, MWArray c, 
                              MWArray Densityo, MWArray Densityp, MWArray Em, MWArray Ep, 
                              MWArray FlowRes, MWArray freq, MWArray h, MWArray 
                              HeatRatio, MWArray hp, MWArray ItaAir, MWArray L, MWArray 
                              LFactor, MWArray Npr, MWArray PRatio, MWArray PRatiop, 
                              MWArray SFactor)
    {
      return mcr.EvaluateFunction(numArgsOut, "TMElasticPanel", BulkDensity, c, Densityo, Densityp, Em, Ep, FlowRes, freq, h, HeatRatio, hp, ItaAir, L, LFactor, Npr, PRatio, PRatiop, SFactor);
    }


    /// <summary>
    /// Provides the standard 19-input MWArray interface to the TMElasticPanel MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This is a function program to define the transfer matrix for foam-panel layer
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="Densityp">Input argument #4</param>
    /// <param name="Em">Input argument #5</param>
    /// <param name="Ep">Input argument #6</param>
    /// <param name="FlowRes">Input argument #7</param>
    /// <param name="freq">Input argument #8</param>
    /// <param name="h">Input argument #9</param>
    /// <param name="HeatRatio">Input argument #10</param>
    /// <param name="hp">Input argument #11</param>
    /// <param name="ItaAir">Input argument #12</param>
    /// <param name="L">Input argument #13</param>
    /// <param name="LFactor">Input argument #14</param>
    /// <param name="Npr">Input argument #15</param>
    /// <param name="PRatio">Input argument #16</param>
    /// <param name="PRatiop">Input argument #17</param>
    /// <param name="SFactor">Input argument #18</param>
    /// <param name="TCL">Input argument #19</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] TMElasticPanel(int numArgsOut, MWArray BulkDensity, MWArray c, 
                              MWArray Densityo, MWArray Densityp, MWArray Em, MWArray Ep, 
                              MWArray FlowRes, MWArray freq, MWArray h, MWArray 
                              HeatRatio, MWArray hp, MWArray ItaAir, MWArray L, MWArray 
                              LFactor, MWArray Npr, MWArray PRatio, MWArray PRatiop, 
                              MWArray SFactor, MWArray TCL)
    {
      return mcr.EvaluateFunction(numArgsOut, "TMElasticPanel", BulkDensity, c, Densityo, Densityp, Em, Ep, FlowRes, freq, h, HeatRatio, hp, ItaAir, L, LFactor, Npr, PRatio, PRatiop, SFactor, TCL);
    }


    /// <summary>
    /// Provides the standard 20-input MWArray interface to the TMElasticPanel MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This is a function program to define the transfer matrix for foam-panel layer
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="Densityp">Input argument #4</param>
    /// <param name="Em">Input argument #5</param>
    /// <param name="Ep">Input argument #6</param>
    /// <param name="FlowRes">Input argument #7</param>
    /// <param name="freq">Input argument #8</param>
    /// <param name="h">Input argument #9</param>
    /// <param name="HeatRatio">Input argument #10</param>
    /// <param name="hp">Input argument #11</param>
    /// <param name="ItaAir">Input argument #12</param>
    /// <param name="L">Input argument #13</param>
    /// <param name="LFactor">Input argument #14</param>
    /// <param name="Npr">Input argument #15</param>
    /// <param name="PRatio">Input argument #16</param>
    /// <param name="PRatiop">Input argument #17</param>
    /// <param name="SFactor">Input argument #18</param>
    /// <param name="TCL">Input argument #19</param>
    /// <param name="theta">Input argument #20</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] TMElasticPanel(int numArgsOut, MWArray BulkDensity, MWArray c, 
                              MWArray Densityo, MWArray Densityp, MWArray Em, MWArray Ep, 
                              MWArray FlowRes, MWArray freq, MWArray h, MWArray 
                              HeatRatio, MWArray hp, MWArray ItaAir, MWArray L, MWArray 
                              LFactor, MWArray Npr, MWArray PRatio, MWArray PRatiop, 
                              MWArray SFactor, MWArray TCL, MWArray theta)
    {
      return mcr.EvaluateFunction(numArgsOut, "TMElasticPanel", BulkDensity, c, Densityo, Densityp, Em, Ep, FlowRes, freq, h, HeatRatio, hp, ItaAir, L, LFactor, Npr, PRatio, PRatiop, SFactor, TCL, theta);
    }


    /// <summary>
    /// Provides the standard 21-input MWArray interface to the TMElasticPanel MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This is a function program to define the transfer matrix for foam-panel layer
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="Densityp">Input argument #4</param>
    /// <param name="Em">Input argument #5</param>
    /// <param name="Ep">Input argument #6</param>
    /// <param name="FlowRes">Input argument #7</param>
    /// <param name="freq">Input argument #8</param>
    /// <param name="h">Input argument #9</param>
    /// <param name="HeatRatio">Input argument #10</param>
    /// <param name="hp">Input argument #11</param>
    /// <param name="ItaAir">Input argument #12</param>
    /// <param name="L">Input argument #13</param>
    /// <param name="LFactor">Input argument #14</param>
    /// <param name="Npr">Input argument #15</param>
    /// <param name="PRatio">Input argument #16</param>
    /// <param name="PRatiop">Input argument #17</param>
    /// <param name="SFactor">Input argument #18</param>
    /// <param name="TCL">Input argument #19</param>
    /// <param name="theta">Input argument #20</param>
    /// <param name="VCL">Input argument #21</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] TMElasticPanel(int numArgsOut, MWArray BulkDensity, MWArray c, 
                              MWArray Densityo, MWArray Densityp, MWArray Em, MWArray Ep, 
                              MWArray FlowRes, MWArray freq, MWArray h, MWArray 
                              HeatRatio, MWArray hp, MWArray ItaAir, MWArray L, MWArray 
                              LFactor, MWArray Npr, MWArray PRatio, MWArray PRatiop, 
                              MWArray SFactor, MWArray TCL, MWArray theta, MWArray VCL)
    {
      return mcr.EvaluateFunction(numArgsOut, "TMElasticPanel", BulkDensity, c, Densityo, Densityp, Em, Ep, FlowRes, freq, h, HeatRatio, hp, ItaAir, L, LFactor, Npr, PRatio, PRatiop, SFactor, TCL, theta, VCL);
    }


    /// <summary>
    /// Provides an interface for the TMElasticPanel function in which the input and
    /// output
    /// arguments are specified as an array of MWArrays.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// M-Documentation:
    /// This is a function program to define the transfer matrix for foam-panel layer
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of MWArray output arguments</param>
    /// <param name= "argsIn">Array of MWArray input arguments</param>
    ///
    public void TMElasticPanel(int numArgsOut, ref MWArray[] argsOut, MWArray[] argsIn)
    {
      mcr.EvaluateFunction("TMElasticPanel", numArgsOut, ref argsOut, argsIn);
    }


    /// <summary>
    /// Provides a single output, 0-input MWArrayinterface to the TMImperMemb MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray TMImperMemb()
    {
      return mcr.EvaluateFunction("TMImperMemb", new MWArray[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input MWArrayinterface to the TMImperMemb MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="c">Input argument #1</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray TMImperMemb(MWArray c)
    {
      return mcr.EvaluateFunction("TMImperMemb", c);
    }


    /// <summary>
    /// Provides a single output, 2-input MWArrayinterface to the TMImperMemb MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="c">Input argument #1</param>
    /// <param name="Density">Input argument #2</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray TMImperMemb(MWArray c, MWArray Density)
    {
      return mcr.EvaluateFunction("TMImperMemb", c, Density);
    }


    /// <summary>
    /// Provides a single output, 3-input MWArrayinterface to the TMImperMemb MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="c">Input argument #1</param>
    /// <param name="Density">Input argument #2</param>
    /// <param name="freq">Input argument #3</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray TMImperMemb(MWArray c, MWArray Density, MWArray freq)
    {
      return mcr.EvaluateFunction("TMImperMemb", c, Density, freq);
    }


    /// <summary>
    /// Provides a single output, 4-input MWArrayinterface to the TMImperMemb MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="c">Input argument #1</param>
    /// <param name="Density">Input argument #2</param>
    /// <param name="freq">Input argument #3</param>
    /// <param name="L">Input argument #4</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray TMImperMemb(MWArray c, MWArray Density, MWArray freq, MWArray L)
    {
      return mcr.EvaluateFunction("TMImperMemb", c, Density, freq, L);
    }


    /// <summary>
    /// Provides a single output, 5-input MWArrayinterface to the TMImperMemb MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="c">Input argument #1</param>
    /// <param name="Density">Input argument #2</param>
    /// <param name="freq">Input argument #3</param>
    /// <param name="L">Input argument #4</param>
    /// <param name="theta">Input argument #5</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray TMImperMemb(MWArray c, MWArray Density, MWArray freq, MWArray L, 
                         MWArray theta)
    {
      return mcr.EvaluateFunction("TMImperMemb", c, Density, freq, L, theta);
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the TMImperMemb MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] TMImperMemb(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "TMImperMemb", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 1-input MWArray interface to the TMImperMemb MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="c">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] TMImperMemb(int numArgsOut, MWArray c)
    {
      return mcr.EvaluateFunction(numArgsOut, "TMImperMemb", c);
    }


    /// <summary>
    /// Provides the standard 2-input MWArray interface to the TMImperMemb MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="c">Input argument #1</param>
    /// <param name="Density">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] TMImperMemb(int numArgsOut, MWArray c, MWArray Density)
    {
      return mcr.EvaluateFunction(numArgsOut, "TMImperMemb", c, Density);
    }


    /// <summary>
    /// Provides the standard 3-input MWArray interface to the TMImperMemb MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="c">Input argument #1</param>
    /// <param name="Density">Input argument #2</param>
    /// <param name="freq">Input argument #3</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] TMImperMemb(int numArgsOut, MWArray c, MWArray Density, MWArray freq)
    {
      return mcr.EvaluateFunction(numArgsOut, "TMImperMemb", c, Density, freq);
    }


    /// <summary>
    /// Provides the standard 4-input MWArray interface to the TMImperMemb MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="c">Input argument #1</param>
    /// <param name="Density">Input argument #2</param>
    /// <param name="freq">Input argument #3</param>
    /// <param name="L">Input argument #4</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] TMImperMemb(int numArgsOut, MWArray c, MWArray Density, MWArray 
                           freq, MWArray L)
    {
      return mcr.EvaluateFunction(numArgsOut, "TMImperMemb", c, Density, freq, L);
    }


    /// <summary>
    /// Provides the standard 5-input MWArray interface to the TMImperMemb MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="c">Input argument #1</param>
    /// <param name="Density">Input argument #2</param>
    /// <param name="freq">Input argument #3</param>
    /// <param name="L">Input argument #4</param>
    /// <param name="theta">Input argument #5</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] TMImperMemb(int numArgsOut, MWArray c, MWArray Density, MWArray 
                           freq, MWArray L, MWArray theta)
    {
      return mcr.EvaluateFunction(numArgsOut, "TMImperMemb", c, Density, freq, L, theta);
    }


    /// <summary>
    /// Provides an interface for the TMImperMemb function in which the input and output
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
    public void TMImperMemb(int numArgsOut, ref MWArray[] argsOut, MWArray[] argsIn)
    {
      mcr.EvaluateFunction("TMImperMemb", numArgsOut, ref argsOut, argsIn);
    }


    /// <summary>
    /// Provides a single output, 0-input MWArrayinterface to the TMInit MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// elseif Travl1==7, T1=TMRigid(L1, Density1,FlowRes1,SFactor1,h1,VCL1,TCL1);
    /// thick1=L1; 
    /// </remarks>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray TMInit()
    {
      return mcr.EvaluateFunction("TMInit", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the TMInit MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// elseif Travl1==7, T1=TMRigid(L1, Density1,FlowRes1,SFactor1,h1,VCL1,TCL1);
    /// thick1=L1; 
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] TMInit(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "TMInit", new MWArray[]{});
    }


    /// <summary>
    /// Provides an interface for the TMInit function in which the input and output
    /// arguments are specified as an array of MWArrays.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// M-Documentation:
    /// elseif Travl1==7, T1=TMRigid(L1, Density1,FlowRes1,SFactor1,h1,VCL1,TCL1);
    /// thick1=L1; 
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of MWArray output arguments</param>
    /// <param name= "argsIn">Array of MWArray input arguments</param>
    ///
    public void TMInit(int numArgsOut, ref MWArray[] argsOut, MWArray[] argsIn)
    {
      mcr.EvaluateFunction("TMInit", numArgsOut, ref argsOut, argsIn);
    }


    /// <summary>
    /// Provides a single output, 0-input MWArrayinterface to the TMLimp MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Constant and variable definition
    /// </remarks>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray TMLimp()
    {
      return mcr.EvaluateFunction("TMLimp", new MWArray[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input MWArrayinterface to the TMLimp MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Constant and variable definition
    /// </remarks>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray TMLimp(MWArray BulkDensity)
    {
      return mcr.EvaluateFunction("TMLimp", BulkDensity);
    }


    /// <summary>
    /// Provides a single output, 2-input MWArrayinterface to the TMLimp MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Constant and variable definition
    /// </remarks>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray TMLimp(MWArray BulkDensity, MWArray c)
    {
      return mcr.EvaluateFunction("TMLimp", BulkDensity, c);
    }


    /// <summary>
    /// Provides a single output, 3-input MWArrayinterface to the TMLimp MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Constant and variable definition
    /// </remarks>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray TMLimp(MWArray BulkDensity, MWArray c, MWArray Densityo)
    {
      return mcr.EvaluateFunction("TMLimp", BulkDensity, c, Densityo);
    }


    /// <summary>
    /// Provides a single output, 4-input MWArrayinterface to the TMLimp MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Constant and variable definition
    /// </remarks>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="FlowRes">Input argument #4</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray TMLimp(MWArray BulkDensity, MWArray c, MWArray Densityo, MWArray 
                    FlowRes)
    {
      return mcr.EvaluateFunction("TMLimp", BulkDensity, c, Densityo, FlowRes);
    }


    /// <summary>
    /// Provides a single output, 5-input MWArrayinterface to the TMLimp MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Constant and variable definition
    /// </remarks>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="FlowRes">Input argument #4</param>
    /// <param name="freq">Input argument #5</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray TMLimp(MWArray BulkDensity, MWArray c, MWArray Densityo, MWArray 
                    FlowRes, MWArray freq)
    {
      return mcr.EvaluateFunction("TMLimp", BulkDensity, c, Densityo, FlowRes, freq);
    }


    /// <summary>
    /// Provides a single output, 6-input MWArrayinterface to the TMLimp MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Constant and variable definition
    /// </remarks>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="FlowRes">Input argument #4</param>
    /// <param name="freq">Input argument #5</param>
    /// <param name="h">Input argument #6</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray TMLimp(MWArray BulkDensity, MWArray c, MWArray Densityo, MWArray 
                    FlowRes, MWArray freq, MWArray h)
    {
      return mcr.EvaluateFunction("TMLimp", BulkDensity, c, Densityo, FlowRes, freq, h);
    }


    /// <summary>
    /// Provides a single output, 7-input MWArrayinterface to the TMLimp MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Constant and variable definition
    /// </remarks>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="FlowRes">Input argument #4</param>
    /// <param name="freq">Input argument #5</param>
    /// <param name="h">Input argument #6</param>
    /// <param name="HeatRatio">Input argument #7</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray TMLimp(MWArray BulkDensity, MWArray c, MWArray Densityo, MWArray 
                    FlowRes, MWArray freq, MWArray h, MWArray HeatRatio)
    {
      return mcr.EvaluateFunction("TMLimp", BulkDensity, c, Densityo, FlowRes, freq, h, HeatRatio);
    }


    /// <summary>
    /// Provides a single output, 8-input MWArrayinterface to the TMLimp MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Constant and variable definition
    /// </remarks>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="FlowRes">Input argument #4</param>
    /// <param name="freq">Input argument #5</param>
    /// <param name="h">Input argument #6</param>
    /// <param name="HeatRatio">Input argument #7</param>
    /// <param name="ItaAir">Input argument #8</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray TMLimp(MWArray BulkDensity, MWArray c, MWArray Densityo, MWArray 
                    FlowRes, MWArray freq, MWArray h, MWArray HeatRatio, MWArray ItaAir)
    {
      return mcr.EvaluateFunction("TMLimp", BulkDensity, c, Densityo, FlowRes, freq, h, HeatRatio, ItaAir);
    }


    /// <summary>
    /// Provides a single output, 9-input MWArrayinterface to the TMLimp MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Constant and variable definition
    /// </remarks>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="FlowRes">Input argument #4</param>
    /// <param name="freq">Input argument #5</param>
    /// <param name="h">Input argument #6</param>
    /// <param name="HeatRatio">Input argument #7</param>
    /// <param name="ItaAir">Input argument #8</param>
    /// <param name="L">Input argument #9</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray TMLimp(MWArray BulkDensity, MWArray c, MWArray Densityo, MWArray 
                    FlowRes, MWArray freq, MWArray h, MWArray HeatRatio, MWArray ItaAir, 
                    MWArray L)
    {
      return mcr.EvaluateFunction("TMLimp", BulkDensity, c, Densityo, FlowRes, freq, h, HeatRatio, ItaAir, L);
    }


    /// <summary>
    /// Provides a single output, 10-input MWArrayinterface to the TMLimp MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Constant and variable definition
    /// </remarks>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="FlowRes">Input argument #4</param>
    /// <param name="freq">Input argument #5</param>
    /// <param name="h">Input argument #6</param>
    /// <param name="HeatRatio">Input argument #7</param>
    /// <param name="ItaAir">Input argument #8</param>
    /// <param name="L">Input argument #9</param>
    /// <param name="Npr">Input argument #10</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray TMLimp(MWArray BulkDensity, MWArray c, MWArray Densityo, MWArray 
                    FlowRes, MWArray freq, MWArray h, MWArray HeatRatio, MWArray ItaAir, 
                    MWArray L, MWArray Npr)
    {
      return mcr.EvaluateFunction("TMLimp", BulkDensity, c, Densityo, FlowRes, freq, h, HeatRatio, ItaAir, L, Npr);
    }


    /// <summary>
    /// Provides a single output, 11-input MWArrayinterface to the TMLimp MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Constant and variable definition
    /// </remarks>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="FlowRes">Input argument #4</param>
    /// <param name="freq">Input argument #5</param>
    /// <param name="h">Input argument #6</param>
    /// <param name="HeatRatio">Input argument #7</param>
    /// <param name="ItaAir">Input argument #8</param>
    /// <param name="L">Input argument #9</param>
    /// <param name="Npr">Input argument #10</param>
    /// <param name="P0">Input argument #11</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray TMLimp(MWArray BulkDensity, MWArray c, MWArray Densityo, MWArray 
                    FlowRes, MWArray freq, MWArray h, MWArray HeatRatio, MWArray ItaAir, 
                    MWArray L, MWArray Npr, MWArray P0)
    {
      return mcr.EvaluateFunction("TMLimp", BulkDensity, c, Densityo, FlowRes, freq, h, HeatRatio, ItaAir, L, Npr, P0);
    }


    /// <summary>
    /// Provides a single output, 12-input MWArrayinterface to the TMLimp MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Constant and variable definition
    /// </remarks>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="FlowRes">Input argument #4</param>
    /// <param name="freq">Input argument #5</param>
    /// <param name="h">Input argument #6</param>
    /// <param name="HeatRatio">Input argument #7</param>
    /// <param name="ItaAir">Input argument #8</param>
    /// <param name="L">Input argument #9</param>
    /// <param name="Npr">Input argument #10</param>
    /// <param name="P0">Input argument #11</param>
    /// <param name="SFactor">Input argument #12</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray TMLimp(MWArray BulkDensity, MWArray c, MWArray Densityo, MWArray 
                    FlowRes, MWArray freq, MWArray h, MWArray HeatRatio, MWArray ItaAir, 
                    MWArray L, MWArray Npr, MWArray P0, MWArray SFactor)
    {
      return mcr.EvaluateFunction("TMLimp", BulkDensity, c, Densityo, FlowRes, freq, h, HeatRatio, ItaAir, L, Npr, P0, SFactor);
    }


    /// <summary>
    /// Provides a single output, 13-input MWArrayinterface to the TMLimp MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Constant and variable definition
    /// </remarks>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="FlowRes">Input argument #4</param>
    /// <param name="freq">Input argument #5</param>
    /// <param name="h">Input argument #6</param>
    /// <param name="HeatRatio">Input argument #7</param>
    /// <param name="ItaAir">Input argument #8</param>
    /// <param name="L">Input argument #9</param>
    /// <param name="Npr">Input argument #10</param>
    /// <param name="P0">Input argument #11</param>
    /// <param name="SFactor">Input argument #12</param>
    /// <param name="TCL">Input argument #13</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray TMLimp(MWArray BulkDensity, MWArray c, MWArray Densityo, MWArray 
                    FlowRes, MWArray freq, MWArray h, MWArray HeatRatio, MWArray ItaAir, 
                    MWArray L, MWArray Npr, MWArray P0, MWArray SFactor, MWArray TCL)
    {
      return mcr.EvaluateFunction("TMLimp", BulkDensity, c, Densityo, FlowRes, freq, h, HeatRatio, ItaAir, L, Npr, P0, SFactor, TCL);
    }


    /// <summary>
    /// Provides a single output, 14-input MWArrayinterface to the TMLimp MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Constant and variable definition
    /// </remarks>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="FlowRes">Input argument #4</param>
    /// <param name="freq">Input argument #5</param>
    /// <param name="h">Input argument #6</param>
    /// <param name="HeatRatio">Input argument #7</param>
    /// <param name="ItaAir">Input argument #8</param>
    /// <param name="L">Input argument #9</param>
    /// <param name="Npr">Input argument #10</param>
    /// <param name="P0">Input argument #11</param>
    /// <param name="SFactor">Input argument #12</param>
    /// <param name="TCL">Input argument #13</param>
    /// <param name="theta">Input argument #14</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray TMLimp(MWArray BulkDensity, MWArray c, MWArray Densityo, MWArray 
                    FlowRes, MWArray freq, MWArray h, MWArray HeatRatio, MWArray ItaAir, 
                    MWArray L, MWArray Npr, MWArray P0, MWArray SFactor, MWArray TCL, 
                    MWArray theta)
    {
      return mcr.EvaluateFunction("TMLimp", BulkDensity, c, Densityo, FlowRes, freq, h, HeatRatio, ItaAir, L, Npr, P0, SFactor, TCL, theta);
    }


    /// <summary>
    /// Provides a single output, 15-input MWArrayinterface to the TMLimp MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Constant and variable definition
    /// </remarks>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="FlowRes">Input argument #4</param>
    /// <param name="freq">Input argument #5</param>
    /// <param name="h">Input argument #6</param>
    /// <param name="HeatRatio">Input argument #7</param>
    /// <param name="ItaAir">Input argument #8</param>
    /// <param name="L">Input argument #9</param>
    /// <param name="Npr">Input argument #10</param>
    /// <param name="P0">Input argument #11</param>
    /// <param name="SFactor">Input argument #12</param>
    /// <param name="TCL">Input argument #13</param>
    /// <param name="theta">Input argument #14</param>
    /// <param name="VCL">Input argument #15</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray TMLimp(MWArray BulkDensity, MWArray c, MWArray Densityo, MWArray 
                    FlowRes, MWArray freq, MWArray h, MWArray HeatRatio, MWArray ItaAir, 
                    MWArray L, MWArray Npr, MWArray P0, MWArray SFactor, MWArray TCL, 
                    MWArray theta, MWArray VCL)
    {
      return mcr.EvaluateFunction("TMLimp", BulkDensity, c, Densityo, FlowRes, freq, h, HeatRatio, ItaAir, L, Npr, P0, SFactor, TCL, theta, VCL);
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the TMLimp MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Constant and variable definition
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] TMLimp(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "TMLimp", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 1-input MWArray interface to the TMLimp MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Constant and variable definition
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] TMLimp(int numArgsOut, MWArray BulkDensity)
    {
      return mcr.EvaluateFunction(numArgsOut, "TMLimp", BulkDensity);
    }


    /// <summary>
    /// Provides the standard 2-input MWArray interface to the TMLimp MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Constant and variable definition
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] TMLimp(int numArgsOut, MWArray BulkDensity, MWArray c)
    {
      return mcr.EvaluateFunction(numArgsOut, "TMLimp", BulkDensity, c);
    }


    /// <summary>
    /// Provides the standard 3-input MWArray interface to the TMLimp MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Constant and variable definition
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] TMLimp(int numArgsOut, MWArray BulkDensity, MWArray c, MWArray 
                      Densityo)
    {
      return mcr.EvaluateFunction(numArgsOut, "TMLimp", BulkDensity, c, Densityo);
    }


    /// <summary>
    /// Provides the standard 4-input MWArray interface to the TMLimp MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Constant and variable definition
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="FlowRes">Input argument #4</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] TMLimp(int numArgsOut, MWArray BulkDensity, MWArray c, MWArray 
                      Densityo, MWArray FlowRes)
    {
      return mcr.EvaluateFunction(numArgsOut, "TMLimp", BulkDensity, c, Densityo, FlowRes);
    }


    /// <summary>
    /// Provides the standard 5-input MWArray interface to the TMLimp MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Constant and variable definition
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="FlowRes">Input argument #4</param>
    /// <param name="freq">Input argument #5</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] TMLimp(int numArgsOut, MWArray BulkDensity, MWArray c, MWArray 
                      Densityo, MWArray FlowRes, MWArray freq)
    {
      return mcr.EvaluateFunction(numArgsOut, "TMLimp", BulkDensity, c, Densityo, FlowRes, freq);
    }


    /// <summary>
    /// Provides the standard 6-input MWArray interface to the TMLimp MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Constant and variable definition
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="FlowRes">Input argument #4</param>
    /// <param name="freq">Input argument #5</param>
    /// <param name="h">Input argument #6</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] TMLimp(int numArgsOut, MWArray BulkDensity, MWArray c, MWArray 
                      Densityo, MWArray FlowRes, MWArray freq, MWArray h)
    {
      return mcr.EvaluateFunction(numArgsOut, "TMLimp", BulkDensity, c, Densityo, FlowRes, freq, h);
    }


    /// <summary>
    /// Provides the standard 7-input MWArray interface to the TMLimp MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Constant and variable definition
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="FlowRes">Input argument #4</param>
    /// <param name="freq">Input argument #5</param>
    /// <param name="h">Input argument #6</param>
    /// <param name="HeatRatio">Input argument #7</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] TMLimp(int numArgsOut, MWArray BulkDensity, MWArray c, MWArray 
                      Densityo, MWArray FlowRes, MWArray freq, MWArray h, MWArray 
                      HeatRatio)
    {
      return mcr.EvaluateFunction(numArgsOut, "TMLimp", BulkDensity, c, Densityo, FlowRes, freq, h, HeatRatio);
    }


    /// <summary>
    /// Provides the standard 8-input MWArray interface to the TMLimp MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Constant and variable definition
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="FlowRes">Input argument #4</param>
    /// <param name="freq">Input argument #5</param>
    /// <param name="h">Input argument #6</param>
    /// <param name="HeatRatio">Input argument #7</param>
    /// <param name="ItaAir">Input argument #8</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] TMLimp(int numArgsOut, MWArray BulkDensity, MWArray c, MWArray 
                      Densityo, MWArray FlowRes, MWArray freq, MWArray h, MWArray 
                      HeatRatio, MWArray ItaAir)
    {
      return mcr.EvaluateFunction(numArgsOut, "TMLimp", BulkDensity, c, Densityo, FlowRes, freq, h, HeatRatio, ItaAir);
    }


    /// <summary>
    /// Provides the standard 9-input MWArray interface to the TMLimp MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Constant and variable definition
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="FlowRes">Input argument #4</param>
    /// <param name="freq">Input argument #5</param>
    /// <param name="h">Input argument #6</param>
    /// <param name="HeatRatio">Input argument #7</param>
    /// <param name="ItaAir">Input argument #8</param>
    /// <param name="L">Input argument #9</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] TMLimp(int numArgsOut, MWArray BulkDensity, MWArray c, MWArray 
                      Densityo, MWArray FlowRes, MWArray freq, MWArray h, MWArray 
                      HeatRatio, MWArray ItaAir, MWArray L)
    {
      return mcr.EvaluateFunction(numArgsOut, "TMLimp", BulkDensity, c, Densityo, FlowRes, freq, h, HeatRatio, ItaAir, L);
    }


    /// <summary>
    /// Provides the standard 10-input MWArray interface to the TMLimp MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Constant and variable definition
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="FlowRes">Input argument #4</param>
    /// <param name="freq">Input argument #5</param>
    /// <param name="h">Input argument #6</param>
    /// <param name="HeatRatio">Input argument #7</param>
    /// <param name="ItaAir">Input argument #8</param>
    /// <param name="L">Input argument #9</param>
    /// <param name="Npr">Input argument #10</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] TMLimp(int numArgsOut, MWArray BulkDensity, MWArray c, MWArray 
                      Densityo, MWArray FlowRes, MWArray freq, MWArray h, MWArray 
                      HeatRatio, MWArray ItaAir, MWArray L, MWArray Npr)
    {
      return mcr.EvaluateFunction(numArgsOut, "TMLimp", BulkDensity, c, Densityo, FlowRes, freq, h, HeatRatio, ItaAir, L, Npr);
    }


    /// <summary>
    /// Provides the standard 11-input MWArray interface to the TMLimp MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Constant and variable definition
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="FlowRes">Input argument #4</param>
    /// <param name="freq">Input argument #5</param>
    /// <param name="h">Input argument #6</param>
    /// <param name="HeatRatio">Input argument #7</param>
    /// <param name="ItaAir">Input argument #8</param>
    /// <param name="L">Input argument #9</param>
    /// <param name="Npr">Input argument #10</param>
    /// <param name="P0">Input argument #11</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] TMLimp(int numArgsOut, MWArray BulkDensity, MWArray c, MWArray 
                      Densityo, MWArray FlowRes, MWArray freq, MWArray h, MWArray 
                      HeatRatio, MWArray ItaAir, MWArray L, MWArray Npr, MWArray P0)
    {
      return mcr.EvaluateFunction(numArgsOut, "TMLimp", BulkDensity, c, Densityo, FlowRes, freq, h, HeatRatio, ItaAir, L, Npr, P0);
    }


    /// <summary>
    /// Provides the standard 12-input MWArray interface to the TMLimp MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Constant and variable definition
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="FlowRes">Input argument #4</param>
    /// <param name="freq">Input argument #5</param>
    /// <param name="h">Input argument #6</param>
    /// <param name="HeatRatio">Input argument #7</param>
    /// <param name="ItaAir">Input argument #8</param>
    /// <param name="L">Input argument #9</param>
    /// <param name="Npr">Input argument #10</param>
    /// <param name="P0">Input argument #11</param>
    /// <param name="SFactor">Input argument #12</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] TMLimp(int numArgsOut, MWArray BulkDensity, MWArray c, MWArray 
                      Densityo, MWArray FlowRes, MWArray freq, MWArray h, MWArray 
                      HeatRatio, MWArray ItaAir, MWArray L, MWArray Npr, MWArray P0, 
                      MWArray SFactor)
    {
      return mcr.EvaluateFunction(numArgsOut, "TMLimp", BulkDensity, c, Densityo, FlowRes, freq, h, HeatRatio, ItaAir, L, Npr, P0, SFactor);
    }


    /// <summary>
    /// Provides the standard 13-input MWArray interface to the TMLimp MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Constant and variable definition
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="FlowRes">Input argument #4</param>
    /// <param name="freq">Input argument #5</param>
    /// <param name="h">Input argument #6</param>
    /// <param name="HeatRatio">Input argument #7</param>
    /// <param name="ItaAir">Input argument #8</param>
    /// <param name="L">Input argument #9</param>
    /// <param name="Npr">Input argument #10</param>
    /// <param name="P0">Input argument #11</param>
    /// <param name="SFactor">Input argument #12</param>
    /// <param name="TCL">Input argument #13</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] TMLimp(int numArgsOut, MWArray BulkDensity, MWArray c, MWArray 
                      Densityo, MWArray FlowRes, MWArray freq, MWArray h, MWArray 
                      HeatRatio, MWArray ItaAir, MWArray L, MWArray Npr, MWArray P0, 
                      MWArray SFactor, MWArray TCL)
    {
      return mcr.EvaluateFunction(numArgsOut, "TMLimp", BulkDensity, c, Densityo, FlowRes, freq, h, HeatRatio, ItaAir, L, Npr, P0, SFactor, TCL);
    }


    /// <summary>
    /// Provides the standard 14-input MWArray interface to the TMLimp MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Constant and variable definition
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="FlowRes">Input argument #4</param>
    /// <param name="freq">Input argument #5</param>
    /// <param name="h">Input argument #6</param>
    /// <param name="HeatRatio">Input argument #7</param>
    /// <param name="ItaAir">Input argument #8</param>
    /// <param name="L">Input argument #9</param>
    /// <param name="Npr">Input argument #10</param>
    /// <param name="P0">Input argument #11</param>
    /// <param name="SFactor">Input argument #12</param>
    /// <param name="TCL">Input argument #13</param>
    /// <param name="theta">Input argument #14</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] TMLimp(int numArgsOut, MWArray BulkDensity, MWArray c, MWArray 
                      Densityo, MWArray FlowRes, MWArray freq, MWArray h, MWArray 
                      HeatRatio, MWArray ItaAir, MWArray L, MWArray Npr, MWArray P0, 
                      MWArray SFactor, MWArray TCL, MWArray theta)
    {
      return mcr.EvaluateFunction(numArgsOut, "TMLimp", BulkDensity, c, Densityo, FlowRes, freq, h, HeatRatio, ItaAir, L, Npr, P0, SFactor, TCL, theta);
    }


    /// <summary>
    /// Provides the standard 15-input MWArray interface to the TMLimp MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Constant and variable definition
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="FlowRes">Input argument #4</param>
    /// <param name="freq">Input argument #5</param>
    /// <param name="h">Input argument #6</param>
    /// <param name="HeatRatio">Input argument #7</param>
    /// <param name="ItaAir">Input argument #8</param>
    /// <param name="L">Input argument #9</param>
    /// <param name="Npr">Input argument #10</param>
    /// <param name="P0">Input argument #11</param>
    /// <param name="SFactor">Input argument #12</param>
    /// <param name="TCL">Input argument #13</param>
    /// <param name="theta">Input argument #14</param>
    /// <param name="VCL">Input argument #15</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] TMLimp(int numArgsOut, MWArray BulkDensity, MWArray c, MWArray 
                      Densityo, MWArray FlowRes, MWArray freq, MWArray h, MWArray 
                      HeatRatio, MWArray ItaAir, MWArray L, MWArray Npr, MWArray P0, 
                      MWArray SFactor, MWArray TCL, MWArray theta, MWArray VCL)
    {
      return mcr.EvaluateFunction(numArgsOut, "TMLimp", BulkDensity, c, Densityo, FlowRes, freq, h, HeatRatio, ItaAir, L, Npr, P0, SFactor, TCL, theta, VCL);
    }


    /// <summary>
    /// Provides an interface for the TMLimp function in which the input and output
    /// arguments are specified as an array of MWArrays.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// M-Documentation:
    /// Constant and variable definition
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of MWArray output arguments</param>
    /// <param name= "argsIn">Array of MWArray input arguments</param>
    ///
    public void TMLimp(int numArgsOut, ref MWArray[] argsOut, MWArray[] argsIn)
    {
      mcr.EvaluateFunction("TMLimp", numArgsOut, ref argsOut, argsIn);
    }


    /// <summary>
    /// Provides a single output, 0-input MWArrayinterface to the TMMul MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray TMMul()
    {
      return mcr.EvaluateFunction("TMMul", new MWArray[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input MWArrayinterface to the TMMul MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="TM">Input argument #1</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray TMMul(MWArray TM)
    {
      return mcr.EvaluateFunction("TMMul", TM);
    }


    /// <summary>
    /// Provides a single output, 2-input MWArrayinterface to the TMMul MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="TM">Input argument #1</param>
    /// <param name="Result">Input argument #2</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray TMMul(MWArray TM, MWArray Result)
    {
      return mcr.EvaluateFunction("TMMul", TM, Result);
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the TMMul MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] TMMul(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "TMMul", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 1-input MWArray interface to the TMMul MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="TM">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] TMMul(int numArgsOut, MWArray TM)
    {
      return mcr.EvaluateFunction(numArgsOut, "TMMul", TM);
    }


    /// <summary>
    /// Provides the standard 2-input MWArray interface to the TMMul MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="TM">Input argument #1</param>
    /// <param name="Result">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] TMMul(int numArgsOut, MWArray TM, MWArray Result)
    {
      return mcr.EvaluateFunction(numArgsOut, "TMMul", TM, Result);
    }


    /// <summary>
    /// Provides an interface for the TMMul function in which the input and output
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
    public void TMMul(int numArgsOut, ref MWArray[] argsOut, MWArray[] argsIn)
    {
      mcr.EvaluateFunction("TMMul", numArgsOut, ref argsOut, argsIn);
    }


    /// <summary>
    /// Provides a single output, 0-input MWArrayinterface to the TMPanel MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray TMPanel()
    {
      return mcr.EvaluateFunction("TMPanel", new MWArray[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input MWArrayinterface to the TMPanel MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="c">Input argument #1</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray TMPanel(MWArray c)
    {
      return mcr.EvaluateFunction("TMPanel", c);
    }


    /// <summary>
    /// Provides a single output, 2-input MWArrayinterface to the TMPanel MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="c">Input argument #1</param>
    /// <param name="Density">Input argument #2</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray TMPanel(MWArray c, MWArray Density)
    {
      return mcr.EvaluateFunction("TMPanel", c, Density);
    }


    /// <summary>
    /// Provides a single output, 3-input MWArrayinterface to the TMPanel MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="c">Input argument #1</param>
    /// <param name="Density">Input argument #2</param>
    /// <param name="Em">Input argument #3</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray TMPanel(MWArray c, MWArray Density, MWArray Em)
    {
      return mcr.EvaluateFunction("TMPanel", c, Density, Em);
    }


    /// <summary>
    /// Provides a single output, 4-input MWArrayinterface to the TMPanel MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="c">Input argument #1</param>
    /// <param name="Density">Input argument #2</param>
    /// <param name="Em">Input argument #3</param>
    /// <param name="freq">Input argument #4</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray TMPanel(MWArray c, MWArray Density, MWArray Em, MWArray freq)
    {
      return mcr.EvaluateFunction("TMPanel", c, Density, Em, freq);
    }


    /// <summary>
    /// Provides a single output, 5-input MWArrayinterface to the TMPanel MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="c">Input argument #1</param>
    /// <param name="Density">Input argument #2</param>
    /// <param name="Em">Input argument #3</param>
    /// <param name="freq">Input argument #4</param>
    /// <param name="L">Input argument #5</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray TMPanel(MWArray c, MWArray Density, MWArray Em, MWArray freq, MWArray 
                     L)
    {
      return mcr.EvaluateFunction("TMPanel", c, Density, Em, freq, L);
    }


    /// <summary>
    /// Provides a single output, 6-input MWArrayinterface to the TMPanel MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="c">Input argument #1</param>
    /// <param name="Density">Input argument #2</param>
    /// <param name="Em">Input argument #3</param>
    /// <param name="freq">Input argument #4</param>
    /// <param name="L">Input argument #5</param>
    /// <param name="PRatio">Input argument #6</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray TMPanel(MWArray c, MWArray Density, MWArray Em, MWArray freq, MWArray 
                     L, MWArray PRatio)
    {
      return mcr.EvaluateFunction("TMPanel", c, Density, Em, freq, L, PRatio);
    }


    /// <summary>
    /// Provides a single output, 7-input MWArrayinterface to the TMPanel MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="c">Input argument #1</param>
    /// <param name="Density">Input argument #2</param>
    /// <param name="Em">Input argument #3</param>
    /// <param name="freq">Input argument #4</param>
    /// <param name="L">Input argument #5</param>
    /// <param name="PRatio">Input argument #6</param>
    /// <param name="theta">Input argument #7</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray TMPanel(MWArray c, MWArray Density, MWArray Em, MWArray freq, MWArray 
                     L, MWArray PRatio, MWArray theta)
    {
      return mcr.EvaluateFunction("TMPanel", c, Density, Em, freq, L, PRatio, theta);
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the TMPanel MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] TMPanel(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "TMPanel", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 1-input MWArray interface to the TMPanel MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="c">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] TMPanel(int numArgsOut, MWArray c)
    {
      return mcr.EvaluateFunction(numArgsOut, "TMPanel", c);
    }


    /// <summary>
    /// Provides the standard 2-input MWArray interface to the TMPanel MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="c">Input argument #1</param>
    /// <param name="Density">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] TMPanel(int numArgsOut, MWArray c, MWArray Density)
    {
      return mcr.EvaluateFunction(numArgsOut, "TMPanel", c, Density);
    }


    /// <summary>
    /// Provides the standard 3-input MWArray interface to the TMPanel MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="c">Input argument #1</param>
    /// <param name="Density">Input argument #2</param>
    /// <param name="Em">Input argument #3</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] TMPanel(int numArgsOut, MWArray c, MWArray Density, MWArray Em)
    {
      return mcr.EvaluateFunction(numArgsOut, "TMPanel", c, Density, Em);
    }


    /// <summary>
    /// Provides the standard 4-input MWArray interface to the TMPanel MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="c">Input argument #1</param>
    /// <param name="Density">Input argument #2</param>
    /// <param name="Em">Input argument #3</param>
    /// <param name="freq">Input argument #4</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] TMPanel(int numArgsOut, MWArray c, MWArray Density, MWArray Em, 
                       MWArray freq)
    {
      return mcr.EvaluateFunction(numArgsOut, "TMPanel", c, Density, Em, freq);
    }


    /// <summary>
    /// Provides the standard 5-input MWArray interface to the TMPanel MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="c">Input argument #1</param>
    /// <param name="Density">Input argument #2</param>
    /// <param name="Em">Input argument #3</param>
    /// <param name="freq">Input argument #4</param>
    /// <param name="L">Input argument #5</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] TMPanel(int numArgsOut, MWArray c, MWArray Density, MWArray Em, 
                       MWArray freq, MWArray L)
    {
      return mcr.EvaluateFunction(numArgsOut, "TMPanel", c, Density, Em, freq, L);
    }


    /// <summary>
    /// Provides the standard 6-input MWArray interface to the TMPanel MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="c">Input argument #1</param>
    /// <param name="Density">Input argument #2</param>
    /// <param name="Em">Input argument #3</param>
    /// <param name="freq">Input argument #4</param>
    /// <param name="L">Input argument #5</param>
    /// <param name="PRatio">Input argument #6</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] TMPanel(int numArgsOut, MWArray c, MWArray Density, MWArray Em, 
                       MWArray freq, MWArray L, MWArray PRatio)
    {
      return mcr.EvaluateFunction(numArgsOut, "TMPanel", c, Density, Em, freq, L, PRatio);
    }


    /// <summary>
    /// Provides the standard 7-input MWArray interface to the TMPanel MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="c">Input argument #1</param>
    /// <param name="Density">Input argument #2</param>
    /// <param name="Em">Input argument #3</param>
    /// <param name="freq">Input argument #4</param>
    /// <param name="L">Input argument #5</param>
    /// <param name="PRatio">Input argument #6</param>
    /// <param name="theta">Input argument #7</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] TMPanel(int numArgsOut, MWArray c, MWArray Density, MWArray Em, 
                       MWArray freq, MWArray L, MWArray PRatio, MWArray theta)
    {
      return mcr.EvaluateFunction(numArgsOut, "TMPanel", c, Density, Em, freq, L, PRatio, theta);
    }


    /// <summary>
    /// Provides an interface for the TMPanel function in which the input and output
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
    public void TMPanel(int numArgsOut, ref MWArray[] argsOut, MWArray[] argsIn)
    {
      mcr.EvaluateFunction("TMPanel", numArgsOut, ref argsOut, argsIn);
    }


    /// <summary>
    /// Provides a single output, 0-input MWArrayinterface to the TMPanelElastic MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This is a function program to define the transfer matrix for panel-foam layer
    /// </remarks>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray TMPanelElastic()
    {
      return mcr.EvaluateFunction("TMPanelElastic", new MWArray[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input MWArrayinterface to the TMPanelElastic MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This is a function program to define the transfer matrix for panel-foam layer
    /// </remarks>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray TMPanelElastic(MWArray BulkDensity)
    {
      return mcr.EvaluateFunction("TMPanelElastic", BulkDensity);
    }


    /// <summary>
    /// Provides a single output, 2-input MWArrayinterface to the TMPanelElastic MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This is a function program to define the transfer matrix for panel-foam layer
    /// </remarks>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray TMPanelElastic(MWArray BulkDensity, MWArray c)
    {
      return mcr.EvaluateFunction("TMPanelElastic", BulkDensity, c);
    }


    /// <summary>
    /// Provides a single output, 3-input MWArrayinterface to the TMPanelElastic MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This is a function program to define the transfer matrix for panel-foam layer
    /// </remarks>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray TMPanelElastic(MWArray BulkDensity, MWArray c, MWArray Densityo)
    {
      return mcr.EvaluateFunction("TMPanelElastic", BulkDensity, c, Densityo);
    }


    /// <summary>
    /// Provides a single output, 4-input MWArrayinterface to the TMPanelElastic MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This is a function program to define the transfer matrix for panel-foam layer
    /// </remarks>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="Densityp">Input argument #4</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray TMPanelElastic(MWArray BulkDensity, MWArray c, MWArray Densityo, 
                            MWArray Densityp)
    {
      return mcr.EvaluateFunction("TMPanelElastic", BulkDensity, c, Densityo, Densityp);
    }


    /// <summary>
    /// Provides a single output, 5-input MWArrayinterface to the TMPanelElastic MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This is a function program to define the transfer matrix for panel-foam layer
    /// </remarks>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="Densityp">Input argument #4</param>
    /// <param name="Em">Input argument #5</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray TMPanelElastic(MWArray BulkDensity, MWArray c, MWArray Densityo, 
                            MWArray Densityp, MWArray Em)
    {
      return mcr.EvaluateFunction("TMPanelElastic", BulkDensity, c, Densityo, Densityp, Em);
    }


    /// <summary>
    /// Provides a single output, 6-input MWArrayinterface to the TMPanelElastic MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This is a function program to define the transfer matrix for panel-foam layer
    /// </remarks>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="Densityp">Input argument #4</param>
    /// <param name="Em">Input argument #5</param>
    /// <param name="Ep">Input argument #6</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray TMPanelElastic(MWArray BulkDensity, MWArray c, MWArray Densityo, 
                            MWArray Densityp, MWArray Em, MWArray Ep)
    {
      return mcr.EvaluateFunction("TMPanelElastic", BulkDensity, c, Densityo, Densityp, Em, Ep);
    }


    /// <summary>
    /// Provides a single output, 7-input MWArrayinterface to the TMPanelElastic MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This is a function program to define the transfer matrix for panel-foam layer
    /// </remarks>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="Densityp">Input argument #4</param>
    /// <param name="Em">Input argument #5</param>
    /// <param name="Ep">Input argument #6</param>
    /// <param name="FlowRes">Input argument #7</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray TMPanelElastic(MWArray BulkDensity, MWArray c, MWArray Densityo, 
                            MWArray Densityp, MWArray Em, MWArray Ep, MWArray FlowRes)
    {
      return mcr.EvaluateFunction("TMPanelElastic", BulkDensity, c, Densityo, Densityp, Em, Ep, FlowRes);
    }


    /// <summary>
    /// Provides a single output, 8-input MWArrayinterface to the TMPanelElastic MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This is a function program to define the transfer matrix for panel-foam layer
    /// </remarks>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="Densityp">Input argument #4</param>
    /// <param name="Em">Input argument #5</param>
    /// <param name="Ep">Input argument #6</param>
    /// <param name="FlowRes">Input argument #7</param>
    /// <param name="freq">Input argument #8</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray TMPanelElastic(MWArray BulkDensity, MWArray c, MWArray Densityo, 
                            MWArray Densityp, MWArray Em, MWArray Ep, MWArray FlowRes, 
                            MWArray freq)
    {
      return mcr.EvaluateFunction("TMPanelElastic", BulkDensity, c, Densityo, Densityp, Em, Ep, FlowRes, freq);
    }


    /// <summary>
    /// Provides a single output, 9-input MWArrayinterface to the TMPanelElastic MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This is a function program to define the transfer matrix for panel-foam layer
    /// </remarks>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="Densityp">Input argument #4</param>
    /// <param name="Em">Input argument #5</param>
    /// <param name="Ep">Input argument #6</param>
    /// <param name="FlowRes">Input argument #7</param>
    /// <param name="freq">Input argument #8</param>
    /// <param name="h">Input argument #9</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray TMPanelElastic(MWArray BulkDensity, MWArray c, MWArray Densityo, 
                            MWArray Densityp, MWArray Em, MWArray Ep, MWArray FlowRes, 
                            MWArray freq, MWArray h)
    {
      return mcr.EvaluateFunction("TMPanelElastic", BulkDensity, c, Densityo, Densityp, Em, Ep, FlowRes, freq, h);
    }


    /// <summary>
    /// Provides a single output, 10-input MWArrayinterface to the TMPanelElastic MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This is a function program to define the transfer matrix for panel-foam layer
    /// </remarks>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="Densityp">Input argument #4</param>
    /// <param name="Em">Input argument #5</param>
    /// <param name="Ep">Input argument #6</param>
    /// <param name="FlowRes">Input argument #7</param>
    /// <param name="freq">Input argument #8</param>
    /// <param name="h">Input argument #9</param>
    /// <param name="HeatRatio">Input argument #10</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray TMPanelElastic(MWArray BulkDensity, MWArray c, MWArray Densityo, 
                            MWArray Densityp, MWArray Em, MWArray Ep, MWArray FlowRes, 
                            MWArray freq, MWArray h, MWArray HeatRatio)
    {
      return mcr.EvaluateFunction("TMPanelElastic", BulkDensity, c, Densityo, Densityp, Em, Ep, FlowRes, freq, h, HeatRatio);
    }


    /// <summary>
    /// Provides a single output, 11-input MWArrayinterface to the TMPanelElastic MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This is a function program to define the transfer matrix for panel-foam layer
    /// </remarks>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="Densityp">Input argument #4</param>
    /// <param name="Em">Input argument #5</param>
    /// <param name="Ep">Input argument #6</param>
    /// <param name="FlowRes">Input argument #7</param>
    /// <param name="freq">Input argument #8</param>
    /// <param name="h">Input argument #9</param>
    /// <param name="HeatRatio">Input argument #10</param>
    /// <param name="hp">Input argument #11</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray TMPanelElastic(MWArray BulkDensity, MWArray c, MWArray Densityo, 
                            MWArray Densityp, MWArray Em, MWArray Ep, MWArray FlowRes, 
                            MWArray freq, MWArray h, MWArray HeatRatio, MWArray hp)
    {
      return mcr.EvaluateFunction("TMPanelElastic", BulkDensity, c, Densityo, Densityp, Em, Ep, FlowRes, freq, h, HeatRatio, hp);
    }


    /// <summary>
    /// Provides a single output, 12-input MWArrayinterface to the TMPanelElastic MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This is a function program to define the transfer matrix for panel-foam layer
    /// </remarks>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="Densityp">Input argument #4</param>
    /// <param name="Em">Input argument #5</param>
    /// <param name="Ep">Input argument #6</param>
    /// <param name="FlowRes">Input argument #7</param>
    /// <param name="freq">Input argument #8</param>
    /// <param name="h">Input argument #9</param>
    /// <param name="HeatRatio">Input argument #10</param>
    /// <param name="hp">Input argument #11</param>
    /// <param name="ItaAir">Input argument #12</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray TMPanelElastic(MWArray BulkDensity, MWArray c, MWArray Densityo, 
                            MWArray Densityp, MWArray Em, MWArray Ep, MWArray FlowRes, 
                            MWArray freq, MWArray h, MWArray HeatRatio, MWArray hp, 
                            MWArray ItaAir)
    {
      return mcr.EvaluateFunction("TMPanelElastic", BulkDensity, c, Densityo, Densityp, Em, Ep, FlowRes, freq, h, HeatRatio, hp, ItaAir);
    }


    /// <summary>
    /// Provides a single output, 13-input MWArrayinterface to the TMPanelElastic MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This is a function program to define the transfer matrix for panel-foam layer
    /// </remarks>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="Densityp">Input argument #4</param>
    /// <param name="Em">Input argument #5</param>
    /// <param name="Ep">Input argument #6</param>
    /// <param name="FlowRes">Input argument #7</param>
    /// <param name="freq">Input argument #8</param>
    /// <param name="h">Input argument #9</param>
    /// <param name="HeatRatio">Input argument #10</param>
    /// <param name="hp">Input argument #11</param>
    /// <param name="ItaAir">Input argument #12</param>
    /// <param name="L">Input argument #13</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray TMPanelElastic(MWArray BulkDensity, MWArray c, MWArray Densityo, 
                            MWArray Densityp, MWArray Em, MWArray Ep, MWArray FlowRes, 
                            MWArray freq, MWArray h, MWArray HeatRatio, MWArray hp, 
                            MWArray ItaAir, MWArray L)
    {
      return mcr.EvaluateFunction("TMPanelElastic", BulkDensity, c, Densityo, Densityp, Em, Ep, FlowRes, freq, h, HeatRatio, hp, ItaAir, L);
    }


    /// <summary>
    /// Provides a single output, 14-input MWArrayinterface to the TMPanelElastic MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This is a function program to define the transfer matrix for panel-foam layer
    /// </remarks>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="Densityp">Input argument #4</param>
    /// <param name="Em">Input argument #5</param>
    /// <param name="Ep">Input argument #6</param>
    /// <param name="FlowRes">Input argument #7</param>
    /// <param name="freq">Input argument #8</param>
    /// <param name="h">Input argument #9</param>
    /// <param name="HeatRatio">Input argument #10</param>
    /// <param name="hp">Input argument #11</param>
    /// <param name="ItaAir">Input argument #12</param>
    /// <param name="L">Input argument #13</param>
    /// <param name="LFactor">Input argument #14</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray TMPanelElastic(MWArray BulkDensity, MWArray c, MWArray Densityo, 
                            MWArray Densityp, MWArray Em, MWArray Ep, MWArray FlowRes, 
                            MWArray freq, MWArray h, MWArray HeatRatio, MWArray hp, 
                            MWArray ItaAir, MWArray L, MWArray LFactor)
    {
      return mcr.EvaluateFunction("TMPanelElastic", BulkDensity, c, Densityo, Densityp, Em, Ep, FlowRes, freq, h, HeatRatio, hp, ItaAir, L, LFactor);
    }


    /// <summary>
    /// Provides a single output, 15-input MWArrayinterface to the TMPanelElastic MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This is a function program to define the transfer matrix for panel-foam layer
    /// </remarks>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="Densityp">Input argument #4</param>
    /// <param name="Em">Input argument #5</param>
    /// <param name="Ep">Input argument #6</param>
    /// <param name="FlowRes">Input argument #7</param>
    /// <param name="freq">Input argument #8</param>
    /// <param name="h">Input argument #9</param>
    /// <param name="HeatRatio">Input argument #10</param>
    /// <param name="hp">Input argument #11</param>
    /// <param name="ItaAir">Input argument #12</param>
    /// <param name="L">Input argument #13</param>
    /// <param name="LFactor">Input argument #14</param>
    /// <param name="Npr">Input argument #15</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray TMPanelElastic(MWArray BulkDensity, MWArray c, MWArray Densityo, 
                            MWArray Densityp, MWArray Em, MWArray Ep, MWArray FlowRes, 
                            MWArray freq, MWArray h, MWArray HeatRatio, MWArray hp, 
                            MWArray ItaAir, MWArray L, MWArray LFactor, MWArray Npr)
    {
      return mcr.EvaluateFunction("TMPanelElastic", BulkDensity, c, Densityo, Densityp, Em, Ep, FlowRes, freq, h, HeatRatio, hp, ItaAir, L, LFactor, Npr);
    }


    /// <summary>
    /// Provides a single output, 16-input MWArrayinterface to the TMPanelElastic MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This is a function program to define the transfer matrix for panel-foam layer
    /// </remarks>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="Densityp">Input argument #4</param>
    /// <param name="Em">Input argument #5</param>
    /// <param name="Ep">Input argument #6</param>
    /// <param name="FlowRes">Input argument #7</param>
    /// <param name="freq">Input argument #8</param>
    /// <param name="h">Input argument #9</param>
    /// <param name="HeatRatio">Input argument #10</param>
    /// <param name="hp">Input argument #11</param>
    /// <param name="ItaAir">Input argument #12</param>
    /// <param name="L">Input argument #13</param>
    /// <param name="LFactor">Input argument #14</param>
    /// <param name="Npr">Input argument #15</param>
    /// <param name="PRatio">Input argument #16</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray TMPanelElastic(MWArray BulkDensity, MWArray c, MWArray Densityo, 
                            MWArray Densityp, MWArray Em, MWArray Ep, MWArray FlowRes, 
                            MWArray freq, MWArray h, MWArray HeatRatio, MWArray hp, 
                            MWArray ItaAir, MWArray L, MWArray LFactor, MWArray Npr, 
                            MWArray PRatio)
    {
      return mcr.EvaluateFunction("TMPanelElastic", BulkDensity, c, Densityo, Densityp, Em, Ep, FlowRes, freq, h, HeatRatio, hp, ItaAir, L, LFactor, Npr, PRatio);
    }


    /// <summary>
    /// Provides a single output, 17-input MWArrayinterface to the TMPanelElastic MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This is a function program to define the transfer matrix for panel-foam layer
    /// </remarks>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="Densityp">Input argument #4</param>
    /// <param name="Em">Input argument #5</param>
    /// <param name="Ep">Input argument #6</param>
    /// <param name="FlowRes">Input argument #7</param>
    /// <param name="freq">Input argument #8</param>
    /// <param name="h">Input argument #9</param>
    /// <param name="HeatRatio">Input argument #10</param>
    /// <param name="hp">Input argument #11</param>
    /// <param name="ItaAir">Input argument #12</param>
    /// <param name="L">Input argument #13</param>
    /// <param name="LFactor">Input argument #14</param>
    /// <param name="Npr">Input argument #15</param>
    /// <param name="PRatio">Input argument #16</param>
    /// <param name="PRatiop">Input argument #17</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray TMPanelElastic(MWArray BulkDensity, MWArray c, MWArray Densityo, 
                            MWArray Densityp, MWArray Em, MWArray Ep, MWArray FlowRes, 
                            MWArray freq, MWArray h, MWArray HeatRatio, MWArray hp, 
                            MWArray ItaAir, MWArray L, MWArray LFactor, MWArray Npr, 
                            MWArray PRatio, MWArray PRatiop)
    {
      return mcr.EvaluateFunction("TMPanelElastic", BulkDensity, c, Densityo, Densityp, Em, Ep, FlowRes, freq, h, HeatRatio, hp, ItaAir, L, LFactor, Npr, PRatio, PRatiop);
    }


    /// <summary>
    /// Provides a single output, 18-input MWArrayinterface to the TMPanelElastic MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This is a function program to define the transfer matrix for panel-foam layer
    /// </remarks>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="Densityp">Input argument #4</param>
    /// <param name="Em">Input argument #5</param>
    /// <param name="Ep">Input argument #6</param>
    /// <param name="FlowRes">Input argument #7</param>
    /// <param name="freq">Input argument #8</param>
    /// <param name="h">Input argument #9</param>
    /// <param name="HeatRatio">Input argument #10</param>
    /// <param name="hp">Input argument #11</param>
    /// <param name="ItaAir">Input argument #12</param>
    /// <param name="L">Input argument #13</param>
    /// <param name="LFactor">Input argument #14</param>
    /// <param name="Npr">Input argument #15</param>
    /// <param name="PRatio">Input argument #16</param>
    /// <param name="PRatiop">Input argument #17</param>
    /// <param name="SFactor">Input argument #18</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray TMPanelElastic(MWArray BulkDensity, MWArray c, MWArray Densityo, 
                            MWArray Densityp, MWArray Em, MWArray Ep, MWArray FlowRes, 
                            MWArray freq, MWArray h, MWArray HeatRatio, MWArray hp, 
                            MWArray ItaAir, MWArray L, MWArray LFactor, MWArray Npr, 
                            MWArray PRatio, MWArray PRatiop, MWArray SFactor)
    {
      return mcr.EvaluateFunction("TMPanelElastic", BulkDensity, c, Densityo, Densityp, Em, Ep, FlowRes, freq, h, HeatRatio, hp, ItaAir, L, LFactor, Npr, PRatio, PRatiop, SFactor);
    }


    /// <summary>
    /// Provides a single output, 19-input MWArrayinterface to the TMPanelElastic MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This is a function program to define the transfer matrix for panel-foam layer
    /// </remarks>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="Densityp">Input argument #4</param>
    /// <param name="Em">Input argument #5</param>
    /// <param name="Ep">Input argument #6</param>
    /// <param name="FlowRes">Input argument #7</param>
    /// <param name="freq">Input argument #8</param>
    /// <param name="h">Input argument #9</param>
    /// <param name="HeatRatio">Input argument #10</param>
    /// <param name="hp">Input argument #11</param>
    /// <param name="ItaAir">Input argument #12</param>
    /// <param name="L">Input argument #13</param>
    /// <param name="LFactor">Input argument #14</param>
    /// <param name="Npr">Input argument #15</param>
    /// <param name="PRatio">Input argument #16</param>
    /// <param name="PRatiop">Input argument #17</param>
    /// <param name="SFactor">Input argument #18</param>
    /// <param name="TCL">Input argument #19</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray TMPanelElastic(MWArray BulkDensity, MWArray c, MWArray Densityo, 
                            MWArray Densityp, MWArray Em, MWArray Ep, MWArray FlowRes, 
                            MWArray freq, MWArray h, MWArray HeatRatio, MWArray hp, 
                            MWArray ItaAir, MWArray L, MWArray LFactor, MWArray Npr, 
                            MWArray PRatio, MWArray PRatiop, MWArray SFactor, MWArray TCL)
    {
      return mcr.EvaluateFunction("TMPanelElastic", BulkDensity, c, Densityo, Densityp, Em, Ep, FlowRes, freq, h, HeatRatio, hp, ItaAir, L, LFactor, Npr, PRatio, PRatiop, SFactor, TCL);
    }


    /// <summary>
    /// Provides a single output, 20-input MWArrayinterface to the TMPanelElastic MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This is a function program to define the transfer matrix for panel-foam layer
    /// </remarks>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="Densityp">Input argument #4</param>
    /// <param name="Em">Input argument #5</param>
    /// <param name="Ep">Input argument #6</param>
    /// <param name="FlowRes">Input argument #7</param>
    /// <param name="freq">Input argument #8</param>
    /// <param name="h">Input argument #9</param>
    /// <param name="HeatRatio">Input argument #10</param>
    /// <param name="hp">Input argument #11</param>
    /// <param name="ItaAir">Input argument #12</param>
    /// <param name="L">Input argument #13</param>
    /// <param name="LFactor">Input argument #14</param>
    /// <param name="Npr">Input argument #15</param>
    /// <param name="PRatio">Input argument #16</param>
    /// <param name="PRatiop">Input argument #17</param>
    /// <param name="SFactor">Input argument #18</param>
    /// <param name="TCL">Input argument #19</param>
    /// <param name="theta">Input argument #20</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray TMPanelElastic(MWArray BulkDensity, MWArray c, MWArray Densityo, 
                            MWArray Densityp, MWArray Em, MWArray Ep, MWArray FlowRes, 
                            MWArray freq, MWArray h, MWArray HeatRatio, MWArray hp, 
                            MWArray ItaAir, MWArray L, MWArray LFactor, MWArray Npr, 
                            MWArray PRatio, MWArray PRatiop, MWArray SFactor, MWArray 
                            TCL, MWArray theta)
    {
      return mcr.EvaluateFunction("TMPanelElastic", BulkDensity, c, Densityo, Densityp, Em, Ep, FlowRes, freq, h, HeatRatio, hp, ItaAir, L, LFactor, Npr, PRatio, PRatiop, SFactor, TCL, theta);
    }


    /// <summary>
    /// Provides a single output, 21-input MWArrayinterface to the TMPanelElastic MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This is a function program to define the transfer matrix for panel-foam layer
    /// </remarks>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="Densityp">Input argument #4</param>
    /// <param name="Em">Input argument #5</param>
    /// <param name="Ep">Input argument #6</param>
    /// <param name="FlowRes">Input argument #7</param>
    /// <param name="freq">Input argument #8</param>
    /// <param name="h">Input argument #9</param>
    /// <param name="HeatRatio">Input argument #10</param>
    /// <param name="hp">Input argument #11</param>
    /// <param name="ItaAir">Input argument #12</param>
    /// <param name="L">Input argument #13</param>
    /// <param name="LFactor">Input argument #14</param>
    /// <param name="Npr">Input argument #15</param>
    /// <param name="PRatio">Input argument #16</param>
    /// <param name="PRatiop">Input argument #17</param>
    /// <param name="SFactor">Input argument #18</param>
    /// <param name="TCL">Input argument #19</param>
    /// <param name="theta">Input argument #20</param>
    /// <param name="VCL">Input argument #21</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray TMPanelElastic(MWArray BulkDensity, MWArray c, MWArray Densityo, 
                            MWArray Densityp, MWArray Em, MWArray Ep, MWArray FlowRes, 
                            MWArray freq, MWArray h, MWArray HeatRatio, MWArray hp, 
                            MWArray ItaAir, MWArray L, MWArray LFactor, MWArray Npr, 
                            MWArray PRatio, MWArray PRatiop, MWArray SFactor, MWArray 
                            TCL, MWArray theta, MWArray VCL)
    {
      return mcr.EvaluateFunction("TMPanelElastic", BulkDensity, c, Densityo, Densityp, Em, Ep, FlowRes, freq, h, HeatRatio, hp, ItaAir, L, LFactor, Npr, PRatio, PRatiop, SFactor, TCL, theta, VCL);
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the TMPanelElastic MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This is a function program to define the transfer matrix for panel-foam layer
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] TMPanelElastic(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "TMPanelElastic", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 1-input MWArray interface to the TMPanelElastic MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This is a function program to define the transfer matrix for panel-foam layer
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] TMPanelElastic(int numArgsOut, MWArray BulkDensity)
    {
      return mcr.EvaluateFunction(numArgsOut, "TMPanelElastic", BulkDensity);
    }


    /// <summary>
    /// Provides the standard 2-input MWArray interface to the TMPanelElastic MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This is a function program to define the transfer matrix for panel-foam layer
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] TMPanelElastic(int numArgsOut, MWArray BulkDensity, MWArray c)
    {
      return mcr.EvaluateFunction(numArgsOut, "TMPanelElastic", BulkDensity, c);
    }


    /// <summary>
    /// Provides the standard 3-input MWArray interface to the TMPanelElastic MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This is a function program to define the transfer matrix for panel-foam layer
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] TMPanelElastic(int numArgsOut, MWArray BulkDensity, MWArray c, 
                              MWArray Densityo)
    {
      return mcr.EvaluateFunction(numArgsOut, "TMPanelElastic", BulkDensity, c, Densityo);
    }


    /// <summary>
    /// Provides the standard 4-input MWArray interface to the TMPanelElastic MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This is a function program to define the transfer matrix for panel-foam layer
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="Densityp">Input argument #4</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] TMPanelElastic(int numArgsOut, MWArray BulkDensity, MWArray c, 
                              MWArray Densityo, MWArray Densityp)
    {
      return mcr.EvaluateFunction(numArgsOut, "TMPanelElastic", BulkDensity, c, Densityo, Densityp);
    }


    /// <summary>
    /// Provides the standard 5-input MWArray interface to the TMPanelElastic MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This is a function program to define the transfer matrix for panel-foam layer
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="Densityp">Input argument #4</param>
    /// <param name="Em">Input argument #5</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] TMPanelElastic(int numArgsOut, MWArray BulkDensity, MWArray c, 
                              MWArray Densityo, MWArray Densityp, MWArray Em)
    {
      return mcr.EvaluateFunction(numArgsOut, "TMPanelElastic", BulkDensity, c, Densityo, Densityp, Em);
    }


    /// <summary>
    /// Provides the standard 6-input MWArray interface to the TMPanelElastic MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This is a function program to define the transfer matrix for panel-foam layer
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="Densityp">Input argument #4</param>
    /// <param name="Em">Input argument #5</param>
    /// <param name="Ep">Input argument #6</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] TMPanelElastic(int numArgsOut, MWArray BulkDensity, MWArray c, 
                              MWArray Densityo, MWArray Densityp, MWArray Em, MWArray Ep)
    {
      return mcr.EvaluateFunction(numArgsOut, "TMPanelElastic", BulkDensity, c, Densityo, Densityp, Em, Ep);
    }


    /// <summary>
    /// Provides the standard 7-input MWArray interface to the TMPanelElastic MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This is a function program to define the transfer matrix for panel-foam layer
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="Densityp">Input argument #4</param>
    /// <param name="Em">Input argument #5</param>
    /// <param name="Ep">Input argument #6</param>
    /// <param name="FlowRes">Input argument #7</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] TMPanelElastic(int numArgsOut, MWArray BulkDensity, MWArray c, 
                              MWArray Densityo, MWArray Densityp, MWArray Em, MWArray Ep, 
                              MWArray FlowRes)
    {
      return mcr.EvaluateFunction(numArgsOut, "TMPanelElastic", BulkDensity, c, Densityo, Densityp, Em, Ep, FlowRes);
    }


    /// <summary>
    /// Provides the standard 8-input MWArray interface to the TMPanelElastic MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This is a function program to define the transfer matrix for panel-foam layer
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="Densityp">Input argument #4</param>
    /// <param name="Em">Input argument #5</param>
    /// <param name="Ep">Input argument #6</param>
    /// <param name="FlowRes">Input argument #7</param>
    /// <param name="freq">Input argument #8</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] TMPanelElastic(int numArgsOut, MWArray BulkDensity, MWArray c, 
                              MWArray Densityo, MWArray Densityp, MWArray Em, MWArray Ep, 
                              MWArray FlowRes, MWArray freq)
    {
      return mcr.EvaluateFunction(numArgsOut, "TMPanelElastic", BulkDensity, c, Densityo, Densityp, Em, Ep, FlowRes, freq);
    }


    /// <summary>
    /// Provides the standard 9-input MWArray interface to the TMPanelElastic MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This is a function program to define the transfer matrix for panel-foam layer
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="Densityp">Input argument #4</param>
    /// <param name="Em">Input argument #5</param>
    /// <param name="Ep">Input argument #6</param>
    /// <param name="FlowRes">Input argument #7</param>
    /// <param name="freq">Input argument #8</param>
    /// <param name="h">Input argument #9</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] TMPanelElastic(int numArgsOut, MWArray BulkDensity, MWArray c, 
                              MWArray Densityo, MWArray Densityp, MWArray Em, MWArray Ep, 
                              MWArray FlowRes, MWArray freq, MWArray h)
    {
      return mcr.EvaluateFunction(numArgsOut, "TMPanelElastic", BulkDensity, c, Densityo, Densityp, Em, Ep, FlowRes, freq, h);
    }


    /// <summary>
    /// Provides the standard 10-input MWArray interface to the TMPanelElastic MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This is a function program to define the transfer matrix for panel-foam layer
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="Densityp">Input argument #4</param>
    /// <param name="Em">Input argument #5</param>
    /// <param name="Ep">Input argument #6</param>
    /// <param name="FlowRes">Input argument #7</param>
    /// <param name="freq">Input argument #8</param>
    /// <param name="h">Input argument #9</param>
    /// <param name="HeatRatio">Input argument #10</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] TMPanelElastic(int numArgsOut, MWArray BulkDensity, MWArray c, 
                              MWArray Densityo, MWArray Densityp, MWArray Em, MWArray Ep, 
                              MWArray FlowRes, MWArray freq, MWArray h, MWArray HeatRatio)
    {
      return mcr.EvaluateFunction(numArgsOut, "TMPanelElastic", BulkDensity, c, Densityo, Densityp, Em, Ep, FlowRes, freq, h, HeatRatio);
    }


    /// <summary>
    /// Provides the standard 11-input MWArray interface to the TMPanelElastic MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This is a function program to define the transfer matrix for panel-foam layer
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="Densityp">Input argument #4</param>
    /// <param name="Em">Input argument #5</param>
    /// <param name="Ep">Input argument #6</param>
    /// <param name="FlowRes">Input argument #7</param>
    /// <param name="freq">Input argument #8</param>
    /// <param name="h">Input argument #9</param>
    /// <param name="HeatRatio">Input argument #10</param>
    /// <param name="hp">Input argument #11</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] TMPanelElastic(int numArgsOut, MWArray BulkDensity, MWArray c, 
                              MWArray Densityo, MWArray Densityp, MWArray Em, MWArray Ep, 
                              MWArray FlowRes, MWArray freq, MWArray h, MWArray 
                              HeatRatio, MWArray hp)
    {
      return mcr.EvaluateFunction(numArgsOut, "TMPanelElastic", BulkDensity, c, Densityo, Densityp, Em, Ep, FlowRes, freq, h, HeatRatio, hp);
    }


    /// <summary>
    /// Provides the standard 12-input MWArray interface to the TMPanelElastic MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This is a function program to define the transfer matrix for panel-foam layer
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="Densityp">Input argument #4</param>
    /// <param name="Em">Input argument #5</param>
    /// <param name="Ep">Input argument #6</param>
    /// <param name="FlowRes">Input argument #7</param>
    /// <param name="freq">Input argument #8</param>
    /// <param name="h">Input argument #9</param>
    /// <param name="HeatRatio">Input argument #10</param>
    /// <param name="hp">Input argument #11</param>
    /// <param name="ItaAir">Input argument #12</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] TMPanelElastic(int numArgsOut, MWArray BulkDensity, MWArray c, 
                              MWArray Densityo, MWArray Densityp, MWArray Em, MWArray Ep, 
                              MWArray FlowRes, MWArray freq, MWArray h, MWArray 
                              HeatRatio, MWArray hp, MWArray ItaAir)
    {
      return mcr.EvaluateFunction(numArgsOut, "TMPanelElastic", BulkDensity, c, Densityo, Densityp, Em, Ep, FlowRes, freq, h, HeatRatio, hp, ItaAir);
    }


    /// <summary>
    /// Provides the standard 13-input MWArray interface to the TMPanelElastic MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This is a function program to define the transfer matrix for panel-foam layer
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="Densityp">Input argument #4</param>
    /// <param name="Em">Input argument #5</param>
    /// <param name="Ep">Input argument #6</param>
    /// <param name="FlowRes">Input argument #7</param>
    /// <param name="freq">Input argument #8</param>
    /// <param name="h">Input argument #9</param>
    /// <param name="HeatRatio">Input argument #10</param>
    /// <param name="hp">Input argument #11</param>
    /// <param name="ItaAir">Input argument #12</param>
    /// <param name="L">Input argument #13</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] TMPanelElastic(int numArgsOut, MWArray BulkDensity, MWArray c, 
                              MWArray Densityo, MWArray Densityp, MWArray Em, MWArray Ep, 
                              MWArray FlowRes, MWArray freq, MWArray h, MWArray 
                              HeatRatio, MWArray hp, MWArray ItaAir, MWArray L)
    {
      return mcr.EvaluateFunction(numArgsOut, "TMPanelElastic", BulkDensity, c, Densityo, Densityp, Em, Ep, FlowRes, freq, h, HeatRatio, hp, ItaAir, L);
    }


    /// <summary>
    /// Provides the standard 14-input MWArray interface to the TMPanelElastic MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This is a function program to define the transfer matrix for panel-foam layer
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="Densityp">Input argument #4</param>
    /// <param name="Em">Input argument #5</param>
    /// <param name="Ep">Input argument #6</param>
    /// <param name="FlowRes">Input argument #7</param>
    /// <param name="freq">Input argument #8</param>
    /// <param name="h">Input argument #9</param>
    /// <param name="HeatRatio">Input argument #10</param>
    /// <param name="hp">Input argument #11</param>
    /// <param name="ItaAir">Input argument #12</param>
    /// <param name="L">Input argument #13</param>
    /// <param name="LFactor">Input argument #14</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] TMPanelElastic(int numArgsOut, MWArray BulkDensity, MWArray c, 
                              MWArray Densityo, MWArray Densityp, MWArray Em, MWArray Ep, 
                              MWArray FlowRes, MWArray freq, MWArray h, MWArray 
                              HeatRatio, MWArray hp, MWArray ItaAir, MWArray L, MWArray 
                              LFactor)
    {
      return mcr.EvaluateFunction(numArgsOut, "TMPanelElastic", BulkDensity, c, Densityo, Densityp, Em, Ep, FlowRes, freq, h, HeatRatio, hp, ItaAir, L, LFactor);
    }


    /// <summary>
    /// Provides the standard 15-input MWArray interface to the TMPanelElastic MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This is a function program to define the transfer matrix for panel-foam layer
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="Densityp">Input argument #4</param>
    /// <param name="Em">Input argument #5</param>
    /// <param name="Ep">Input argument #6</param>
    /// <param name="FlowRes">Input argument #7</param>
    /// <param name="freq">Input argument #8</param>
    /// <param name="h">Input argument #9</param>
    /// <param name="HeatRatio">Input argument #10</param>
    /// <param name="hp">Input argument #11</param>
    /// <param name="ItaAir">Input argument #12</param>
    /// <param name="L">Input argument #13</param>
    /// <param name="LFactor">Input argument #14</param>
    /// <param name="Npr">Input argument #15</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] TMPanelElastic(int numArgsOut, MWArray BulkDensity, MWArray c, 
                              MWArray Densityo, MWArray Densityp, MWArray Em, MWArray Ep, 
                              MWArray FlowRes, MWArray freq, MWArray h, MWArray 
                              HeatRatio, MWArray hp, MWArray ItaAir, MWArray L, MWArray 
                              LFactor, MWArray Npr)
    {
      return mcr.EvaluateFunction(numArgsOut, "TMPanelElastic", BulkDensity, c, Densityo, Densityp, Em, Ep, FlowRes, freq, h, HeatRatio, hp, ItaAir, L, LFactor, Npr);
    }


    /// <summary>
    /// Provides the standard 16-input MWArray interface to the TMPanelElastic MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This is a function program to define the transfer matrix for panel-foam layer
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="Densityp">Input argument #4</param>
    /// <param name="Em">Input argument #5</param>
    /// <param name="Ep">Input argument #6</param>
    /// <param name="FlowRes">Input argument #7</param>
    /// <param name="freq">Input argument #8</param>
    /// <param name="h">Input argument #9</param>
    /// <param name="HeatRatio">Input argument #10</param>
    /// <param name="hp">Input argument #11</param>
    /// <param name="ItaAir">Input argument #12</param>
    /// <param name="L">Input argument #13</param>
    /// <param name="LFactor">Input argument #14</param>
    /// <param name="Npr">Input argument #15</param>
    /// <param name="PRatio">Input argument #16</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] TMPanelElastic(int numArgsOut, MWArray BulkDensity, MWArray c, 
                              MWArray Densityo, MWArray Densityp, MWArray Em, MWArray Ep, 
                              MWArray FlowRes, MWArray freq, MWArray h, MWArray 
                              HeatRatio, MWArray hp, MWArray ItaAir, MWArray L, MWArray 
                              LFactor, MWArray Npr, MWArray PRatio)
    {
      return mcr.EvaluateFunction(numArgsOut, "TMPanelElastic", BulkDensity, c, Densityo, Densityp, Em, Ep, FlowRes, freq, h, HeatRatio, hp, ItaAir, L, LFactor, Npr, PRatio);
    }


    /// <summary>
    /// Provides the standard 17-input MWArray interface to the TMPanelElastic MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This is a function program to define the transfer matrix for panel-foam layer
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="Densityp">Input argument #4</param>
    /// <param name="Em">Input argument #5</param>
    /// <param name="Ep">Input argument #6</param>
    /// <param name="FlowRes">Input argument #7</param>
    /// <param name="freq">Input argument #8</param>
    /// <param name="h">Input argument #9</param>
    /// <param name="HeatRatio">Input argument #10</param>
    /// <param name="hp">Input argument #11</param>
    /// <param name="ItaAir">Input argument #12</param>
    /// <param name="L">Input argument #13</param>
    /// <param name="LFactor">Input argument #14</param>
    /// <param name="Npr">Input argument #15</param>
    /// <param name="PRatio">Input argument #16</param>
    /// <param name="PRatiop">Input argument #17</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] TMPanelElastic(int numArgsOut, MWArray BulkDensity, MWArray c, 
                              MWArray Densityo, MWArray Densityp, MWArray Em, MWArray Ep, 
                              MWArray FlowRes, MWArray freq, MWArray h, MWArray 
                              HeatRatio, MWArray hp, MWArray ItaAir, MWArray L, MWArray 
                              LFactor, MWArray Npr, MWArray PRatio, MWArray PRatiop)
    {
      return mcr.EvaluateFunction(numArgsOut, "TMPanelElastic", BulkDensity, c, Densityo, Densityp, Em, Ep, FlowRes, freq, h, HeatRatio, hp, ItaAir, L, LFactor, Npr, PRatio, PRatiop);
    }


    /// <summary>
    /// Provides the standard 18-input MWArray interface to the TMPanelElastic MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This is a function program to define the transfer matrix for panel-foam layer
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="Densityp">Input argument #4</param>
    /// <param name="Em">Input argument #5</param>
    /// <param name="Ep">Input argument #6</param>
    /// <param name="FlowRes">Input argument #7</param>
    /// <param name="freq">Input argument #8</param>
    /// <param name="h">Input argument #9</param>
    /// <param name="HeatRatio">Input argument #10</param>
    /// <param name="hp">Input argument #11</param>
    /// <param name="ItaAir">Input argument #12</param>
    /// <param name="L">Input argument #13</param>
    /// <param name="LFactor">Input argument #14</param>
    /// <param name="Npr">Input argument #15</param>
    /// <param name="PRatio">Input argument #16</param>
    /// <param name="PRatiop">Input argument #17</param>
    /// <param name="SFactor">Input argument #18</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] TMPanelElastic(int numArgsOut, MWArray BulkDensity, MWArray c, 
                              MWArray Densityo, MWArray Densityp, MWArray Em, MWArray Ep, 
                              MWArray FlowRes, MWArray freq, MWArray h, MWArray 
                              HeatRatio, MWArray hp, MWArray ItaAir, MWArray L, MWArray 
                              LFactor, MWArray Npr, MWArray PRatio, MWArray PRatiop, 
                              MWArray SFactor)
    {
      return mcr.EvaluateFunction(numArgsOut, "TMPanelElastic", BulkDensity, c, Densityo, Densityp, Em, Ep, FlowRes, freq, h, HeatRatio, hp, ItaAir, L, LFactor, Npr, PRatio, PRatiop, SFactor);
    }


    /// <summary>
    /// Provides the standard 19-input MWArray interface to the TMPanelElastic MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This is a function program to define the transfer matrix for panel-foam layer
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="Densityp">Input argument #4</param>
    /// <param name="Em">Input argument #5</param>
    /// <param name="Ep">Input argument #6</param>
    /// <param name="FlowRes">Input argument #7</param>
    /// <param name="freq">Input argument #8</param>
    /// <param name="h">Input argument #9</param>
    /// <param name="HeatRatio">Input argument #10</param>
    /// <param name="hp">Input argument #11</param>
    /// <param name="ItaAir">Input argument #12</param>
    /// <param name="L">Input argument #13</param>
    /// <param name="LFactor">Input argument #14</param>
    /// <param name="Npr">Input argument #15</param>
    /// <param name="PRatio">Input argument #16</param>
    /// <param name="PRatiop">Input argument #17</param>
    /// <param name="SFactor">Input argument #18</param>
    /// <param name="TCL">Input argument #19</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] TMPanelElastic(int numArgsOut, MWArray BulkDensity, MWArray c, 
                              MWArray Densityo, MWArray Densityp, MWArray Em, MWArray Ep, 
                              MWArray FlowRes, MWArray freq, MWArray h, MWArray 
                              HeatRatio, MWArray hp, MWArray ItaAir, MWArray L, MWArray 
                              LFactor, MWArray Npr, MWArray PRatio, MWArray PRatiop, 
                              MWArray SFactor, MWArray TCL)
    {
      return mcr.EvaluateFunction(numArgsOut, "TMPanelElastic", BulkDensity, c, Densityo, Densityp, Em, Ep, FlowRes, freq, h, HeatRatio, hp, ItaAir, L, LFactor, Npr, PRatio, PRatiop, SFactor, TCL);
    }


    /// <summary>
    /// Provides the standard 20-input MWArray interface to the TMPanelElastic MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This is a function program to define the transfer matrix for panel-foam layer
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="Densityp">Input argument #4</param>
    /// <param name="Em">Input argument #5</param>
    /// <param name="Ep">Input argument #6</param>
    /// <param name="FlowRes">Input argument #7</param>
    /// <param name="freq">Input argument #8</param>
    /// <param name="h">Input argument #9</param>
    /// <param name="HeatRatio">Input argument #10</param>
    /// <param name="hp">Input argument #11</param>
    /// <param name="ItaAir">Input argument #12</param>
    /// <param name="L">Input argument #13</param>
    /// <param name="LFactor">Input argument #14</param>
    /// <param name="Npr">Input argument #15</param>
    /// <param name="PRatio">Input argument #16</param>
    /// <param name="PRatiop">Input argument #17</param>
    /// <param name="SFactor">Input argument #18</param>
    /// <param name="TCL">Input argument #19</param>
    /// <param name="theta">Input argument #20</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] TMPanelElastic(int numArgsOut, MWArray BulkDensity, MWArray c, 
                              MWArray Densityo, MWArray Densityp, MWArray Em, MWArray Ep, 
                              MWArray FlowRes, MWArray freq, MWArray h, MWArray 
                              HeatRatio, MWArray hp, MWArray ItaAir, MWArray L, MWArray 
                              LFactor, MWArray Npr, MWArray PRatio, MWArray PRatiop, 
                              MWArray SFactor, MWArray TCL, MWArray theta)
    {
      return mcr.EvaluateFunction(numArgsOut, "TMPanelElastic", BulkDensity, c, Densityo, Densityp, Em, Ep, FlowRes, freq, h, HeatRatio, hp, ItaAir, L, LFactor, Npr, PRatio, PRatiop, SFactor, TCL, theta);
    }


    /// <summary>
    /// Provides the standard 21-input MWArray interface to the TMPanelElastic MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This is a function program to define the transfer matrix for panel-foam layer
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="Densityp">Input argument #4</param>
    /// <param name="Em">Input argument #5</param>
    /// <param name="Ep">Input argument #6</param>
    /// <param name="FlowRes">Input argument #7</param>
    /// <param name="freq">Input argument #8</param>
    /// <param name="h">Input argument #9</param>
    /// <param name="HeatRatio">Input argument #10</param>
    /// <param name="hp">Input argument #11</param>
    /// <param name="ItaAir">Input argument #12</param>
    /// <param name="L">Input argument #13</param>
    /// <param name="LFactor">Input argument #14</param>
    /// <param name="Npr">Input argument #15</param>
    /// <param name="PRatio">Input argument #16</param>
    /// <param name="PRatiop">Input argument #17</param>
    /// <param name="SFactor">Input argument #18</param>
    /// <param name="TCL">Input argument #19</param>
    /// <param name="theta">Input argument #20</param>
    /// <param name="VCL">Input argument #21</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] TMPanelElastic(int numArgsOut, MWArray BulkDensity, MWArray c, 
                              MWArray Densityo, MWArray Densityp, MWArray Em, MWArray Ep, 
                              MWArray FlowRes, MWArray freq, MWArray h, MWArray 
                              HeatRatio, MWArray hp, MWArray ItaAir, MWArray L, MWArray 
                              LFactor, MWArray Npr, MWArray PRatio, MWArray PRatiop, 
                              MWArray SFactor, MWArray TCL, MWArray theta, MWArray VCL)
    {
      return mcr.EvaluateFunction(numArgsOut, "TMPanelElastic", BulkDensity, c, Densityo, Densityp, Em, Ep, FlowRes, freq, h, HeatRatio, hp, ItaAir, L, LFactor, Npr, PRatio, PRatiop, SFactor, TCL, theta, VCL);
    }


    /// <summary>
    /// Provides an interface for the TMPanelElastic function in which the input and
    /// output
    /// arguments are specified as an array of MWArrays.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// M-Documentation:
    /// This is a function program to define the transfer matrix for panel-foam layer
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of MWArray output arguments</param>
    /// <param name= "argsIn">Array of MWArray input arguments</param>
    ///
    public void TMPanelElastic(int numArgsOut, ref MWArray[] argsOut, MWArray[] argsIn)
    {
      mcr.EvaluateFunction("TMPanelElastic", numArgsOut, ref argsOut, argsIn);
    }


    /// <summary>
    /// Provides a single output, 0-input MWArrayinterface to the TMPanelElasticPanel
    /// MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This is a function program to define the transfer matrix for panel-foam-panel
    /// alyer
    /// </remarks>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray TMPanelElasticPanel()
    {
      return mcr.EvaluateFunction("TMPanelElasticPanel", new MWArray[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input MWArrayinterface to the TMPanelElasticPanel
    /// MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This is a function program to define the transfer matrix for panel-foam-panel
    /// alyer
    /// </remarks>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray TMPanelElasticPanel(MWArray BulkDensity)
    {
      return mcr.EvaluateFunction("TMPanelElasticPanel", BulkDensity);
    }


    /// <summary>
    /// Provides a single output, 2-input MWArrayinterface to the TMPanelElasticPanel
    /// MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This is a function program to define the transfer matrix for panel-foam-panel
    /// alyer
    /// </remarks>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray TMPanelElasticPanel(MWArray BulkDensity, MWArray c)
    {
      return mcr.EvaluateFunction("TMPanelElasticPanel", BulkDensity, c);
    }


    /// <summary>
    /// Provides a single output, 3-input MWArrayinterface to the TMPanelElasticPanel
    /// MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This is a function program to define the transfer matrix for panel-foam-panel
    /// alyer
    /// </remarks>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray TMPanelElasticPanel(MWArray BulkDensity, MWArray c, MWArray Densityo)
    {
      return mcr.EvaluateFunction("TMPanelElasticPanel", BulkDensity, c, Densityo);
    }


    /// <summary>
    /// Provides a single output, 4-input MWArrayinterface to the TMPanelElasticPanel
    /// MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This is a function program to define the transfer matrix for panel-foam-panel
    /// alyer
    /// </remarks>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="Densityp1">Input argument #4</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray TMPanelElasticPanel(MWArray BulkDensity, MWArray c, MWArray Densityo, 
                                 MWArray Densityp1)
    {
      return mcr.EvaluateFunction("TMPanelElasticPanel", BulkDensity, c, Densityo, Densityp1);
    }


    /// <summary>
    /// Provides a single output, 5-input MWArrayinterface to the TMPanelElasticPanel
    /// MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This is a function program to define the transfer matrix for panel-foam-panel
    /// alyer
    /// </remarks>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="Densityp1">Input argument #4</param>
    /// <param name="Densityp2">Input argument #5</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray TMPanelElasticPanel(MWArray BulkDensity, MWArray c, MWArray Densityo, 
                                 MWArray Densityp1, MWArray Densityp2)
    {
      return mcr.EvaluateFunction("TMPanelElasticPanel", BulkDensity, c, Densityo, Densityp1, Densityp2);
    }


    /// <summary>
    /// Provides a single output, 6-input MWArrayinterface to the TMPanelElasticPanel
    /// MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This is a function program to define the transfer matrix for panel-foam-panel
    /// alyer
    /// </remarks>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="Densityp1">Input argument #4</param>
    /// <param name="Densityp2">Input argument #5</param>
    /// <param name="Em">Input argument #6</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray TMPanelElasticPanel(MWArray BulkDensity, MWArray c, MWArray Densityo, 
                                 MWArray Densityp1, MWArray Densityp2, MWArray Em)
    {
      return mcr.EvaluateFunction("TMPanelElasticPanel", BulkDensity, c, Densityo, Densityp1, Densityp2, Em);
    }


    /// <summary>
    /// Provides a single output, 7-input MWArrayinterface to the TMPanelElasticPanel
    /// MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This is a function program to define the transfer matrix for panel-foam-panel
    /// alyer
    /// </remarks>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="Densityp1">Input argument #4</param>
    /// <param name="Densityp2">Input argument #5</param>
    /// <param name="Em">Input argument #6</param>
    /// <param name="Ep1">Input argument #7</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray TMPanelElasticPanel(MWArray BulkDensity, MWArray c, MWArray Densityo, 
                                 MWArray Densityp1, MWArray Densityp2, MWArray Em, 
                                 MWArray Ep1)
    {
      return mcr.EvaluateFunction("TMPanelElasticPanel", BulkDensity, c, Densityo, Densityp1, Densityp2, Em, Ep1);
    }


    /// <summary>
    /// Provides a single output, 8-input MWArrayinterface to the TMPanelElasticPanel
    /// MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This is a function program to define the transfer matrix for panel-foam-panel
    /// alyer
    /// </remarks>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="Densityp1">Input argument #4</param>
    /// <param name="Densityp2">Input argument #5</param>
    /// <param name="Em">Input argument #6</param>
    /// <param name="Ep1">Input argument #7</param>
    /// <param name="Ep2">Input argument #8</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray TMPanelElasticPanel(MWArray BulkDensity, MWArray c, MWArray Densityo, 
                                 MWArray Densityp1, MWArray Densityp2, MWArray Em, 
                                 MWArray Ep1, MWArray Ep2)
    {
      return mcr.EvaluateFunction("TMPanelElasticPanel", BulkDensity, c, Densityo, Densityp1, Densityp2, Em, Ep1, Ep2);
    }


    /// <summary>
    /// Provides a single output, 9-input MWArrayinterface to the TMPanelElasticPanel
    /// MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This is a function program to define the transfer matrix for panel-foam-panel
    /// alyer
    /// </remarks>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="Densityp1">Input argument #4</param>
    /// <param name="Densityp2">Input argument #5</param>
    /// <param name="Em">Input argument #6</param>
    /// <param name="Ep1">Input argument #7</param>
    /// <param name="Ep2">Input argument #8</param>
    /// <param name="FlowRes">Input argument #9</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray TMPanelElasticPanel(MWArray BulkDensity, MWArray c, MWArray Densityo, 
                                 MWArray Densityp1, MWArray Densityp2, MWArray Em, 
                                 MWArray Ep1, MWArray Ep2, MWArray FlowRes)
    {
      return mcr.EvaluateFunction("TMPanelElasticPanel", BulkDensity, c, Densityo, Densityp1, Densityp2, Em, Ep1, Ep2, FlowRes);
    }


    /// <summary>
    /// Provides a single output, 10-input MWArrayinterface to the TMPanelElasticPanel
    /// MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This is a function program to define the transfer matrix for panel-foam-panel
    /// alyer
    /// </remarks>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="Densityp1">Input argument #4</param>
    /// <param name="Densityp2">Input argument #5</param>
    /// <param name="Em">Input argument #6</param>
    /// <param name="Ep1">Input argument #7</param>
    /// <param name="Ep2">Input argument #8</param>
    /// <param name="FlowRes">Input argument #9</param>
    /// <param name="freq">Input argument #10</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray TMPanelElasticPanel(MWArray BulkDensity, MWArray c, MWArray Densityo, 
                                 MWArray Densityp1, MWArray Densityp2, MWArray Em, 
                                 MWArray Ep1, MWArray Ep2, MWArray FlowRes, MWArray freq)
    {
      return mcr.EvaluateFunction("TMPanelElasticPanel", BulkDensity, c, Densityo, Densityp1, Densityp2, Em, Ep1, Ep2, FlowRes, freq);
    }


    /// <summary>
    /// Provides a single output, 11-input MWArrayinterface to the TMPanelElasticPanel
    /// MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This is a function program to define the transfer matrix for panel-foam-panel
    /// alyer
    /// </remarks>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="Densityp1">Input argument #4</param>
    /// <param name="Densityp2">Input argument #5</param>
    /// <param name="Em">Input argument #6</param>
    /// <param name="Ep1">Input argument #7</param>
    /// <param name="Ep2">Input argument #8</param>
    /// <param name="FlowRes">Input argument #9</param>
    /// <param name="freq">Input argument #10</param>
    /// <param name="h">Input argument #11</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray TMPanelElasticPanel(MWArray BulkDensity, MWArray c, MWArray Densityo, 
                                 MWArray Densityp1, MWArray Densityp2, MWArray Em, 
                                 MWArray Ep1, MWArray Ep2, MWArray FlowRes, MWArray freq, 
                                 MWArray h)
    {
      return mcr.EvaluateFunction("TMPanelElasticPanel", BulkDensity, c, Densityo, Densityp1, Densityp2, Em, Ep1, Ep2, FlowRes, freq, h);
    }


    /// <summary>
    /// Provides a single output, 12-input MWArrayinterface to the TMPanelElasticPanel
    /// MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This is a function program to define the transfer matrix for panel-foam-panel
    /// alyer
    /// </remarks>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="Densityp1">Input argument #4</param>
    /// <param name="Densityp2">Input argument #5</param>
    /// <param name="Em">Input argument #6</param>
    /// <param name="Ep1">Input argument #7</param>
    /// <param name="Ep2">Input argument #8</param>
    /// <param name="FlowRes">Input argument #9</param>
    /// <param name="freq">Input argument #10</param>
    /// <param name="h">Input argument #11</param>
    /// <param name="HeatRatio">Input argument #12</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray TMPanelElasticPanel(MWArray BulkDensity, MWArray c, MWArray Densityo, 
                                 MWArray Densityp1, MWArray Densityp2, MWArray Em, 
                                 MWArray Ep1, MWArray Ep2, MWArray FlowRes, MWArray freq, 
                                 MWArray h, MWArray HeatRatio)
    {
      return mcr.EvaluateFunction("TMPanelElasticPanel", BulkDensity, c, Densityo, Densityp1, Densityp2, Em, Ep1, Ep2, FlowRes, freq, h, HeatRatio);
    }


    /// <summary>
    /// Provides a single output, 13-input MWArrayinterface to the TMPanelElasticPanel
    /// MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This is a function program to define the transfer matrix for panel-foam-panel
    /// alyer
    /// </remarks>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="Densityp1">Input argument #4</param>
    /// <param name="Densityp2">Input argument #5</param>
    /// <param name="Em">Input argument #6</param>
    /// <param name="Ep1">Input argument #7</param>
    /// <param name="Ep2">Input argument #8</param>
    /// <param name="FlowRes">Input argument #9</param>
    /// <param name="freq">Input argument #10</param>
    /// <param name="h">Input argument #11</param>
    /// <param name="HeatRatio">Input argument #12</param>
    /// <param name="hp1">Input argument #13</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray TMPanelElasticPanel(MWArray BulkDensity, MWArray c, MWArray Densityo, 
                                 MWArray Densityp1, MWArray Densityp2, MWArray Em, 
                                 MWArray Ep1, MWArray Ep2, MWArray FlowRes, MWArray freq, 
                                 MWArray h, MWArray HeatRatio, MWArray hp1)
    {
      return mcr.EvaluateFunction("TMPanelElasticPanel", BulkDensity, c, Densityo, Densityp1, Densityp2, Em, Ep1, Ep2, FlowRes, freq, h, HeatRatio, hp1);
    }


    /// <summary>
    /// Provides a single output, 14-input MWArrayinterface to the TMPanelElasticPanel
    /// MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This is a function program to define the transfer matrix for panel-foam-panel
    /// alyer
    /// </remarks>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="Densityp1">Input argument #4</param>
    /// <param name="Densityp2">Input argument #5</param>
    /// <param name="Em">Input argument #6</param>
    /// <param name="Ep1">Input argument #7</param>
    /// <param name="Ep2">Input argument #8</param>
    /// <param name="FlowRes">Input argument #9</param>
    /// <param name="freq">Input argument #10</param>
    /// <param name="h">Input argument #11</param>
    /// <param name="HeatRatio">Input argument #12</param>
    /// <param name="hp1">Input argument #13</param>
    /// <param name="hp2">Input argument #14</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray TMPanelElasticPanel(MWArray BulkDensity, MWArray c, MWArray Densityo, 
                                 MWArray Densityp1, MWArray Densityp2, MWArray Em, 
                                 MWArray Ep1, MWArray Ep2, MWArray FlowRes, MWArray freq, 
                                 MWArray h, MWArray HeatRatio, MWArray hp1, MWArray hp2)
    {
      return mcr.EvaluateFunction("TMPanelElasticPanel", BulkDensity, c, Densityo, Densityp1, Densityp2, Em, Ep1, Ep2, FlowRes, freq, h, HeatRatio, hp1, hp2);
    }


    /// <summary>
    /// Provides a single output, 15-input MWArrayinterface to the TMPanelElasticPanel
    /// MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This is a function program to define the transfer matrix for panel-foam-panel
    /// alyer
    /// </remarks>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="Densityp1">Input argument #4</param>
    /// <param name="Densityp2">Input argument #5</param>
    /// <param name="Em">Input argument #6</param>
    /// <param name="Ep1">Input argument #7</param>
    /// <param name="Ep2">Input argument #8</param>
    /// <param name="FlowRes">Input argument #9</param>
    /// <param name="freq">Input argument #10</param>
    /// <param name="h">Input argument #11</param>
    /// <param name="HeatRatio">Input argument #12</param>
    /// <param name="hp1">Input argument #13</param>
    /// <param name="hp2">Input argument #14</param>
    /// <param name="ItaAir">Input argument #15</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray TMPanelElasticPanel(MWArray BulkDensity, MWArray c, MWArray Densityo, 
                                 MWArray Densityp1, MWArray Densityp2, MWArray Em, 
                                 MWArray Ep1, MWArray Ep2, MWArray FlowRes, MWArray freq, 
                                 MWArray h, MWArray HeatRatio, MWArray hp1, MWArray hp2, 
                                 MWArray ItaAir)
    {
      return mcr.EvaluateFunction("TMPanelElasticPanel", BulkDensity, c, Densityo, Densityp1, Densityp2, Em, Ep1, Ep2, FlowRes, freq, h, HeatRatio, hp1, hp2, ItaAir);
    }


    /// <summary>
    /// Provides a single output, 16-input MWArrayinterface to the TMPanelElasticPanel
    /// MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This is a function program to define the transfer matrix for panel-foam-panel
    /// alyer
    /// </remarks>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="Densityp1">Input argument #4</param>
    /// <param name="Densityp2">Input argument #5</param>
    /// <param name="Em">Input argument #6</param>
    /// <param name="Ep1">Input argument #7</param>
    /// <param name="Ep2">Input argument #8</param>
    /// <param name="FlowRes">Input argument #9</param>
    /// <param name="freq">Input argument #10</param>
    /// <param name="h">Input argument #11</param>
    /// <param name="HeatRatio">Input argument #12</param>
    /// <param name="hp1">Input argument #13</param>
    /// <param name="hp2">Input argument #14</param>
    /// <param name="ItaAir">Input argument #15</param>
    /// <param name="L">Input argument #16</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray TMPanelElasticPanel(MWArray BulkDensity, MWArray c, MWArray Densityo, 
                                 MWArray Densityp1, MWArray Densityp2, MWArray Em, 
                                 MWArray Ep1, MWArray Ep2, MWArray FlowRes, MWArray freq, 
                                 MWArray h, MWArray HeatRatio, MWArray hp1, MWArray hp2, 
                                 MWArray ItaAir, MWArray L)
    {
      return mcr.EvaluateFunction("TMPanelElasticPanel", BulkDensity, c, Densityo, Densityp1, Densityp2, Em, Ep1, Ep2, FlowRes, freq, h, HeatRatio, hp1, hp2, ItaAir, L);
    }


    /// <summary>
    /// Provides a single output, 17-input MWArrayinterface to the TMPanelElasticPanel
    /// MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This is a function program to define the transfer matrix for panel-foam-panel
    /// alyer
    /// </remarks>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="Densityp1">Input argument #4</param>
    /// <param name="Densityp2">Input argument #5</param>
    /// <param name="Em">Input argument #6</param>
    /// <param name="Ep1">Input argument #7</param>
    /// <param name="Ep2">Input argument #8</param>
    /// <param name="FlowRes">Input argument #9</param>
    /// <param name="freq">Input argument #10</param>
    /// <param name="h">Input argument #11</param>
    /// <param name="HeatRatio">Input argument #12</param>
    /// <param name="hp1">Input argument #13</param>
    /// <param name="hp2">Input argument #14</param>
    /// <param name="ItaAir">Input argument #15</param>
    /// <param name="L">Input argument #16</param>
    /// <param name="LFactor">Input argument #17</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray TMPanelElasticPanel(MWArray BulkDensity, MWArray c, MWArray Densityo, 
                                 MWArray Densityp1, MWArray Densityp2, MWArray Em, 
                                 MWArray Ep1, MWArray Ep2, MWArray FlowRes, MWArray freq, 
                                 MWArray h, MWArray HeatRatio, MWArray hp1, MWArray hp2, 
                                 MWArray ItaAir, MWArray L, MWArray LFactor)
    {
      return mcr.EvaluateFunction("TMPanelElasticPanel", BulkDensity, c, Densityo, Densityp1, Densityp2, Em, Ep1, Ep2, FlowRes, freq, h, HeatRatio, hp1, hp2, ItaAir, L, LFactor);
    }


    /// <summary>
    /// Provides a single output, 18-input MWArrayinterface to the TMPanelElasticPanel
    /// MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This is a function program to define the transfer matrix for panel-foam-panel
    /// alyer
    /// </remarks>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="Densityp1">Input argument #4</param>
    /// <param name="Densityp2">Input argument #5</param>
    /// <param name="Em">Input argument #6</param>
    /// <param name="Ep1">Input argument #7</param>
    /// <param name="Ep2">Input argument #8</param>
    /// <param name="FlowRes">Input argument #9</param>
    /// <param name="freq">Input argument #10</param>
    /// <param name="h">Input argument #11</param>
    /// <param name="HeatRatio">Input argument #12</param>
    /// <param name="hp1">Input argument #13</param>
    /// <param name="hp2">Input argument #14</param>
    /// <param name="ItaAir">Input argument #15</param>
    /// <param name="L">Input argument #16</param>
    /// <param name="LFactor">Input argument #17</param>
    /// <param name="Npr">Input argument #18</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray TMPanelElasticPanel(MWArray BulkDensity, MWArray c, MWArray Densityo, 
                                 MWArray Densityp1, MWArray Densityp2, MWArray Em, 
                                 MWArray Ep1, MWArray Ep2, MWArray FlowRes, MWArray freq, 
                                 MWArray h, MWArray HeatRatio, MWArray hp1, MWArray hp2, 
                                 MWArray ItaAir, MWArray L, MWArray LFactor, MWArray Npr)
    {
      return mcr.EvaluateFunction("TMPanelElasticPanel", BulkDensity, c, Densityo, Densityp1, Densityp2, Em, Ep1, Ep2, FlowRes, freq, h, HeatRatio, hp1, hp2, ItaAir, L, LFactor, Npr);
    }


    /// <summary>
    /// Provides a single output, 19-input MWArrayinterface to the TMPanelElasticPanel
    /// MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This is a function program to define the transfer matrix for panel-foam-panel
    /// alyer
    /// </remarks>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="Densityp1">Input argument #4</param>
    /// <param name="Densityp2">Input argument #5</param>
    /// <param name="Em">Input argument #6</param>
    /// <param name="Ep1">Input argument #7</param>
    /// <param name="Ep2">Input argument #8</param>
    /// <param name="FlowRes">Input argument #9</param>
    /// <param name="freq">Input argument #10</param>
    /// <param name="h">Input argument #11</param>
    /// <param name="HeatRatio">Input argument #12</param>
    /// <param name="hp1">Input argument #13</param>
    /// <param name="hp2">Input argument #14</param>
    /// <param name="ItaAir">Input argument #15</param>
    /// <param name="L">Input argument #16</param>
    /// <param name="LFactor">Input argument #17</param>
    /// <param name="Npr">Input argument #18</param>
    /// <param name="PRatio">Input argument #19</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray TMPanelElasticPanel(MWArray BulkDensity, MWArray c, MWArray Densityo, 
                                 MWArray Densityp1, MWArray Densityp2, MWArray Em, 
                                 MWArray Ep1, MWArray Ep2, MWArray FlowRes, MWArray freq, 
                                 MWArray h, MWArray HeatRatio, MWArray hp1, MWArray hp2, 
                                 MWArray ItaAir, MWArray L, MWArray LFactor, MWArray Npr, 
                                 MWArray PRatio)
    {
      return mcr.EvaluateFunction("TMPanelElasticPanel", BulkDensity, c, Densityo, Densityp1, Densityp2, Em, Ep1, Ep2, FlowRes, freq, h, HeatRatio, hp1, hp2, ItaAir, L, LFactor, Npr, PRatio);
    }


    /// <summary>
    /// Provides a single output, 20-input MWArrayinterface to the TMPanelElasticPanel
    /// MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This is a function program to define the transfer matrix for panel-foam-panel
    /// alyer
    /// </remarks>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="Densityp1">Input argument #4</param>
    /// <param name="Densityp2">Input argument #5</param>
    /// <param name="Em">Input argument #6</param>
    /// <param name="Ep1">Input argument #7</param>
    /// <param name="Ep2">Input argument #8</param>
    /// <param name="FlowRes">Input argument #9</param>
    /// <param name="freq">Input argument #10</param>
    /// <param name="h">Input argument #11</param>
    /// <param name="HeatRatio">Input argument #12</param>
    /// <param name="hp1">Input argument #13</param>
    /// <param name="hp2">Input argument #14</param>
    /// <param name="ItaAir">Input argument #15</param>
    /// <param name="L">Input argument #16</param>
    /// <param name="LFactor">Input argument #17</param>
    /// <param name="Npr">Input argument #18</param>
    /// <param name="PRatio">Input argument #19</param>
    /// <param name="PRatiop1">Input argument #20</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray TMPanelElasticPanel(MWArray BulkDensity, MWArray c, MWArray Densityo, 
                                 MWArray Densityp1, MWArray Densityp2, MWArray Em, 
                                 MWArray Ep1, MWArray Ep2, MWArray FlowRes, MWArray freq, 
                                 MWArray h, MWArray HeatRatio, MWArray hp1, MWArray hp2, 
                                 MWArray ItaAir, MWArray L, MWArray LFactor, MWArray Npr, 
                                 MWArray PRatio, MWArray PRatiop1)
    {
      return mcr.EvaluateFunction("TMPanelElasticPanel", BulkDensity, c, Densityo, Densityp1, Densityp2, Em, Ep1, Ep2, FlowRes, freq, h, HeatRatio, hp1, hp2, ItaAir, L, LFactor, Npr, PRatio, PRatiop1);
    }


    /// <summary>
    /// Provides a single output, 21-input MWArrayinterface to the TMPanelElasticPanel
    /// MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This is a function program to define the transfer matrix for panel-foam-panel
    /// alyer
    /// </remarks>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="Densityp1">Input argument #4</param>
    /// <param name="Densityp2">Input argument #5</param>
    /// <param name="Em">Input argument #6</param>
    /// <param name="Ep1">Input argument #7</param>
    /// <param name="Ep2">Input argument #8</param>
    /// <param name="FlowRes">Input argument #9</param>
    /// <param name="freq">Input argument #10</param>
    /// <param name="h">Input argument #11</param>
    /// <param name="HeatRatio">Input argument #12</param>
    /// <param name="hp1">Input argument #13</param>
    /// <param name="hp2">Input argument #14</param>
    /// <param name="ItaAir">Input argument #15</param>
    /// <param name="L">Input argument #16</param>
    /// <param name="LFactor">Input argument #17</param>
    /// <param name="Npr">Input argument #18</param>
    /// <param name="PRatio">Input argument #19</param>
    /// <param name="PRatiop1">Input argument #20</param>
    /// <param name="PRatiop2">Input argument #21</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray TMPanelElasticPanel(MWArray BulkDensity, MWArray c, MWArray Densityo, 
                                 MWArray Densityp1, MWArray Densityp2, MWArray Em, 
                                 MWArray Ep1, MWArray Ep2, MWArray FlowRes, MWArray freq, 
                                 MWArray h, MWArray HeatRatio, MWArray hp1, MWArray hp2, 
                                 MWArray ItaAir, MWArray L, MWArray LFactor, MWArray Npr, 
                                 MWArray PRatio, MWArray PRatiop1, MWArray PRatiop2)
    {
      return mcr.EvaluateFunction("TMPanelElasticPanel", BulkDensity, c, Densityo, Densityp1, Densityp2, Em, Ep1, Ep2, FlowRes, freq, h, HeatRatio, hp1, hp2, ItaAir, L, LFactor, Npr, PRatio, PRatiop1, PRatiop2);
    }


    /// <summary>
    /// Provides a single output, 22-input MWArrayinterface to the TMPanelElasticPanel
    /// MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This is a function program to define the transfer matrix for panel-foam-panel
    /// alyer
    /// </remarks>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="Densityp1">Input argument #4</param>
    /// <param name="Densityp2">Input argument #5</param>
    /// <param name="Em">Input argument #6</param>
    /// <param name="Ep1">Input argument #7</param>
    /// <param name="Ep2">Input argument #8</param>
    /// <param name="FlowRes">Input argument #9</param>
    /// <param name="freq">Input argument #10</param>
    /// <param name="h">Input argument #11</param>
    /// <param name="HeatRatio">Input argument #12</param>
    /// <param name="hp1">Input argument #13</param>
    /// <param name="hp2">Input argument #14</param>
    /// <param name="ItaAir">Input argument #15</param>
    /// <param name="L">Input argument #16</param>
    /// <param name="LFactor">Input argument #17</param>
    /// <param name="Npr">Input argument #18</param>
    /// <param name="PRatio">Input argument #19</param>
    /// <param name="PRatiop1">Input argument #20</param>
    /// <param name="PRatiop2">Input argument #21</param>
    /// <param name="SFactor">Input argument #22</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray TMPanelElasticPanel(MWArray BulkDensity, MWArray c, MWArray Densityo, 
                                 MWArray Densityp1, MWArray Densityp2, MWArray Em, 
                                 MWArray Ep1, MWArray Ep2, MWArray FlowRes, MWArray freq, 
                                 MWArray h, MWArray HeatRatio, MWArray hp1, MWArray hp2, 
                                 MWArray ItaAir, MWArray L, MWArray LFactor, MWArray Npr, 
                                 MWArray PRatio, MWArray PRatiop1, MWArray PRatiop2, 
                                 MWArray SFactor)
    {
      return mcr.EvaluateFunction("TMPanelElasticPanel", BulkDensity, c, Densityo, Densityp1, Densityp2, Em, Ep1, Ep2, FlowRes, freq, h, HeatRatio, hp1, hp2, ItaAir, L, LFactor, Npr, PRatio, PRatiop1, PRatiop2, SFactor);
    }


    /// <summary>
    /// Provides a single output, 23-input MWArrayinterface to the TMPanelElasticPanel
    /// MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This is a function program to define the transfer matrix for panel-foam-panel
    /// alyer
    /// </remarks>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="Densityp1">Input argument #4</param>
    /// <param name="Densityp2">Input argument #5</param>
    /// <param name="Em">Input argument #6</param>
    /// <param name="Ep1">Input argument #7</param>
    /// <param name="Ep2">Input argument #8</param>
    /// <param name="FlowRes">Input argument #9</param>
    /// <param name="freq">Input argument #10</param>
    /// <param name="h">Input argument #11</param>
    /// <param name="HeatRatio">Input argument #12</param>
    /// <param name="hp1">Input argument #13</param>
    /// <param name="hp2">Input argument #14</param>
    /// <param name="ItaAir">Input argument #15</param>
    /// <param name="L">Input argument #16</param>
    /// <param name="LFactor">Input argument #17</param>
    /// <param name="Npr">Input argument #18</param>
    /// <param name="PRatio">Input argument #19</param>
    /// <param name="PRatiop1">Input argument #20</param>
    /// <param name="PRatiop2">Input argument #21</param>
    /// <param name="SFactor">Input argument #22</param>
    /// <param name="TCL">Input argument #23</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray TMPanelElasticPanel(MWArray BulkDensity, MWArray c, MWArray Densityo, 
                                 MWArray Densityp1, MWArray Densityp2, MWArray Em, 
                                 MWArray Ep1, MWArray Ep2, MWArray FlowRes, MWArray freq, 
                                 MWArray h, MWArray HeatRatio, MWArray hp1, MWArray hp2, 
                                 MWArray ItaAir, MWArray L, MWArray LFactor, MWArray Npr, 
                                 MWArray PRatio, MWArray PRatiop1, MWArray PRatiop2, 
                                 MWArray SFactor, MWArray TCL)
    {
      return mcr.EvaluateFunction("TMPanelElasticPanel", BulkDensity, c, Densityo, Densityp1, Densityp2, Em, Ep1, Ep2, FlowRes, freq, h, HeatRatio, hp1, hp2, ItaAir, L, LFactor, Npr, PRatio, PRatiop1, PRatiop2, SFactor, TCL);
    }


    /// <summary>
    /// Provides a single output, 24-input MWArrayinterface to the TMPanelElasticPanel
    /// MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This is a function program to define the transfer matrix for panel-foam-panel
    /// alyer
    /// </remarks>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="Densityp1">Input argument #4</param>
    /// <param name="Densityp2">Input argument #5</param>
    /// <param name="Em">Input argument #6</param>
    /// <param name="Ep1">Input argument #7</param>
    /// <param name="Ep2">Input argument #8</param>
    /// <param name="FlowRes">Input argument #9</param>
    /// <param name="freq">Input argument #10</param>
    /// <param name="h">Input argument #11</param>
    /// <param name="HeatRatio">Input argument #12</param>
    /// <param name="hp1">Input argument #13</param>
    /// <param name="hp2">Input argument #14</param>
    /// <param name="ItaAir">Input argument #15</param>
    /// <param name="L">Input argument #16</param>
    /// <param name="LFactor">Input argument #17</param>
    /// <param name="Npr">Input argument #18</param>
    /// <param name="PRatio">Input argument #19</param>
    /// <param name="PRatiop1">Input argument #20</param>
    /// <param name="PRatiop2">Input argument #21</param>
    /// <param name="SFactor">Input argument #22</param>
    /// <param name="TCL">Input argument #23</param>
    /// <param name="theta">Input argument #24</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray TMPanelElasticPanel(MWArray BulkDensity, MWArray c, MWArray Densityo, 
                                 MWArray Densityp1, MWArray Densityp2, MWArray Em, 
                                 MWArray Ep1, MWArray Ep2, MWArray FlowRes, MWArray freq, 
                                 MWArray h, MWArray HeatRatio, MWArray hp1, MWArray hp2, 
                                 MWArray ItaAir, MWArray L, MWArray LFactor, MWArray Npr, 
                                 MWArray PRatio, MWArray PRatiop1, MWArray PRatiop2, 
                                 MWArray SFactor, MWArray TCL, MWArray theta)
    {
      return mcr.EvaluateFunction("TMPanelElasticPanel", BulkDensity, c, Densityo, Densityp1, Densityp2, Em, Ep1, Ep2, FlowRes, freq, h, HeatRatio, hp1, hp2, ItaAir, L, LFactor, Npr, PRatio, PRatiop1, PRatiop2, SFactor, TCL, theta);
    }


    /// <summary>
    /// Provides a single output, 25-input MWArrayinterface to the TMPanelElasticPanel
    /// MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This is a function program to define the transfer matrix for panel-foam-panel
    /// alyer
    /// </remarks>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="Densityp1">Input argument #4</param>
    /// <param name="Densityp2">Input argument #5</param>
    /// <param name="Em">Input argument #6</param>
    /// <param name="Ep1">Input argument #7</param>
    /// <param name="Ep2">Input argument #8</param>
    /// <param name="FlowRes">Input argument #9</param>
    /// <param name="freq">Input argument #10</param>
    /// <param name="h">Input argument #11</param>
    /// <param name="HeatRatio">Input argument #12</param>
    /// <param name="hp1">Input argument #13</param>
    /// <param name="hp2">Input argument #14</param>
    /// <param name="ItaAir">Input argument #15</param>
    /// <param name="L">Input argument #16</param>
    /// <param name="LFactor">Input argument #17</param>
    /// <param name="Npr">Input argument #18</param>
    /// <param name="PRatio">Input argument #19</param>
    /// <param name="PRatiop1">Input argument #20</param>
    /// <param name="PRatiop2">Input argument #21</param>
    /// <param name="SFactor">Input argument #22</param>
    /// <param name="TCL">Input argument #23</param>
    /// <param name="theta">Input argument #24</param>
    /// <param name="VCL">Input argument #25</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray TMPanelElasticPanel(MWArray BulkDensity, MWArray c, MWArray Densityo, 
                                 MWArray Densityp1, MWArray Densityp2, MWArray Em, 
                                 MWArray Ep1, MWArray Ep2, MWArray FlowRes, MWArray freq, 
                                 MWArray h, MWArray HeatRatio, MWArray hp1, MWArray hp2, 
                                 MWArray ItaAir, MWArray L, MWArray LFactor, MWArray Npr, 
                                 MWArray PRatio, MWArray PRatiop1, MWArray PRatiop2, 
                                 MWArray SFactor, MWArray TCL, MWArray theta, MWArray VCL)
    {
      return mcr.EvaluateFunction("TMPanelElasticPanel", BulkDensity, c, Densityo, Densityp1, Densityp2, Em, Ep1, Ep2, FlowRes, freq, h, HeatRatio, hp1, hp2, ItaAir, L, LFactor, Npr, PRatio, PRatiop1, PRatiop2, SFactor, TCL, theta, VCL);
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the TMPanelElasticPanel MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This is a function program to define the transfer matrix for panel-foam-panel
    /// alyer
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] TMPanelElasticPanel(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "TMPanelElasticPanel", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 1-input MWArray interface to the TMPanelElasticPanel MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This is a function program to define the transfer matrix for panel-foam-panel
    /// alyer
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] TMPanelElasticPanel(int numArgsOut, MWArray BulkDensity)
    {
      return mcr.EvaluateFunction(numArgsOut, "TMPanelElasticPanel", BulkDensity);
    }


    /// <summary>
    /// Provides the standard 2-input MWArray interface to the TMPanelElasticPanel MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This is a function program to define the transfer matrix for panel-foam-panel
    /// alyer
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] TMPanelElasticPanel(int numArgsOut, MWArray BulkDensity, MWArray c)
    {
      return mcr.EvaluateFunction(numArgsOut, "TMPanelElasticPanel", BulkDensity, c);
    }


    /// <summary>
    /// Provides the standard 3-input MWArray interface to the TMPanelElasticPanel MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This is a function program to define the transfer matrix for panel-foam-panel
    /// alyer
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] TMPanelElasticPanel(int numArgsOut, MWArray BulkDensity, MWArray c, 
                                   MWArray Densityo)
    {
      return mcr.EvaluateFunction(numArgsOut, "TMPanelElasticPanel", BulkDensity, c, Densityo);
    }


    /// <summary>
    /// Provides the standard 4-input MWArray interface to the TMPanelElasticPanel MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This is a function program to define the transfer matrix for panel-foam-panel
    /// alyer
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="Densityp1">Input argument #4</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] TMPanelElasticPanel(int numArgsOut, MWArray BulkDensity, MWArray c, 
                                   MWArray Densityo, MWArray Densityp1)
    {
      return mcr.EvaluateFunction(numArgsOut, "TMPanelElasticPanel", BulkDensity, c, Densityo, Densityp1);
    }


    /// <summary>
    /// Provides the standard 5-input MWArray interface to the TMPanelElasticPanel MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This is a function program to define the transfer matrix for panel-foam-panel
    /// alyer
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="Densityp1">Input argument #4</param>
    /// <param name="Densityp2">Input argument #5</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] TMPanelElasticPanel(int numArgsOut, MWArray BulkDensity, MWArray c, 
                                   MWArray Densityo, MWArray Densityp1, MWArray Densityp2)
    {
      return mcr.EvaluateFunction(numArgsOut, "TMPanelElasticPanel", BulkDensity, c, Densityo, Densityp1, Densityp2);
    }


    /// <summary>
    /// Provides the standard 6-input MWArray interface to the TMPanelElasticPanel MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This is a function program to define the transfer matrix for panel-foam-panel
    /// alyer
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="Densityp1">Input argument #4</param>
    /// <param name="Densityp2">Input argument #5</param>
    /// <param name="Em">Input argument #6</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] TMPanelElasticPanel(int numArgsOut, MWArray BulkDensity, MWArray c, 
                                   MWArray Densityo, MWArray Densityp1, MWArray 
                                   Densityp2, MWArray Em)
    {
      return mcr.EvaluateFunction(numArgsOut, "TMPanelElasticPanel", BulkDensity, c, Densityo, Densityp1, Densityp2, Em);
    }


    /// <summary>
    /// Provides the standard 7-input MWArray interface to the TMPanelElasticPanel MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This is a function program to define the transfer matrix for panel-foam-panel
    /// alyer
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="Densityp1">Input argument #4</param>
    /// <param name="Densityp2">Input argument #5</param>
    /// <param name="Em">Input argument #6</param>
    /// <param name="Ep1">Input argument #7</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] TMPanelElasticPanel(int numArgsOut, MWArray BulkDensity, MWArray c, 
                                   MWArray Densityo, MWArray Densityp1, MWArray 
                                   Densityp2, MWArray Em, MWArray Ep1)
    {
      return mcr.EvaluateFunction(numArgsOut, "TMPanelElasticPanel", BulkDensity, c, Densityo, Densityp1, Densityp2, Em, Ep1);
    }


    /// <summary>
    /// Provides the standard 8-input MWArray interface to the TMPanelElasticPanel MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This is a function program to define the transfer matrix for panel-foam-panel
    /// alyer
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="Densityp1">Input argument #4</param>
    /// <param name="Densityp2">Input argument #5</param>
    /// <param name="Em">Input argument #6</param>
    /// <param name="Ep1">Input argument #7</param>
    /// <param name="Ep2">Input argument #8</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] TMPanelElasticPanel(int numArgsOut, MWArray BulkDensity, MWArray c, 
                                   MWArray Densityo, MWArray Densityp1, MWArray 
                                   Densityp2, MWArray Em, MWArray Ep1, MWArray Ep2)
    {
      return mcr.EvaluateFunction(numArgsOut, "TMPanelElasticPanel", BulkDensity, c, Densityo, Densityp1, Densityp2, Em, Ep1, Ep2);
    }


    /// <summary>
    /// Provides the standard 9-input MWArray interface to the TMPanelElasticPanel MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This is a function program to define the transfer matrix for panel-foam-panel
    /// alyer
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="Densityp1">Input argument #4</param>
    /// <param name="Densityp2">Input argument #5</param>
    /// <param name="Em">Input argument #6</param>
    /// <param name="Ep1">Input argument #7</param>
    /// <param name="Ep2">Input argument #8</param>
    /// <param name="FlowRes">Input argument #9</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] TMPanelElasticPanel(int numArgsOut, MWArray BulkDensity, MWArray c, 
                                   MWArray Densityo, MWArray Densityp1, MWArray 
                                   Densityp2, MWArray Em, MWArray Ep1, MWArray Ep2, 
                                   MWArray FlowRes)
    {
      return mcr.EvaluateFunction(numArgsOut, "TMPanelElasticPanel", BulkDensity, c, Densityo, Densityp1, Densityp2, Em, Ep1, Ep2, FlowRes);
    }


    /// <summary>
    /// Provides the standard 10-input MWArray interface to the TMPanelElasticPanel
    /// MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This is a function program to define the transfer matrix for panel-foam-panel
    /// alyer
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="Densityp1">Input argument #4</param>
    /// <param name="Densityp2">Input argument #5</param>
    /// <param name="Em">Input argument #6</param>
    /// <param name="Ep1">Input argument #7</param>
    /// <param name="Ep2">Input argument #8</param>
    /// <param name="FlowRes">Input argument #9</param>
    /// <param name="freq">Input argument #10</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] TMPanelElasticPanel(int numArgsOut, MWArray BulkDensity, MWArray c, 
                                   MWArray Densityo, MWArray Densityp1, MWArray 
                                   Densityp2, MWArray Em, MWArray Ep1, MWArray Ep2, 
                                   MWArray FlowRes, MWArray freq)
    {
      return mcr.EvaluateFunction(numArgsOut, "TMPanelElasticPanel", BulkDensity, c, Densityo, Densityp1, Densityp2, Em, Ep1, Ep2, FlowRes, freq);
    }


    /// <summary>
    /// Provides the standard 11-input MWArray interface to the TMPanelElasticPanel
    /// MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This is a function program to define the transfer matrix for panel-foam-panel
    /// alyer
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="Densityp1">Input argument #4</param>
    /// <param name="Densityp2">Input argument #5</param>
    /// <param name="Em">Input argument #6</param>
    /// <param name="Ep1">Input argument #7</param>
    /// <param name="Ep2">Input argument #8</param>
    /// <param name="FlowRes">Input argument #9</param>
    /// <param name="freq">Input argument #10</param>
    /// <param name="h">Input argument #11</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] TMPanelElasticPanel(int numArgsOut, MWArray BulkDensity, MWArray c, 
                                   MWArray Densityo, MWArray Densityp1, MWArray 
                                   Densityp2, MWArray Em, MWArray Ep1, MWArray Ep2, 
                                   MWArray FlowRes, MWArray freq, MWArray h)
    {
      return mcr.EvaluateFunction(numArgsOut, "TMPanelElasticPanel", BulkDensity, c, Densityo, Densityp1, Densityp2, Em, Ep1, Ep2, FlowRes, freq, h);
    }


    /// <summary>
    /// Provides the standard 12-input MWArray interface to the TMPanelElasticPanel
    /// MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This is a function program to define the transfer matrix for panel-foam-panel
    /// alyer
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="Densityp1">Input argument #4</param>
    /// <param name="Densityp2">Input argument #5</param>
    /// <param name="Em">Input argument #6</param>
    /// <param name="Ep1">Input argument #7</param>
    /// <param name="Ep2">Input argument #8</param>
    /// <param name="FlowRes">Input argument #9</param>
    /// <param name="freq">Input argument #10</param>
    /// <param name="h">Input argument #11</param>
    /// <param name="HeatRatio">Input argument #12</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] TMPanelElasticPanel(int numArgsOut, MWArray BulkDensity, MWArray c, 
                                   MWArray Densityo, MWArray Densityp1, MWArray 
                                   Densityp2, MWArray Em, MWArray Ep1, MWArray Ep2, 
                                   MWArray FlowRes, MWArray freq, MWArray h, MWArray 
                                   HeatRatio)
    {
      return mcr.EvaluateFunction(numArgsOut, "TMPanelElasticPanel", BulkDensity, c, Densityo, Densityp1, Densityp2, Em, Ep1, Ep2, FlowRes, freq, h, HeatRatio);
    }


    /// <summary>
    /// Provides the standard 13-input MWArray interface to the TMPanelElasticPanel
    /// MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This is a function program to define the transfer matrix for panel-foam-panel
    /// alyer
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="Densityp1">Input argument #4</param>
    /// <param name="Densityp2">Input argument #5</param>
    /// <param name="Em">Input argument #6</param>
    /// <param name="Ep1">Input argument #7</param>
    /// <param name="Ep2">Input argument #8</param>
    /// <param name="FlowRes">Input argument #9</param>
    /// <param name="freq">Input argument #10</param>
    /// <param name="h">Input argument #11</param>
    /// <param name="HeatRatio">Input argument #12</param>
    /// <param name="hp1">Input argument #13</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] TMPanelElasticPanel(int numArgsOut, MWArray BulkDensity, MWArray c, 
                                   MWArray Densityo, MWArray Densityp1, MWArray 
                                   Densityp2, MWArray Em, MWArray Ep1, MWArray Ep2, 
                                   MWArray FlowRes, MWArray freq, MWArray h, MWArray 
                                   HeatRatio, MWArray hp1)
    {
      return mcr.EvaluateFunction(numArgsOut, "TMPanelElasticPanel", BulkDensity, c, Densityo, Densityp1, Densityp2, Em, Ep1, Ep2, FlowRes, freq, h, HeatRatio, hp1);
    }


    /// <summary>
    /// Provides the standard 14-input MWArray interface to the TMPanelElasticPanel
    /// MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This is a function program to define the transfer matrix for panel-foam-panel
    /// alyer
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="Densityp1">Input argument #4</param>
    /// <param name="Densityp2">Input argument #5</param>
    /// <param name="Em">Input argument #6</param>
    /// <param name="Ep1">Input argument #7</param>
    /// <param name="Ep2">Input argument #8</param>
    /// <param name="FlowRes">Input argument #9</param>
    /// <param name="freq">Input argument #10</param>
    /// <param name="h">Input argument #11</param>
    /// <param name="HeatRatio">Input argument #12</param>
    /// <param name="hp1">Input argument #13</param>
    /// <param name="hp2">Input argument #14</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] TMPanelElasticPanel(int numArgsOut, MWArray BulkDensity, MWArray c, 
                                   MWArray Densityo, MWArray Densityp1, MWArray 
                                   Densityp2, MWArray Em, MWArray Ep1, MWArray Ep2, 
                                   MWArray FlowRes, MWArray freq, MWArray h, MWArray 
                                   HeatRatio, MWArray hp1, MWArray hp2)
    {
      return mcr.EvaluateFunction(numArgsOut, "TMPanelElasticPanel", BulkDensity, c, Densityo, Densityp1, Densityp2, Em, Ep1, Ep2, FlowRes, freq, h, HeatRatio, hp1, hp2);
    }


    /// <summary>
    /// Provides the standard 15-input MWArray interface to the TMPanelElasticPanel
    /// MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This is a function program to define the transfer matrix for panel-foam-panel
    /// alyer
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="Densityp1">Input argument #4</param>
    /// <param name="Densityp2">Input argument #5</param>
    /// <param name="Em">Input argument #6</param>
    /// <param name="Ep1">Input argument #7</param>
    /// <param name="Ep2">Input argument #8</param>
    /// <param name="FlowRes">Input argument #9</param>
    /// <param name="freq">Input argument #10</param>
    /// <param name="h">Input argument #11</param>
    /// <param name="HeatRatio">Input argument #12</param>
    /// <param name="hp1">Input argument #13</param>
    /// <param name="hp2">Input argument #14</param>
    /// <param name="ItaAir">Input argument #15</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] TMPanelElasticPanel(int numArgsOut, MWArray BulkDensity, MWArray c, 
                                   MWArray Densityo, MWArray Densityp1, MWArray 
                                   Densityp2, MWArray Em, MWArray Ep1, MWArray Ep2, 
                                   MWArray FlowRes, MWArray freq, MWArray h, MWArray 
                                   HeatRatio, MWArray hp1, MWArray hp2, MWArray ItaAir)
    {
      return mcr.EvaluateFunction(numArgsOut, "TMPanelElasticPanel", BulkDensity, c, Densityo, Densityp1, Densityp2, Em, Ep1, Ep2, FlowRes, freq, h, HeatRatio, hp1, hp2, ItaAir);
    }


    /// <summary>
    /// Provides the standard 16-input MWArray interface to the TMPanelElasticPanel
    /// MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This is a function program to define the transfer matrix for panel-foam-panel
    /// alyer
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="Densityp1">Input argument #4</param>
    /// <param name="Densityp2">Input argument #5</param>
    /// <param name="Em">Input argument #6</param>
    /// <param name="Ep1">Input argument #7</param>
    /// <param name="Ep2">Input argument #8</param>
    /// <param name="FlowRes">Input argument #9</param>
    /// <param name="freq">Input argument #10</param>
    /// <param name="h">Input argument #11</param>
    /// <param name="HeatRatio">Input argument #12</param>
    /// <param name="hp1">Input argument #13</param>
    /// <param name="hp2">Input argument #14</param>
    /// <param name="ItaAir">Input argument #15</param>
    /// <param name="L">Input argument #16</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] TMPanelElasticPanel(int numArgsOut, MWArray BulkDensity, MWArray c, 
                                   MWArray Densityo, MWArray Densityp1, MWArray 
                                   Densityp2, MWArray Em, MWArray Ep1, MWArray Ep2, 
                                   MWArray FlowRes, MWArray freq, MWArray h, MWArray 
                                   HeatRatio, MWArray hp1, MWArray hp2, MWArray ItaAir, 
                                   MWArray L)
    {
      return mcr.EvaluateFunction(numArgsOut, "TMPanelElasticPanel", BulkDensity, c, Densityo, Densityp1, Densityp2, Em, Ep1, Ep2, FlowRes, freq, h, HeatRatio, hp1, hp2, ItaAir, L);
    }


    /// <summary>
    /// Provides the standard 17-input MWArray interface to the TMPanelElasticPanel
    /// MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This is a function program to define the transfer matrix for panel-foam-panel
    /// alyer
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="Densityp1">Input argument #4</param>
    /// <param name="Densityp2">Input argument #5</param>
    /// <param name="Em">Input argument #6</param>
    /// <param name="Ep1">Input argument #7</param>
    /// <param name="Ep2">Input argument #8</param>
    /// <param name="FlowRes">Input argument #9</param>
    /// <param name="freq">Input argument #10</param>
    /// <param name="h">Input argument #11</param>
    /// <param name="HeatRatio">Input argument #12</param>
    /// <param name="hp1">Input argument #13</param>
    /// <param name="hp2">Input argument #14</param>
    /// <param name="ItaAir">Input argument #15</param>
    /// <param name="L">Input argument #16</param>
    /// <param name="LFactor">Input argument #17</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] TMPanelElasticPanel(int numArgsOut, MWArray BulkDensity, MWArray c, 
                                   MWArray Densityo, MWArray Densityp1, MWArray 
                                   Densityp2, MWArray Em, MWArray Ep1, MWArray Ep2, 
                                   MWArray FlowRes, MWArray freq, MWArray h, MWArray 
                                   HeatRatio, MWArray hp1, MWArray hp2, MWArray ItaAir, 
                                   MWArray L, MWArray LFactor)
    {
      return mcr.EvaluateFunction(numArgsOut, "TMPanelElasticPanel", BulkDensity, c, Densityo, Densityp1, Densityp2, Em, Ep1, Ep2, FlowRes, freq, h, HeatRatio, hp1, hp2, ItaAir, L, LFactor);
    }


    /// <summary>
    /// Provides the standard 18-input MWArray interface to the TMPanelElasticPanel
    /// MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This is a function program to define the transfer matrix for panel-foam-panel
    /// alyer
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="Densityp1">Input argument #4</param>
    /// <param name="Densityp2">Input argument #5</param>
    /// <param name="Em">Input argument #6</param>
    /// <param name="Ep1">Input argument #7</param>
    /// <param name="Ep2">Input argument #8</param>
    /// <param name="FlowRes">Input argument #9</param>
    /// <param name="freq">Input argument #10</param>
    /// <param name="h">Input argument #11</param>
    /// <param name="HeatRatio">Input argument #12</param>
    /// <param name="hp1">Input argument #13</param>
    /// <param name="hp2">Input argument #14</param>
    /// <param name="ItaAir">Input argument #15</param>
    /// <param name="L">Input argument #16</param>
    /// <param name="LFactor">Input argument #17</param>
    /// <param name="Npr">Input argument #18</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] TMPanelElasticPanel(int numArgsOut, MWArray BulkDensity, MWArray c, 
                                   MWArray Densityo, MWArray Densityp1, MWArray 
                                   Densityp2, MWArray Em, MWArray Ep1, MWArray Ep2, 
                                   MWArray FlowRes, MWArray freq, MWArray h, MWArray 
                                   HeatRatio, MWArray hp1, MWArray hp2, MWArray ItaAir, 
                                   MWArray L, MWArray LFactor, MWArray Npr)
    {
      return mcr.EvaluateFunction(numArgsOut, "TMPanelElasticPanel", BulkDensity, c, Densityo, Densityp1, Densityp2, Em, Ep1, Ep2, FlowRes, freq, h, HeatRatio, hp1, hp2, ItaAir, L, LFactor, Npr);
    }


    /// <summary>
    /// Provides the standard 19-input MWArray interface to the TMPanelElasticPanel
    /// MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This is a function program to define the transfer matrix for panel-foam-panel
    /// alyer
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="Densityp1">Input argument #4</param>
    /// <param name="Densityp2">Input argument #5</param>
    /// <param name="Em">Input argument #6</param>
    /// <param name="Ep1">Input argument #7</param>
    /// <param name="Ep2">Input argument #8</param>
    /// <param name="FlowRes">Input argument #9</param>
    /// <param name="freq">Input argument #10</param>
    /// <param name="h">Input argument #11</param>
    /// <param name="HeatRatio">Input argument #12</param>
    /// <param name="hp1">Input argument #13</param>
    /// <param name="hp2">Input argument #14</param>
    /// <param name="ItaAir">Input argument #15</param>
    /// <param name="L">Input argument #16</param>
    /// <param name="LFactor">Input argument #17</param>
    /// <param name="Npr">Input argument #18</param>
    /// <param name="PRatio">Input argument #19</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] TMPanelElasticPanel(int numArgsOut, MWArray BulkDensity, MWArray c, 
                                   MWArray Densityo, MWArray Densityp1, MWArray 
                                   Densityp2, MWArray Em, MWArray Ep1, MWArray Ep2, 
                                   MWArray FlowRes, MWArray freq, MWArray h, MWArray 
                                   HeatRatio, MWArray hp1, MWArray hp2, MWArray ItaAir, 
                                   MWArray L, MWArray LFactor, MWArray Npr, MWArray 
                                   PRatio)
    {
      return mcr.EvaluateFunction(numArgsOut, "TMPanelElasticPanel", BulkDensity, c, Densityo, Densityp1, Densityp2, Em, Ep1, Ep2, FlowRes, freq, h, HeatRatio, hp1, hp2, ItaAir, L, LFactor, Npr, PRatio);
    }


    /// <summary>
    /// Provides the standard 20-input MWArray interface to the TMPanelElasticPanel
    /// MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This is a function program to define the transfer matrix for panel-foam-panel
    /// alyer
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="Densityp1">Input argument #4</param>
    /// <param name="Densityp2">Input argument #5</param>
    /// <param name="Em">Input argument #6</param>
    /// <param name="Ep1">Input argument #7</param>
    /// <param name="Ep2">Input argument #8</param>
    /// <param name="FlowRes">Input argument #9</param>
    /// <param name="freq">Input argument #10</param>
    /// <param name="h">Input argument #11</param>
    /// <param name="HeatRatio">Input argument #12</param>
    /// <param name="hp1">Input argument #13</param>
    /// <param name="hp2">Input argument #14</param>
    /// <param name="ItaAir">Input argument #15</param>
    /// <param name="L">Input argument #16</param>
    /// <param name="LFactor">Input argument #17</param>
    /// <param name="Npr">Input argument #18</param>
    /// <param name="PRatio">Input argument #19</param>
    /// <param name="PRatiop1">Input argument #20</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] TMPanelElasticPanel(int numArgsOut, MWArray BulkDensity, MWArray c, 
                                   MWArray Densityo, MWArray Densityp1, MWArray 
                                   Densityp2, MWArray Em, MWArray Ep1, MWArray Ep2, 
                                   MWArray FlowRes, MWArray freq, MWArray h, MWArray 
                                   HeatRatio, MWArray hp1, MWArray hp2, MWArray ItaAir, 
                                   MWArray L, MWArray LFactor, MWArray Npr, MWArray 
                                   PRatio, MWArray PRatiop1)
    {
      return mcr.EvaluateFunction(numArgsOut, "TMPanelElasticPanel", BulkDensity, c, Densityo, Densityp1, Densityp2, Em, Ep1, Ep2, FlowRes, freq, h, HeatRatio, hp1, hp2, ItaAir, L, LFactor, Npr, PRatio, PRatiop1);
    }


    /// <summary>
    /// Provides the standard 21-input MWArray interface to the TMPanelElasticPanel
    /// MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This is a function program to define the transfer matrix for panel-foam-panel
    /// alyer
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="Densityp1">Input argument #4</param>
    /// <param name="Densityp2">Input argument #5</param>
    /// <param name="Em">Input argument #6</param>
    /// <param name="Ep1">Input argument #7</param>
    /// <param name="Ep2">Input argument #8</param>
    /// <param name="FlowRes">Input argument #9</param>
    /// <param name="freq">Input argument #10</param>
    /// <param name="h">Input argument #11</param>
    /// <param name="HeatRatio">Input argument #12</param>
    /// <param name="hp1">Input argument #13</param>
    /// <param name="hp2">Input argument #14</param>
    /// <param name="ItaAir">Input argument #15</param>
    /// <param name="L">Input argument #16</param>
    /// <param name="LFactor">Input argument #17</param>
    /// <param name="Npr">Input argument #18</param>
    /// <param name="PRatio">Input argument #19</param>
    /// <param name="PRatiop1">Input argument #20</param>
    /// <param name="PRatiop2">Input argument #21</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] TMPanelElasticPanel(int numArgsOut, MWArray BulkDensity, MWArray c, 
                                   MWArray Densityo, MWArray Densityp1, MWArray 
                                   Densityp2, MWArray Em, MWArray Ep1, MWArray Ep2, 
                                   MWArray FlowRes, MWArray freq, MWArray h, MWArray 
                                   HeatRatio, MWArray hp1, MWArray hp2, MWArray ItaAir, 
                                   MWArray L, MWArray LFactor, MWArray Npr, MWArray 
                                   PRatio, MWArray PRatiop1, MWArray PRatiop2)
    {
      return mcr.EvaluateFunction(numArgsOut, "TMPanelElasticPanel", BulkDensity, c, Densityo, Densityp1, Densityp2, Em, Ep1, Ep2, FlowRes, freq, h, HeatRatio, hp1, hp2, ItaAir, L, LFactor, Npr, PRatio, PRatiop1, PRatiop2);
    }


    /// <summary>
    /// Provides the standard 22-input MWArray interface to the TMPanelElasticPanel
    /// MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This is a function program to define the transfer matrix for panel-foam-panel
    /// alyer
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="Densityp1">Input argument #4</param>
    /// <param name="Densityp2">Input argument #5</param>
    /// <param name="Em">Input argument #6</param>
    /// <param name="Ep1">Input argument #7</param>
    /// <param name="Ep2">Input argument #8</param>
    /// <param name="FlowRes">Input argument #9</param>
    /// <param name="freq">Input argument #10</param>
    /// <param name="h">Input argument #11</param>
    /// <param name="HeatRatio">Input argument #12</param>
    /// <param name="hp1">Input argument #13</param>
    /// <param name="hp2">Input argument #14</param>
    /// <param name="ItaAir">Input argument #15</param>
    /// <param name="L">Input argument #16</param>
    /// <param name="LFactor">Input argument #17</param>
    /// <param name="Npr">Input argument #18</param>
    /// <param name="PRatio">Input argument #19</param>
    /// <param name="PRatiop1">Input argument #20</param>
    /// <param name="PRatiop2">Input argument #21</param>
    /// <param name="SFactor">Input argument #22</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] TMPanelElasticPanel(int numArgsOut, MWArray BulkDensity, MWArray c, 
                                   MWArray Densityo, MWArray Densityp1, MWArray 
                                   Densityp2, MWArray Em, MWArray Ep1, MWArray Ep2, 
                                   MWArray FlowRes, MWArray freq, MWArray h, MWArray 
                                   HeatRatio, MWArray hp1, MWArray hp2, MWArray ItaAir, 
                                   MWArray L, MWArray LFactor, MWArray Npr, MWArray 
                                   PRatio, MWArray PRatiop1, MWArray PRatiop2, MWArray 
                                   SFactor)
    {
      return mcr.EvaluateFunction(numArgsOut, "TMPanelElasticPanel", BulkDensity, c, Densityo, Densityp1, Densityp2, Em, Ep1, Ep2, FlowRes, freq, h, HeatRatio, hp1, hp2, ItaAir, L, LFactor, Npr, PRatio, PRatiop1, PRatiop2, SFactor);
    }


    /// <summary>
    /// Provides the standard 23-input MWArray interface to the TMPanelElasticPanel
    /// MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This is a function program to define the transfer matrix for panel-foam-panel
    /// alyer
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="Densityp1">Input argument #4</param>
    /// <param name="Densityp2">Input argument #5</param>
    /// <param name="Em">Input argument #6</param>
    /// <param name="Ep1">Input argument #7</param>
    /// <param name="Ep2">Input argument #8</param>
    /// <param name="FlowRes">Input argument #9</param>
    /// <param name="freq">Input argument #10</param>
    /// <param name="h">Input argument #11</param>
    /// <param name="HeatRatio">Input argument #12</param>
    /// <param name="hp1">Input argument #13</param>
    /// <param name="hp2">Input argument #14</param>
    /// <param name="ItaAir">Input argument #15</param>
    /// <param name="L">Input argument #16</param>
    /// <param name="LFactor">Input argument #17</param>
    /// <param name="Npr">Input argument #18</param>
    /// <param name="PRatio">Input argument #19</param>
    /// <param name="PRatiop1">Input argument #20</param>
    /// <param name="PRatiop2">Input argument #21</param>
    /// <param name="SFactor">Input argument #22</param>
    /// <param name="TCL">Input argument #23</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] TMPanelElasticPanel(int numArgsOut, MWArray BulkDensity, MWArray c, 
                                   MWArray Densityo, MWArray Densityp1, MWArray 
                                   Densityp2, MWArray Em, MWArray Ep1, MWArray Ep2, 
                                   MWArray FlowRes, MWArray freq, MWArray h, MWArray 
                                   HeatRatio, MWArray hp1, MWArray hp2, MWArray ItaAir, 
                                   MWArray L, MWArray LFactor, MWArray Npr, MWArray 
                                   PRatio, MWArray PRatiop1, MWArray PRatiop2, MWArray 
                                   SFactor, MWArray TCL)
    {
      return mcr.EvaluateFunction(numArgsOut, "TMPanelElasticPanel", BulkDensity, c, Densityo, Densityp1, Densityp2, Em, Ep1, Ep2, FlowRes, freq, h, HeatRatio, hp1, hp2, ItaAir, L, LFactor, Npr, PRatio, PRatiop1, PRatiop2, SFactor, TCL);
    }


    /// <summary>
    /// Provides the standard 24-input MWArray interface to the TMPanelElasticPanel
    /// MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This is a function program to define the transfer matrix for panel-foam-panel
    /// alyer
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="Densityp1">Input argument #4</param>
    /// <param name="Densityp2">Input argument #5</param>
    /// <param name="Em">Input argument #6</param>
    /// <param name="Ep1">Input argument #7</param>
    /// <param name="Ep2">Input argument #8</param>
    /// <param name="FlowRes">Input argument #9</param>
    /// <param name="freq">Input argument #10</param>
    /// <param name="h">Input argument #11</param>
    /// <param name="HeatRatio">Input argument #12</param>
    /// <param name="hp1">Input argument #13</param>
    /// <param name="hp2">Input argument #14</param>
    /// <param name="ItaAir">Input argument #15</param>
    /// <param name="L">Input argument #16</param>
    /// <param name="LFactor">Input argument #17</param>
    /// <param name="Npr">Input argument #18</param>
    /// <param name="PRatio">Input argument #19</param>
    /// <param name="PRatiop1">Input argument #20</param>
    /// <param name="PRatiop2">Input argument #21</param>
    /// <param name="SFactor">Input argument #22</param>
    /// <param name="TCL">Input argument #23</param>
    /// <param name="theta">Input argument #24</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] TMPanelElasticPanel(int numArgsOut, MWArray BulkDensity, MWArray c, 
                                   MWArray Densityo, MWArray Densityp1, MWArray 
                                   Densityp2, MWArray Em, MWArray Ep1, MWArray Ep2, 
                                   MWArray FlowRes, MWArray freq, MWArray h, MWArray 
                                   HeatRatio, MWArray hp1, MWArray hp2, MWArray ItaAir, 
                                   MWArray L, MWArray LFactor, MWArray Npr, MWArray 
                                   PRatio, MWArray PRatiop1, MWArray PRatiop2, MWArray 
                                   SFactor, MWArray TCL, MWArray theta)
    {
      return mcr.EvaluateFunction(numArgsOut, "TMPanelElasticPanel", BulkDensity, c, Densityo, Densityp1, Densityp2, Em, Ep1, Ep2, FlowRes, freq, h, HeatRatio, hp1, hp2, ItaAir, L, LFactor, Npr, PRatio, PRatiop1, PRatiop2, SFactor, TCL, theta);
    }


    /// <summary>
    /// Provides the standard 25-input MWArray interface to the TMPanelElasticPanel
    /// MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This is a function program to define the transfer matrix for panel-foam-panel
    /// alyer
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="Densityp1">Input argument #4</param>
    /// <param name="Densityp2">Input argument #5</param>
    /// <param name="Em">Input argument #6</param>
    /// <param name="Ep1">Input argument #7</param>
    /// <param name="Ep2">Input argument #8</param>
    /// <param name="FlowRes">Input argument #9</param>
    /// <param name="freq">Input argument #10</param>
    /// <param name="h">Input argument #11</param>
    /// <param name="HeatRatio">Input argument #12</param>
    /// <param name="hp1">Input argument #13</param>
    /// <param name="hp2">Input argument #14</param>
    /// <param name="ItaAir">Input argument #15</param>
    /// <param name="L">Input argument #16</param>
    /// <param name="LFactor">Input argument #17</param>
    /// <param name="Npr">Input argument #18</param>
    /// <param name="PRatio">Input argument #19</param>
    /// <param name="PRatiop1">Input argument #20</param>
    /// <param name="PRatiop2">Input argument #21</param>
    /// <param name="SFactor">Input argument #22</param>
    /// <param name="TCL">Input argument #23</param>
    /// <param name="theta">Input argument #24</param>
    /// <param name="VCL">Input argument #25</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] TMPanelElasticPanel(int numArgsOut, MWArray BulkDensity, MWArray c, 
                                   MWArray Densityo, MWArray Densityp1, MWArray 
                                   Densityp2, MWArray Em, MWArray Ep1, MWArray Ep2, 
                                   MWArray FlowRes, MWArray freq, MWArray h, MWArray 
                                   HeatRatio, MWArray hp1, MWArray hp2, MWArray ItaAir, 
                                   MWArray L, MWArray LFactor, MWArray Npr, MWArray 
                                   PRatio, MWArray PRatiop1, MWArray PRatiop2, MWArray 
                                   SFactor, MWArray TCL, MWArray theta, MWArray VCL)
    {
      return mcr.EvaluateFunction(numArgsOut, "TMPanelElasticPanel", BulkDensity, c, Densityo, Densityp1, Densityp2, Em, Ep1, Ep2, FlowRes, freq, h, HeatRatio, hp1, hp2, ItaAir, L, LFactor, Npr, PRatio, PRatiop1, PRatiop2, SFactor, TCL, theta, VCL);
    }


    /// <summary>
    /// Provides an interface for the TMPanelElasticPanel function in which the input and
    /// output
    /// arguments are specified as an array of MWArrays.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// M-Documentation:
    /// This is a function program to define the transfer matrix for panel-foam-panel
    /// alyer
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of MWArray output arguments</param>
    /// <param name= "argsIn">Array of MWArray input arguments</param>
    ///
    public void TMPanelElasticPanel(int numArgsOut, ref MWArray[] argsOut, MWArray[] 
                          argsIn)
    {
      mcr.EvaluateFunction("TMPanelElasticPanel", numArgsOut, ref argsOut, argsIn);
    }


    /// <summary>
    /// Provides a single output, 0-input MWArrayinterface to the TMperMemb MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Constant and variable definition
    /// </remarks>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray TMperMemb()
    {
      return mcr.EvaluateFunction("TMperMemb", new MWArray[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input MWArrayinterface to the TMperMemb MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Constant and variable definition
    /// </remarks>
    /// <param name="Density">Input argument #1</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray TMperMemb(MWArray Density)
    {
      return mcr.EvaluateFunction("TMperMemb", Density);
    }


    /// <summary>
    /// Provides a single output, 2-input MWArrayinterface to the TMperMemb MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Constant and variable definition
    /// </remarks>
    /// <param name="Density">Input argument #1</param>
    /// <param name="FlowRes">Input argument #2</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray TMperMemb(MWArray Density, MWArray FlowRes)
    {
      return mcr.EvaluateFunction("TMperMemb", Density, FlowRes);
    }


    /// <summary>
    /// Provides a single output, 3-input MWArrayinterface to the TMperMemb MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Constant and variable definition
    /// </remarks>
    /// <param name="Density">Input argument #1</param>
    /// <param name="FlowRes">Input argument #2</param>
    /// <param name="freq">Input argument #3</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray TMperMemb(MWArray Density, MWArray FlowRes, MWArray freq)
    {
      return mcr.EvaluateFunction("TMperMemb", Density, FlowRes, freq);
    }


    /// <summary>
    /// Provides a single output, 4-input MWArrayinterface to the TMperMemb MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Constant and variable definition
    /// </remarks>
    /// <param name="Density">Input argument #1</param>
    /// <param name="FlowRes">Input argument #2</param>
    /// <param name="freq">Input argument #3</param>
    /// <param name="L">Input argument #4</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray TMperMemb(MWArray Density, MWArray FlowRes, MWArray freq, MWArray L)
    {
      return mcr.EvaluateFunction("TMperMemb", Density, FlowRes, freq, L);
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the TMperMemb MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Constant and variable definition
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] TMperMemb(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "TMperMemb", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 1-input MWArray interface to the TMperMemb MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Constant and variable definition
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="Density">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] TMperMemb(int numArgsOut, MWArray Density)
    {
      return mcr.EvaluateFunction(numArgsOut, "TMperMemb", Density);
    }


    /// <summary>
    /// Provides the standard 2-input MWArray interface to the TMperMemb MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Constant and variable definition
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="Density">Input argument #1</param>
    /// <param name="FlowRes">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] TMperMemb(int numArgsOut, MWArray Density, MWArray FlowRes)
    {
      return mcr.EvaluateFunction(numArgsOut, "TMperMemb", Density, FlowRes);
    }


    /// <summary>
    /// Provides the standard 3-input MWArray interface to the TMperMemb MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Constant and variable definition
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="Density">Input argument #1</param>
    /// <param name="FlowRes">Input argument #2</param>
    /// <param name="freq">Input argument #3</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] TMperMemb(int numArgsOut, MWArray Density, MWArray FlowRes, MWArray 
                         freq)
    {
      return mcr.EvaluateFunction(numArgsOut, "TMperMemb", Density, FlowRes, freq);
    }


    /// <summary>
    /// Provides the standard 4-input MWArray interface to the TMperMemb MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Constant and variable definition
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="Density">Input argument #1</param>
    /// <param name="FlowRes">Input argument #2</param>
    /// <param name="freq">Input argument #3</param>
    /// <param name="L">Input argument #4</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] TMperMemb(int numArgsOut, MWArray Density, MWArray FlowRes, MWArray 
                         freq, MWArray L)
    {
      return mcr.EvaluateFunction(numArgsOut, "TMperMemb", Density, FlowRes, freq, L);
    }


    /// <summary>
    /// Provides an interface for the TMperMemb function in which the input and output
    /// arguments are specified as an array of MWArrays.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// M-Documentation:
    /// Constant and variable definition
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of MWArray output arguments</param>
    /// <param name= "argsIn">Array of MWArray input arguments</param>
    ///
    public void TMperMemb(int numArgsOut, ref MWArray[] argsOut, MWArray[] argsIn)
    {
      mcr.EvaluateFunction("TMperMemb", numArgsOut, ref argsOut, argsIn);
    }


    /// <summary>
    /// Provides a single output, 0-input MWArrayinterface to the TMRigid MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Constant and variable definition
    /// </remarks>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray TMRigid()
    {
      return mcr.EvaluateFunction("TMRigid", new MWArray[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input MWArrayinterface to the TMRigid MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Constant and variable definition
    /// </remarks>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray TMRigid(MWArray BulkDensity)
    {
      return mcr.EvaluateFunction("TMRigid", BulkDensity);
    }


    /// <summary>
    /// Provides a single output, 2-input MWArrayinterface to the TMRigid MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Constant and variable definition
    /// </remarks>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray TMRigid(MWArray BulkDensity, MWArray c)
    {
      return mcr.EvaluateFunction("TMRigid", BulkDensity, c);
    }


    /// <summary>
    /// Provides a single output, 3-input MWArrayinterface to the TMRigid MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Constant and variable definition
    /// </remarks>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray TMRigid(MWArray BulkDensity, MWArray c, MWArray Densityo)
    {
      return mcr.EvaluateFunction("TMRigid", BulkDensity, c, Densityo);
    }


    /// <summary>
    /// Provides a single output, 4-input MWArrayinterface to the TMRigid MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Constant and variable definition
    /// </remarks>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="FlowRes">Input argument #4</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray TMRigid(MWArray BulkDensity, MWArray c, MWArray Densityo, MWArray 
                     FlowRes)
    {
      return mcr.EvaluateFunction("TMRigid", BulkDensity, c, Densityo, FlowRes);
    }


    /// <summary>
    /// Provides a single output, 5-input MWArrayinterface to the TMRigid MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Constant and variable definition
    /// </remarks>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="FlowRes">Input argument #4</param>
    /// <param name="freq">Input argument #5</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray TMRigid(MWArray BulkDensity, MWArray c, MWArray Densityo, MWArray 
                     FlowRes, MWArray freq)
    {
      return mcr.EvaluateFunction("TMRigid", BulkDensity, c, Densityo, FlowRes, freq);
    }


    /// <summary>
    /// Provides a single output, 6-input MWArrayinterface to the TMRigid MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Constant and variable definition
    /// </remarks>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="FlowRes">Input argument #4</param>
    /// <param name="freq">Input argument #5</param>
    /// <param name="h">Input argument #6</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray TMRigid(MWArray BulkDensity, MWArray c, MWArray Densityo, MWArray 
                     FlowRes, MWArray freq, MWArray h)
    {
      return mcr.EvaluateFunction("TMRigid", BulkDensity, c, Densityo, FlowRes, freq, h);
    }


    /// <summary>
    /// Provides a single output, 7-input MWArrayinterface to the TMRigid MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Constant and variable definition
    /// </remarks>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="FlowRes">Input argument #4</param>
    /// <param name="freq">Input argument #5</param>
    /// <param name="h">Input argument #6</param>
    /// <param name="HeatRatio">Input argument #7</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray TMRigid(MWArray BulkDensity, MWArray c, MWArray Densityo, MWArray 
                     FlowRes, MWArray freq, MWArray h, MWArray HeatRatio)
    {
      return mcr.EvaluateFunction("TMRigid", BulkDensity, c, Densityo, FlowRes, freq, h, HeatRatio);
    }


    /// <summary>
    /// Provides a single output, 8-input MWArrayinterface to the TMRigid MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Constant and variable definition
    /// </remarks>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="FlowRes">Input argument #4</param>
    /// <param name="freq">Input argument #5</param>
    /// <param name="h">Input argument #6</param>
    /// <param name="HeatRatio">Input argument #7</param>
    /// <param name="ItaAir">Input argument #8</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray TMRigid(MWArray BulkDensity, MWArray c, MWArray Densityo, MWArray 
                     FlowRes, MWArray freq, MWArray h, MWArray HeatRatio, MWArray ItaAir)
    {
      return mcr.EvaluateFunction("TMRigid", BulkDensity, c, Densityo, FlowRes, freq, h, HeatRatio, ItaAir);
    }


    /// <summary>
    /// Provides a single output, 9-input MWArrayinterface to the TMRigid MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Constant and variable definition
    /// </remarks>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="FlowRes">Input argument #4</param>
    /// <param name="freq">Input argument #5</param>
    /// <param name="h">Input argument #6</param>
    /// <param name="HeatRatio">Input argument #7</param>
    /// <param name="ItaAir">Input argument #8</param>
    /// <param name="L">Input argument #9</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray TMRigid(MWArray BulkDensity, MWArray c, MWArray Densityo, MWArray 
                     FlowRes, MWArray freq, MWArray h, MWArray HeatRatio, MWArray ItaAir, 
                     MWArray L)
    {
      return mcr.EvaluateFunction("TMRigid", BulkDensity, c, Densityo, FlowRes, freq, h, HeatRatio, ItaAir, L);
    }


    /// <summary>
    /// Provides a single output, 10-input MWArrayinterface to the TMRigid MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Constant and variable definition
    /// </remarks>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="FlowRes">Input argument #4</param>
    /// <param name="freq">Input argument #5</param>
    /// <param name="h">Input argument #6</param>
    /// <param name="HeatRatio">Input argument #7</param>
    /// <param name="ItaAir">Input argument #8</param>
    /// <param name="L">Input argument #9</param>
    /// <param name="Npr">Input argument #10</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray TMRigid(MWArray BulkDensity, MWArray c, MWArray Densityo, MWArray 
                     FlowRes, MWArray freq, MWArray h, MWArray HeatRatio, MWArray ItaAir, 
                     MWArray L, MWArray Npr)
    {
      return mcr.EvaluateFunction("TMRigid", BulkDensity, c, Densityo, FlowRes, freq, h, HeatRatio, ItaAir, L, Npr);
    }


    /// <summary>
    /// Provides a single output, 11-input MWArrayinterface to the TMRigid MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Constant and variable definition
    /// </remarks>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="FlowRes">Input argument #4</param>
    /// <param name="freq">Input argument #5</param>
    /// <param name="h">Input argument #6</param>
    /// <param name="HeatRatio">Input argument #7</param>
    /// <param name="ItaAir">Input argument #8</param>
    /// <param name="L">Input argument #9</param>
    /// <param name="Npr">Input argument #10</param>
    /// <param name="P0">Input argument #11</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray TMRigid(MWArray BulkDensity, MWArray c, MWArray Densityo, MWArray 
                     FlowRes, MWArray freq, MWArray h, MWArray HeatRatio, MWArray ItaAir, 
                     MWArray L, MWArray Npr, MWArray P0)
    {
      return mcr.EvaluateFunction("TMRigid", BulkDensity, c, Densityo, FlowRes, freq, h, HeatRatio, ItaAir, L, Npr, P0);
    }


    /// <summary>
    /// Provides a single output, 12-input MWArrayinterface to the TMRigid MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Constant and variable definition
    /// </remarks>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="FlowRes">Input argument #4</param>
    /// <param name="freq">Input argument #5</param>
    /// <param name="h">Input argument #6</param>
    /// <param name="HeatRatio">Input argument #7</param>
    /// <param name="ItaAir">Input argument #8</param>
    /// <param name="L">Input argument #9</param>
    /// <param name="Npr">Input argument #10</param>
    /// <param name="P0">Input argument #11</param>
    /// <param name="SFactor">Input argument #12</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray TMRigid(MWArray BulkDensity, MWArray c, MWArray Densityo, MWArray 
                     FlowRes, MWArray freq, MWArray h, MWArray HeatRatio, MWArray ItaAir, 
                     MWArray L, MWArray Npr, MWArray P0, MWArray SFactor)
    {
      return mcr.EvaluateFunction("TMRigid", BulkDensity, c, Densityo, FlowRes, freq, h, HeatRatio, ItaAir, L, Npr, P0, SFactor);
    }


    /// <summary>
    /// Provides a single output, 13-input MWArrayinterface to the TMRigid MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Constant and variable definition
    /// </remarks>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="FlowRes">Input argument #4</param>
    /// <param name="freq">Input argument #5</param>
    /// <param name="h">Input argument #6</param>
    /// <param name="HeatRatio">Input argument #7</param>
    /// <param name="ItaAir">Input argument #8</param>
    /// <param name="L">Input argument #9</param>
    /// <param name="Npr">Input argument #10</param>
    /// <param name="P0">Input argument #11</param>
    /// <param name="SFactor">Input argument #12</param>
    /// <param name="TCL">Input argument #13</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray TMRigid(MWArray BulkDensity, MWArray c, MWArray Densityo, MWArray 
                     FlowRes, MWArray freq, MWArray h, MWArray HeatRatio, MWArray ItaAir, 
                     MWArray L, MWArray Npr, MWArray P0, MWArray SFactor, MWArray TCL)
    {
      return mcr.EvaluateFunction("TMRigid", BulkDensity, c, Densityo, FlowRes, freq, h, HeatRatio, ItaAir, L, Npr, P0, SFactor, TCL);
    }


    /// <summary>
    /// Provides a single output, 14-input MWArrayinterface to the TMRigid MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Constant and variable definition
    /// </remarks>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="FlowRes">Input argument #4</param>
    /// <param name="freq">Input argument #5</param>
    /// <param name="h">Input argument #6</param>
    /// <param name="HeatRatio">Input argument #7</param>
    /// <param name="ItaAir">Input argument #8</param>
    /// <param name="L">Input argument #9</param>
    /// <param name="Npr">Input argument #10</param>
    /// <param name="P0">Input argument #11</param>
    /// <param name="SFactor">Input argument #12</param>
    /// <param name="TCL">Input argument #13</param>
    /// <param name="theta">Input argument #14</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray TMRigid(MWArray BulkDensity, MWArray c, MWArray Densityo, MWArray 
                     FlowRes, MWArray freq, MWArray h, MWArray HeatRatio, MWArray ItaAir, 
                     MWArray L, MWArray Npr, MWArray P0, MWArray SFactor, MWArray TCL, 
                     MWArray theta)
    {
      return mcr.EvaluateFunction("TMRigid", BulkDensity, c, Densityo, FlowRes, freq, h, HeatRatio, ItaAir, L, Npr, P0, SFactor, TCL, theta);
    }


    /// <summary>
    /// Provides a single output, 15-input MWArrayinterface to the TMRigid MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Constant and variable definition
    /// </remarks>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="FlowRes">Input argument #4</param>
    /// <param name="freq">Input argument #5</param>
    /// <param name="h">Input argument #6</param>
    /// <param name="HeatRatio">Input argument #7</param>
    /// <param name="ItaAir">Input argument #8</param>
    /// <param name="L">Input argument #9</param>
    /// <param name="Npr">Input argument #10</param>
    /// <param name="P0">Input argument #11</param>
    /// <param name="SFactor">Input argument #12</param>
    /// <param name="TCL">Input argument #13</param>
    /// <param name="theta">Input argument #14</param>
    /// <param name="VCL">Input argument #15</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray TMRigid(MWArray BulkDensity, MWArray c, MWArray Densityo, MWArray 
                     FlowRes, MWArray freq, MWArray h, MWArray HeatRatio, MWArray ItaAir, 
                     MWArray L, MWArray Npr, MWArray P0, MWArray SFactor, MWArray TCL, 
                     MWArray theta, MWArray VCL)
    {
      return mcr.EvaluateFunction("TMRigid", BulkDensity, c, Densityo, FlowRes, freq, h, HeatRatio, ItaAir, L, Npr, P0, SFactor, TCL, theta, VCL);
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the TMRigid MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Constant and variable definition
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] TMRigid(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "TMRigid", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 1-input MWArray interface to the TMRigid MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Constant and variable definition
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] TMRigid(int numArgsOut, MWArray BulkDensity)
    {
      return mcr.EvaluateFunction(numArgsOut, "TMRigid", BulkDensity);
    }


    /// <summary>
    /// Provides the standard 2-input MWArray interface to the TMRigid MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Constant and variable definition
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] TMRigid(int numArgsOut, MWArray BulkDensity, MWArray c)
    {
      return mcr.EvaluateFunction(numArgsOut, "TMRigid", BulkDensity, c);
    }


    /// <summary>
    /// Provides the standard 3-input MWArray interface to the TMRigid MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Constant and variable definition
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] TMRigid(int numArgsOut, MWArray BulkDensity, MWArray c, MWArray 
                       Densityo)
    {
      return mcr.EvaluateFunction(numArgsOut, "TMRigid", BulkDensity, c, Densityo);
    }


    /// <summary>
    /// Provides the standard 4-input MWArray interface to the TMRigid MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Constant and variable definition
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="FlowRes">Input argument #4</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] TMRigid(int numArgsOut, MWArray BulkDensity, MWArray c, MWArray 
                       Densityo, MWArray FlowRes)
    {
      return mcr.EvaluateFunction(numArgsOut, "TMRigid", BulkDensity, c, Densityo, FlowRes);
    }


    /// <summary>
    /// Provides the standard 5-input MWArray interface to the TMRigid MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Constant and variable definition
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="FlowRes">Input argument #4</param>
    /// <param name="freq">Input argument #5</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] TMRigid(int numArgsOut, MWArray BulkDensity, MWArray c, MWArray 
                       Densityo, MWArray FlowRes, MWArray freq)
    {
      return mcr.EvaluateFunction(numArgsOut, "TMRigid", BulkDensity, c, Densityo, FlowRes, freq);
    }


    /// <summary>
    /// Provides the standard 6-input MWArray interface to the TMRigid MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Constant and variable definition
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="FlowRes">Input argument #4</param>
    /// <param name="freq">Input argument #5</param>
    /// <param name="h">Input argument #6</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] TMRigid(int numArgsOut, MWArray BulkDensity, MWArray c, MWArray 
                       Densityo, MWArray FlowRes, MWArray freq, MWArray h)
    {
      return mcr.EvaluateFunction(numArgsOut, "TMRigid", BulkDensity, c, Densityo, FlowRes, freq, h);
    }


    /// <summary>
    /// Provides the standard 7-input MWArray interface to the TMRigid MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Constant and variable definition
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="FlowRes">Input argument #4</param>
    /// <param name="freq">Input argument #5</param>
    /// <param name="h">Input argument #6</param>
    /// <param name="HeatRatio">Input argument #7</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] TMRigid(int numArgsOut, MWArray BulkDensity, MWArray c, MWArray 
                       Densityo, MWArray FlowRes, MWArray freq, MWArray h, MWArray 
                       HeatRatio)
    {
      return mcr.EvaluateFunction(numArgsOut, "TMRigid", BulkDensity, c, Densityo, FlowRes, freq, h, HeatRatio);
    }


    /// <summary>
    /// Provides the standard 8-input MWArray interface to the TMRigid MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Constant and variable definition
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="FlowRes">Input argument #4</param>
    /// <param name="freq">Input argument #5</param>
    /// <param name="h">Input argument #6</param>
    /// <param name="HeatRatio">Input argument #7</param>
    /// <param name="ItaAir">Input argument #8</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] TMRigid(int numArgsOut, MWArray BulkDensity, MWArray c, MWArray 
                       Densityo, MWArray FlowRes, MWArray freq, MWArray h, MWArray 
                       HeatRatio, MWArray ItaAir)
    {
      return mcr.EvaluateFunction(numArgsOut, "TMRigid", BulkDensity, c, Densityo, FlowRes, freq, h, HeatRatio, ItaAir);
    }


    /// <summary>
    /// Provides the standard 9-input MWArray interface to the TMRigid MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Constant and variable definition
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="FlowRes">Input argument #4</param>
    /// <param name="freq">Input argument #5</param>
    /// <param name="h">Input argument #6</param>
    /// <param name="HeatRatio">Input argument #7</param>
    /// <param name="ItaAir">Input argument #8</param>
    /// <param name="L">Input argument #9</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] TMRigid(int numArgsOut, MWArray BulkDensity, MWArray c, MWArray 
                       Densityo, MWArray FlowRes, MWArray freq, MWArray h, MWArray 
                       HeatRatio, MWArray ItaAir, MWArray L)
    {
      return mcr.EvaluateFunction(numArgsOut, "TMRigid", BulkDensity, c, Densityo, FlowRes, freq, h, HeatRatio, ItaAir, L);
    }


    /// <summary>
    /// Provides the standard 10-input MWArray interface to the TMRigid MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Constant and variable definition
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="FlowRes">Input argument #4</param>
    /// <param name="freq">Input argument #5</param>
    /// <param name="h">Input argument #6</param>
    /// <param name="HeatRatio">Input argument #7</param>
    /// <param name="ItaAir">Input argument #8</param>
    /// <param name="L">Input argument #9</param>
    /// <param name="Npr">Input argument #10</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] TMRigid(int numArgsOut, MWArray BulkDensity, MWArray c, MWArray 
                       Densityo, MWArray FlowRes, MWArray freq, MWArray h, MWArray 
                       HeatRatio, MWArray ItaAir, MWArray L, MWArray Npr)
    {
      return mcr.EvaluateFunction(numArgsOut, "TMRigid", BulkDensity, c, Densityo, FlowRes, freq, h, HeatRatio, ItaAir, L, Npr);
    }


    /// <summary>
    /// Provides the standard 11-input MWArray interface to the TMRigid MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Constant and variable definition
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="FlowRes">Input argument #4</param>
    /// <param name="freq">Input argument #5</param>
    /// <param name="h">Input argument #6</param>
    /// <param name="HeatRatio">Input argument #7</param>
    /// <param name="ItaAir">Input argument #8</param>
    /// <param name="L">Input argument #9</param>
    /// <param name="Npr">Input argument #10</param>
    /// <param name="P0">Input argument #11</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] TMRigid(int numArgsOut, MWArray BulkDensity, MWArray c, MWArray 
                       Densityo, MWArray FlowRes, MWArray freq, MWArray h, MWArray 
                       HeatRatio, MWArray ItaAir, MWArray L, MWArray Npr, MWArray P0)
    {
      return mcr.EvaluateFunction(numArgsOut, "TMRigid", BulkDensity, c, Densityo, FlowRes, freq, h, HeatRatio, ItaAir, L, Npr, P0);
    }


    /// <summary>
    /// Provides the standard 12-input MWArray interface to the TMRigid MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Constant and variable definition
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="FlowRes">Input argument #4</param>
    /// <param name="freq">Input argument #5</param>
    /// <param name="h">Input argument #6</param>
    /// <param name="HeatRatio">Input argument #7</param>
    /// <param name="ItaAir">Input argument #8</param>
    /// <param name="L">Input argument #9</param>
    /// <param name="Npr">Input argument #10</param>
    /// <param name="P0">Input argument #11</param>
    /// <param name="SFactor">Input argument #12</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] TMRigid(int numArgsOut, MWArray BulkDensity, MWArray c, MWArray 
                       Densityo, MWArray FlowRes, MWArray freq, MWArray h, MWArray 
                       HeatRatio, MWArray ItaAir, MWArray L, MWArray Npr, MWArray P0, 
                       MWArray SFactor)
    {
      return mcr.EvaluateFunction(numArgsOut, "TMRigid", BulkDensity, c, Densityo, FlowRes, freq, h, HeatRatio, ItaAir, L, Npr, P0, SFactor);
    }


    /// <summary>
    /// Provides the standard 13-input MWArray interface to the TMRigid MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Constant and variable definition
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="FlowRes">Input argument #4</param>
    /// <param name="freq">Input argument #5</param>
    /// <param name="h">Input argument #6</param>
    /// <param name="HeatRatio">Input argument #7</param>
    /// <param name="ItaAir">Input argument #8</param>
    /// <param name="L">Input argument #9</param>
    /// <param name="Npr">Input argument #10</param>
    /// <param name="P0">Input argument #11</param>
    /// <param name="SFactor">Input argument #12</param>
    /// <param name="TCL">Input argument #13</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] TMRigid(int numArgsOut, MWArray BulkDensity, MWArray c, MWArray 
                       Densityo, MWArray FlowRes, MWArray freq, MWArray h, MWArray 
                       HeatRatio, MWArray ItaAir, MWArray L, MWArray Npr, MWArray P0, 
                       MWArray SFactor, MWArray TCL)
    {
      return mcr.EvaluateFunction(numArgsOut, "TMRigid", BulkDensity, c, Densityo, FlowRes, freq, h, HeatRatio, ItaAir, L, Npr, P0, SFactor, TCL);
    }


    /// <summary>
    /// Provides the standard 14-input MWArray interface to the TMRigid MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Constant and variable definition
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="FlowRes">Input argument #4</param>
    /// <param name="freq">Input argument #5</param>
    /// <param name="h">Input argument #6</param>
    /// <param name="HeatRatio">Input argument #7</param>
    /// <param name="ItaAir">Input argument #8</param>
    /// <param name="L">Input argument #9</param>
    /// <param name="Npr">Input argument #10</param>
    /// <param name="P0">Input argument #11</param>
    /// <param name="SFactor">Input argument #12</param>
    /// <param name="TCL">Input argument #13</param>
    /// <param name="theta">Input argument #14</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] TMRigid(int numArgsOut, MWArray BulkDensity, MWArray c, MWArray 
                       Densityo, MWArray FlowRes, MWArray freq, MWArray h, MWArray 
                       HeatRatio, MWArray ItaAir, MWArray L, MWArray Npr, MWArray P0, 
                       MWArray SFactor, MWArray TCL, MWArray theta)
    {
      return mcr.EvaluateFunction(numArgsOut, "TMRigid", BulkDensity, c, Densityo, FlowRes, freq, h, HeatRatio, ItaAir, L, Npr, P0, SFactor, TCL, theta);
    }


    /// <summary>
    /// Provides the standard 15-input MWArray interface to the TMRigid MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Constant and variable definition
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="BulkDensity">Input argument #1</param>
    /// <param name="c">Input argument #2</param>
    /// <param name="Densityo">Input argument #3</param>
    /// <param name="FlowRes">Input argument #4</param>
    /// <param name="freq">Input argument #5</param>
    /// <param name="h">Input argument #6</param>
    /// <param name="HeatRatio">Input argument #7</param>
    /// <param name="ItaAir">Input argument #8</param>
    /// <param name="L">Input argument #9</param>
    /// <param name="Npr">Input argument #10</param>
    /// <param name="P0">Input argument #11</param>
    /// <param name="SFactor">Input argument #12</param>
    /// <param name="TCL">Input argument #13</param>
    /// <param name="theta">Input argument #14</param>
    /// <param name="VCL">Input argument #15</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] TMRigid(int numArgsOut, MWArray BulkDensity, MWArray c, MWArray 
                       Densityo, MWArray FlowRes, MWArray freq, MWArray h, MWArray 
                       HeatRatio, MWArray ItaAir, MWArray L, MWArray Npr, MWArray P0, 
                       MWArray SFactor, MWArray TCL, MWArray theta, MWArray VCL)
    {
      return mcr.EvaluateFunction(numArgsOut, "TMRigid", BulkDensity, c, Densityo, FlowRes, freq, h, HeatRatio, ItaAir, L, Npr, P0, SFactor, TCL, theta, VCL);
    }


    /// <summary>
    /// Provides an interface for the TMRigid function in which the input and output
    /// arguments are specified as an array of MWArrays.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// M-Documentation:
    /// Constant and variable definition
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of MWArray output arguments</param>
    /// <param name= "argsIn">Array of MWArray input arguments</param>
    ///
    public void TMRigid(int numArgsOut, ref MWArray[] argsOut, MWArray[] argsIn)
    {
      mcr.EvaluateFunction("TMRigid", numArgsOut, ref argsOut, argsIn);
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
