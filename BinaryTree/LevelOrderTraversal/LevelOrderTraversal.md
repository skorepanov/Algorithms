# Level-order traversal - Обход в порядке уровней

## Пример

```
        1
     /     \
    2       3
   / \       \
  4   5       8
     / \     /
    6   7   9
```

- Обход: 1, 2, 3, 4, 5, 8, 6, 7, 9.

## Сложность алгоритма (решение с помощью BFS)

- [BFS](../../Graph/BreadthFirstSearch/BreadthFirstSearch.md).
- Time complexity: `O(n)`.
- Space complexity: `O(n)`.
- Где:
    - `n` - число вершин дерева.
