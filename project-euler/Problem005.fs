module Problem005

// Attempts to divide number by every integer in the provided list
let rec trialDivision numbers number =
    List.forall (fun x -> number % x = 0) numbers

// Finds the smallest number divisible up to limit, by applying trial dividing each test number by each value from 2 to limit, until a result is found
let smallestDivisibleUpTo limit =
    let testnumbers = [2..limit]

    let rec find current =
        if trialDivision testnumbers current then
            current
        else
            find (current + 1)

    find 2

let solve = smallestDivisibleUpTo 20