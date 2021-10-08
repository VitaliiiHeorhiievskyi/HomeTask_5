using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask_5
{
    static class MyPath
    {
        public static string GetFileNameWithoutExtension(string path)
        {
            if (path == null)
                throw new ArgumentNullException();

            return path.Split("\\")[path.Split("\\").Length - 1].Split(".")[0];
        }

        public static string GetPathRoot(string path)
        {
            if (path == null)
                throw new ArgumentNullException();

            return path.Split("\\")[0]+"\\";
        }
    }
}
