let last10Digits number =
    number % (10000000000I)

let bigPower a b =
    let rec computePower a b result =
        if b = 0I then
            result
        else
            computePower a (b - 1I) (a * result)

    computePower a b 1I

let rec calculateReducedSum number =

    let term = bigPower number number

    if number = 1000I then
        term |> last10Digits
    else
        (term |> last10Digits) + calculateReducedSum (number + 1I)

[<EntryPoint>]
let main argv =
    
    printfn "%A" (calculateReducedSum 1I |> last10Digits)

    0