module Problem52

let checkSameDigits number1 number2 =

    let rec decomposeToDigits number =
        match number with
        | 0 -> []
        | _ ->
            let lastDigit = number % 10
            List.append (decomposeToDigits ((number - lastDigit) / 10)) [lastDigit]
    
    (number1
    |> decomposeToDigits
    |> List.sort,
    number2
    |> decomposeToDigits
    |> List.sort)
    ||> (=)

let rec check number =
    let conditionsSatisfied =
        [
            for i = 2 to 6 do
                yield checkSameDigits number (number * i)
        ]
        |> List.fold (fun state value -> state && value) true

    match conditionsSatisfied with
    | true -> number
    | false ->
        check (number + 1)


let solve = check 2