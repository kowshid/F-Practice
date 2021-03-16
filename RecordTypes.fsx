open System

module RecordTypes =
    type ContactCard =
        {
            Name :     string
            Phone :    string
            Verified : bool
        }

        member this.printContact =
            printfn "%s: Phone: %s, Verified %d" this.Name this.Phone (if not this.Verified then 0 else 1)

    let contact1 =
        { Name = "Alf"
          Phone = "(206) 555-0157"
          Verified = false
        }

    // Can we define something like this without providing every information? like below - NO
    // Can the fields have default values
    // let contact1 =
    //     { Name = "Alf"
    //       Phone = "(206) 555-0157"
    //     }

    let setNamePhone name phone =
        {
            Name =  name;
            Phone = phone;
            Verified = false
        }

    let registerContact tempContact =
        {
            tempContact with
                Verified = true
        }

    let preRegistered = setNamePhone "Ahsan" "102"
    preRegistered.printContact

    let contact = registerContact preRegistered
    contact.printContact

    // Construct Deconstruct
    type GeoCoord = { lat: float; long: float } // use colon in type
    let myGeoCoord = { lat = 1.1; long = 2.2 }  // use equals in let
    let { lat = myLat; long = myLong } = myGeoCoord  // "deconstruct"
    let { lat= _ ; long = myLong2 } = myGeoCoord  // "deconstruct"
    let { long = myLong3 } = myGeoCoord         // "deconstruct"

    // If you just need a single property, you can use dot notation rather than pattern matching.
    let x = myGeoCoord.lat
    let y = myGeoCoord.long

    //define return type
    type WordAndLetterCountResult = { wordCount:int; letterCount:int }

    let wordAndLetterCount (s: string) : WordAndLetterCountResult =
       let words = s.Split [|' '|]
       let letterCount = words |> Array.sumBy (fun word -> word.Length )
       {wordCount = words.Length; letterCount = letterCount}

    //test
    wordAndLetterCount "to be or not to be"

    printfn "%A" (myGeoCoord.GetHashCode())

    