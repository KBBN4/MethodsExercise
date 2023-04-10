using System.Drawing;
using System.Xml.Linq;

namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {

            Methods.Add(2, 4);
            Methods.Subtract(4, 2);
            Methods.Multiply(5, 2);
            Methods.divide(10, 2);


            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("What is your favorite color ?");
            string color = Console.ReadLine();
            Console.WriteLine(" What is your favorite animal ?");
            string Animal = Console.ReadLine();
            Console.WriteLine(" What is your favorite band?");
            string Band = Console.ReadLine();

            Console.WriteLine($" Hi,this story is about {name}.{name} favorite color is {color}.\n I think thats a lie though. Not sure." +
                $"i then asked about her favorite animal. She said her favorite animal is a {Animal}. Can you belive that ! a, {Animal}.\n " +
                $"i was so shocked by the answers so,of course i then asked , tell me your favorite band and she replied with {Band}." +
                $"Oh, no, no no. Unbelievable.");
        }
         
       
            
        
         }
     }