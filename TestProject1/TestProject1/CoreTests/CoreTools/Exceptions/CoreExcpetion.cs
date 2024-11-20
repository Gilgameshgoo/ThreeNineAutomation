namespace ThreeNineTests.CoreTests.CoreTools.Exceptions;

public abstract class CoreExcpetion : Exception
{
    public CoreExcpetion() : base() { }

    public CoreExcpetion(string message) : base(message) { }

    public CoreExcpetion(string message, Exception innerException)
        : base(message, innerException) { }
}
