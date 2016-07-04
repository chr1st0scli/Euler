//A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 99.
//Find the largest palindrome made from the product of two 3-digit numbers.

let isPalindrome num = 
    let list = List.ofSeq (num.ToString())
    list = List.rev list

let answer = seq {
    for x in 100..999 do
        for y in 100..999 do
            let prod = x * y
            if isPalindrome prod then yield prod
                } |> Seq.max

//906609
printfn "%d" answer
System.Console.ReadKey() |>ignore