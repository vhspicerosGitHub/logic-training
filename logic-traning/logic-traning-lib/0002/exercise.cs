namespace logic_traning_lib._0002
{
    internal static class exercise
    {
        public static int[] GetMaxs(int[] numbers, int MaxCount)
        {
            var list = numbers.ToList().Distinct().ToList();
            list.Sort();
            list.Reverse();
            var a = list.GetRange(0, MaxCount).ToArray();
            return a;

        }
    }
}
