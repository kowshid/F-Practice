open System

let pi = 3.141592654

// Must implement BST later

module DiscriminatedUnions =
    type Shape =
        | Rectangle of width : float * length : float
        | Circle of radius : float
        | Square of double

        member this.Area = 
             match this with
             | Rectangle (w, h) -> w * h
             | Circle r -> pi * r * r
             | Square s -> s * s

    let rect = Rectangle(length = 1.3, width = 10.0)
    let circ = Circle (1.0)
    let sqr = Square (2.05)

    printfn $"Area of rect is {rect.Area}"

    let getShapeWidth shape =
        match shape with
        | Rectangle(width = w) -> w
        | Circle(radius = r) -> 2. * r
        | Square(s) -> s

    // The option type is a discriminated union.
    type Option<'a> =
        | Some of 'a
        | None

    let myOption1 = Some(10.0)
    let myOption2 = Some("string")
    let myOption3 = None

    let printValue opt =
        match opt with
        | Some x -> printfn "%A" x
        | None -> printfn "No value."

    // printValue myOption1
    
    let area myShape =
        match myShape with
        | Circle radius -> pi * radius * radius
        | Rectangle (w, h) -> w * h
        | Square s -> s * s
    
    let radius = 15.0
    let myCircle = Circle(radius)
    // printfn "Area of circle that has radius %f: %f" radius (area myCircle)
    
    let squareSide = 10.0
    let mySquare = Square(squareSide)
    // printfn "Area of square that has side %f: %f" squareSide (area mySquare)
    
    let height, width = 5.0, 10.0
    let myRectangle = Rectangle(height, width)
    // printfn "Area of rectangle that has height %f and width %f is %f" height width (area myRectangle)

    type Expression =
        | Number of int
        | Add of Expression * Expression
        | Multiply of Expression * Expression
        | Variable of string

    let rec Evaluate (env:Map<string, int>) exp =
        match exp with
        | Number n -> n
        | Add (x, y) -> Evaluate env x + Evaluate env y
        | Multiply (x, y) -> Evaluate env x * Evaluate env y
        | Variable id -> env.[id]

    let environment = Map.ofList [ "a", 2;
                                   "b", 4 ]
  
    let expressionTree = Add(Number 1, Multiply(Variable "a", Variable "b"))

    let result = Evaluate environment expressionTree

    // printfn $"{result}"

    /// The following represents the suit of a playing card.
    type Suit =
        | Hearts
        | Clubs
        | Diamonds
        | Spades

    /// A Discriminated Union can also be used to represent the rank of a playing card.
    type Rank =
        /// Represents the rank of cards 2 .. 10
        | Value of int
        | Ace
        | King
        | Queen
        | Jack

        /// Discriminated Unions can also implement object-oriented members.
        static member GetAllRanks() =
            [ yield Ace
              yield Jack
              yield Queen
              yield King
              for i in 2 .. 10 do yield Value i ]

    /// This is a record type that combines a Suit and a Rank.
    /// It's common to use both Records and Discriminated Unions when representing data.
    type Card = { Suit: Suit; Rank: Rank }

    /// This computes a list representing all the cards in the deck.
    let fullDeck =
        [ for suit in [ Hearts; Diamonds; Clubs; Spades] do
              for rank in Rank.GetAllRanks() do
                  yield { Suit=suit; Rank=rank } ]

    /// This example converts a 'Card' object to a string.
    let showPlayingCard (c: Card) =
        let rankString =
            match c.Rank with
            | Ace -> "Ace"
            | King -> "King"
            | Queen -> "Queen"
            | Jack -> "Jack"
            | Value n -> string n
        let suitString =
            match c.Suit with
            | Clubs -> "clubs"
            | Diamonds -> "diamonds"
            | Spades -> "spades"
            | Hearts -> "hearts"
        rankString  + " of " + suitString

    /// This example prints all the cards in a playing deck.
    let printAllCards() =
        for card in fullDeck do
            printfn "%s" (showPlayingCard card)

    // printAllCards()
    
    // single case DUs for domain modeling
    type Name = Name of string
    type Address = Address of string

    // instantiating single case DUs
    let address = Address "CTG"
    let name = Name "ahsan"

    // Unwrapping (getter in other languages)
    let unwrapAddress (Address a) = a
    let unwrapName (Name n) = n

    printfn $"{unwrapAddress address} {unwrapName name}"