﻿using System;

namespace IJunior.TypedScene
{
    public class SceneCreationTrigger : UnityEditor.AssetModificationProcessor
    {
        private const string _sceneExtension = ".unity";
        private const string _metaExtension = ".meta";
        public static event Action<string> Created;

        private static void OnWillCreateAsset(string assetName)
        {
            assetName = assetName.Replace(_metaExtension, "");
            if (assetName.Contains(_sceneExtension))
            {
                Created?.Invoke(assetName);
            }
        }
    } 
}
