using System.Collections.Generic;

namespace NinjectAop.ServiceLayer
{
    public interface IFeatureUsageLog 
    {
        IEnumerable<FeatureUsageLogItem> Logs { get; }

        void Log(string feature,
            bool isEnabled,
            string stackTrace);
    }
}