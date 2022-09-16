
--
-- Dumping data for table `objects_types`
--
-- ORDER BY:  `ID`

`objects_types` (`ID`, `ParentID`, `Name`, `IsContainer`, `IsMovableObject`, `IsUnmovableobject`, `IsTool`, `IsDevice`, `IsDoor`, `IsPremium`, `MaxContSize`, `Length`, `MaxStackSize`, `UnitWeight`, `BackgndImage`, `WorkAreaTop`, `WorkAreaLeft`, `WorkAreaWidth`, `WorkAreaHeight`, `BtnCloseTop`, `BtnCloseLeft`, `FaceImage`, `Description`, `BasePrice`, `OwnerTimeout`, `AllowExportFromRed`, `AllowExportFromGreen`) VALUES

(3000,751,'Tribe Bear',0,1,0,0,0,0,0,0,0,0,1,'',0,0,0,0,0,0,'','',0,NULL,0,0),
(3001,59,'Tribe Bear Carcass',1,1,0,0,0,0,0,100000,5,0,1,'art\\images\\universal',0,0,0,0,0,0,'','',0,300,0,0),
(3002,751,'Tribe Chieftain',0,1,0,0,0,0,0,0,0,0,1,'',0,0,0,0,0,0,'','',0,NULL,0,0),
(3003,59,'Tribe Chieftain Carcass',1,1,0,0,0,0,0,100000,5,0,1,'art\\images\\universal',0,0,0,0,0,0,'','',0,300,0,0),
(3004,751,'Tribe Hunter',0,1,0,0,0,0,0,0,0,0,1,'',0,0,0,0,0,0,'','',0,NULL,0,0),
(3005,59,'Tribe Hunter Carcass',1,1,0,0,0,0,0,100000,5,0,1,'art\\images\\universal',0,0,0,0,0,0,'','',0,300,0,0),
(3006,751,'Tribe Mole',0,1,0,0,0,0,0,0,0,0,1,'',0,0,0,0,0,0,'','',0,NULL,0,0),
(3007,59,'Tribe Mole Carcass',1,1,0,0,0,0,0,100000,5,0,1,'art\\images\\universal',0,0,0,0,0,0,'','',0,300,0,0),
(3008,751,'Tribe Witch',0,1,0,0,0,0,0,0,0,0,1,'',0,0,0,0,0,0,'','',0,NULL,0,0),
(3009,59,'Tribe Witch Carcass',1,1,0,0,0,0,0,100000,5,0,1,'art\\images\\universal',0,0,0,0,0,0,'','',0,300,0,0),
(3010,191,'Bear Axe',0,0,0,0,0,0,0,0,4,1,5000,'',0,0,0,0,0,0,'art\\2D\\Items\\bearaxe.png','',0,NULL,1,1),
(3011,57,'Chieftain Sword',0,0,0,0,0,0,0,0,4,1,4500,'',0,0,0,0,0,0,'art\\2D\\Items\\chieftainsword.png','',3000,NULL,1,1),
(3012,190,'Hunter Axe',0,0,0,0,0,0,0,0,3,1,1300,'',0,0,0,0,0,0,'art\\2D\\Items\\hunteraxe.png','',3000,NULL,1,1),
(3013,196,'Hunter Bow',0,0,0,0,0,0,0,0,3,1,3000,'',0,0,0,0,0,0,'art\\2D\\Items\\hunterbow.png','',20000,NULL,1,1),
(3014,35,'Mole Pickaxe',0,0,0,1,0,0,0,0,2,1,1500,'',0,0,0,0,0,0,'art\\2D\\Items\\molepickaxe.png','',3000,NULL,1,1),
(3015,1031,'Witch Sickle',0,0,0,1,0,0,0,0,2,1,1000,'',0,0,0,0,0,0,'art\\2D\\Items\\witchsickle.png','',3100,NULL,1,1),

--
-- Dumping data for table `recipe`
--
-- ORDER BY:  `ID`

`recipe` (`ID`, `Name`, `Description`, `StartingToolsID`, `SkillTypeID`, `SkillLvl`, `ResultObjectTypeID`, `SkillDepends`, `Quantity`, `Autorepeat`, `IsBlueprint`, `ImagePath`) VALUES

(3001,'Tribe Bear Sack','',36,8,500,3001,0,1,0,0,''),
(3003,'Tribe Chieftain Sack','',36,8,500,3003,0,1,0,0,''),
(3005,'Tribe Hunter Sack','',36,8,500,3005,0,1,0,0,''),
(3007,'Tribe Mole Sack','',36,8,500,3007,0,1,0,0,''),
(3009,'Tribe Witch Sack','',36,8,500,3009,0,1,0,0,'');
