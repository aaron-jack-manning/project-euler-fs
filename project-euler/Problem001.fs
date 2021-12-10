module Problem001

let rec loop acc index =
    // When loop hits zero, return the accumulated value
    if index = 0 then
        acc
    // In cases where index is divisible by 3 or 5, add the index to the accumulator in the next recursive call
    elif index % 3 = 0 || index % 5 = 0 then
        loop (index + acc) (index - 1)
    // Reduce index in next call, mantaining accumulator
    else
        loop acc (index - 1)

// Accumulator starts at 0 always, and loop starts at 999 (going down to 0)
let solve = loop 0 999