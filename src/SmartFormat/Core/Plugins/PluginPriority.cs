﻿using System;
using System.ComponentModel;



namespace SmartFormat.Core.Plugins
{
    public enum PluginPriority
    {
        // the greater the value, the higher the priority
        /// <summary>
        /// This handler has the highest priority, so it gets fired first.
        /// </summary>
        Highest = 0,
        /// <summary>
        /// This handler has high priority, so it gets processed before normal priority ones.
        /// </summary>
        High = 1,
        /// <summary>
        /// [Default]
        /// This handler has normal priority.
        /// </summary>
        Normal = 2,

        /// <summary>
        /// Low priority is used only for the core's default methods,
        /// and shouldn't be used otherwise.  
        /// If you want a Source plugin to fire after the default methods, then use Lowest priority.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        Low = 3,

        /// <summary>
        /// This is the lowest priority.  It is only valid for Source plugins, not Formatter plugins.
        /// A Source plugin with this priority only occurs after all other plugins fail.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        Lowest = 99
    }
}