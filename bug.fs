let mutable x = 10
let mutable y = 20

let swap x y =
    let temp = x
    x <- y
    y <- temp

swap x y
printfn "%d %d" x y // This will print 20 20

//However, if you try to use swap function with let binding instead of mutable variables
let x = 10
let y = 20

let swap x y =
    let temp = x
    x <- y //This line will give compile time error since x is immutable
    y <- temp

swap x y
printfn "%d %d" x y