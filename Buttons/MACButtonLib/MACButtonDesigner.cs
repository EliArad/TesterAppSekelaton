#region Copyright (c) 2002-2006 X-Component All Rights Reserved
/* ---------------------------------------------------------------------*
*                           X-Component                              *
*              Copyright (c) 2002-2006 All Rights reserved              *
*                                                                       *
*                                                                       *
* This file and its contents are protected by Vietnam and               *
* International copyright laws.  Unauthorized reproduction and/or       *
* distribution of all or any portion of the code contained herein       *
* is strictly prohibited and will result in severe civil and criminal   *
* penalties.  Any violations of this copyright will be prosecuted       *
* to the fullest extent possible under law.                             *
*                                                                       *
* THE SOURCE CODE CONTAINED HEREIN AND IN RELATED FILES IS PROVIDED     *
* TO THE REGISTERED DEVELOPER FOR THE PURPOSES OF EDUCATION AND         *
* TROUBLESHOOTING. UNDER NO CIRCUMSTANCES MAY ANY PORTION OF THE SOURCE *
* CODE BE DISTRIBUTED, DISCLOSED OR OTHERWISE MADE AVAILABLE TO ANY     *
* THIRD PARTY WITHOUT THE EXPRESS WRITTEN CONSENT OF ECONTECH JSC.,     *
*                                                                       *
* UNDER NO CIRCUMSTANCES MAY THE SOURCE CODE BE USED IN WHOLE OR IN     *
* PART, AS THE BASIS FOR CREATING A PRODUCT THAT PROVIDES THE SAME, OR  *
* SUBSTANTIALLY THE SAME, FUNCTIONALITY AS ANY ECONTECH JSC. PRODUCT.   *
*                                                                       *
* THE REGISTERED DEVELOPER ACKNOWLEDGES THAT THIS SOURCE CODE           *
* CONTAINS VALUABLE AND PROPRIETARY TRADE SECRETS OF ECONTECH JSC.,     *
* THE REGISTERED DEVELOPER AGREES TO EXPEND EVERY EFFORT TO             *
* INSURE ITS CONFIDENTIALITY.                                           *
*                                                                       *
* THE END USER LICENSE AGREEMENT (EULA) ACCOMPANYING THE PRODUCT        *
* PERMITS THE REGISTERED DEVELOPER TO REDISTRIBUTE THE PRODUCT IN       *
* EXECUTABLE FORM ONLY IN SUPPORT OF APPLICATIONS WRITTEN USING         *
* THE PRODUCT.  IT DOES NOT PROVIDE ANY RIGHTS REGARDING THE            *
* SOURCE CODE CONTAINED HEREIN.                                         *
*                                                                       *
* THIS COPYRIGHT NOTICE MAY NOT BE REMOVED FROM THIS FILE.              *
* --------------------------------------------------------------------- *
*/
#endregion Copyright (c) 2002-2006 X-Component All Rights Reserved


using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Collections;
using System.Drawing;
using System.Drawing.Design;
using System.Windows.Forms.Design;
using System.Windows.Forms;

namespace XComponent.MACButton.Designer
{
	/// <summary>
	/// The Designer for the <see cref="MACButton"/>.
	/// </summary>
	internal class MACButtonDesigner : System.Windows.Forms.Design.ControlDesigner {
	
		/// <summary>
		/// 
		/// </summary>
		public MACButtonDesigner()
		{
		}

		/// <summary>
		/// Remove Button and Control properties that are 
		/// not supported by the <see cref="MACButton"/>.
		/// </summary>
		protected override void PostFilterProperties( IDictionary Properties )
		{
			Properties.Remove( "AllowDrop" );
			Properties.Remove( "FlatStyle");
			Properties.Remove( "ForeColor" );
			Properties.Remove( "ImageIndex");
			Properties.Remove( "ImageList");
		}
	}
}
