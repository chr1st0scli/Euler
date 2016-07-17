//You are given the following information, but you may prefer to do some research for yourself.

//    1 Jan 1900 was a Monday.
//    Thirty days has September,
//    April, June and November.
//    All the rest have thirty-one,
//    Saving February alone,
//    Which has twenty-eight, rain or shine.
//    And on leap years, twenty-nine.
//    A leap year occurs on any year evenly divisible by 4, but not on a century unless it is divisible by 400.

//How many Sundays fell on the first of the month during the twentieth century (1 Jan 1901 to 31 Dec 2000)?

let febDays year = 
    let cent = year % 1000 = 0
    if cent && year % 400 = 0 || (not cent && year % 4 = 0) then 29
    else 28

let monthlyDays year = [31; febDays year; 31; 30; 31; 30; 31; 31; 30; 31; 30; 31]

//171
printfn "%d"
    ({1900..2000}
    |> Seq.fold (fun acc y -> 
        let rec countSun l currAcc = 
            if List.isEmpty l then currAcc
            else
                let monthDay1 = 
                    match fst currAcc + l.Head % 7 with
                    | x when x > 7 -> x - 7
                    | x -> x
                if monthDay1 = 7 && y >= 1901 then countSun l.Tail (monthDay1, 1 + snd currAcc)
                else countSun l.Tail (monthDay1, snd currAcc)
        countSun (monthlyDays y) acc) (1, 0) //1 is Monday, 0 is the no of Sundays 
    |> snd)
System.Console.ReadKey() |> ignore