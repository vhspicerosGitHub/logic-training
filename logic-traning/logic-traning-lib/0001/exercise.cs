namespace logic_traning_lib._0001
{
    internal static class exercise
    {
        public static int GetMax(int[] numbers)
        {
            var list = numbers.ToList();
            list.Sort();
            list.Reverse();
            return list[0];

        }
    }
}
