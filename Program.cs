using System;

namespace freestyle
{
    class Program
    {
        static void Main(string[] args)
        {
            

           string[] months = { "Jananuary" , "February" , "March" , "April" , "May" , "June" , "July" , "August" , "September" , "October" , "November" , "December" };
         Console.WriteLine(months.Length);
         int monthsLen = months.Length;
         Console.WriteLine($"The number of month is {monthsLen}");
         Console.WriteLine();

         
         foreach(string rankMonth in months)
         Console.WriteLine(rankMonth);
         Console.WriteLine();
         
         
        

         Console.WriteLine("-----copy the first six months-----");
         string[] newArray = new string[6];
         Array.Copy(months, newArray, 6);
         foreach(string value in newArray)
         {
             Console.WriteLine(value);
         }
         
         
          Console.WriteLine("-----clone----");
          string[] monthsClone = (string[])months.Clone(); 
          foreach (string clon in months)
           {
              Console.WriteLine(clon);
           }

         

         Console.WriteLine();
         
         Console.WriteLine("----reverse the months------");

         Array.Reverse(months);
         foreach(string revers in months)
         {
             Console.WriteLine(revers);
         }
         Console.WriteLine();


         Console.WriteLine("------- no. of months in alphabetical order-------");
         Array.Sort(months);
         foreach (string order in months)
         {
          Console.WriteLine(order);
         }
         Console.WriteLine();

          
          Console.WriteLine("------clear from index six-----"); 
           Array.Clear(months, 0, 6);
         foreach(string indclear in months)
         {
            Console.WriteLine(indclear);
         }


         Console.WriteLine("-------array after using clear-----");
         Array.Clear (months, 0 ,months.Length);
         foreach(string clear in months)
         {
             Console.WriteLine(clear);
         }
          Console.WriteLine();
           
           
         

         
        }
    }
}
