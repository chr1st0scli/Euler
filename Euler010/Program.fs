//The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.
//Find the sum of all the primes below two million.
let eratosthOpt n = //Eratosthenes' optimized sieve
    let arr = Array.create (n + 1) true
    arr.[0] <- false
    arr.[1] <- false
    let rec f i z =
        if i > int(System.Math.Sqrt (float n)) then arr
        elif arr.[i] = false then f (i + 1) 0
        else
            let j = i * i + z * i
            if j > n then f (i + 1) 0
            else
                arr.[j] <- false
                f i (z + 1)
    f 2 0

//142913828922
eratosthOpt 2000000
|> Array.mapi (fun i el -> if el then uint64(i) else 0UL)
|> Array.sum
|> printfn "%d"
System.Console.ReadKey() |> ignore
