﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Globals
{
    [NMS(Size = 0x348, GUID = 0x1E3BB15A8FC3BAF6)]
    public class GcCharacterGlobals : NMSTemplate
    {
		/* 0x0 */ public float PitchTest;
		/* 0x4 */ public float RollTest;
		/* 0x8 */ public float WaterEffectHeightOffset;
		/* 0xC */ public float WaterEffectHeightRange;
		/* 0x10 */ public float WaterEffectFadeSpring;
		/* 0x14 */ public float WaterEffectSpeedFade;
		/* 0x18 */ public float WaterEffectSpeedFadeMin;
		/* 0x1C */ public float WaterEffectSpeedOffset;
		/* 0x20 */ public float WaterEffectMinScale;
		/* 0x24 */ public float WaterEffectSideOffset;
		/* 0x28 */ public float WaterEffectRearOffset;
		/* 0x2C */ public float WaterEffectRearBackOffset;
		/* 0x30 */ public float CharacterRotationOffsetY;
        /* 0x34 */ public float CharacterRoughHeadHeight;
        [NMS(Size = 0x80)]
        /* 0x38 */ public string CharacterFile;
        /* 0xB8 */ public GcSeed CharacterSeedOverride;
		/* 0xC8 */ public float DontShowCharacterWithinCameraDistance;
		/* 0xCC */ public float CharacterTurnSpeed;
        /* 0xD0 */ public float CharacterRunTurnSpeed;
		/* 0xD4 */ public float CharacterJetpackTurnSpeed;
		/* 0xD8 */ public float CharacterJetpackTurnAimSpeed;
		/* 0xDC */ public float CharacterTurnAimSpeed;
		/* 0xE0 */ public float CharacterSwimmingTurnSpeed;
		/* 0xE4 */ public float CharacterSwimmingTurnAimSpeed;
		/* 0xE8 */ public float RocketBootsLandedTurnSpeed;
		/* 0xEC */ public float RocketBootsTurnSpeed;
		/* 0xF0 */ public float FeetShiftOnTurnSpeed;
		/* 0xF4 */ public float FeetShiftOnTurnMaxSpeed;
		/* 0xF8 */ public float MinTurnAngle;
		/* 0xFC */ public float YawPullSpeed;
		/* 0x100 */ public float GunRotationSpeed;
		/* 0x104 */ public float AimPitchAnimScale;
		/* 0x108 */ public float AimYawAnimScale;
		/* 0x10C */ public float AimPitchInterpSpeed;
		/* 0x110 */ public float MinSwimmingPitchRotation;
		/* 0x114 */ public float MaxSwimmingPitchRotation;
		/* 0x118 */ public float JetpackSwimmingPitchRotation;
		/* 0x11C */ public float MinSwimmingRollRotation;
		/* 0x120 */ public float MaxSwimmingRollRotation;
		/* 0x124 */ public float SwimmingSmoothTime;
		/* 0x128 */ public float SwimmingSmoothTimeWithWeapon;
		/* 0x12C */ public float SwimmingRollSmoothTime;
		/* 0x130 */ public float SwimmingRollSmoothTimeWithWeapon;
		/* 0x134 */ public float LadderDistanceToAutoMount;
		/* 0x138 */ public float LadderCooldownAfterBeforeAutoClimb;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x13C */ public byte[] Padding13C;
        [NMS(Size = 0x10)]
        /* 0x140 */ public string LadderClimbIdle;
        [NMS(Size = 0x10)]
        /* 0x150 */ public string LadderClimbUp;
        [NMS(Size = 0x10)]
        /* 0x160 */ public string LadderClimbDown;
        [NMS(Size = 0x10)]
        /* 0x170 */ public string LadderMountBottom;
        [NMS(Size = 0x10)]
        /* 0x180 */ public string LadderDismountBottom;
        [NMS(Size = 0x10)]
        /* 0x190 */ public string LadderMountTop;
        [NMS(Size = 0x10)]
        /* 0x1A0 */ public string LadderDismountTop;
		/* 0x1B0 */ public float SlopeAngleForUphillClimb;
		/* 0x1B4 */ public float SlopeAngleForDownhillClimb;
		/* 0x1B8 */ public float SlidingBrake;
		/* 0x1BC */ public float SlopeAngleForSlide;
		/* 0x1C0 */ public float UphillSpeedMultiplier;
		/* 0x1C4 */ public float TrudgeUphillSpeed;
		/* 0x1C8 */ public float MaxAnkleRotationAngle;
		/* 0x1CC */ public float RotateToFaceSlopeSpeed;
		/* 0x1D0 */ public float TimeNotOnGroundToBeConsideredInAir;
		/* 0x1D4 */ public float TimeNotOnGroundToUseFallingCamera;
		/* 0x1D8 */ public float TimeFallingUntilPanic;
		/* 0x1DC */ public float BankingMinimumSpeed;
		/* 0x1E0 */ public float BankingMaxStrength;
		/* 0x1E4 */ public float BankingSpeedForMaxStrength;
		/* 0x1E8 */ public float MinimumIdleToJogAnimSpeed;
		/* 0x1EC */ public float RootedAnimInterpolationTime;
		/* 0x1F0 */ public float IKLegStretchStrength;
		/* 0x1F4 */ public float IkBlendStrengthSpeed;
		/* 0x1F8 */ public float FootPlantedTolerance;
		/* 0x1FC */ public float FootPlantSpring;
		/* 0x200 */ public float BlendToNewFeetSpeed;
		/* 0x204 */ public float TimeAfterDeathRagdollIsEnabledForward;
		/* 0x208 */ public float TimeAfterDeathRagdollIsEnabledBackward;
		/* 0x20C */ public float TimeAfterDeathRagdollIsEnabledWhenBlocked;
		/* 0x210 */ public float RagdollTau;
		/* 0x214 */ public float RagdollDamping;
		/* 0x218 */ public float RagdollConeLimit;
		/* 0x21C */ public float RagdollTwistLimit;
		/* 0x220 */ public float RagdollMotorFadeStart;
		/* 0x224 */ public float RagdollMotorFadeEnd;
		/* 0x228 */ public float MinStickForIntoJogAnim;
		/* 0x22C */ public float SmoothVelocitySpeed;
		/* 0x230 */ public float TimeToShowSplashEffect;
		/* 0x234 */ public float UnderwaterToAirTolerance;
		/* 0x238 */ public float WaterBottomSmoothPushUp;
		/* 0x23C */ public float WaterBottomSmoothPushUpDepth;
        /* 0x240 */ public float SitPostureChangeTimeMin;
        /* 0x244 */ public float SitPostureChangeTimeMax;
        /* 0x248 */ public bool NPCUseBehaviourTree;
        /* 0x249 */ public bool NPCLightsAlwaysOn;
        /* 0x24C */ public GcNPCPropTypes NPCForceProp;
        /* 0x250 */ public float NPCPropScaleTime;
        /* 0x254 */ public float NPCReactionChance;
        /* 0x258 */ public float NPCReactCooldown;
        /* 0x25C */ public float NPCIKBodyWeightNormalGek;
        /* 0x260 */ public float NPCIKBodyWeightNormal;
        /* 0x264 */ public float NPCIKBodyWeightSeated;
        /* 0x268 */ public float NPCSpineAdjustGek;
        /* 0x26C */ public float NPCSpineAdjustVykeen;
        /* 0x270 */ public float NPCAnimSpeedMin;
        /* 0x274 */ public float NPCAnimSpeedMax;
        /* 0x278 */ public float NPCBehaviourTimeModifier;
        /* 0x27C */ public bool NPCBehaviourInfo;
        /* 0x280 */ public float NPCStaticDistance;
        /* 0x284 */ public float NPCStaticTimeTilFail;
        /* 0x288 */ public float NPCWalkSpeedMech;
        /* 0x28C */ public float NPCWalkSpeed;
        /* 0x290 */ public float NPCWalkSpeedGek;
        /* 0x294 */ public float NPCRunSpeed;
        /* 0x298 */ public float NPCRunSpeedGek;
        /* 0x29C */ public float NPCArriveDist;
        /* 0x2A0 */ public float NPCIncreasedSteeringDist;
        /* 0x2A4 */ public float NPCMinTurnSpeed;
        /* 0x2A8 */ public float NPCMaxTurnSpeed;
        /* 0x2AC */ public float NPCMinTurnSpeedMech;
        /* 0x2B0 */ public float NPCDecelerateStrength;
        /* 0x2B4 */ public float NPCStaticTurnTime;
        /* 0x2B8 */ public float NPCTeleportEffectTime;
        /* 0x2BC */ public float NPCMinStaticTurnAngle;
        /* 0x2C0 */ public float NPCFastStaticTurnAngle;
        /* 0x2C4 */ public float NPCSlowStaticTurnAngle;
        /* 0x2C8 */ public float NPCMaxStaticTurnSpeed;
        /* 0x2CC */ public float NPCActiveListenChance;
        /* 0x2D0 */ public float NPCLookAtThingChance;
        /* 0x2D4 */ public float NPCLookAtThingTimeMin;
        /* 0x2D8 */ public float NPCLookAtThingTimeMax;
        /* 0x2DC */ public float NPCLookAwayTimeMin;
        /* 0x2E0 */ public float NPCLookAwayTimeMax;
        /* 0x2E4 */ public float NPCMaxLookAtAngleMoving;
        /* 0x2E8 */ public float NPCMaxLookAtAngleStatic;
        /* 0x2EC */ public float NPCLookAtTerminateAngle;
        /* 0x2F0 */ public float NPCSeatedLookAtLateralReduction;
        /* 0x2F4 */ public float NPCMinInteractionSearchDist;
        /* 0x2F8 */ public float NPCMaxInteractionSearchDist;
        /* 0x2FC */ public float NPCSteeringSpringTime;
        /* 0x300 */ public float NPCPerceptionRadius;
        /* 0x304 */ public float NPCSteeringObstacleAvoidStrength;
        /* 0x308 */ public float NPCSteeringFollowStrength;
        /* 0x30C */ public float NPCSteeringAvoidStrength;
        /* 0x310 */ public float NPCSteeringRadius;
        /* 0x314 */ public float NPCSteeringRepelDist;
        /* 0x318 */ public float NPCSteeringComingTowardsDegrees;
        /* 0x31C */ public float NPCSteeringCollisionAvoidAngle;
        /* 0x320 */ public float NPCSteeringCollisionAvoidStrength;
        /* 0x324 */ public float NPCSteeringRaySpread;
        /* 0x328 */ public float NPCSteeringRayLength;
        /* 0x32C */ public float NPCSteeringRaySphereSize;
        /* 0x330 */ public float NPCBlockedDestRadius;
        /* 0x334 */ public float NPCFlavourIdleTimeMin;
        /* 0x338 */ public float NPCFlavourIdleTimeMax;
        /* 0x33C */ public float NPCMoodIdleDelayChance;
        /* 0x340 */ public float NPCMoodIdleLowIntensityChance;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x344 */ public byte[] EndPadding;
    }
}
