module Problem027

// Monic quadratic function, taking in the two coefficients and value at which to evaluate it
let monicQuadratic b c x =
    x * x + b * x + c 

// Verifies if a number is prime by trial division
let isprime n =
    let rec check i =
        i * i > n || (n % i <> 0 && check (i + 1))

    if n < 2 then false else (check 2)

// Counts how many consectutive inputs to the quadtratic give a prime, starting at 0
let numberOfPrimes quadtratic =

    let rec helper (quadtratic : int -> int) count current =
        match quadtratic current with
        | x when isprime x -> helper quadtratic (count + 1) (current + 1)
        | _ -> count

    helper quadtratic 0 0

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

// Returns the coefficients of the quadtratic which produces the most consecutive primes
let coefficients =
    let primes = primes 1000

    let a, b, _ =
        [
        for a = -999 to 999 do
            // Narrow the search for b using only primes up to 1000, since for n = 0, the quadtratic is equal to b
            for b in primes do
                let currentQuadratic = monicQuadratic a b

                (a, b, numberOfPrimes currentQuadratic)
        ]
        |> List.maxBy (fun (_, _, n) -> n)

    (a, b)

let solve =
    let a, b = coefficients
    a * b

    