﻿using System.Collections.Generic;

namespace GameKit.Resource
{
    internal sealed partial class ResourceManager : GameKitModule, IResourceManager
    {
        /// <summary>
        /// 资源名称比较器。
        /// </summary>
        private sealed class ResourceNameComparer : IComparer<ResourceName>, IEqualityComparer<ResourceName>
        {
            public int Compare(ResourceName x, ResourceName y)
            {
                return x.CompareTo(y);
            }

            public bool Equals(ResourceName x, ResourceName y)
            {
                return x.Equals(y);
            }

            public int GetHashCode(ResourceName obj)
            {
                return obj.GetHashCode();
            }
        }
    }
}
