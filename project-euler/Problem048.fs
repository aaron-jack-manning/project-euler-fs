module Problem048

// Returns a bigint of the last 10 digits of a bigint
let lastTenDigits number =
    number % (10_000_000_000I)

// Shadows the stdlib definition of pown to support bigint ^ bigint
let pown a b =
    
    let rec helper a b acc =
        if b = 0I then
            acc
        else
            helper a (b - 1I) (a * acc)

    helper a b 1I

// Calculates the sum of the numbers in the series, reducing mod 10,000,000,000 regularly
let rec reducedSum number acc =
    // The current term in the series
    let term = pown number number

    // Not at the end of the sequence
    if number <> 1000I then
        reducedSum (number + 1I) (acc + lastTenDigits term)
    else
        (acc + term) |> lastTenDigits

let solve = reducedSum 1I 0I