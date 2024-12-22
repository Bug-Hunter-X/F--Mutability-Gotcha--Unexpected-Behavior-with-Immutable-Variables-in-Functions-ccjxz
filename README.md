# F# Mutability Gotcha: Unexpected Behavior with Immutable Variables in Functions

This example highlights a common issue in F# related to mutability.  In F#, variables declared with `let` are immutable, meaning their values cannot be changed after they are initialized.  Using `let mutable` declares a mutable variable. This difference can lead to unexpected behavior or compile-time errors if not properly understood.

The `bug.fs` file demonstrates the problem. The `swap` function attempts to modify immutable variables leading to a compile time error. `bugSolution.fs` shows how to correctly use mutable variables to achieve the desired swapping behavior.

**Key takeaway**: Always be mindful of whether you're using `let` (immutable) or `let mutable` (mutable) when working with variables in F#.