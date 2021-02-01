using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace MarsRover.Core.Enums
{
 public enum Command
    {
        [Description("Left")]
        L,
        [Description("Right")]
        R,
        [Description("Move")]
        M
    }
}
