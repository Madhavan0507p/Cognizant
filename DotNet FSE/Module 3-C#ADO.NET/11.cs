using System;

class BaseClass
{
    public string PublicMember = "Public";
    private string PrivateMember = "Private";
    protected string ProtectedMember = "Protected";

    public void ShowBase()
    {
        Console.WriteLine($"Inside BaseClass: {PublicMember}, {PrivateMember}, {ProtectedMember}");
    }
}

class DerivedClass : BaseClass
{
    public void ShowDerived()
    {
        Console.WriteLine($"Inside DerivedClass: {PublicMember}, {ProtectedMember}");
        // Console.WriteLine(PrivateMember); // Error: inaccessible
    }
}

class Program
{
    static void Main()
    {
        BaseClass baseObj = new BaseClass();
        DerivedClass derivedObj = new DerivedClass();

        Console.WriteLine(baseObj.PublicMember);
        // Console.WriteLine(baseObj.PrivateMember); // Error
        // Console.WriteLine(baseObj.ProtectedMember); // Error

        baseObj.ShowBase();
        derivedObj.ShowDerived();
    }
}
