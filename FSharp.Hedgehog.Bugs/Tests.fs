module Tests

open Hedgehog.Xunit

[<Property>]
let ``Should generate System.Collections.Generic.List``(value: System.Collections.Generic.List<int>) =
    value = value
    
[<Property>]
let ``Should generate ResizeArray``(value: ResizeArray<int>) =
    value = value
