﻿namespace SexyFishHorse.CitiesSkylines.Ragnarok
{
    using System.Collections.Generic;
    using ICities;

    public static class SettingKeys
    {
        public const string DisableAutofocusDisaster = "DisableAutofocusDisaster";

        public const string DisableNonDisasterFires = "DisableNonDisasterFires";

        public const string DisableScenarioDisasters = "DisableScenarioDisasters";

        public const string PauseOnDisasterStart = "PauseOnDisasterStart";

        public static readonly DisasterSettingKeys Earthquakes = new DisasterSettingKeys("Earthquakes");

        public static readonly DisasterSettingKeys ForestFires = new DisasterSettingKeys("ForesFires");

        public static readonly DisasterSettingKeys Meteors = new DisasterSettingKeys("Meteors");

        public static readonly DisasterSettingKeys Sinkholes = new DisasterSettingKeys("Sinkholes");

        public static readonly DisasterSettingKeys StructureCollapses = new DisasterSettingKeys("StructureCollapses");

        public static readonly DisasterSettingKeys StructureFires = new DisasterSettingKeys("StructureFires");

        public static readonly DisasterSettingKeys Thunderstorms = new DisasterSettingKeys("Thunderstorms");

        public static readonly DisasterSettingKeys Tornadoes = new DisasterSettingKeys("Tornadoes");

        public static readonly DisasterSettingKeys Tsunamis = new DisasterSettingKeys("Tsunamis");

        public static readonly IDictionary<DisasterType, string> AutoEvacuateSettingKeyMapping = new Dictionary<DisasterType, string>
        {
            { DisasterType.Earthquake, Earthquakes.AutoEvacuate },
            { DisasterType.ForestFire, ForestFires.AutoEvacuate },
            { DisasterType.MeteorStrike, Meteors.AutoEvacuate },
            { DisasterType.Sinkhole, Sinkholes.AutoEvacuate },
            { DisasterType.StructureCollapse, StructureCollapses.AutoEvacuate },
            { DisasterType.StructureFire, StructureFires.AutoEvacuate },
            { DisasterType.ThunderStorm, Thunderstorms.AutoEvacuate },
            { DisasterType.Tornado, Tornadoes.AutoEvacuate },
            { DisasterType.Tsunami, Tsunamis.AutoEvacuate }
        };

        public static readonly IDictionary<DisasterType, string> DisableDisasterSettingKeyMapping = new Dictionary<DisasterType, string>
        {
            { DisasterType.Earthquake, Earthquakes.Disable },
            { DisasterType.ForestFire, ForestFires.Disable },
            { DisasterType.MeteorStrike, Meteors.Disable },
            { DisasterType.Sinkhole, Sinkholes.Disable },
            { DisasterType.StructureCollapse, StructureCollapses.Disable },
            { DisasterType.StructureFire, StructureFires.Disable },
            { DisasterType.ThunderStorm, Thunderstorms.Disable },
            { DisasterType.Tornado, Tornadoes.Disable },
            { DisasterType.Tsunami, Tsunamis.Disable }
        };
    }
}
