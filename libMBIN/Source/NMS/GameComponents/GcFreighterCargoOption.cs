﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x20, GUID = 0x6CC8A9F4B7093108, SubGUID = 0xAEE2DF0976A04EB1)]
    public class GcFreighterCargoOption : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string ID;
        public int MinAmount;
        public int MaxAmount;
        public int PercentageChance;
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] EndPadding;

    }
}