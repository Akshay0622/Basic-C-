using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifire;

public class AccessModifire
{
    // Public field
    public int publicField = 10;

    // Private field
    private int privateField = 20;

    // Protected field
    protected int protectedField = 30;

    // Internal field
    internal int internalField = 40;

    // Protected internal field
    protected internal int protectedInternalField = 50;

    // Private protected field
    private protected int privateProtectedField = 60;

    // Public method
    public void PublicMethod()
    {
        Console.WriteLine("Public method");
    }

    // Private method
    private void PrivateMethod()
    {
        Console.WriteLine("Private method");
    }

    // Protected method
    protected void ProtectedMethod()
    {
        Console.WriteLine("Protected method");
    }

    // Internal method
    internal void InternalMethod()
    {
        Console.WriteLine("Internal method");
    }

    // Protected internal method
    protected internal void ProtectedInternalMethod()
    {
        Console.WriteLine("Protected internal method");
    }

    // Private protected method
    private protected void PrivateProtectedMethod()
    {
        Console.WriteLine("Private protected method");
    }
}
