# F# Mutable Variables Unexpected Behavior

This example demonstrates unexpected behavior with mutable variables in F#. The `add` function modifies the mutable variables `x` and `y`, but the changes are not reflected outside the function's scope as expected.  This highlights a common misunderstanding of mutability in F# when dealing with function parameters that are mutable.

## Bug Description
The code calculates the sum of two mutable integers, but the result is different from what's expected due to the way mutability is handled within the function's scope. The variables 'x' and 'y' are modified inside the function, however these changes are not reflected in the global scope.