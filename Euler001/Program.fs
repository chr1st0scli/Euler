//Add all the natural numbers below one thousand that are multiples of 3 or 5.

//Method 1. Increasing the stack frame.
let rec f1 n =
    if n >= 1000 then
        0
    elif n % 3 = 0 || n % 5 = 0 then
        n + f1 (n + 1)
    else
        f1 (n + 1)

//Method 2. Tail recursion, using an accumulator.
let rec f2 n acc = 
    if n >= 1000 then
        acc
    else if n % 3 = 0 || n % 5 = 0 then 
        f2 (n + 1) (acc + n)
    else 
        f2 (n + 1) acc

//Method 3. Using libraries.
let f3 = 
    [1..999] 
    |> List.filter (fun el -> el % 3 = 0 || el % 5 = 0) 
    |> List.reduce (+)

//233168
printfn "%d %d %d" (f1 1) (f2 1 0) f3
System.Console.ReadKey() |>ignore