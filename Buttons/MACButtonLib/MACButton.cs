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
using System.Reflection;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing.Text;

using System.Diagnostics;
using System.ComponentModel.Design.Serialization;

using XComponent.MACButton.Designer;

namespace MACButtonLib
{
	/// <summary>
	///	  <para>
	///		MACButton control for .NET is a special 3D button control, that 
	///		provides your application buttons nice same as MAC buttons, Aqua buttons...
	///		with many shape styles, texture styles, color styles...
	///		Further more, you can add text, image on the button and adjust their positions
	///		as good as you want.
	///   </para>
	///   <para>
	///     To change color of button and text in states
	///     use following properties <see cref="ButtonColorDefault"/>, <see cref="ButtonColorNormal"/>,  
	///		<see cref="ButtonColorHover"/>, <see cref="ButtonColorDisabled"/>, <see cref="TextColorDefault"/>, <see cref="TextColorNormal"/>, 
	///		<see cref="TextColorHover"/>, <see cref="TextColorDisabled"/>. 
	///		Or you can use <see cref="ColorStyleDefault"/>, <see cref="ColorStyleNormal"/>,  
	///		<see cref="ColorStyleHover"/>, <see cref="ColorStyleDisabled"/> for faster selection.
	///   </para>
	///   <para>
	///     You can add text and image on the button by using <see cref="Text">Text</see>, 
	///     <see cref="Image">Image</see> properties, and adjust their positions exactly to 
	///     the positions you want by using following properties: <see cref="TextAlign">TextAlign</see>, <see cref="TextPaddingX">TextPaddingX</see>
	///     , <see cref="TextPaddingY">TextPaddingY</see>, <see cref="ImageAlign">ImageAlign</see>, <see cref="ImagePaddingX">ImagePaddingX</see>
	///     , <see cref="ImagePaddingY">ImagePaddingY</see>.
	///   </para>
	///   <para>
	///   MACButton supports the following features:
	///   <list type="bullet">
	///     <item><c>Very nice 3D Button.</c></item>
	///     <item><c>Supports MAC style button.</c></item>
	///     <item><c>Many button styles with properties: ButtonShapeStyle, ButtonTextureStyle.</c></item> 
	///     <item><c>Any color for the button and text.</c></item> 
	///     <item><c>Different button colors and text colors for 4 states of the button: Normal, Default, Hover, and Disabled.</c></item> 
	///     <item><c>Fast selecting good color style for both button and text by using the property: ColorStyleDefault, ColorStyleDisabled, ColorStyleHover, ColorStyleNormal.</c></item> 
	///     <item><c>Pulsing as MAC X button style. Further more you can adjust the pulsing as you want with properties: BrightnessDefault, PulseBrightnessMax, PulseBrightnessMin, Pulse, PulseInterval.</c></item> 
	///     <item><c>Very better alignment and allocation for text and image with following properties: ImageAlign, ImagePaddingX, ImagePaddingY, TextAlign, TextPaddingX, TextPaddingY.</c></item> 
	///     <item><c>Easy to Use and Integrate in Visual Studio .NET.</c></item> 
	///     <item><c>100% compatible to standard button control in VS.NET.</c></item> 
	///     <item><c>100% managed code.</c></item> 
	///     <item><c>No coding RAD component.</c></item> 
	///     <item><c>Supports text shadow.</c></item> 
	///     <item><c>Supports .ico file.</c></item> 
	///     <item><c>Left menu popup.</c></item> 
	///     <item><c>Supports the AcceptButton or CancelButton</c></item> 
	///     <item><c>Supports Shortcut Key</c></item> 
	///   </list>
	///   </para>
	/// </summary>
	/// <remarks>
	/// In case you want to choose a specified picture as your button, 
	/// you can use the <see cref="ECTPictureButtonEx">ECTPictureButtonEx</see> control for that purpose.
	/// This <see cref="ECTPictureButtonEx">ECTPictureButtonEx</see> control has <see cref="ECTPictureButtonEx.ButtonPicture">ButtonPicture</see>
	/// property to select customized picture as button.
	/// </remarks>
	[Description("Extended MAC Button Control")]
	[ToolboxBitmap(typeof(MACButton),"MACButton.bmp")]
	[Designer(typeof (XComponent.MACButton.Designer.MACButtonDesigner))]
	[DefaultProperty("ButtonColorNormal")]
	[DefaultEvent("Click")]
	public class MACButton : System.Windows.Forms.Control
	{
		//===============================================================
		#region Class Constants
		//Default Button Color
		internal static Color buttonColorOrigin = Color.FromArgb(90,162,214);

		#endregion

		#region Static Member Variables

		internal static StringFormat stringFormat = null;			

		#endregion

		//===============================================================
		#region Member Variables

		//Button Colors on States
		private Color buttonColorDisabled = Color.FromArgb(132,130,132);
		private Color buttonColorHover = Color.FromArgb(59,122,87);   
		private Color buttonColorNormal = buttonColorOrigin;
		private Color buttonColorDefault = buttonColorOrigin;

		private Color textColorDisabled  = Color.Black;
		private Color textColorHover = Color.White;   
		private Color textColorNormal = Color.Black;
		private Color textColorDefault = Color.Black;

		// If your source bitmaps have shadows, set this 
		// to the shadow size so DrawText can position the 
		// label appears centered on the label
		private int buttonShadowOffset = 7;

		//Text Variables
		private int textShadowOffset = 0;

		//Content Padding
		private int imagePaddingX = 14;
		private int imagePaddingY = 5;
		private int textPaddingX = 2;
		private int textPaddingY = 5;

		//For Sizing Button
		private bool	sizeToLabel = false;

		//------------------------------------------------------------------
		// Mouse tracking
		private bool	mousePressed;
		private bool	blEntered;
		private Point	ptMousePosition = new Point(0,0);

		// Images used to draw the button
		private Bitmap buttonPicture;

		// Rectangle that really contains the button image without shadow
		private Rectangle buttonRect;

		// Matrices for transparency transformation
		private ImageAttributes iaDefault, iaNormal, iaHover, iaDisabled;
		private ColorMatrix cmDefault, cmNormal, cmHover, cmDisabled;

		// Text properties
		private ContentAlignment textAlign = ContentAlignment.MiddleCenter;

		// Image properties
		private ContentAlignment imageAlign = ContentAlignment.MiddleLeft;

		#endregion

		//===============================================================
		#region Constructors and Initializers

		/// <summary>
		/// Constructor method of <see cref="MACButton"/> class
		/// </summary>
		public MACButton( ) 
		{

			// Prevent drawing flicker by blitting from memory in WM_PAINT
			SetStyle(ControlStyles.DoubleBuffer | 
				ControlStyles.AllPaintingInWmPaint |
				ControlStyles.UserPaint |
				ControlStyles.SupportsTransparentBackColor|
				ControlStyles.Selectable| 
				ControlStyles.ResizeRedraw, true);

			// Prevent base class from trying to generate double click events and
			// so testing clicks against the double click time and rectangle. Getting
			// rid of this allows the user to press then button very quickly.
			SetStyle(ControlStyles.StandardDoubleClick, false);

			LoadButtonImage();

			InitializeGraphics();

			this.BackColor = Color.Transparent;
			this.Font = new Font("Verdana Ref", 9, FontStyle.Bold);

			if(stringFormat == null)
			{
				stringFormat = new StringFormat();
				stringFormat.FormatFlags = StringFormatFlags.NoWrap;
				stringFormat.Trimming = StringTrimming.EllipsisCharacter;
				stringFormat.HotkeyPrefix = HotkeyPrefix.Show;
			}
		}
		
		#endregion

		//===============================================================
		#region Properties

		//---------------------------------------------------------------
		//Button Color
		//---------------------------------------------------------------
		/// <summary>
		/// The Button Color that is used on the <b>Disabled</b> state of the button.
		/// You can select any <see cref="Color"/> you want for this state.
		/// </summary>
		/// <remarks> <b>Note</b>: When you want to set the button color by ButtonColorDisabled property, 
		/// and set the text color by <see cref="TextColorDisabled"/> property, you must set the <see cref="ColorStyleDisabled"/> 
		/// to 'UserDefined�f value. If you set ColorStyleDisabled to another value, that will overrides 
		/// this property's value.
		/// </remarks>
		/// <value>A <see cref="Color"/> that represents the color of the button when it's in <b>Disabled</b> state.</value>
		[Description("The Button Color that is used on the Disabled state of the button.")]
		[Category("Appearance Color")]
		public Color ButtonColorDisabled
		{
			get {return buttonColorDisabled; }
			set 
			{
				buttonColorDisabled = value;					
				if(iaDisabled != null)
				{
					cmDisabled = GetTranslationColorMatrix(buttonColorOrigin, buttonColorDisabled);
					iaDisabled.SetColorMatrix( cmDisabled, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
				}
				this.Invalidate();
			}
		}

		/// <summary>
		/// The Button Color that is used on the <b>Hover</b> state of the button.
		/// You can select any <see cref="Color"/> you want for this state.
		/// </summary>
		/// <remarks> <b>Note</b>: When you want to set the button color by ButtonColorHover property, 
		/// and set the text color by <see cref="TextColorHover"/> property, you must set the <see cref="ColorStyleHover"/> 
		/// to 'UserDefined�f value. If you set ColorStyleHover to another value, that will overrides 
		/// this property's value.
		/// </remarks>
		/// <value>A <see cref="Color"/> that represents the color of the button when it's in <b>Hover</b> state.</value>
		[Description("The Button Color is used on the Hovered state of the button.")]
		[Category("Appearance Color")]
		public Color ButtonColorHover
		{
			get {return buttonColorHover;}
			set 
			{
				buttonColorHover = value;					
				if(iaHover != null)
				{
					cmHover = GetTranslationColorMatrix(buttonColorOrigin, buttonColorHover);
					iaHover.SetColorMatrix( cmHover, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
				}
				this.Invalidate();
			}
		}

		/// <summary>
		/// The Button Color that is used on the <b>Normal</b> state of the button.
		/// You can select any <see cref="Color"/> you want for this state.
		/// </summary>
		/// <remarks> <b>Note</b>: When you want to set the button color by ButtonColorNormal property, 
		/// and set the text color by <see cref="TextColorNormal"/> property, you must set the <see cref="ColorStyleNormal"/> 
		/// to 'UserDefined�f value. If you set ColorStyleNormal to another value, that will overrides 
		/// this property's value.
		/// </remarks>
		/// <value>A <see cref="Color"/> that represents the color of the button when it's in <b>Normal</b> state.</value>
		[Description("This Button Color is used on the Normal state of the button.")]
		[Category("Appearance Color")]
		public Color ButtonColorNormal
		{
			get {return buttonColorNormal; }
			set 
			{
				buttonColorNormal = value; 					
				if(iaNormal != null)
				{
					cmNormal = GetTranslationColorMatrix(buttonColorOrigin, buttonColorNormal);
					iaNormal.SetColorMatrix( cmNormal, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
				}
				this.Invalidate();
			}
		}

		/// <summary>
		/// The Button Color that is used on the <b>Default</b> state of the button.
		/// You can select any <see cref="Color"/> you want for this state.
		/// </summary>
		/// <remarks> <b>Note</b>: When you want to set the button color by ButtonColorDefault property, 
		/// and set the text color by <see cref="TextColorDefault"/> property, you must set the <see cref="ColorStyleDefault"/> 
		/// to 'UserDefined�f value. If you set ColorStyleDefault to another value, that will overrides 
		/// this property's value.
		/// </remarks>
		/// <value>A <see cref="Color"/> that represents the color of the button when it's in <b>Default</b> state.</value>
		[Description("This Button Color is used on the Default state of the button.")]
		[Category("Appearance Color")]
		public Color ButtonColorDefault
		{
			get {return buttonColorDefault; }
			set 
			{
				buttonColorDefault = value;
				if(iaDefault != null)
				{
					cmDefault = GetTranslationColorMatrix(buttonColorOrigin, buttonColorDefault);
					iaDefault.SetColorMatrix( cmDefault, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
				}

				this.Invalidate();
			}
		}

		//---------------------------------------------------------------
		//Text Color
		//---------------------------------------------------------------
		/// <summary>
		/// This property determines the Text Color that is used on the Disabled state of the button.
		/// You can select any <see cref="Color"/> you want for this state.
		/// </summary>
		/// <remarks> <b>Note</b>: When you want to set the button color by ButtonColorDisabled property, 
		/// and set the text color by <see cref="TextColorDisabled"/> property, you must set the <see cref="ColorStyleDisabled"/> 
		/// to 'UserDefined�f value. If you set ColorStyleDisabled to another value, that will overrides 
		/// this property's value.
		/// </remarks>
		/// <value>A <see cref="Color"/> that represents the color of the <see cref="Text"/> when it's in <b>Disabled</b> state.</value>
		[Description("This property determines the Text Color that is used on the Disabled state of the button.")]
		[Category("Appearance Color")]
		public Color TextColorDisabled
		{
			get {return textColorDisabled; }
			set 
			{
				textColorDisabled = value; 					
				this.Invalidate();
			}
		}

		/// <summary>
		/// This property determines the Text Color that is used on the Hover state of the button.
		/// You can select any <see cref="Color"/> you want for this state.
		/// </summary>
		/// <remarks> <b>Note</b>: When you want to set the button color by ButtonColorHover property, 
		/// and set the text color by <see cref="TextColorHover"/> property, you must set the <see cref="ColorStyleHover"/> 
		/// to 'UserDefined�f value. If you set ColorStyleHover to another value, that will overrides 
		/// this property's value.
		/// </remarks>
		/// <value>A <see cref="Color"/> that represents the color of the <see cref="Text"/> when it's in <b>Hover</b> state.</value>
		[Description("This property determines the Text Color that is used on the Hover state of the button.")]
		[Category("Appearance Color")]
		public Color TextColorHover
		{
			get {return textColorHover; }
			set 
			{
				textColorHover = value; 					
				this.Invalidate();
			}
		}

		/// <summary>
		/// This property determines the Text Color that is used on the Normal state of the button.
		/// You can select any <see cref="Color"/> you want for this state.
		/// </summary>
		/// <remarks> <b>Note</b>: When you want to set the button color by ButtonColorNormal property, 
		/// and set the text color by <see cref="TextColorNormal"/> property, you must set the <see cref="ColorStyleNormal"/> 
		/// to 'UserDefined�f value. If you set ColorStyleNormal to another value, that will overrides 
		/// this property's value.
		/// </remarks>
		/// <value>A <see cref="Color"/> that represents the color of the <see cref="Text"/> when it's in <b>Normal</b> state.</value>
		[Description("This property determines the Text Color that is used on the Normal state of the button.")]
		[Category("Appearance Color")]
		public Color TextColorNormal
		{
			get {return textColorNormal; }
			set 
			{
				textColorNormal = value; 					
				this.Invalidate();
			}
		}

		/// <summary>
		/// This property determines the Text Color that is used on the Default state of the button.
		/// You can select any <see cref="Color"/> you want for this state.
		/// </summary>
		/// <remarks> <b>Note</b>: When you want to set the button color by ButtonColorDefault property, 
		/// and set the text color by <see cref="TextColorDefault"/> property, you must set the <see cref="ColorStyleDefault"/> 
		/// to 'UserDefined�f value. If you set ColorStyleDefault to another value, that will overrides 
		/// this property's value.
		/// </remarks>
		/// <value>A <see cref="Color"/> that represents the color of the <see cref="Text"/> when it's in <b>Default</b> state.</value>
		[Description("This property determines the Text Color that is used on the Default state of the button.")]
		[Category("Appearance Color")]
		public Color TextColorDefault
		{
			get {return textColorDefault; }
			set 
			{
				textColorDefault = value; 					
				this.Invalidate();
			}
		}

		//---------------------------------------------------------------

		/// <summary>
		/// Gets or sets the value that determines shadow offset of the <see cref="Text"/> within button.
		/// </summary>
		/// <remarks>The <see cref="Text"/> hasnt' shadow if this property is set to 0.</remarks>
		/// <value>The shadow offset of the <see cref="Text"/> within button in pixels. The default value is 0.</value>
		[Description("This property determines shadow offset of the text within button.")]
		[Category("Appearance Text")]
		[DefaultValue(0)]
		public int TextShadowOffset
		{
			get {return textShadowOffset; }
			set 
			{
				textShadowOffset = value; 					
				this.Invalidate();
			}
		}

		//---------------------------------------------------------------
		/// <summary>
		/// Gets or sets the value that determines Image Padding in the X-axis. 
		/// </summary>
		/// <remarks>
		/// <para>
		/// Please note that MACButton supports very better alignment and allocation for text and image with following properties: 
		/// <see cref="ImageAlign"/>, <see cref="ImagePaddingX"/>, <see cref="ImagePaddingY"/>, <see cref="TextAlign"/>, 
		/// <see cref="TextPaddingX"/>, <see cref="TextPaddingY"/>.
		/// </para>
		/// <para>
		/// Please read the section �eAlignment of Text and Image on Button�ffor detail.
		/// </para>
		/// </remarks>
		/// <value>This property determines Image Padding in X-axis. The default value is 14.</value>
		[Browsable(true)]
		[Category("Appearance Child Image")]
		[Description("Gets or sets the value that determines Image Padding in the X-axis. Please note that this MACButton supports very better alignment and allocation for text and image with following properties: ImageAlign, ImagePaddingX, ImagePaddingY, TextAlign, TextPaddingX, TextPaddingY.")]
		[DefaultValue(14)]
		public int ImagePaddingX
		{
			get{return imagePaddingX;}
			set
			{
				if(imagePaddingX != value) 
				{
					imagePaddingX = value;
					this.Invalidate();
				}
			}
		}

		//---------------------------------------------------------------

		/// <summary>
		/// Gets or sets the value that determines Image Padding in the Y-axis. 
		/// </summary>
		/// <remarks>
		/// <para>
		/// Please note that MACButton supports very better alignment and allocation for text and image with following properties: 
		/// <see cref="ImageAlign"/>, <see cref="ImagePaddingX"/>, <see cref="ImagePaddingY"/>, <see cref="TextAlign"/>, 
		/// <see cref="TextPaddingX"/>, <see cref="TextPaddingY"/>.
		/// </para>
		/// <para>
		/// Please read the section �eAlignment of Text and Image on Button�ffor detail.
		/// </para>
		/// </remarks>
		/// <value>This property determines Image Padding in Y-axis. The default value is 5.</value>
		[Browsable(true)]
		[Category("Appearance Child Image")]
		[Description("Gets or sets the value that determines Image Padding in Y-axis. Please note that this MACButton supports very better alignment and allocation for text and image with following properties: ImageAlign, ImagePaddingX, ImagePaddingY, TextAlign, TextPaddingX, TextPaddingY.")]
		[DefaultValue(5)]
		public int ImagePaddingY
		{
			get{return imagePaddingY;}
			set
			{
				if(imagePaddingY != value) 
				{
					imagePaddingY = value;
					this.Invalidate();
				}
			}
		}

		/// <summary>
		/// Gets or sets the value that determines Text Padding in the X-axis. 
		/// </summary>
		/// <remarks>
		/// <para>
		/// Please note that MACButton supports very better alignment and allocation for text and image with following properties: 
		/// <see cref="ImageAlign"/>, <see cref="ImagePaddingX"/>, <see cref="ImagePaddingY"/>, <see cref="TextAlign"/>, 
		/// <see cref="TextPaddingX"/>, <see cref="TextPaddingY"/>.
		/// </para>
		/// <para>
		/// Please read the section �eAlignment of Text and Image on Button�ffor detail.
		/// </para>
		/// </remarks>
		/// <value>This property determines Text Padding in X-axis. The default value is 2.</value>
		[Browsable(true)]
		[CategoryAttribute("Appearance Text")]
		[Description("Gets or sets the value that determines Text Padding in X-axis. Please note that this MACButton supports very better alignment and allocation for text and image with following properties: ImageAlign, ImagePaddingX, ImagePaddingY, TextAlign, TextPaddingX, TextPaddingY.")]
		[DefaultValue(2)]
		public int TextPaddingX
		{
			get{return textPaddingX;}
			set
			{
				if(textPaddingX != value) 
				{
					textPaddingX = value;
					this.Invalidate();
				}
			}
		}

		/// <summary>
		/// Gets or sets the value that determines Text Padding in the Y-axis. 
		/// </summary>
		/// <remarks>
		/// <para>
		/// Please note that MACButton supports very better alignment and allocation for text and image with following properties: 
		/// <see cref="ImageAlign"/>, <see cref="ImagePaddingX"/>, <see cref="ImagePaddingY"/>, <see cref="TextAlign"/>, 
		/// <see cref="TextPaddingX"/>, <see cref="TextPaddingY"/>.
		/// </para>
		/// <para>
		/// Please read the section �eAlignment of Text and Image on Button�ffor detail.
		/// </para>
		/// </remarks>
		/// <value>This property determines Text Padding in Y-axis. The default value is 5.</value>
		[Browsable(true)]
		[CategoryAttribute("Appearance Text")]
		[Description("Gets or sets the value that determines Text Padding in Y-axis. Please note that this MACButton supports very better alignment and allocation for text and image with following properties: ImageAlign, ImagePaddingX, ImagePaddingY, TextAlign, TextPaddingX, TextPaddingY.")]
		[DefaultValue(5)]
		public int TextPaddingY
		{
			get{return textPaddingY;}
			set
			{
				if(textPaddingY != value) 
				{
					textPaddingY = value;
					this.Invalidate();
				}
			}
		}

		/// <summary>
		/// Gets or sets the text caption displayed in the button control.
		/// </summary>
		/// <remarks>Use the Text property to specify or determine the caption to display in the button control.</remarks>
		/// <value>The text caption displayed in the button control. The default value is <see cref="String.Empty"/>.</value>
		[Description("Gets or sets the text displayed in control.")]
		[EditorBrowsable(EditorBrowsableState.Always)]
		[Browsable(true)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
		[CategoryAttribute("Appearance Text")]
		public new string Text
		{
			get
			{
				return base.Text;
			}
			set
			{
				if(base.Text != value) 
				{
					base.Text = value;
					this.Invalidate();
				}
			}
		}

		/// <summary>
		/// Gets or sets the alignment of the text on the button control.
		/// </summary>
		/// <remarks>
		/// <para>
		/// Please note that MACButton supports very better alignment and allocation for text and image with following properties: 
		/// <see cref="ImageAlign"/>, <see cref="ImagePaddingX"/>, <see cref="ImagePaddingY"/>, <see cref="TextAlign"/>, 
		/// <see cref="TextPaddingX"/>, <see cref="TextPaddingY"/>.
		/// </para>
		/// <para>
		/// Please read the section �eAlignment of Text and Image on Button�ffor detail.
		/// </para>
		/// </remarks>
		/// <value>One of the <see cref="ContentAlignment"/> values. The default is MiddleCenter.</value>
		[Browsable(true)]
		[CategoryAttribute("Appearance Text")]
		[DefaultValue(ContentAlignment.MiddleCenter)]
		[Description("Gets or sets the alignment of the text on the button control.")]
		public ContentAlignment TextAlign
		{
			get
			{
				return textAlign;
			}
			set
			{
				if(textAlign != value) 
				{
					textAlign = value;
					this.Invalidate();
				}
			}
		}

		/// <summary>
		/// Gets or sets the font of the text displayed by the control.
		/// </summary>
		/// <remarks>
		/// <para>
		/// The <see cref="Font"/> property is an ambient property. 
		/// An ambient property is a control property that, 
		/// if not set, is retrieved from the parent control. For example, a <see cref="Button"/> will have the same <see cref="Control.BackColor"/> as its parent <see cref="Form"/> by default.
		/// For more information about ambient properties, see the <see cref="AmbientProperties"/> class or the <see cref="Control"/> class overview.
		/// </para>
		/// <para>
		/// Because the <see cref="Font"/> object is immutable (meaning that you cannot adjust any of it's 
		/// properties), you can only assign the <see cref="Font"/> property a new <see cref="Font"/> object. 
		/// However, you can base the new font on the existing font.
		/// </para>
		/// </remarks>
		/// <value>The <see cref="Font"/> object to apply to the text displayed by the control. The default is the value of the <see cref="Control.DefaultFont"/> property.</value>
		[CategoryAttribute("Appearance Text")]
		public override Font Font
		{
			get 
			{ 
				return base.Font;
			}

			set
			{
				base.Font = value;
			}
		}


		//End=====================Pulsing Properties============================================

		/// <summary>
		/// This property determines whether the button should automatically size to fit the Text within it. 
		/// </summary>
		/// <remarks>In case this property is set to true, 
		/// whenver you change <see cref="Text"/>, the button's size is recalculated to fit with the text.</remarks>
		/// <value>The default value is false.</value>
		[Description("This property determines whether the button should automatically size to fit the Text within it. The default value is False.")]
		[Category("Behavior")]
		[DefaultValue(false)]
		public bool SizeToLabel
		{
			get { return sizeToLabel; }
			set 
			{ 
				sizeToLabel = value;
				ResizeButton(); 					
			}
		}

		/// <summary>
		/// Gets or sets the value that determines shadow offset of the button.
		/// </summary>
		/// <remarks>
		/// <para>
		/// Please note that MACButton supports very better alignment and allocation for text and image with following properties: 
		/// <see cref="ImageAlign"/>, <see cref="ImagePaddingX"/>, <see cref="ImagePaddingY"/>, <see cref="TextAlign"/>, 
		/// <see cref="TextPaddingX"/>, <see cref="TextPaddingY"/>.
		/// </para>
		/// <para>
		/// Please read the section �eAlignment of Text and Image on Button�ffor detail.
		/// </para>
		/// </remarks>
		/// <value>This property determines shadow offset of the button. You can use this property to adjust vertical position of text on the button. The default value is 7.</value>
		[Description("This property determines shadow offset of the button. You can use this property to adjust vertical position of text on the button. The default value is 7.")]
		[Category("Appearance")]
		[Browsable( true)]
		[DefaultValue(7)]
		public int ButtonShadowOffset 
		{
			get { return buttonShadowOffset; }
			set { buttonShadowOffset = value; this.Invalidate();}
		}

		#endregion

		//===============================================================
		#region Property overrides

		/// <summary>
		/// Gets or sets the alignment of the image on the button control.
		/// </summary>
		/// <remarks>
		/// <para>
		/// Please note that MACButton supports very better alignment and allocation for text and image with following properties: 
		/// <see cref="ImageAlign"/>, <see cref="ImagePaddingX"/>, <see cref="ImagePaddingY"/>, <see cref="TextAlign"/>, 
		/// <see cref="TextPaddingX"/>, <see cref="TextPaddingY"/>.
		/// </para>
		/// <para>
		/// Please read the section �eAlignment of Text and Image on Button�ffor detail.
		/// </para>
		/// </remarks>
		/// <value>One of the <see cref="ContentAlignment"/> values. The default is MiddleCenter.</value>
		[Description("Gets or sets the alignment of the image on the button. Its value is one of the ContentAlignment values. The default value is MiddleLeft.")]
		[Category("Appearance Child Image")]
		[Browsable( true)]
		[DefaultValue(ContentAlignment.MiddleLeft)]
		public ContentAlignment ImageAlign
		{
			get { return imageAlign; }
			set 
			{ 
				if(imageAlign != value)
				{
					imageAlign = value; 
					this.Invalidate();
				}

			}
		}


		#endregion

		//===============================================================
		#region Method overrides

		/// <summary>
		/// This member overrides <see cref="Control.OnSizeChanged">Control.OnSizeChanged</see>.
		/// </summary>
		protected override void OnSizeChanged ( EventArgs e )
		{
			base.OnSizeChanged(e);
			ResizeButton();
		}

		/// <summary>
		/// This member overrides <see cref="Control.OnTextChanged">Control.OnTextChanged</see>.
		/// </summary>
		protected override void OnTextChanged( EventArgs e )
		{
			ResizeButton();
			base.OnTextChanged( e );
		}

		private void ResizeButton()
		{
			if (sizeToLabel) 
			{
				Graphics g = this.CreateGraphics( );
				SizeF sizeF = g.MeasureString(Text, Font);
				Width = (int)sizeF.Width + 12* textPaddingX;
				Height = (int)sizeF.Height + 4* textPaddingY;
				g.Dispose();
				Invalidate( );
			}
		}


		/// <summary>
		/// This member overrides <see cref="Control.OnPaint">Control.OnPaint</see>.
		/// </summary>
		protected override void OnPaint( PaintEventArgs e)
		{
			Graphics g = e.Graphics;

			CalculateButtonRect(); 
			DrawButton(g);
			DrawText(g);
		}

	
		/// <summary>
		/// This member overrides <see cref="Control.OnMouseDown">Control.OnMouseDown</see>.
		/// </summary>
		protected override void OnMouseDown( MouseEventArgs e )
		{
			base.OnMouseDown( e );

			if( e.Button == MouseButtons.Left ) 
			{
				mousePressed = true;
				
				ptMousePosition.X = e.X;
				ptMousePosition.Y = e.Y;

			}
			this.Invalidate();
		}

		/// <summary>
		/// This member overrides <see cref="Control.OnMouseMove">Control.OnMouseMove</see>.
		/// </summary>
		protected override void OnMouseMove( MouseEventArgs e )
		{
			// Buttons receives MouseMove events when the
			// mouse enters or leaves the client area.

			base.OnMouseMove( e );

			if( mousePressed && ( e.Button & MouseButtons.Left ) != 0 )
			{
				ptMousePosition.X = e.X;
				ptMousePosition.Y = e.Y;
			} 
		}

		/// <summary>
		/// This member overrides <see cref="Control.OnMouseLeave">Control.OnMouseLeave</see>.
		/// </summary>
		protected override void OnMouseLeave(  EventArgs e )
		{
			// Buttons receives MouseMove events when the
			// mouse enters or leaves the client area.
			base.OnMouseLeave(e);

			blEntered = false;
			Invalidate();
			//Update(); //By NghiaNT 06June2006 - Performance Review
		}

		/// <summary>
		/// This member overrides <see cref="Control.OnMouseEnter">Control.OnMouseEnter</see>.
		/// </summary>
		protected override void OnMouseEnter(  EventArgs e )
		{
			// Buttons receives MouseMove events when the
			// mouse enters or leaves the client area.
			base.OnMouseEnter(e);

			blEntered = true;
			Invalidate();
		}

		/// <summary>
		/// This member overrides <see cref="Control.OnMouseUp">Control.OnMouseUp</see>.
		/// </summary>
		protected override void OnMouseUp( MouseEventArgs e )
		{
			base.OnMouseUp(e);

			if( mousePressed ) 
			{
				mousePressed = false;

				Invalidate();
			}
		}

		/// <summary>
		/// This member overrides <see cref="Control.OnKeyPress">Control.OnKeyPress</see>.
		/// </summary>
		protected override void OnKeyPress( KeyPressEventArgs e )
		{
			base.OnKeyPress( e );

			if(mousePressed && e.KeyChar == (char) Keys.Escape)  
			{
				mousePressed = false;

			}
		}

		/// <summary>
		/// This member overrides <see cref="Control.Dispose">Control.Dispose</see>.
		/// </summary>
		/// <param name="disposing">true to release both managed and unmanaged resources; false to release only unmanaged resources.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				if(iaDefault != null)
					iaDefault.Dispose();
				if(iaNormal != null)
					iaNormal.Dispose();
				if(iaDisabled != null)
					iaDisabled.Dispose();
				if(iaHover != null)
					iaHover.Dispose();
			}
			
			base.Dispose (disposing);
		}

		#endregion

		//===============================================================
		#region Paiting Implementation

		private void LoadButtonImage()
		{
			if(buttonPicture != null)
				buttonPicture.Dispose();
			
			string templateFileName = "PicTemplate.RoundedRectangle.png";
			buttonPicture = new Bitmap( GetType(),templateFileName);
		}

		private void InitializeGraphics ()
		{
			//----------------------------------------
			//Disbled State
			//Image attributes used to lighten default buttons
			cmDisabled = GetTranslationColorMatrix(buttonColorOrigin, buttonColorDisabled);
			iaDisabled = new ImageAttributes();
			iaDisabled.SetColorMatrix( cmDisabled, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
			//----------------------------------------

			//----------------------------------------
			//Default State
			//Image attributes used to lighten default buttons
			cmDefault = GetTranslationColorMatrix(buttonColorOrigin, buttonColorDefault);
			iaDefault = new ImageAttributes();
			iaDefault.SetColorMatrix( cmDefault, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
			//----------------------------------------
			
			//----------------------------------------
			//Normal State
			//Image attributes that lighten and desaturate normal buttons
			cmNormal = GetTranslationColorMatrix(buttonColorOrigin, buttonColorNormal);
			iaNormal = new ImageAttributes();
			iaNormal.SetColorMatrix( cmNormal, ColorMatrixFlag.Default, ColorAdjustType.Bitmap );
			//----------------------------------------

			//----------------------------------------
			//Hover State
			//Image attributes for mouse over status
			cmHover = GetTranslationColorMatrix(buttonColorOrigin, buttonColorHover);
			iaHover = new ImageAttributes();
			iaHover.SetColorMatrix(cmHover, ColorMatrixFlag.Default, ColorAdjustType.Bitmap );
			//----------------------------------------
		
		}

		private void CalculateButtonRect() 
		{
			int scaledOffset;
			scaledOffset = buttonShadowOffset * this.Height/buttonPicture.Height;
			buttonRect = new Rectangle( 0, 0, this.Width, this.Height - scaledOffset);
		}
		/// <summary>
		/// calculates the left/top edge for content.
		/// </summary>
		/// <param name="Alignment">the alignment of the content</param>
		/// <param name="rect">rectagular region to place content</param>
		/// <param name="nWidth">with of content</param>
		/// <param name="nHeight">height of content</param>
		/// <returns>returns the left/top edge to place content</returns>
		private Point Calculate_LeftEdgeTopEdge(ContentAlignment Alignment, Rectangle rect, int nWidth, int nHeight)
		{
			Point pt = new Point(0,0);
			switch(Alignment)
			{					
				case ContentAlignment.BottomCenter:
					pt.X = (rect.Width - nWidth)/2;
					pt.Y = rect.Height - nHeight;					
					break;
				case ContentAlignment.BottomLeft:
					pt.X = 0;
					pt.Y = rect.Height - nHeight;
					break;
				case ContentAlignment.BottomRight:
					pt.X = rect.Width - nWidth;
					pt.Y = rect.Height - nHeight;
					break;
				case ContentAlignment.MiddleCenter:
					pt.X = (rect.Width - nWidth)/2;
					pt.Y = (rect.Height - nHeight)/2;
					break;
				case ContentAlignment.MiddleLeft:						
					pt.X = 0;
					pt.Y = (rect.Height - nHeight)/2;						
					break;
				case ContentAlignment.MiddleRight:
					pt.X = rect.Width - nWidth;
					pt.Y = (rect.Height - nHeight)/2;						
					break;
				case ContentAlignment.TopCenter:
					pt.X = (rect.Width - nWidth)/2;
					pt.Y = 0;
					break;
				case ContentAlignment.TopLeft:
					pt.X = 0;
					pt.Y = 0;
					break;
				case ContentAlignment.TopRight:
					pt.X = rect.Width - nWidth;
					pt.Y = 0;
					break;
			}
			pt.X += rect.Left;
			pt.Y += rect.Top;
			return(pt);
		}

		//==============================================================
		// Drawing Button
		//==============================================================
		private void DrawButton( Graphics g )
		{
			if(this.Enabled == false)
			{
				DrawButtonState( g, iaDisabled);
			}
			else if(mousePressed)
			{
				if (ClientRectangle.Contains(ptMousePosition.X, ptMousePosition.Y))
					DrawButtonState( g, iaDefault);// If Mouse Pressed then Draw Click State (not Default State)
				else
					DrawButtonState( g, iaNormal);
			}
			else if(blEntered)
			{
				DrawButtonState( g, iaHover);
			}
			else
			{
				DrawButtonState( g, iaNormal);
			}
		}

		private void DrawButtonState (Graphics g, ImageAttributes ia)
		{
			g.DrawImage( buttonPicture, this.ClientRectangle, 0, 0, buttonPicture.Width, buttonPicture.Height, GraphicsUnit.Pixel,ia);
		} 

		//==============================================================
		// Drawing Text
		//==============================================================
		private void DrawText( Graphics g )
		{
			string textTemp = this.Text;
			textTemp.Trim();

			if(textTemp.Length != 0)
			{
				Rectangle drawRect = GetTextDestinationRect();

				// Caculate bounding Rectangle for the text
				SizeF size = g.MeasureString(this.Text,this.Font);

				// Calculate the starting location to paint the text
				Point pt = Calculate_LeftEdgeTopEdge(this.TextAlign, drawRect, (int) size.Width, (int) size.Height);

				// Draw text at the above Point
				DrawTextByColor(g,pt,GetTextColor());
			}
		}

		/// <summary>
		/// Calculates the rectangular region used for text display.
		/// </summary>
		/// <returns>returns the rectangular region for the text display</returns>
		private Rectangle GetTextDestinationRect()
		{
			Rectangle textRect = buttonRect;
			textRect.Inflate(-this.textPaddingX,-this.textPaddingY);
			return (textRect);
		}
		
		private Color GetTextColor()
		{
			Color textColor;

			if(this.Enabled == false)
			{
				textColor = textColorDisabled;
			}
			else if(mousePressed)
			{
				if (ClientRectangle.Contains(ptMousePosition.X, ptMousePosition.Y))
					textColor = textColorDefault;
				else
					textColor = textColorNormal;
			}
			else if(blEntered)
			{
				textColor = textColorHover;
			}
			else
			{
				textColor = textColorNormal;
			}

			return textColor;
		}

		private void DrawTextByColor( Graphics g, Point pt, Color textColor) 
		{
			// Draw the shadow below the label
			if(textShadowOffset != 0)
			{
				Point shadowPoint = pt;
				shadowPoint.Offset(0, textShadowOffset );
				g.DrawString(this.Text,this.Font, Brushes.Gray, shadowPoint.X, shadowPoint.Y, stringFormat);	
			}

			// and the label itself
			SolidBrush brushText = new SolidBrush(textColor);
			g.DrawString(this.Text,this.Font, brushText, pt.X, pt.Y, stringFormat);	
			brushText.Dispose();
		}

		//==============================================================
		/// <summary>
		/// Detect if it is in Design Mode.
		/// </summary>
		/// <returns>true if is being in Design Mode; otherwize false.</returns>
		protected bool DesignModeDetected()
		{
			IDesignerHost host = 
				(IDesignerHost) this.GetService( typeof( IDesignerHost ) );

			return ( host != null );
		}

		#endregion


		/// <summary>
		/// Get ColorMatrix that transform from the origin color to a new color
		/// </summary>
		private ColorMatrix GetTranslationColorMatrix(Color originColor, Color newColor)
		{

			// Image attributes that lighten and desaturate normal buttons
			ColorMatrix cmTrans = new ColorMatrix();

			if(newColor.Equals(originColor))
				return cmTrans;

			float fTransRed = (float)newColor.R/(float)(originColor.R + originColor.G + originColor.B);
			float fTransGreen = (float)newColor.G/(float)(originColor.R + originColor.G + originColor.B);
			float fTransBlue = (float)newColor.B/(float)(originColor.R + originColor.G + originColor.B);

			// Translate the Origin Color to New Color
			cmTrans.Matrix00 = fTransRed;
			cmTrans.Matrix10 = fTransRed;
			cmTrans.Matrix20 = fTransRed;

			cmTrans.Matrix01 = fTransGreen;
			cmTrans.Matrix11 = fTransGreen;
			cmTrans.Matrix21 = fTransGreen;

			cmTrans.Matrix02 = fTransBlue;
			cmTrans.Matrix12 = fTransBlue;
			cmTrans.Matrix22 = fTransBlue;

			return cmTrans;

		}
	}
}


