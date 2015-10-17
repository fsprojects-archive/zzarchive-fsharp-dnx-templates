namespace $safeprojectname$

type Program () =
    member x.Main (argv: string array) =
        printfn "%A" argv
        0