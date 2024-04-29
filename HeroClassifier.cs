using System;

class HeroClassifier
{
    public static void Main(string[] args)
    {
        float HeroXp;
        string heroName;
        string level = "";

        Console.WriteLine("Enter your hero name:");
        heroName = Console.ReadLine();
        
        Console.WriteLine("Enter your xp:");
        HeroXp = float.Parse(Console.ReadLine());
        
        if (HeroXp > 10000) {
            level = "Radiante";
        } 
        else if (HeroXp > 9000)
        {
            level = "Imortal";
        }
        else if (HeroXp > 8000)
        {
            level = "Ascendente";
        }
        else if (HeroXp > 7000)
        {
            level = "Platina";
        }
        else if (HeroXp > 5000)
        {
            level = "Ouro";
        }
        else if (HeroXp > 2000)
        {
            level = "Prata";
        }
        else if (HeroXp > 1000)
        {
            level = "Bronze";
        }
        else if (HeroXp <= 1000)
        {
            level = "Ferro";
        }

        Console.WriteLine("O Herói de nome " + heroName + " está no nível de " + level);
    }
}