using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask_5
{
    enum Axis
    {
        XOY,
        XOZ,
        YOZ
    }
    static class Shadow
    {
        public static int[,] FindShadowInCube(int[,,] cube, Axis axis)
        {
            if (cube == null)
                throw new ArgumentNullException();

            if (cube.GetLength(0) != cube.GetLength(1) || cube.GetLength(2) != cube.GetLength(1))
                throw new ArithmeticException("It is not cube!!  Size is different!!");

            foreach (var item in cube)
            {
                if (item < 0 || item > 1)
                    return null;
            }

            int[,] shadow = new int[cube.GetLength(0), cube.GetLength(0)];

            for (int i = 0; i < cube.GetLength(0); i++)
            {
                for (int j = 0; j < cube.GetLength(0); j++)
                {
                    for (int n = 0; n < cube.GetLength(0); n++)
                    {
                        if (shadow[i, j] == 1)
                            break;

                        switch (axis)
                        {
                            case Axis.XOY:
                                shadow[i, j] = cube[n, i, j];
                                break;

                            case Axis.XOZ:
                                shadow[i, j] = cube[i, j, n];
                                break;

                            case Axis.YOZ:
                                shadow[i, j] = cube[i, n, j];
                                break;
                        }
                    }
                }
            }
            return shadow;
        }
    }
}
