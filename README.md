# FingerPrintView
Attempt at a binding

###Error: 

System.Exception: Could not create an native instance of the type 'FingerPrintView.CTFingerPrintAnimatedView': the native class hasn't been loaded.
It is possible to ignore this condition by setting ObjCRuntime.Class.ThrowOnInitFailure to false.
  at Foundation.NSObject.InitializeObject (Boolean alloced) [0x0003a] in /Developer/MonoTouch/Source/maccore/src/Foundation/NSObject2.cs:171
  at Foundation.NSObject..ctor (Foundation.NSObjectFlag x) [0x0000d] in /Developer/MonoTouch/Source/maccore/src/Foundation/NSObject2.cs:115
  at UIKit.UIResponder..ctor (Foundation.NSObjectFlag t) [0x00000] in /Developer/MonoTouch/Source/monotouch/src/build/native/UIKit/UIResponder.g.cs:57
  at UIKit.UIView..ctor (Foundation.NSObjectFlag t) [0x00000] in /Developer/MonoTouch/Source/monotouch/src/build/native/UIKit/UIView.g.cs:70
  at FingerPrintView.CTFingerPrintAnimatedView..ctor () [0x00000] in /Users/mikejames/Git/FingerPrintView/FingerPrintView/obj/Debug/ios/FingerPrintView/CTFingerPrintAnimatedView.g.cs:46
  at Sample.SampleViewController.ViewDidLoad () [0x00007] in /Users/mikejames/Git/FingerPrintView/Sample/SampleViewController.cs:31
  at at (wrapper managed-to-native) UIKit.UIApplication:UIApplicationMain (int,string[],intptr,intptr)
  at UIKit.UIApplication.Main (System.String[] args, IntPtr principal, IntPtr delegate) [0x00005] in /Developer/MonoTouch/Source/monotouch/src/UIKit/UIApplication.cs:62
  at UIKit.UIApplication.Main (System.String[] args, System.String principalClassName, System.String delegateClassName) [0x00038] in /Developer/MonoTouch/Source/monotouch/src/UIKit/UIApplication.cs:46
  at Sample.Application.Main (System.String[] args) [0x00008] in /Users/mikejames/Git/FingerPrintView/Sample/Main.cs:17

###Orginal project: https://github.com/Collect3/CTFingerPrintView
