﻿Console.Clear();
//Console.SetCursorPosition(10, 4);
//Console.WriteLine("+");
int xa = 15;
int ya = 10;
int xb = 1;
int yb = 10;
int xc = 30;
int yc = 10;
Console.SetCursorPosition(xa, ya);
Console.WriteLine ("*");

Console.SetCursorPosition(xb, yb);
Console.WriteLine ("*");

Console.SetCursorPosition(xc, yc);
Console.WriteLine ("*");
 int x = xa, y = xb;
 int count = 0;

while(count<10)
{
    int what = new Random().Next(0, 10);

    if(what == 0)
    {
        x = (x + xa)/2;
        y = (ya + ya)/2;
    }
    if(what == 1)
    {
        x = (x + xb)/2;
        ya = (y + yb)/2;
    }
    if(what == 2)

    {
        x = (x + xc)/2;
        y = (y + yc)/2;
    }
    
    Console.SetCursorPosition(x, y);
    Console.WriteLine("*");
    count++;
}
