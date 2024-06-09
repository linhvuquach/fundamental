function fibonacci(n)
{
    if (n <= 0) return 0;
    else if (n === 1) return 1;
    else return fibonacci(n-1) + fibonacci(n-2);
}

console.log(fibonacci(5));

// The function would make the following recursive calls

// fibonacci(5)
//     fibonacci(4)
//         fibonacci(3)
//             fibonacci(2)
//                 fibonacci(1)
//                 fibonacci(0)
//             fibonacci(1)
//         fibonacci(2)
//             fibonacci(1)
//             fibonacci(0)
//     fibonacci(3)
//         fibonacci(2)
//             fibonacci(1)
//             fibonacci(0)
//         fibonacci(1)