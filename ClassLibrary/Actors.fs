﻿namespace ClassLibrary

open ClassLibrary.WorldPos

module Actors =

    type ActorKind =
        | Squirrel of hasAcorn: bool
        | Tree
        | Acorn
        | Rabbit
        | Doggo

    type Actor = 
        { Pos: WorldPos
          ActorKind: ActorKind}

    let getChar actor =
        match actor.ActorKind with
        | Squirrel _ -> 'S'
        | Tree _ -> 't'
        | Acorn _ -> 'a'
        | Rabbit _ -> 'R'
        | Doggo _ -> 'D'


