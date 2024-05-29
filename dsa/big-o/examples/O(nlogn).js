// Implement merge sort algorithm
function mergeSort(array) {
    if (array.length <= 1) {
        return array;
    }

    const mid = Math.floor(array.length / 2);
    const left = array.slice(0, mid);
    const right = array.slice(mid);

    return merge(mergeSort(left), mergeSort(right));
}

function merge(left, right) {
    let result = [];
    let i = 0;
    let j = 0;

    while (i < left.length && j < right.length) {
        if (left[i] < right[j]) {
            result.push(left[i]);
            i++;
        } else {
            result.push(right[j]);
            j++;
        }
    }

    return result.concat(left.slice(i)).concat(right.slice(j));
}

// Usage example
const array = [5, 2, 8, 4, 1, 9, 6, 3, 7];
const sortedArray = mergeSort(array);
console.log(sortedArray);

// In this example, the array is first sorted using a divide-and-conquer algorithm like merge sort, which has a time complexity of O(n log n). 
