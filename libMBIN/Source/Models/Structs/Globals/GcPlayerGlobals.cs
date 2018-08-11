﻿namespace libMBIN.Models.Structs
{
    public class GcPlayerGlobals : NMSTemplate
    {
        /* 0x0 */ public bool InteractNearbyRadiusEnabled;
        /* 0x1 */ public bool DebugExperience;
        /* 0x2 */ public bool DebugExperienceRender;
        /* 0x3 */ public bool DebugDroneScanPlayer;
        [NMS(Size = 0xC, Ignore = true)]
        /* 0x4 */ public byte[] Padding4;
        /* 0x10 */ public Vector4f DebugDroneSpawn;
        /* 0x20 */ public Vector4f DebugDroneTarget;
        /* 0x30 */ public int DebugNumDrones;
        [NMS(Size = 0xC, Ignore = true)]
        /* 0x34 */ public byte[] Padding34;
        /* 0x40 */ public Vector4f DebugFlybyTarget;
        /* 0x50 */ public Vector4f DebugFlybyDir;
        /* 0x60 */ public float DebugFlybyRange;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x64 */ public byte[] Padding64;
        /* 0x68 */ public GcSeed DebugFlybySeed;
        [NMS(Size = 0x10)]
        /* 0x78 */ public string DebugExperienceCamShake;       // maybe? or Vector4f
        /* 0x88 */ public float MinBinocActiveTime;
        /* 0x8C */ public float CreativeModeDeathFadeInTime;
        /* 0x90 */ public float CreativeModeDeathFadeOutTime;
        /* 0x94 */ public int NumberOfWarpsRequiredForFreightersToSpawn;
        /* 0x98 */ public float SpawningDistanceBetweenPlayersAfterWarp;
        /* 0x9C */ public float SpawningSpaceBattleLookOffset;
        /* 0xA0 */ public float SpawningSpaceBattleLookOffsetUp;
        /* 0xA4 */ public bool MultiplayerShareWanted;
        /* 0xA5 */ public bool ReportAllProjectileDamage;
        /* 0xA8 */ public int DefaultHitPoints;
        /* 0xAC */ public int DefaultHealthPips;
        /* 0xB0 */ public int DefaultShipHealthPips;
        /* 0xB4 */ public int MaxHealthPips;
        /* 0xB8 */ public bool UseLargeHealthBar;
        /* 0xBC */ public float DroneSpawnAccelerator;
        /* 0xC0 */ public float TrackArrowStaticTargetOffsetMultiplier;
        /* 0xC4 */ public float WitnessSenseEnhancementTime;
        /* 0xC8 */ public float WitnessSenseEnhancement;
        /* 0xCC */ public float UnderwaterMargin;
        /* 0xD0 */ public float MultiplayerMinWanteEscalationTime;
        /* 0xD4 */ public float HealthRechargeMinTimeSinceDamage;
        /* 0xD8 */ public float HealthPipRechargeRate;
		/* 0xDC */ public float MinEnergyPercentOnRespawn;
		/* 0xE0 */ public float VehicleRaceResultsHintTime;
		/* 0xE4 */ public float OtherPlayerTrackArrowRange;
		/* 0xE8 */ public float WantedLevelPlayerRange;
		/* 0xEC */ public float WantedLevelPlayerRangeSpace;
		/* 0xF0 */ public float PlayerTransferRange;
		/* 0xF4 */ public float PlayerSpaceTransferRange;
		/* 0xF8 */ public float DroneScanTimeToForget;
		/* 0xFC */ public float GhostbusterStartLength;
		/* 0x100 */ public float GhostbusterStart1;
		/* 0x104 */ public float GhostbusterSpeed1;
		/* 0x108 */ public float GhostbusterFreq1;
		/* 0x10C */ public float GhostbusterAmp1;
		/* 0x110 */ public float GhostbusterStart2;
		/* 0x114 */ public float GhostbusterSpeed2;
		/* 0x118 */ public float GhostbusterFreq2;
		/* 0x11C */ public float GhostbusterAmp2;
		/* 0x120 */ public float GhostbusterStart3;
		/* 0x124 */ public float GhostbusterSpeed3;
		/* 0x128 */ public float GhostbusterFreq3;
		/* 0x12C */ public float GhostbusterAmp3;
		/* 0x130 */ public bool WeaponZoomEnabled;
		/* 0x134 */ public float WeaponZoomFOV;
		/* 0x138 */ public float WeaponZoomRecoilMultiplier;
		/* 0x13C */ public float WeaponZoomVertRotation;
		/* 0x140 */ public float WeaponZoomHorzRotation;
		/* 0x144 */ public bool FrontShieldEnabled;
		/* 0x148 */ public float FrontShieldOffsetOff;
		/* 0x14C */ public float FrontShieldOffsetOn;
		/* 0x150 */ public float FrontShieldSpeedSlowdown;
		/* 0x154 */ public float CombatSpawnMinWantedTime;
		/* 0x158 */ public float ExperienceHardPiratesDamagePotentialMin;
		/* 0x15C */ public float ExperienceHardPiratesDamagePotentialRange;
		/* 0x160 */ public float ExperienceHardPiratesDamageMaxOdds;
		/* 0x164 */ public float ExperienceMediumPiratesDamagePotentialMin;
		/* 0x168 */ public float ExperienceMediumPiratesDamagePotentialRange;
		/* 0x16C */ public float ExperienceMediumPiratesDamageMaxOdds;
		/* 0x170 */ public float CommunicatorSpeed;
		/* 0x174 */ public float GrenadeBounceDamping;
		/* 0x178 */ public float GrenadeBounceMaxSpeed;
		/* 0x17C */ public float GrenadeStopExplodeTime;
		/* 0x180 */ public float CockpitEjectTestSphereRadius;
		/* 0x184 */ public float CockpitEjectTestSphereRange;
		/* 0x188 */ public float CockpitEjectSideTestRange;
		/* 0x18C */ public float WeaponShotgunSlowdown;
		/* 0x190 */ public int MouseSmoothMode;
		/* 0x194 */ public Vector2f MouseSpringStrength;
		/* 0x19C */ public Vector2f MouseSpringStrengthMinDelta;
		/* 0x1A4 */ public Vector2f MouseSpringStrengthMaxDelta;
		/* 0x1AC */ public float HardModeEnergyDischargeRateLow;
		/* 0x1B0 */ public float HardModeEnergyDischargeRateMedium;
		/* 0x1B4 */ public float HardModeEnergyDischargeRateHigh;
		/* 0x1B8 */ public float HazardDamageMinTime;
		/* 0x1BC */ public float EnergyDamageMinTime;
		/* 0x1C0 */ public float EnergyDischargeRateLow;
		/* 0x1C4 */ public float EnergyDischargeRateMedium;
		/* 0x1C8 */ public float EnergyDischargeRateHigh;
		/* 0x1CC */ public float EnergyDischargeRateFloatingInSpace;
		/* 0x1D0 */ public float EnergyPainRate;
		/* 0x1D4 */ public float SolarRegenFactor;
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x1D4 */ public byte[] Padding1D4;
        /* 0x1E0 */ public Colour DefaultMuzzleColour;
        /* 0x1F0 */ public Colour TerrainEditorMuzzleColourSubtract;
        /* 0x200 */ public Colour TerrainEditorMuzzleColourAdd;
        /* 0x210 */ public Colour DefaultMuzzleLaserColour;
        /* 0x220 */ public float FreeJetpackRange;
        /* 0x224 */ public float FreeJetpackRangeNonTerrain;
        /* 0x228 */ public float JetpackDrainHorizontalFactor;
        /* 0x22C */ public float MinTimeAfterMeleeBeforeBoost;
        /* 0x230 */ public float MaxTimeAfterMeleeBeforeBoost;
        /* 0x234 */ public float MeleeBoostAirForce;
        /* 0x238 */ public float MeleeToAirBoostInitialImpulse;
        /* 0x23C */ public float MaxTimeInMeleeBoost;
        /* 0x240 */ public float JetpackForce;
        /* 0x244 */ public float JetpackBrake;
        /* 0x248 */ public float JetpackMinLevel;
        /* 0x24C */ public float JetpackMaxSpeed;
        /* 0x250 */ public float JetpackMaxUpSpeed;
        /* 0x254 */ public float JetpackUpForce;
        /* 0x258 */ public float JetpackIgnitionForce;
        /* 0x25C */ public float JetpackIgnitionTime;
        /* 0x260 */ public float JetpackMinIgnitionTime;
        [NMS(Size = 0x3)]
        /* 0x264 */ public float[] JetpackTankTimes;
        /* 0x270 */ public float JetpackFillRate;
		/* 0x274 */ public float JetpackFillRateHardMode;
		/* 0x278 */ public float JetpackFillRateSpaceStationMultiplier;
		/* 0x27C */ public float JetpackUpForceDeadPlanetExtra;
		/* 0x280 */ public float JetpackForceDeadPlanetExtra;
		/* 0x284 */ public float JetpackIgnitionForceDeadPlanetExtra;
		/* 0x288 */ public bool EnableHeadMovements;
		/* 0x289 */ public bool ClampPitch;
		/* 0x28C */ public float DamageRepairFactor;
		/* 0x290 */ public float DamageRepairFactorHardMode;
		/* 0x294 */ public float NormalModeHazardTimeMultiplier;
		/* 0x298 */ public float NormalModeHazardDamageRateMultiplier;
		/* 0x29C */ public float NormalModeHazardDamageWoundRateMultiplier;
		/* 0x2A0 */ public float NormalModeSubstanceRewardMultiplier;
		/* 0x2A4 */ public float NormalModeHazardRechargeUnderground;
		/* 0x2A8 */ public float HardModeHazardTimeMultiplier;
		/* 0x2AC */ public float HardModeHazardDamageRateMultiplier;
		/* 0x2B0 */ public float HardModeHazardDamageWoundRateMultiplier;
		/* 0x2B4 */ public float HardModeSubstanceRewardMultiplier;
		/* 0x2B8 */ public float HardModeHazardRechargeUnderground;
		/* 0x2BC */ public float FreighterProbeScanTime;
		/* 0x2C0 */ public int MaxNumDestroyEffects;
		/* 0x2C4 */ public int MinNumDestroyEffects;
		/* 0x2C8 */ public float ProjectileEndTime;
		/* 0x2CC */ public float ExplosionTimePerEffect;
		/* 0x2D0 */ public float ExplosionTimeVariance;
		/* 0x2D4 */ public float ExplosionScaleVariance;
		/* 0x2D8 */ public float ExplosionBoundingInset;
		/* 0x2DC */ public float ExplosionBoundingInsetRange;
		/* 0x2E0 */ public float DestroyEffectFinalDelay;
		/* 0x2E4 */ public float ShipPriceExp2;
		/* 0x2E8 */ public float WeaponPriceExp2;
		/* 0x2EC */ public float FreighterPriceExp2;
		/* 0x2F0 */ public float ShipCoolFactor;
		/* 0x2F4 */ public float WeaponCoolFactor;
		/* 0x2F8 */ public float FreighterCoolFactor;
		/* 0x2FC */ public bool MouseCrosshairVisible;
		/* 0x300 */ public float MouseMaxLength;
		/* 0x304 */ public float MouseDeadZone;
		/* 0x308 */ public float MouseAimZone;
		/* 0x30C */ public float MouseCrosshairMaxAlpha;
		/* 0x310 */ public float MouseCrosshairAlphaFade;
		/* 0x314 */ public float MouseCrosshairAlphaFadeSpeed;
		/* 0x318 */ public float MouseCrosshairLineAlpha;
		/* 0x31C */ public float MouseCrosshairLineWidth;
		/* 0x320 */ public float MouseCrosshairShipStrength;
		/* 0x324 */ public float MouseCrosshairMultiplier;
		/* 0x328 */ public bool UseEnergy;
		/* 0x329 */ public bool InventoryDamage;
		/* 0x32A */ public bool NeverPreyedOn;
		/* 0x32B */ public bool PermanantFire;
		/* 0x32C */ public bool PermanantAltFire;
		/* 0x32D */ public bool LuckyWithTech;
		/* 0x330 */ public int BulletCostReducer;
		/* 0x334 */ public int BulletClipMultiplier;
		/* 0x338 */ public float LootForceMultiplier;
		/* 0x33C */ public float WoundTimeMinimum;
		/* 0x340 */ public float WoundDamageLimit;
		/* 0x344 */ public float WoundDamageLimitShip;
		/* 0x348 */ public float WoundDamageDecayTime;
		/* 0x34C */ public float ResourceBlobFinalScaleDistance;
		/* 0x350 */ public float LaserPlayerOffset;
		/* 0x354 */ public float WalkerAlertRange;
		/* 0x358 */ public float WalkerSightRange;
		/* 0x35C */ public float WalkerSightAngle;
		/* 0x360 */ public float CombatEscalateTime;
		/* 0x364 */ public float CombatEscapeRadius;
		/* 0x368 */ public float CombatEscapeTime;
		/* 0x36C */ public bool UpgradeExosuitWithProduct;
        [NMS(Size = 0x3, Ignore = true)]
        /* 0x369 */ public byte[] Padding369;
        [NMS(Size = 0x10)]
        /* 0x370 */ public string ExosuitUpgradeProduct;
        /* 0x380 */ public int SuitInventoryStartSeed;
        /* 0x384 */ public int MaxNumShipsAttackingPlayer;
        /* 0x388 */ public float ObjectScanTime;
        /* 0x38C */ public float DroneProbeScanTime;
        /* 0x390 */ public int PirateHailPercent;
        /* 0x394 */ public float PirateBountyInitTime;
        /* 0x398 */ public float PirateProbeInitTime;
        /* 0x39C */ public float PirateProbeAttackWaitTime;
        /* 0x3A0 */ public float PirateProbeAttackWarnTime;
        /* 0x3A4 */ public float PirateProbeScanTime;
        /* 0x3A8 */ public float PirateProbeScanTotalTime;
        /* 0x3AC */ public float PirateProbeHailPause;
        /* 0x3B0 */ public float PirateBattleMarkerRange;
        /* 0x3B4 */ public float PirateBattleWarnTime;
        /* 0x3B8 */ public float PirateBattleMarkerTime;
        /* 0x3BC */ public float PirateBattleMaxTime;
        [NMS(Size = 0x20)]
        /* 0x3C0 */ public string TraderHailReceiveOSDLoc;
        [NMS(Size = 0x20)]
        /* 0x3E0 */ public string TraderHailRefusedOSDLoc;
        /* 0x400 */ public float TraderHailTime;
        /* 0x404 */ public float TraderApproachTime;
        /* 0x408 */ public float TraderHailDistance;
        /* 0x40C */ public float TraderApproachDistance;
        /* 0x410 */ public float TraderSpamTimeWait;
        /* 0x414 */ public float TraderStayCloseLockOffset;
        /* 0x418 */ public float TraderStayCloseLockSin1Coeff;
        /* 0x41C */ public float TraderStayCloseLockSin1Offset;
        /* 0x420 */ public float TraderStayCloseLockSin2Coeff;
        /* 0x424 */ public float TraderStayCloseLockSin2Offset;
        /* 0x428 */ public float TraderStayCloseLockSinsAdd;
        /* 0x42C */ public float TraderStayCloseLockSpread;
        /* 0x430 */ public float TraderStayCloseLockSpreadAdd;
        /* 0x434 */ public float TraderStayCloseLockSpreadTime;
        /* 0x438 */ public float TraderHealthFightThreshold;
        /* 0x43C */ public int TraderCommunicationBanMinTime;
        /* 0x440 */ public int TraderCommunicationBanMaxTime;
        /* 0x444 */ public float LaserMiningDamageMultiplier;
        /* 0x448 */ public float ShieldRechargeMinTimeSinceDamage;
        /* 0x44C */ public float ShieldRechargeRate;
        /* 0x450 */ public float MoveStickHighRangeLimit;
        /* 0x454 */ public float WitnessAIDamageDistance;
        /* 0x458 */ public float WitnessAIDamageAngle;
        /* 0x45C */ public float DeathDamageDrainChargeFactor;
        /* 0x460 */ public int DeathDamageTechBrokenPercent;
        /* 0x464 */ public float MaxProjectileRadiusMultiplier;
        /* 0x468 */ public float HardLandPainTime;
        /* 0x46C */ public int GunBaseClipSize;
        /* 0x470 */ public int GrenadeBaseClipSize;
		/* 0x474 */ public float MeleeCooldown;
		/* 0x478 */ public float ChargeMeleeCooldown;
		/* 0x47C */ public float MeleeDistance;
		/* 0x480 */ public float MeleeDistance3P;
		/* 0x484 */ public float MeleeRadius;
		/* 0x488 */ public float MeleeHitTime;
		/* 0x48C */ public float MeleeSpeedBoost;
		/* 0x490 */ public float MeleeSpeedDamageBoost;
		/* 0x494 */ public float MeleeSpeedBoostRangeMultiplier;
		/* 0x498 */ public float MeleeStaminaDrain;
		/* 0x49C */ public float TemperatureDisplaySampleTime;
        /* 0x4A0 */ public Colour StarFieldColour;
        /* 0x4B0 */ public float StarFieldRadius;
        /* 0x4B4 */ public float StarFieldDensity;
        /* 0x4B8 */ public float StarFieldStarSize;
        /* 0x4BC */ public float SpeedLinesSpeedMin;
        /* 0x4C0 */ public float SpeedLinesSpeedMax;
        /* 0x4C4 */ public float SpeedLinesLength;
        /* 0x4C8 */ public float SpeedLinesTotalLength;
        /* 0x4CC */ public float SpeedLinesWidthMin;
        /* 0x4D0 */ public float SpeedLinesWidthMax;
        /* 0x4D4 */ public float SpeedLinesRadiusStartMin;
        /* 0x4D8 */ public float SpeedLinesRadiusStartMax;
        /* 0x4DC */ public float SpeedLinesRadiusIncrement;
        /* 0x4E0 */ public float SpeedLinesStartFade;
        /* 0x4E4 */ public float SpeedLinesMinAlpha;
        /* 0x4E8 */ public float SpeedLinesMaxAlpha;
        /* 0x4EC */ public float SpeedLinesOffset;
        /* 0x4F0 */ public float SleepFadeTime;
        /* 0x4F4 */ public float StaminaRate;
        /* 0x4F8 */ public float StaminaRecoveryRate;
        /* 0x4FC */ public float StaminaRecoveredFactor;
        /* 0x500 */ public float ScanLabelTime;
        /* 0x504 */ public float ScanWobbleFreq;
        /* 0x508 */ public float ScanWobbleAmp;
        /* 0x50C */ public float ScanWobbleFreq2;
        /* 0x510 */ public float ScanWobbleAmp2;
        /* 0x514 */ public float ScanRotate;
        /* 0x518 */ public float ScanRotateDist;
        /* 0x51C */ public float ScanRotateWobbleAmp;
        /* 0x520 */ public float ScanFadeInTime;
        /* 0x524 */ public float ScanFadeOutTime;
        /* 0x528 */ public float ScanBeamWidth;
        /* 0x52C */ public float ScanRotateBeamWdith;
        /* 0x530 */ public float ScanBeamMainWidth;
        /* 0x534 */ public float WantedDroneEventRadius;
        /* 0x538 */ public float WantedMinSpaceTime;
        /* 0x53C */ public float WantedMinPlanetTime;
        /* 0x540 */ public float WantedLevelDelay;
        /* 0x544 */ public float WantedWitnessTimer;
        /* 0x548 */ public float WantedWitnessFuzzyTime;
        /* 0x54C */ public float WantedMinorCrimeAmount;
        /* 0x550 */ public float WantedTimeoutAggressive;
        [NMS(Size = 0x5)]
        /* 0x554 */ public float[] WantedTimeout;
        [NMS(Size = 0x5)]
        /* 0x568 */ public float[] WantedEscalateTime;
        [NMS(Size = 0x5)]
        /* 0x57C */ public float[] WantedExtremeEscalateTime;
        /* 0x590 */ public float ControlModes;
        /* 0x594 */ public float InteractionScanRange;
        /* 0x598 */ public float InteractionButtonRange;
        /* 0x59C */ public float InteractionFocusTime;
        /* 0x5A0 */ public float InteractionSubstanceRange;
        /* 0x5A4 */ public float HeatShieldTime;
        /* 0x5A8 */ public float LaserShakeMin;
        /* 0x5AC */ public float LaserShakeMax;
        /* 0x5B0 */ public float GunRecoil;
        /* 0x5B4 */ public float LaserRecoil;
        /* 0x5B8 */ public float BeamRecoil;
        /* 0x5BC */ public float GrenadeRecoil;
        /* 0x5C0 */ public float GunRecoilSpring;
        /* 0x5C4 */ public float BlastRecoilSpring;
        /* 0x5C8 */ public float RailRecoilSpring;
        /* 0x5CC */ public float PulseRecoilSpring;
        /* 0x5D0 */ public float GunRecoilSettleSpring;
        /* 0x5D4 */ public float ThirdPersonRecoilMultiplier;
        /* 0x5D8 */ public float GunRecoilMin;
        /* 0x5DC */ public float GunRecoilMax;
        /* 0x5E0 */ public float ProjectileDamageFalloff;
        /* 0x5E4 */ public float ShotgunDispersion;
        /* 0x5E8 */ public GcResourceCollectEffect TerrainResourceCollect;
        /* 0x61C */ public GcResourceCollectEffect TerrainResourceMiniCollect;
        /* 0x650 */ public GcResourceCollectEffect TerrainResourceMeleeCollect;
        /* 0x684 */ public GcResourceCollectEffect CrystalResourceCollect;
        /* 0x6B8 */ public GcResourceCollectEffect ShardResourceCollect;
        /* 0x6EC */ public GcBoidData MissileSwarm;
        /* 0x718 */ public GcPlayerStickData StickData;
        /* 0x734 */ public bool AutoAim;
        /* 0x738 */ public float AutoAimMaxAccelFactor;
        /* 0x73C */ public float AutoAimFixedInterceptSpeed;
        /* 0x740 */ public float AutoAimTimeOut;
        /* 0x744 */ public float AutoAimMaxAngle;
        /* 0x748 */ public float AutoAimMinScreenDistance;
        /* 0x74C */ public float AutoAimRadiusExtra;
        /* 0x750 */ public float AutoAimStickyMin;
        /* 0x754 */ public float AutoAimStickyMax;
        /* 0x758 */ public float AutoAimDotCurve;
        /* 0x75C */ public TkCurveType AutoAimCentreOffsetCurve;
        /* 0x760 */ public float AimDistanceShip;
        /* 0x764 */ public float AimSpeed;
        /* 0x768 */ public float AimWeightAdd;
        /* 0x76C */ public float AimMinWeight;
        /* 0x770 */ public float AimDecay;
        /* 0x774 */ public float AimOffset;
        /* 0x778 */ public float AimShootableTargetAngle;
        /* 0x77C */ public float AimDisperseTime;
        /* 0x780 */ public float AimDisperseMinTime;
        /* 0x784 */ public float AimDisperseCooldownTime;
        /* 0x788 */ public float AimDisperseCooldownFactor;
        /* 0x78C */ public TkCurveType AimDisperseCurve;
        /* 0x790 */ public float CrosshairTime;
        /* 0x794 */ public float BeaconActivateRange;
        /* 0x798 */ public float ExperiencePirateFreighterAttackRange;
        /* 0x79C */ public float ExperienceWalkerSize;
        /* 0x7A0 */ public float ExperienceInterestingShipDistance;
        /* 0x7A4 */ public float ExperienceInterestingFreighterDistance;
        /* 0x7A8 */ public float ExperienceInterestingDroneDistance;
        /* 0x7AC */ public float ExperienceShipTimeMin;
        /* 0x7B0 */ public float ExperienceShipTimeMax;
        /* 0x7B4 */ public int ExperiencePirateCloseAttackPercentage;
        /* 0x7B8 */ public float ExperiencePirateTimeMin;
        /* 0x7BC */ public float ExperiencePirateTimeMax;
        /* 0x7C0 */ public float ExperienceDroneTimeMin;
        /* 0x7C4 */ public float ExperienceDroneTimeMax;
        /* 0x7C8 */ public float ExperienceFlybyScareRadius;
        /* 0x7CC */ public float ExperienceFlybyScareTime;
        /* 0x7D0 */ public Vector2f ExperienceFlybyStartAngle;
        /* 0x7D8 */ public float ExperienceAlertRange;
        /* 0x7DC */ public float ExperienceAlertSightRange;
        /* 0x7E0 */ public float ExperienceAlertSightAngle;
        /* 0x7E4 */ public float ExperienceDroneSpawnOffset;
        /* 0x7E8 */ public float ExperienceDroneSpawnAngle;
        /* 0x7EC */ public float ExperienceMessageBroadcastNearbyDistance;
        /* 0x7F0 */ public float WantedEnemyAttackAmount;
        [NMS(Size = 0x80)]
        /* 0x7F4 */ public string Gun;
        /* 0x874 */ public float StickDeadZoneMin;
        /* 0x878 */ public float StickDeadZoneMax;
        /* 0x87C */ public TkCurveType StickCurve;
        /* 0x880 */ public float AutoLandRange;
        /* 0x884 */ public float AutoLandTime;
        /* 0x888 */ public float LabelSpringTime;
        /* 0x88C */ public float LabelOffset;
        /* 0x890 */ public float AtmosphereEffectTime;
        /* 0x894 */ public float AtmosphereEffectOffset;
        [NMS(Size = 0x7)]
        /* 0x898 */ public GcCreatureAlertData[] AlertTable;
        /* 0x940 */ public float PainFlickerAmount;
        /* 0x944 */ public float PainColourSeperateAmount;
        /* 0x948 */ public float PainTime;
        /* 0x94C */ public GcProjectileLineData PlayerBullet;
        /* 0x974 */ public GcProjectileLineData RobotBullet;
        /* 0x99C */ public GcProjectileLineData ShipBullet;
        /* 0x9C4 */ public float ExplodeShakeMaxDist;
        /* 0x9C8 */ public float ExplodeShakeMaxDistSpace;
        /* 0x9CC */ public float ExplodeShakeStrength;
        /* 0x9D0 */ public float FlashSize;
        /* 0x9D4 */ public float FlashPosX;
        /* 0x9D8 */ public float FlashPosY;
        /* 0x9DC */ public float FlashPosZ;
        /* 0x9E0 */ public float FlashSpeed;
        /* 0x9E4 */ public float FlashPulse;
        /* 0x9E8 */ public float FlashGrow;
        /* 0x9EC */ public float GunRightOffset;
        /* 0x9F0 */ public float GunUpOffset;
        /* 0x9F4 */ public float LaserBeamMineRate;
        /* 0x9F8 */ public float LaserBeamCore;
        /* 0x9FC */ public float LaserBeamFlickerAmp;
        /* 0xA00 */ public float LaserBeamFlickerFreq;
        /* 0xA04 */ public float LaserEndOffset;
        /* 0xA08 */ public float GrenadeTerrainDeformRadius;
        /* 0xA0C */ public float LaserBeamTerrainDeformRadius;
        /* 0xA10 */ public float LaserBeamTerrainDeformVariance;
        /* 0xA14 */ public float LaserBeamOverheatTime;
        /* 0xA18 */ public float LaserBeamAmmoUseTime;
        /* 0xA1C */ public float ReloadButtonHoldTimeToHolster;
        /* 0xA20 */ public float WeaponChangeModeTime;
        [NMS(Size = 0xC, Ignore = true)]
        /* 0xA24 */ public byte[] PaddingA24;
        /* 0xA30 */ public Vector4f WeaponBarrelOffset;
        /* 0xA40 */ public float WeaponLowerDelay;
        /* 0xA44 */ public float WeaponHolsterDelay;
        /* 0xA48 */ public float WeaponLag;
        /* 0xA4C */ public float WeaponBobFactorWalkDeadZone;
        /* 0xA50 */ public float WeaponBobFactorWalk;
        /* 0xA54 */ public float WeaponBobFactorRun;
        /* 0xA58 */ public float WeaponBobBlendTime;
        /* 0xA5C */ public TkCurveType WeaponBobBlendCurve;
        /* 0xA60 */ public float WeaponGrenadeTime;
        /* 0xA64 */ public float WeaponGunTime;
        /* 0xA68 */ public float WeaponRailFireTime;
        /* 0xA6C */ public float WeaponRailRechargeTime;
        /* 0xA70 */ public int MaxBuildHeight;
        /* 0xA74 */ public float SpaceMaxGravityDist;
        /* 0xA78 */ public float SpaceMinGravityDist;
        /* 0xA7C */ public float UnderwaterImpact;
        /* 0xA80 */ public float UnderwaterMaxSpeed;
        /* 0xA84 */ public float UnderwaterForce;
        /* 0xA88 */ public float UnderwaterBrake;
        /* 0xA8C */ public float UnderwaterFloat;
        /* 0xA90 */ public float UnderwaterFloatForce;
        /* 0xA94 */ public float UnderwaterFloatRange;
        /* 0xA98 */ public float UnderwaterFloatFreq;
        /* 0xA9C */ public float BulletBend;
        /* 0xAA0 */ public float ShootSizeMinZ;
        /* 0xAA4 */ public float ShootSizeMaxZ;
        /* 0xAA8 */ public float ShootSizeMinXY;
        /* 0xAAC */ public float ShootSizeMaxXY;
        /* 0xAB0 */ public float ShootSizeTime;
        /* 0xAB4 */ public float ShootSizeBase;
        /* 0xAB8 */ public float ShootOffset;
        /* 0xABC */ public float ShootPrepTime;
        /* 0xAC0 */ public float GrenadeCarveRadius;
        /* 0xAC4 */ public float ChargeTime;
        /* 0xAC8 */ public float EnergyBallSpeed;
        /* 0xACC */ public float ChargedEnergyBallSpeed;
        /* 0xAD0 */ public float LookRayRadius;
        /* 0xAD4 */ public float PickRange;
        /* 0xAD8 */ public float DamageRateWhenUnderNoGravity;
        /* 0xADC */ public float TakeDamageImpulse;
        /* 0xAE0 */ public float HardLandTime;
        /* 0xAE4 */ public float HardLandMin;
        /* 0xAE8 */ public float HardLandMax;
        /* 0xAEC */ public float MeleeRange;
        /* 0xAF0 */ public float MeleeTime;
        /* 0xAF4 */ public float MeleeForcePush;
        /* 0xAF8 */ public float MeleeOffset;
        /* 0xAFC */ public float PushForceAirFactor;
        /* 0xB00 */ public int HUDHeightPosX;
        /* 0xB04 */ public int HUDHeightPosY;
        /* 0xB08 */ public float TargetDistance;
        /* 0xB0C */ public float TargetRadius;
        /* 0xB10 */ public float HoldForce;
        /* 0xB14 */ public float HoldTime;
        /* 0xB18 */ public float HoldActionDistX;
        /* 0xB1C */ public float HoldActionDistY;
        /* 0xB20 */ public float HoldActionDistZ;
        /* 0xB24 */ public float HoldDistX;
        /* 0xB28 */ public float HoldDistY;
        /* 0xB2C */ public float HoldDistZ;
        /* 0xB30 */ public float HoldMaxForce;
        /* 0xB34 */ public float HoldRotate;
        /* 0xB38 */ public float BalanceStrength;
        /* 0xB3C */ public float BalanceSpeed;
        /* 0xB40 */ public float GroundWalkForce;
        /* 0xB44 */ public float GroundWalkBrake;
        /* 0xB48 */ public float GroundWalkBrakeWhileMoving;
        /* 0xB4C */ public float GroundWalkSpeed;
        /* 0xB50 */ public float GroundRunSpeed;
        /* 0xB54 */ public float GroundWalkRecoverySpeedDamper;
        /* 0xB58 */ public float ExertionSmoothTime;
        /* 0xB5C */ public float ExertionFromPainTime;
        /* 0xB60 */ public float AnimWalkSpeed;
        /* 0xB64 */ public float AnimRunSpeed;
        /* 0xB68 */ public float AnimWalkToRunSpeed;
        /* 0xB6C */ public float AnimWalkBlendPoint;
        /* 0xB70 */ public float AnimRunBlendPoint;
        /* 0xB74 */ public float MaxSlopeAngle;
        /* 0xB78 */ public float SlopeSlidingSpeed;
        /* 0xB7C */ public float SlopeSlideBrake;
        /* 0xB80 */ public float MinSlideTime;
        /* 0xB84 */ public float MaxWalkableSlopeAngle;
        /* 0xB88 */ public float MinSpidermanSlopeAngle;
        /* 0xB8C */ public float MinTimeToHoldSpidermanPose;
        /* 0xB90 */ public float MaxSpidermanSlopeAngle;
        /* 0xB94 */ public float MaxClingableSlopeAngle;
        /* 0xB98 */ public float MinimumPushOffForceToSlide;
        /* 0xB9C */ public float FullClipReloadSpeedMultiplier;
        /* 0xBA0 */ public float ReloadTapButtonSpeedIncrease;
        /* 0xBA4 */ public float ClingBrakeMultiplier;
        /* 0xBA8 */ public float ClingAngleThreshold;
        /* 0xBAC */ public float ClingSpeedThreshold;
        /* 0xBB0 */ public float ClimbableStickinessAngle;
        /* 0xBB4 */ public float MinUpAmount;
        /* 0xBB8 */ public float FootOffset;
        /* 0xBBC */ public float MaxFallSpeed;
        /* 0xBC0 */ public float PushForceDecay;
        /* 0xBC4 */ public float LeanFwdMaxAngle;
        /* 0xBC8 */ public float LeanBackMaxAngle;
        /* 0xBCC */ public float LeanLeftMaxAngle;
        /* 0xBD0 */ public float LeanRightMaxAngle;
        /* 0xBD4 */ public float LeanAmount;
        /* 0xBD8 */ public float LeanAmountFwd;
        /* 0xBDC */ public float HelmetLag;
        /* 0xBE0 */ public float HelmetMaxLag;
        /* 0xBE4 */ public float HelmetBob;
        /* 0xBE8 */ public float JetpackHelmetBob;
        /* 0xBEC */ public float ShipCameraLag;
        /* 0xBF0 */ public float MaxResource;
        /* 0xBF4 */ public float ShieldRestoreSpeed;
        /* 0xBF8 */ public float ShieldRestoreDelay;
        /* 0xBFC */ public float TimeHoldDownAccelerateToLaunchFromOutpost;
        /* 0xC00 */ public float DeathScreenFadeInThirdPerson;
        /* 0xC04 */ public float DeathScreenFadeInUnderwaterThirdPerson;
        /* 0xC08 */ public float DeathScreenFadeInTime;
        /* 0xC0C */ public float DeathScreenShipFadeInTime;
        /* 0xC10 */ public float DeathScreenPauseTime;
        /* 0xC14 */ public float DeathScreenMaxRegenWaitTime;
        /* 0xC18 */ public float DeathScreenMinRegenWaitTime;
        /* 0xC1C */ public float DeathScreenFadeOutTime;
        /* 0xC20 */ public GcPlayerStickData LookStickData;
        /* 0xC3C */ public GcPlayerStickData AmbientModeLookStickData;
        /* 0xC58 */ public int LowHealthEffectPips;
        /* 0xC5C */ public int LowHealthEffectShield;
        /* 0xC60 */ public float CriticalHitTime;
        /* 0xC64 */ public float CriticalHitDesatTime;
        /* 0xC68 */ public float CriticalHitDesatFreq;
        [NMS(Size = 0x2)]
        /* 0xC6C */ public GcCameraSpawnSetupData[] FirstSpawnDataTable;
        /* 0xC8C */ public GcInventoryValueData ShipValueData;
        /* 0xCA8 */ public GcInventoryValueData WeaponValueData;
        /* 0xCC4 */ public GcInventoryValueData FreighterValueData;
        [NMS(Size = 0x7)]
        /* 0xCE0 */ public float[] TechRarityData;
        [NMS(Size = 0x6)]
        /* 0xCFC */ public float[] TechLearningProbabilities;
        /* 0xD14 */ public int NumTechShopSlots;
        /* 0xD18 */ public float GrassPushDistance;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0xD1C */ public byte[] PaddingD1c;
        /* 0xD20 */ public GcCameraAnomalySetupData AnomalyBlachHoleSpawnData;
        /* 0xD60 */ public GcCameraAnomalySetupData AnomalyAtlasStationSpawnData;
        /* 0xDA0 */ public GcCameraAnomalySetupData AnomalyMiniStationSpawnData;
        /* 0xDE0 */ public GcJourneyMedalTiers MedalTiers;
        /* 0xDF0 */ public int LowGuildRank;
        /* 0xDF4 */ public int MedGuildRank;
        /* 0xDF8 */ public int HighGuildRank;
        /* 0xDFC */ public int BestGuildRank;
        /* 0xE00 */ public float LaserWeaponRange;
        /* 0xE04 */ public float LaserShipRange;
        /* 0xE08 */ public float TerrainLaserRange;
        /* 0xE0C */ public float VehicleLaserRange;
        /* 0xE10 */ public GcPlayerCommunicatorMessage PirateHailMessage;
        /* 0xE60 */ public GcShipDialogue TraderHailMessages;
        [NMS(Size =  0x4)]
        /* 0x10C8 */ public int[] TraderHailReceiveRegular;
        [NMS(Size = 0x2)]
        /* 0x10D8 */ public int[] TraderHailReceiveFight;
        [NMS(Size =  0x4)]
        /* 0x10E0 */ public int[] TraderHailSend;
    }
}
