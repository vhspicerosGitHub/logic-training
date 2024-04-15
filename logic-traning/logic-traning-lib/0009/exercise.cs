namespace logic_traning_lib._0009;
internal class exercise
{

    public bool isPRimeNumber(int number)
    {

        if (number <= 1)
        {
            return false;
        }

        for (int i = 2; i < number; i++)
        {
            if (number % i == 0)
            {
                return false;
            }
        }

        return true;
    }


}