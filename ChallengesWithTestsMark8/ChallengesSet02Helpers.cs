internal static class ChallengesSet02Helpers
{


    public static long CountOfPositiveOddsBelowNumber(int expected, int number)
    {
        if (number <= 0)
        {
            return 0;
        }
        else
        {
            return number / 2;
        }
    }
}