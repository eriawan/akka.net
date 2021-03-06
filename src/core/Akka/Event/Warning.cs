﻿//-----------------------------------------------------------------------
// <copyright file="Warning.cs" company="Akka.NET Project">
//     Copyright (C) 2009-2016 Lightbend Inc. <http://www.lightbend.com>
//     Copyright (C) 2013-2016 Akka.NET project <https://github.com/akkadotnet/akka.net>
// </copyright>
//-----------------------------------------------------------------------

using System;

namespace Akka.Event
{
    /// <summary>
    /// Represents an Warning log event.
    /// </summary>
    public class Warning : LogEvent
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Warning" /> class.
        /// </summary>
        /// <param name="logSource">The log source.</param>
        /// <param name="logClass">The log class.</param>
        /// <param name="message">The message.</param>
        public Warning(string logSource, Type logClass, object message)
        {
            LogSource = logSource;
            LogClass = logClass;
            Message = message;
        }

        public override LogLevel LogLevel()
        {
            return Event.LogLevel.WarningLevel;
        }
    }
}

