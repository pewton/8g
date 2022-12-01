open CyclicQueue

[<EntryPoint>]
let main _ =
    create 4
    printfn"%A" queue
    let _ = enqueue 4
    let _ = enqueue 5
    let _ = enqueue 6
    let _ = enqueue 7
    let _ = enqueue 8
    let _ = enqueue 9
    printfn"%A" queue
    // Write your tests here
    // (or organize your tests into functions and call them from here)
    // Exit status; consider making it the number of failed tests
    0
