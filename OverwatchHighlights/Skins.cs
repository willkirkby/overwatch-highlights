﻿namespace OverwatchHighlights
{
	enum Skin : uint
	{
		Mercy_Sigrun                      = 0x000015D4,
		McCree_Classic                    = 0x000015F7,
		Zenyatta_Ifrit                    = 0x000015FC,
		Zenyatta_Sunyatta                 = 0x00001600,
		Zenyatta_Classic                  = 0x00001603,
		Junkrat_Irradiated                = 0x00001609,
		Lucio_Classic                     = 0x0000160B,
		Doomfist_Classic                  = 0x0000160F,
		Mei_Classic                       = 0x0000161F,
		Bastion_Classic                   = 0x00001627,
		Sombra_Classic                    = 0x0000162B,
		Zarya_Classic                     = 0x0000166B,
		Roadhog_Classic                   = 0x000016A3,
		Soldier76_StrikeCommanderMorrison = 0x000016C3,
		Soldier76_Classic                 = 0x000016C7,
		Genji_Classic                     = 0x000016D7,
		Widowmaker_Odette                 = 0x00001714,
		Widowmaker_Ciel                   = 0x0000171C,
		Junkrat_Hayseed                   = 0x0000177D,
		Genji_Sparrow                     = 0x00001785,
		Zenyatta_Ascendant                = 0x000018BB,
		Doomfist_Painted                  = 0x000018C4,
		Sombra_Virus                      = 0x000018D1,
		Genji_CarbonFiber                 = 0x000018EB,
		Mei_YetiHunter                    = 0x00001914,
		Ana_Classic                       = 0x00001921,
		Pharah_Anubis                     = 0x00001928,
		Sombra_LosMuertos                 = 0x0000198A,
		Sombra_Azucar                     = 0x0000198B,
		Sombra_Cyberspace                 = 0x0000198C,
		Tracer_Rose                       = 0x00001B07,
		Mercy_CombatMedicZiegler          = 0x00001B7B,

		// -- anything below here is known to exist but i've not mapped the value to a name yet --
		Ana_skin_00001923 = 0x00001923,
		Ana_skin_00001927 = 0x00001927,
		Ana_skin_0000194A = 0x0000194A,
		Ana_skin_0000194B = 0x0000194B,
		Ana_skin_00001950 = 0x00001950,
		Ana_skin_00001951 = 0x00001951,
		Ana_skin_0000199C = 0x0000199C,
		Ana_skin_00001B11 = 0x00001B11,

		Bastion_skin_00001623 = 0x00001623,
		Bastion_skin_00001629 = 0x00001629,
		Bastion_skin_00001795 = 0x00001795,
		Bastion_skin_00001799 = 0x00001799,
		Bastion_skin_000018CE = 0x000018CE,
		Bastion_skin_00001B90 = 0x00001B90,

		Doomfist_skin_00001611 = 0x00001611,
		Doomfist_skin_000018C5 = 0x000018C5,

		DVa_skin_00001613 = 0x00001613,
		DVa_skin_00001615 = 0x00001615,
		DVa_skin_00001616 = 0x00001616,
		DVa_skin_00001764 = 0x00001764,
		DVa_skin_00001765 = 0x00001765,
		DVa_skin_000017A0 = 0x000017A0,
		DVa_skin_000017A1 = 0x000017A1,
		DVa_skin_000018C7 = 0x000018C7,
		DVa_skin_000018C8 = 0x000018C8,
		DVa_skin_0000196C = 0x0000196C,
		DVa_skin_00001A19 = 0x00001A19,
		DVa_skin_00001BB0 = 0x00001BB0,

		Genji_skin_000016DA = 0x000016DA,
		Genji_skin_00001784 = 0x00001784,
		Genji_skin_00001788 = 0x00001788,
		Genji_skin_000018EC = 0x000018EC,
		Genji_skin_00001994 = 0x00001994,
		Genji_skin_00001B7D = 0x00001B7D,
		Genji_skin_00001B91 = 0x00001B91,

		Hanzo_skin_000015E3 = 0x000015E3,
		Hanzo_skin_000015E4 = 0x000015E4,
		Hanzo_skin_000015E7 = 0x000015E7,
		Hanzo_skin_000015E8 = 0x000015E8,
		Hanzo_skin_000015EB = 0x000015EB,
		Hanzo_skin_000015EC = 0x000015EC,
		Hanzo_skin_000015EE = 0x000015EE,
		Hanzo_skin_000018B5 = 0x000018B5,
		Hanzo_skin_000019B0 = 0x000019B0,

		Junkrat_skin_00001607 = 0x00001607,
		Junkrat_skin_0000160A = 0x0000160A,
		Junkrat_skin_0000177C = 0x0000177C,
		Junkrat_skin_0000179C = 0x0000179C,
		Junkrat_skin_0000179D = 0x0000179D,
		Junkrat_skin_000018BE = 0x000018BE,
		Junkrat_skin_00001962 = 0x00001962,

		Lucio_skin_0000160D = 0x0000160D,
		Lucio_skin_00001778 = 0x00001778,
		Lucio_skin_000018C1 = 0x000018C1,
		Lucio_skin_000018C2 = 0x000018C2,
		Lucio_skin_00001911 = 0x00001911,
		Lucio_skin_00001A0B = 0x00001A0B,

		McCree_skin_000015EF = 0x000015EF,
		McCree_skin_000015F0 = 0x000015F0,
		McCree_skin_000015F3 = 0x000015F3,
		McCree_skin_000015F4 = 0x000015F4,
		McCree_skin_000015FA = 0x000015FA,
		McCree_skin_000018B7 = 0x000018B7,
		McCree_skin_000018B8 = 0x000018B8,
		McCree_skin_00001976 = 0x00001976,
		McCree_skin_000019B6 = 0x000019B6,
		McCree_skin_00001A12 = 0x00001A12,

		Mei_skin_00001622 = 0x00001622,
		Mei_skin_000017A5 = 0x000017A5,
		Mei_skin_000018C9 = 0x000018C9,
		Mei_skin_000018CB = 0x000018CB,
		Mei_skin_00001915 = 0x00001915,
		Mei_skin_00001981 = 0x00001981,
		Mei_skin_00001982 = 0x00001982,

		Mercy_skin_000015D3 = 0x000015D3,
		Mercy_skin_000015DB = 0x000015DB,
		Mercy_skin_000015DC = 0x000015DC,
		Mercy_skin_000015DE = 0x000015DE,
		Mercy_skin_000018AE = 0x000018AE,
		Mercy_skin_000018B0 = 0x000018B0,
		Mercy_skin_0000196A = 0x0000196A,
		Mercy_skin_00001A2A = 0x00001A2A,

		Orisa_skin_00001933 = 0x00001933,
		Orisa_skin_00001934 = 0x00001934,
		Orisa_skin_00001B61 = 0x00001B61,
		Orisa_skin_00001B63 = 0x00001B63,
		Orisa_skin_00001B64 = 0x00001B64,
		Orisa_skin_00001B65 = 0x00001B65,
		Orisa_skin_00001B95 = 0x00001B95,

		Pharah_skin_000016A7 = 0x000016A7,
		Pharah_skin_000016BF = 0x000016BF,
		Pharah_skin_000016C2 = 0x000016C2,
		Pharah_skin_00001769 = 0x00001769,
		Pharah_skin_00001929 = 0x00001929,
		Pharah_skin_0000192A = 0x0000192A,
		Pharah_skin_0000192B = 0x0000192B,
		Pharah_skin_000019E6 = 0x000019E6,
		Pharah_skin_00001A16 = 0x00001A16,

		Reaper_skin_0000167B = 0x0000167B,
		Reaper_skin_0000167C = 0x0000167C,
		Reaper_skin_0000168B = 0x0000168B,
		Reaper_skin_00001697 = 0x00001697,
		Reaper_skin_00001698 = 0x00001698,
		Reaper_skin_000018DB = 0x000018DB,
		Reaper_skin_000018DC = 0x000018DC,
		Reaper_skin_000018DD = 0x000018DD,
		Reaper_skin_00001A07 = 0x00001A07,

		Reinhardt_skin_0000163B = 0x0000163B,
		Reinhardt_skin_0000163F = 0x0000163F,
		Reinhardt_skin_0000165F = 0x0000165F,
		Reinhardt_skin_00001662 = 0x00001662,
		Reinhardt_skin_000018D5 = 0x000018D5,
		Reinhardt_skin_00001B87 = 0x00001B87,

		Roadhog_skin_0000169B = 0x0000169B,
		Roadhog_skin_0000169C = 0x0000169C,
		Roadhog_skin_000016A0 = 0x000016A0,
		Roadhog_skin_000016A5 = 0x000016A5,
		Roadhog_skin_000016A6 = 0x000016A6,
		Roadhog_skin_0000197D = 0x0000197D,
		Roadhog_skin_00001A14 = 0x00001A14,

		Soldier76_skin_000016CA = 0x000016CA,
		Soldier76_skin_0000178C = 0x0000178C,
		Soldier76_skin_0000178D = 0x0000178D,
		Soldier76_skin_00001791 = 0x00001791,
		Soldier76_skin_000018E4 = 0x000018E4,
		Soldier76_skin_000018E5 = 0x000018E5,
		Soldier76_skin_000018E6 = 0x000018E6,
		Soldier76_skin_000019A6 = 0x000019A6,
		Soldier76_skin_00001A1E = 0x00001A1E,

		Sombra_skin_0000162D = 0x0000162D,
		Sombra_skin_0000162E = 0x0000162E,
		Sombra_skin_000018CF = 0x000018CF,
		Sombra_skin_0000198D = 0x0000198D,
		Sombra_skin_00001A1D = 0x00001A1D,

		Symmetra_skin_000016DB = 0x000016DB,
		Symmetra_skin_000016E7 = 0x000016E7,
		Symmetra_skin_000016E8 = 0x000016E8,
		Symmetra_skin_000016E9 = 0x000016E9,
		Symmetra_skin_000016EA = 0x000016EA,
		Symmetra_skin_000018EF = 0x000018EF,
		Symmetra_skin_00001A27 = 0x00001A27,
		Symmetra_skin_00001B92 = 0x00001B92,

		Torbjorn_skin_0000162F = 0x0000162F,
		Torbjorn_skin_00001633 = 0x00001633,
		Torbjorn_skin_00001634 = 0x00001634,
		Torbjorn_skin_00001637 = 0x00001637,
		Torbjorn_skin_00001638 = 0x00001638,
		Torbjorn_skin_00001639 = 0x00001639,
		Torbjorn_skin_000018D2 = 0x000018D2,
		Torbjorn_skin_000018D3 = 0x000018D3,
		Torbjorn_skin_00001B60 = 0x00001B60,
		Torbjorn_skin_00001BAD = 0x00001BAD,

		Tracer_skin_000016EB = 0x000016EB,
		Tracer_skin_000016F7 = 0x000016F7,
		Tracer_skin_0000170B = 0x0000170B,
		Tracer_skin_0000170F = 0x0000170F,
		Tracer_skin_000018F1 = 0x000018F1,
		Tracer_skin_000018F2 = 0x000018F2,
		Tracer_skin_00001942 = 0x00001942,
		Tracer_skin_00001943 = 0x00001943,
		Tracer_skin_0000195E = 0x0000195E,
		Tracer_skin_00001B2B = 0x00001B2B,
		Tracer_skin_00001B66 = 0x00001B66,

		Widowmaker_skin_00001713 = 0x00001713,
		Widowmaker_skin_00001717 = 0x00001717,
		Widowmaker_skin_0000171B = 0x0000171B,
		Widowmaker_skin_0000171E = 0x0000171E,
		Widowmaker_skin_000018F3 = 0x000018F3,
		Widowmaker_skin_000018F4 = 0x000018F4,
		Widowmaker_skin_000018F5 = 0x000018F5,
		Widowmaker_skin_00001918 = 0x00001918,
		Widowmaker_skin_00001919 = 0x00001919,
		Widowmaker_skin_00001BAF = 0x00001BAF,

		Winston_skin_000016CB = 0x000016CB,
		Winston_skin_000016CC = 0x000016CC,
		Winston_skin_000016CF = 0x000016CF,
		Winston_skin_000016D0 = 0x000016D0,
		Winston_skin_000016D3 = 0x000016D3,
		Winston_skin_000016D4 = 0x000016D4,
		Winston_skin_000016D5 = 0x000016D5,
		Winston_skin_000016D6 = 0x000016D6,
		Winston_skin_000018E9 = 0x000018E9,
		Winston_skin_00001964 = 0x00001964,
		Winston_skin_0000197F = 0x0000197F,

		Zarya_skin_00001667 = 0x00001667,
		Zarya_skin_000018D8 = 0x000018D8,
		Zarya_skin_000018D9 = 0x000018D9,
		Zarya_skin_00001944 = 0x00001944,
		Zarya_skin_00001A1B = 0x00001A1B,
		Zarya_skin_00001B6A = 0x00001B6A,

		Zenyatta_skin_000015FF = 0x000015FF,
		Zenyatta_skin_000018BA = 0x000018BA,
		Zenyatta_skin_00001960 = 0x00001960,
		Zenyatta_skin_00001966 = 0x00001966,
	}
}
