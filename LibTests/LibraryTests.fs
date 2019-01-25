namespace LibTests

open Lib.Library

open Xunit
open FsCheck.Xunit

module LibraryTests =
    [<Property>]
    let ``g always returns value greater or equal to its argument`` x = g x >= x

    [<Fact>]
    let ``f test1`` () =
        Assert.True (f 4 = 8)
    
    [<Fact>]
    let ``f test2`` () =
        Assert.Equal (10, f 5)
