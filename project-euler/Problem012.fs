module Problem012

// Finds the prime factorization of a number as a list of factors, some of which may appear more than once
let primeFactors number =
    let rec helper acc index number =
        if number = 1 then
            acc
        elif number % index = 0 then
            helper (index :: acc) 2 (number / index)
        else
            helper acc (index + 1) number
    
    helper [] 2 number

// Counts the number of divisors of a number
let numberOfFactors number =
    number
    |> primeFactors
    |> List.countBy id
    |> List.map (fun (key, power) -> power + 1)
    |> List.fold (fun s m -> s * m) 1

// Iterates through the triangle numbers in sum, and returns the first triangle number with a number of divisors greater than 500
let rec triangleNumbers index sum =
    let divisors = numberOfFactors sum

    if divisors > 500 then
        sum
    else
        triangleNumbers (index + 1) (sum + index + 1)

let solve = triangleNumbers 1 1