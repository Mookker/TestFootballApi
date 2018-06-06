using MvvmCross;
using MvvmCross.Platform.IoC;
using MvvmCross.ViewModels;
using TestFootballApi.Core.Helpers.Implementations;
using TestFootballApi.Core.Helpers.Interfaces;
using TestFootballApi.Core.Services.Implementations;
using TestFootballApi.Core.Services.Interfaces;
using TestFootballApi.Core.ViewModels;

namespace TestFootballApi.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
//            CreatableTypes()
//                .EndingWith("Service")
//                .AsInterfaces()
//                .RegisterAsLazySingleton();

            Mvx.RegisterType<IHttpHelperService, HttpHelperWithAuth>();
            Mvx.RegisterType<ICompetitionsService, CompetitionService>();
            RegisterAppStart<CompetitionsViewModel>();
        }
    }
}
