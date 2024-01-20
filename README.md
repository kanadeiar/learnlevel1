# TDD Level 1

Обучение по курсу GeekBrains "C# Уровень 1".

Уклон в разработку через тестирование (TDD).

## Методичка 1. C# Уровень 1. 	Введение. Базовые типы данных. Консоль. Классы и методы.

1.	Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес). В результате вся информация выводится в одну строчку:
	а) используя  склеивание;
    б) используя форматированный вывод;
    в) используя вывод со знаком $.
2.	Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h); где m — масса тела в килограммах, h — рост в метрах.
3.	а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2). Вывести результат, используя спецификатор формата .2f (с двумя знаками после запятой);
	б) *Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде метода.
4.	Написать программу обмена значениями двух переменных:
	а) с использованием третьей переменной;
    б) *без использования третьей переменной.
5.	а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
	б) *Сделать задание, только вывод организовать в центре экрана.
	в) **Сделать задание б с использованием собственных методов (например, Print(string ms, int x,int y).
6.	*Создать класс с методами, которые могут пригодиться в вашей учебе (Print, Pause).

## Методичка 2. C# Уровень 1. Управляющие конструкции

1.  Написать метод, возвращающий минимальное из трёх чисел.
2.  Написать метод подсчета количества цифр числа.
3.  С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.
4.  Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль. На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains). Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает. С помощью цикла do while ограничить ввод пароля тремя попытками.
5.  а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или всё в норме.
    б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.
6.  *Написать программу подсчета количества «хороших» чисел в диапазоне от 1 до 1 000 000 000. «Хорошим» называется число, которое делится на сумму своих цифр. Реализовать подсчёт времени выполнения программы, используя структуру DateTime.
7.  a) Разработать рекурсивный метод, который выводит на экран числа от a до b(a<b).
    б) *Разработать рекурсивный метод, который считает сумму чисел от a до b.

## Методичка 3. C# Уровень 1. Методы. От структур к объектам.

1.	а) Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры.
б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса.
в) Добавить диалог с использованием switch демонстрирующий работу класса.
2.	а)  С клавиатуры вводятся числа, пока не будет введён 0 (каждое число в новой строке). Требуется подсчитать сумму всех нечётных положительных чисел. Сами числа и сумму вывести на экран, используя tryParse.
3.	*Описать класс дробей — рациональных чисел, являющихся отношением двух целых чисел. Предусмотреть методы сложения, вычитания, умножения и деления дробей. Написать программу, демонстрирующую все разработанные элементы класса.
* Добавить свойства типа int для доступа к числителю и знаменателю;
* Добавить свойство типа double только на чтение, чтобы получить десятичную дробь числа;
** Добавить проверку, чтобы знаменатель не равнялся 0. Выбрасывать исключение ArgumentException("Знаменатель не может быть равен 0");
*** Добавить упрощение дробей.
    
## Методичка 4. C# Уровень 1. Массивы. Текстовые файлы.

1.  Дан  целочисленный  массив  из 20 элементов.  Элементы  массива  могут принимать  целые  значения  от –10 000 до 10 000 включительно. Заполнить случайными числами.  Написать программу, позволяющую найти и вывести количество пар элементов массива, в которых только одно число делится на 3. В данной задаче под парой подразумевается два подряд идущих элемента массива. Например, для массива из пяти элементов: 6; 2; 9; –3; 6 ответ — 2. 
2.  Реализуйте задачу 1 в виде статического класса StaticClass;
а)  Класс должен содержать статический метод, который принимает на вход массив и решает задачу 1;
б)  *Добавьте статический метод для считывания массива из текстового файла. Метод должен возвращать массив целых чисел;
в)  **Добавьте обработку ситуации отсутствия файла на диске.
3.  а) Дописать класс для работы с одномерным массивом. Реализовать конструктор, создающий массив определенного размера и заполняющий массив числами от начального значения с заданным шагом. Создать свойство Sum, которое возвращает сумму элементов массива, метод Inverse, возвращающий новый массив с измененными знаками у всех элементов массива (старый массив, остается без изменений),  метод Multi, умножающий каждый элемент массива на определённое число, свойство MaxCount, возвращающее количество максимальных элементов. 
б)  **Создать библиотеку содержащую класс для работы с массивом. Продемонстрировать работу библиотеки
е)  ***Подсчитать частоту вхождения каждого элемента в массив (коллекция Dictionary<int,int>)
4.  Решить задачу с логинами из урока 2, только логины и пароли считать из файла в массив. Создайте структуру Account, содержащую Login и Password.
5.  *а) Реализовать библиотеку с классом для работы с двумерным массивом. Реализовать конструктор, заполняющий массив случайными числами. Создать методы, которые возвращают сумму всех элементов массива, сумму всех элементов массива больше заданного, свойство, возвращающее минимальный элемент массива, свойство, возвращающее максимальный элемент массива, метод, возвращающий номер максимального элемента массива (через параметры, используя модификатор ref или out).
**б) Добавить конструктор и методы, которые загружают данные из файла и записывают данные в файл.
**в) Обработать возможные исключительные ситуации при работе с файлами.

## Методичка 5. C# Уровень 1. Символы, строки, регулярные выражения.

1.	Создать программу, которая будет проверять корректность ввода логина. Корректным логином будет строка от 2 до 10 символов, содержащая только буквы латинского алфавита или цифры, при этом цифра не может быть первой:
а) без использования регулярных выражений;
б) **с использованием регулярных выражений.
2.	Разработать статический класс Message, содержащий следующие статические методы для обработки текста:
а) Вывести только те слова сообщения,  которые содержат не более n букв.
б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
в) Найти самое длинное слово сообщения.
г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
д) ***Создать метод, который производит частотный анализ текста. В качестве параметра в него передается массив слов и текст, в качестве результата метод возвращает сколько раз каждое из слов массива входит в этот текст. Здесь требуется использовать класс Dictionary.
3.	*Для двух строк написать метод, определяющий, является ли одна строка перестановкой другой.
	Например:
	badc являются перестановкой abcd.
4.	*Задача ЕГЭ. 
	На вход программе подаются сведения о сдаче экзаменов учениками 9-х классов некоторой средней школы. В первой строке сообщается количество учеников N, которое не меньше 10, но не превосходит 100, каждая из следующих N строк имеет следующий формат:
	<Фамилия> <Имя> <оценки>,
	где <Фамилия> — строка, состоящая не более чем из 20 символов, <Имя> — строка, состоящая не более чем из 15 символов, <оценки> — через пробел три целых числа, соответствующие оценкам по пятибалльной системе. <Фамилия> и <Имя>, а также <Имя> и <оценки> разделены одним пробелом. Пример входной строки:
	Иванов Петр 4 5 3
	Требуется написать как можно более эффективную программу, которая будет выводить на экран фамилии и имена трёх худших по среднему баллу учеников. Если среди остальных есть ученики, набравшие тот же средний балл, что и один из трёх худших, следует вывести и их фамилии и имена.
	Достаточно решить 2 задачи. Старайтесь разбивать программы на подпрограммы. Переписывайте в начало программы условие и свою фамилию. Все программы сделать в одном решении. Для решения задач используйте неизменяемые строки (string)

## Методичка 6. C# Уровень 1. Делегаты, файлы, коллекции.

1.	Изменить программу вывода таблицы функции так, чтобы можно было передавать функции типа double (double, double). Продемонстрировать работу на функции с функцией a*x^2 и функцией a*sin(x).
2.	Модифицировать программу нахождения минимума функции так, чтобы можно было передавать функцию в виде делегата. 
	а) Сделать меню с различными функциями и представить пользователю выбор, для какой функции и на каком отрезке находить минимум. Использовать массив (или список) делегатов, в котором хранятся различные функции.
	б) *Переделать функцию Load, чтобы она возвращала массив считанных значений. Пусть она возвращает минимум через параметр (с использованием модификатора out). 
3.	Переделать программу Пример использования коллекций для решения следующих задач:
	а) Подсчитать количество студентов учащихся на 5 и 6 курсах;
	б) подсчитать сколько студентов в возрасте от 18 до 20 лет на каком курсе учатся (*частотный массив);
	в) отсортировать список по возрасту студента;
	г) *отсортировать список по курсу и возрасту студента;
4.	**Считайте файл различными способами. Смотрите “Пример записи файла различными способами”. Создайте методы, которые возвращают массив byte (FileStream, BufferedStream), строку для StreamReader и массив int для BinaryReader.

## Методичка 7. C# Уровень 1. Введение в Windows Forms

1.	а) Добавить в программу «Удвоитель» подсчёт количества отданных команд удвоителю.
	б) Добавить меню и команду «Играть». При нажатии появляется сообщение, какое число должен получить игрок. Игрок должен получить это число за минимальное количество ходов.
	в) *Добавить кнопку «Отменить», которая отменяет последние ходы. Используйте обобщенный класс Stack.
	Вся логика игры должна быть реализована в классе с удвоителем.
2.	Используя Windows Forms, разработать игру «Угадай число». Компьютер загадывает число от 1 до 100, а человек пытается его угадать за минимальное число попыток. Компьютер говорит, больше или меньше загаданное число введенного.  
	a) Для ввода данных от человека используется элемент TextBox;
	б) **Реализовать отдельную форму c TextBox для ввода числа.
	
## Методичка 8. C# Уровень 1. Программирование “по-взрослому”

1.	С помощью рефлексии выведите все свойства структуры DateTime
2.	Создайте простую форму на котором свяжите свойство Text элемента TextBox со свойством Value элемента NumericUpDown
3.	а) Создать приложение, показанное на уроке, добавив в него защиту от возможных ошибок (не создана база данных, обращение к несуществующему вопросу, открытие слишком большого файла и т.д.).
	б) Изменить интерфейс программы, увеличив шрифт, поменяв цвет элементов и добавив другие «косметические» улучшения на свое усмотрение.
	в) Добавить в приложение меню «О программе» с информацией о программе (автор, версия, авторские права и др.).
	г)* Добавить пункт меню Save As, в котором можно выбрать имя для сохранения базы данных (элемент SaveFileDialog).
4.	*Используя полученные знания и класс TrueFalse в качестве шаблона, разработать собственную утилиту хранения данных (Например: Дни рождения, Траты, Напоминалка, Английские слова и другие).
5.	**Написать программу-преобразователь из CSV в XML-файл с информацией о студентах (6 урок).
6.	Игра "Верю - не верю".
7.	Получение прогноза погоды с API.
