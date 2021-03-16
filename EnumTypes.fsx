type ColorEnum =
    | Red = 1
    | Black = 2
    | White = 3

// Error. Strings are not allowed
// type MyEnum = Yes = "Y" | No = "N"
type MyEnum = Yes = 'Y' | No = 'N'

let red = ColorEnum.Black

let redInt = int ColorEnum.Red

let redAgain : ColorEnum = enum redInt  // cast to a specified enum type
let yellow = enum<ColorEnum>(4)    // or create directly

let values = System.Enum.GetValues(typeof<ColorEnum>)
let redFromString =
    System.Enum.Parse(typeof<ColorEnum>,"Red")
    :?> ColorEnum  // downcast needed

let qualifiedMatch x =
    match x with
    | ColorEnum.Red -> printfn "red"
    | ColorEnum.Black -> printfn "black"
    | _ -> printfn "sth else"