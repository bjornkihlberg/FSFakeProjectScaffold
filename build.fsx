#r "paket:
nuget Fake.IO.FileSystem
nuget Fake.DotNet.Cli
nuget Fake.Core.Target //"
#load "./.fake/build.fsx/intellisense.fsx"

open Fake.Core
open Fake.DotNet
open Fake.IO
open Fake.IO.Globbing.Operators
open Fake.Core.TargetOperators

let clean _ =
    !! "./**/bin"
    ++ "./**/obj"
    |> Shell.cleanDirs

let run _ = DotNet.exec id "run" "--project ./App" |> ignore

Target.create "Clean" clean
Target.create "CleanRun" run
Target.create "Run" run

"Clean" ==> "CleanRun"

Target.runOrDefault "Run"
