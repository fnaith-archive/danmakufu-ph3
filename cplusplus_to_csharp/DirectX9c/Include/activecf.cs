// ------------------------------------------------------------------------------
// File: ActiveCf.h
// 
// Desc: Contains the data formats for the transfer of VfW4 filters via the
//       clipboard.
// 
// Copyright (c) 1992-2001, Microsoft Corporation.  All rights reserved.
// ------------------------------------------------------------------------------



public class tagVFW_FILTERLIST
{
    public uint cFilters; // number of CLSIDs in aClsId
    public CLSID[] aClsId = Arrays.InitializeWithDefaultInstances<CLSID>(1); // ClsId of each filter

}


