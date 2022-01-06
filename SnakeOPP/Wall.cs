using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeOPP
{
    class Walls
    {
        List<Figure> wallList;

        public Walls(int mapWidth, int mapHeight)
        {
            wallList = new List<Figure>();
            HorizontaLine top = new HorizontaLine(0, 80, 0, '#');
            VerticalLine left = new VerticalLine(0, 25, 0, '!');
            HorizontaLine bottom = new HorizontaLine(0, 80, 25, '$');
            VerticalLine right = new VerticalLine(0, 25, 80, '!');
            HorizontaLine obstacle = new HorizontaLine(15, 35, 10, '%');
            HorizontaLine obstacle1 = new HorizontaLine(3, 5, 10, '%');



            wallList.Add(top);
            wallList.Add(left);
            wallList.Add(bottom);
            wallList.Add(right);
            wallList.Add(obstacle);
            wallList.Add(obstacle1);
        }
        public void Draw()
        {
            foreach (var wall in wallList)
            {
                wall.Draw();
            }
        }
        public bool IsHit(Figure figure)
        {
            foreach (var wall in wallList)
            {
                if (wall.IsHit(figure))
                {
                    return true;
                }
            }
            return false;
            Console.ForegroundColor = ConsoleColor.Red;
        }
    }
}