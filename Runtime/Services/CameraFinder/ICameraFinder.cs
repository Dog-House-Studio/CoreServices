using DogScaffold;
using System;
using UnityEngine;

namespace DogHouse.CoreServices
{
    /// <summary>
    /// ICameraFinder is an interface that
    /// all Camera Finders must implement. A 
    /// camera finder is responsible for knowing
    /// the current main camera of the scene.
    /// </summary>
    public interface ICameraFinder : IService
    {
        event Action<Camera> OnNewCameraFound;

        UnityEngine.Camera Camera { get; }
    }
}
