using System;
using System.Runtime.ConstrainedExecution;
namespace laber
{
    internal class Program
    {
        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            string asciiArt = @"
              .,-:;//;:=,
          . :H@@@MM@M#H/.,+%;,
       ,/X+ +M@@M@MM%=,-%HMMM@X/,
     -+@MM; $M@@MH+-,;XMMMM@MMMM@+-
    ;@M@@M- XM@X;. -+XXXXXHHH@M@M#@/.
  ,%MM@@MH ,@%=             .---=-=:=,.
  =@#@@@MX.,                -%HX$%%%:;
 =-./@M@M$                   .;@MMMM@MM:
 X@/ -$MM/                    . +MM@@@M$
,@M@H: :@:                    . =X#@@@@-
,@@@MMX, .                    /H- ;@M@M=
.H@@@@M@+,                    %MM+..%#$.
 /MMMM@MMH/.                  XM@MH; =;
  /%+%$XHH@$=              , .H@@@@MX,
   .=--------.           -%H.,@@@@@MX,
   .%MM@@@HHHXX$%+- .:$MMX =M@@MM%.
     =XMMM@MM@MM#H;,-+HMM@M+ /MMMX=
       =%@M@M#@$-.=$@MM@@@M; %M%=
         ,:+$+-,/H#MMMMMMM@= =,
              =++%%%%+/:-.";

            PrintAsciiArt(asciiArt);
            Console.ResetColor();
            static void PrintAsciiArt(string art)
            {
                var lines = art.Split(new[] { '\n' }, StringSplitOptions.None);
                int linesToPrint = 3;
                Random random = new Random();

                for (int i = 0; i < lines.Length; i += linesToPrint)
                {
                    for (int j = 0; j < linesToPrint && (i + j) < lines.Length; j++)
                    {
                        Console.WriteLine(lines[i + j]);
                    }

                    int delay = random.Next(100, 501);
                    Thread.Sleep(delay);
                }

                for (int i = lines.Length - (lines.Length % linesToPrint); i < lines.Length; i++)
                {
                    Console.WriteLine(lines[i]);
                }

                Thread.Sleep(100);
                Console.Clear();

            }

            //вход ................................................
            //вход ................................................

            Console.WriteLine("введтие из какой системы переводим и в какую разделёную пробелом ");
            string input = Console.ReadLine();
            string[] metodSplit =  input.Split(' ');
            int cictema =  int.Parse(metodSplit[0]);
            int l = int.Parse(metodSplit[1]);



            Console.WriteLine(" введите что преобазуем  ");
            string refrech = Console.ReadLine();









            if (cictema != 10)
            {
                Console.WriteLine("не десетичная ");
                int decemalNUm = Convert.ToInt32(refrech, cictema);
                Console.WriteLine("Ваше значение в 10: " + Convert.ToString(decemalNUm));
                string output = Convert.ToString(decemalNUm, l);
                Console.WriteLine(output);
            }
            else
            {
                Console.WriteLine("у вас десетичная ");
                string output = Convert.ToString(cictema, l);
                Console.WriteLine("ваше число в " + l + output);

            }

        }
    }
}
