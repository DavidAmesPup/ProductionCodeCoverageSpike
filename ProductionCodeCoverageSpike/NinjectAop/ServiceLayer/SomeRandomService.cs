namespace NinjectAop.ServiceLayer
{
    public class SomeRandomService : ISomeRandomService
    {
        private readonly IFeature _feature;

        public SomeRandomService(IFeature feature)
        {
            _feature = feature;
        }

        public string DoSomething()
        {
            if (_feature.GetFeatureValue_Bool("SomeFeature"))
                return "A am in SomeRandomService.DoSomething and the feature is enabled";

            return "A am in SomeRandomService.DoSomething and the feature is NOT enabled";
        }
    }
}