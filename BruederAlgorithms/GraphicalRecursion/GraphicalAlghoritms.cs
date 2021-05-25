using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace BruederAlgorithms.GraphicalRecursion
{
    public class GraphicalAlghoritms : Graphical
    {
        public GraphicalAlghoritms(int sizeW, int sizeH, string Name = "test") : base(sizeW, sizeH, Name) { }

        //функция зарисовки фрактала
        public void DrawFractalAlghoritm()
        {
            // при каждой итерации, вычисляется znew = zold² + С
            // вещественная  и мнимая части постоянной C
            double cRe, cIm;
            // вещественная и мнимая части старой и новой
            double newRe, newIm, oldRe, oldIm;
            // Можно увеличивать и изменять положение
            double zoom = 1, moveX = 0, moveY = 0;
            //Определяем после какого числа итераций функция должна прекратить свою работу
            int maxIterations = 300;

            //выбираем несколько значений константы С, это определяет форму фрактала         Жюлиа
            cRe = -0.70176;
            cIm = -0.3842;

            //"перебираем" каждый пиксель
            for (int x = 0; x < this.Wight; x++)
                for (int y = 0; y < this.Height; y++)
                {
                    //вычисляется реальная и мнимая части числа z
                    //на основе расположения пикселей,масштабирования и значения позиции
                    newRe = 1.5 * (x - this.Wight / 2) / (0.5 * zoom * this.Wight) + moveX;
                    newIm = (y - this.Height / 2) / (0.5 * zoom * this.Height) + moveY;

                    int i; //i представляет собой число итераций 

                    //начинается процесс итерации
                    for (i = 0; i < maxIterations; i++)
                    {
                        //Запоминаем значение предыдущей итерации
                        oldRe = newRe;
                        oldIm = newIm;

                        // в текущей итерации вычисляются действительная и мнимая части 
                        newRe = oldRe * oldRe - oldIm * oldIm + cRe;
                        newIm = 2 * oldRe * oldIm + cIm;

                        // если точка находится вне круга с радиусом 2 - прерываемся
                        if ((newRe * newRe + newIm * newIm) > 4) break;
                    }

                    //определяем цвета
                    Pen pen = new Pen(Color.Black, 1);
                    pen.Color = Color.FromArgb(255, (i * 9) % 255, 0, (i * 9) % 255);
                    
                    //рисуем пиксель
                    using (Graphics g = Graphics.FromImage(this.image))
                    {
                        g.DrawRectangle(pen, x, y, 1, 1);
                    }
                }
        }

        public void DrawRectangleAlghoritm(int x, int y, int wight = 200)
        {
            Pen pen = new Pen(Color.Red, 2);

            if (x > 10 && y > 10 && wight > 50)
            {
                using (Graphics g = Graphics.FromImage(this.image))
                {
                    g.DrawRectangle(pen, x + wight, y, wight / 2, wight / 2);
                    g.DrawRectangle(pen, x, y + wight, wight / 2, wight / 2);
                    g.DrawRectangle(pen, x - wight, y, wight / 2, wight / 2);
                    g.DrawRectangle(pen, x, y - wight, wight / 2, wight / 2);
                }

                DrawRectangleAlghoritm(x - wight + wight / 10, y + wight / 10, wight / 2);
                DrawRectangleAlghoritm(x + wight + wight / 10, y + wight / 10, wight / 2);
                DrawRectangleAlghoritm(x + wight / 10, y + wight + wight / 10, wight / 2);
                DrawRectangleAlghoritm(x + wight / 10, y - wight + wight / 10, wight / 2);
            }
        }
    }
}
