namespace AutomationCore.CoreTools
{
    public static class Wait
        {
        public static bool UntilTrue(Func<bool> condition, TimeSpan timeout, int intervalSeconds = 1)
            {
                DateTime endTime = DateTime.Now + timeout;
                Exception raisedException;
            
                while (DateTime.Now < endTime)
                {
                    try
                    {
                        if (condition())
                        {
                            return true;
                        }
                    }
                    catch(Exception ex) {raisedException = ex;}

                    Thread.Sleep(intervalSeconds * 1000);
                }
                throw (new TimeoutException());
            }
        }
    }
