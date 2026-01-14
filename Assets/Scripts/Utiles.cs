using System;

public static class Utiles 
{
    private static Random s_random = new Random();

    public static int GetRandomNumber(int min, int max)
    {
        return s_random.Next(min, max + 1);
    }

    public static bool GetRandomBool(int probability)
    {
        int maxProbability = 100;

        return s_random.Next(maxProbability + 1) <= probability;
    }
}
