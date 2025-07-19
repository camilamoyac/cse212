public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // 1. Create a static array of size length and type double
        double[] multiples = new double[length];
        // 2. make a loop for lenth amount of times
        for (int i = 0; i < length; i++)
        {
            // 3. for each iteration calculate the multiple: number * (index + 1) (so it doesnt start
            // on 0) and store on the i position of the array
            multiples[i] = number * (i + 1);
        }   
        // 4. return the finished array
        return multiples;
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // for the rotation we essentially take out the last "amount" of data from the list and insert it in the beginning so:
        // 1. calculate the index of the first item of the tail end of the list that will be moved to the front
        int itemIndex = data.Count - amount;
        // from the example: itemIndex = 9 - 3 = 6 -> index of 7

        // 2. use GetRange to copy the tail end of the list from the itemIndex
        List<int> tailEnd = data.GetRange(itemIndex, amount);
        // from the example: tailEnd = 7, 8, 9

        // 3. use RemoveRange to remove the tailEnd from the original list
        data.RemoveRange(itemIndex, amount);
        // from the example: data = 1, 2, 3, 4, 5, 6

        // 4. use InsertRange to add the tail end to the front of the list
        data.InsertRange(0, tailEnd);
        // from the example: data = 7, 8, 9, 1, 2, 3, 4, 5, 6
    }
}
