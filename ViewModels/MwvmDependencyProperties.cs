using ABCoder.Models.Code;
using ABCoder.Models.ComboBox;
using Microsoft.VisualBasic;
using System.Collections.ObjectModel;
using System.Data.Common;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Animation;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ABCoder.ViewModels
{
    internal partial class MainWindowViewModel
    {
        #region Button Action Content

        private string _ButtonActionContent = "Encode";
        /// <summary>Button Action Content</summary>
        public string ButtonActionContent
        {
            get => _ButtonActionContent;
            set => Set(ref _ButtonActionContent, value);
        }

        #endregion

        #region Button Information Information Bits Text Color

        private string _ButtonInformationInformationBitsTextColor = "Firebrick";
        /// <summary>Button Information Information Bits Text Color</summary>
        public string ButtonInformationInformationBitsTextColor
        {
            get => _ButtonInformationInformationBitsTextColor;
            set => Set(ref _ButtonInformationInformationBitsTextColor, value);
        }

        #endregion
        #region Button Information Information Bits Tool Tip Text

        private string _ButtonInformationInformationBitsToolTipText = "The \"Information Bits\" field is empty.";
        /// <summary>Button Information Information Bits Tool Tip Text</summary>
        public string ButtonInformationInformationBitsToolTipText
        {
            get => _ButtonInformationInformationBitsToolTipText;
            set => Set(ref _ButtonInformationInformationBitsToolTipText, value);
        }

        #endregion
        #region Button Information Information Bits Is Enable

        private bool _ButtonInformationInformationBitsIsEnable = true;
        /// <summary>Button Information Information Bits Is Enable</summary>
        public bool ButtonInformationInformationBitsIsEnable
        {
            get => _ButtonInformationInformationBitsIsEnable;
            set => Set(ref _ButtonInformationInformationBitsIsEnable, value);
        }

        #endregion

        #region Button Information Code Word Text Color

        private string _ButtonInformationCodeWordTextColor = "Red";
        /// <summary>Button Information Code Word Text Color</summary>
        public string ButtonInformationCodeWordTextColor
        {
            get => _ButtonInformationCodeWordTextColor;
            set => Set(ref _ButtonInformationCodeWordTextColor, value);
        }

        #endregion
        #region Button Information Code Word Tool Tip Text

        private string _ButtonInformationCodeWordToolTipText = "The \"Code Word\" field is empty.";
        /// <summary>Button Information Code Word Tool Tip Text</summary>
        public string ButtonInformationCodeWordToolTipText
        {
            get => _ButtonInformationCodeWordToolTipText;
            set => Set(ref _ButtonInformationCodeWordToolTipText, value);
        }

        #endregion
        #region Button Information Code Word Is Enable

        private bool _ButtonInformationCodeWordIsEnable = false;
        /// <summary>Button Information Code Word Is Enable</summary>
        public bool ButtonInformationCodeWordIsEnable
        {
            get => _ButtonInformationCodeWordIsEnable;
            set => Set(ref _ButtonInformationCodeWordIsEnable, value);
        }

        #endregion

        #region Button Open Information Bits Is Enable

        private bool _ButtonOpenInformationBitsIsEnable = true;
        /// <summary>Button Open Information Bits Is Enable</summary>
        public bool ButtonOpenInformationBitsIsEnable
        {
            get => _ButtonOpenInformationBitsIsEnable;
            set => Set(ref _ButtonOpenInformationBitsIsEnable, value);
        }

        #endregion

        #region GroupBox Panel Mode Header

        private string _GroupBoxPanelModeHeader = "Mode";
        /// <summary>GroupBox Panel Mode Header</summary>
        public string GroupBoxPanelModeHeader
        {
            get => _GroupBoxPanelModeHeader;
            set => Set(ref _GroupBoxPanelModeHeader, value);
        }

        #endregion
        #region GroupBox Panel Values Header

        private string _GroupBoxPanelValuesHeader = "Values";
        /// <summary>GroupBox Panel Values Header</summary>
        public string GroupBoxPanelValuesHeader
        {
            get => _GroupBoxPanelValuesHeader;
            set => Set(ref _GroupBoxPanelValuesHeader, value);
        }

        #endregion
        #region GroupBox Panel Options Header

        private string _GroupBoxPanelOptionsHeader = "Options";
        /// <summary>GroupBox Panel Options Header</summary>
        public string GroupBoxPanelOptionsHeader
        {
            get => _GroupBoxPanelOptionsHeader;
            set => Set(ref _GroupBoxPanelOptionsHeader, value);
        }

        #endregion

        #region Main Window Title

        private string _MainWindowTitle = "ABCoder";
        /// <summary>Main Window Title</summary>

        public string MainWindowTitle
        {
            get => _MainWindowTitle;
            set => Set(ref _MainWindowTitle, value);
        }

        #endregion

        #region Main Menu File Item

        private string _MainMenuFileItem = "File";
        /// <summary>Main Menu File Item</summary>

        public string MainMenuFileItem
        {
            get => _MainMenuFileItem;
            set => Set(ref _MainMenuFileItem, value);
        }

        #endregion
        #region Main Menu File Exit Item

        private string _MainMenuFileExitItem = "Exit";
        /// <summary>Main Menu File Exit Item</summary>

        public string MainMenuFileExitItem
        {
            get => _MainMenuFileExitItem;
            set => Set(ref _MainMenuFileExitItem, value);
        }

        #endregion
        #region Main Menu Help Item

        private string _MainMenuHelpItem = "Help";
        /// <summary>Main Menu Help Item</summary>

        public string MainMenuHelpItem
        {
            get => _MainMenuHelpItem;
            set => Set(ref _MainMenuHelpItem, value);
        }

        #endregion
        #region Main Menu Help About ABCoder Item

        private string _MainMenuHelpAboutABCoderItem = "About ABCoder";
        /// <summary>Main Menu Help About ABCoder Item</summary>

        public string MainMenuHelpAboutABCoderItem
        {
            get => _MainMenuHelpAboutABCoderItem;
            set => Set(ref _MainMenuHelpAboutABCoderItem, value);
        }

        #endregion

        #region Lable Value Information

        private string _LableValueInformation = "Information bits:";
        /// <summary>Lable Value Information</summary>
        public string LableValueInformation
        {
            get => _LableValueInformation;
            set => Set(ref _LableValueInformation, value);
        }

        #endregion
        #region Lable Value Code Combination

        private string _LableValueCodeCombination = "Code word:";
        /// <summary>Lable Value Code Combination</summary>
        public string LableValueCodeCombination
        {
            get => _LableValueCodeCombination;
            set => Set(ref _LableValueCodeCombination, value);
        }

        #endregion
        #region Lable Value Errors Bits

        private string _LableValueErrorsBits = "Error bits:";
        /// <summary>Lable Value Errors Bits</summary>
        public string LableValueErrorsBits
        {
            get => _LableValueErrorsBits;
            set => Set(ref _LableValueErrorsBits, value);
        }

        #endregion
        #region Lable Errors Bits Is Enable

        private bool _LableErrorsBitsIsEnable = false;
        /// <summary>Lable Value Errors Bits</summary>
        public bool LableErrorsBitsIsEnable
        {
            get => _LableErrorsBitsIsEnable;
            set => Set(ref _LableErrorsBitsIsEnable, value);
        }

        #endregion

        #region Lable Value Code Parameters

        private string _LableValueCodeParameters = "Code parameters:";
        /// <summary>Lable Value Code Parameters</summary>
        public string LableValueCodeParameters
        {
            get => _LableValueCodeParameters;
            set => Set(ref _LableValueCodeParameters, value);
        }

        #endregion

        #region Lable Code Instance Name

        private string _LableCodeInstanceName = "Code Type:";
        /// <summary>Lable Code Instance Name</summary>
        public string LableCodeInstanceName
        {
            get => _LableCodeInstanceName;
            set => Set(ref _LableCodeInstanceName, value);
        }

        #endregion
        #region Lable Code Instance Polynomial

        private string _LableCodeInstancePolynomial = "Polynomial:";
        /// <summary>Lable Code Instance Polynomial</summary>
        public string LableCodeInstancePolynomial
        {
            get => _LableCodeInstancePolynomial;
            set => Set(ref _LableCodeInstancePolynomial, value);
        }

        #endregion
        #region Lable Code Word Length

        private string _LableCodeWordLength = "Code Word Length:";
        /// <summary>Lable Code Word Length</summary>
        public string LableCodeWordLength
        {
            get => _LableCodeWordLength;
            set => Set(ref _LableCodeWordLength, value);
        }

        #endregion
        #region Lable Information Part Length

        private string _LableInformationPartLength = "Information Part Length:";
        /// <summary>Lable Information Part Length</summary>
        public string LableInformationPartLength
        {
            get => _LableInformationPartLength;
            set => Set(ref _LableInformationPartLength, value);
        }

        #endregion
        #region Lable Verification Part Length

        private string _LableVerificationPartLength = "Verification Part Length:";
        /// <summary>Lable Verification Part Length</summary>
        public string LableVerificationPartLength
        {
            get => _LableVerificationPartLength;
            set => Set(ref _LableVerificationPartLength, value);
        }

        #endregion
        #region Lable Error Detection Capability

        private string _LableDetectionCapability = "Error Detection Capability:";
        /// <summary>Lable Value Detection Capability</summary>
        public string LableDetectionCapability
        {
            get => _LableDetectionCapability;
            set => Set(ref _LableDetectionCapability, value);
        }

        #endregion
        #region Lable Error Correction Capability

        private string _LableErrorCorrectionCapability = "Error Correction Capability:";
        /// <summary>Lable Error Correction Capability</summary>
        public string LableErrorCorrectionCapability
        {
            get => _LableErrorCorrectionCapability;
            set => Set(ref _LableErrorCorrectionCapability, value);
        }

        #endregion

        #region Lable Value Code Instance Name

        private string _LableValueCodeInstanceName = "Goley (23, 12) C75";
        /// <summary>Lable Value Code Instance Name</summary>
        public string LableValueCodeInstanceName
        {
            get => _LableValueCodeInstanceName;
            set => Set(ref _LableValueCodeInstanceName, value);
        }

        #endregion
        #region Lable Value Code Instance Polynomial

        private string _LableValueCodeInstancePolynomial = "x\u00b9\u00b9+x\u00b9\u2070+x\u2076+x\u2075+x\u2074+x\u00B2+1";
        /// <summary>Lable Value Code Instance Polynomial</summary>
        public string LableValueCodeInstancePolynomial
        {
            get => _LableValueCodeInstancePolynomial;
            set => Set(ref _LableValueCodeInstancePolynomial, value);
        }

        #endregion
        #region Lable Value Code Word Length

        private int _LableValueCodeWordLength = 23;
        /// <summary>Lable Value Code Word Length</summary>
        public int LableValueCodeWordLength
        {
            get => _LableValueCodeWordLength;
            set => Set(ref _LableValueCodeWordLength, value);
        }

        #endregion
        #region Lable Value Information Part Length

        private int _LableValueInformationPartLength = 12;
        /// <summary>Lable Value Information Part Length</summary>
        public int LableValueInformationPartLength
        {
            get => _LableValueInformationPartLength;
            set => Set(ref _LableValueInformationPartLength, value);
        }

        #endregion
        #region Lable Value Verification Part Length

        private int _LableValueVerificationPartLength = 11;
        /// <summary>Lable Value Verification Part Length</summary>
        public int LableValueVerificationPartLength
        {
            get => _LableValueVerificationPartLength;
            set => Set(ref _LableValueVerificationPartLength, value);
        }

        #endregion
        #region Lable Value Error Detection Capability

        private int _LableValueErrorDetectionCapability = 7;
        /// <summary>Lable Value Error Detection Capability</summary>
        public int LableValueErrorDetectionCapability
        {
            get => _LableValueErrorDetectionCapability;
            set => Set(ref _LableValueErrorDetectionCapability, value);
        }

        #endregion
        #region Lable Value Error Correction Capability

        private int _LableValueErrorCorrectionCapability = 3;
        /// <summary>Lable Value Error Correction Capability</summary>
        public int LableValueErrorCorrectionCapability
        {
            get => _LableValueErrorCorrectionCapability;
            set => Set(ref _LableValueErrorCorrectionCapability, value);
        }

        #endregion

        #region Combo Box Mode Source

        private ObservableCollection<Mode> _ComboBoxModeSource;
        ///// <summary>Combo Box Mode Source</summary>
        public ObservableCollection<Mode> ComboBoxModeSource
        {
            get => _ComboBoxModeSource;
            set => Set(ref _ComboBoxModeSource, value);
        }

        #endregion
        #region Combo Box Mode Selected Index

        private int _ComboBoxModeSelectedIndex;
        ///// <summary>Combo Box Mode Selected Index</summary>
        public int ComboBoxModeSelectedIndex
        {
            get => _ComboBoxModeSelectedIndex;
            set => Set(ref _ComboBoxModeSelectedIndex, value);
        }

        #endregion

        #region Combo Box Mode Code Content

        private string _ComboBoxModeCodeContent = "Encode";
        /// <summary>Combo Box Mode Code Content</summary>
        public string ComboBoxModeCodeContent
        {
            get => _ComboBoxModeCodeContent;
            set => Set(ref _ComboBoxModeCodeContent, value);
        }

        #endregion
        #region Combo Box Mode Decode Content

        private string _ComboBoxModeDecodeContent = "Decode";
        /// <summary>Combo Box Mode Decode Content</summary>
        public string ComboBoxModeDecodeContent
        {
            get => _ComboBoxModeDecodeContent;
            set => Set(ref _ComboBoxModeDecodeContent, value);
        }

        #endregion

        #region Code Instance Goley (23, 12) C75

        private CodeInstance _CodeInstanceGoley2312C75;
        /// <summary>Code Instance Goley (23, 12) C75</summary>
        public CodeInstance CodeInstanceGoley2312C75
        {
            get => _CodeInstanceGoley2312C75;
            set => Set(ref _CodeInstanceGoley2312C75, value);
        }

        #endregion

        #region Combo Box Code Type Source

        private ObservableCollection<Mode> _ComboBoxCodeTypeSource;
        ///// <summary>Combo Box Code Type Source</summary>
        public ObservableCollection<Mode> ComboBoxCodeTypeSource
        {
            get => _ComboBoxCodeTypeSource;
            set => Set(ref _ComboBoxCodeTypeSource, value);
        }

        #endregion
        #region Combo Box Code Type Selected Index

        private int _ComboBoxCodeTypeSelectedIndex;
        ///// <summary>Combo Box Code Type Selected Index</summary>
        public int ComboBoxCodeTypeSelectedIndex
        {
            get => _ComboBoxCodeTypeSelectedIndex;
            set => Set(ref _ComboBoxCodeTypeSelectedIndex, value);
        }

        #endregion
        #region Combo Box Code Type Goley (23, 12) C75 Content

        private string _ComboBoxCodeTypeGoley2312C75Content = "Goley (23, 12) C75";
        /// <summary>Combo Box Code Type Goley (23, 12) C75 Content</summary>
        public string ComboBoxCodeTypeGoley2312C75Content
        {
            get => _ComboBoxCodeTypeGoley2312C75Content;
            set => Set(ref _ComboBoxCodeTypeGoley2312C75Content, value);
        }

        #endregion

        #region Text Box Information Bits Border Brush

        private string _TextBoxInformationBitsBorderBrush = "DeepSkyBlue";
        /// <summary>Text Box Information Bits Border Brush</summary>
        public string TextBoxInformationBitsBorderBrush
        {
            get => _TextBoxInformationBitsBorderBrush;
            set => Set(ref _TextBoxInformationBitsBorderBrush, value);
        }

        #endregion
        #region Text Box Information Bits Text

        private string _TextBoxInformationBitsText = string.Empty;
        /// <summary>Text Box Information Bits Text</summary>
        public string TextBoxInformationBitsText
        {
            get => _TextBoxInformationBitsText;
            set => Set(ref _TextBoxInformationBitsText, value);
        }

        #endregion
        #region Text Box Information Bits Is Enable

        private bool _TextBoxInformationBitsIsEnable = true;
        /// <summary>Text Box Information Bits Is Enable</summary>
        public bool TextBoxInformationBitsIsEnable
        {
            get => _TextBoxInformationBitsIsEnable;
            set => Set(ref _TextBoxInformationBitsIsEnable, value);
        }

        #endregion

        #region Text Box Code Combination Text

        private string _TextBoxCodeCombinationText = string.Empty;
        /// <summary>Text Box Code Combination Text</summary>
        public string TextBoxCodeCombinationText
        {
            get => _TextBoxCodeCombinationText;
            set => Set(ref _TextBoxCodeCombinationText, value);
        }

        #endregion
    }
}
