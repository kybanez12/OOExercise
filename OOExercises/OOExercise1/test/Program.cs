using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOExercise1;



namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            PAVETeacher teacher1 = new PAVETeacher("tim", "M", "baird", 12);
            SecondaryTeacher teacher2 = new SecondaryTeacher("james", "M", "white", 13);

            Console.WriteLine(teacher1.GetOccupation());
            Console.WriteLine(teacher1.Work());

            Console.WriteLine(teacher2.GetOccupation());
            Console.WriteLine(teacher2.Work());
            Console.ReadKey();

        }   

         
        
      
    }



        
    
}
