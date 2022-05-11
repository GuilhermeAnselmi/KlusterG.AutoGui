using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace KlusterG.AutoGui.InternalKeys
{
    public enum MouseKeys
    {
        #region Mouse Keys
        [EnumMember]
        LeftDrop = 0x00000002,

        [EnumMember]
        LeftPress = 0x00000004,

        [EnumMember]
        RightDrop = 0x00000008,

        [EnumMember]
        RightPress = 0x00000010,

        [EnumMember]
        MiddleDrop = 0x00000020,

        [EnumMember]
        MiddlePress = 0x00000040,

        [EnumMember]
        Move = 0x00000001,

        [EnumMember]
        Absolute = 0x00008000,
        #endregion
    }
}
