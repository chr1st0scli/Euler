//2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
//What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?

let isDivisableByAll num (divisors: int[]) = Array.forall (fun div -> num % div = 0) divisors
let divs = [|2..20|]

//It's worth noting that if this is implemented as a tail recursive function, it's 3 times faster.
//232792560
printfn "%d" ({ 1..400000000 } |> Seq.tryFind (fun el -> isDivisableByAll el divs)).Value
System.Console.ReadKey() |>ignore
