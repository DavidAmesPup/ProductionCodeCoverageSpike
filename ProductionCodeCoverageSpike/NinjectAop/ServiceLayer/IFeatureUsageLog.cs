using System.Collections.Generic;

namespace NinjectAop.ServiceLayer
{
    public interface IFeatureUsageLog 
    {
        IEnumerable<KeyValuePair<string, bool>> Logs { get; }

        void Log(string psFeatureName,
            bool enabled);
    }
}