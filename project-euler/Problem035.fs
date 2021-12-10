module Problem035

open Microsoft.FSharp.Core.Operators.Checked


// Verifies if a number is prime by trial division
let isprime n =
    let rec check i =
        i * i > n || (n % i <> 0 && check (i + 1))

    if n < 2 then false else (check 2)

// Convert a number to a list of its digits by removing the last digit and prepending it to a list, then reversing the result
let asDigitList number =

    let rec helper number =
        if number = 0 then
            []
        else
            let lastdigit = number % 10
            lastdigit :: helper ((number - lastdigit) / 10)

    helper number
    |> List.rev

// Takes a list of digits and converts them to a number.
let rec recombineToNumber digits =
    digits
    |> List.rev
    |> List.mapi (fun index value -> value * pown 10 index)
    |> List.sum

// Removes the first instance of toRemove from digits, and doesn't change the list if no such element is found
let rec listRemoveFirst digits toRemove =
    match digits with
    | head :: tail ->
        if head = toRemove then
            tail
        else
            head :: (listRemoveFirst tail toRemove)
    | [] -> []

// Generates all primes up to and including limit
let primes limit =
    
    // Sieve of Eratosthenes
    let rec sieve acc numbers max =
        match numbers with
        | x :: xs when x * x > max -> acc @ numbers
        | x :: xs -> sieve (x :: acc) (List.filter (fun a -> a % x <> 0) xs) max
        | [] -> []

    // Avoid testing even numbers (except 2) at the start for efficiency
    let potentialPrimes = 2 :: [3..2..limit]
    sieve [] potentialPrimes limit


// Returns all rotations of a list of digits
let rec rotate previous acc remaining =
    match remaining with
    | x :: xs ->
        rotate (previous @ [x]) ((remaining @ previous) :: acc) xs
    | [] ->
        acc

// Checks if a number is a circular prime
let isCircularPrime = asDigitList >> (rotate [] []) >> (List.map recombineToNumber) >> (List.forall isprime)

let solve =
    let primes = primes 999_999

    primes
    |> List.map isCircularPrime
    |> List.sumBy (fun x -> if x then 1 else 0)
