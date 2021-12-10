module Problem019

// Number of days in each month for a normal year and leap year respectively
let normalYear = [31; 28; 31; 30; 31; 30; 31; 31; 30; 31; 30; 31]
let leapYear = [31; 29; 31; 30; 31; 30; 31; 31; 30; 31; 30; 31]

// Total number of days in the twentieth century
let totalDays =
    75 * (List.sum normalYear)
    + 25 * (List.sum leapYear)

// Number of days in each month for every month in the 20th century
let daysPerMonth =
    [
        for i = 100 downto 1 do
            yield!
                if i % 4 = 0 then
                    leapYear 
                else
                    normalYear
    ]
    
// Takes a date as the number of days since 1 Jan 1900, and returns what date within its corresponding month it fell on
let rec dayWithinMonth daysEachMonth daysRemaining =
    match daysEachMonth with
    | x :: xs when daysRemaining < x ->
        daysRemaining
    | x :: xs ->
        dayWithinMonth xs (daysRemaining - x)
    | _ -> 0

// For every day since Jan 1, 1970, count by how many are sundays and the first of the month, then deconstruct the list of tuples for the desired value
let sundayCount =
    [1..totalDays]
    |> List.sumBy (
        fun x ->
            if 
                (x % 7 = 6)
                && (dayWithinMonth daysPerMonth x = 0)
            then 1 else 0
    )

let solve = sundayCount
    