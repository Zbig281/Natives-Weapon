// Tribe_Weapon
singleton Material(Tribe_Weapon_DIFFUSE_ns_mat)
{
   mapTo = "Tribe_Weapon_DIFFUSE_ns";
   diffuseMap[0] = "art/Textures/Tribe/Tribe_Weapon_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/Tribe/Tribe_Weapon_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/Tribe/Tribe_Weapon_SPECULAR.dds";
   materialTag0 = "LiF";
   behaveAsParticle = true;
};
exec("art/female_materials.cs");
exec("art/materials_environment.cs");
