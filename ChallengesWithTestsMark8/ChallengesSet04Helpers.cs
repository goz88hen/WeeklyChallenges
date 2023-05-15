using System.Collections.Generic;

internal static class ChallengesSet04Helpers
{

    public static int GetSmallestNumber(int num1, int num2, int num3, int num4)
    {
        var smallest = num1;

        var list = new List<int>() { num1, num2, num3, num4 };

        for (int i = 0; i < list.Count; i++)
        {
            if (list[i] < smallest)
            {
                smallest = list[i];
            }
            return smallest;
        }

    }
}