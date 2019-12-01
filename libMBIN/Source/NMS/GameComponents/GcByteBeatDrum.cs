using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x54, GUID = 0x903E735321A44DAF, NameHash = 0xAAB4AB6EC567BC2F)]
    public class GcByteBeatDrum : NMSTemplate
    {
        [NMS(Size = 0x40)]
        /* 0x00 */ public string Tree;
        /* 0x40 */ public float Volume;
        /* 0x44 */ public float Duration;
        /* 0x48 */ public float OctaveShift;
        /* 0x4C */ public GcByteBeatEnvelope AttackEnvelope;
        /* 0x50 */ public GcByteBeatEnvelope DecayEnvelope;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x54 */ public byte[] EndPadding;
    }
}
