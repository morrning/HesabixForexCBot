using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using cAlgo.API;
using cAlgo.API.Collections;
using cAlgo.API.Indicators;
using cAlgo.API.Internals;

namespace cAlgo.Robots
{
    [Robot(AccessRights = AccessRights.None)]
    public class Hesabix : Robot
    {
        [Parameter(DefaultValue = "Hello world!")]
        public string Message { get; set; }

        protected override void OnStart()
        {
            // To learn more about cTrader Automate visit our Help Center:
            // https://help.ctrader.com/ctrader-automate

            Print(Message);
        }

        protected override void OnTick()
        {
            // Handle price updates here
            Print("salam Hesabix !");
        }

        protected override void OnStop()
        {
            // Handle cBot stop here
        }
    }
}