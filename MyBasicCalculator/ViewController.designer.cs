// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace MyBasicCalculator
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		AppKit.NSTextField Screen { get; set; }

		[Action ("DivisionButton:")]
		partial void DivisionButton (AppKit.NSButton sender);

		[Action ("EightButton:")]
		partial void EightButton (AppKit.NSButton sender);

		[Action ("EqualButton:")]
		partial void EqualButton (AppKit.NSButton sender);

		[Action ("FiveButton:")]
		partial void FiveButton (AppKit.NSButton sender);

		[Action ("FourButton:")]
		partial void FourButton (AppKit.NSButton sender);

		[Action ("MinusButton:")]
		partial void MinusButton (AppKit.NSButton sender);

		[Action ("MultiplicationButton:")]
		partial void MultiplicationButton (AppKit.NSButton sender);

		[Action ("NineButton:")]
		partial void NineButton (AppKit.NSButton sender);

		[Action ("OneButton:")]
		partial void OneButton (AppKit.NSButton sender);

		[Action ("PercentButton:")]
		partial void PercentButton (AppKit.NSButton sender);

		[Action ("PlusButton:")]
		partial void PlusButton (AppKit.NSButton sender);

		[Action ("PlusOrMinusButton:")]
		partial void PlusOrMinusButton (AppKit.NSButton sender);

		[Action ("ResetButton:")]
		partial void ResetButton (AppKit.NSButton sender);

		[Action ("SevenButton:")]
		partial void SevenButton (AppKit.NSButton sender);

		[Action ("SixButton:")]
		partial void SixButton (AppKit.NSButton sender);

		[Action ("SquareRoot:")]
		partial void SquareRoot (AppKit.NSButton sender);

		[Action ("ThreeButton:")]
		partial void ThreeButton (AppKit.NSButton sender);

		[Action ("TwoButton:")]
		partial void TwoButton (AppKit.NSButton sender);

		[Action ("ZeroButton:")]
		partial void ZeroButton (AppKit.NSButton sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (Screen != null) {
				Screen.Dispose ();
				Screen = null;
			}
		}
	}
}
