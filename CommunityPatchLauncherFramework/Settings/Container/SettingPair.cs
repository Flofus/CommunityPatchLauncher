﻿using System;

namespace CommunityPatchLauncherFramework.Settings.Container
{
    /// <summary>
    /// This class represents a setting pair
    /// </summary>
    public class SettingPair
    {
        /// <summary>
        /// The key of the setting pair
        /// </summary>
        public string Key { get; }
        
        /// <summary>
        /// The value of the setting pair
        /// </summary>
        public object Value { get; }

        /// <summary>
        /// Get the type of the value
        /// </summary>
        public Type ValueType { get; }

        /// <summary>
        /// Create a new instance of this class
        /// </summary>
        /// <param name="key">The key of the setting</param>
        /// <param name="value">The value of the setting</param>
        public SettingPair(string key, object value)
            : this(key, value, value.GetType())
        {
        }

        /// <summary>
        /// Create a new instance of this class
        /// </summary>
        /// <param name="key">The key of the setting</param>
        /// <param name="value">The value of the setting</param>
        /// <param name="type">The type of the value</param>
        public SettingPair(string key, object value, Type type)
        {
            Key = key;
            Value = value;
            ValueType = type;
        }

        /// <summary>
        /// This method will return you the value as the correct type
        /// </summary>
        /// <typeparam name="T">The type of the value to get</typeparam>
        /// <returns></returns>
        public T getValue<T>()
        {
            Type type = typeof(T);
            return type == ValueType ? (T)Convert.ChangeType(Value, type) : default(T);
        }
    }
}
