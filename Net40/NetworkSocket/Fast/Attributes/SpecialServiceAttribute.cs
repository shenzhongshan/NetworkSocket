﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NetworkSocket.Fast.Attributes
{
    /// <summary>
    /// 表示特殊的服务实现
    /// </summary>
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class, AllowMultiple = false, Inherited = true)]
    internal sealed class SpecialServiceAttribute : Attribute
    {
    }
}