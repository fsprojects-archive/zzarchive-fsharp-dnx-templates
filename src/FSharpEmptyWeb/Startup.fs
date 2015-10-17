namespace $safeprojectname$

open System
open System.Collections.Generic
open System.Linq
open System.Threading.Tasks
open Microsoft.AspNet.Builder
open Microsoft.AspNet.Http
open Microsoft.Extensions.DependencyInjection

type Startup () =
    member x.ConfigureServices(services: IServiceCollection) =
        ()
        
    member x.Configure(app: IApplicationBuilder) =
        // Add the platform handler to the request pipeline.
        app.UseIISPlatformHandler() |> ignore
    
        app.Run(fun (context: HttpContext) -> context.Response.WriteAsync("Hello World!"))