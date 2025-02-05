﻿# Interpolation search - Интерполяционный поиск

## Сложность алгоритма

- Временная сложность.
  - В худшем случае: `O(n)`.
    - Если данные распределены очень неравномерно.
  - В среднем: `O(log(log(n)))`.
    - Если распределение относительно равномерное.
  - В лучшем случае: `O(1)`.
- Затраты памяти: `O(1)`.

## Описание алгоритма

- Алгоритм пытается угадать расположение целевого элемента в массиве по его значению.
  - Н-р, если нужно найти значение 30 в массиве со значениями от 1 до 100, то поиск начнётся с первой трети массива.
- Подходит для очень больших массивов.
- Как правило, интерполяционный поиск быстрее бинарного.
