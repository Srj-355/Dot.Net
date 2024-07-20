using System;
using System.Collections;

public class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Welcome to QFI movies!");

        Console.WriteLine("Please Enter your name for movies list:");

        string name = Console.ReadLine();
        User u = new User();
        u.setUsername(name);
        if (u.getUsername().Equals("saroj mandal", StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine($"Welcome to QFI movies! Mr/Mrs {u.getUsername()}");
          
            Movie m1 = new Movie();
            m1.setTitle("Avengers");


            

            Console.WriteLine("Now showing:");

              Movie m = new Movie();
            m.setTitle("Avengers: Endgame");
            List<Movie> li = new List<Movie>();
           li.Add(m);
           li.Add(new Movie("Nai na bhau la"));
           li.Add(new Movie("Kalki "));
           li.Add(new Movie("Pathan"));
           li.Add(new Movie("sahoo"));
           li.Add(new Movie("KGF 2"));
           li.Add(new Movie("RRR"));
           foreach(var movie in li){
            Console.WriteLine(movie.getTitle());
           }


        }

        else
        {
            Console.WriteLine("Unauthorized access!!!");
        }





    }
}

