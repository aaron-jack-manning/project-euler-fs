module Problem004

// Convert a number to a list of its digits in reverse by removing the last digit and prepending it to a list
let rec asDigitList = function
    | 0 -> []
    | number ->
        let lastdigit = number % 10
        lastdigit :: asDigitList ((number - lastdigit) / 10)

// Checks if a number is palendromic by checking if the reverse of its digit list is the same as the original digit list
let palendromic number =
    let digits = asDigitList number

    digits = List.rev digits

// Generates a list of all palendromic products of 3 digit numbers
let palendromicProducts =
    [
        for i = 999 downto 100 do
            for j = 999 downto 100 do
                if palendromic (i * j) then
                    yield i * j
    ]

let solve =
    palendromicProducts
    |> List.max