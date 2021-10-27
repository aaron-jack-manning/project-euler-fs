[<EntryPoint>]
let main argv =

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

    printfn "%i" (List.sum (List.where (fun x -> x % 2 = 0) list))

    0