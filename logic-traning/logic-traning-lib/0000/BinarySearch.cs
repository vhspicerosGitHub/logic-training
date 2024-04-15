namespace logic_traning_lib._0000
{
    public static class BinarySearch
    {
        public static object BinarySearchIterative(int[] inputArray, int key)
        {
            int left = 0;
            int right = inputArray.Length - 1;
            while (left <= right)
            {
                int middle = (left + right) / 2;
                int comparison = inputArray[middle].CompareTo(key);
                if (comparison == 0)
                {
                    return middle;
                }
                else if (comparison < 0)
                {
                    left = middle + 1;
                }
                else
                {
                    right = middle - 1;
                }
            }
            return -1;
        }
    }
}
