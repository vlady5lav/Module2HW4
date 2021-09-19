using Microsoft.Extensions.DependencyInjection;

namespace SafariPark
{
    public class App
    {
        private Starter _starter;

        public void Start()
        {
            var serviceProvider = new ServiceCollection()
                .AddSingleton<IConfigService, ConfigService>()
                .AddSingleton<ISectionService, SectionService>()
                .AddTransient<IAnimalsProvider, AnimalsProvider>()
                .AddTransient<IAnimalsService, AnimalsService>()
                .AddTransient<IConfig, Config>()
                .AddTransient<IHeightComparer, HeightComparer>()
                .AddTransient<IHeightConfig, HeightConfig>()
                .AddTransient<INameComparer, NameComparer>()
                .AddTransient<ISectionConfig, SectionConfig>()
                .AddTransient<ISectionProvider, SectionProvider>()
                .AddTransient<IWeightComparer, WeightComparer>()
                .AddTransient<IWeightConfig, WeightConfig>()
                .AddTransient<Starter>()
                .BuildServiceProvider();

            _starter = serviceProvider.GetService<Starter>();
            _starter.Run();
        }
    }
}
