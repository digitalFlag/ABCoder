using ABCoder.ViewModels.Base;
using Microsoft.Win32;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Input;
using TextOptions;

namespace ABCoder.ViewModels
{
    internal partial class MainWindowViewModel : ViewModel
    {
        #region Close Application Command

        public ICommand CloseApplicationCommand { get; }

        private bool CanCloseApplicationCommandExecute(object p) => true;

        private void OnCloseApplicationCommandExecuted(object p)
        {
            Application.Current.Shutdown();
        }

        #endregion

        #region Change Selection Of Combo Box Mode Command

        public ICommand ChangeSelectionOfComboBoxModeCommand { get; }

        private bool CanChangeSelectionOfComboBoxModeCommandExecute(object p) => true;

        private void OnChangeSelectionOfComboBoxModeCommandExecuted(object p)
        {
            TextBoxInformationBitsText = string.Empty;
            TextBoxCodeCombinationText = string.Empty;
            if (ComboBoxModeSelectedIndex == 0)
            {
                ButtonActionContent = ComboBoxModeCodeContent;
                TextBoxInformationBitsIsEnable = true;
                ButtonInformationInformationBitsIsEnable = true;
                ButtonInformationInformationBitsTextColor = "Firebrick";
                ButtonInformationInformationBitsToolTipText = "The \"Information Bits\" field is empty.";
                ButtonOpenInformationBitsIsEnable = true;
                TextBoxCodeCombinationIsEnable = false;
                ButtonInformationCodeCombinationTextColor = "DarkBlue";
                ButtonInformationCodeCombinationIsEnable = false;
                ButtonOpenCodeCombinationIsEnable = false;
                SetErrorBitsFieldDefaultValues();
            }
            else
            {
                ButtonActionContent = ComboBoxModeDecodeContent;
                TextBoxInformationBitsIsEnable = false;
                ButtonInformationInformationBitsIsEnable = false;
                ButtonInformationInformationBitsTextColor = "DarkBlue";
                ButtonOpenInformationBitsIsEnable = false;
                TextBoxCodeCombinationIsEnable = true;
                ButtonInformationCodeCombinationTextColor = "Firebrick";
                ButtonInformationCodeCombinationIsEnable = true;
                ButtonInformationCodeCombinationToolTipText = "The \"Code Combination\" field is empty.";
                ButtonOpenCodeCombinationIsEnable = true;
            }
            OnPropertyChanged();
        }

        #endregion

        #region Change Selection Of Combo Box Code Type Command

        public ICommand ChangeSelectionOfComboBoxCodeTypeCommand { get; }

        private bool CanChangeSelectionOfComboBoxCodeTypeCommandExecute(object p) => true;

        private void OnChangeSelectionOfComboBoxCodeTypeCommandExecuted(object p)
        {
            if (ComboBoxModeSelectedIndex == 1)
            {
                TextBoxInformationBitsText = string.Empty;
            }

            //(13, 9) 13 Hamming
            if (ComboBoxCodeTypeSelectedIndex == 0)
            {
                SetHamming13913Options();
            }
            //(15, 11) 13 Hamming
            if (ComboBoxCodeTypeSelectedIndex == 1)
            {
                SetHamming151113Options();
            }
            //(16, 7) 139 Quadratic Residue
            if (ComboBoxCodeTypeSelectedIndex == 2)
            {
                Set167139QuadraticResidueOptions();
            }
            //(16, 11) 13 Hamming
            if (ComboBoxCodeTypeSelectedIndex == 3)
            {
                SetHamming161113Options();
            }
            //(17, 12) 45 Hamming
            if (ComboBoxCodeTypeSelectedIndex == 4)
            {
                SetHamming171245Options();
            }
            //(20, 8) C75 Goley
            if (ComboBoxCodeTypeSelectedIndex == 5)
            {
                SetGoley208C75Options();
            }
            //(23, 12) AE3 Goley
            if (ComboBoxCodeTypeSelectedIndex == 6)
            {
                SetGoley2312AE3Options();
            }
            //(23, 12) C75 Goley
            if (ComboBoxCodeTypeSelectedIndex == 7)
            {
                SetGoley2312C75Options();
            }

            CheckInformationBitsCombination();
            SetErrorBitsFieldDefaultValues();
            OnPropertyChanged();
        }

        #endregion

        #region Select Main Menu Help About Command

        public ICommand SelectMainMenuHelpAboutCommand { get; }

        private bool CanSelectMainMenuHelpAboutCommandExecute(object p) => true;

        private void OnSelectMainMenuHelpAboutCommandExecuted(object p)
        {
            MessageBox.Show(File.ReadAllText("README.md"), MainMenuHelpAboutABCoderItem, MessageBoxButton.OK, MessageBoxImage.Information);
            OnPropertyChanged();
        }

        #endregion

        #region Select Main Menu Help Feedback Command

        public ICommand SelectMainMenuHelpFeedbackCommand { get; }

        private bool CanSelectMainMenuHelpFeedbackCommandExecute(object p) => true;

        private void OnSelectMainMenuHelpFeedbackCommandExecuted(object p)
        {
            MessageBox.Show(MainMenuHelpFeedbackText, MainMenuHelpFeedbackItem, MessageBoxButton.OK, MessageBoxImage.Information);
            OnPropertyChanged();
        }

        #endregion

        #region Text Box Information Bits Text Changed Command

        public ICommand TextBoxInformationBitsTextChangedCommand { get; }

        private bool CanTextBoxInformationBitsTextChangedCommandExecute(object p) => true;

        private void OnTextBoxInformationBitsTextChangedCommandExecuted(object p)
        {
            if (ComboBoxModeSelectedIndex == 0)
            {
                TextBoxCodeCombinationBorderBrush = "DeepSkyBlue";
                CheckInformationBitsCombination();
                OnPropertyChanged();
            }
        }

        #endregion
        #region Text Box Code Combination Text Changed Command

        public ICommand TextBoxCodeCombinationTextChangedCommand { get; }

        private bool CanTextBoxCodeCombinationTextChangedCommandExecute(object p) => true;

        private void OnTextBoxCodeCombinationTextChangedCommandExecuted(object p)
        {
            if (ComboBoxModeSelectedIndex == 1)
            {
                CheckCodeWord();
                OnPropertyChanged();
            }
        }

        #endregion

        #region Text Box Code Word Text Changed Command

        public ICommand TextBoxCodeWordTextChangedCommand { get; }

        private bool CanTextBoxCodeWordTextChangedCommandExecute(object p) => true;

        private void OnTextBoxCodeWordTextChangedCommandExecuted(object p)
        {
            if (ComboBoxModeSelectedIndex == 0)
            {
                TextBoxCodeCombinationText = string.Empty;
            }
            OnPropertyChanged();
        }

        #endregion

        #region Press Button Information Bits Information Command

        public ICommand PressButtonInformationBitsInformationCommand { get; }

        private bool CanPressButtonInformationBitsInformationCommandExecute(object p) => true;

        private void OnPressButtonInformationBitsInformationCommandExecuted(object p)
        {
            MessageBox.Show(ButtonInformationInformationBitsToolTipText, "Attention", MessageBoxButton.OK, MessageBoxImage.Information);
            OnPropertyChanged();
        }

        #endregion
        #region Press Button Information Code Combination Command

        public ICommand PressButtonInformationCodeCombinationCommand { get; }

        private bool CanPressButtonInformationCodeCombinationCommandExecute(object p) => true;

        private void OnPressButtonInformationCodeCombinationCommandExecuted(object p)
        {
            MessageBox.Show(ButtonInformationCodeCombinationToolTipText, "Attention", MessageBoxButton.OK, MessageBoxImage.Information);
            OnPropertyChanged();
        }

        #endregion

        #region Press Button Open Information Bits Command

        public ICommand PressPressButtonOpenInformationBitsCommand { get; }

        private bool CanPressPressButtonOpenInformationBitsCommandExecute(object p) => true;

        private void OnPressPressButtonOpenInformationBitsCommandExecuted(object p)
        {
            OpenFileDialog ofd = new();
            ofd.ShowDialog();
            if (ofd.FileName != string.Empty)//Select new file
            {
                TextBoxInformationBitsText = File.ReadAllText(ofd.FileName);
                TextBoxInformationBitsText = TextChecks.AsBinarySymbols(ref _TextBoxInformationBitsText);
                CheckInformationBitsCombination();
            }
            OnPropertyChanged();
        }

        #endregion
        #region Press Button Open Code Combination Command

        public ICommand PressButtonOpenCodeCombinationCommand { get; }

        private bool CanPressButtonOpenCodeCombinationCommandExecute(object p) => true;

        private void OnPressButtonOpenCodeCombinationCommandExecuted(object p)
        {
            OpenFileDialog ofd = new();
            ofd.ShowDialog();
            if (ofd.FileName != string.Empty)//Select new file
            {
                TextBoxCodeCombinationText = File.ReadAllText(ofd.FileName);
                TextBoxCodeCombinationText = TextChecks.AsBinarySymbols(ref _TextBoxCodeCombinationText);
                CheckInformationBitsCombination();
            }
            OnPropertyChanged();
        }

        #endregion

        #region Press Button Copy Information Bits Command

        public ICommand PressPressButtonCopyInformationBitsCommand { get; }

        private bool CanPressPressButtonCopyInformationBitsCommandExecute(object p) => true;

        private void OnPressPressButtonCopyInformationBitsCommandExecuted(object p)
        {
            if (string.IsNullOrEmpty(TextBoxInformationBitsText))
            {
                return;
            }

            Clipboard.SetDataObject(TextBoxInformationBitsText);
            OnPropertyChanged();
        }

        #endregion
        #region Press Button Copy Code Combination Command

        public ICommand PressButtonCopyCodeCombinationCommand { get; }

        private bool CanPressButtonCopyCodeCombinationCommandExecute(object p) => true;

        private void OnPressButtonCopyCodeCombinationCommandExecuted(object p)
        {
            if (string.IsNullOrEmpty(TextBoxCodeCombinationText))
            {
                return;
            }

            Clipboard.SetDataObject(TextBoxCodeCombinationText);
            OnPropertyChanged();
        }

        #endregion

        #region Press Button Clear Information Bits Command

        public ICommand PressPressButtonClearInformationBitsCommand { get; }

        private bool CanPressPressButtonClearInformationBitsCommandExecute(object p) => true;

        private void OnPressPressButtonClearInformationBitsCommandExecuted(object p)
        {
            if (string.IsNullOrEmpty(TextBoxInformationBitsText))
            {
                return;
            }
            else
            {
                TextBoxInformationBitsText = string.Empty;
            }

            OnPropertyChanged();
        }

        #endregion
        #region Press Button Clear Code Combination Command

        public ICommand PressButtonClearCodeCombinationCommand { get; }

        private bool CanPressButtonClearCodeCombinationCommandExecute(object p) => true;

        private void OnPressButtonClearCodeCombinationCommandExecuted(object p)
        {
            if (string.IsNullOrEmpty(TextBoxCodeCombinationText))
            {
                return;
            }
            else
            {
                TextBoxCodeCombinationText = string.Empty;
            }

            OnPropertyChanged();
        }

        #endregion

        /* 
         * 0 -> (13, 9) 13 Hamming
         * 1 -> (15, 11) 13 Hamming
         * 2 -> (16, 7) 139 Quadratic Residue
         * 3 -> (16, 11) 13 Hamming
         * 4 -> (17, 12) 45 Hamming
         * 5 -> (20, 8) C75 Goley
         * 6 -> (23, 12) AE3 Goley
         * 7 -> (23, 12) C75 Goley
        */

        private void Encode()
        {
            // (13, 9) 13 Hamming
            if (ComboBoxCodeTypeSelectedIndex == 0)
                EncodeHamming13913();
            // (16, 11) 13 Hamming
            if (ComboBoxCodeTypeSelectedIndex == 1)
                EncodeHamming151113();
            // (16, 7) 139 Quadratic Residue
            if (ComboBoxCodeTypeSelectedIndex == 2)
                Encode167139QuadraticResidue();
            // (16, 11) 13 Hamming
            if (ComboBoxCodeTypeSelectedIndex == 3)
                EncodeHamming161113();
            // (17, 12) 45 Hamming
            if (ComboBoxCodeTypeSelectedIndex == 4)
                EncodeHamming171245();
            // (20, 8) C75 Goley
            if (ComboBoxCodeTypeSelectedIndex == 5)
                EncodeGoley208C75();
            // (23, 12) AE3 Goley
            if (ComboBoxCodeTypeSelectedIndex == 6)
                EncodeGoley2312AE3();
            // (23, 12) C75 Goley
            if (ComboBoxCodeTypeSelectedIndex == 7)
                EncodeGoley2312C75();

            OnPropertyChanged();
        }

        private void Decode()
        {
            // (13, 9) 13 Hamming
            if (ComboBoxCodeTypeSelectedIndex == 0)
                DecodeHamming13913();
            // (15, 11) 13 Hamming
            if (ComboBoxCodeTypeSelectedIndex == 1)
                DecodeHamming151113();
            // (16, 7) 139 Quadratic Residue
            if (ComboBoxCodeTypeSelectedIndex == 2)
                Decode167139QuadraticResidue();
            // (16, 11) 13 Hamming
            if (ComboBoxCodeTypeSelectedIndex == 3)
                DecodeHamming161113();
            // (17, 12) 45 Hamming
            if (ComboBoxCodeTypeSelectedIndex == 4)
                DecodeHamming171245();
            // (20, 8) C75 Goley
            if (ComboBoxCodeTypeSelectedIndex == 5)
                DecodeGoley208C75();
            // (23, 12) AE3 Goley
            if (ComboBoxCodeTypeSelectedIndex == 6)
                DecodeGoley2312AE3();
            // (23, 12) C75 Goley
            if (ComboBoxCodeTypeSelectedIndex == 7)
                DecodeGoley2312C75();

            OnPropertyChanged();
        }

        private void CheckInformationBitsCombination()
        {
            StringBuilder informationInformationBitsToolTip = new();
            TextBoxInformationBitsBorderBrush = "DeepSkyBlue";
            ButtonInformationInformationBitsTextColor = "DarkBlue";

            if (string.IsNullOrEmpty(TextBoxInformationBitsText))
            {
                TextBoxInformationBitsBorderBrush = "DeepSkyBlue";
                ButtonInformationInformationBitsTextColor = "Firebrick";
                informationInformationBitsToolTip.AppendLine("* The \"" + LableValueInformation + "\" field is empty.");
            }
            else
            {
                //Encode
                if (ComboBoxModeSelectedIndex == 0)
                {
                    // (13, 9) 13 Hamming
                    if (ComboBoxCodeTypeSelectedIndex == 0)
                        CheckHamming13913InformationBitsCombination(ref informationInformationBitsToolTip);
                    // (15, 11) 13 Hamming
                    if (ComboBoxCodeTypeSelectedIndex == 1)
                        CheckHamming151113InformationBitsCombination(ref informationInformationBitsToolTip);
                    // (16, 7) 139 Quadratic Residue
                    if (ComboBoxCodeTypeSelectedIndex == 2)
                        Check167139QuadraticResidueInformationBitsCombination(ref informationInformationBitsToolTip);
                    // (16, 11) 13 Hamming
                    if (ComboBoxCodeTypeSelectedIndex == 3)
                        CheckHamming161113InformationBitsCombination(ref informationInformationBitsToolTip);
                    // (17, 12) 45 Hamming
                    if (ComboBoxCodeTypeSelectedIndex == 4)
                        CheckHamming171245InformationBitsCombination(ref informationInformationBitsToolTip);
                    // (20, 8) C75 Goley
                    if (ComboBoxCodeTypeSelectedIndex == 5)
                        CheckGoley208C75InformationBitsCombination(ref informationInformationBitsToolTip);
                    // (23, 12) AE3 Goley
                    if (ComboBoxCodeTypeSelectedIndex == 6)
                        CheckGoley2312AE3InformationBitsCombination(ref informationInformationBitsToolTip);
                    // (23, 12) C75 Goley
                    if (ComboBoxCodeTypeSelectedIndex == 7)
                        CheckGoley2312C75InformationBitsCombination(ref informationInformationBitsToolTip);
                }
                //Decode
                if (ComboBoxModeSelectedIndex == 1)
                {
                    // (13, 9) 13 Hamming
                    if (ComboBoxCodeTypeSelectedIndex == 0)
                        CheckHamming13913CodeWord(ref informationInformationBitsToolTip);
                    // (15, 11) 13 Hamming
                    if (ComboBoxCodeTypeSelectedIndex == 1)
                        CheckHamming151113CodeWord(ref informationInformationBitsToolTip);
                    // (16, 7) 139 Quadratic Residue
                    if (ComboBoxCodeTypeSelectedIndex == 2)
                        Check167139QuadraticResidueCodeWord(ref informationInformationBitsToolTip);
                    // (16, 11) 13 Hamming
                    if (ComboBoxCodeTypeSelectedIndex == 3)
                        CheckHamming161113CodeWord(ref informationInformationBitsToolTip);
                    // (17, 12) 45 Hamming
                    if (ComboBoxCodeTypeSelectedIndex == 4)
                        CheckHamming171245CodeWord(ref informationInformationBitsToolTip);
                    // (20, 8) C75 Goley
                    if (ComboBoxCodeTypeSelectedIndex == 5)
                        CheckGoley208C75CodeWord(ref informationInformationBitsToolTip);
                    // (23, 12) AE3 Goley
                    if (ComboBoxCodeTypeSelectedIndex == 6)
                        CheckGoley2312AE3CodeWord(ref informationInformationBitsToolTip);
                    // (23, 12) C75 Goley
                    if (ComboBoxCodeTypeSelectedIndex == 7)
                        CheckGoley2312C75CodeWord(ref informationInformationBitsToolTip);
                }
            }

            if (string.IsNullOrEmpty(informationInformationBitsToolTip.ToString()))
            {
                informationInformationBitsToolTip.AppendLine("* The \"" + LableValueInformation + "\" combination is valid.");
                Encode();
            }

            ButtonInformationInformationBitsToolTipText = informationInformationBitsToolTip.ToString();
        }

        private void CheckCodeWord()
        {
            StringBuilder codeCombinationToolTip = new();
            TextBoxCodeCombinationBorderBrush = "DeepSkyBlue";
            ButtonInformationCodeCombinationTextColor = "DarkBlue";
            SetErrorBitsFieldDefaultValues();
            if (TextBoxCodeCombinationText == string.Empty)
            {
                TextBoxCodeCombinationBorderBrush = "DeepSkyBlue";
                ButtonInformationCodeCombinationTextColor = "Firebrick";
                codeCombinationToolTip.AppendLine("* The \"" + LableValueCodeCombination + "\" field is empty.");
            }
            else
            //Decode
            {
                // (13, 9) 13 Hamming
                if (ComboBoxCodeTypeSelectedIndex == 0)
                    CheckHamming13913CodeWord(ref codeCombinationToolTip);
                // (15, 11) 13 Hamming
                if (ComboBoxCodeTypeSelectedIndex == 1)
                    CheckHamming151113CodeWord(ref codeCombinationToolTip);
                // (16, 7) 139 Quadratic Residue
                if (ComboBoxCodeTypeSelectedIndex == 2)
                    Check167139QuadraticResidueCodeWord(ref codeCombinationToolTip);
                // (16, 11) 13 Hamming
                if (ComboBoxCodeTypeSelectedIndex == 3)
                    CheckHamming161113CodeWord(ref codeCombinationToolTip);
                // (17, 12) 45 Hamming
                if (ComboBoxCodeTypeSelectedIndex == 4)
                    CheckHamming171245CodeWord(ref codeCombinationToolTip);
                // (20, 8) C75 Goley
                if (ComboBoxCodeTypeSelectedIndex == 5)
                    CheckGoley208C75CodeWord(ref codeCombinationToolTip);
                // (23, 12) AE3 Goley
                if (ComboBoxCodeTypeSelectedIndex == 6)
                    CheckGoley2312AE3CodeWord(ref codeCombinationToolTip);
                // (23, 12) C75 Goley
                if (ComboBoxCodeTypeSelectedIndex == 7)
                    CheckGoley2312C75CodeWord(ref codeCombinationToolTip);
            }

            if (string.IsNullOrEmpty(codeCombinationToolTip.ToString()))
            {
                codeCombinationToolTip.AppendLine("* The \"" + LableValueCodeCombination + "\" field is valid.");
                Decode();
            }

            ButtonInformationCodeCombinationToolTipText = codeCombinationToolTip.ToString();
        }

        private void SetErrorBitsFieldDefaultValues()
        {
            string color = "Green";
            string fontStyle = "Regular";


            TextBlockLetter0Text = string.Empty;
            TextBlockLetter1Text = string.Empty;
            TextBlockLetter2Text = string.Empty;
            TextBlockLetter3Text = string.Empty;
            TextBlockLetter4Text = string.Empty;
            TextBlockLetter5Text = string.Empty;
            TextBlockLetter6Text = string.Empty;
            TextBlockLetter7Text = string.Empty;
            TextBlockLetter8Text = string.Empty;
            TextBlockLetter9Text = string.Empty;
            TextBlockLetter10Text = string.Empty;
            TextBlockLetter11Text = string.Empty;
            TextBlockLetter12Text = string.Empty;
            TextBlockLetter13Text = string.Empty;
            TextBlockLetter14Text = string.Empty;
            TextBlockLetter15Text = string.Empty;
            TextBlockLetter16Text = string.Empty;
            TextBlockLetter17Text = string.Empty;
            TextBlockLetter18Text = string.Empty;
            TextBlockLetter19Text = string.Empty;
            TextBlockLetter20Text = string.Empty;
            TextBlockLetter21Text = string.Empty;
            TextBlockLetter22Text = string.Empty;

            TextBlockLetter0Foreground = color;
            TextBlockLetter1Foreground = color;
            TextBlockLetter2Foreground = color;
            TextBlockLetter3Foreground = color;
            TextBlockLetter4Foreground = color;
            TextBlockLetter5Foreground = color;
            TextBlockLetter6Foreground = color;
            TextBlockLetter7Foreground = color;
            TextBlockLetter8Foreground = color;
            TextBlockLetter9Foreground = color;
            TextBlockLetter10Foreground = color;
            TextBlockLetter11Foreground = color;
            TextBlockLetter12Foreground = color;
            TextBlockLetter13Foreground = color;
            TextBlockLetter14Foreground = color;
            TextBlockLetter15Foreground = color;
            TextBlockLetter16Foreground = color;
            TextBlockLetter17Foreground = color;
            TextBlockLetter18Foreground = color;
            TextBlockLetter19Foreground = color;
            TextBlockLetter20Foreground = color;
            TextBlockLetter21Foreground = color;
            TextBlockLetter22Foreground = color;

            TextBlockLetter0FontStyle = fontStyle;
            TextBlockLetter1FontStyle = fontStyle;
            TextBlockLetter2FontStyle = fontStyle;
            TextBlockLetter3FontStyle = fontStyle;
            TextBlockLetter4FontStyle = fontStyle;
            TextBlockLetter5FontStyle = fontStyle;
            TextBlockLetter6FontStyle = fontStyle;
            TextBlockLetter7FontStyle = fontStyle;
            TextBlockLetter8FontStyle = fontStyle;
            TextBlockLetter9FontStyle = fontStyle;
            TextBlockLetter10FontStyle = fontStyle;
            TextBlockLetter11FontStyle = fontStyle;
            TextBlockLetter12FontStyle = fontStyle;
            TextBlockLetter13FontStyle = fontStyle;
            TextBlockLetter14FontStyle = fontStyle;
            TextBlockLetter15FontStyle = fontStyle;
            TextBlockLetter16FontStyle = fontStyle;
            TextBlockLetter17FontStyle = fontStyle;
            TextBlockLetter18FontStyle = fontStyle;
            TextBlockLetter19FontStyle = fontStyle;
            TextBlockLetter20FontStyle = fontStyle;
            TextBlockLetter21FontStyle = fontStyle;
            TextBlockLetter22FontStyle = fontStyle;
        }

    }
}
