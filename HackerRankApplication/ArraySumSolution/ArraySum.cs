namespace HackerRankApplication.ArraySumSolution;

internal static class ArraySum
{
    //Method that calculates the sum of given int array
    internal static int ComputeArraySum(List<int> array)
    {
        int total = 0;
        array.ForEach(x => total += x);
        return total;
    }
}
