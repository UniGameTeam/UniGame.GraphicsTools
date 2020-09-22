﻿namespace UniModules.UniGame.GraphicsTools.Runtime.Abstract
{
    using UnityEngine;

    public interface IVirtualTexture
    {
        int Width  { get; }
        int Height { get; }

        Bounds Bounds { get; }

        Color GetPixelColor(float x, float y);

        void SetAverageColor(Color color, Color backgroundColor);
    }
}