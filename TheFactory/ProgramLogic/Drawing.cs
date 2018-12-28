using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProgramLogic
{
    public class Drawing
    {
        static Image _conv1;
        static Image _conv2;
        static Image _loaderFull;
        static Image _loaderEmpty;
        static Image _engImage;
        static Image _material;
        static Image _materialHalf;
        static Image _materialSmall;

        public static void DrawingConstr(Image conveyor1, Image conveyor2, Image loaderFull, Image loaderEmpty, Image engineer, Image material, Image materialHalf, Image materialSmall)
        {
            _conv1 = conveyor1;
            _conv2 = conveyor2;
            _loaderFull = loaderFull;
            _loaderEmpty = loaderEmpty;
            _engImage = engineer;
            _material = material;
            _materialHalf = materialHalf;
            _materialSmall = materialSmall;
        }

        public static void DrawState(Factory factory, Graphics g)
        {
            foreach(Conveyor conv in factory.Conveyors)
            {
                DrawConvState(conv, g);
            }

            if (factory.Engineer.Moving)
                DrawEngineer(factory.Engineer, g);

            if (factory.Loader.Moving)
                DrawLoader(factory.Loader, g);
        }

        private static void DrawEngineer(Engineer eng, Graphics g)
        {
            g.DrawImage(_engImage, eng.X, eng.Y);
        }

        private static void DrawLoader(Loader loader, Graphics g)
        {
            if (loader.IsFull)
                g.DrawImage(_loaderFull, loader.X, loader.Y);
            else
                g.DrawImage(_loaderEmpty, loader.X, loader.Y);
        }

        private static void DrawConvState(Conveyor conv, Graphics g)
        {
            if (conv.Material % 2 == 0)
            {
                g.DrawImage(_conv1, 50, conv.Y);
            }
            else
            {
                g.DrawImage(_conv2, 50, conv.Y);
            }

            if (conv.Material >= 15)
                g.DrawImage(_material, 450, conv.Y - 50);
            else
            {
                if (conv.Material < 15 && conv.Material >= 8)
                    g.DrawImage(_materialHalf, 450, conv.Y - 50);
                else
                {
                    if (conv.Material > 1)
                        g.DrawImage(_materialSmall, 450, conv.Y - 50);
                }
            }
        }
    }
}
