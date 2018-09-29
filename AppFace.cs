using System;
using System.Runtime ;
using System.Runtime.InteropServices ;


//Imports System
using System.Drawing ;



namespace MCKJ
{

	[StructLayout(LayoutKind.Sequential)]
	public struct RECT
	{
		public int left ;
		public int top  ;
		public int right ;
		public int bottom ;	
		public RECT(int l ,int t, int r,int b){left =t ;right =r ;top =t;bottom = b;}
	}

	/// <summary>
	/// </summary>
	public class AppFace
	{

		
	
		//------------------------------------------------------------------------
		//The interface declaration for AppFace
		[DllImport("appface.dll")] 
		public static extern int SkinStart(string SkinFile,int nDefWinType,string CheckSum,int nType,int hInstance,int nLen);
		
		[DllImport("appface.dll")]
		public static extern int SkinRemove() ;		
		[DllImport("appface.dll")]
		public static extern int SkinWindowSet(IntPtr hWnd,int nSkintype);
		[DllImport("appface.dll")]
		public static extern int SkinWindowSetEx(IntPtr hWnd,int nSkintype,int nResourceId,int nUrfLoadType,string SkinFile,int hInstance,int nLen);
		
		[DllImport("appface.dll")]
		public static extern IntPtr BkCreate(int nbktype);

		[DllImport("appface.dll")]
		public static extern int BkDelete(IntPtr hBk);

		[DllImport("appface.dll")]
		public static extern int BkDraw(IntPtr hBk,IntPtr hDC,ref RECT rc ,int nSkintype);
		//------------------------------------------------------------------------


		//The frame control button would send this message when it has been clicked
		public const int WM_FRAME_BUTTON  = 0x764  ;

		//Send this message to the hyperlink control to modify the URL 
		public const int WM_HYPERLINK_URL     =   0X765 ;

		//Send this message to display a transparent GIF on a SKIN_CLASS_STATIC control
		public const int WM_TRANSPARENT_GIF    =  0X765 ;

		//For WM_FRAME_BUTTON  WPARAM
		public const int FRAME_BUTTON_MAX          =   1;
		public const int FRAME_BUTTON_RESTORE      =   2;
		public const int FRAME_BUTTON_MIN          =   3;
		public const int FRAME_BUTTON_CLOSE        =   4;
		  
				//For custom frame button
		public const int FRAME_BUTTON_CUSTOMBASE   = 0x200 ;           //The custom control button

		public const int FB_COMMAND_REMOVE         =   0;
		public const int FB_COMMAND_ENABLE         =   1;
		public const int FB_COMMAND_DISABLE        =   2;
		public const int FB_COMMAND_CHECK          =   3;
		public const int FB_COMMAND_UNCHECK        =   4;


				//Load URF,and skin windows automatically
		public const int GTP_LOAD_FILE            =    1;
		public const int GTP_LOAD_MEMORY          =    2;
		public const int GTP_LOAD_RESOURCE         =   3;
				//Load the URF into memory only ,but do not skin any windows,
				//until users call SkinWindowSet
		public const int GTP_LOAD_FILE_ONLY      =     4 ;   
		public const int GTP_LOAD_MEMORY_ONLY     =    5;
		public const int GTP_LOAD_RESOURCE_ONLY    =   6;

				//The window was created by which development tool
		public const int WINDOW_TYPE_AUTOFILTER    =   0 ; //Auto detected by appface
		public const int WINDOW_TYPE_SDK            =  1;
		public const int WINDOW_TYPE_VC           =    1;
		public const int WINDOW_TYPE_VB6          =    2;
		public const int WINDOW_TYPE_BCB          =    3;
		public const int WINDOW_TYPE_DELPHI      =     3;
		public const int WINDOW_TYPE_NET         =     4;

				//Windows skin type,used for SkinWindowSet function
		public const int SKIN_CLASS_NOSKIN       =     0 ;  //Do not skin a window ,but allocate the needed resource for it

				//Windows
		public const int SKIN_CLASS_AUTOFILTER    =    1  ; //AppFace skin this window automatically

		public const int SKIN_CLASS_PAUSESKIN     =    2  ; //Pause skin for a special window,but do not free resource
		public const int SKIN_CLASS_REDOSKIN     =     3   ;//Redo skin from pause state
		public const int SKIN_CLASS_REMOVESKIN    =    4 ;  //Unskin a window and remove all the allocated skin resource for it at the same time
		public const int SKIN_CLASS_NOSKINEX      =    5 ;  //Unskin a window and all the child windows of it


		public const int SKIN_CLASS_UNKNOWN      =     6;
		public const int SKIN_CLASS_AUTOFILTEREX  =    7;
		public const int SKIN_CLASS_SCROLLWIN     =   10;
		public const int SKIN_CLASS_SCROLLWINBORDER  =11;
		public const int SKIN_CLASS_FRAMEWIN      =  101;
		public const int SKIN_CLASS_FRAMEDIALOG   =  102;
		public const int SKIN_CLASS_INSIDEDIALOG  =  103;
		public const int SKIN_CLASS_MDICLIENT     =  104;
		public const int SKIN_CLASS_SCROLLPANEL   =  105;
		public const int SKIN_CLASS_FRAMEBACKGROUND= 106;

				//Controls
		public const int SKIN_CLASS_COMBOBOX      =  201;
		public const int SKIN_CLASS_DATETIME      =  202;
		public const int SKIN_CLASS_HEADER         = 203;
		public const int SKIN_CLASS_GROUPBOX      =  204;
		public const int SKIN_CLASS_IMAGEBUTTON   =  205;
		public const int SKIN_CLASS_MENU          =  206;
		public const int SKIN_CLASS_PROGRESS      =  207;
		public const int SKIN_CLASS_PUSHBUTTON   =   208;
		public const int SKIN_CLASS_SCROLLBAR      = 209;
		public const int SKIN_CLASS_SLIDER        =  210;
		public const int SKIN_CLASS_SPIN          =  211;
		public const int SKIN_CLASS_SPILTER      =   212;
		public const int SKIN_CLASS_STATUSBAR     =  213;
		public const int SKIN_CLASS_TAB           =  214;
		public const int SKIN_CLASS_TEXT          =  215;
		public const int SKIN_CLASS_TOOLBAR       =  216;
		public const int SKIN_CLASS_TOOLBARPANEL  =  217;
		public const int SKIN_CLASS_PANEL         =  218;
		public const int SKIN_CLASS_PANELEX       =  219;
		public const int SKIN_CLASS_PANELELIXIR   =  220;
		public const int SKIN_CLASS_HYPERLINK     =  221;
		public const int SKIN_CLASS_STATUSBAR_VB6 =  222;
		public const int SKIN_CLASS_SHAPEWIN      =  223;
		public const int SKIN_CLASS_CHECKBUTTON   =  224;
		public const int SKIN_CLASS_RADIOBUTTON   =  225;
		public const int SKIN_CLASS_READONLYEDIT  =  226;

		public const int SKIN_CLASS_FRAMEBTN      =  227;
		public const int SKIN_CLASS_SLIDEREX      =  228;



				//Only for SkinWindowSetEx
		public const int SKIN_SET_TRANSPARENT     =  601;
		public const int SKIN_SET_THEME_COLOR     =  602;
		public const int SKIN_SET_EFFECT          =  603;
		public const int SKIN_SET_REDRAW          =  604;

		public const int SKIN_SET_PAINTCUSTOMPROC =  605;
		public const int SKIN_SET_NCPAINTCUSTOMPROC= 606;

		public const int SKIN_SET_SPECIAL_TOOL     = 610;

				//Only for VB6 scrollbar control
		public const int SKIN_SET_VB6_SCROLL_INFO  = 611;


		public const int SKIN_SET_UNSKIN            =660;
		public const int SKIN_SET_UNICODE_URF_FONT  =661;

				//Pause all the skin functions of AppFace for all windows in the target process,
				//SKIN_CLASS_PAUSESKIN only pause skin functions for one special window .
				//These two parameters do not release the allocated resource both.
		public const int SKIN_SET_PAUSESKIN        = 662;

				//Restore skin functions from SKIN_SET_PAUSESKIN state
		public const int SKIN_SET_REDOSKIN         = 663;

				//Indicate skin or not skin VC static control automatically
		public const int SKIN_SET_VCLABEL          = 664;

				//To control the custom frame button
		public const int SKIN_SET_FRAMEBTN         = 665;

				//Create bk object from another URF
		public const int SKIN_GET_BK               = 701;


				//

				//Only for SKIN_SET_EFFECT
		public const int EFFECT_IN_SPIN             =  2;
		public const int EFFECT_IN_VORTEX           =  3;
		public const int EFFECT_IN_SCATTER          =  4;
		public const int EFFECT_IN_STAR             =  5;
		public const int EFFECT_IN_RAZZLE           =  6;

		public const int EFFECT_OUT_SPIN            =  52;
		public const int EFFECT_OUT_VORTEX          = 53;
		public const int EFFECT_OUT_SCATTER         = 54;
		public const int EFFECT_OUT_STAR            = 55;
		public const int EFFECT_OUT_RAZZLE          = 56;


				//Background type
		public const int BK_DIALOGPANEL              = 1;
		public const int BK_MDICLIENT                = 2;
		public const int BK_MDICHILD                 = 3;
		public const int BK_SPLITTER                 = 4;
		public const int BK_STATUSBAR                = 5;
		public const int BK_MENUBARBK                = 6;
		public const int BK_MENUBARHOVER             = 7;
		public const int BK_MENUBARDOWN              = 8;
		public const int BK_MENU_BK                  = 9;
		public const int BK_MENU_HOVER               =10;
		public const int BK_SCROLL_BK                =11;
		public const int BK_SLIDER_CHANNEL_H         =12;
		public const int BK_SLIDER_CHANNEL_V         =13;
		public const int BK_PROGRESS_H_NORMAL        =14;
		public const int BK_PROGRESS_V_NORMAL        =15;
		public const int BK_PROGRESS_H_OVER          =16;
		public const int BK_PROGRESS_V_OVER          =17;

		public const int BK_IMAGE_ARROW            =1001;
		public const int BK_CUSTOM                =10000;

		public const int ARROW_UP_NORMAL           =   1;
		public const int ARROW_UP_DOWN              =  2;
		public const int ARROW_DOWN_NORMAL         =   3;
		public const int ARROW_DOWN_DOWN           =   4;
		

		public AppFace()
		{
			
		}
	}
}
