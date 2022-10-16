#Задача:
Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами

# Описание решения:

Запрашиваем у пользователя данные, разбиваем через запятую. Объявляем метод удаления пробелов между элементами масссива от пользователя и формируем новый массив такой же длины. Объявляем метод генерации второго нового массива, в котором цикл соразмерный длине массива, внутри цикла проверка условия ( <4 ), если да - элемент массива заносится в count элемент второго массива. Переменная count поочередно накапливает из первого массива во второй необходимые элементы. После присвоения увеличивается переменная count на 1 и возвращается к циклу for в котором i увеличивается на 1. И так проверяется до конца.