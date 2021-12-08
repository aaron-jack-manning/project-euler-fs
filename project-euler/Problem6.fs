module Problem6

let sum last transformation =

    let mutable accumulator = 0

    for i = 1 to last do
        accumulator <- accumulator + (transformation i)

    accumulator

let square number = number * number

let solve = square (sum 100 (fun x -> x)) - sum 100 (fun x -> square x)
