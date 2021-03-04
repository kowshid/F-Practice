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

    // Can we define something like this without providing every information? like below
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