using SignalRServer.Models;
using System;
using System.Collections.Generic;

namespace SignalRServer.Supports
{
    public static class DataManager
    {
        public static List<ChartModel> GetData()
        {
            Random r = new Random();

            return new List<ChartModel>()
            {
                new ChartModel { Data = new List<int> { r.Next(1, 100) }, Label = "Data1" },
                new ChartModel { Data = new List<int> { r.Next(1, 100) }, Label = "Data2" },
                new ChartModel { Data = new List<int> { r.Next(1, 100) }, Label = "Data3" },
                new ChartModel { Data = new List<int> { r.Next(1, 100) }, Label = "Data4" }
            };
        }
    }
}
