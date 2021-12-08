module Problem10

let isPrime n =
    let rec check i =
        i > n/2 || (n % i <> 0 && check (i + 1))

    check 2

let primeSum max:bigint =
    
    let mutable sum = 0I

    for i = 2 to max do
        sum <- sum + if isPrime i then bigint i else 0I

    sum

let solve =
    let number = 2_000_000

    primeSum number