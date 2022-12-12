# Задача 43 #

 Написать программу, которая найдёт точку пересечения двух прямых 
 
 Уравнение: y1 = k1 * x + b1, y2 = k2 * x + b2

 Значения b1, k1, b2 и k2 задаются пользователем

 Пример : b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


 ## -=Пересечение=- ##

 Нам даны два уравнения прямых
 y1 = k1 * x + b1
 y2 = k2 * x + b2

 Если прямые пересекаются то :
 y1 = y2 

 Решим через систему уравнений с данными, которые указаны в примере 

 {y1 = 5x + 2 
 {y2 = 9x + 2

 1. Находим x 
 5x + 2 = 9x + 4 // Так как y1 = y2

 5x - 9x = 4 - 2 // Переносим 9x в левую часть, а 2 в правую часть и меняем знаки

 4x = 2 // Получаем вот такую формулу

 x = 2/-4 // Переносим 4 в правую часть

 x = -0,5 // Находим X

2. Подставляем х в нашу формулу

 y1 = 5 (-0,5) + 2 = -0,5
 y2 = 9 (-0,5) + 4 = -0,5

 y1 = y2 - Да!

 Значит прямые пересекаются в координатах (-0,5 ; -0,5)