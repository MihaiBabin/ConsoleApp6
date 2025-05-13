namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Sezon
            //Console.WriteLine("Introduceti un numar (1-12) ");
            //int num = int.Parse(Console.ReadLine());
            //string sezon;
            //switch (num)
            //{
            //    case 1: 
            //    case 2:
            //    case 3:
            //        sezon = "Iarna";
            //        break;
            //    case 4:
            //    case 5:
            //    case 6:
            //        sezon = "Primavara";
            //        break;
            //    case 7:
            //    case 8:
            //    case 9:
            //        sezon = "Vara";
            //        break;
            //    case 10:
            //    case 11:
            //    case 12:
            //        sezon = "Iarna";
            //        break;
            //    default:
            //        sezon = "Valoare incorecta pentru numar";
            //        break;  

            //}
            //Console.WriteLine("Sezonul corespunzator pentru numarul {0} este {1} ", num, sezon);
            #endregion
            #region IdentifyType
            //void IdentifyType(object obj)
            //{
            //   switch (obj)
            //   {
            //       case int i:
            //           Console.WriteLine($"este un int : {i}");
            //           break;
            //       case double d:
            //           Console.WriteLine($"este un double : {d}");
            //           break;
            //       case string s:
            //           Console.WriteLine($"este un string : {s}");
            //           break;
            //       case bool b:
            //           Console.WriteLine($"este un bool : {b}");
            //           break;
            //       default:
            //           Console.WriteLine("Este un tip necunoscut");
            //           break;
            //   }
            //}
            #endregion
            #region Aria 
            //Console.WriteLine("Introduceti forma");
            //Console.WriteLine("1- Cercul");
            //Console.WriteLine("2- Triunghi");
            //Console.WriteLine("3- Dreptunghi");
            //double aria;
            //int forma = int.Parse(Console.ReadLine());
            //switch (forma)
            //{
            //    case 1:
            //        Console.WriteLine("Introduceti raza cercului");
            //        double raza = double.Parse(Console.ReadLine());
            //        aria = raza * raza * Math.PI;
            //        Console.WriteLine($"Aria cercului este {aria}");
            //        break;
            //    case 2:
            //        Console.WriteLine("Introduceti baza triunghiului");
            //        double baza = double.Parse(Console.ReadLine());
            //        Console.WriteLine("Introduceti inaltimea triunghiului");
            //        double inaltimea = double.Parse(Console.ReadLine());
            //        aria = (baza * inaltimea) / 2;
            //        Console.WriteLine($"Aria triunghiului este {aria} ");
            //        break;
            //    case 3:
            //        Console.WriteLine("Introduceti latura1 a dreptunghiului");
            //        double l1 = double.Parse(Console.ReadLine());
            //        Console.WriteLine("Introduceti latura2 a dreptunghiului");
            //        double l2 = double.Parse(Console.ReadLine());
            //        aria = l1 * l2;
            //        Console.WriteLine($"Aria dreptunghiului este {aria} ");
            //        break;
            //    default:
            //        Console.WriteLine("Introduceti forma valida");
            //        break;

            //}

            #endregion
            #region TypeMatch
            //void TypeMatch(object obj)
            //{
            //    switch (obj)
            //    {
            //        case int i:
            //            if (i % 2 == 0)
            //                Console.WriteLine($"Numarul {i} este par");
            //            else if (i % 2 == 1)
            //                Console.WriteLine($"Numarul {i} este impar");
            //            else
            //                Console.WriteLine("Valoare necunoscuta");
            //            break;
            //        case string s:
            //            if (s.Length > 5)
            //                Console.WriteLine($"Sir lung {s} ");
            //            else if (s.Length <= 5)
            //                Console.WriteLine($"Sir scurt{s} ");
            //            break;
            //        case null:
            //            Console.WriteLine("Este null");
            //            break;
            //        default:
            //            Console.WriteLine("Tip necunoscut");
            //            break;
            //    }
            //}
            #endregion
            #region Nota
            //Console.WriteLine("Introduceti nota studentului (1-10) ");
            //int nota = int.Parse(Console.ReadLine());
            //string calificativ;
            //if (nota is 10)
            //    Console.WriteLine("Calificativ: Excelent");
            //else if (nota is 8 or 9)
            //    Console.WriteLine("Calificativ: Bun");
            //else if (nota is <= 7 and >= 5)
            //    Console.WriteLine("Calificativ: Suficient");
            //else if (nota is <= 4 and >= 1)
            //    Console.WriteLine("Calificativ: Necalificat");
            //else
            //    Console.WriteLine("Introduceti o nota valida");
            #endregion
        }
    }
}
