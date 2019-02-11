using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintStickerCSharpConsole
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            if (args != null && args.Length == 1)
            {
                string path = args[0];
                FN.PrintStickerFromMnf(path);
            }
        }
    }
}
