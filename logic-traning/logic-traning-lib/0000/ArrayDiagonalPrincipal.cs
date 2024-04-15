namespace logic_traning_lib._0000
{
    public class ArrayMethods
    {

        public string ReverseWords(string s)
        {
            var words = s.Split(' ');
            var reverseWord = String.Empty;
            foreach (var word in words)
            {
                Console.WriteLine(word);
                reverseWord += word.ToCharArray(0, word.Length).Reverse().ToArray().ToString();
            }
            return reverseWord;
        }

        public void Diagonal_principal(int[,] array)
        {
            var n = array.GetLength(0);
            for (int i = 0; i < n; i++)
            {
                    array[i, i] = 1;
            }
        }

        public void Diagonal_invertida(int[,] array)
        {
            var n = array.GetLength(0);
            for (int i = 0, j = n-1; i < n ; i++, j--)
            {
                    array[i, j] = 1;
            }
        }

        public int[,] createArray(int n)
        {
            int[,] miArray = new int[n, n];
            for (int i = 0; i < miArray.GetLength(0); i++)
            {
                for (int j = 0; j < miArray.GetLength(1); j++)
                {
                    miArray[i, j] = 0;
                }
            }
            return miArray;
        }

        public string print(int[,] array)
        {
            var n = array.GetLength(0);
            var r = string.Empty;
            var counter = 1;
            for (int i = 0; i < n; i++)
            {
                for (int x = 0; x < n; x++)
                {
                    r += array[i, x];
                }

                r += Environment.NewLine;
            }
            return r;
        }
    }
}