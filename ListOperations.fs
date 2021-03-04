open System

module Lists =
    // literal method
    let numbers = [1; 2; 3; 4; 5]
    let numbers2 = [2 .. 2 .. 11]

    // range method
    let numberList = [0 .. 99]

    let isOdd x = 
        x % 2 = 1

    // yield method
    let blackSquares =
        [for i in 0 .. 7 do
            for j in 0 .. 7 do
                if isOdd (i+j) then
                    yield (i, j)
        ]

    // printfn $"Black squares are {blackSquares}"

    // how define parameter and return type of following function
    // let sumOfSquaresOfThreeDivisibles (numbers : List) : List =
    let sumOfSquaresOfThreeDivisibles = 
        numberList
        |> List.filter (fun x -> x % 3 = 0)
        |> List.sumBy (fun x -> x * x)

    // printfn $"sumOfSquaresOfThreeDivisibles is {sumOfSquaresOfThreeDivisibles}"

    let squaresOfNumbers =
        numbers 
        |> List.map (fun x -> x * x)

    printfn $"square numbers {squaresOfNumbers}"

    let numbers3 = numbers @ numbers2
    
    printfn $"numbers 2 {numbers2}"

    let printWholeList =
        numbers3 |> List.iter (printf "%d ")