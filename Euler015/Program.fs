//Starting in the top left corner of a 2x2 grid, 
//and only being able to move to the right and down, there are exactly 6 routes to the bottom right corner.
//How many such routes are there through a 20x20 grid?

//For a square grid, the number of lattices
//is found by the "central binomial coefficient" which is (2n)!/(n!)^2.
//It's called central because it consists of the central numbers in Pascal's triangle.

//Without bigint, we can't get factorial 40 due to value wrapping.
let rec factorial n =
    if n = bigint 1 then n
    else n * (factorial (n - bigint 1))

//137846528820
printfn "%d" (uint64 (factorial (bigint 40) / (factorial (bigint 20) * factorial (bigint 20))))
System.Console.ReadKey() |>ignore