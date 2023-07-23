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
                ButtonOpenCodeCOmbinationIsEnable = false;
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
                ButtonOpenCodeCOmbinationIsEnable = true;
            }
            OnPropertyChanged();
        }

        #endregion

        #region Change Selection Of Combo Box Code Type Command

        public ICommand ChangeSelectionOfComboBoxCodeTypeCommand { get; }

        private bool CanChangeSelectionOfComboBoxCodeTypeCommandExecute(object p) => true;

        private void OnChangeSelectionOfComboBoxCodeTypeCommandExecuted(object p)
        {
            //Goley (23, 12) C75
            if (ComboBoxCodeTypeSelectedIndex == 0)
            {
                SetGoley2312C75Options();
            }
            //Hamming (16, 11) 13
            if (ComboBoxCodeTypeSelectedIndex == 0)
            {
                SetHumming161113Options();
            }

            CheckInformationBitsCombination();
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
            CheckInformationBitsCombination();
            OnPropertyChanged();
        }

        #endregion
        #region Text Box Code Combination Text Changed Command

        public ICommand TextBoxCodeCombinationTextChangedCommand { get; }

        private bool CanTextBoxCodeCombinationTextChangedCommandExecute(object p) => true;

        private void OnTextBoxCodeCombinationTextChangedCommandExecuted(object p)
        {
            CheckCodeWord();
            OnPropertyChanged();
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


        private void Encode()
        {
            // EnCode Goley (23, 12) C75
            if (ComboBoxCodeTypeSelectedIndex == 0)
            {
                EncodeGoley2312C75();
            }
            //EnCode Hamming (16,11) 13
            if (ComboBoxCodeTypeSelectedIndex == 1)
            {
                EncodeHumming161113();
            }

            OnPropertyChanged();
        }

        private void Decode()
        {
            if (ComboBoxModeSelectedIndex == 1 && ComboBoxCodeTypeSelectedIndex == 0)// DeCode Goley (23, 12) C75
            {
                bool[] codeWord = Converter.BinaryStringToBoolArray.Convert(ref _TextBoxCodeCombinationText);
                bool[] errors = new bool[23];
                if (Goley_2312_C75.Decode.IsValidCombination(ref codeWord))// No errors
                {
                    bool[] infornationPart = Goley_2312_C75.Parts.SelectTheInformationPartFromTheCodeWord(ref codeWord);
                    TextBoxInformationBitsText = Converter.BoolArrayToBinaryString.Convert(ref infornationPart);
                    CreateErrorBitsText23(ref codeWord, ref errors);
                    return;
                }// No errors
                bool[] syndrom = Goley_2312_C75.Decode.CalculateSindrom(ref codeWord);
                if (Goley_2312_C75.SingleError.Check(ref syndrom, ref errors))// Single error
                {
                    CreateErrorBitsText23(ref codeWord, ref errors);
                    return;
                }// Single error
                if (Goley_2312_C75.DoubleError.Check(ref syndrom, ref errors))// Double error
                {
                    CreateErrorBitsText23(ref codeWord, ref errors);
                    return;
                }// Double error
                if (Goley_2312_C75.TripleError.Check(ref syndrom, ref errors))// Triple error
                {
                    CreateErrorBitsText23(ref codeWord, ref errors);
                    return;
                }// Triple error
                Converter.InvertBoolArrayValues.Execute(ref errors);
                CreateErrorBitsText23(ref codeWord, ref errors);
            }
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
                //Goley (23, 12) C75
                if (ComboBoxCodeTypeSelectedIndex == 0)
                {
                    CheckGoley2312C75InformationBitsCombination(ref informationInformationBitsToolTip);
                }

                //Hamming (16, 11) 13
                if (ComboBoxCodeTypeSelectedIndex == 1)
                {
                    CheckHumming161113InformationBitsCombination(ref informationInformationBitsToolTip);
                }

            }

            if (string.IsNullOrEmpty(informationInformationBitsToolTip.ToString()))
            {
                informationInformationBitsToolTip.AppendLine("* The \"" + LableValueInformation + "\" combination is valid.");
                Encode();
            }

            //informationInformationBitsToolTip.Remove(informationInformationBitsToolTip.Length - 2, 2);

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
            {
                if (!Goley_2312_C75.Checks.CodeWordLength(ref _TextBoxCodeCombinationText))//Lengtg Check
                {
                    TextBoxCodeCombinationBorderBrush = "Firebrick";
                    ButtonInformationCodeCombinationTextColor = "Firebrick";
                    codeCombinationToolTip.AppendLine("* The \"" + LableValueCodeCombination + "\" field length must be 23.");
                    TextBoxInformationBitsText = string.Empty;
                }
                if (!ChecksGeneral.Checks.BinaryFormat(ref _TextBoxCodeCombinationText))//String Format Check
                {
                    TextBoxCodeCombinationBorderBrush = "Firebrick";
                    ButtonInformationCodeCombinationTextColor = "Firebrick";
                    codeCombinationToolTip.AppendLine("* The \"" + LableValueCodeCombination + "\" field contains a non-binary symbol.");
                    TextBoxInformationBitsText = string.Empty;
                }
            }

            if (string.IsNullOrEmpty(codeCombinationToolTip.ToString()))
            {
                codeCombinationToolTip.AppendLine("* The \"" + LableValueCodeCombination + "\" field is valid.");
                Decode();
            }

            codeCombinationToolTip.Remove(codeCombinationToolTip.Length - 2, 2);

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

        private void CreateErrorBitsText23(ref bool[] codeWord, ref bool[] errors)
        {
            SetErrorBitsFieldDefaultValues();

            if (errors[0])
            {
                TextBlockLetter0Text = codeWord[0] ? "0" : "1";
                TextBlockLetter0Foreground = "Firebrick";
                TextBlockLetter0FontStyle = "Bold";
            }
            else
            {
                TextBlockLetter0Text = codeWord[0] ? "1" : "0";
            }

            if (errors[1])
            {
                TextBlockLetter1Text = codeWord[1] ? "0" : "1";
                TextBlockLetter1Foreground = "Firebrick";
                TextBlockLetter1FontStyle = "Bold";
            }
            else
            {
                TextBlockLetter1Text = codeWord[1] ? "1" : "0";
            }

            if (errors[2])
            {
                TextBlockLetter2Text = codeWord[2] ? "0" : "1";
                TextBlockLetter2Foreground = "Firebrick";
                TextBlockLetter2FontStyle = "Bold";
            }
            else
            {
                TextBlockLetter2Text = codeWord[2] ? "1" : "0";
            }

            if (errors[3])
            {
                TextBlockLetter3Text = codeWord[3] ? "0" : "1";
                TextBlockLetter3Foreground = "Firebrick";
                TextBlockLetter3FontStyle = "Bold";
            }
            else
            {
                TextBlockLetter3Text = codeWord[3] ? "1" : "0";
            }

            if (errors[4])
            {
                TextBlockLetter4Text = codeWord[4] ? "0" : "1";
                TextBlockLetter4Foreground = "Firebrick";
                TextBlockLetter4FontStyle = "Bold";
            }
            else
            {
                TextBlockLetter4Text = codeWord[4] ? "1" : "0";
            }

            if (errors[5])
            {
                TextBlockLetter5Text = codeWord[5] ? "0" : "1";
                TextBlockLetter5Foreground = "Firebrick";
                TextBlockLetter5FontStyle = "Bold";
            }
            else
            {
                TextBlockLetter5Text = codeWord[5] ? "1" : "0";
            }

            if (errors[6])
            {
                TextBlockLetter6Text = codeWord[6] ? "0" : "1";
                TextBlockLetter6Foreground = "Firebrick";
                TextBlockLetter6FontStyle = "Bold";
            }
            else
            {
                TextBlockLetter6Text = codeWord[6] ? "1" : "0";
            }

            if (errors[7])
            {
                TextBlockLetter7Text = codeWord[7] ? "0" : "1";
                TextBlockLetter7Foreground = "Firebrick";
                TextBlockLetter7FontStyle = "Bold";
            }
            else
            {
                TextBlockLetter7Text = codeWord[7] ? "1" : "0";
            }

            if (errors[8])
            {
                TextBlockLetter8Text = codeWord[8] ? "0" : "1";
                TextBlockLetter8Foreground = "Firebrick";
                TextBlockLetter8FontStyle = "Bold";
            }
            else
            {
                TextBlockLetter8Text = codeWord[8] ? "1" : "0";
            }

            if (errors[9])
            {
                TextBlockLetter9Text = codeWord[9] ? "0" : "1";
                TextBlockLetter9Foreground = "Firebrick";
                TextBlockLetter9FontStyle = "Bold";
            }
            else
            {
                TextBlockLetter9Text = codeWord[9] ? "1" : "0";
            }

            if (errors[10])
            {
                TextBlockLetter10Text = codeWord[10] ? "0" : "1";
                TextBlockLetter10Foreground = "Firebrick";
                TextBlockLetter10FontStyle = "Bold";
            }
            else
            {
                TextBlockLetter10Text = codeWord[10] ? "1" : "0";
            }

            if (errors[11])
            {
                TextBlockLetter11Text = codeWord[11] ? "0" : "1";
                TextBlockLetter11Foreground = "Firebrick";
                TextBlockLetter11FontStyle = "Bold";
            }
            else
            {
                TextBlockLetter11Text = codeWord[11] ? "1" : "0";
            }

            if (errors[12])
            {
                TextBlockLetter12Text = codeWord[12] ? "0" : "1";
                TextBlockLetter12Foreground = "Firebrick";
                TextBlockLetter12FontStyle = "Bold";
            }
            else
            {
                TextBlockLetter12Text = codeWord[12] ? "1" : "0";
            }

            if (errors[13])
            {
                TextBlockLetter13Text = codeWord[13] ? "0" : "1";
                TextBlockLetter13Foreground = "Firebrick";
                TextBlockLetter13FontStyle = "Bold";
            }
            else
            {
                TextBlockLetter13Text = codeWord[13] ? "1" : "0";
            }

            if (errors[14])
            {
                TextBlockLetter14Text = codeWord[14] ? "0" : "1";
                TextBlockLetter14Foreground = "Firebrick";
                TextBlockLetter14FontStyle = "Bold";
            }
            else
            {
                TextBlockLetter14Text = codeWord[14] ? "1" : "0";
            }

            if (errors[15])
            {
                TextBlockLetter15Text = codeWord[15] ? "0" : "1";
                TextBlockLetter15Foreground = "Firebrick";
                TextBlockLetter15FontStyle = "Bold";
            }
            else
            {
                TextBlockLetter15Text = codeWord[15] ? "1" : "0";
            }

            if (errors[16])
            {
                TextBlockLetter16Text = codeWord[16] ? "0" : "1";
                TextBlockLetter16Foreground = "Firebrick";
                TextBlockLetter16FontStyle = "Bold";
            }
            else
            {
                TextBlockLetter16Text = codeWord[16] ? "1" : "0";
            }

            if (errors[17])
            {
                TextBlockLetter17Text = codeWord[17] ? "0" : "1";
                TextBlockLetter17Foreground = "Firebrick";
                TextBlockLetter17FontStyle = "Bold";
            }
            else
            {
                TextBlockLetter17Text = codeWord[17] ? "1" : "0";
            }

            if (errors[18])
            {
                TextBlockLetter18Text = codeWord[18] ? "0" : "1";
                TextBlockLetter18Foreground = "Firebrick";
                TextBlockLetter18FontStyle = "Bold";
            }
            else
            {
                TextBlockLetter18Text = codeWord[18] ? "1" : "0";
            }

            if (errors[19])
            {
                TextBlockLetter19Text = codeWord[19] ? "0" : "1";
                TextBlockLetter19Foreground = "Firebrick";
                TextBlockLetter19FontStyle = "Bold";
            }
            else
            {
                TextBlockLetter19Text = codeWord[19] ? "1" : "0";
            }

            if (errors[20])
            {
                TextBlockLetter20Text = codeWord[20] ? "0" : "1";
                TextBlockLetter20Foreground = "Firebrick";
                TextBlockLetter20FontStyle = "Bold";
            }
            else
            {
                TextBlockLetter20Text = codeWord[20] ? "1" : "0";
            }

            if (errors[21])
            {
                TextBlockLetter21Text = codeWord[21] ? "0" : "1";
                TextBlockLetter21Foreground = "Firebrick";
                TextBlockLetter21FontStyle = "Bold";
            }
            else
            {
                TextBlockLetter21Text = codeWord[21] ? "1" : "0";
            }

            if (errors[22])
            {
                TextBlockLetter22Text = codeWord[22] ? "0" : "1";
                TextBlockLetter22Foreground = "Firebrick";
                TextBlockLetter22FontStyle = "Bold";
            }
            else
            {
                TextBlockLetter22Text = codeWord[22] ? "1" : "0";
            }

            TextBoxInformationBitsText = TextBlockLetter0Text + TextBlockLetter1Text + TextBlockLetter2Text + TextBlockLetter3Text +
                                         TextBlockLetter4Text + TextBlockLetter5Text + TextBlockLetter6Text + TextBlockLetter7Text +
                                         TextBlockLetter8Text + TextBlockLetter9Text + TextBlockLetter10Text + TextBlockLetter11Text;

        }

    }
}
