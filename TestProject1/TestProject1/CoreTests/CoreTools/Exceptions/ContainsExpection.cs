namespace ThreeNineTests.CoreTests.CoreTools.Exceptions
{
    public class ContainsExpection : CoreExcpetion
    {
        public ContainsExpection() : base() { }

        public ContainsExpection(string message) : base(message) { }

        public ContainsExpection(string message, Exception innerException)
            : base(message, innerException) { }

    }
}
