open System

module Tuples = 
    let averageFour (a, b, c, d) =
        let sum = a + b + c + d
        sum / 4.0

    let avg: float = averageFour (1.0, 2.0, 5.0, 6.0)

    printfn $" average of (1.0, 2.0, 5.0, 6.0 is {avg}"

    // how to access individual items?