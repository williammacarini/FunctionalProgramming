module Optional

let maybeString = Some "String"
let maybeNot = None

match maybeString with
    | Some text -> printfn "%s" text
    | None -> printfn "Invalid"

if maybeString.IsSome
    then printfn "%s" maybeString.Value
    else printfn "Invalid"

printfn "%s" maybeString.Value

let withValue = Some "Value"
let noValue = None

let lenght =
    match withValue with
    | Some texto -> texto.Length
    | None -> 0

let stringTest = "Test"

let stringCompare =
    match stringTest with
    | null -> None
    | valor -> Some valor

