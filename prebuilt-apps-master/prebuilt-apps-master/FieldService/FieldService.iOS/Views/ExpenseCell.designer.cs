// WARNING
//
// This file has been generated automatically by MonoDevelop to store outlets and
// actions made in the Xcode designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;

namespace FieldService.iOS
{
	[Register ("ExpenseCell")]
	partial class ExpenseCell
	{
		[Outlet]
		UIKit.UILabel description { get; set; }

		[Outlet]
		UIKit.UILabel type { get; set; }

		[Outlet]
		UIKit.UILabel cost { get; set; }

		[Outlet]
		UIKit.UIImageView icon { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (description != null) {
				description.Dispose ();
				description = null;
			}

			if (type != null) {
				type.Dispose ();
				type = null;
			}

			if (cost != null) {
				cost.Dispose ();
				cost = null;
			}

			if (icon != null) {
				icon.Dispose ();
				icon = null;
			}
		}
	}
}
