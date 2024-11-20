namespace AutomationCore.CoreTools
{
    public static class Wait
    {
        public static bool UntilTrue(Func<bool> condition, TimeSpan timeout, int intervalSeconds = 1)
        {
            DateTime endTime = DateTime.Now + timeout;
            Exception? raisedException = null;

            while (DateTime.Now < endTime)
            {
                try
                {
                    if (condition())
                    {
                        return true;
                    }
                }
                catch (Exception ex) { raisedException = ex; }

                Thread.Sleep(intervalSeconds * 1000);
            }

            throw new TimeoutException(raisedException != null ? raisedException.Message : "Expression is False");
        }

        public static T Until<T>(Func<T> condition, TimeSpan timeout, int intervalSeconds = 1)
        {
            DateTime endTime = DateTime.Now + timeout;
            Exception? raisedException = null;

            while (DateTime.Now < endTime)
            {
                try
                {
                    return condition();
                }
                catch (Exception ex) { raisedException = ex; }

                Thread.Sleep(intervalSeconds * 1000);
            }

            throw new TimeoutException(raisedException.Message);
        }

        public static void Until(Action action, TimeSpan timeout, int intervalSeconds = 1)
        {
            DateTime endTime = DateTime.Now + timeout;
            Exception? raisedException = null;

            while (DateTime.Now < endTime)
            {
                try
                {
                    action();
                    return;
                }
                catch
                {
                }

                Thread.Sleep(intervalSeconds * 1000);
            }

            throw new TimeoutException(raisedException != null ? raisedException.Message : null);
        }
    }
}
