//The sum of the squares of the first ten natural numbers is,
//12 + 22 + ... + 102 = 385
//The square of the sum of the first ten natural numbers is,
//(1 + 2 + ... + 10)2 = 552 = 3025
//Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 3025  385 = 2640.
//Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.

let sumOfSquares nums = Array.fold (fun acc el -> el * el + acc) 0 nums
let squareOfSums nums = 
    let sum = Array.reduce (+) nums
    sum * sum
let nums = [|1..100|]
//25164150
printfn "%d" (squareOfSums nums - sumOfSquares nums)
System.Console.ReadKey() |>ignore