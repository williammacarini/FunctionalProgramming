open ComparisonTime
open System

//Funcion
let helloWorld() =
    printfn "Hello World!"

//Pipe and call a value
let squareNumber numero = numero * numero

let sumSquareNumberUntilTen =  
    [1..10] 
    |> List.map squareNumber 
    |> List.sum

//Type and Module and Open

//Input
[<EntryPoint>]
let main argv = 
    helloWorld()

    let result = sumSquareNumberUntilTen 
    printfn "Resultado: %d" result


    let comparisonTime = {
        StartDate = DateTime.Parse "01/01/2023";
        EndDate = DateTime.Parse "30/01/2023"; }

    let testDates =
        [|
            DateTime.Parse "02/01/2023"
            DateTime.Parse "22/02/2023"
            DateTime.Parse "02/01/2022"
        |]

    for date in testDates do
        let isPeriod = checkDatesIsBetween comparisonTime date
        printfn "%b" isPeriod

    Console.ReadKey() |> ignore
    0
//Success
