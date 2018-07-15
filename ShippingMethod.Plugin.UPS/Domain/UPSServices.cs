using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingMethod.Plugin.UPS.Domain
{
    /// <summary>
    /// Class for UPS services
    /// </summary>
    public enum UPSServices
    {
        NextDayAir = 1,
        SecondDayAir = 2,
        Ground = 3,
        WorldwideExpress = 4,
        WorldwideExpedited =5,
        Standard = 6,
        ThreeDaySelect = 7,
        NextDayAirSaver = 8,
        NextDayAirEarlyAM = 9,
        WorldwideExpressPlus = 10,
        SecondDayAirAM = 11,
        ExpressSaver = 12,
        SurePost = 13
    }
}
