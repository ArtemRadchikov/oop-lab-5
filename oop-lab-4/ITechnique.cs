using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_lab_5
{
    interface IOwner
    {
        string Manufacturer { get; }
    }

    interface IGoods
    {
        float Discount();
    }

    interface ICommonFunctionsForPhones
    {
        void Call();
    }
    interface ICommonFunctionsForSmartphones
    {
        void Call();
    }
}
