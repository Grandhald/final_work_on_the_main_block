# Описание программы
 На вход программа получает N количество строк, добавляет их в массив и выводит массив строк, длина которых меньше или равна 3. 

 ## Описание функций программы

 ### InputedWords (string message):

 На вход функция принимает локальную переменную string **message**, которая содержит информацию для пользователя.

 Функция выводит string **message** на экран (консоль). Далее она предлагает ввести пользователю строку, которое записывается в переменную string **words**.

 В конце  **InputedWords** возращает значение переменной **words**.

 ### string[] CreateArray(string message)
 
 На вход функция принимает локальную переменную string **message**, которая содержит информацию для пользователя.

 Функция выводит string **message** на экран (консоль).

 Далее она предлагает ввести пользователю число, которое конвентируются в тип Int32 и записывается в переменную int **count**.

 Затем создается массив string [] **arrayWords** c длинной **count**. 

 После этого в цикле **for**, c условием *(i=0, i < array.Lenght, i++)*, каждому элементу массива **arrayWords** присвается значение функции **InputedWords (string message)** (см.выше).

 После всех итераций цикла функция возращает значение **arrayWords**.

 ### string[] CreateArrayLenWordsAreLessThenTree(string[] words)

 На вход функция принимает локальную переменную string [] words. 

 В начале программы создается переменная string **strWords**, в значение которой записывается пустая строка.

 Далее при помощи цикла *for* перебираются элементы массива **words**. В теле цикла осуществлятеся проверка является длина *i-ого* элемента массива **words** меньше или ровна 3:

    words[i].Lenght <= 3

При положительном результате переменой **strWords** добавляется значение *i-ого* элемента массива + *"\t"*. 

При отрицательном результате цикл переходит на следующую итерацию. 

После завершения итераций цикла переменая **strWords** проверяется на условие:

    strWord.Lenght == 0 

При положительном результате функция возращает значение 

    strWords.Split("\t")

Данная строк кода, разделяет переменную **strWords** по "\t" и из полученных подстрок создает массив. 

При отрицательном результате значение переменной **strWords** перезаписывается на срез переменной **strWords**

    strWords.Substring(0, strWords.Lenght - 1)

Делается это с целью удаления лишней табуляции. 

После этого функция возращает значение 

    strWords.Split("\t")

## Описание работы программы.

В начале идет очистка консоли с помощью команды 

    Console.Clear()

Далее создается массив string[] **arrayWords**, при помощи функции **CreateArray("Введите количество строк: ")**, длину которого указыват пользователь.

После создается переменная string[] **arrayWordlenLessTheree**, которому присвается значение функции string[] **CreateArrayLenWordsAreLessThenTree(string[] arrayWords)**. Значение функции являетя массив с элементами массива **arrayWords** длина, которых меньше или ровна 3.

Затем программа выводит оба массива 

    [arrayWords] --> [arrayWordlenLessTheree]
