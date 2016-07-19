//The following iterative sequence is defined for the set of positive integers:
//n → n/2 (n is even)
//n → 3n + 1 (n is odd)
//Using the rule above and starting with 13, we generate the following sequence:
//13 → 40 → 20 → 10 → 5 → 16 → 8 → 4 → 2 → 1
//It can be seen that this sequence (starting at 13 and finishing at 1) contains 10 terms. Although it has not been proved yet (Collatz Problem), it is thought that all starting numbers finish at 1.
//Which starting number, under one million, produces the longest chain?
//NOTE: Once the chain starts the terms are allowed to go above one million.

//If unsigned long wasn't used for n, we would get wrap around effects.
let (|Odd|Even|) n = if n % 2UL = 0UL then Even else Odd
//If this wasn't tail recursive, we would get StackOverflowException trying to get the answer.
let countCollatz n =
    let rec countCollatz n cnt =
        match n with
        | 1UL -> cnt
        | Odd -> countCollatz (n * 3UL + 1UL) (cnt + 1)
        | Even -> countCollatz (n / 2UL) (cnt + 1)
    countCollatz n 1

//837799
{1000000..-1..500000}
|> Seq.map (fun i -> (i, countCollatz (uint64 i)))
|> Seq.maxBy (fun t -> snd t)
|> fst
|> printfn "%d"
System.Console.ReadKey() |> ignore