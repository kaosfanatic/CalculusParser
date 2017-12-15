using System;

public static class Helpers
{


    public static string ReverseString(string input)
    {

        char[] inputChar = input.ToCharArray();
        string output = "";


        for (int i = input.Length - 1; i >= 0; i--)
        {
            output = output + inputChar[i];
        }

        return output;

    }
}

