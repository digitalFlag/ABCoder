using ABCoder.Models.Code;
using ABCoder.Models.ComboBox;
using System.Collections.ObjectModel;

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

        #region Button Open Information Bits Is Enable

        private bool _ButtonOpenInformationBitsIsEnable = true;
        /// <summary>Button Open Information Bits Is Enable</summary>
        public bool ButtonOpenInformationBitsIsEnable
        {
            get => _ButtonOpenInformationBitsIsEnable;
            set => Set(ref _ButtonOpenInformationBitsIsEnable, value);
        }

        #endregion

        #region Button Clone Information Bits Is Enable

        private bool _ButtonCloneInformationBitsIsEnable = true;
        /// <summary>Button Clone Information Bits Is Enable</summary>
        public bool ButtonCloneInformationBitsIsEnable
        {
            get => _ButtonCloneInformationBitsIsEnable;
            set => Set(ref _ButtonCloneInformationBitsIsEnable, value);
        }

        #endregion

        #region Button Clear Information Bits Is Enable

        private bool _ButtonClearInformationBitsIsEnable = true;
        /// <summary>Button Clear Information Bits Is Enable</summary>
        public bool ButtonClearInformationBitsIsEnable
        {
            get => _ButtonClearInformationBitsIsEnable;
            set => Set(ref _ButtonClearInformationBitsIsEnable, value);
        }

        #endregion

        #region Button Information Code Combination Text Color

        private string _ButtonInformationCodeCombinationTextColor = "DarkBlue";
        /// <summary>Button Information Code Combination Text Color</summary>
        public string ButtonInformationCodeCombinationTextColor
        {
            get => _ButtonInformationCodeCombinationTextColor;
            set => Set(ref _ButtonInformationCodeCombinationTextColor, value);
        }

        #endregion
        #region Button Information Code Combination Tool Tip Text

        private string _ButtonInformationCodeCombinationToolTipText = "The \"Code Combination\" field is empty.";
        /// <summary>Button Information Code Combination Tool Tip Text</summary>
        public string ButtonInformationCodeCombinationToolTipText
        {
            get => _ButtonInformationCodeCombinationToolTipText;
            set => Set(ref _ButtonInformationCodeCombinationToolTipText, value);
        }

        #endregion
        #region Button Information Code Combination Is Enable

        private bool _ButtonInformationCodeCombinationIsEnable = false;
        /// <summary>Button Information Code Combination Is Enable</summary>
        public bool ButtonInformationCodeCombinationIsEnable
        {
            get => _ButtonInformationCodeCombinationIsEnable;
            set => Set(ref _ButtonInformationCodeCombinationIsEnable, value);
        }

        #endregion

        #region Button Open Code COmbination Is Enable

        private bool _ButtonOpenCodeCOmbinationIsEnable = false;
        /// <summary>Button Open Code COmbination Is Enable</summary>
        public bool ButtonOpenCodeCOmbinationIsEnable
        {
            get => _ButtonOpenCodeCOmbinationIsEnable;
            set => Set(ref _ButtonOpenCodeCOmbinationIsEnable, value);
        }

        #endregion

        #region Button Clone Code Combination Is Enable

        private bool _ButtonCloneCodeCombinationIsEnable = true;
        /// <summary>Button Clone Code Combination Is Enable</summary>
        public bool ButtonCloneCodeCombinationIsEnable
        {
            get => _ButtonCloneCodeCombinationIsEnable;
            set => Set(ref _ButtonCloneCodeCombinationIsEnable, value);
        }

        #endregion

        #region Button Clear Code Combination Is Enable

        private bool _ButtonClearCodeCombinationIsEnable = true;
        /// <summary>Button Clear Code Combination Is Enable</summary>
        public bool ButtonClearCodeCombinationIsEnable
        {
            get => _ButtonClearCodeCombinationIsEnable;
            set => Set(ref _ButtonClearCodeCombinationIsEnable, value);
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

        private string _MainWindowTitle = "ABCoder 1.0.0";
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
        #region Main Menu Help Feedback Item

        private string _MainMenuHelpFeedbackItem = "Feedback";
        /// <summary>Main Menu Help Feedback Item</summary>

        public string MainMenuHelpFeedbackItem
        {
            get => _MainMenuHelpFeedbackItem;
            set => Set(ref _MainMenuHelpFeedbackItem, value);
        }

        #endregion

        #region Main Menu Help Feedback Text

        private string _MainMenuHelpFeedbackText =
            "Send your feedback about the program, as well as suggestions for its improvement by email gelpostbox@gmail.com";
        /// <summary>Main Menu Help Feedback Text</summary>

        public string MainMenuHelpFeedbackText
        {
            get => _MainMenuHelpFeedbackText;
            set => Set(ref _MainMenuHelpFeedbackText, value);
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

        #region Text Block Letter0 Text

        private string _TextBlockLetter0Text = string.Empty;
        /// <summary>Text Block Letter0 Text</summary>
        public string TextBlockLetter0Text
        {
            get => _TextBlockLetter0Text;
            set => Set(ref _TextBlockLetter0Text, value);
        }

        #endregion
        #region Text Block Letter0 Foreground

        private string _TextBlockLetter0Foreground = "Green";
        /// <summary>Text Block Letter0 Foreground</summary>
        public string TextBlockLetter0Foreground
        {
            get => _TextBlockLetter0Foreground;
            set => Set(ref _TextBlockLetter0Foreground, value);
        }

        #endregion
        #region Text Block Letter0 Font Style

        private string _TextBlockLetter0FontStyle = "Regular";
        /// <summary>Text Block Letter0 Font Style</summary>
        public string TextBlockLetter0FontStyle
        {
            get => _TextBlockLetter0FontStyle;
            set => Set(ref _TextBlockLetter0FontStyle, value);
        }

        #endregion
        #region Text Block Letter1 Text

        private string _TextBlockLetter1Text = string.Empty;
        /// <summary>Text Block Letter1 Text</summary>
        public string TextBlockLetter1Text
        {
            get => _TextBlockLetter1Text;
            set => Set(ref _TextBlockLetter1Text, value);
        }

        #endregion
        #region Text Block Letter1 Foreground

        private string _TextBlockLetter1Foreground = "Green";
        /// <summary>Text Block Letter1 Foreground</summary>
        public string TextBlockLetter1Foreground
        {
            get => _TextBlockLetter1Foreground;
            set => Set(ref _TextBlockLetter1Foreground, value);
        }

        #endregion
        #region Text Block Letter1 Font Style

        private string _TextBlockLetter1FontStyle = "Regular";
        /// <summary>Text Block Letter1 Font Style</summary>
        public string TextBlockLetter1FontStyle
        {
            get => _TextBlockLetter1FontStyle;
            set => Set(ref _TextBlockLetter1FontStyle, value);
        }

        #endregion
        #region Text Block Letter2 Text

        private string _TextBlockLetter2Text = string.Empty;
        /// <summary>Text Block Letter2 Text</summary>
        public string TextBlockLetter2Text
        {
            get => _TextBlockLetter2Text;
            set => Set(ref _TextBlockLetter2Text, value);
        }

        #endregion
        #region Text Block Letter2 Foreground

        private string _TextBlockLetter2Foreground = "Green";
        /// <summary>Text Block Letter2 Foreground</summary>
        public string TextBlockLetter2Foreground
        {
            get => _TextBlockLetter2Foreground;
            set => Set(ref _TextBlockLetter2Foreground, value);
        }

        #endregion
        #region Text Block Letter2 Font Style

        private string _TextBlockLetter2FontStyle = "Regular";
        /// <summary>Text Block Letter2 Font Style</summary>
        public string TextBlockLetter2FontStyle
        {
            get => _TextBlockLetter2FontStyle;
            set => Set(ref _TextBlockLetter2FontStyle, value);
        }

        #endregion
        #region Text Block Letter3 Text

        private string _TextBlockLetter3Text = string.Empty;
        /// <summary>Text Block Letter3 Text</summary>
        public string TextBlockLetter3Text
        {
            get => _TextBlockLetter3Text;
            set => Set(ref _TextBlockLetter3Text, value);
        }

        #endregion
        #region Text Block Letter3 Foreground

        private string _TextBlockLetter3Foreground = "Green";
        /// <summary>Text Block Letter3 Foreground</summary>
        public string TextBlockLetter3Foreground
        {
            get => _TextBlockLetter3Foreground;
            set => Set(ref _TextBlockLetter3Foreground, value);
        }

        #endregion
        #region Text Block Letter3 Font Style

        private string _TextBlockLetter3FontStyle = "Regular";
        /// <summary>Text Block Letter3 Font Style</summary>
        public string TextBlockLetter3FontStyle
        {
            get => _TextBlockLetter3FontStyle;
            set => Set(ref _TextBlockLetter3FontStyle, value);
        }

        #endregion
        #region Text Block Letter4 Text

        private string _TextBlockLetter4Text = string.Empty;
        /// <summary>Text Block Letter4 Text</summary>
        public string TextBlockLetter4Text
        {
            get => _TextBlockLetter4Text;
            set => Set(ref _TextBlockLetter4Text, value);
        }

        #endregion
        #region Text Block Letter4 Foreground

        private string _TextBlockLetter4Foreground = "Green";
        /// <summary>Text Block Letter4 Foreground</summary>
        public string TextBlockLetter4Foreground
        {
            get => _TextBlockLetter4Foreground;
            set => Set(ref _TextBlockLetter4Foreground, value);
        }

        #endregion
        #region Text Block Letter4 Font Style

        private string _TextBlockLetter4FontStyle = "Regular";
        /// <summary>Text Block Letter4 Font Style</summary>
        public string TextBlockLetter4FontStyle
        {
            get => _TextBlockLetter4FontStyle;
            set => Set(ref _TextBlockLetter4FontStyle, value);
        }

        #endregion
        #region Text Block Letter5 Text

        private string _TextBlockLetter5Text = string.Empty;
        /// <summary>Text Block Letter3 Text</summary>
        public string TextBlockLetter5Text
        {
            get => _TextBlockLetter5Text;
            set => Set(ref _TextBlockLetter5Text, value);
        }

        #endregion
        #region Text Block Letter5 Foreground

        private string _TextBlockLetter5Foreground = "Green";
        /// <summary>Text Block Letter5 Foreground</summary>
        public string TextBlockLetter5Foreground
        {
            get => _TextBlockLetter5Foreground;
            set => Set(ref _TextBlockLetter5Foreground, value);
        }

        #endregion
        #region Text Block Letter5 Font Style

        private string _TextBlockLetter5FontStyle = "Regular";
        /// <summary>Text Block Letter5 Font Style</summary>
        public string TextBlockLetter5FontStyle
        {
            get => _TextBlockLetter5FontStyle;
            set => Set(ref _TextBlockLetter5FontStyle, value);
        }

        #endregion
        #region Text Block Letter6 Text

        private string _TextBlockLetter6Text = string.Empty;
        /// <summary>Text Block Letter6 Text</summary>
        public string TextBlockLetter6Text
        {
            get => _TextBlockLetter6Text;
            set => Set(ref _TextBlockLetter6Text, value);
        }

        #endregion
        #region Text Block Letter6 Foreground

        private string _TextBlockLetter6Foreground = "Green";
        /// <summary>Text Block Letter6 Foreground</summary>
        public string TextBlockLetter6Foreground
        {
            get => _TextBlockLetter6Foreground;
            set => Set(ref _TextBlockLetter6Foreground, value);
        }

        #endregion
        #region Text Block Letter6 Font Style

        private string _TextBlockLetter6FontStyle = "Regular";
        /// <summary>Text Block Letter3 Font Style</summary>
        public string TextBlockLetter6FontStyle
        {
            get => _TextBlockLetter6FontStyle;
            set => Set(ref _TextBlockLetter6FontStyle, value);
        }

        #endregion
        #region Text Block Letter7 Text

        private string _TextBlockLetter7Text = string.Empty;
        /// <summary>Text Block Letter7 Text</summary>
        public string TextBlockLetter7Text
        {
            get => _TextBlockLetter7Text;
            set => Set(ref _TextBlockLetter7Text, value);
        }

        #endregion
        #region Text Block Letter7 Foreground

        private string _TextBlockLetter7Foreground = "Green";
        /// <summary>Text Block Letter7 Foreground</summary>
        public string TextBlockLetter7Foreground
        {
            get => _TextBlockLetter7Foreground;
            set => Set(ref _TextBlockLetter7Foreground, value);
        }

        #endregion
        #region Text Block Letter7 Font Style

        private string _TextBlockLetter7FontStyle = "Regular";
        /// <summary>Text Block Letter7 Font Style</summary>
        public string TextBlockLetter7FontStyle
        {
            get => _TextBlockLetter7FontStyle;
            set => Set(ref _TextBlockLetter7FontStyle, value);
        }

        #endregion
        #region Text Block Letter8 Text

        private string _TextBlockLetter8Text = string.Empty;
        /// <summary>Text Block Letter8 Text</summary>
        public string TextBlockLetter8Text
        {
            get => _TextBlockLetter8Text;
            set => Set(ref _TextBlockLetter8Text, value);
        }

        #endregion
        #region Text Block Letter8 Foreground

        private string _TextBlockLetter8Foreground = "Green";
        /// <summary>Text Block Letter8 Foreground</summary>
        public string TextBlockLetter8Foreground
        {
            get => _TextBlockLetter8Foreground;
            set => Set(ref _TextBlockLetter8Foreground, value);
        }

        #endregion
        #region Text Block Letter8 Font Style

        private string _TextBlockLetter8FontStyle = "Regular";
        /// <summary>Text Block Letter8 Font Style</summary>
        public string TextBlockLetter8FontStyle
        {
            get => _TextBlockLetter8FontStyle;
            set => Set(ref _TextBlockLetter8FontStyle, value);
        }

        #endregion
        #region Text Block Letter9 Text

        private string _TextBlockLetter9Text = string.Empty;
        /// <summary>Text Block Letter9 Text</summary>
        public string TextBlockLetter9Text
        {
            get => _TextBlockLetter9Text;
            set => Set(ref _TextBlockLetter9Text, value);
        }

        #endregion
        #region Text Block Letter9 Foreground

        private string _TextBlockLetter9Foreground = "Green";
        /// <summary>Text Block Letter9 Foreground</summary>
        public string TextBlockLetter9Foreground
        {
            get => _TextBlockLetter9Foreground;
            set => Set(ref _TextBlockLetter9Foreground, value);
        }

        #endregion
        #region Text Block Letter9 Font Style

        private string _TextBlockLetter9FontStyle = "Regular";
        /// <summary>Text Block Letter9 Font Style</summary>
        public string TextBlockLetter9FontStyle
        {
            get => _TextBlockLetter9FontStyle;
            set => Set(ref _TextBlockLetter9FontStyle, value);
        }

        #endregion
        #region Text Block Letter10 Text

        private string _TextBlockLetter10Text = string.Empty;
        /// <summary>Text Block Letter10 Text</summary>
        public string TextBlockLetter10Text
        {
            get => _TextBlockLetter10Text;
            set => Set(ref _TextBlockLetter10Text, value);
        }

        #endregion
        #region Text Block Letter10 Foreground

        private string _TextBlockLetter10Foreground = "Green";
        /// <summary>Text Block Letter10 Foreground</summary>
        public string TextBlockLetter10Foreground
        {
            get => _TextBlockLetter10Foreground;
            set => Set(ref _TextBlockLetter10Foreground, value);
        }

        #endregion
        #region Text Block Letter10 Font Style

        private string _TextBlockLetter10FontStyle = "Regular";
        /// <summary>Text Block Letter10 Font Style</summary>
        public string TextBlockLetter10FontStyle
        {
            get => _TextBlockLetter10FontStyle;
            set => Set(ref _TextBlockLetter10FontStyle, value);
        }

        #endregion
        #region Text Block Letter11 Text

        private string _TextBlockLetter11Text = string.Empty;
        /// <summary>Text Block Letter11 Text</summary>
        public string TextBlockLetter11Text
        {
            get => _TextBlockLetter11Text;
            set => Set(ref _TextBlockLetter11Text, value);
        }

        #endregion
        #region Text Block Letter11 Foreground

        private string _TextBlockLetter11Foreground = "Green";
        /// <summary>Text Block Letter11 Foreground</summary>
        public string TextBlockLetter11Foreground
        {
            get => _TextBlockLetter11Foreground;
            set => Set(ref _TextBlockLetter11Foreground, value);
        }

        #endregion
        #region Text Block Letter11 Font Style

        private string _TextBlockLetter11FontStyle = "Regular";
        /// <summary>Text Block Letter11 Font Style</summary>
        public string TextBlockLetter11FontStyle
        {
            get => _TextBlockLetter11FontStyle;
            set => Set(ref _TextBlockLetter11FontStyle, value);
        }

        #endregion
        #region Text Block Letter12 Text

        private string _TextBlockLetter12Text = string.Empty;
        /// <summary>Text Block Letter12 Text</summary>
        public string TextBlockLetter12Text
        {
            get => _TextBlockLetter12Text;
            set => Set(ref _TextBlockLetter12Text, value);
        }

        #endregion
        #region Text Block Letter12 Foreground

        private string _TextBlockLetter12Foreground = "Green";
        /// <summary>Text Block Letter12 Foreground</summary>
        public string TextBlockLetter12Foreground
        {
            get => _TextBlockLetter12Foreground;
            set => Set(ref _TextBlockLetter12Foreground, value);
        }

        #endregion
        #region Text Block Letter12 Font Style

        private string _TextBlockLetter12FontStyle = "Regular";
        /// <summary>Text Block Letter12 Font Style</summary>
        public string TextBlockLetter12FontStyle
        {
            get => _TextBlockLetter12FontStyle;
            set => Set(ref _TextBlockLetter12FontStyle, value);
        }

        #endregion
        #region Text Block Letter13 Text

        private string _TextBlockLetter13Text = string.Empty;
        /// <summary>Text Block Letter13 Text</summary>
        public string TextBlockLetter13Text
        {
            get => _TextBlockLetter13Text;
            set => Set(ref _TextBlockLetter13Text, value);
        }

        #endregion
        #region Text Block Letter13 Foreground

        private string _TextBlockLetter13Foreground = "Green";
        /// <summary>Text Block Letter13 Foreground</summary>
        public string TextBlockLetter13Foreground
        {
            get => _TextBlockLetter13Foreground;
            set => Set(ref _TextBlockLetter13Foreground, value);
        }

        #endregion
        #region Text Block Letter13 Font Style

        private string _TextBlockLetter13FontStyle = "Regular";
        /// <summary>Text Block Letter13 Font Style</summary>
        public string TextBlockLetter13FontStyle
        {
            get => _TextBlockLetter13FontStyle;
            set => Set(ref _TextBlockLetter13FontStyle, value);
        }

        #endregion
        #region Text Block Letter14 Text

        private string _TextBlockLetter14Text = string.Empty;
        /// <summary>Text Block Letter14 Text</summary>
        public string TextBlockLetter14Text
        {
            get => _TextBlockLetter14Text;
            set => Set(ref _TextBlockLetter14Text, value);
        }

        #endregion
        #region Text Block Letter14 Foreground

        private string _TextBlockLetter14Foreground = "Green";
        /// <summary>Text Block Letter14 Foreground</summary>
        public string TextBlockLetter14Foreground
        {
            get => _TextBlockLetter14Foreground;
            set => Set(ref _TextBlockLetter14Foreground, value);
        }

        #endregion
        #region Text Block Letter14 Font Style

        private string _TextBlockLetter14FontStyle = "Regular";
        /// <summary>Text Block Letter14 Font Style</summary>
        public string TextBlockLetter14FontStyle
        {
            get => _TextBlockLetter14FontStyle;
            set => Set(ref _TextBlockLetter14FontStyle, value);
        }

        #endregion
        #region Text Block Letter15 Text

        private string _TextBlockLetter15Text = string.Empty;
        /// <summary>Text Block Letter15 Text</summary>
        public string TextBlockLetter15Text
        {
            get => _TextBlockLetter15Text;
            set => Set(ref _TextBlockLetter15Text, value);
        }

        #endregion
        #region Text Block Letter15 Foreground

        private string _TextBlockLetter15Foreground = "Green";
        /// <summary>Text Block Letter15 Foreground</summary>
        public string TextBlockLetter15Foreground
        {
            get => _TextBlockLetter15Foreground;
            set => Set(ref _TextBlockLetter15Foreground, value);
        }

        #endregion
        #region Text Block Letter15 Font Style

        private string _TextBlockLetter15FontStyle = "Regular";
        /// <summary>Text Block Letter15 Font Style</summary>
        public string TextBlockLetter15FontStyle
        {
            get => _TextBlockLetter15FontStyle;
            set => Set(ref _TextBlockLetter15FontStyle, value);
        }

        #endregion
        #region Text Block Letter16 Text

        private string _TextBlockLetter16Text = string.Empty;
        /// <summary>Text Block Letter16 Text</summary>
        public string TextBlockLetter16Text
        {
            get => _TextBlockLetter16Text;
            set => Set(ref _TextBlockLetter16Text, value);
        }

        #endregion
        #region Text Block Letter16 Foreground

        private string _TextBlockLetter16Foreground = "Green";
        /// <summary>Text Block Letter16 Foreground</summary>
        public string TextBlockLetter16Foreground
        {
            get => _TextBlockLetter16Foreground;
            set => Set(ref _TextBlockLetter16Foreground, value);
        }

        #endregion
        #region Text Block Letter16 Font Style

        private string _TextBlockLetter16FontStyle = "Regular";
        /// <summary>Text Block Letter16 Font Style</summary>
        public string TextBlockLetter16FontStyle
        {
            get => _TextBlockLetter16FontStyle;
            set => Set(ref _TextBlockLetter16FontStyle, value);
        }

        #endregion
        #region Text Block Letter17 Text

        private string _TextBlockLetter17Text = string.Empty;
        /// <summary>Text Block Letter17 Text</summary>
        public string TextBlockLetter17Text
        {
            get => _TextBlockLetter17Text;
            set => Set(ref _TextBlockLetter17Text, value);
        }

        #endregion
        #region Text Block Letter17 Foreground

        private string _TextBlockLetter17Foreground = "Green";
        /// <summary>Text Block Letter17 Foreground</summary>
        public string TextBlockLetter17Foreground
        {
            get => _TextBlockLetter17Foreground;
            set => Set(ref _TextBlockLetter17Foreground, value);
        }

        #endregion
        #region Text Block Letter17 Font Style

        private string _TextBlockLetter17FontStyle = "Regular";
        /// <summary>Text Block Letter17 Font Style</summary>
        public string TextBlockLetter17FontStyle
        {
            get => _TextBlockLetter17FontStyle;
            set => Set(ref _TextBlockLetter17FontStyle, value);
        }

        #endregion
        #region Text Block Letter18 Text

        private string _TextBlockLetter18Text = string.Empty;
        /// <summary>Text Block Letter18 Text</summary>
        public string TextBlockLetter18Text
        {
            get => _TextBlockLetter18Text;
            set => Set(ref _TextBlockLetter18Text, value);
        }

        #endregion
        #region Text Block Letter18 Foreground

        private string _TextBlockLetter18Foreground = "Green";
        /// <summary>Text Block Letter18 Foreground</summary>
        public string TextBlockLetter18Foreground
        {
            get => _TextBlockLetter18Foreground;
            set => Set(ref _TextBlockLetter18Foreground, value);
        }

        #endregion
        #region Text Block Letter18 Font Style

        private string _TextBlockLetter18FontStyle = "Regular";
        /// <summary>Text Block Letter18 Font Style</summary>
        public string TextBlockLetter18FontStyle
        {
            get => _TextBlockLetter18FontStyle;
            set => Set(ref _TextBlockLetter18FontStyle, value);
        }

        #endregion
        #region Text Block Letter19 Text

        private string _TextBlockLetter19Text = string.Empty;
        /// <summary>Text Block Letter19 Text</summary>
        public string TextBlockLetter19Text
        {
            get => _TextBlockLetter19Text;
            set => Set(ref _TextBlockLetter19Text, value);
        }

        #endregion
        #region Text Block Letter19 Foreground

        private string _TextBlockLetter19Foreground = "Green";
        /// <summary>Text Block Letter19 Foreground</summary>
        public string TextBlockLetter19Foreground
        {
            get => _TextBlockLetter19Foreground;
            set => Set(ref _TextBlockLetter19Foreground, value);
        }

        #endregion
        #region Text Block Letter19 Font Style

        private string _TextBlockLetter19FontStyle = "Regular";
        /// <summary>Text Block Letter19 Font Style</summary>
        public string TextBlockLetter19FontStyle
        {
            get => _TextBlockLetter19FontStyle;
            set => Set(ref _TextBlockLetter19FontStyle, value);
        }

        #endregion
        #region Text Block Letter20 Text

        private string _TextBlockLetter20Text = string.Empty;
        /// <summary>Text Block Letter20 Text</summary>
        public string TextBlockLetter20Text
        {
            get => _TextBlockLetter20Text;
            set => Set(ref _TextBlockLetter20Text, value);
        }

        #endregion
        #region Text Block Letter20 Foreground

        private string _TextBlockLetter20Foreground = "Green";
        /// <summary>Text Block Letter20 Foreground</summary>
        public string TextBlockLetter20Foreground
        {
            get => _TextBlockLetter20Foreground;
            set => Set(ref _TextBlockLetter20Foreground, value);
        }

        #endregion
        #region Text Block Letter20 Font Style

        private string _TextBlockLetter20FontStyle = "Regular";
        /// <summary>Text Block Letter20 Font Style</summary>
        public string TextBlockLetter20FontStyle
        {
            get => _TextBlockLetter20FontStyle;
            set => Set(ref _TextBlockLetter20FontStyle, value);
        }

        #endregion
        #region Text Block Letter21 Text

        private string _TextBlockLetter21Text = string.Empty;
        /// <summary>Text Block Letter21 Text</summary>
        public string TextBlockLetter21Text
        {
            get => _TextBlockLetter21Text;
            set => Set(ref _TextBlockLetter21Text, value);
        }

        #endregion
        #region Text Block Letter21 Foreground

        private string _TextBlockLetter21Foreground = "Green";
        /// <summary>Text Block Letter21 Foreground</summary>
        public string TextBlockLetter21Foreground
        {
            get => _TextBlockLetter21Foreground;
            set => Set(ref _TextBlockLetter21Foreground, value);
        }

        #endregion
        #region Text Block Letter21 Font Style

        private string _TextBlockLetter21FontStyle = "Regular";
        /// <summary>Text Block Letter21 Font Style</summary>
        public string TextBlockLetter21FontStyle
        {
            get => _TextBlockLetter21FontStyle;
            set => Set(ref _TextBlockLetter21FontStyle, value);
        }

        #endregion
        #region Text Block Letter22 Text

        private string _TextBlockLetter22Text = string.Empty;
        /// <summary>Text Block Letter22 Text</summary>
        public string TextBlockLetter22Text
        {
            get => _TextBlockLetter22Text;
            set => Set(ref _TextBlockLetter22Text, value);
        }

        #endregion
        #region Text Block Letter22 Foreground

        private string _TextBlockLetter22Foreground = "Green";
        /// <summary>Text Block Letter22 Foreground</summary>
        public string TextBlockLetter22Foreground
        {
            get => _TextBlockLetter22Foreground;
            set => Set(ref _TextBlockLetter22Foreground, value);
        }

        #endregion
        #region Text Block Letter22 Font Style

        private string _TextBlockLetter22FontStyle = "Regular";
        /// <summary>Text Block Letter22 Font Style</summary>
        public string TextBlockLetter22FontStyle
        {
            get => _TextBlockLetter22FontStyle;
            set => Set(ref _TextBlockLetter22FontStyle, value);
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

        #region Text Box Code Combination Border Brush

        private string _TextBoxCodeCombinationBorderBrush = "DeepSkyBlue";
        /// <summary>Text Box Code Combination Border Brush</summary>
        public string TextBoxCodeCombinationBorderBrush
        {
            get => _TextBoxCodeCombinationBorderBrush;
            set => Set(ref _TextBoxCodeCombinationBorderBrush, value);
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
        #region Text Box Code Combination Is Enable

        private bool _TextBoxCodeCombinationIsEnable = false;
        /// <summary>Text Box Code Combination Is Enable</summary>
        public bool TextBoxCodeCombinationIsEnable
        {
            get => _TextBoxCodeCombinationIsEnable;
            set => Set(ref _TextBoxCodeCombinationIsEnable, value);
        }

        #endregion

    }
}
