let rec factorial (n:bigint):bigint =
    if n = 0I then
        1I
    else
        n * factorial (n - 1I)

let binom n k =
    (factorial n) / ((factorial k) * (factorial (n - k)))

let countBinom =

    let mutable total = 0

    for n = 100 downto 1 do
        for k = n downto 1 do
            if binom (bigint n) (bigint k) > 1_000_000I then
                total <- total + 1

    total

[<EntryPoint>]
let main argv =
    
    printfn "%i" countBinom

    0