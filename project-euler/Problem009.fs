module Problem009

// Generates all possible sets of 3 digits which sum to 1000
let sets = [
    for a = 1000 downto 1 do
        for b = 1000 - a downto 1 do
            let c = 1000 - (a + b)
            yield (a, b, c)
]

// Checks each set for the required condition
let rec check = function
    | (a, b, c) :: _ when a * a + b * b = c * c ->
        a * b * c
    | _ :: remaining ->
        check remaining
    | [] ->
        failwith "no set of values satisfying the condition was found"

let solve = check sets