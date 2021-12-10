module Problem092

// Represents one iteration of a number by the process of adding the sum of squares of the digits
let rec iterate number  =
    let lastDigit = number % 10
    let remaining = (number - lastDigit) / 10

    match number with
    | x when x = lastDigit -> number * number
    | _ -> lastDigit * lastDigit + iterate remaining

// Chains the iterate function repeatedly and returns 1 or 89 depending on where it finished
let rec chain start =
    if start = 1 || start = 89 then
        start
    else
        chain (iterate start)

let solve =
    [1..10_000_000]
    |> List.sumBy (fun x -> if chain x = 89 then 1 else 0)