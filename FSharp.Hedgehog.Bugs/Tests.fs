module Tests

open Xunit
open Hedgehog

[<Fact>]
let ``Fails properly with Assert and without counterexample`` () =
    property {
        let! a = Gen.string (Range.linear 2 10) Gen.alphaNum
        Assert.Equal(a, "")
    } |> Property.check
    
[<Fact>]
let ``Crashes with Assert and counterexample`` () =
    property {
        let! a = Gen.string (Range.linear 2 10) Gen.alphaNum
        counterexample a
        Assert.Equal(a, "")
    } |> Property.check
    
[<Fact>]
let ``Crashes with exception and counterexample`` () =
    property {
        let! a = Gen.string (Range.linear 2 10) Gen.alphaNum
        counterexample a
        failwith "boo"
    } |> Property.check