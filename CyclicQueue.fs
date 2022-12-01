module CyclicQueue

type Value = int

let mutable first = None

let mutable last = None

let mutable queue : Value option[] = [||]

let create (n: int) : unit =
    queue <- Array.create n None
    ()
let enqueue (e: Value) : bool =
    if last.IsNone then
        queue[0] <- Some e
        last <- Some 0
        first <- Some 0
        true
    elif ((last|>Option.isSome) && (first|>Option.isSome)) then
        if (((last|>Option.get)+1) % queue.Length) = (first|>Option.get) then
            false
        elif (last|>Option.get) = (queue.Length - 1) then
            last <- Some ((last|>Option.get) % (queue.Length - 1))
            queue[(last|>Option.get)] <- Some e
            true
        else
            last <- Some ((last|>Option.get) + 1)
            queue[(last|>Option.get)] <- Some e
            true
    else
        false






let dequeue () : Value option =
    failwith "Not implemented yet: dequeue"

let isEmpty () : bool =
    failwith "Not implemented yet: isEmpty"


let length () : int =
    failwith "Not implemented yet: length"

let toString () : string =
    failwith "Not implemented yet: toString"
