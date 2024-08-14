namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite subject in school?");
            string favSubject = Console.ReadLine();

            switch (favSubject)
            {
                case "Math":
                case "math":
                    Console.WriteLine("Math, you say? Well, hello there, Einstein...\n" +
                                      "My calculations suggest that you may be a genius.");
                    break;
                
                case "English":
                case "english":
                    Console.WriteLine("English, huh? Well, yabba dabba doo, good for you - \n" +
                                      "I'm pretty sure that's Shakespeare.");
                    break;
                
                case "Science":
                case "science":
                    Console.WriteLine("Science is a great answer. I wonder how many ages it took...\n" +
                                      "for such an excellent answer to, shall we say, evolve? Touche.");
                    break;
                    
                case "History":
                case "history":
                    Console.WriteLine("Sweet. Looks like we have ourselves a History buff, here.\n" +
                                      "Maybe you can help me figure out some stuff from the past...\n" +
                                      "such as, where in the world last week's homework went.");
                    break;
                
                case "Art":
                case "art":
                    Console.WriteLine("Well, hello there Picasso.\n" +
                                      "Now I know your favorite classo.");
                    break;
                        
                    
                default:
                    Console.WriteLine("An interesting, slightly out-of-the-box choice!\n" +
                                      "Looks like we have a non-conformist here.\n" +
                                      "I've heard that's a sure sign of intelligence!");
                    break;
                
            }
        }
    }
}