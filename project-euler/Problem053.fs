module Problem053

// Calculates the factorial of a bigint
let rec factorial n =
    if n = 0I then
        1I
    else
        n * factorial (n - 1I)

// Binomial Coefficient
let binom n k =
    factorial n / (factorial k * factorial (n - k))

let solve =
    // This list is a list of true/false values depending on if the binomial coefficient was greater than one million, to then be summed by true -> 1 and false -> 0
    [
        for n = 100 downto 1 do
            for k = n downto 1 do
                binom (bigint n) (bigint k) > 1_000_000I
    ]
    |> List.sumBy (fun x -> if x then 1 else 0)

