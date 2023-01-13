# specialization_test_work

В этом репозитории итоговая робота вводной части пакета курсов "Разработчик" GeekBrains 

Задание:
 ![Ссылка на задание:](https://gbcdn.mrgcdn.ru/uploads/asset/4283449/attachment/1251e74b703108ee483caaa98787097d.png)

 **Описание решения:**
 
 Принцип алгоритма простой:
 - получаем исходный массив строк;
 - читаем его по индексу;
 - если текущий элемент длиной 3 или менее символов, записываем его в новый массив;
 - выводим новый массив.

 Единственную сложность составляет то, что заранее неизвестно, какой длины будет новый массив. Решила склеить все в одну строку через пробел, а после разделить (по тем же пробелам) и записать в массив (вроде, на лекции было что-то такое). Надеюсь, это не связано с коллекциями (пока не знаю, что это).

 *Блок-схему* решила не привязывать к C# и конкретному коду (хотя, сомневалась долго), сделала более общей.
