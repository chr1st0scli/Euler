//If the numbers 1 to 5 are written out in words: one, two, three, four, five, then there are 3 + 3 + 5 + 4 + 4 = 19 letters used in total.
//If all the numbers from 1 to 1000 (one thousand) inclusive were written out in words, how many letters would be used?
//NOTE: Do not count spaces or hyphens. For example, 342 (three hundred and forty-two) contains 23 letters and 115 (one hundred and fifteen) contains 20 letters. The use of "and" when writing out numbers is in compliance with British usage.

let oneTo9 = ["one"; "two"; "three"; "four"; "five"; "six"; "seven"; "eight"; "nine"]
let tenTo19 = ["ten"; "eleven"; "twelve"; "thirteen"; "fourteen"; "fifteen"; "sixteen"; "seventeen"; "eighteen"; "nineteen"]
let mult10 = ["twenty"; "thirty"; "forty"; "fifty"; "sixty"; "seventy"; "eighty"; "ninety"]

let oneTo99 = oneTo9 @ tenTo19 @ [for x in mult10 do for y in oneTo9 -> x + " " + y] @ mult10
let mult100 = oneTo9 |> List.map (fun i -> i + " hundred")
let hndrN1To999 = [for x in mult100 do for y in oneTo99 -> x + " and " + y]

//21124
printfn "%d" 
    ("one thousand" :: oneTo99 @ mult100 @ hndrN1To999
    |> List.map (fun str -> str.Replace(" ", "").Length)
    |> List.reduce (+))
System.Console.ReadKey() |> ignore