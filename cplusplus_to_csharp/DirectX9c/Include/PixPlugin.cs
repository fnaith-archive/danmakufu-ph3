using System;

// ==================================================================================================
// PIXPlugin.h
// 
// Microsoft PIX Plugin Header
// 
// Copyright (c) Microsoft Corporation, All rights reserved
// ==================================================================================================


#if __cplusplus
#endif


// ==================================================================================================
// PIX_PLUGIN_SYSTEM_VERSION - Indicates version of the plugin interface the plugin is built with.
// ==================================================================================================


// ==================================================================================================
// PIXCOUNTERID - A unique identifier for each PIX plugin counter.
// ==================================================================================================


// ==================================================================================================
// PIXCOUNTERDATATYPE - Indicates what type of data the counter produces.
// ==================================================================================================
public enum PIXCOUNTERDATATYPE
{
    PCDT_RESERVED,
    PCDT_FLOAT,
    PCDT_INT,
    PCDT_INT64,
    PCDT_STRING
}


// ==================================================================================================
// PIXPLUGININFO - This structure is filled out by PIXGetPluginInfo and passed back to PIX.
// ==================================================================================================
public class PIXPLUGININFO
{
    // Filled in by caller:
    public IntPtr hinst;

    // Filled in by PIXGetPluginInfo:
    public string pstrPluginName; // Name of plugin
    public int iPluginVersion; // Version of this particular plugin
    public int iPluginSystemVersion; // Version of PIX's plugin system this plugin was designed for
}


// ==================================================================================================
// PIXCOUNTERINFO - This structure is filled out by PIXGetCounterInfo and passed back to PIX 
//                  to allow PIX to determine information about the counters in the plugin.
// ==================================================================================================
public class PIXCOUNTERINFO
{
    public int counterID; // Used to uniquely ID this counter
    public string pstrName; // String name of the counter
    public PIXCOUNTERDATATYPE pcdtDataType; // Data type returned by this counter
}