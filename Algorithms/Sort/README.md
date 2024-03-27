

| Sort Algorithm | Data Structure |    Worst Case    |    Best Case     |     Average      | Space Complexity | Optimal | Stability |
| :------------- | :------------: | :--------------: | :--------------: | :--------------: | :--------------: | :-----: | :-------: |
| Bubble Sort    |     Array      | O(n<sup>2</sup>) |       O(n)       | O(n<sup>2</sup>) |       O(1)       |   No    |  Stable   |
| Selection Sort |     Array      | O(n<sup>2</sup>) | O(n<sup>2</sup>) | O(n<sup>2</sup>) |       O(1)       |   No    | Unstable  |
| Insertion Sort |     Array      | O(n<sup>2</sup>) |       O(n)       | O(n<sup>2</sup>) |       O(1)       |   No    |  Stable   |
| Merge Sort     |     Array      |     O(nlogn)     |     O(nlogn)     |     O(nlogn)     |       O(n)       |   No    |  Stable   |
| Heap Sort      |     Array      |     O(nlogn)     |     O(nlogn)     |     O(nlogn)     |       O(1)       |   No    | Unstable  |
| Quick Sort     |     Array      | O(n<sup>2</sup>) |     O(nlogn)     |     O(nlogn)     |     O(nlogn)     |   No    | Unstable  |
| Tim Sort       |     Array      |     O(nlogn)     |       O(n)       |     O(nlogn)     |       O(n)       |   No    |           |
| Counting Sort  |                |     O(n + k)     |     O(n + k)     |     O(n + k)     |       O(k)       |         |  Stable   |
| Radix Sort     |                |      O(n*k)      |      O(n*k)      |      O(n*k)      |     O(n + k)     |         |  Stable   |
| Bucket Sort    |                | O(n<sup>2</sup>) |     O(n + k)     |     O(n + k)     |       O(n)       |         |  Stable   |
| Shell Sort     |                | O(n<sup>2</sup>) |       n(2)       |                  |                  |         | Unstable  |

* *Best case time complexity: when the array is already sorted.*
* *Worst case: when the array is reverse sorted.* 
* *Space Complexity: memory comsumsion.*
* *n: number of elements of array.*
* *k: value range of each element.*