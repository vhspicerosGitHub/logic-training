namespace logic_traning_lib._0000
{
    public class CollatzProblem
    {
        public List<int> Generate(int counter)
        {
            var collatzPatters = new List<int>();
            collatzPatters.Add(counter);
            while (counter != 1)
            {
                if (counter % 2 == 0)
                {
                    counter = counter / 2;
                }
                else
                {
                    counter = counter * 3 + 1;
                }
                collatzPatters.Add(counter);
            }
            return collatzPatters;

        }
    }
}
