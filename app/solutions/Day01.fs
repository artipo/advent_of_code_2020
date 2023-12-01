module App.Solutions.Day01

open App.Helpers

    // vecchie soluzioni

    // Seq.allPairs numbers numbers
    // |> Seq.pick (fun (a, b) ->
    //     if a + b = 2020 then
    //         Some (a * b)
    //     else
    //         None)
    
    // Seq.allPairs numbers numbers
    // |> Seq.find (fun (a, b) -> (a + b) = 2020)
    // |> (fun (a, b) -> a * b)


let searchMatchingNumbers grade ss =
    let numbers =
        ss
        |> List.map int
    
    let tuples =
        let ts = ResizeArray()
        
        let rec loop level acc =
            if grade = level then
                ts.Add acc
            else
                for n in numbers do
                    loop (level + 1) (n::acc)
        loop 0 []
        ts
    
    tuples
    |> Seq.find (fun t -> t |> List.sum = 2020)
    |> (fun t -> t |> List.reduce (*))

// wrappers
let solve_puzzle_1 () =
    File.readLines @"./inputs/day01.txt"
    |> Seq.toList
    |> searchMatchingNumbers 2
    |> printfn "Day01, puzzle 1 -> result = %A"

let solve_puzzle_2 () =
    File.readLines @"./inputs/day01.txt"
    |> Seq.toList
    |> searchMatchingNumbers 3
    |> printfn "Day01, puzzle 2 -> result = %A"