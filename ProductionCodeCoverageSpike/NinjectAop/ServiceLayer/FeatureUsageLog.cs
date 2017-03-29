using System.Collections.Generic;
using System.Linq;

namespace NinjectAop.ServiceLayer
{
    public class FeatureUsageLog : IFeatureUsageLog
    {
        private readonly IList<FeatureUsageLogItem> _logs = new List<FeatureUsageLogItem>();

        public IEnumerable<FeatureUsageLogItem> Logs => _logs.AsEnumerable();

        public void Log(string feature,
            bool isEnabled,
            string stackTrace)
        {
            _logs.Add(new FeatureUsageLogItem(feature, isEnabled, stackTrace));
        }
    }
}