// Learn more about F# at http://fsharp.org
open System
open ClassLibrary.World
open FSharpConsoleApp.Display

let generateWorld randomizer =
    new World(8,8, randomizer)

[<EntryPoint>]
let main argv =
    printfn "F# Console Application Tutorial"

    let randomizer = new Random()

    let mutable simulating: bool = true
    let mutable world = generateWorld(randomizer)

    while simulating do
        displayWorld world

        let key = getUserInput()

        Console.Clear()

        match key.Key with
        | ConsoleKey.X -> simulating <- false
        | ConsoleKey.R -> world <- generateWorld(randomizer)
        | _ -> printfn "Invalid input '%c'" key.KeyChar

    0 // return an integer exit code
