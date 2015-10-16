# fsharp-dnx-templates
Visual Studio templates for creating DNX projects with F#.

# Getting started
[FSharpDNXConsoleApp](https://github.com/jbfp/fsharp-dnx-templates/tree/master/src/FSharpDNXConsoleApp) is a template that contains a reference to the real template ([FSharpConsoleApp](https://github.com/jbfp/fsharp-dnx-templates/tree/master/src/FSharpConsoleApp).) It might be possible to combine the templates, but I just copied the approach the ASP.NET guys took with [the official C# ASP.NET 5 templates](https://github.com/aspnet/Templates).
[FSharpConsoleApp](https://github.com/jbfp/fsharp-dnx-templates/tree/master/src/FSharpConsoleApp) is the actual contents of the project (`project.json`, `Program.fs`, the `.xproj` file`.)

* [FSharpConsoleApp](https://github.com/jbfp/fsharp-dnx-templates/tree/master/src/FSharpConsoleApp) goes into `..\Microsoft Visual Studio 14.0\Common7\IDE\AspNetProjectTemplates\1033\`
* [FSharpDNXConsoleApp](https://github.com/jbfp/fsharp-dnx-templates/tree/master/src/FSharpDNXConsoleApp) goes into `..\Microsoft Visual Studio 14.0\Common7\IDE\ProjectTemplates\FSharp\1033`

To get Visual Studio to register the templates, you can run `devenv.exe /installvstemplates`. (`devenv.exe` is in the `..\Microsoft Visual Studio 14.0\Common7\IDE\` folder.)

Visual Studio/`dnu restore` will probably fail to resolve the [`FSharp.Dnx`](https://github.com/fsprojects/fsharp-dnx) dependency because I don't think it's in the NuGet feed yet.
