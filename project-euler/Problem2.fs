module Problem2



let solve =

    let mutable first = 1
    let mutable second = 2

    let mutable third = first + second
    
    let list = [
        while third < 4_000_000 do
            third <- first + second

            yield third

            first <- second
            second <- third
    ]

    list
    |> List.where (fun x -> x % 2 = 0)
    |> List.sum