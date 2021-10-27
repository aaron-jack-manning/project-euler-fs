let lowestPrimeFactor (input:int64):int64 =
    let mutable index = 2L

    while input % index <> 0L do
        index <- index + 1L

    index

[<EntryPoint>]
let main argv =
    
    let mutable current = 600_851_475_143L

    let mutable largestPrimeFactor = 0L

    while current <> 1L do

        let currentLowestPrimeFactor = lowestPrimeFactor current

        largestPrimeFactor <- if currentLowestPrimeFactor > largestPrimeFactor then currentLowestPrimeFactor else largestPrimeFactor

        current <- current / (currentLowestPrimeFactor)


    printfn "%i" largestPrimeFactor

    0