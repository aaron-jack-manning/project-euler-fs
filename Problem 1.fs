let divisible n k = n % k = 0

[<EntryPoint>]
let main argv =
    let mutable total = 0
    for i = 1 to 999 do
        total <- total + if divisible i 3 || divisible i 5 then i else 0

    printfn "%i" total
    0