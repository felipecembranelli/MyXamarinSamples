// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.1433
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace Example_StandardControls.Screens.iPad.DatePicker {
	
	
	// Base type probably should be UIKit.UIViewController or subclass
	[Foundation.Register("ActionSheetDatePicker_iPad")]
	public partial class ActionSheetDatePicker_iPad {
		
		private UIKit.UIView __mt_view;
		
		private UIKit.UIButton __mt_btnChooseDate;
		
		private UIKit.UILabel __mt_lblDate;
		
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
		
		[Foundation.Connect("btnChooseDate")]
		private UIKit.UIButton btnChooseDate {
			get {
				this.__mt_btnChooseDate = ((UIKit.UIButton)(this.GetNativeField("btnChooseDate")));
				return this.__mt_btnChooseDate;
			}
			set {
				this.__mt_btnChooseDate = value;
				this.SetNativeField("btnChooseDate", value);
			}
		}
		
		[Foundation.Connect("lblDate")]
		private UIKit.UILabel lblDate {
			get {
				this.__mt_lblDate = ((UIKit.UILabel)(this.GetNativeField("lblDate")));
				return this.__mt_lblDate;
			}
			set {
				this.__mt_lblDate = value;
				this.SetNativeField("lblDate", value);
			}
		}
	}
}
