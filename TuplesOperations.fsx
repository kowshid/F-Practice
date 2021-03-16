module Tuples =
    let averageFour (a, b, c, d) =
        let sum = a + b + c + d
        sum / 4.0

    let avg : float = averageFour (1.0, 2.0, 5.0, 6.0)

    printfn $"average of (1.0, 2.0, 5.0, 6.0) is {avg}"

    // how to access individual items?

    // Tuples of complex types
    // define some types
    type Person = { First:string; Last:string }
    type Complex = float * float
    type ComplexComparisonFunction = Complex -> Complex -> int

    // define some tuples using them
    type PersonAndBirthday = Person * System.DateTime
    type ComplexPair = Complex * Complex
    type ComplexListAndSortFunction = Complex list * ComplexComparisonFunction
    type PairOfIntFunctions = (int->int) * (int->int)

    // a function that takes a single tuple parameter
    // but looks like it takes two ints
    let addConfusingTuple (x, y) = x + y

    // Constructor, Deconstructor
    let z = 1,true,"hello",3.14   // "construct"
    let z1, z2, z3, z4 = z        // "deconstruct"
    // let z1, z2, z3 = z         // error
    let _, z5, _, z6 = z          // ignore 1st and 3rd elements

    // pair jas fst and snd keyword
    let x = (1, 2)
    fst x
    snd x

    // return word count and letter count in a tuple
    let wordAndLetterCount (s:string) =
       let words = s.Split [|' '|]
       let letterCount = words |> Array.sumBy (fun word -> word.Length )
       (words.Length, letterCount)

    //test
    printfn "%A" (wordAndLetterCount "to be or not to be")

    let addOneToTuple (x, y, z) = (x + 1, y + 1, z + 1)

    // try it
    addOneToTuple (1, 2, 3)

    printfn "HashCode of x is %A" (x.GetHashCode())
    printfn "String of x is %s" (x.ToString())