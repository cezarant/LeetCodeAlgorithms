using System.Collections.Generic;

public static class fizzBuzzProblem
{
    public static List<string> implementation(int n)
    {
        int cont = 0;
        bool divideBy5 = false;
        bool divideBy3 = false;
        List<string> lstReturn = new List<string>();
        do
        {
            if (cont % 3 == 0)
                divideBy3 = true;

            if (cont % 5 == 0)
                divideBy5 = true;

            if ((divideBy3) && (divideBy5))
            {
                lstReturn.Add("FizzBuzz");
            }
            else
            {
                if (divideBy3)
                    lstReturn.Add("Fizz");
                else if (divideBy5)
                    lstReturn.Add("Buzz");
                else
                    lstReturn.Add(cont.ToString());
            }
            divideBy3 = false;
            divideBy5 = false;
            cont++;
        } while (cont < n);

        return lstReturn;
    }
}

