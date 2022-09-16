//Dont forgot chance Object_typeID = ; 


datablock RangedWeaponData(NativeHunterArrow : BaseBow)
{
   id = 628;
   Object_typeID = 3013;

   AgilityNeed = 50.0;
   StrengthNeed = 40.0;
   MaxAccuracy = 0.7;
   Emax = 3.7;
   BasePrefireAnimTime = 1.7;
   BaseRecoilAnimTime = 1.3;
   allowedAmmoIDs = "656 657 658 659 660 1339 1582";
   DurabilityPerShot = 20.0;
   StaminaRate = 28;

   shapefile = "art/models/3d-2d/weapons/Tribe/hunterbow.dts";

   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = AttackBow;
   WeaponType = WeaponBow;

   hitDirection[0] = ""; // Thrust
   hitDirection[1] = ""; // Overhead
   hitDirection[2] = ""; // RightToLeftHit
   hitDirection[3] = ""; // LeftToRightHit
   WoundMultiplier = "";
   FractureMultiplier = "";
   StunMultiplier = "";
   correctMuzzleVector = false;
};
