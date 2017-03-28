using System.Collections.Generic;
using System.Linq;

namespace NinjectAop.ServiceLayer
{
    public class FeatureUsageLog : IFeatureUsageLog
    {
        private readonly IList<KeyValuePair<string, bool>> _logs = new List<KeyValuePair<string, bool>>();

        public IEnumerable<KeyValuePair<string, bool>> Logs => _logs.AsEnumerable();

        public void Log(string psFeatureName,
            bool enabled)
        {
            _logs.Add(new KeyValuePair<string, bool>(psFeatureName, enabled));
        }
    }
}