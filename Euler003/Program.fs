//The prime factors of 13195 are 5, 7, 13 and 29.
//What is the largest prime factor of the number 600851475143?
let isPrime num =
    if num = 1UL then false
    elif num = 2UL then true
    else { 2UL..num - 1UL } |> Seq.forall (fun el -> num % el <> 0UL)

let maxPrimeFactorOf num = 
    let rec findMaxPrimeFactor num primeFact = 
        if isPrime primeFact && num % primeFact = 0UL then
            let res = num / primeFact
            printfn "%d / %d = %d" num primeFact res
            if isPrime res then res
            else findMaxPrimeFactor res 2UL
        else findMaxPrimeFactor num (primeFact + 1UL)
    findMaxPrimeFactor num 1UL
 
//6857
printfn "%d" (maxPrimeFactorOf 600851475143UL)
System.Console.ReadKey() |> ignore
