using ABCoder.Models.ComboBox;
using System;
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

        private string _LableValueCodeCombination = "Code Combination:";
        /// <summary>Lable Value Code Combination</summary>
        public string LableValueCodeCombination
        {
            get => _LableValueCodeCombination;
            set => Set(ref _LableValueCodeCombination, value);
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

        private string _ComboBoxModeCodeContent = "Code";
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

        private string _ButtonActionContent = "Code";
        /// <summary>Button Action Content</summary>
        public string ButtonActionContent
        {
            get => _ButtonActionContent;
            set => Set(ref _ButtonActionContent, value);
        }

        #endregion
    }
}
