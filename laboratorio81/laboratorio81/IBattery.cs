using System;
using System.Collections.Generic;
using System.Text;

namespace laboratorio81
{
    public interface IBattery
    {
        int RemainingChargePercent { get; }
        BatteryStatus Status { get; }
        PowerSource PowerSource { get; }
    }



}
