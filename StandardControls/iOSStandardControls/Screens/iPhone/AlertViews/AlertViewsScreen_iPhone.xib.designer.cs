// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.1433
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace Example_StandardControls.Screens.iPhone.AlertViews {
	
	
	// Base type probably should be UIKit.UIViewController or subclass
	[Foundation.Register("AlertViewsScreen_iPhone")]
	public partial class AlertViewsScreen_iPhone {
		
		private UIKit.UIView __mt_view;
		
		private UIKit.UIButton __mt_btnCustomButtons;
		
		private UIKit.UIButton __mt_btnSimpleAlert;
		
		private UIKit.UIButton __mt_btnCustomButtonsWithDelegate;
		
		private UIKit.UIButton __mt_btnCustomAlert;
		
		#pragma warning disable 0169
		[Foundation.Connect("view")]
		private UIKit.UIView view {
			get {
				this.__mt_view = ((UIKit.UIView)(this.GetNativeField("view")));
				return this.__mt_view;
			}
			set {
				this.__mt_view = value;
				this.SetNativeField("view", value);
			}
		}
		
		[Foundation.Connect("btnCustomButtons")]
		private UIKit.UIButton btnCustomButtons {
			get {
				this.__mt_btnCustomButtons = ((UIKit.UIButton)(this.GetNativeField("btnCustomButtons")));
				return this.__mt_btnCustomButtons;
			}
			set {
				this.__mt_btnCustomButtons = value;
				this.SetNativeField("btnCustomButtons", value);
			}
		}
		
		[Foundation.Connect("btnSimpleAlert")]
		private UIKit.UIButton btnSimpleAlert {
			get {
				this.__mt_btnSimpleAlert = ((UIKit.UIButton)(this.GetNativeField("btnSimpleAlert")));
				return this.__mt_btnSimpleAlert;
			}
			set {
				this.__mt_btnSimpleAlert = value;
				this.SetNativeField("btnSimpleAlert", value);
			}
		}
		
		[Foundation.Connect("btnCustomButtonsWithDelegate")]
		private UIKit.UIButton btnCustomButtonsWithDelegate {
			get {
				this.__mt_btnCustomButtonsWithDelegate = ((UIKit.UIButton)(this.GetNativeField("btnCustomButtonsWithDelegate")));
				return this.__mt_btnCustomButtonsWithDelegate;
			}
			set {
				this.__mt_btnCustomButtonsWithDelegate = value;
				this.SetNativeField("btnCustomButtonsWithDelegate", value);
			}
		}
		
		[Foundation.Connect("btnCustomAlert")]
		private UIKit.UIButton btnCustomAlert {
			get {
				this.__mt_btnCustomAlert = ((UIKit.UIButton)(this.GetNativeField("btnCustomAlert")));
				return this.__mt_btnCustomAlert;
			}
			set {
				this.__mt_btnCustomAlert = value;
				this.SetNativeField("btnCustomAlert", value);
			}
		}
	}
}
