module Problem9

// Recursive solution
let rec loop (a : int) (b : int) (c : int) (max : int) =
    if a + b + c = max && a * a + b * b = c * c then
        a * b * c
    elif a <> 1 then
        loop (a - 1) b c max
    else
        let newa = max
        
        if b <> 1 then
            loop newa (b - 1) c max
        else
            let newb = max

            if c <> 1 then
                loop newa newb (c - 1) max
            else
                0

let solve = loop 1000 1000 1000 1000

// Solution with loops
// let solve =
    
//     let mutable result = 0

//     for a = 1000 downto 1 do
//         for b = 1000 - a downto 1 do
//             for c = 1000 - (a + b) downto 1 do
//                 if a + b + c = 1000 && a * a + b * b = c * c then
//                     result <- a * b * c

//     result