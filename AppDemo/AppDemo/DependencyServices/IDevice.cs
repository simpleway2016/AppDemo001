using System;
using System.Collections.Generic;
using System.Text;

namespace AppDemo
{
    public interface IDevice
    {
        int ScreenWidth
        {
            get;
        }

        int ScreenHeight
        {
            get;
        }
    }
}
