using Foundation;
using System;
using System.Diagnostics;
using UIKit;

namespace TypingAttributesDemo
{
    public partial class ViewController : UIViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            var tf = new UITextView();
            Debug.Assert(tf.TypingAttributes != null);
            Debug.Assert(tf.TypingAttributes.Count == 0);
            tf.AttributedText = new NSAttributedString("some text");
            Debug.Assert(tf.TypingAttributes != null);
            Debug.Assert(tf.TypingAttributes.Count == 1);
        }
    }
}