﻿using System.Windows;
using iNKORE.UI.WPF.Modern.Common;

namespace iNKORE.UI.WPF.Modern.Controls
{
    internal class FrameworkElementSizeChangedRevoker : EventRevoker<FrameworkElement, SizeChangedEventHandler>
    {
        public FrameworkElementSizeChangedRevoker(FrameworkElement source, SizeChangedEventHandler handler) : base(source, handler)
        {
        }

        protected override void AddHandler(FrameworkElement source, SizeChangedEventHandler handler)
        {
            source.SizeChanged += handler;
        }

        protected override void RemoveHandler(FrameworkElement source, SizeChangedEventHandler handler)
        {
            source.SizeChanged -= handler;
        }
    }
}
