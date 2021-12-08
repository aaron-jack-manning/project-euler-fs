module Problem5

let divisible n k = n % k = 0

let rec divisibleUpTo n k =
    if k = 0 then
        true
    else
        divisible n k && divisibleUpTo n (k - 1)


let rec smallestDivisibleUpTo start largestFactor : int =
    if divisibleUpTo start largestFactor then
        start
    else
        smallestDivisibleUpTo (start + 1) largestFactor


let solve = smallestDivisibleUpTo 2520 20