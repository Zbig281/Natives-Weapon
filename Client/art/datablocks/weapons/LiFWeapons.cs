//Dont forgot chance Object_typeID = ; 


datablock WeaponData(NativeBearWeapon : BaseMeleeWeapon)
{
   id = 624;
   Object_typeID = 3010;
   
   shapefile = "art/models/3d-2d/weapons/Tribe/bearaxe.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack2HWeapon;
   WeaponType = Weapon2HAxe;
   weaponMaterial = Wooden;
   hitGroupType[0] = Slashing;
   hitGroupDmgLevel[0] = 1.3;
   hitGroupType[1] = Blunt;
   hitGroupDmgLevel[1] = 0.7;
   hitDirection[0] = "0 1"; // Thrust
   hitDirection[1] = "0 1"; // Overhead
   hitDirection[2] = "0 1"; // RightToLeftHit
   hitDirection[3] = "0 1"; // LeftToRightHit
   WoundMultiplier = 1;
   FractureMultiplier = 0.9;
   StunMultiplier = 0.00;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = PracticeMaulItem;
   BasePrefireAnimTime = 1.1;
   BaseFireAnimTime = 1.2;
   BaseRecoilAnimTime = 1.8;
};

datablock WeaponData(NativeChiefWeapon : BaseMeleeWeapon)
{
   id = 626;
   Object_typeID = 3011;
   
   shapefile = "art/models/3d-2d/weapons/Tribe/chieftainsword.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack2HSword;
   WeaponType = Weapon2HSword;
   weaponMaterial = Metal;
   hitGroupType[0] = Piercing;
   hitGroupDmgLevel[0] = 2.10;
   hitGroupType[1] =  Slashing;
   hitGroupDmgLevel[1] = 1.9;
   hitGroupType[2] =  Blunt;
   hitGroupDmgLevel[2] = 0.9;
   hitDirection[0] = "0 2"; // Thrust
   hitDirection[1] = "1 0"; // Overhead
   hitDirection[2] = "1 0"; // RightToLeftHit
   hitDirection[3] = "1 0"; // LeftToRightHit
   WoundMultiplier = 0.4;
   FractureMultiplier = 0;
   StunMultiplier = 0.0;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = ZweihaenderItem;
   BasePrefireAnimTime = 1.2;
   BaseFireAnimTime = 1.2;
   BaseRecoilAnimTime = 1.15;
};

datablock WeaponData(NativeHunterWeapon : BaseMeleeWeapon)
{
   id = 623;
   Object_typeID = 3012;
   
   shapefile = "art/models/3d-2d/weapons/Tribe/hunteraxe.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack1H;
   WeaponType = Weapon1HAxe;
   weaponMaterial = Metal;
   hitGroupType[0] = Chopping;
   hitGroupDmgLevel[0] = 2.2;
   hitGroupType[1] = Blunt;
   hitGroupDmgLevel[1] = 1.4;
   hitDirection[0] = "1"; // Thrust
   hitDirection[1] = "0"; // Overhead
   hitDirection[2] = "0"; // RightToLeftHit
   hitDirection[3] = "0"; // LeftToRightHit
   WoundMultiplier = 2.1;
   FractureMultiplier = 2.1;
   StunMultiplier = 0.6;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = WarAxeItem;
   BasePrefireAnimTime = 1.0;
   BaseFireAnimTime = 1.0;
   BaseRecoilAnimTime = 1.1;
};

datablock WeaponData(NativeMoleWeapon : BaseMeleeWeapon)
{
   id = 622;
   Object_typeID = 3014;
   
   shapefile = "art/models/3d-2d/weapons/Tribe/molepickaxe.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack2HSword;
   WeaponType = WeaponMisc;
   weaponMaterial = Wooden;
   hitGroupType[0] = Piercing;
   hitGroupDmgLevel[0] = 1.3;
   hitGroupType[1] =  Blunt;
   hitGroupDmgLevel[1] = 1.2;
   hitGroupType[1] = Piercing;
   hitGroupDmgLevel[3] = 1;
   hitDirection[0] = "0 2"; // Thrust
   hitDirection[1] = "0 1"; // Overhead
   hitDirection[2] = "0 1"; // RightToLeftHit
   hitDirection[3] = "0 1"; // LeftToRightHit
   WoundMultiplier = 0;
   FractureMultiplier = 0;
   StunMultiplier = 0;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = PickaxeItem;
};

datablock WeaponData(NativeWitchWeapon : BaseMeleeWeapon)
{
   id = 625;
   Object_typeID = 3015;
   
   shapefile = "art/models/3d-2d/weapons/Tribe/witchsickle.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack1H;
   WeaponType = WeaponMisc;
   weaponMaterial = Wooden;
   hitGroupType[0] = Piercing;
   hitGroupDmgLevel[0] = 1.4;
   hitGroupType[1] =  Blunt;
   hitGroupDmgLevel[1] = 1.2;
   hitDirection[0] = "0 1"; // Thrust
   hitDirection[1] = "0 1"; // Overhead
   hitDirection[2] = "0 1"; // RightToLeftHit
   hitDirection[3] = "0 1"; // LeftToRightHit
   WoundMultiplier = 0.2;
   FractureMultiplier = 0;
   StunMultiplier = 0;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = SickleItem;
};