//By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
//What is the 10 001st prime number?
let isPrime num = 
    let rec isPrimeFn nextDiv = 
        if nextDiv > num || num = 1 then false
        else if nextDiv = num then true
        else if nextDiv < num && nextDiv > 1 && num % nextDiv = 0 then false
        else isPrimeFn (nextDiv + 1)
    isPrimeFn 2

//104743
Seq.initInfinite (fun i -> i + 1) 
|> Seq.where isPrime 
|> Seq.item 10000
|> printfn "%d"
System.Console.ReadKey() |> ignore
