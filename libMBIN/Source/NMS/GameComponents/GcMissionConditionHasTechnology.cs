﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x4EFE5A34F597C44F, NameHash = 0x7454AD5214251C68)]
    public class GcMissionConditionHasTechnology : NMSTemplate
    {
        public GcTechnologyTableEnum Technology;
        public bool AllowPartiallyInstalled;
        public bool TeachIfNotKnown;
        [NMS(Size = 0x2, Ignore = true)]
        public byte[] EndPadding;
    }
}
