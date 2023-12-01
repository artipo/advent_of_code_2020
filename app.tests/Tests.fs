module Tests

open FsUnit.Xunit
open Xunit

module Day01 =

    open App.Solutions.Day01

    [<Fact>]
    let ``day 01, puzzle 1`` () =
        [ "1721"
          "979"
          "366"
          "299"
          "675"
          "1456" ]
        |> searchMatchingNumbers 2
        |> should equal 514579

    [<Fact>]
    let ``day 01, puzzle 2`` () =
        [ "1721"
          "979"
          "366"
          "299"
          "675"
          "1456" ]
        |> searchMatchingNumbers 3
        |> should equal 241861950
