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

let build _ =
    !! "./Lib/Lib.fsproj"
    ++ "./LibTests/LibTests.fsproj"
    ++ "./App/App.fsproj"
    |> Seq.iter (DotNet.exec id "build" >> ignore)

let run _ = DotNet.exec id "run" "--project ./App" |> ignore

let test _ = DotNet.exec id "test" "./LibTests/LibTests.fsproj" |> ignore

let coverage _ =
    [ "/p:CollectCoverage=true"
      "/p:CoverletOutputFormat=lcov"
      "/p:CoverletOutput=../lcov.info"
      "/p:Include=\"[Lib]*\""
      "./LibTests/LibTests.fsproj" ]
    |> String.concat " "
    |> DotNet.exec id "test"
    |> ignore

Target.create "Clean" clean
Target.create "CleanBuild" build
Target.create "Run" run
Target.create "Test" test
Target.create "Coverage" coverage

"Clean" ==> "CleanBuild"

Target.runOrDefault "Run"
