using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
    [NMS(Size = 0x4, GUID = 0x53ACC709803EED2D, NameHash = 0xF50D34444AC02C1E)]
    public class TkTrophyEnum : NMSTemplate
    {
        // size = 0x1
        public enum TrophyEnum { None };
        public TrophyEnum Trophy;
    }
}
