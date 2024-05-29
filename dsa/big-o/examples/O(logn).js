// CASE: find index of a given value

/*** Solution 1 */
for (let index = 0; index < array.length; index++) {
    if (array[index] === givenValue) return index;    
}
return -1;

/*** Solution 2 */
// Suppose Array is sorted

let indexMiddle = Math.floor(array.length / 2);
let indexValue = array[indexMiddle];

if (indexValue === givenValue) return indexMiddle;

if (givenValue > indexValue) {
    // loop from indexMiddle to array.length
}
else {
    // loop from 0 to indexMiddle
}

return - 1;

/*** Solution 3 */
// Suppose Array is sorted
let low = 0;
high = n - 1;

while (low <= high) {
    let mid = Math.floor(high + low) / 2;
    if (array[mid] === givenValue) return mid;
    else if (array[mid] < givenValue) low = mid + 1;
    else high = mid - 1;
}
return -1;

// => f(n) = logn, O(fn) = O(logn)