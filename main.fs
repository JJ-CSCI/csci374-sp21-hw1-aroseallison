module Assignment

// Problem 1
let rec tribn n =
    // write your code here
    if n <= 0 then 0
    else if n = 1 then 1
    else if n = 2 then 1
    else tribn (n-1) + tribn (n-2) + tribn (n-3)

// Problem 2
let tribn2 n =
    // write your code here
  0
// Problem 3
let rec last lst = 
    // write your code here
  (List.head (List.rev lst))

// Problem 4
let fourth (lst:int list) =
    // write your code here
  let rec fourthn n (lst:int list) = 
    if List.isEmpty lst then 0
    else 
      let n = 4
      let h = List.head lst
      let t = List.tail lst
        if h = n then h::(fourthn t)
        else fourthn t
// Problem 5
let everyfourth (lst:int list) =
    // write your code here
  0

// Problem 6
let rec take n (lst:int list) =
    // write your code here
  if List.length lst < n then [lst]
  else 
    let h = List.head lst
    let t = List.tail lst
    let count = 0
    if count > n then h::(take t)
    else take t
      count+1


// Problem 7
let rec drop n (lst:int list) = 
    // write your code here
  if List.isEmpty lst then []
  else 
    let h = List.head lst
    let t = List.tail lst
    let count = 0
    if count < n then h::(drop t)
    else drop t
      count+1
