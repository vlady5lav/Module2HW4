namespace SafariPark
{
    public class ConfigService : IConfigService
    {
        public ConfigService()
        {
            Init();
            HeightConfig = Config.HeightConfig;
            SectionConfig = Config.SectionConfig;
            WeightConfig = Config.WeightConfig;
        }

        public IConfig Config { get; private set; }
        public IHeightConfig HeightConfig { get; private set; }
        public ISectionConfig SectionConfig { get; private set; }
        public IWeightConfig WeightConfig { get; private set; }

        private void Init()
        {
            Config = new Config()
            {
                HeightConfig = new HeightConfig()
                {
                    HeightData = new HeightData[]
                    {
                        new HeightData
                        {
                            HeightUnit = HeightUnits.M,
                            DefaultToCurrentRate = 1.0
                        },
                        new HeightData
                        {
                            HeightUnit = HeightUnits.CM,
                            DefaultToCurrentRate = 0.01
                        },
                        new HeightData
                        {
                            HeightUnit = HeightUnits.DM,
                            DefaultToCurrentRate = 0.1
                        },
                    },

                    CurrentHeight = HeightUnits.M,
                },

                SectionConfig = new SectionConfig()
                {
                    SectionSize = 50,
                },

                WeightConfig = new WeightConfig()
                {
                    WeightData = new WeightData[]
                    {
                        new WeightData
                        {
                            WeightUnit = WeightUnits.KG,
                            DefaultToCurrentRate = 1.0
                        },
                        new WeightData
                        {
                            WeightUnit = WeightUnits.G,
                            DefaultToCurrentRate = 0.001
                        },
                        new WeightData
                        {
                            WeightUnit = WeightUnits.LB,
                            DefaultToCurrentRate = 0.4536
                        },
                        new WeightData
                        {
                            WeightUnit = WeightUnits.TON,
                            DefaultToCurrentRate = 1000.0
                        },
                    },

                    CurrentWeight = WeightUnits.KG,
                }
            };
        }
    }
}
