# Linked list

A linked list is a linear data structure, Unlike arrays, linked list elements are **not stored at a contiguous location**. it is basically **chains of nodes**, each node contains information such as **data and a pointer** to the next node in the chain. In the linked list there is a **head pointer**, which points to the first element of the linked list, and if the list is empty then it simply points to null or nothing.

## Why to Linked list data structure needed?

Here are a few advantages of a linked list that is listed below, it will help you understand why it is necessary to know.

- Dynamic data structure: The size of memory can be allocated or de-allocated at run time based on the operation insertion or deletion.
- Ease of insertion\deletion: The insertion and deletion of elements are simpler than arrays since no elements need to be shifted after insertion and deletion, Just the **address needed to be updated**.
- Efficent memory utilization: As we know Linked List is a dynamic data structure the size increases or decreases as per the requirement so this avoids the wastage of memory.
- Implementation: Various advanced data structures can be implemented using a linked list like stack, queue, graph, hash maps, etc.

## Type of Linked list

- Singly-linked list: Traversal of items can be done in the forward direction only due to the linking of every node to its next node.
- Doubly-linked list: Traversal of items can be done in both forward and backward directions as every node contains an additional prev pointer that points to the previous node.
- Circular-linked list: A circular linked list is a type of linked list in which the first and the last nodes are also connected to each other to form a circle, there is no NULL at the end

## References

- https://www.geeksforgeeks.org/top-data-structures-that-every-programmer-must-know/
