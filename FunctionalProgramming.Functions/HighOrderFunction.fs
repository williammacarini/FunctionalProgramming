module HighOrderFunction

//Functions can receive other functions

let executeAction list action = list |> List.iter action 
    
let printDoubleANumber number = 
    printfn "%i" ( number * 2)

let multiply multiply number = 
    printfn "%i" ( number * multiply)

let printDoubleNumbers numbers = 
    executeAction numbers (printDoubleANumber)    

let printDoubleNumbersByLambda numbers = 
    executeAction numbers 
        (fun numero -> printfn "%i" (numero * 2))    

let printTheNumberWithNestedFunctions numberToMultiply numbers = 
    let printNumberFunction = multiply numberToMultiply
    executeAction numbers printNumberFunction 

let printNumberList numberToMultiply numbers = 
    executeAction numbers (multiply numberToMultiply) 