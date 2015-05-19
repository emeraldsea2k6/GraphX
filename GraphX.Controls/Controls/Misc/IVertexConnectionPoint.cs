﻿using System;
using System.Windows;
using GraphX.PCL.Common.Enums;

namespace GraphX.WPF.Controls
{
    public interface IVertexConnectionPoint : IDisposable
    {
        /// <summary>
        /// Connector identifier
        /// </summary>
        int Id { get; }

        /// <summary>
        /// Gets or sets shape form for connection point (affects math calculations for edge end placement)
        /// </summary>
        VertexShape Shape { get; }

        void Hide();
        void Show();

        Rect RectangularSize { get; }

        void Update();
    }
}