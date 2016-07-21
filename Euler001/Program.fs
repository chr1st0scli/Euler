//Add all the natural numbers below one thousand that are multiples of 3 or 5.

//This is the only problem solved in different ways for educational purposes.
let mult3Or5 n = n % 3 = 0 || n % 5 = 0

//Method 1. Increasing the stack frame.
let rec f1 n =
    if n >= 1000 then 0
    elif mult3Or5 n then n + f1 (n + 1)
    else f1 (n + 1)

//Method 2. Tail recursion, using an accumulator.
let rec f2 n acc = 
    if n >= 1000 then acc
    elif mult3Or5 n then f2 (n + 1) (acc + n)
    else f2 (n + 1) acc

//Method 3. Continuation passing style.
let rec f3 n f =
    if n >= 1000 then f 0
    elif mult3Or5 n then f3 (n + 1) (fun x -> f (n + x))
    else f3 (n + 1) f

//Method 4. Using libraries.
let f4 = 
    [1..999] 
    |> List.filter mult3Or5 
    |> List.reduce (+)

//233168
printfn "%d %d %d %d" (f1 1) (f2 1 0) (f3 1 id) f4
System.Console.ReadKey() |> ignore