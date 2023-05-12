using ABCoder.Models.Code;
using ABCoder.Models.ComboBox;
using System.Collections.ObjectModel;

namespace ABCoder.ViewModels
{
    internal partial class MainWindowViewModel
    {
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

        #region Lable Value Mode

        private string _LableValueMode = "Mode:";
        /// <summary>Lable Value Mode</summary>
        public string LableValueMode
        {
            get => _LableValueMode;
            set => Set(ref _LableValueMode, value);
        }

        #endregion
        #region Lable Value Code Type

        private string _LableValueCodeType = "Code Type:";
        /// <summary>Lable Value Code Type</summary>
        public string LableValueCodeType
        {
            get => _LableValueCodeType;
            set => Set(ref _LableValueCodeType, value);
        }

        #endregion
        #region Lable Value Action

        private string _LableValueAction = "Action:";
        /// <summary>Lable Value Action</summary>
        public string LableValueAction
        {
            get => _LableValueAction;
            set => Set(ref _LableValueAction, value);
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
        #region Lable Value Code Parameters

        private string _LableValueCodeParameters = "Code parameters:";
        /// <summary>Lable Value Code Parameters</summary>
        public string LableValueCodeParameters
        {
            get => _LableValueCodeParameters;
            set => Set(ref _LableValueCodeParameters, value);
        }

        #endregion

        #region Lable Value Code Instance Name

        private string _LableValueCodeInstanceName = "Code type:";
        /// <summary>Lable Value Code Instance Name</summary>
        public string LableValueCodeInstanceName
        {
            get => _LableValueCodeInstanceName;
            set => Set(ref _LableValueCodeInstanceName, value);
        }

        #endregion
        #region Lable Value Code Instance Polynomial

        private string _LableValueCodeInstancePolynomial = "Polynomial:";
        /// <summary>Lable Value Code Instance Polynomial</summary>
        public string LableValueCodeInstancePolynomial
        {
            get => _LableValueCodeInstancePolynomial;
            set => Set(ref _LableValueCodeInstancePolynomial, value);
        }

        #endregion

        #region Lable Value Code Word Length

        private string _LableValueCodeWordLength = "Code word length:";
        /// <summary>Lable Value Code Word Length</summary>
        public string LableValueCodeWordLength
        {
            get => _LableValueCodeWordLength;
            set => Set(ref _LableValueCodeWordLength, value);
        }

        #endregion
        #region Lable Value Information Part Length

        private string _LableValueInformationPartLength = "Information Part Length:";
        /// <summary>Lable Value Information Part Length</summary>
        public string LableValueInformationPartLength
        {
            get => _LableValueInformationPartLength;
            set => Set(ref _LableValueInformationPartLength, value);
        }

        #endregion
        #region Lable Value Verification Part Length

        private string _LableValueVerificationPartLength = "Verification Part Length:";
        /// <summary>Lable Value Verification Part Length</summary>
        public string LableValueVerificationPartLength
        {
            get => _LableValueVerificationPartLength;
            set => Set(ref _LableValueVerificationPartLength, value);
        }

        #endregion
        #region Lable Value Error Detection Capability

        private string _LableValueErrorDetectionCapability = "Error Detection Capability:";
        /// <summary>Lable Value Error Detection Capability</summary>
        public string LableValueErrorDetectionCapability
        {
            get => _LableValueErrorDetectionCapability;
            set => Set(ref _LableValueErrorDetectionCapability, value);
        }

        #endregion
        #region Lable Value Error Correction Capability

        private string _LableValueErrorCorrectionCapability = "Error Correction Capability:";
        /// <summary>Lable Value Error Correction Capability</summary>
        public string LableValueErrorCorrectionCapability
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

        private string _TextBoxInformationBitsBorderBrush = "Gray";
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

        #region Text Box Code Combination Text

        private string _TextBoxCodeCombinationText = string.Empty;
        /// <summary>Text Box Code Combination Text</summary>
        public string TextBoxCodeCombinationText
        {
            get => _TextBoxCodeCombinationText;
            set => Set(ref _TextBoxCodeCombinationText, value);
        }

        #endregion

        #region Button Action Content

        private string _ButtonActionContent = "Encode";
        /// <summary>Button Action Content</summary>
        public string ButtonActionContent
        {
            get => _ButtonActionContent;
            set => Set(ref _ButtonActionContent, value);
        }

        #endregion
    }
}
