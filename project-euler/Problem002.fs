module Problem002

// Generates fibonacci numbers using a bottom up approach and passing in adjacent pairs into each recursive call
let rec fibonacci acc first second max =
    // This case indicates the numbers have gotten sufficiently large to stop and return acc
    if first > max then
        acc
    // If the first of the pair is even, add it to the accumulator before the next call with updated values for first and second
    elif first % 2 = 0 then
        fibonacci (acc + first) second (first + second) max
    // If the first of the pair is odd, just update the values of first and second
    else
        fibonacci acc second (first + second) max

let solve = fibonacci 0 1 2 4_000_000