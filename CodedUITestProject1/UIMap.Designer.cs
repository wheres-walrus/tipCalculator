﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 14.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace CodedUITestProject1
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Text.RegularExpressions;
    using System.Windows.Input;
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using MouseButtons = System.Windows.Forms.MouseButtons;
    
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public partial class UIMap
    {
        
        /// <summary>
        /// edit the total bill and tip percentage
        /// </summary>
        public void RecordedMethod1()
        {
            #region Variable Declarations
            WinListItem uITipCalculatorShortcuListItem = this.UIProgramManagerWindow.UIDesktopList.UITipCalculatorShortcuListItem;
            WinControl uIOpenFileSecurityWarnDialog = this.UIOpenFileSecurityWarnWindow.UIOpenFileSecurityWarnDialog;
            WinButton uIOpenButton = this.UIOpenFileSecurityWarnWindow.UIOpenWindow.UIOpenButton;
            WinEdit uIBill_InputEdit = this.UITipCalculatorWindow.UIBill_InputWindow.UIBill_InputEdit;
            WinEdit uIPercentage_Input_BoxEdit = this.UITipCalculatorWindow.UIItem0Window.UIPercentage_Input_BoxEdit;
            #endregion

            // Double-Click 'TipCalculator - Shortcut' list item
            Mouse.DoubleClick(uITipCalculatorShortcuListItem, new Point(24, 38));

            // Click 'Open File - Security Warning' Dialog
            Mouse.Click(uIOpenFileSecurityWarnDialog, new Point(280, 166));

            // Click '&Open' button
            Mouse.Click(uIOpenButton, new Point(31, 19));

            // Type '20' in 'bill_Input' text box
            uIBill_InputEdit.Text = this.RecordedMethod1Params.UIBill_InputEditText;

            // Type '10' in 'percentage_Input_Box' text box
            uIPercentage_Input_BoxEdit.Text = this.RecordedMethod1Params.UIPercentage_Input_BoxEditText;

            // Double-Click 'TipCalculator - Shortcut' list item
            Mouse.DoubleClick(uITipCalculatorShortcuListItem, new Point(30, 26));

            // Click '&Open' button
            Mouse.Click(uIOpenButton, new Point(35, 8));

            // Type '45' in 'bill_Input' text box
            uIBill_InputEdit.Text = this.RecordedMethod1Params.UIBill_InputEditText1;

            // Type '10' in 'percentage_Input_Box' text box
            uIPercentage_Input_BoxEdit.Text = this.RecordedMethod1Params.UIPercentage_Input_BoxEditText1;
        }
        
        #region Properties
        public virtual RecordedMethod1Params RecordedMethod1Params
        {
            get
            {
                if ((this.mRecordedMethod1Params == null))
                {
                    this.mRecordedMethod1Params = new RecordedMethod1Params();
                }
                return this.mRecordedMethod1Params;
            }
        }
        
        public UIProgramManagerWindow UIProgramManagerWindow
        {
            get
            {
                if ((this.mUIProgramManagerWindow == null))
                {
                    this.mUIProgramManagerWindow = new UIProgramManagerWindow();
                }
                return this.mUIProgramManagerWindow;
            }
        }
        
        public UIOpenFileSecurityWarnWindow UIOpenFileSecurityWarnWindow
        {
            get
            {
                if ((this.mUIOpenFileSecurityWarnWindow == null))
                {
                    this.mUIOpenFileSecurityWarnWindow = new UIOpenFileSecurityWarnWindow();
                }
                return this.mUIOpenFileSecurityWarnWindow;
            }
        }
        
        public UITipCalculatorWindow UITipCalculatorWindow
        {
            get
            {
                if ((this.mUITipCalculatorWindow == null))
                {
                    this.mUITipCalculatorWindow = new UITipCalculatorWindow();
                }
                return this.mUITipCalculatorWindow;
            }
        }
        #endregion
        
        #region Fields
        private RecordedMethod1Params mRecordedMethod1Params;
        
        private UIProgramManagerWindow mUIProgramManagerWindow;
        
        private UIOpenFileSecurityWarnWindow mUIOpenFileSecurityWarnWindow;
        
        private UITipCalculatorWindow mUITipCalculatorWindow;
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'RecordedMethod1'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class RecordedMethod1Params
    {
        
        #region Fields
        /// <summary>
        /// Type '20' in 'bill_Input' text box
        /// </summary>
        public string UIBill_InputEditText = "20";
        
        /// <summary>
        /// Type '10' in 'percentage_Input_Box' text box
        /// </summary>
        public string UIPercentage_Input_BoxEditText = "10";
        
        /// <summary>
        /// Type '45' in 'bill_Input' text box
        /// </summary>
        public string UIBill_InputEditText1 = "45";
        
        /// <summary>
        /// Type '10' in 'percentage_Input_Box' text box
        /// </summary>
        public string UIPercentage_Input_BoxEditText1 = "10";
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIProgramManagerWindow : WinWindow
    {
        
        public UIProgramManagerWindow()
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.Name] = "Program Manager";
            this.SearchProperties[WinWindow.PropertyNames.ClassName] = "Progman";
            this.WindowTitles.Add("Program Manager");
            #endregion
        }
        
        #region Properties
        public UIDesktopList UIDesktopList
        {
            get
            {
                if ((this.mUIDesktopList == null))
                {
                    this.mUIDesktopList = new UIDesktopList(this);
                }
                return this.mUIDesktopList;
            }
        }
        #endregion
        
        #region Fields
        private UIDesktopList mUIDesktopList;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIDesktopList : WinList
    {
        
        public UIDesktopList(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinList.PropertyNames.Name] = "Desktop";
            this.WindowTitles.Add("Program Manager");
            #endregion
        }
        
        #region Properties
        public WinListItem UITipCalculatorShortcuListItem
        {
            get
            {
                if ((this.mUITipCalculatorShortcuListItem == null))
                {
                    this.mUITipCalculatorShortcuListItem = new WinListItem(this);
                    #region Search Criteria
                    this.mUITipCalculatorShortcuListItem.SearchProperties[WinListItem.PropertyNames.Name] = "TipCalculator - Shortcut";
                    this.mUITipCalculatorShortcuListItem.WindowTitles.Add("Program Manager");
                    #endregion
                }
                return this.mUITipCalculatorShortcuListItem;
            }
        }
        #endregion
        
        #region Fields
        private WinListItem mUITipCalculatorShortcuListItem;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIOpenFileSecurityWarnWindow : WinWindow
    {
        
        public UIOpenFileSecurityWarnWindow()
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.Name] = "Open File - Security Warning";
            this.SearchProperties[WinWindow.PropertyNames.ClassName] = "#32770";
            this.WindowTitles.Add("Open File - Security Warning");
            #endregion
        }
        
        #region Properties
        public WinControl UIOpenFileSecurityWarnDialog
        {
            get
            {
                if ((this.mUIOpenFileSecurityWarnDialog == null))
                {
                    this.mUIOpenFileSecurityWarnDialog = new WinControl(this);
                    #region Search Criteria
                    this.mUIOpenFileSecurityWarnDialog.SearchProperties[UITestControl.PropertyNames.Name] = "Open File - Security Warning";
                    this.mUIOpenFileSecurityWarnDialog.SearchProperties[UITestControl.PropertyNames.ControlType] = "Dialog";
                    this.mUIOpenFileSecurityWarnDialog.WindowTitles.Add("Open File - Security Warning");
                    #endregion
                }
                return this.mUIOpenFileSecurityWarnDialog;
            }
        }
        
        public UIOpenWindow UIOpenWindow
        {
            get
            {
                if ((this.mUIOpenWindow == null))
                {
                    this.mUIOpenWindow = new UIOpenWindow(this);
                }
                return this.mUIOpenWindow;
            }
        }
        #endregion
        
        #region Fields
        private WinControl mUIOpenFileSecurityWarnDialog;
        
        private UIOpenWindow mUIOpenWindow;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIOpenWindow : WinWindow
    {
        
        public UIOpenWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlId] = "4426";
            this.WindowTitles.Add("Open File - Security Warning");
            #endregion
        }
        
        #region Properties
        public WinButton UIOpenButton
        {
            get
            {
                if ((this.mUIOpenButton == null))
                {
                    this.mUIOpenButton = new WinButton(this);
                    #region Search Criteria
                    this.mUIOpenButton.SearchProperties[WinButton.PropertyNames.Name] = "Open";
                    this.mUIOpenButton.WindowTitles.Add("Open File - Security Warning");
                    #endregion
                }
                return this.mUIOpenButton;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mUIOpenButton;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UITipCalculatorWindow : WinWindow
    {
        
        public UITipCalculatorWindow()
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.Name] = "Tip Calculator";
            this.SearchProperties.Add(new PropertyExpression(WinWindow.PropertyNames.ClassName, "WindowsForms10.Window", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("Tip Calculator");
            #endregion
        }
        
        #region Properties
        public UIBill_InputWindow UIBill_InputWindow
        {
            get
            {
                if ((this.mUIBill_InputWindow == null))
                {
                    this.mUIBill_InputWindow = new UIBill_InputWindow(this);
                }
                return this.mUIBill_InputWindow;
            }
        }
        
        public UIItem0Window UIItem0Window
        {
            get
            {
                if ((this.mUIItem0Window == null))
                {
                    this.mUIItem0Window = new UIItem0Window(this);
                }
                return this.mUIItem0Window;
            }
        }
        #endregion
        
        #region Fields
        private UIBill_InputWindow mUIBill_InputWindow;
        
        private UIItem0Window mUIItem0Window;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIBill_InputWindow : WinWindow
    {
        
        public UIBill_InputWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlName] = "bill_Input";
            this.WindowTitles.Add("Tip Calculator");
            #endregion
        }
        
        #region Properties
        public WinEdit UIBill_InputEdit
        {
            get
            {
                if ((this.mUIBill_InputEdit == null))
                {
                    this.mUIBill_InputEdit = new WinEdit(this);
                    #region Search Criteria
                    this.mUIBill_InputEdit.WindowTitles.Add("Tip Calculator");
                    #endregion
                }
                return this.mUIBill_InputEdit;
            }
        }
        #endregion
        
        #region Fields
        private WinEdit mUIBill_InputEdit;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIItem0Window : WinWindow
    {
        
        public UIItem0Window(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlName] = "percentage_Input_Box";
            this.WindowTitles.Add("Tip Calculator");
            #endregion
        }
        
        #region Properties
        public WinEdit UIPercentage_Input_BoxEdit
        {
            get
            {
                if ((this.mUIPercentage_Input_BoxEdit == null))
                {
                    this.mUIPercentage_Input_BoxEdit = new WinEdit(this);
                    #region Search Criteria
                    this.mUIPercentage_Input_BoxEdit.WindowTitles.Add("Tip Calculator");
                    #endregion
                }
                return this.mUIPercentage_Input_BoxEdit;
            }
        }
        #endregion
        
        #region Fields
        private WinEdit mUIPercentage_Input_BoxEdit;
        #endregion
    }
}
