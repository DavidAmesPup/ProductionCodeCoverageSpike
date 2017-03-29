namespace NinjectAop.ServiceLayer
{
    public class FeatureUsageLogItem
    {
        public FeatureUsageLogItem(string feature,
            bool isEnabled,
            string stackTrace)
        {
            Feature = feature;
            IsEnabled = isEnabled;
            StackTrace = stackTrace;
        }

        public string Feature { get; private set; }
        public bool IsEnabled { get; private set; }

        public string StackTrace { get; private set; }
    }
}