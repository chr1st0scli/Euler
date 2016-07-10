//2^15 = 32768 and the sum of its digits is 3 + 2 + 7 + 6 + 8 = 26.
//What is the sum of the digits of the number 2^1000?

//1366
printfn "%d" ((bigint (2.0 ** 1000.0)).ToString() |> Seq.map string |> Seq.map int |> Seq.reduce (+))
System.Console.ReadKey() |>ignore