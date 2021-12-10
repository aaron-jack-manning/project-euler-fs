module Problem020

// Computes the factorial of a bigint // acc should start as 1
let rec factorial acc number =
    if number = 0I then
        acc
    else
        factorial (acc * number) (number - 1I)

// Calculates the sum of digits of a bigint // acc should start as 1
let rec digitSum acc number =
    let lastDigit = number % 10I

    if number = 0I then
        acc
    else
        digitSum (lastDigit + acc) ((number - lastDigit) / 10I)
    
let solve =
    factorial 1I 100I
    |> digitSum 0I