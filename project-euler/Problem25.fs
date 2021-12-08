module Problem25

let solve =

    let mutable first = 1I
    let mutable second = 1I
    let mutable third = 0I

    let mutable index = 2

    while String.length (string third) <> 1000 do
        
        third <- first + second

        first <- second
        second <- third

        index <- index + 1

    index