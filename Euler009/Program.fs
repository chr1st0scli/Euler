//A Pythagorean triplet is a set of three natural numbers, a  b  c, for which,
//a^2 + b^2 = c^2
//For example, 3^2 + 4^2 = 9 + 16 = 25 = 5^2.
//There exists exactly one Pythagorean triplet for which a + b + c = 1000.
//Find the product abc.

//It's enough to find two numbers b and c for which the below is true
let bcFound (b, c) = b * b + b * c - 1000 * b - 1000 * c + 500000 = 0

let bc = seq {
    for b in 1..500 do
        for c in 1..500 do
            yield (b, c) 
            } |> Seq.tryFind bcFound 

//31875000
printfn "%d" ((1000 - fst bc.Value - snd bc.Value) * fst bc.Value * snd bc.Value)
System.Console.ReadKey() |> ignore