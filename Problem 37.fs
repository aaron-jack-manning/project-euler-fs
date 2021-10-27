let isPrime n =
    let rec check k  =
        k > n/2 || (n % k <> 0 && check (k + 1))

    if n = 1 then false else check 2

let rec decomposeToDigits number =
    match number with
    | 0 -> []
    | _ ->
        let lastDigit = number % 10
        List.append (decomposeToDigits ((number - lastDigit) / 10)) [lastDigit]


let rec isTruncatablePrime number direction =

    if number % 10 = number then
        isPrime number  
    elif not (isPrime number) then
        false
    else
        let numberString = string number

        let leftTruncatedNumberString = numberString.[1..]
        let rightTruncatedNumberString = numberString.[0..(String.length numberString - 2)]

        if direction = "left" then
            isTruncatablePrime (int numberString.[1..]) direction
        elif direction = "right" then
            isTruncatablePrime (int numberString.[0..(String.length numberString - 2)]) direction
        else
            failwith "Direction must be left or right."

[<EntryPoint>]
let main argv =
    
    let truncatablePrimes = Array.zeroCreate 11

    let mutable primecount = 0
    let mutable testing = 11
    while truncatablePrimes.[10] = 0 do
        if isTruncatablePrime testing "left" && isTruncatablePrime testing "right" then
            truncatablePrimes.[primecount] <- testing
            primecount <- primecount + 1
        
        testing <- testing + 1

    printfn "%d" (Array.sum truncatablePrimes)

    0