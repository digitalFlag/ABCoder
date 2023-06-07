using ABCoder.ViewModels.Base;
using System.IO;
using System.Threading.Channels;
using System.Windows;
using System.Windows.Input;
using ABCoder.BusinessLogic.CodesChecks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Text;

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
            if (ComboBoxModeSelectedIndex == 0)
            {
                ButtonActionContent = ComboBoxModeCodeContent;
                TextBoxInformationBitsIsEnable = true;
                ButtonInformationInformationBitsIsEnable = true;
                ButtonInformationInformationBitsTextColor = "Firebrick";
                ButtonInformationInformationBitsToolTipText = "The \"Information Bits\" field is empty.";
            }
            else
            {
                ButtonActionContent = ComboBoxModeDecodeContent;
                TextBoxInformationBitsIsEnable = false;
                TextBoxInformationBitsText = string.Empty;
                ButtonInformationInformationBitsIsEnable = false;
                ButtonInformationInformationBitsTextColor = "DarkBlue";
                TextBoxCodeCombinationText = string.Empty;
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


    }
}
