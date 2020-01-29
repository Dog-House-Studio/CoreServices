using DogHouse.Core.Services;

namespace BlueEyes.Services
{
    /// <summary>
    /// IGameStartupScreenService is a service that controls
    /// when the game startup screen that is displayed to the
    /// user while the map is being generated and the game
    /// is being setup.
    /// </summary>
    public interface IGameStartupScreenService : IService
    {
        void DisplayUI();
        void SetGameReady();   
    }
}
