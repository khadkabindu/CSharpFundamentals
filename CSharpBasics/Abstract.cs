namespace CSharpBasics;

public abstract class Abstract
{
    // static void Main(string[] args)
    // {
    //     Derived derived = new Derived();
    //     derived.AbstractMethod();
    // }
}

abstract class AbsClass
{
    public abstract void AbstractMethod();

    public void NonAbstractMethod()
    {
        Console.WriteLine("NonAbstract Method");
    }
}


class Derived : AbsClass
{
    public override void AbstractMethod()
    {
        Console.WriteLine("Method is overriden");
    }
}