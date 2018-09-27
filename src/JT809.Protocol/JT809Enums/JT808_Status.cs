﻿using System;
using System.Collections.Generic;
using System.Text;

namespace JT809.Protocol.Enums
{
    [Flags]
    public enum JT808_Status : uint
    {
        ACC开 = 1,
        定位 = 2,
        南纬 = 4,
        西经 = 8,
        停运状态 = 16,
        经纬度已经保密插件加密 = 32,
        //保留 = 64,
        //保留 = 128,
        半载 = 256,
        //保留 = 512,
        满载 = 768,
        车辆油路断开 = 1024,
        车辆电路断开 = 2048,
        车门加锁 = 4096,
        前门开 = 8192,
        中门开 = 16384,
        后门开 = 32768,
        驾驶席门开 = 65536,
        自定义 = 131072,
        使用GPS卫星进行定位 = 262144,
        使用北斗卫星进行定位 = 524288,
        使用GLONASS卫星进行定位 = 1048576,
        使用Galileo卫星进行定位 = 2097152
    }
}
