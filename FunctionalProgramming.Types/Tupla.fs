module Tupla

let tupla1 = 1, 2, 3
let item1, item2, item3 = tupla1

let tupla2 = 1, true, "Gabriel"
let item4, item5, item6 = tupla2

let tupla3 = 3, false
let item7 = fst tupla3
let item8 = snd tupla3

let tupla4 = 10, 10

let sumNumbers (number1, number2) = number1 + number2

let result = sumNumbers tupla4

