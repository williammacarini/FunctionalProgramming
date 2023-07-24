module HighOrderFunctionWithMember

type Calculator =
    {
        Add: int -> int -> int
        Subtract: int -> int -> int
    }

let calculator : Calculator =
    {
        Add = (fun x y -> x + y)
        Subtract = (fun x y -> x - y)
    }