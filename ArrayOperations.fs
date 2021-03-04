open System

module Arrays = 
    let array1 = Array.create 10 1.0

    let array2 = Array.empty

    let array3 : int array = Array.zeroCreate 10

    let array4 = Array.init 10 (fun idx -> idx * idx)

    (*let array5 =
        [|
            for number in array4 do
                if number % 2 = 0 then
                    yield number
        |]*)

    // why this does not work?
    let array5 =
        [|
            for number in array1 do
                if number % 2.0 = 0.0 then
                    yield number
        |]

    let array6 = Array.create 10 ""

    // difference between these two prints
    printfn $"{array1}\n{array2}\n{array3}\n{array4}\n{array5}"

    printfn "%A\n%A\n%A\n%A\narray5 = %A" array1 array2 array3 array4 array5

    array6.[1] <- "Ahsan"
    array6.[0] <- "Kabir"

    for word in array6 do
        printfn "word: %s" word