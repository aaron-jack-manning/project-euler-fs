open System

let isPalendrome (n:int):bool =
    let testString = string n

    let rec testPair i : bool =
        if testString.[i] = testString.[testString.Length - 1 - i]
        then
            if i >= testString.Length - 1 then
                true
            else
                testPair (i + 1)
        else
            false


    testPair 0


[<EntryPoint>]
let main argv =

    let mutable largest = 0

    for i = 999 downto 1 do
        for j = 999 downto 1 do
            largest <- if isPalendrome (i * j) && i * j > largest then i * j else largest

    printfn "%i" largest

    0