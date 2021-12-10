module Problem028

// Generates the gaps between each highlighted number in the spiral
let gaps =
    0 :: [
        for i in [2..2..1000] do
            yield! [i; i; i; i]
    ]

// Generates a new list from numbers, with each value equal to the cummulative sum up to that index in numbers, with the adjustment of starting at 1
let cummulative numbers =

    let rec helper numbers sum acc =
        match numbers with
        | [] -> acc
        | x :: xs -> helper xs (x + sum) (x + sum :: acc)

    helper numbers 1 []

let solve =
    cummulative gaps
    |> List.sum