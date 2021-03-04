open System

module Sequences =
    let seq1 = seq {yield "Hello"; yield "World";}
    let seq2 = seq {"Ahsan", "Kabir"}

    let seq = Seq.init 100 (fun n -> n * 2)

    let rand = System.Random

    // somossa ki
    let rec randomWalk x =
        seq { yield x
              yield! randomWalk (x + rnd.NextDouble() - 0.5) }

    /// This example shows the first 100 elements of the random walk.
    let first100ValuesOfRandomWalk =
        randomWalk 5.0
        |> Seq.truncate 100
        |> Seq.toList

    printfn "First 100 elements of a random walk: %A" first100ValuesOfRandomWalk