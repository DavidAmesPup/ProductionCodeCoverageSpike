using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using Ninject.Extensions.Interception;
using Ninject.Extensions.Interception.Infrastructure.Language;

namespace NinjectAop.Intercepters
{
    public static class InterceptionExtensions
    {
        public static void UseInterceptorFor<TObject, TInterceptor>(
            this IKernel kernel,
            Expression<Action<TObject>> methodExpr)
            where TInterceptor : IInterceptor
        {
            var interceptor = kernel.Get<TInterceptor>();

            kernel.InterceptReplace<TObject>(methodExpr, inv => interceptor.Intercept(inv));
        }
    }

}
