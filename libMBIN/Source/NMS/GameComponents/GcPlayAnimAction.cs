﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x6E59AF67707D88AB, Alignment = 0x8, NameHash = 0x5D2AE4FEA56F0EB4)]
    public class GcPlayAnimAction : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string Anim;
    }
}
