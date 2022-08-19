using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;

public class Example {

	public static void Main()
	{
		
		Movie m1 = new Movie("Avengers","Action");
		Movie m2 = new Movie("F2","Comedy");
		Movie m3 = new Movie("F3","Comedy");
		Movie m4 = new Movie("War","Action");
		Movie m5 = new Movie("Thor","Action");
		
		List<Movie> action_movies = new List<Movie>();
		List<Movie> comedy_movies = new List<Movie>();
		
		comedy_movies.Add(m2);
		comedy_movies.Add(m3);
		
		action_movies.Add(m1);
		action_movies.Add(m4);
		action_movies.Add(m5);
		
		Console.WriteLine("---------------Action Movies------------------");
		foreach(Movie m in action_movies){
		    Console.WriteLine(m);
		}
		
		
		
		Console.WriteLine("---------------Comedy Movies------------------");
		foreach(Movie m in comedy_movies){
		    Console.WriteLine(m);
		}
		
	}
}

class Movie{
    public string Name,Type;
    public Movie(string n,string t){
        Name = n;
        Type = t;
    }
    
    public override string ToString(){
        return "Name: " + Name + " Type: " + Type;
    }
}
