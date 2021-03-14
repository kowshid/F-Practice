type Option<'a> =
    | Some of 'a
    | None

let validInt = Some 1
let invalidInt = None

type SearchResult = Option<string>

[1; 2; 3; 4] |> List.tryFind (fun x -> x = 3)
[1; 2; 3; 4] |> List.tryFind (fun x -> x = 10)

let tryParseTuple intStr =
    try
        let i = System.Int32.Parse intStr
        (true, i)
    with _ ->
        (false, 0)

type TryParseResult =
    {
        success: bool
        value :  int
    }

let tryParseRecord intStr =
    try
        let i = System.Int32.Parse intStr
        {
            success = true
            value =   i
        }
    with _ ->
        {
            success = false
            value =   0
        }

let tryParseOption intStr =
    try
        let i = System.Int32.Parse intStr
        Some i
    with _ -> None

// printfn "%A" (tryParseOption "99")
// printfn "%A" (tryParseOption "abc")

type Person =
    {
        name :    string
        contact : string
    }


// We can use option with any type. 
// For example, you can have an option of a complex type like Person, or a tuple type like int*int, or a function type like int->bool, or even an option of an option type.

type OptionalString = string option
type OptionalPerson = Person option       // optional complex type
type OptionalTuple = (int*int) option
type OptionalFunc = (int -> bool) option  // optional function
type NestedOptionalString = OptionalString option //nested options!
type StrangeOption = string option option option

let x = Some 99
let result =
    match x with
        | Some i -> i * 2
        | None -> 0

// let resultUsingFold =
//     let y = Some 99
//     y |> Option.fold (fun _ v -> v * 2) 0

