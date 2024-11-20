﻿# Bubble sort - Сортировка пузырьком

Алгоритм устойчивой сортировки.

## Сложность алгоритма

- `O(n^2)`.

## Описание алгоритма

1. Алгоритм проходит по списку несколько раз и меняет местами все неправильные пары.
   - В качестве пар берутся соседние элементы.
2. Пары элементов списка перебираются либо `(n-1)` раз, либо пока на очередном обходе не обнаружится, что список уже отсортирован.