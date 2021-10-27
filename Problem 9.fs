[<EntryPoint>]
let main argv =
    
    let mutable result = 0

    for a = 1000 downto 1 do
        for b = 1000 - a downto 1 do
            for c = 1000 - (a + b) downto 1 do
                if a + b + c = 1000 && a * a + b * b = c * c then
                    result <- a * b * c

    
    printfn "%i" result
    
    0