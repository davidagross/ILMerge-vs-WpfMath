# ILMerge-vs-WpfMath
Trying to merge TeX rendering into a Winforms standalone.

## Reproduction
After building or downloading the enclosed project, execute `ILMerge-vs-WpfMath.Standalone.exe` from a `bin` subfolder.  The execution should succeed in rendering the equation.

Now, try moving the standalone executable to it's own folder (specifically, where `WpfMath.dll` is not present).  The execution will fail, throwing:

```
System.TypeInitializationException: The type initializer for 'WpfMath.DefaultTexFont' threw an exception. ---> System.IO.FileNotFoundException: The system cannot find the file specified. (Exception from HRESULT: 0x80070002)
   at System.Runtime.InteropServices.Marshal.ThrowExceptionForHRInternal(Int32 errorCode, IntPtr errorInfo)
   at System.Runtime.InteropServices.Marshal.ThrowExceptionForHR(Int32 errorCode, IntPtr errorInfo)
   at MS.Internal.Text.TextInterface.Native.Util.ConvertHresultToException(Int32 hr)
   at MS.Internal.Text.TextInterface.Factory.CreateFontFace(Uri filePathUri, UInt32 faceIndex, FontSimulations fontSimulationFlags)
   at System.Windows.Media.GlyphTypeface.Initialize(Uri typefaceSource, StyleSimulations styleSimulations)
   at WpfMath.DefaultTexFontParser.CreateFont(String name)
   at WpfMath.DefaultTexFontParser.GetFontDescriptions()
   at WpfMath.DefaultTexFont..cctor()
   --- End of inner exception stack trace ---
   at WpfMath.DefaultTexFont..ctor(Double size)
   at WpfMath.TexFormula.GetRenderer(TexStyle style, Double scale, String systemTextFontName)
   at WpfMath.Extensions.RenderToPng(TexFormula texForm, Double scale, Double x, Double y, String systemTextFontName)
   at ILMerge_vs_WpfMath.Renderer.DisplayEquation()
   at ILMerge_vs_WpfMath.Renderer..ctor()
```

Finally, try copying `WpfMath.dll` next to the standalone executable, and the render should succeed on reexecution.

## Diagnosis
Some resource of `WpfMath.dll` is not being merged properly, or one of it's resources is not included in such a way that it can be merged.

Either way, this repository will be linked to issues in both projects.
