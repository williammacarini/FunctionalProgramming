open HighOrderFunction
open HighOrderFunctionWithMember

//Input
[<EntryPoint>]
let main argv = 
    let numbers = [1; 2; 3]

    printDoubleNumbersByLambda numbers

    printTheNumberWithNestedFunctions 5 numbers

    printNumberList 2 numbers

    let result1 = calculator.Add 5 3
    let result2 = calculator.Subtract 10 7

    printfn "Resultado da adição: %A" result1
    printfn "Resultado da subtração: %A" result2
    0
//Success
