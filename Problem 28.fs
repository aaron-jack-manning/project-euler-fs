[<EntryPoint>]
let main argv =

    let mutable skip = 2
    let mutable numberOfSkips = 0
    let mutable sum = 0
    let mutable current = 1

    while current <= 1001 * 1001 do

        sum <- sum + current

        current <- current + skip

        if numberOfSkips = 3 then
            skip <- skip + 2
            numberOfSkips <- 0
        else
            numberOfSkips <- numberOfSkips + 1


    printfn "%d" sum


    0