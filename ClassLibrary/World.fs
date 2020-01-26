namespace ClassLibrary
open System
open ClassLibrary.Actors
open ClassLibrary.WorldPos

module World =

    let getRandomPos(maxX: int32, maxY: int32, random: Random): WorldPos =
        let x = random.Next(maxX) + 1
        let y = random.Next(maxY) + 1
        newPos x y

    let generate(maxX: int32, maxY: int32, random: Random): Actor seq =
        let pos = getRandomPos(maxX, maxY, random)
        seq {
            yield createSquirrel pos
        }

    type World(maxX: int32, maxY: int32, random: Random) =
        let actors = generate(maxX, maxY, random)
        member this.Actors = actors
        member this.MaxX = maxX
        member this.MaxY = maxY

        member this.GetCharacterAtCell(x, y) =
            let mutable char = '.'
            for actor in this.Actors do
                if actor.Pos.X = x && actor.Pos.Y = y then
                    char <- actor.Character
            char

