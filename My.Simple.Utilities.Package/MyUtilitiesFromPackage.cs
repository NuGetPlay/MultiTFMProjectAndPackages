using System;

namespace My.Simple.Utilities.Package
{
    public class MyUitilitiesFromPackage
    {
        public static string GetString()
        {
            string returnStr = "NOT SET";
#if NETSTANDARD2_0
            returnStr = "NETSTANDARD2_0";
#elif NET462            
            returnStr = "NET462";
#elif NET47
            returnStr = "NET47";
#endif
            return returnStr;
        }
    }
}
