using YC.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace YC.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class YCController : AbpController
    {
        protected YCController()
        {
            LocalizationResource = typeof(YCResource);
        }
    }
}