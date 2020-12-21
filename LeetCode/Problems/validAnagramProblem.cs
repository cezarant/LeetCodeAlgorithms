
public static class validAnagramProblem
{
    public static bool implementation(string s, string t)
    {
        bool bValidAnagram = true;
        int cont = 0;
        int contReverse = t.Length-1;
        if (contReverse != (s.Length-1))
            return false; 

        do
        {
            if (s[cont] != t[contReverse])
                bValidAnagram = false;

            cont++;
            contReverse--;
        } while ((cont < (s.Length-1)) && (bValidAnagram));
        return bValidAnagram; 
    }
}

