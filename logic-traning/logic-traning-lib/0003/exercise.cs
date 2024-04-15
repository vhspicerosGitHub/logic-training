namespace logic_traning_lib._0003
{
    internal static class exercise
    {
        public static  bool  IsArrayPalindrome (int[] numbers)
        {
            var revertNumbers =numbers.Reverse();
            return numbers.SequenceEqual(revertNumbers);
        }
    }
}
