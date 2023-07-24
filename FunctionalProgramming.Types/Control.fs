module Control

let verificaSeONumeroPar number = 
    if number % 2 = 0 
        then "Pair"
        else "Unpaired"

let checkWithPatternMatching number = 
    match number % 2 = 0  with
    | true -> "Par"
    | false -> "Ímpar"
