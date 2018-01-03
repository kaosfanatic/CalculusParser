using System;

public static class Helpers
{


    public static string ReverseString(string input)
    {
        
        string output = String.Empty;


        for (int i = input.Length - 1; i >= 0; i--)
        {
            output = output + input[i];
        }

        return output;

    }
}

