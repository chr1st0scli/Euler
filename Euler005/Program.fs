//2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
//What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?

let divs = [|2..20|]
let divisibleByAll num = Array.forall (fun div -> num % div = 0) divs
let work = 
    Async.Parallel [    //Split the set 1 to 400000000 into chunks to search in parallel.
        let cnt = 400000000 / System.Environment.ProcessorCount
        for i in 0..System.Environment.ProcessorCount - 1 ->
            async { return seq {i * cnt + 1..(i + 1) * cnt} |> Seq.tryFind divisibleByAll }]

//232792560
printfn "%d" (work |> Async.RunSynchronously |> Array.find Option.isSome).Value
System.Console.ReadKey() |> ignore