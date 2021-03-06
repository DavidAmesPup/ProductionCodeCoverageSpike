﻿using Ninject;
using Ninject.Extensions.Interception.Infrastructure.Language;
using NinjectAop.Intercepters;
using NinjectAop.ServiceLayer;
using Xunit;

namespace NinjectAop.Tests
{
    public static class InterceptionTests
    {
        private static IKernel SetupKernel()
        {
            var kernel = new StandardKernel();

            kernel.Bind<IFeature>().To<Feature>();

            //Use this style to intercept all interactions with a class.
            //kernel.Bind<IFeature>().To<Feature>().InTransientScope().Intercept().With<FeatureUsageIntercepter>();
            kernel.Bind<IFeatureUsageLog>().To<FeatureUsageLog>().InThreadScope();
            kernel.Bind<ISomeRandomService>().To<SomeRandomService>().InTransientScope();

            //Hook up single method interception.

            kernel.UseInterceptorFor<Feature, FeatureUsageIntercepter>(x => x.GetFeatureValue_Bool(""));
            

            return kernel;
            
        }

        [Fact]
        public static void CanIntercept()
        {
            //Arrange
            var kernel = SetupKernel();

            //Act
            kernel.Get<ISomeRandomService>().DoSomething();

            //Assert
            Assert.NotEmpty(kernel.Get<IFeatureUsageLog>().Logs);
        }
    }
}