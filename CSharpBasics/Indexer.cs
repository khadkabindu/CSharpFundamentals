namespace CSharpBasics;

public abstract class Indexer
{
    
    // static void Main(string[] args)
    // {
    //     Student indexerExample1 = new Student();
    //     indexerExample1[0] = 20;
    //     indexerExample1[1] = 40;
    //     indexerExample1[2] = 100;
    //     Console.WriteLine(indexerExample1.GetPercent());
    //     
    //     
    //     
    // }
}

partial class Student
{
    private int roll;

    // public int Roll
    // {
    //     get { return roll; }
    //     set { roll = value; }
    // }

    private int[] Marks = new int[3];

    public int this[int index]
    {
        get { return Marks[index]; }
        set { Marks[index] = value; }
    }

    public double GetPercent()
    {
        double total = 0.0;
        foreach (int m in Marks)
        {
            total += m;
        }

        return total / Marks.Length;
    }
}