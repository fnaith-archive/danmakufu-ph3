// The following statement is interrupted by a preprocessor statement.

// The original statement from the file multimon.h starts with:
//    if (hUser32 && (*(FARPROC*)&g_pfnGetSystemMetrics = GetProcAddress(hUser32,"GetSystemMetrics")) != NULL && (*(FARPROC*)&g_pfnMonitorFromWindow = GetProcAddress(hUser32,"MonitorFromWindow")) != NULL && (*(FARPROC*)&g_pfnMonitorFromRect = GetProcAddress(hUser32,"MonitorFromRect")) != NULL && (*(FARPROC*)&g_pfnMonitorFromPoint = GetProcAddress(hUser32,"MonitorFromPoint")) != NULL && (*(FARPROC*)&g_pfnEnumDisplayMonitors = GetProcAddress(hUser32,"EnumDisplayMonitors")) != NULL &&

// These cannot be handled by this converter.
// Modify this statement so that it is not interrupted by preprocessor statements and try the conversion again.