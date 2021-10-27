let rec iterate number  =
    let lastDigit = number % 10

    if number = lastDigit then
        number * number
    else
        lastDigit * lastDigit + iterate ((number - number % 10)/10)


let rec chain start =

    if start = 1 || start = 89 then
        start
    else
        chain (iterate start)


[<EntryPoint>]
let main argv = 
    let mutable total = 0

    let mutable index = 1

    while index < 10_000_000 do
        total <- total + if chain index = 89 then 1 else 0

        index <- index + 1

    printfn "%i" total

    0