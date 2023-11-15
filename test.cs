public class Solution {
    public bool IsPalindrome(int x) {
        // volver int a string para iterar
        string numeroString = x.ToString();

        int i = 0;
        int j = numeroString.Length - 1;

        while(i < j)
        {
            if(numeroString[i] != numeroString[j])
            {
                return false;
            }
            i ++;
            j --;
        }
        return true;
    }
}