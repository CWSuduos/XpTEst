using Zenject;

public class GameInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        Container.Bind<XpModel>().AsSingle();
        Container.Bind<LevelModel>().AsSingle();
        Container.Bind<PlayerPresenter>().AsSingle();
    }
}

