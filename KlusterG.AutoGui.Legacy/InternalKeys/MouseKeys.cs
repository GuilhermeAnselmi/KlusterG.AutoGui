using System.Runtime.Serialization;

namespace KlusterG.AutoGui.Legacy.InternalKeys
{
    public enum MouseKeys
    {
        #region Mouse Keys
        [EnumMember]
        LeftPress = 0x00000002,

        [EnumMember]
        LeftDrop = 0x00000004,

        [EnumMember]
        RightPress = 0x0000008,

        [EnumMember]
        RightDrop = 0x00000010,

        [EnumMember]
        MiddlePress = 0x00000020,

        [EnumMember]
        MiddleDrop = 0x00000040,

        [EnumMember]
        Move = 0x00000001,

        [EnumMember]
        Absolute = 0x00008000,
        #endregion
    }
}
