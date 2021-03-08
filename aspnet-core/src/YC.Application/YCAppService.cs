using System;
using System.Collections.Generic;
using System.Text;
using YC.Localization;
using Volo.Abp.Application.Services;

namespace YC
{
    /* Inherit your application services from this class.
     */
    public abstract class YCAppService : ApplicationService
    {
        protected YCAppService()
        {
            LocalizationResource = typeof(YCResource);
        }
    }
}
