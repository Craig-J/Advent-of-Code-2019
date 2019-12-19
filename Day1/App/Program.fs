// Learn more about F# at http://fsharp.org

open System
open System.IO
open System.Linq

let fuelForModule mass =
    let fuelEquation = (fun x -> x / 3.0) >> Math.Floor >> fun x -> x - 2.0
    let rec fuelForFuel f =
        if f < 0.0 then 0.0
        else f + (f |> fuelEquation |> fuelForFuel)
    fuelEquation >> fuelForFuel <| mass

[<EntryPoint>]
let main argv =
    let fuelFromString = Double.Parse >> fuelForModule
    let total = File.ReadAllLines("input.txt").Select(fuelFromString).Sum()
    printfn "%f" total
    0 // return an integer exit code
