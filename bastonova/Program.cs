using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SunshineConsole;
using OpenTK.Graphics;
using OpenTK.Input;

namespace bastonova
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleWindow console = new ConsoleWindow(16, 40, "Sunshine Console Hello World");
            int x = 0;
            int y = 0;
            while (true)
            {
                x++;
                if(x > 16)
                {
                    x = 0;
                    y++;
                }
                console.WindowUpdate();
                console.Write(x, y, '+', Color4.Red,new Color4(0f,0f,0f,0f));
            }
        }
    }
}
