﻿using System;
using DogScaffold;
using UnityEngine;

namespace DogHouse.CoreServices
{
    /// <summary>
    /// CallLoadSlideShowScene is a component that can be
    /// used to easily access the SceneManager and call the
    /// Load Slide Show Scene method.
    /// </summary>
    public class SceneManagerBackdoor : MonoBehaviour , ISceneManager
    {
        #region Public Variables
        [HideInInspector]
        public event Action OnAboutToLoadNewScene = null;
        #endregion

        #region Private Variables
        private ServiceReference<ISceneManager> m_sceneManager 
            = new ServiceReference<ISceneManager>();

        #endregion

        #region Main Methods
        public void LoadSlideShowScene()
        {
            m_sceneManager.Reference?.LoadSlideShowScene();
        }

        public void LoadMainMenuScene()
        {
            m_sceneManager.Reference?.LoadMainMenuScene();
        }

        public void LoadGameScene()
        {
            m_sceneManager.Reference?.LoadGameScene();
        }

        public void RegisterService()                                           //Were not going to register this. This class is just a backdoor and thus not necesarry to register as a service.
        {
            #if UNITY_EDITOR
            //Only doing this to prevent the console warning
            OnAboutToLoadNewScene?.Invoke();
            #endif
        }                                        
        #endregion
    }
}
