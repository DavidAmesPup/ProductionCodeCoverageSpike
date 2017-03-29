using System;
using System.Linq;
using Ninject.Extensions.Interception;
using NinjectAop.ServiceLayer;

namespace NinjectAop.Intercepters
{
    public class FeatureUsageIntercepter : SimpleInterceptor
    {
        private readonly IFeatureUsageLog _featureUsageLog;

        public FeatureUsageIntercepter(IFeatureUsageLog featureUsageLog)
        {
            _featureUsageLog = featureUsageLog;
        }

        protected override void BeforeInvoke(IInvocation invocation)
        {
            invocation.Proceed();
        }

        protected override void AfterInvoke(IInvocation invocation)
        {
            string stack = Environment.StackTrace;

            _featureUsageLog.Log(invocation.Request.Arguments.First().ToString(), (bool) invocation.ReturnValue, stack);
        }
    }
}