﻿//The sequence of triangle numbers is generated by adding the natural numbers. So the 7th triangle number would be 1 + 2 + 3 + 4 + 5 + 6 + 7 = 28. The first ten terms would be:
//1, 3, 6, 10, 15, 21, 28, 36, 45, 55, ...
//Let us list the factors of the first seven triangle numbers:
// 1: 1
// 3: 1,3
// 6: 1,2,3,6
//10: 1,2,5,10
//15: 1,3,5,15
//21: 1,3,7,21
//28: 1,2,4,7,14,28
//We can see that 28 is the first triangle number to have over five divisors.
//What is the value of the first triangle number to have over five hundred divisors?

let noOfDivs n =
    let stop = int (System.Math.Sqrt (float n))
    let rec count div acc =
        if div > stop then acc
        elif n % div = 0 then 
            let res = n / div
            count (div + 1) (acc + (if res = div then 1 else 2))
        else count (div + 1) acc
    count 1 0

//76576500
let rec tri n acc =
    if noOfDivs acc > 500 then acc
    else tri (n + 1) (n + acc)
tri 1 0 |> printfn "%d"
System.Console.ReadKey() |> ignore