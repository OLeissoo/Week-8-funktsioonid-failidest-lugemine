using System;

namespace FunctionsReturnAndArraysFromFile
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayRandomFood();
            DisplayRandomDrink();
            DisplayRandomMovie();
        }

        private static void DisplayRandomFood()
        {
            string[] foods = { "pizza", "sushi", "burger", "burrito", "salad" };
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, foods.Length);

            string RandomFood = foods[randomIndex];
            Console.WriteLine($"Computer picked: {RandomFood}");
        }

        private static void DisplayRandomDrink()
        {
            string[] drinks = { "apple juice", "Coke", "Sprite", "Fanta" };
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, drinks.Length);

            string RandomDrink = drinks[randomIndex];
            Console.WriteLine($"Computer picked: {RandomDrink}");
        }

        private static void DisplayRandomMovie()
        {
            string[] movies = { "The Departed", "Matrix", "Inception", "Avengers: Endgame", "Looper", "Jumper", "The Nun" };
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, movies.Length);

            string RandomMovie = movies[randomIndex];
            Console.WriteLine($"Computer picked: {RandomMovie}");
        }
    }
}
