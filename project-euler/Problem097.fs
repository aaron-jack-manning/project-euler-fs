module Problem097

// Calculates a to the power of b, reduced mod modulus
let reducedPower a b modulus =
    
    let rec helper a b acc modulus =
        if b = 0I then
            acc
        else
            helper a (b - 1I) ((a * acc) % modulus) modulus

    helper a b 1I modulus

// Solving this problem is very easy in a language with arbitrarily large (or just very big) integers
let solve =
    (28433I * reducedPower 2I 7_830_457I 10_000_000_000I + 1I) % 10_000_000_000I