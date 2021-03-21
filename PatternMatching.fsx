open System

module PatternMatching =
    let getSeason (month : string) : string =
        match month with
        | "January" -> "Winter"
        | "April" -> "Spring"
        | "September" -> "Fall"
        | "June" -> "Summer"
        | _ -> "Not Defined"

    let mnth = getSeason "January"
    // printfn $"{mnth}"

    let getRate = function
    | "rice" -> 60.0
    | "potato" -> 20.0
    | _ -> nan

    // printfn "%g" (getRate "rice")
    // printfn "%g" (getRate "lentils")

    // matching with tuple
    // let sign = function
    //     | 0 -> 0
    //     | x when x < 0 -> -1
    //     | x when x > 0 -> 1

    // printfn "%d" (sign -20)
    // printfn "%d" (sign 20)
    // printfn "%d" (sign 0)

    (*let compareInt x =
        match x with
        | (var1, var2) when var1 > var2 -> printfn "%d is greater than %d" var1, var2
        | (var1, var2) when var1 < var2 -> printfn "%d is less than %d" var1, var2
        | (var1, var2) when var1 = var2 -> printfn "%d is equal to %d" var1, var2

    compareInt(102, 107)
    compareInt(176, 102)
    compareInt(0, 0)*)

    // let parseHelper (f : string -> bool * 'a) = f >> function
    //     | (true, item) -> Some item
    //     | (false, _) -> None

    // let parseDateTimeOffset = parseHelper DateTimeOffset.TryParse

    // let result = parseDateTimeOffset "1970-01-01"
    // match result with
    // | Some dto -> printfn "It parsed!"
    // | None -> printfn "It didn't parse!"

    // // Define some more functions which parse with the helper function.
    // let parseInt = parseHelper Int32.TryParse
    // let parseDouble = parseHelper Double.TryParse
    // let parseTimeSpan = parseHelper TimeSpan.TryParse

    // // Active Patterns are used here
    // let (|Int|_|) = parseInt
    // let (|Double|_|) = parseDouble
    // let (|Date|_|) = parseDateTimeOffset
    // let (|TimeSpan|_|) = parseTimeSpan

    // let printParseResult = function
    // | Int x -> printfn "%d" x
    // | Double x -> printfn "%f" x
    // | Date d -> printfn "%s" (d.ToString())
    // | TimeSpan t -> printfn "%s" (t.ToString())
    // | _ -> printfn "Nothing was parse-able!"

   (* printParseResult "12"
    printParseResult "12.045"
    printParseResult "02/27/2016"
    printParseResult "9:01PM"
    printParseResult "banana!"*)

    // nested match..withs are ok
    // let f aValue =
    //     match aValue with
    //     | x ->
    //         match x with
    //         | _ -> "something"

    // [2 .. 10]
    // |> List.map (fun i ->
    //         match i with
    //         | 2 | 3 | 5 | 7 -> sprintf "%i is prime" i
    //         | _ -> sprintf "%i is not prime" i
    //         )

    // let x =
    //     match -1 with
    //     | 1 -> "a"
    //     | 2 -> "b"
    //     | i when i >= 0 && i<=100 -> "ok"
    //     // the last case will always match
    //     | x -> failwithf "%i is out of range" x

    // let y =
    //     match (1, 0) with
    //     // OR  -- same as multiple cases on one line
    //     | (2,x) | (3,x) | (4,x) -> printfn "x=%A" x
    //     | (1,x) & (_,1) -> printfn "x=%A" x // AND  -- must match both patterns at once, Note only a single "&" is used
    //     | (_, _) -> printfn "Out of bound"

    // // loop through a list and print the values
    let rec loopAndPrint aList =
        match aList with
        // empty list means we're done.
        | [] ->
            printfn "empty"

        // binding to head::tail.
        | x :: xs ->
            printfn "element=%A," x
            // do all over again with the
            // rest of the list
            loopAndPrint xs

    //test
    loopAndPrint [1..5]