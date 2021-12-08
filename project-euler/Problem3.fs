module Problem3

// Finds the smallest prime factor of a number by trial division.
let rec leastPrimeFactor (test : int64) (number : int64) : int64 =
    if number % test = 0L then
        test
    else
        leastPrimeFactor (test + 1L) number

let rec largestPrimeFactor (previousFactor : int64) (number : int64) =
    // First find the smallest prime factor of the number by trial division, starting with whatever the previously found highest factor was.
    let currentFactor = leastPrimeFactor previousFactor number    

    // The number is prime, hence we have found the last, and by extension the largest factor.
    if currentFactor = number then
        currentFactor
    // The number is composite, and can be divided again by a larger factor.
    else
        largestPrimeFactor currentFactor (number / currentFactor)

let solve = largestPrimeFactor 2L 600_851_475_143L