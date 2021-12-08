module Problem27

let monicQuadraticFunction a b x =
    let quadraticFunction a b c x =
        a * x * x + b * x + c

    quadraticFunction 1 a b x

let isPrime n = 
    let rec check i = 
        i > n/2 || (n % i <> 0 && check (i + 1))
    
    check 2

let solve =

    let mutable maximumInput = 0

    let mutable result = (0, 0)

    for i = -999 to 999 do
        for j = -1000 to 1000 do
            let currentQuadratic = monicQuadraticFunction i j

            let mutable input = 0
        
            while currentQuadratic input > 0 && (currentQuadratic input) |> isPrime do // first case here is significant optimization
                input <- input + 1

            maximumInput <- if input > maximumInput
                            then result <- (i, j); input
                            else maximumInput

    let xCoefficient, constantTerm = result

    xCoefficient * constantTerm