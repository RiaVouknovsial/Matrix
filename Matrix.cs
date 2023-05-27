public class Matrix
{
    private int[,] nums;

    public int Rows { get; set; }
    public int Cols { get; set; }

    public Matrix(int rows, int cols)
    {
        Rows = rows;
        Cols = cols;
        nums = new int[rows, cols];
    }

    public int this[int r, int c]
    {
        get { return nums[r, c]; }
        set { nums[r, c] = value; }
    }
}
