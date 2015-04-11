using System;
using ObjCRuntime;

[assembly: LinkWith ("libCTFingerPrintView.a", LinkTarget.ArmV7 | LinkTarget.ArmV7s, SmartLink = true, ForceLoad = true)]
