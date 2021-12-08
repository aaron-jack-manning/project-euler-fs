module Problem20

let rec factorial (n:bigint):bigint = if n = 0I then 1I else n * factorial (n - 1I)

let rec digitSum (n:bigint):bigint =
    
    let lastDigit = n % 10I

    if n = 0I then 0I else lastDigit + (digitSum ((n - lastDigit)/10I))
    
let solve = digitSum (factorial 100I)