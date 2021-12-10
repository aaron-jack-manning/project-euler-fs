module Problem052

// Convert a number to a list of its digits in reverse by removing the last digit and prepending it to a list
let rec asDigitList = function
    | 0 -> []
    | x ->
        let lastdigit = x % 10
        lastdigit :: asDigitList ((x - lastdigit) / 10)

// Converts a number into a sorted list of its digits
let sortDigits = asDigitList >> List.sort

// Checks if all lists within a list are equivalent
let rec allListsEqual = function
    | a :: b :: tail -> a = b && allListsEqual tail
    | _ -> true

// Checks if a number and all multiples up to six have the same digits
let conditionsSatisfied number =
    [
        for i = 1 to 6 do
            (i * number) |> sortDigits
    ]
    |> allListsEqual

// Recursively checks each number for if it satisfies the required conditions, increasing by one at each call
let rec check number =
    if conditionsSatisfied number then
        number
    else
        check (number + 1)

let solve = check 2