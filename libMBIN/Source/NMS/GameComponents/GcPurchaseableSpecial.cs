﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x20, GUID = 0x2222AFDB29769EBA)]
    public class GcPurchaseableSpecial : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x00 */ public string ID;
        /* 0x10 */ public int ShopNumber;
        /* 0x14 */ public int MissionTier;
        /* 0x18 */ public bool IsConsumable;
        [NMS(Size = 0x7, Ignore = true)]
        /* 0x19 */ public byte[] EndPadding;
    }
}