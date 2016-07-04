//2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
//What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?

let isDivisableByAll num (divisors: int[]) = Array.forall (fun div -> num % div = 0) divisors
let divs = [|1..20|]
let answer = { 1..400000000 } 
            |> Seq.tryFind (fun el -> isDivisableByAll el divs)

//232792560
printfn "%d" answer.Value
System.Console.ReadKey() |>ignore

(*
//Method 2, tail recursion is 3 times faster.
let minNumDividedBy (divisors: int[]) =  
    let rec minNumDividedByAll stopAt acc = 
        if acc >= stopAt then 0
        else if isDivisableByAll acc divisors then acc
        else minNumDividedByAll stopAt (acc + 1)
    minNumDividedByAll 400000000 1
*)
