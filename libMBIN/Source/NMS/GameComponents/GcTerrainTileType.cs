﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x4, Alignment = 0x4, GUID = 0xAFB195227CDEA6E2, NameHash = 0x6247F06C43E3ADDD)]
    public class GcTerrainTileType : NMSTemplate
    {
        // 0x9 elements
		public enum TileTypeEnum { Air, Base, Rock, Mountain, Underwater, Cave, Dirt, Liquid, Substance }
		public TileTypeEnum TileType;
    }
}