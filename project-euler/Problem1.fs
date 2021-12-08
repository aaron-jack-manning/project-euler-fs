module Problem1

let rec loop acc index =
    if index = 0 then
        acc
    elif index % 3 = 0 || index % 5 = 0 then
        loop (index + acc) (index - 1)
    else
        loop acc (index - 1)

let solve = loop 0 999