module Problem008

// The input number as a list of its digits
// The convertion from array to list is to get around the limit on list literal lengths
let inputNumber =
    Array.toList
        [|
            7L; 3L; 1L; 6L; 7L; 1L; 7L; 6L; 5L; 3L;
            1L; 3L; 3L; 0L; 6L; 2L; 4L; 9L; 1L; 9L;
            2L; 2L; 5L; 1L; 1L; 9L; 6L; 7L; 4L; 4L;
            2L; 6L; 5L; 7L; 4L; 7L; 4L; 2L; 3L; 5L; 
            5L; 3L; 4L; 9L; 1L; 9L; 4L; 9L; 3L; 4L;
            9L; 6L; 9L; 8L; 3L; 5L; 2L; 0L; 3L; 1L;
            2L; 7L; 7L; 4L; 5L; 0L; 6L; 3L; 2L; 6L;
            2L; 3L; 9L; 5L; 7L; 8L; 3L; 1L; 8L; 0L;
            1L; 6L; 9L; 8L; 4L; 8L; 0L; 1L; 8L; 6L;
            9L; 4L; 7L; 8L; 8L; 5L; 1L; 8L; 4L; 3L; 
            8L; 5L; 8L; 6L; 1L; 5L; 6L; 0L; 7L; 8L; 
            9L; 1L; 1L; 2L; 9L; 4L; 9L; 4L; 9L; 5L; 
            4L; 5L; 9L; 5L; 0L; 1L; 7L; 3L; 7L; 9L;
            5L; 8L; 3L; 3L; 1L; 9L; 5L; 2L; 8L; 5L;
            3L; 2L; 0L; 8L; 8L; 0L; 5L; 5L; 1L; 1L;
            1L; 2L; 5L; 4L; 0L; 6L; 9L; 8L; 7L; 4L;
            7L; 1L; 5L; 8L; 5L; 2L; 3L; 8L; 6L; 3L;
            0L; 5L; 0L; 7L; 1L; 5L; 6L; 9L; 3L; 2L;
            9L; 0L; 9L; 6L; 3L; 2L; 9L; 5L; 2L; 2L;
            7L; 4L; 4L; 3L; 0L; 4L; 3L; 5L; 5L; 7L;
            6L; 6L; 8L; 9L; 6L; 6L; 4L; 8L; 9L; 5L;
            0L; 4L; 4L; 5L; 2L; 4L; 4L; 5L; 2L; 3L;
            1L; 6L; 1L; 7L; 3L; 1L; 8L; 5L; 6L; 4L;
            0L; 3L; 0L; 9L; 8L; 7L; 1L; 1L; 1L; 2L;
            1L; 7L; 2L; 2L; 3L; 8L; 3L; 1L; 1L; 3L;
            6L; 2L; 2L; 2L; 9L; 8L; 9L; 3L; 4L; 2L;
            3L; 3L; 8L; 0L; 3L; 0L; 8L; 1L; 3L; 5L;
            3L; 3L; 6L; 2L; 7L; 6L; 6L; 1L; 4L; 2L;
            8L; 2L; 8L; 0L; 6L; 4L; 4L; 4L; 4L; 8L;
            6L; 6L; 4L; 5L; 2L; 3L; 8L; 7L; 4L; 9L;
            3L; 0L; 3L; 5L; 8L; 9L; 0L; 7L; 2L; 9L;
            6L; 2L; 9L; 0L; 4L; 9L; 1L; 5L; 6L; 0L;
            4L; 4L; 0L; 7L; 7L; 2L; 3L; 9L; 0L; 7L;
            1L; 3L; 8L; 1L; 0L; 5L; 1L; 5L; 8L; 5L;
            9L; 3L; 0L; 7L; 9L; 6L; 0L; 8L; 6L; 6L;
            7L; 0L; 1L; 7L; 2L; 4L; 2L; 7L; 1L; 2L;
            1L; 8L; 8L; 3L; 9L; 9L; 8L; 7L; 9L; 7L;
            9L; 0L; 8L; 7L; 9L; 2L; 2L; 7L; 4L; 9L;
            2L; 1L; 9L; 0L; 1L; 6L; 9L; 9L; 7L; 2L;
            0L; 8L; 8L; 8L; 0L; 9L; 3L; 7L; 7L; 6L;
            6L; 5L; 7L; 2L; 7L; 3L; 3L; 3L; 0L; 0L;
            1L; 0L; 5L; 3L; 3L; 6L; 7L; 8L; 8L; 1L;
            2L; 2L; 0L; 2L; 3L; 5L; 4L; 2L; 1L; 8L;
            0L; 9L; 7L; 5L; 1L; 2L; 5L; 4L; 5L; 4L;
            0L; 5L; 9L; 4L; 7L; 5L; 2L; 2L; 4L; 3L;
            5L; 2L; 5L; 8L; 4L; 9L; 0L; 7L; 7L; 1L;
            1L; 6L; 7L; 0L; 5L; 5L; 6L; 0L; 1L; 3L;
            6L; 0L; 4L; 8L; 3L; 9L; 5L; 8L; 6L; 4L;
            4L; 6L; 7L; 0L; 6L; 3L; 2L; 4L; 4L; 1L;
            5L; 7L; 2L; 2L; 1L; 5L; 5L; 3L; 9L; 7L;
            5L; 3L; 6L; 9L; 7L; 8L; 1L; 7L; 9L; 7L;
            7L; 8L; 4L; 6L; 1L; 7L; 4L; 0L; 6L; 4L;
            9L; 5L; 5L; 1L; 4L; 9L; 2L; 9L; 0L; 8L;
            6L; 2L; 5L; 6L; 9L; 3L; 2L; 1L; 9L; 7L;
            8L; 4L; 6L; 8L; 6L; 2L; 2L; 4L; 8L; 2L;
            8L; 3L; 9L; 7L; 2L; 2L; 4L; 1L; 3L; 7L;
            5L; 6L; 5L; 7L; 0L; 5L; 6L; 0L; 5L; 7L;
            4L; 9L; 0L; 2L; 6L; 1L; 4L; 0L; 7L; 9L;
            7L; 2L; 9L; 6L; 8L; 6L; 5L; 2L; 4L; 1L;
            4L; 5L; 3L; 5L; 1L; 0L; 0L; 4L; 7L; 4L;
            8L; 2L; 1L; 6L; 6L; 3L; 7L; 0L; 4L; 8L;
            4L; 4L; 0L; 3L; 1L; 9L; 9L; 8L; 9L; 0L;
            0L; 0L; 8L; 8L; 9L; 5L; 2L; 4L; 3L; 4L;
            5L; 0L; 6L; 5L; 8L; 5L; 4L; 1L; 2L; 2L;
            7L; 5L; 8L; 8L; 6L; 6L; 6L; 8L; 8L; 1L;
            1L; 6L; 4L; 2L; 7L; 1L; 7L; 1L; 4L; 7L;
            9L; 9L; 2L; 4L; 4L; 4L; 2L; 9L; 2L; 8L;
            2L; 3L; 0L; 8L; 6L; 3L; 4L; 6L; 5L; 6L;
            7L; 4L; 8L; 1L; 3L; 9L; 1L; 9L; 1L; 2L;
            3L; 1L; 6L; 2L; 8L; 2L; 4L; 5L; 8L; 6L;
            1L; 7L; 8L; 6L; 6L; 4L; 5L; 8L; 3L; 5L;
            9L; 1L; 2L; 4L; 5L; 6L; 6L; 5L; 2L; 9L;
            4L; 7L; 6L; 5L; 4L; 5L; 6L; 8L; 2L; 8L;
            4L; 8L; 9L; 1L; 2L; 8L; 8L; 3L; 1L; 4L;
            2L; 6L; 0L; 7L; 6L; 9L; 0L; 0L; 4L; 2L;
            2L; 4L; 2L; 1L; 9L; 0L; 2L; 2L; 6L; 7L;
            1L; 0L; 5L; 5L; 6L; 2L; 6L; 3L; 2L; 1L;
            1L; 1L; 1L; 1L; 0L; 9L; 3L; 7L; 0L; 5L;
            4L; 4L; 2L; 1L; 7L; 5L; 0L; 6L; 9L; 4L;
            1L; 6L; 5L; 8L; 9L; 6L; 0L; 4L; 0L; 8L;
            0L; 7L; 1L; 9L; 8L; 4L; 0L; 3L; 8L; 5L;
            0L; 9L; 6L; 2L; 4L; 5L; 5L; 4L; 4L; 4L;
            3L; 6L; 2L; 9L; 8L; 1L; 2L; 3L; 0L; 9L;
            8L; 7L; 8L; 7L; 9L; 9L; 2L; 7L; 2L; 4L;
            4L; 2L; 8L; 4L; 9L; 0L; 9L; 1L; 8L; 8L;
            8L; 4L; 5L; 8L; 0L; 1L; 5L; 6L; 1L; 6L;
            6L; 0L; 9L; 7L; 9L; 1L; 9L; 1L; 3L; 3L;
            8L; 7L; 5L; 4L; 9L; 9L; 2L; 0L; 0L; 5L;
            2L; 4L; 0L; 6L; 3L; 6L; 8L; 9L; 9L; 1L;
            2L; 5L; 6L; 0L; 7L; 1L; 7L; 6L; 0L; 6L;
            0L; 5L; 8L; 8L; 6L; 1L; 1L; 6L; 4L; 6L;
            7L; 1L; 0L; 9L; 4L; 0L; 5L; 0L; 7L; 7L;
            5L; 4L; 1L; 0L; 0L; 2L; 2L; 5L; 6L; 9L;
            8L; 3L; 1L; 5L; 5L; 2L; 0L; 0L; 0L; 5L;
            5L; 9L; 3L; 5L; 7L; 2L; 9L; 7L; 2L; 5L;
            7L; 1L; 6L; 3L; 6L; 2L; 6L; 9L; 5L; 6L;
            1L; 8L; 8L; 2L; 6L; 7L; 0L; 4L; 2L; 8L;
            2L; 5L; 2L; 4L; 8L; 3L; 6L; 0L; 0L; 8L;
            2L; 3L; 2L; 5L; 7L; 5L; 3L; 0L; 4L; 2L;
            0L; 7L; 5L; 2L; 9L; 6L; 3L; 4L; 5L; 0L
        |]

// Returns a list the same as the input except without the last element
let removelast list =
    match List.rev list with
    | x :: xs -> List.rev xs
    | [] -> []

// Finds the greatest product of 13 consecutive digits by passing around the current thirteen, appending to the front and removing from the back in each call, and updating greatest in each recursive call depending on if the sum of the current thirteen digits was greater
let rec greatestProduct greatest thirteen remaining =
    match remaining with
    | x :: xs ->
        // For cases at the start when the list of thirteen digits is first being constructed
        if List.length thirteen < 13 then
            greatestProduct greatest (x :: thirteen) xs
        else
            let thirteenProduct = List.fold (fun s x -> s * x) 1L thirteen
            let newGreatest = if thirteenProduct > greatest then thirteenProduct else greatest 

            // Passes the new greatest (which may have been the same as previous) into the next recursive call, along with the list of the previous thirteen digits, minus the last one, plus the new next one
            greatestProduct newGreatest (x :: (removelast thirteen)) xs
    | [] -> greatest

let solve =
    greatestProduct 0L [] inputNumber