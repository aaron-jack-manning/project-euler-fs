module Problem014

// The basic function on which the Collatz sequence is based
let collatz = function
    | x when x % 2L = 0L ->
        x / 2L
    | x ->
        3L * x + 1L

// Calculates the length of the Collatz sequence for a given number
let rec sequenceLength = function
    | 1L -> 0
    | x -> 1 + sequenceLength (collatz x)

// Checks the sequence length of each input and passes in the next starting point, the greatest sequence length and the starting value that caused that greatest length in each recursive call
let rec longestChain startOfGreatest greatest start max =
    if start < max then
        match sequenceLength start with
        | x when x > greatest -> longestChain start x (start + 1L) max
        | x -> longestChain startOfGreatest greatest (start + 1L) max
    else
        startOfGreatest

let solve = longestChain 0 0 1 1_000_000