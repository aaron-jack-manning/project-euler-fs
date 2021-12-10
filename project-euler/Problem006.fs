module Problem006

let first100 = [1..100]

// Sums the first 100 natural numbers by their square
let sumOfSquares =
    first100
    |> List.sumBy (fun x -> x * x)
// Note that this can also be done using:
    // |>List.map (fun x -> x * x) 
    // |> List.sum
    // OR
    // List.fold (fun s x -> s + x * x) 0
// but in general, using one specialised list function gives more efficient results due to the reduced number of iterations, and the specific optimizations made for the specific use case

// Sums the first 100 natural numbers then squares the result
let squareOfSum =
    pown (List.sum first100) 2

let solve = squareOfSum - sumOfSquares