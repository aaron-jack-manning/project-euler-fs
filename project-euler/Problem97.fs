module Problem97

let solve =
    
    let modulus = 10_000_000_000L

    let mutable power = 1L

    for i = 1 to 7830457 do
        
        power <- power * 2L

        if power >= modulus then
            power <- power % modulus // if division by 0 occurs then it's a multiple of the desired alue

    (power * 28433L + 1L) % modulus