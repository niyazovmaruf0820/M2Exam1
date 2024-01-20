# Exam 

### Task 1

Given a array of numbers and the index of an element in the array k. Remove the element at index k from the array by shifting all elements to the right of the element at index k to the left.    

----

Дан массив из чисел и индекс элемента в массиве k. Удалите из массив элемент с индексом k, сдвинув влево все элементы, стоящие правее элемента с индексом k.  

----

Ба мо массиви ададҳо ва индекси элемент k дода мешавад. Элементро дар индекси k аст чоп накунед, ва бокимондаи массивро чоп кунед.
 
**Input**
```
7
7 6 5 4 3 2 1
2
```
**Output**
```
7 6 4 3 2 1
```

##

### Task 2

Given a positive number of n.  Find :

The number of even numbers => `int EvenCount(int n)`

The number of odd numbers => `int OddCount(int n)`

The number of digits => `int DigitCount(int n)`

Sum of digits => `int SumDigit(int n) `  

---

Дано положительное число n. Найдите :

Количество четных чисел => `int EvenCount(int n)`

Количество нечетных чисел => `int OddCount(int n)`

Количество цифр => `int DigitCount(int n)`

Сумма цифр => `int SumDigit(int n)`

 ---

Шумораи мусбати n дода мешавад. Ёбед :      

Шумораи ададхои чуфт => `int EvenCount(int n)`

Шумораи ададхои тоk => `int OddCount(int n)`

Шумораи ракамхо => `int DigitCount(int n)`

Суммаи Ададхо => `int SumDigit(int n)`

**Input**
```
12345
```
**Output**
```
Even:2
Odd:3
Digits:5
Sum:15
```
##

### Task 3

Write a function string IsPalindrome(int n) to check if a given four-digit number is a palindrome or not. (The function should return “YES” if the number is a palindrome, otherwise return “NO”).

---

Напишите функцию string IsPalindrome(int n), чтобы проверить, является ли заданное четырехзначное число палиндромом или нет. (Функция должна вернуть “YES”, если число является палиндромом, в противном случае вернуть “NO”).

---

Функсияи string IsPalindrome(int n)-ро нависед, то санҷед, ки рақами 4-рақамаи додашуда палиндром аст ё не. (Агар рақам палиндром бошад, функсия бояд “YES” баргардонад, вагарна “NO” баргардонад).

**Input**
```
1001
```
**Output**
```
YES
```
##

### Task 4
Create a method `int SumOfDigits(int n)` to calculate the sum of the individual digits of a given.  

----
 
Cоздать метод `int SumOfDigits(int n)` для вычисления суммы отдельных цифр заданного числа.  

----
 
Методи `int SumOfDigits(int n)` созед, ки суммаи рақамҳои aдади додашударо баргардонад.  
 
**Input**
```
1234
```
**Output**
```
The sum of the digits of the number 1234 is : 10
```

##

### Task 5
Write a method `void IncrementArrayElements(ref int[] arr, ref int n)` that will accept an array of type int[] and a value of type int by reference. The method must increment all array elements by the passed value.   

----

Напишите метод `void IncrementArrayElements(ref int[] arr, ref int n)`, который будет принимать массив типа int[] и значение типа int по ссылке. Метод должен увеличивать все элементы массива на переданное значение.  

----

Методи `void IncrementArrayElements(ref int[] arr, ref int n)` нависед, ки массиви навъи int[] ва арзиши навъи int-ро бо ссылки қабул кунад. Метод бояд ҳамаи элементҳои массивро бо арзиши додашуда зиёд кунад.    

**Input**
```
5
1 2 3 4 5
5
```
**Output**
```
 [6, 7, 8, 9, 10] 
```

##

### Task 6

Write a method `void Swap(ref int a, ref int b)` that will take two parameters by reference and swap their values.  

----

Напишите метод `void Swap(ref int a, ref int b)`, который будет принимать два параметра по ссылке и менять их значения местами.  

----

Meтоди `void Swap(ref int a, ref int b)` нависед, ки ду параметр бо ссылка мегирад ва кимматои онҳоро иваз мекунад.  

**Input**
```
x = 5
y = 10
```
**Output**
```
x = 10
y = 5
```

##

### Task 7
An instructor has given her students an assignment to calculate the sum of the digits of a positive integer using recursion.The student came up with the solution does not seem to be correct.Help her fix the error.

---

Преподаватель дала своим ученикам задание вычислить сумму цифр положительного целого числа с помощью рекурсии. Ученица нашла решение,похоже, неверное. Помогите ей исправить ошибку.

--- 

Муаллим ба шогирдонаш супориш дод, ки бо истифода аз рекурсия ҷамъи рақамҳои бутуни мусбатро ҳисоб кунад. Донишҷӯ як роҳи ҳалли худро ёфт, ки ба назар нодуруст буд. Ба ӯ кӯмак кунед, ки хатогиашро ислоҳ кунад.

**Input**
```
sumDigit(111)
sumDigit(222)
sumDigit(333)
```
**Output**
```
3
6
9
```

##

### Task 8
Create a recursive function that takes two parameters and repeats the string n number of times. The first parameter txt is the string to be
repeated and the second parameter is the number of times the string is to be repeated.

---

Создайте рекурсивную функцию, которая принимает два параметра и повторяет строку n раз. Первый параметр txt — это повторяемая строка, а второй параметр — количество повторений этой строки.

---

Функсияи рекурсивӣ эҷод кунед, ки ду параметрро мегирад ва сатри n-ро чанд маротиба такрор мекунад. Параметри якум txt сатри такроршаванда ва параметри дуюм шумораи такрори сатр мебошад.

**Input**
```
repetition("ab", 3)
repetition("kiwi", 1)
repetition("cherry", 2)
```
**Output**
```
ababab
kiwi
cherrycherry
```


