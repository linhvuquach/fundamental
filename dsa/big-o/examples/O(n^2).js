/*** Example 1 */
for (let index = 0; index < array.length; index++) {
    for (let j = 0; j < array.length; j++) {
    }
}
// f(n) = n^2, O(fn) = O(n^2)

/*** Example 2 */
for (let index = 0; index < array.length; index++) {
    for (let j = index; j < array.length; j++) {
    }
}
// f(n) = n(n+1)/2, O(fn) = O(n^2)

/*** Example 3 */
for (let i = 0; i < n; i++) {
    for (let j = 0; j < 2 * n; j++) {}
    for (let k = 0; k < 3 * n; k++) {}
}
// f(n) = n * (2n + 3n), O(fn) = O(n^2)