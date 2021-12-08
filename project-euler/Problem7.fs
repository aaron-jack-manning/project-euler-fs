module Problem7

let isPrime n =
    let rec check i =
        i > (n/2) || (n % i <> 0 && check (i + 1))

    check 2

let rec nextPrime n =
    
    if isPrime (n + 1) then
        n + 1
    else
        nextPrime (n + 1)

let solve =

    let mutable counter = 0

    let mutable prime = 1

    while counter < 10001 do
        prime <- nextPrime prime

        counter <- counter + 1
        
    prime