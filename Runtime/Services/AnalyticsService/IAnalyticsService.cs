using DogScaffold;

namespace DogHouse.CoreServices
{
    /// <summary>
    /// IAnalyticsService is an interface that
    /// all analytics services must implement. The
    /// Analytics service is responsible for sending
    /// analytics data to a remote server for further
    /// analysis.
    /// </summary>
    public interface IAnalyticsService : IService
    {
        void SendGameStartEvent();
        void SendLogosStartEvent();
        void SendLogosEndEvent();
        void SendSceneLoadedEvent(string sceneName);
        void SendLevelStartedEvent(string levelName);
        void SendLevelFinishedEvent(string levelName);
        void SendStartButtonClickedEvent();
    }
}
