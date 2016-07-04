//By considering the terms in the Fibonacci sequence whose values do not exceed four million, find the sum of the even-valued terms.
let rec fib n1 n2 acc =
    if n2 >= 4000000 then
        if n2 % 2 = 0 then acc + n2
        else acc
    elif n2 % 2 = 0 then fib n2 (n1 + n2) (acc + n2)
    else fib n2 (n1 + n2) acc

//4613732
printfn "%d" (fib 0 1 0)
System.Console.ReadKey() |>ignore