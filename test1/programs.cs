using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace test1
{
    public class programs
    {
       
        

        public void allmethods(string namamethod)
        {


            /* var methods = new List<string>();   
             methods.Add(namamethod);
             methods.Add("omid");
             methods.Add("kh");
             methods.Add("r");
             methods.Add("1400/10/05");
             foreach (var method in methods)
             {
                 Console.WriteLine(method);
             }*/
           string  ch = Convert.ToString(namamethod);
            switch (ch)
            {
                case "1": soalAval(); break;
                case "2": soaldovom(); break;
                case "3": soalsevom(); break;
                case "4": soalcharom(); break;
                case "5": soalpanjom(); break;
                case "6": soalsheshom(); break;
                case "7": soalhaftom(); break;
                case "9": soalnohom(); break;
                case "sheklZarb": sheklZarb(); break;
                case "shekl": shekl(); break;

            }
        }
        public int zarb()
        {


            Console.WriteLine("please enter number 1");
            int num1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("please enter number 2");
            int num2 = Int32.Parse(Console.ReadLine());
            return num1 * num2;

        }//دو عدد را بگیرد و حاصل ضرب آنها را نمایش دهد
        public void jam()

        {

            int a, b;
            double ja;
            Char ch;
            Console.Write("Enter Number one: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("------");
            Console.Write("Enter Number tow: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("------");
            Console.Write("Select Steatment * or / or + or – or % ? ");
            ch = Convert.ToChar(Console.ReadLine());
            Console.Clear();
            switch (ch)
            {
                case '*':
                    ja = a * b;
                    break;
                case '+':
                    ja = a + b;
                    break;
                case '-':
                    ja = a - b;
                    break;
                case '/':
                    ja = a / (10 / b);
                    break;
                case '%':
                    ja = a % b;
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Error For Statement !!");
                    ja = 0;
                    break;
            }



            Console.Write(a);
            Console.Write(ch);
            Console.Write(b);
            Console.Write(" = ");
            Console.Write(ja); Console.ReadKey();


        }//دوعدد صحیح و عملگر را بگیرد وحاصل را نمایش دهد
        public void matrix()

        {
            int[,] a = new int[5, 6];
            int i, j;
            Console.WriteLine(" Enter Data For Matris: ");
            for (i = 0; i < 5; i++) // سطر
                for (j = 0; j < 6; j++) // ستون
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Matris Is ");
            for (i = 0; i < 5; i++) // سطر
            {
                for (j = 0; j < 6; j++) // ستون
                {
                    Console.Write(a[i, j]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }//خواندن اعداد یک ماتریس 2 بعدی و چاپ مجدد انها
        public string addWithMatrix()
        {
            int[] a = new int[10];
            int sum = 0, i;
            Console.WriteLine("Enter 10 int Number= ");
            for (i = 0; i < 10; i++)
                a[i] = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i < 10; i++)
                sum += a[i];
            Console.WriteLine(sum);
            string sum3 = Convert.ToString(sum);
            return sum3;
            Console.ReadKey();
        }//10 عدد بخواند در یک آرایه ی 1 بعدی ذخیره نماید و حاصل جمع آنها را نمایش دهد
        public void rePrint()//پنج عدد را از ورودی بگیرد و دوباره چاپ کند
        {
            int[] mynumber = new int[5];
            for (int i = 0; i < 5; i++)
            {
                System.Console.WriteLine(" number " + i + " = ");

                mynumber[i] = Int32.Parse(Console.ReadLine());
            }
            for (int i = 0; i < 5; i++)
            {
                System.Console.WriteLine(" number " + i + " = " + mynumber[i]);


            }
        }
        public void shekl()
        {
            int tedad = 0;
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    if ( i + j == 7)
                    {
                        System.Console.WriteLine("i={0} and j={1}",i,j) ;
                        tedad++;
                    }      
                }
                
            }
            System.Console.WriteLine("Tedad={0}", tedad);
        }
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public void soalAval()// سوال اول مکتب شریف
        {

            Console.WriteLine("please enter number 1");
            int num1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("please enter number 2");
            int num2 = Int32.Parse(Console.ReadLine());
            int hasel = 0;
            hasel = num1 / 2;
            for (int i = 1; i <= num2 - 1; i++)
            {
                hasel = hasel / 2;

            }
            Console.WriteLine("hasel baraba ast ba:{0}", hasel);

        }
        public void soaldovom()// سوال دوم مکتب شریف
        {
            Console.WriteLine(" tarikh tavalod khood ra vared koonid ");
            string num1 = Console.ReadLine();
            int num = num1.Length;

            string sal = num1.Substring(0, 2);
            string mah = num1.Substring(2, 2);
            string roz = num1.Substring(4, 2);
            System.Console.WriteLine("saal:{0} ", sal);
            System.Console.WriteLine("maah:{0} ", mah);
            System.Console.WriteLine("rooz:{0} ", roz);




        }
        public void soalsevom()//سوال سوم مکتب شریف
        {
            int a, b;
            double ja;
            Char ch;
            Console.Write("Enter Number one: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("------");
            Console.Write("Select Steatment * or / or + or – or % ? ");
            ch = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("------");
            Console.Write("Enter Number tow: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("------");
           
          //  Console.Clear();
            switch (ch)
            {
                case '*':
                    ja = a * b;
                    break;
                case '+':
                    ja = a + b;
                    break;
                case '-':
                    ja = a - b;
                    break;
                case '/':
                    ja = a /  b;
                    break;
                case '%':
                    ja = a % b;
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Error For Statement !!");
                    ja = 0;
                    break;
            }
            Console.WriteLine("hasel barabar ast ba:   {0}",ja);

        }
        public void soalcharom()//سوال چهارم مکتب شریف
        {
            
                Console.WriteLine("Enter your Number= ");
              int aa=  Convert.ToInt32(Console.ReadLine());
                int[] aray = new int[aa];
                int sum = 0;
                
                for (int i = 0; i < aa; i++)
                    aray[i] = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < aa; i++) sum += aray[i];//جمع
            int max = aray[0];
            for (int i = 0; i < aa; i++)//بزرگترین عدد
            {
              if (aray[i] > max) max = aray[i];
            }
            int min = aray[0];
            for (int i = 0; i < aa; i++)// کوچکترین عدد
            {
                if (aray[i] < min) min = aray[i];
            }
            Console.WriteLine("max=  {0}",max);
            Console.WriteLine("min=  {0}", min);
            Console.WriteLine("AVG=  {0}", sum/aa);//میاتگین
            Console.ReadKey();

            

        }
        public void soalpanjom()//سوال پنجم مکتب شریف1
        {
            Console.WriteLine("Enter  your Number= ");
            string num = Console.ReadLine();
            char[] chars = num.ToCharArray();
            Array.Reverse(chars);
            string revers = "";
            for (int i = 0; i <chars.Length; i++)
            {
                revers=revers+ chars[i];    

            }
            
            if (num ==revers) Console.WriteLine("yes");
            else Console.WriteLine("No");

        }
        public void soalsheshom()//1سوال ششم مکتب شریف
        {
            int num = Int32.Parse(Console.ReadLine());
            int ll = num;
            for (var j = 1; j <= ll; j++)
            {
                string s = "";
                for (var a = ll; a >= j; a--)
                {
                    s = s + " ";
                }
                for (var i = 1; i <= j; i++)
                {
                    s = s + " *";
                }
                Console.WriteLine(s);
            }
            for (var j = 1; j <= ll - 1; j++)
            {
                string s = "";

                for (var i = 1; i <= j + 1; i++)
                {
                    s = s + " ";
                }

                for (var a = ll; a > j; a--)
                {
                    s = s + " *";
                }
                Console.WriteLine(s);
            }

            Console.ReadLine();
        }
        public void soalhaftom()//سوال هفتم مکتب شریف
        {
           
            Console.Write("Enter Your Characters: ");
           string  ch1 = Console.ReadLine();
            char[] ch2 = ch1.ToCharArray();
            string CH3= "";
            int tedad = 0;
            for (int i = 0; i < ch2.Length; i++)
            {
               CH3 =Convert.ToString(ch2[i]);
                switch (CH3)
                {
                    case "K":
                        tedad++;
                        break;
                    case "C":
                        tedad++;
                        break;
                    case "Y":
                        tedad++;
                        break;
                    case "M":
                       tedad++;
                        break;
                    case "L":
                        tedad++;
                        break;
                    case "X":
                        tedad++;
                        break;
                    case "T":
                        tedad++;
                        break;
                    case "N":
                        tedad++;
                        break;
                   
                }

            }
            
           



            Console.Write(tedad);
           

        }
        public void soalnohom()//سوال نهم مکتب شریف
        {
            Console.WriteLine("lotfan tedad mazhik ha ra vared konid...");
            int mazhik = Int32.Parse(Console.ReadLine());
            Console.WriteLine("lotfan Rang ha ra vared konid...");
            int[] tedaad = new int[mazhik];
            int max = 0;
            int nrang = 0;
            for (int  i= 0;  i<mazhik; i++)
            {
                tedaad[i]= Convert.ToInt32(Console.ReadLine());
            }
            
            for (int i = 0; i <mazhik; i++)
            {
                
                int shomarande = 0; 
                for (int j = 0; j < mazhik; j++)
                {
                    if (tedaad[i] == tedaad[j]) shomarande++;
                }
                if (shomarande > max)
                {
                 max =shomarande;
                    nrang = tedaad[i];

                }
                   
            }
            Console.WriteLine("{0}=جواب",nrang);
        }
        ///////////////////////////////////////////////////تمرین های سی شارپ سری //////////////////////////////////////////////////////////////////
        public void sheklZarb()
        {
            ////////top
            Console.WriteLine("Please inter you namber:  ");
            int maz = Int32.Parse(Console.ReadLine());
            for (int j =maz; j > 0; j--)
            {
                string Space1 = "";
                for (int i = maz; i > j; i--)
                {
                    Space1 = Space1 + " ";
                }
                Space1 = Space1 + "X";
                string Space = "";
                for (int m = 0; m < j; m++)
                {
                    Space = Space + "  ";
                }
                Space = Space + "X";
                Console.WriteLine(Space1 + Space);
            }
            //////DOWN
            for (int j = maz; j >= 0; j--)
            {
                string Space1 = "";
                for (int i = 0; i < j; i++)
                {
                    Space1 = Space1 + " ";
                }
                Space1 = Space1 + "X";
                string Space = "";
                for (int m = maz; m > j; m--)
                {
                    Space = Space + "  ";
                }
                Space = Space + "X";
                Console.WriteLine(Space1 + Space);
            }
            Console.ReadLine();
        }
    }
}