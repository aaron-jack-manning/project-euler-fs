module Problem037

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

// Returns a list the same as the input except without the last element
let removelast list =
    match List.rev list with
    | x :: xs -> List.rev xs
    | [] -> []

// Checks whether a list of digits represents a truncatable prime
let truncatable number =

    let digits = asDigitList number

    // Checks left truncatability
    let rec left digits =
        let prime = isprime (recombineToNumber digits)

        match digits with
        | [] -> true
        | _ :: tail ->
            if prime then
                left tail
            else
                false

    // Checks right truncatability
    let rec right digits =
        let prime = isprime (recombineToNumber digits)

        match digits with
        | [] -> true
        | x ->
            if prime then
                right (digits |> removelast)
            else
                false
        
    left digits && right digits

let solve =

    let mutable truncatablePrimes = List.empty

    // To rule out 2, 3, 5, 7, start at the next prime
    let mutable testing = 11
    while List.length truncatablePrimes < 11 do
        if truncatable testing then
            truncatablePrimes <- testing :: truncatablePrimes
        testing <- testing + 1

    List.sum truncatablePrimes