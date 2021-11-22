
[<EntryPoint>]
let main args =
    // For more information see https://aka.ms/fsharp-console-apps
    let count = args.Length
    
    printfn "Passed in %d items: %A" count args

    0
