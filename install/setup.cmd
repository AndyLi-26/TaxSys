wmic csproduct get uuid > info.txt
wmic path Win32_VideoController get CurrentHorizontalResolution,CurrentVerticalResolution >> info.txt