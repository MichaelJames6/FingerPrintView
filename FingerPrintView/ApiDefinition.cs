using System;

using UIKit;
using Foundation;
using ObjCRuntime;
using CoreGraphics;

namespace FingerPrintView
{
    // @interface CTFingerPrintAnimatedView : UIView
    [BaseType (typeof(UIView))]
    interface CTFingerPrintAnimatedView
    {
        // @property (readonly, nonatomic) CTFingerPrintAnimationMode animationMode;
        [Export ("animationMode")]
        CTFingerPrintAnimationMode AnimationMode { get; }

        // @property (readonly, nonatomic) BOOL isAnimating;
        [Export ("isAnimating")]
        bool IsAnimating { get; }

        // -(void)startAnimation:(CTFingerPrintAnimationMode)animationMode;
        [Export ("startAnimation:")]
        void StartAnimation (CTFingerPrintAnimationMode animationMode);

        // -(void)stopAnimation;
        [Export ("stopAnimation")]
        void StopAnimation ();

        // -(void)highlightWithColor:(UIColor *)color animated:(BOOL)animated;
        [Export ("highlightWithColor:animated:")]
        void HighlightWithColor (UIColor color, bool animated);

        // -(void)revertHighlightColorAnimated:(BOOL)animated;
        [Export ("revertHighlightColorAnimated:")]
        void RevertHighlightColorAnimated (bool animated);

        // -(void)showAllVisible:(BOOL)visibleState animated:(BOOL)animated duration:(float)duration;
        [Export ("showAllVisible:animated:duration:")]
        void ShowAllVisible (bool visibleState, bool animated, float duration);
    }

    [BaseType (typeof(NSObject))]
    interface FingerRidgePath
    {
        // @property (nonatomic, strong) UIBezierPath * bezierPath;
        [Export ("bezierPath", ArgumentSemantic.Strong)]
        UIBezierPath BezierPath { get; set; }

        // @property (assign, nonatomic) BOOL visible;
        [Export ("visible")]
        bool Visible { get; set; }

        // @property (assign, nonatomic) BOOL isAnimating;
        [Export ("isAnimating")]
        bool IsAnimating { get; set; }

        // -(void)setVisible:(BOOL)visible animated:(BOOL)animated;
        [Export ("setVisible:animated:")]
        void SetVisible (bool visible, bool animated);

        // -(void)setVisible:(BOOL)visible animated:(BOOL)animated duration:(float)duration;
        [Export ("setVisible:animated:duration:")]
        void SetVisible (bool visible, bool animated, float duration);
    }

    // @interface CTFingerPrintView : UIView
    [BaseType (typeof(UIView))]
    interface CTFingerPrintView
    {
        // @property (nonatomic, strong) NSMutableArray * ridges;
        [Export ("ridges", ArgumentSemantic.Strong)]
        NSMutableArray Ridges { get; set; }

        // @property (assign, nonatomic) float lineWidth;
        [Export ("lineWidth")]
        float LineWidth { get; set; }

        // -(id)initWithFrame:(CGRect)frame beziers:(NSArray *)beziers;
        [Export ("initWithFrame:beziers:")]
        //[Verify (StronglyTypedNSArray)]
        IntPtr Constructor (CGRect frame, NSObject[] beziers);

        // -(void)showAllRidges;
        [Export ("showAllRidges")]
        void ShowAllRidges ();

        // -(void)beginTintColorAnimation;
        [Export ("beginTintColorAnimation")]
        void BeginTintColorAnimation ();

        // -(void)endTintColorAnimation:(void (^)(void))completionBlock;
        [Export ("endTintColorAnimation:")]
        void EndTintColorAnimation (Action completionBlock);
    }
}

