let normalYear = [31; 28; 31; 30; 31; 30; 31; 31; 30; 31; 30; 31]
let leapYear = [31; 29; 31; 30; 31; 30; 31; 31; 30; 31; 30; 31]


let totalDays = 75 * (normalYear |> List.sum) + 25 * (leapYear |> List.sum)

let monthDays =

    let mutable fullList = List.empty

    for i = 1 to 100 do
        fullList <- fullList |> List.append (if i % 4 = 0 then leapYear else normalYear)

    fullList

let dayInMonth day =
    
    let mutable sum = 0

    let result = seq {for value in monthDays do
                        sum <- sum + value

                        if sum > day then
                            yield! [day - (sum - value)] else
                                if sum = day then
                                    yield! [0]
                                else
                                    yield! []}

    (result |> Seq.toList).[0]


[<EntryPoint>]
let main argv =
    
    let mutable sum = 0

    for i = 1 to totalDays do
        if i % 7 = 6 && (dayInMonth i) = 0 then
            sum <- sum + 1
    
    printfn "%i" sum

    0