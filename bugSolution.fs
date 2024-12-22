let mutable x = 10
let mutable y = 20

let swap x y =
    let temp = x
    x <- y
    y <- temp

swap x y
printfn "%d %d" x y // This will print 20 20

//Alternatively, you can avoid mutability altogether using tuples and pattern matching
let swap (x,y) = (y,x)
let x,y = swap(10,20)
printfn "%d %d" x y