namespace LibTests

open Lib.Library

open Xunit

module LibraryTests =
    [<Fact>]
    let ``f test1`` () =
        Assert.True (f 4 = 8)
    
    [<Fact>]
    let ``f test2`` () =
        Assert.Equal (10, f 5)
