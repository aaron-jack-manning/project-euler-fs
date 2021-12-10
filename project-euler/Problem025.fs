module Problem025

// Generates fibonacci numbers using a bottom up approach, accumulating the index in each recursive call
let rec fibonacci index first second =
    // If the first in the pair of fibonacci numbers has 1000 digits, return the index
    if String.length (string first) = 1000 then
        index
    else
        fibonacci (index + 1) second (first + second)

let solve =
    fibonacci 1 1I 1I