using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ispan_dotNetHw_printStar
{
    public class DrawLib
    {
        // 先寫下正常的程式碼
        // 再來找出共通點寫委派

        public delegate string DrawFunHandler(int rows, int rowIndex);

        public DrawFunHandler LeftStarMethod {
            get {
                return new DrawFunHandler(LeftStar);
            }
        }
        public DrawFunHandler RightStarMethod
        {
            get
            {
                return new DrawFunHandler(RightStar);
            }
        }
        public DrawFunHandler MidStarMethod
        {
            get
            {
                return new DrawFunHandler(MidStar);
            }
        }
        private string LeftStar(int rows,int rowIndex)
        {
            return $"{new string('＊', rowIndex)}\n";
        }
        private string RightStar(int rows, int rowIndex)
        {
            string result = string.Empty;
            int temp = rows - rowIndex;
            result += new string('　', temp);
            result += new string('＊', rowIndex); // "" 是string，''是char
            result += "\n";
            return result;
        }
        private string MidStar(int rows, int rowIndex)
        {
            string result = string.Empty;
            int temp = rows - rowIndex;
            result += new string('　', temp);
            result += new string('＊', 2 * (rowIndex - 1) + 1); // "" 是string，''是char
            result += "\n";
            return result;
        }
        public string DrawLogic(int rows, DrawFunHandler handler)
        {
            string result = String.Empty;
            for (int i = 1; i <= rows; i++)
            {
                // OperationHandler handler = new OperationHandler(Add);
                // handler = LeftStar;
                result += handler(rows, i);
            }
            return result;
        }
        public string LeftStar(int rows)
        {
            string result = String.Empty;
            for (int i = 1; i <= rows; i++)
            {
                result += new string('＊', i); // "" 是string，''是char
                result += "\n";
            }
            return result;
        }

        public string RightStar(int rows)
        {
            string result = String.Empty;
            for (int i = 1; i <= rows; i++)
            {
                int temp = rows - i;
                result += new string('　', temp);
                result += new string('＊', i); // "" 是string，''是char
                result += "\n";
            }
            return result;
        }

        public string MidStar(int rows)
        {
            string result = String.Empty;
            for (int i = 1; i <= rows; i++)
            {
                int temp = rows - i;
                result += new string('　', temp);
                result += new string('＊', 2 * (i - 1) + 1); // "" 是string，''是char
                result += "\n";
            }
            return result;
        }
    }
    /*
    public class DrawLib_先寫下正常的程式碼
    {
        // 先寫下正常的程式碼
        // 再來找出共通點寫委派
        public string LeftStar(int rows)
        {
            string result = String.Empty;
            for (int i = 1; i <= rows; i++)
            {
                result += new string('＊', i); // "" 是string，''是char
                result += "\n";
            }
            return result;
        }

        public string RightStar(int rows)
        {
            string result = String.Empty;
            for (int i = 1; i <= rows; i++)
            {
                int temp = rows - i;
                result += new string('　', temp);
                result += new string('＊', i); // "" 是string，''是char
                result += "\n";
            }
            return result;
        }

        public string MidStar(int rows)
        {
            string result = String.Empty;
            for (int i = 1; i <= rows; i++)
            {
                int temp = rows - i;
                result += new string('　', temp);
                result += new string('＊', 2 * (i - 1) + 1); // "" 是string，''是char
                result += "\n";
            }
            return result;
        }
    }
    */
}
