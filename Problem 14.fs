let collatz (n:int64) :int64 = if n % 2L = 0L then n/2L else 3L*n + 1L

let rec collatzSequenceLength (number:int64) :int =
    if number = 1L then
        0
    else
        1 + collatzSequenceLength (collatz number)

let longestCollatzChainStart max =

    let mutable length = 0

    let mutable startingValue = 0

    for i = max downto 1 do

        let chainLength = collatzSequenceLength (int64 i)
        length <- if chainLength > length then
                        startingValue <- i
                        chainLength
                    else
                        length
    startingValue

[<EntryPoint>]
let main argv =

    printfn "%i" (longestCollatzChainStart 999_999)

    0