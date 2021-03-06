﻿//Starting in the top left corner of a 2x2 grid, 
//and only being able to move to the right and down, there are exactly 6 routes to the bottom right corner.
//How many such routes are there through a 20x20 grid?

//For a square grid, the number of lattices
//is found by the "central binomial coefficient" which is (2n)!/(n!)^2.
//It's called central because it consists of the central numbers in Pascal's triangle.

let rec factorial n =
    if n = 1I then n
    else n * factorial (n - 1I)

//137846528820
factorial 40I / (factorial 20I * factorial 20I) |> uint64 |> printfn "%d"
System.Console.ReadKey() |> ignore