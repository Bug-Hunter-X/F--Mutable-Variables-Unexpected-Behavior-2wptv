let x = ref 10
let y = ref 20

let add x y = 
    x := !x + !y
    y := !y + !x
    !x + !y

let result = add x y
printf "%d" result