# Big-O Notation

Big-O notation is a mathematical notation used in computer science to describe the asymptotic behavior or efficiency of an algorithm. It provides a way to analyze the performance of an algorithm by expressing how the runtime or space requirements grow relative to the input size.

In Big-O notation, the letter "O" represents the order of magnitude or the worst-case scenario. The notation is typically written as "O(f(n))," where "f(n)" is a mathematical function that represents the algorithm's performance in terms of the input size "n."

The Big-O notation describes the upper bound of the growth rate of an algorithm. It simplifies the analysis by focusing on the dominant term that has the most significant impact on the algorithm's performance as the input size increases. The actual runtime or space usage of an algorithm may be better (faster or smaller) than the Big-O notation suggests, but the notation helps establish an upper limit or worst-case estimate.

## Commonly used Big-O notations include:

- O(1) - Constant time: The algorithm's runtime or space usage remains constant, regardless of the input size. Examples include accessing an element in an array or performing a basic arithmetic operation.
- O(logn) - Logarithmic time: The algorithm's runtime or space usage grows logarithmically with the input size. Examples include binary search or operations on balanced search trees.
- O(n) - Linear time: The algorithm's runtime or space usage grows linearly with the input size. Examples include traversing an array or a linked list.
- O(nlogn) - Linearithmic time: The algorithm's runtime or space usage grows in a multiple of n and the logarithm of n. Examples include efficient sorting algorithms like merge sort or quicksort.
- O(n^2) - Quadratic time: The algorithm's runtime or space usage grows quadratically with the input size. Examples include nested loops or bubble sort.
- (2^n) - Exponential time: The algorithm's runtime or space usage grows exponentially with the input size. Examples include generating all subsets of a set or solving the traveling salesman problem using a brute-force approach.

## Time and space complexity

- Time complexity: number of statements to run - the running time of the algorithm based on the number of input elements
- Space complexity: the amount of memory the algorithm needs, based on the number of the input elements.

## References

- https://www.freecodecamp.org/news/big-o-notation-why-it-matters-and-why-it-doesnt-1674cfa8a23c/
- https://www.bigocheatsheet.com/
- https://github.com/jwasham/coding-interview-university?tab=readme-ov-file#algorithmic-complexity--big-o--asymptotic-analysis
