﻿namespace OverwatchHighlights
{
	enum WeaponSkin : uint
	{
		Mercy_Celestial                    = 0x00001E9F,
		Mercy_Orchid                       = 0x00001EA3,
		Hanzo_Midori                       = 0x00001EC1,
		McCree_Gambler                     = 0x00001ECD,
		McCree_Gambler_Golden              = 0x00001ECE,
		McCree_Classic                     = 0x00001ED5,
		Zenyatta_Ifrit                     = 0x00001EDF,
		Zenyatta_Sunyatta                  = 0x00001EE7,
		Zenyatta_Classic                   = 0x00001EED,
		Junkrat_Irradiated                 = 0x00001EF9,
		Lucio_Classic                      = 0x00001EFD,
		Doomfist_Classic                   = 0x00001F05,
		Doomfist_Classic_Golden            = 0x00001F06,
		Mei_Classic                        = 0x00001F25,
		Bastion_Overgrown                  = 0x00001F2D,
		Bastion_Classic                    = 0x00001F35,
		Sombra_Classic                     = 0x00001F3D,
		Torbjorn_Classic                   = 0x00001F55,
		Zarya_Classic                      = 0x00001FBD,
		Roadhog_Classic                    = 0x0000202D,
		Soldier76_StrikeCommanderMorrison  = 0x0000206D,
		Soldier76_Classic                  = 0x00002075,
		Winston_Safari                     = 0x0000207F,
		Winston_Frogston                   = 0x00002087,
		Winston_Banana                     = 0x00002093,
		Genji_Classic                      = 0x00002095,
		Symmetra_Saffron                   = 0x000020BB,
		Tracer_Classic                     = 0x00002105,
		Widowmaker_Odette                  = 0x0000210F,
		Widowmaker_Odette_Golden           = 0x00002110,
		Widowmaker_Ciel                    = 0x0000211F,
		Pharah_Raptorion                   = 0x000021B7,
		Pharah_Raptorion_Golden            = 0x000021B8,
		Junkrat_Hayseed                    = 0x000021DF,
		Genji_YoungGenji                   = 0x000021ED,
		Genji_Sparrow                      = 0x000021EF,
		Genji_Sparrow_Golden               = 0x000021F0,
		DVa_Scavenger                      = 0x00002227,
		Zenyatta_Ascendant                 = 0x00002453,
		Junkrat_Drowned                    = 0x00002457,
		Junkrat_Jailbird                   = 0x00002459,
		Junkrat_Jailbird_Golden            = 0x0000245A,
		Doomfist_Painted                   = 0x00002465,
		Sombra_Virus                       = 0x0000247F,
		Soldier76_Bone                     = 0x000024A7,
		Genji_CarbonFiber                  = 0x000024B3,
		Genji_CarbonFiber_Golden           = 0x000024B4,
		Symmetra_Regal                     = 0x000024B9,
		Mei_YetiHunter                     = 0x00002505,
		Mei_Abominable                     = 0x00002507,
		Ana_Classic                        = 0x00002519,
		Pharah_Anubis                      = 0x00002527,
		Pharah_Jackal                      = 0x00002529,
		Reinhardt_Greifhardt               = 0x00002581,
		DVa_Cruiser                        = 0x000025AF,
		Sombra_LosMuertos                  = 0x000025EB,
		Sombra_LosMuertos_Golden           = 0x000025EC,
		Sombra_Azucar                      = 0x000025ED,
		Sombra_Cyberspace                  = 0x000025EF,
		Sombra_Cyberspace_Golden           = 0x000025F0,
		Tracer_Rose                        = 0x000028E2,
		Tracer_Graffiti                    = 0x0000292A,
		Mercy_CombatMedicZiegler           = 0x000029CA,
		Bastion_DuneBuggy                  = 0x000029F4,
		Torbjorn_ChiefEngineerLindholm     = 0x00002A2E,
		Widowmaker_Talon                   = 0x00002A32,

		// -- anything below here is known to exist but i've not mapped the value to a name yet --
		Ana_skin_00001923_weapon_0000251D = 0x0000251D,
		Ana_skin_00001926_weapon_00002523 = 0x00002523,
		Ana_skin_00001927_weapon_00002525 = 0x00002525,
		Ana_skin_0000194A_weapon_0000256B = 0x0000256B,
		Ana_skin_0000194B_weapon_0000256D = 0x0000256D,
		Ana_skin_0000194B_weapon_0000256E = 0x0000256E,
		Ana_skin_00001950_weapon_00002577 = 0x00002577,
		Ana_skin_00001951_weapon_00002579 = 0x00002579,
		Ana_skin_00001951_weapon_0000257A = 0x0000257A,
		Ana_skin_0000199C_weapon_0000260D = 0x0000260D,
		Ana_skin_00001B11_weapon_000028F6 = 0x000028F6,

		Bastion_Classic_weapon_00001F36 = 0x00001F36,
		Bastion_skin_00001629_weapon_00001F39 = 0x00001F39,
		Bastion_skin_00001795_weapon_0000220F = 0x0000220F,
		Bastion_skin_00001799_weapon_00002217 = 0x00002217,
		Bastion_skin_000018CC_weapon_00002475 = 0x00002475,
		Bastion_skin_000018CE_weapon_00002479 = 0x00002479,

		Doomfist_skin_00001611_weapon_00001F09 = 0x00001F09,
		Doomfist_skin_000018C5_weapon_00002467 = 0x00002467,
		Doomfist_skin_00001BDA_weapon_00002A86 = 0x00002A86,
		Doomfist_skin_00001BE3_weapon_00002A98 = 0x00002A98,
		Doomfist_skin_00001BE4_weapon_00002A9A = 0x00002A9A,

		DVa_skin_00001613_weapon_00001F0D = 0x00001F0D,
		DVa_skin_00001615_weapon_00001F11 = 0x00001F11,
		DVa_skin_00001616_weapon_00001F13 = 0x00001F13,
		DVa_skin_00001764_weapon_000021AD = 0x000021AD,
		DVa_skin_00001764_weapon_000021AE = 0x000021AE,
		DVa_skin_00001765_weapon_000021AF = 0x000021AF,
		DVa_skin_000017A0_weapon_00002225 = 0x00002225,
		DVa_skin_000018C7_weapon_0000246B = 0x0000246B,
		DVa_skin_000018C8_weapon_0000246D = 0x0000246D,
		DVa_skin_00001A19_weapon_00002708 = 0x00002708,
		DVa_skin_00001BB0_weapon_00002A34 = 0x00002A34,

		Genji_skin_000016DA_weapon_0000209B = 0x0000209B,
		Genji_skin_00001788_weapon_000021F5 = 0x000021F5,
		Genji_skin_000018EC_weapon_000024B5 = 0x000024B5,
		Genji_skin_00001994_weapon_000025FF = 0x000025FF,
		Genji_skin_00001B7D_weapon_000029CE = 0x000029CE,
		Genji_skin_00001B7D_weapon_000029CF = 0x000029CF,
		Genji_skin_00001B91_weapon_000029F6 = 0x000029F6,

		Hanzo_skin_000015E3_weapon_00001EAD = 0x00001EAD,
		Hanzo_skin_000015E4_weapon_00001EAF = 0x00001EAF,
		Hanzo_skin_000015E4_weapon_00001EB0 = 0x00001EB0,
		Hanzo_skin_000015E7_weapon_00001EB5 = 0x00001EB5,
		Hanzo_skin_000015E8_weapon_00001EB7 = 0x00001EB7,
		Hanzo_skin_000015E8_weapon_00001EB8 = 0x00001EB8,
		Hanzo_skin_000015EB_weapon_00001EBD = 0x00001EBD,
		Hanzo_skin_000015EC_weapon_00001EBF = 0x00001EBF,
		Hanzo_skin_000015EE_weapon_00001EC3 = 0x00001EC3,
		Hanzo_skin_000018B5_weapon_00002447 = 0x00002447,
		Hanzo_skin_000018B6_weapon_00002449 = 0x00002449,
		Hanzo_skin_000019A7_weapon_00002623 = 0x00002623,
		Hanzo_skin_000019B0_weapon_0000263A = 0x0000263A,

		Junkrat_skin_00001607_weapon_00001EF5 = 0x00001EF5,
		Junkrat_skin_0000160A_weapon_00001EFB = 0x00001EFB,
		Junkrat_skin_0000177C_weapon_000021DD = 0x000021DD,
		Junkrat_skin_0000179C_weapon_0000221D = 0x0000221D,
		Junkrat_skin_0000179D_weapon_0000221F = 0x0000221F,
		Junkrat_skin_00001962_weapon_0000259B = 0x0000259B,
		Junkrat_skin_00001A2D_weapon_0000272E = 0x0000272E,

		Lucio_skin_0000160C_weapon_00001EFF = 0x00001EFF,
		Lucio_skin_0000160D_weapon_00001F01 = 0x00001F01,
		Lucio_skin_00001778_weapon_000021D5 = 0x000021D5,
		Lucio_skin_00001779_weapon_000021D7 = 0x000021D7,
		Lucio_skin_000018C1_weapon_0000245F = 0x0000245F,
		Lucio_skin_000018C2_weapon_00002461 = 0x00002461,
		Lucio_skin_00001910_weapon_000024FD = 0x000024FD,
		Lucio_skin_00001911_weapon_000024FF = 0x000024FF,
		Lucio_skin_00001A0B_weapon_000026EC = 0x000026EC,
		Lucio_skin_00001A0B_weapon_000026ED = 0x000026ED,
		Lucio_skin_00001B94_weapon_000029FC = 0x000029FC,
		Lucio_skin_00001B94_weapon_000029FD = 0x000029FD,

		McCree_skin_000015EF_weapon_00001EC5 = 0x00001EC5,
		McCree_skin_000015F0_weapon_00001EC7 = 0x00001EC7,
		McCree_skin_000015F4_weapon_00001ECF = 0x00001ECF,
		McCree_skin_000015F4_weapon_00001ED0 = 0x00001ED0,
		McCree_skin_000015F8_weapon_00001ED7 = 0x00001ED7,
		McCree_skin_000015FA_weapon_00001EDB = 0x00001EDB,
		McCree_skin_000018B7_weapon_0000244B = 0x0000244B,
		McCree_skin_000018B8_weapon_0000244D = 0x0000244D,
		McCree_skin_000018B9_weapon_0000244F = 0x0000244F,
		McCree_skin_00001976_weapon_000025C3 = 0x000025C3,
		McCree_skin_000019B6_weapon_00002646 = 0x00002646,
		McCree_skin_000019B6_weapon_00002647 = 0x00002647,
		McCree_skin_00001A12_weapon_000026FA = 0x000026FA,

		Mei_skin_00001622_weapon_00001F2B = 0x00001F2B,
		Mei_skin_000017A4_weapon_0000222D = 0x0000222D,
		Mei_skin_000017A5_weapon_0000222F = 0x0000222F,
		Mei_skin_000018C9_weapon_0000246F = 0x0000246F,
		Mei_skin_000018CB_weapon_00002473 = 0x00002473,
		Mei_skin_00001981_weapon_000025D9 = 0x000025D9,
		Mei_skin_00001982_weapon_000025DB = 0x000025DB,

		Mercy_skin_000015D3_weapon_00001E8D = 0x00001E8D,
		Mercy_Sigrun_weapon_00001E8F = 0x00001E8F,
		Mercy_skin_000015D7_weapon_00001E95 = 0x00001E95,
		Mercy_skin_000015DB_weapon_00001E9D = 0x00001E9D,
		Mercy_skin_000015DD_weapon_00001EA1 = 0x00001EA1,
		Mercy_skin_000018AE_weapon_00002439 = 0x00002439,
		Mercy_skin_000018AF_weapon_0000243B = 0x0000243B,
		Mercy_skin_000018B0_weapon_0000243D = 0x0000243D,
		Mercy_skin_0000196A_weapon_000025AB = 0x000025AB,
		Mercy_skin_00001A2A_weapon_00002728 = 0x00002728,

		Orisa_skin_00001933_weapon_0000253D = 0x0000253D,
		Orisa_skin_00001934_weapon_0000253F = 0x0000253F,
		Orisa_skin_00001938_weapon_00002547 = 0x00002547,
		Orisa_skin_00001B61_weapon_00002996 = 0x00002996,
		Orisa_skin_00001B62_weapon_00002998 = 0x00002998,
		Orisa_skin_00001B63_weapon_0000299A = 0x0000299A,
		Orisa_skin_00001B64_weapon_0000299C = 0x0000299C,
		Orisa_skin_00001B65_weapon_0000299E = 0x0000299E,
		Orisa_skin_00001B95_weapon_000029FE = 0x000029FE,

		Pharah_skin_000016A7_weapon_00002035 = 0x00002035,
		Pharah_skin_000016BF_weapon_00002065 = 0x00002065,
		Pharah_skin_000016C2_weapon_0000206B = 0x0000206B,
		Pharah_skin_0000192A_weapon_0000252B = 0x0000252B,
		Pharah_skin_0000192B_weapon_0000252D = 0x0000252D,
		Pharah_skin_000019A0_weapon_00002615 = 0x00002615,
		Pharah_skin_000019E6_weapon_000026A2 = 0x000026A2,
		Pharah_skin_00001A16_weapon_00002702 = 0x00002702,

		Reaper_skin_0000167B_weapon_00001FDD = 0x00001FDD,
		Reaper_skin_0000167C_weapon_00001FDF = 0x00001FDF,
		Reaper_skin_0000168B_weapon_00001FFD = 0x00001FFD,
		Reaper_skin_00001697_weapon_00002015 = 0x00002015,
		Reaper_skin_00001698_weapon_00002017 = 0x00002017,
		Reaper_skin_00001699_weapon_00002019 = 0x00002019,
		Reaper_skin_0000169A_weapon_0000201B = 0x0000201B,
		Reaper_skin_00001770_weapon_000021C5 = 0x000021C5,
		Reaper_skin_000018DB_weapon_00002493 = 0x00002493,
		Reaper_skin_000018DC_weapon_00002495 = 0x00002495,
		Reaper_skin_000018DD_weapon_00002497 = 0x00002497,
		Reaper_skin_00001A07_weapon_000026E4 = 0x000026E4,

		Reinhardt_skin_0000163B_weapon_00001F5D = 0x00001F5D,
		Reinhardt_skin_0000163F_weapon_00001F65 = 0x00001F65,
		Reinhardt_skin_0000165F_weapon_00001FA5 = 0x00001FA5,
		Reinhardt_skin_00001660_weapon_00001FA7 = 0x00001FA7,
		Reinhardt_skin_00001662_weapon_00001FAB = 0x00001FAB,
		Reinhardt_skin_000017B1_weapon_00002247 = 0x00002247,
		Reinhardt_skin_000018D5_weapon_00002487 = 0x00002487,
		Reinhardt_skin_00001954_weapon_0000257F = 0x0000257F,
		Reinhardt_skin_00001B87_weapon_000029E2 = 0x000029E2,

		Roadhog_skin_0000169B_weapon_0000201D = 0x0000201D,
		Roadhog_skin_0000169C_weapon_0000201F = 0x0000201F,
		Roadhog_skin_0000169F_weapon_00002025 = 0x00002025,
		Roadhog_skin_000016A0_weapon_00002027 = 0x00002027,
		Roadhog_skin_000016A5_weapon_00002031 = 0x00002031,
		Roadhog_skin_000016A6_weapon_00002033 = 0x00002033,
		Roadhog_skin_0000197D_weapon_000025D1 = 0x000025D1,
		Roadhog_skin_00001A14_weapon_000026FE = 0x000026FE,

		Soldier76_skin_000016C9_weapon_00002079 = 0x00002079,
		Soldier76_skin_000016CA_weapon_0000207B = 0x0000207B,
		Soldier76_skin_0000178C_weapon_000021FD = 0x000021FD,
		Soldier76_skin_0000178D_weapon_000021FF = 0x000021FF,
		Soldier76_skin_00001790_weapon_00002205 = 0x00002205,
		Soldier76_skin_00001791_weapon_00002207 = 0x00002207,
		Soldier76_skin_000018E4_weapon_000024A5 = 0x000024A5,
		Soldier76_skin_000018E6_weapon_000024A9 = 0x000024A9,
		Soldier76_skin_000019A6_weapon_00002621 = 0x00002621,
		Soldier76_skin_00001A1E_weapon_00002712 = 0x00002712,

		Sombra_skin_0000162D_weapon_00001F41 = 0x00001F41,
		Sombra_skin_0000162E_weapon_00001F43 = 0x00001F43,
		Sombra_skin_000018CF_weapon_0000247B = 0x0000247B,
		Sombra_skin_0000198D_weapon_000025F1 = 0x000025F1,
		Sombra_skin_00001A1D_weapon_00002710 = 0x00002710,

		Symmetra_skin_000016DB_weapon_0000209D = 0x0000209D,
		Symmetra_skin_000016E4_weapon_000020AF = 0x000020AF,
		Symmetra_skin_000016E7_weapon_000020B5 = 0x000020B5,
		Symmetra_skin_000016E8_weapon_000020B7 = 0x000020B7,
		Symmetra_skin_000016E9_weapon_000020B9 = 0x000020B9,
		Symmetra_skin_000018ED_weapon_000024B7 = 0x000024B7,
		Symmetra_skin_000018EF_weapon_000024BB = 0x000024BB,
		Symmetra_skin_00001A27_weapon_00002724 = 0x00002724,
		Symmetra_Oasis_weapon_000029F8 = 0x000029F8,

		Torbjorn_skin_0000162F_weapon_00001F45 = 0x00001F45,
		Torbjorn_skin_00001630_weapon_00001F47 = 0x00001F47,
		Torbjorn_skin_00001633_weapon_00001F4D = 0x00001F4D,
		Torbjorn_skin_00001634_weapon_00001F4F = 0x00001F4F,
		Torbjorn_Citron_weapon_00001F57 = 0x00001F57,
		Torbjorn_skin_00001639_weapon_00001F59 = 0x00001F59,
		Torbjorn_skin_000018D2_weapon_00002481 = 0x00002481,
		Torbjorn_skin_000018D3_weapon_00002483 = 0x00002483,
		Torbjorn_skin_000018D4_weapon_00002485 = 0x00002485,
		Torbjorn_skin_00001968_weapon_000025A7 = 0x000025A7,
		Torbjorn_skin_00001B60_weapon_00002994 = 0x00002994,

		Tracer_skin_000016EB_weapon_000020BD = 0x000020BD,
		Tracer_skin_000016F7_weapon_000020D5 = 0x000020D5,
		Tracer_skin_0000170B_weapon_000020FD = 0x000020FD,
		Tracer_skin_000018F1_weapon_000024BF = 0x000024BF,
		Tracer_skin_000018F2_weapon_000024C1 = 0x000024C1,
		Tracer_skin_00001942_weapon_0000255B = 0x0000255B,
		Tracer_skin_00001943_weapon_0000255D = 0x0000255D,
		Tracer_skin_0000195E_weapon_00002593 = 0x00002593,
		Tracer_skin_00001B66_weapon_000029A0 = 0x000029A0,
		Tracer_skin_00001B66_weapon_000029A1 = 0x000029A1,

		Widowmaker_skin_00001713_weapon_0000210D = 0x0000210D,
		Widowmaker_skin_00001717_weapon_00002115 = 0x00002115,
		Widowmaker_skin_0000171B_weapon_0000211D = 0x0000211D,
		Widowmaker_skin_0000171D_weapon_00002121 = 0x00002121,
		Widowmaker_skin_0000171E_weapon_00002123 = 0x00002123,
		Widowmaker_skin_000018F3_weapon_000024C3 = 0x000024C3,
		Widowmaker_skin_000018F4_weapon_000024C5 = 0x000024C5,
		Widowmaker_Patina_weapon_000024C7 = 0x000024C7,
		Widowmaker_skin_00001918_weapon_0000250D = 0x0000250D,
		Widowmaker_skin_00001919_weapon_0000250F = 0x0000250F,
		Widowmaker_skin_00001919_weapon_00002510 = 0x00002510,

		Winston_skin_000016CB_weapon_0000207D = 0x0000207D,
		Winston_skin_000016CF_weapon_00002085 = 0x00002085,
		Winston_skin_000016D3_weapon_0000208D = 0x0000208D,
		Winston_skin_000016D4_weapon_0000208F = 0x0000208F,
		Winston_skin_000016D5_weapon_00002091 = 0x00002091,
		Winston_skin_000018E7_weapon_000024AB = 0x000024AB,
		Winston_skin_000018E9_weapon_000024AF = 0x000024AF,
		Winston_skin_00001964_weapon_0000259F = 0x0000259F,
		Winston_skin_0000197F_weapon_000025D5 = 0x000025D5,

		Zarya_skin_00001663_weapon_00001FAD = 0x00001FAD,
		Zarya_skin_00001667_weapon_00001FB5 = 0x00001FB5,
		Zarya_skin_00001668_weapon_00001FB7 = 0x00001FB7,
		Zarya_skin_0000166D_weapon_00001FC1 = 0x00001FC1,
		Zarya_skin_0000166E_weapon_00001FC3 = 0x00001FC3,
		Zarya_skin_000018D8_weapon_0000248D = 0x0000248D,
		Zarya_skin_000018D9_weapon_0000248F = 0x0000248F,
		Zarya_skin_00001944_weapon_00002560 = 0x00002560,
		Zarya_skin_00001A1B_weapon_0000270C = 0x0000270C,
		Zarya_skin_00001B6A_weapon_000029A8 = 0x000029A8,

		Zenyatta_skin_000015FF_weapon_00001EE5 = 0x00001EE5,
		Zenyatta_skin_000018BA_weapon_00002451 = 0x00002451,
		Zenyatta_skin_000018BC_weapon_00002455 = 0x00002455,
		Zenyatta_skin_00001960_weapon_00002597 = 0x00002597,
		Zenyatta_skin_00001966_weapon_000025A3 = 0x000025A3,
	}
}
