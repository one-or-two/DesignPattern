using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            #region +版本1
            //Console.Write("请输入数字A：");
            //string A = Console.ReadLine();
            //Console.Write("请选择运算符号（+、-、*、/）");
            //string B = Console.ReadLine();
            //Console.Write("请输入数字B：");
            //string C = Console.ReadLine();
            //string D = "";
            //if (B == "+")
            //    D = Convert.ToString(Convert.ToDouble(A) + Convert.ToDouble(C));
            //if (B == "-")
            //    D = Convert.ToString(Convert.ToDouble(A) - Convert.ToDouble(C));
            //if (B == "*")
            //    D = Convert.ToString(Convert.ToDouble(A)*Convert.ToDouble(C));
            //if (B == "/")
            //    D = Convert.ToString(Convert.ToDouble(A)/Convert.ToDouble(C));
            //Console.WriteLine("结果是："+D);
            #endregion
            #region +版本2
            try
            {
                Console.WriteLine("请输入第一个数字：");
                var inputNumberA = Console.ReadLine();
                Console.WriteLine("请输入运算符序号：1【+】，2【-】，3【*】，4【/】");
                var inputOperate = Console.ReadLine();
                Console.WriteLine("请输入第二个数字：");
                var inputNumberB = Console.ReadLine();
                var computeResult = "";
                switch (Convert.ToInt32(inputOperate))
                {
                    case 1:
                        computeResult = Convert.ToString(Convert.ToDouble(inputNumberA) + Convert.ToDouble(inputNumberB));
                        break;
                    case 2:
                        computeResult = Convert.ToString(Convert.ToDouble(inputNumberA) - Convert.ToDouble(inputNumberB));
                        break;
                    case 3:
                        computeResult = Convert.ToString(Convert.ToDouble(inputNumberA) * Convert.ToDouble(inputNumberB));
                        break;
                    case 4:
                        if (inputNumberB != "0")
                            computeResult = Convert.ToString(Convert.ToDouble(inputNumberA) / Convert.ToDouble(inputNumberB));
                        else
                            computeResult = "除数不能为0";
                        break;
                }
                Console.WriteLine("结果是：" + computeResult);
                Console.ReadLine();
            }
            catch(Exception exception)
            {
                Console.WriteLine("您的输入有错："+exception.Message);
            }
           
            #endregion
            #region +版本3

            #endregion
        }
    }
}
