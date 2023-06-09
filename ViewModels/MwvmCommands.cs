using ABCoder.BusinessLogic.CodesChecks;
using ABCoder.ViewModels.Base;
using Goley_2312_C75;
using Microsoft.Win32;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
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

        #region Execute Button Command

        public ICommand ExecuteButtonCommand { get; }

        private bool CanExecuteButtonCommandExecute(object p) => true;

        private void OnExecuteButtonCommandExecuted(object p)
        {
            Encode();
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

        #region Text Box Information Bits Text Changed Command

        public ICommand TextBoxInformationBitsTextChangedCommand { get; }

        private bool CanTextBoxInformationBitsTextChangedCommandExecute(object p) => true;

        private void OnTextBoxInformationBitsTextChangedCommandExecuted(object p)
        {
            CheckInformationBitsCombination();
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

        private void Encode()
        {
            if (ComboBoxModeSelectedIndex == 0 && ComboBoxCodeTypeSelectedIndex == 0)// Code Goley (23, 12) C75
            {

                if (Goley_2312_C75.CheckEntedData.CkeckInfornationBits(ref _TextBoxInformationBitsText))
                {
                    TextBoxInformationBitsBorderBrush = "DeepSkyBlue";
                    bool[] informationBits = Converter.BinaryStringToBoolArray.Convert(ref _TextBoxInformationBitsText);
                    bool[] codeCombination = Goley_2312_C75.Code.Encode(ref informationBits);
                    TextBoxCodeCombinationText = Converter.BoolArrayToBinaryString.Convert(ref codeCombination);
                }
                else
                {
                    TextBoxInformationBitsBorderBrush = "Firebrick";
                }

            }
            OnPropertyChanged();
        }

        private void CheckInformationBitsCombination()
        {
            StringBuilder informationInformationBitsToolTip = new();
            TextBoxInformationBitsBorderBrush = "DeepSkyBlue";
            ButtonInformationInformationBitsTextColor = "DarkBlue";

            if (TextBoxInformationBitsText == string.Empty)
            {
                TextBoxInformationBitsBorderBrush = "DeepSkyBlue";
                ButtonInformationInformationBitsTextColor = "Firebrick";
                informationInformationBitsToolTip.AppendLine("* The \"" + LableValueInformation + "\" field is empty.");
            }
            else
            {
                if (!Golay2312C75Checks.InformationPartLength(ref _TextBoxInformationBitsText))//Lengtg Check
                {
                    TextBoxInformationBitsBorderBrush = "Firebrick";
                    ButtonInformationInformationBitsTextColor = "Firebrick";
                    informationInformationBitsToolTip.AppendLine("* The \"" + LableValueInformation + "\" field length must be 12.");
                    TextBoxCodeCombinationText = string.Empty;
                }

                if (!Golay2312C75Checks.BinaryFormat(ref _TextBoxInformationBitsText))//String Format Check
                {
                    TextBoxInformationBitsBorderBrush = "Firebrick";
                    ButtonInformationInformationBitsTextColor = "Firebrick";
                    informationInformationBitsToolTip.AppendLine("* The \"" + LableValueInformation + "\" field contains a non-binary symbol.");
                }
            }

            if (string.IsNullOrEmpty(informationInformationBitsToolTip.ToString()))
            {
                informationInformationBitsToolTip.AppendLine("* The \"" + LableValueInformation + "\" combination is valid.");
                Encode();
            }

            informationInformationBitsToolTip.Remove(informationInformationBitsToolTip.Length - 2, 2);

            ButtonInformationInformationBitsToolTipText = informationInformationBitsToolTip.ToString();
        }
    }
}
