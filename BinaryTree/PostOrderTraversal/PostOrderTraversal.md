# Post-order traversal - Обратный обход

- Порядок обхода: влево, вправо, корень.

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

- Обход: 4, 6, 7, 5, 2, 9, 8, 3, 1.

## Сложность алгоритма (рекурсивная реализация)

- Сложность одинакова для [pre-order traversal](../PreOrderTraversal/PreOrderTraversal.md), [in-order traversal](../InOrderTraversal/InOrderTraversal.md) и post-order traversal.

- Time complexity: `O(n)`.
    - где `n` - число вершин дерева.
- Space complexity:
    - в среднем: `O(h)`.
        - где `h` - высота дерева.
    - в худшем случае: `O(n)`, т.е. `h=n`.
        - когда дерево вытянуто.
    - в лучшем случае `O(log(n))`, т.е. `h=log(n)`.
        - когда дерево сбалансировано.
    - Это связано со стеком рекурсии.