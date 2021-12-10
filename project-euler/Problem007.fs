module Problem007

// Verifies if a number is prime by trial division
let isprime n =
    let rec check i =
        i * i > n || (n % i <> 0 && check (i + 1))

    if n < 2 then false else (check 2)

// Finds the nth prime by checking each number, and incrementing primecount on recursive calls where the current number is prime
let rec nthprime n primecount current =
    if isprime current then
        if primecount = n then
            current
        else
            nthprime n (primecount + 1) (current + 1)
    else
        nthprime n primecount (current + 1)

let solve = nthprime 10_001 1 2