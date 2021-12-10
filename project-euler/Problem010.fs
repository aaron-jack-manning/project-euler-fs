module Problem010

// Generates all primes up to and including limit
let primes limit =
    
    // Sieve of Eratosthenes
    let rec sieve acc numbers max =
        match numbers with
        | x :: xs when x * x > max -> acc @ numbers
        | x :: xs -> sieve (x :: acc) (List.filter (fun a -> a % x <> 0L) xs) max
        | [] -> []

    // Avoid testing even numbers (except 2) at the start for efficiency
    let potentialPrimes = 2L :: [3L..2L..limit]
    sieve [] potentialPrimes limit

let solve =
    primes 2_000_000L
    |> List.sum




    