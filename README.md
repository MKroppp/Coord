# Coord
1. Перехід між системами координат.  
   ![Скрiншот 1](https://github.com/MKroppp/Coord/blob/main/Screenshots/1.png)
   Програма здійснює перехід із декартової системи координат у полярну і навпаки. Для декартових координат були задані точки з конкретними значеннями (x, y), і за допомогою функції з відповідними формулами здійснено перехід з декартової системи в полярну. Як результат - отримання значень для радіуса-відстані (r) та азимута (theta) для полярної системи координат. Далі вже з наявних значень (r, theta) здійснено перехід із полярної системи назад у декартову.  
   Результат роботи програми:  
    ![Скрiншот 2](https://github.com/MKroppp/Coord/blob/main/Screenshots/2.png)  
   
   ![Скрiншот 3](https://github.com/MKroppp/Coord/blob/main/Screenshots/3.png)
   Програма здійснює перехід із декартової системи координат у сферичну і навпаки. Для декартових координат були задані точки з конкретними значеннями (x, y, z), і за допомогою функції з відповідними формулами здійснено перехід з декартової системи в сферичну. Результат - отримання значень для відстані від початку координат (r), азимутального кута (theta) та полярного кута (phi). Далі вже з наявних значень (r, theta, phi) здійснено перехід із сферичної системи назад у декартову.  
   Результат роботи програми:  
   ![Скрiншот 4](https://github.com/MKroppp/Coord/blob/main/Screenshots/4.png).  
   
3. Розрахунок відстаней у сферичній системі координат.  
   ![Скрiншот 5](https://github.com/MKroppp/Coord/blob/main/Screenshots/5.png)  
   ![Скрiншот 6](https://github.com/MKroppp/Coord/blob/main/Screenshots/6.png)
   Програма обчислює відстань між точками. Функції d2 і d3 обчислюють відстань у декартовій системі координат у двовимірному і тривимірному просторі відповідно. Оскільки функція d2 рахує відстань між двома точками в двовимірному просторі, то використовуються значення для двох точок (x1, y1) і (x2, y2). d3 считает расстояние между двумя точками в трехмерном пространстве, используются значения для двух точек (x1, y1, z1) и (x2, y2, z2). Функція pd обчислює відстань у полярній системі координат у двовимірному просторі, і використовує значення відстаней від початку координат до кожної з точок (r1, r2) та азимути точок (theta1, theta2). Функції sd обчислюють відстань у сферичній системі координат. Перша функція рахує через об'єм сфери тому використовує значення для радіусів точок (r1, r2), азимутальні кути точок (theta1, theta2) і полярні кути точок (phi1, phi2). Друга функція sd рахує відстань по поверхні сфери, тому замість радіуса точок використовується радіус сфери (r).  
   Результат роботи програми:
   ![Скрiншот 7](https://github.com/MKroppp/Coord/blob/main/Screenshots/7.png)
   
5. Бенчмарки продуктивності.  
   ![Скрiншот 8](https://github.com/MKroppp/Coord/blob/main/Screenshots/8.png)  
   ![Скрiншот 9](https://github.com/MKroppp/Coord/blob/main/Screenshots/9.png)  
   ![Скрiншот 10](https://github.com/MKroppp/Coord/blob/main/Screenshots/10.png)  
   Програма генерує масиви координат у кожній системі координат, розраховує відстань між точками в кожній системі і як результат повертає час, витрачений на обчислення в кожній системі координат.  
   Результат:
   ![11](https://github.com/MKroppp/Coord/blob/main/Screenshots/11.png)
   У двовимірному просторі декартова система координат виявилася трохи швидшою за полярну (24 мс проти 26 мс). У тривимірному просторі декартова система система координат виявилася значно швидшою за сферичну (21 мс проти 36 мс).
   Декартова система показала найбільшу ефективність у розрахунках як у двовимірному так і в тривимірному просторах. Полярна система трохи менш ефективна, ніж декартова система у 2D, але різниця невелика.
