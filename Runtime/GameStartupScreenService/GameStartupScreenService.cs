using DogHouse.Core.Services;
using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.UI;

namespace BlueEyes.Services
{
    /// <summary>
    /// GameStartupScreenService is a service that displays 
    /// a start up screen when the game first begins. Other 
    /// systems and services may tell the service that the 
    /// game is ready and a start button will appear.
    /// </summary>
    public class GameStartupScreenService : BaseService<IGameStartupScreenService>, IGameStartupScreenService
    {
        #region Private Variables
        [ChildGameObjectsOnly]
        [SerializeField]
        [BoxGroup("UI")]
        [Required("A root for the canvas is required.")]
        private GameObject m_canvasRoot;

        [ChildGameObjectsOnly]
        [SerializeField]
        [BoxGroup("UI")]
        [Required("A root for the start button is required is required.")]
        private Button m_startButtonRoot;

        private const float START_GAME_DELAY = 1f;
        #endregion

        #region Main Methods
        private void Start()
        {
            m_canvasRoot?.gameObject?.SetActive(false);
            m_startButtonRoot?.gameObject?.SetActive(false);
            SubscribeToButtons();
        }

        public override void OnDisable()
        {
            base.OnDisable();
            m_startButtonRoot?.onClick?.RemoveAllListeners();
            CancelInvoke();
        }

        public void DisplayUI()
        {
            m_canvasRoot?.gameObject?.SetActive(true);
            m_startButtonRoot?.gameObject?.SetActive(false);
        }

        public void SetGameReady()
        {
            m_startButtonRoot?.gameObject?.SetActive(true);
        }

        private void StartButtonClicked()
        {
            m_startButtonRoot?.onClick?.RemoveAllListeners();
            Invoke(nameof(BeginGame), START_GAME_DELAY);
        }
        #endregion

        #region Utility Methods
        private void SubscribeToButtons()
        {
            m_startButtonRoot?.onClick.AddListener(StartButtonClicked);
        }

        private void BeginGame()
        {
            this.gameObject.SetActive(false);
        }
        #endregion
    }
}
