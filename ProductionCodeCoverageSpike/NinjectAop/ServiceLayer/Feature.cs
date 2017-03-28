namespace NinjectAop.ServiceLayer
{
    public class Feature : IFeature
    {
        public bool GetFeatureValue_Bool(string psFeatureName)
        {
            return psFeatureName.GetHashCode() % 2 == 0;
        }
    }
}