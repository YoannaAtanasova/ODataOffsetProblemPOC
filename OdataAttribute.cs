using Microsoft.AspNet.OData;

namespace ODataOffsetProblemPOC
{
    public class ODataAttribute : EnableQueryAttribute
    {
        public ODataAttribute()
            : base()

        {
            PageSize = 1;
        }
    }
}
