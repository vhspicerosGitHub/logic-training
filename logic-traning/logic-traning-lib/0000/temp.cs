namespace logic_traning_lib._0000
{
    internal class temp
    {

        public static bool Cons(int[] arr)
        {
            Array.Sort(arr);
            var primerElemento = arr[0];
            var consecutivo = primerElemento;
            for (var i = 0; i < arr.Length; i++)
            {
                if (consecutivo != arr[i])
                {
                    return false;
                }
                consecutivo++;
            }
            return true;
        }
    }
}
