﻿using GameKit;
using UnityEngine;

namespace UnityGameKit.Runtime
{
    /// <summary>
    /// 默认游戏框架日志辅助器。
    /// </summary>
    public class DefaultLogHelper : GameKitLog.ILogHelper
    {
        /// <summary>
        /// 记录日志。
        /// </summary>
        /// <param name="level">日志等级。</param>
        /// <param name="message">日志内容。</param>
        public void Log(GameKitLogLevel level, object message)
        {
            switch (level)
            {
                case GameKitLogLevel.Debug:
                    Debug.Log(Utility.Text.Format("<color=#888888>{0}</color>", message));
                    break;

                case GameKitLogLevel.Info:
                    Debug.Log(message.ToString());
                    break;

                case GameKitLogLevel.Warning:
                    Debug.LogWarning(message.ToString());
                    break;

                case GameKitLogLevel.Error:
                    Debug.LogError(message.ToString());
                    break;

                default:
                    throw new GameKitException(message.ToString());
            }
        }
    }
}
