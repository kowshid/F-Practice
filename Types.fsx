type A = int * int
type B = {FirstName:string; LastName:string}
type C = Circle of int | Rectangle of int * int
type D = Day | Month | Year
type E<'a> = Choice1 of 'a | Choice2 of 'a * 'a

type MyClass(initX:int) =
   let x = initX
   member this.Method() = printf "x=%i\n" x

// Application
let a = (1,1)
let b = { FirstName="Bob"; LastName="Smith" }
let c = Circle 99
let c' = Rectangle (2,1)
let d = Month
let e = Choice1 "a"
let myVal = MyClass 99
myVal.Method()

// Construct, Deconstuct
let aTuple = (1,1)                             // "construct"
let (a1,a2) = aTuple                             // "deconstruct"

let bRecord = { FirstName="Bob"; LastName="Smith" }  // "construct"
let { FirstName = b1 } = bRecord                   // "deconstruct"

let cCirle = Circle 99                              // "construct"
match cCirle with
| Circle c1 -> printf "circle of radius %i\n" c1 // "deconstruct"
| Rectangle (c2,c3) -> printf "%i %i\n" c2 c3    // "deconstruct"

let cRect = Rectangle (2,1)                       // "construct"
match cRect with
| Circle c1 -> printf "circle of radius %i\n" c1 // "deconstruct"
| Rectangle (c2,c3) -> printf "%i %i\n" c2 c3    // "deconstruct"

// Abbrev
type ProductCode = string
type transform<'a> = 'a -> 'a
type AdditionFunc = int -> int -> int

let addFunc : AdditionFunc =
    fun a b -> a + b

// Tuple
// not explicitly defined using type keyword
let t = 1, 2
let s = (3, 4)

// Enum
type Gender =
    | Male = 1
    | Female = 2
    | Other = 3
// usage
let g = Gender.Male

// Class
type Product (code: string, price: double) =
    let isFree =
        price = 0.0
    new(code) = Product(code, 0.0)

    member this.Code = code
    member this.Price = price
    member this.PrintProduct =
        printfn "Code = %A, Price = %f\n" this.Code this.Price

// usage
let p1 = Product("Kowshid", 102.0)
let p2 = Product("Ahsan")
p1.PrintProduct
p2.PrintProduct

// interface
type IPrintable =
    abstract member Print : unit -> unit

// Struct
type ProductStruct =
    struct
        val code: string
        val price: double
        new(code) =
            {
                code = code;
                price = 0.0
            }
    end

// usage
let p3 = ProductStruct()
let p4 = ProductStruct("Kabir")
printfn "%A" (p3)
printfn "%A" p4