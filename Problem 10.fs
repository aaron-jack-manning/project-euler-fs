let isPrime n =
    let rec check i =
        i > n/2 || (n % i <> 0 && check (i + 1))

    check 2

let primeSum max:bigint =
    
    let mutable sum = 0I

    for i = 2 to max do
        sum <- sum + if isPrime i then bigint i else 0I

    sum

[<EntryPoint>]
let main argv =
    let number = 2_000_000

    printfn "%A" (primeSum number)

    0