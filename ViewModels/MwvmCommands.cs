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
                LableErrorsBitsIsEnable = false;
                TextBoxInformationBitsIsEnable = true;
                ButtonInformationInformationBitsIsEnable = true;
                ButtonInformationCodeWordIsEnable = false;
            }
            else
            {
                ButtonActionContent = ComboBoxModeDecodeContent;
                LableErrorsBitsIsEnable = true;
                TextBoxInformationBitsIsEnable = false;
                ButtonInformationInformationBitsIsEnable = false;
                ButtonInformationCodeWordIsEnable = true;
            }
            OnPropertyChanged();


        }

        #endregion

        #region Execute Button Command

        public ICommand ExecuteButtonCommand { get; }

        private bool CanExecuteButtonCommandExecute(object p) => true;

        private void OnExecuteButtonCommandExecuted(object p)
        {
            if (ComboBoxModeSelectedIndex == 0 && ComboBoxCodeTypeSelectedIndex == 0)// Code Goley (23, 12) C75
            {

                if(Goley_2312_C75.CheckEntedData.CkeckInfornationBits(ref _TextBoxInformationBitsText))
                {
                    TextBoxInformationBitsBorderBrush = "Green";
                    bool[] informationBits = Converter.BinaryStringToBoolArray.Convert(ref  _TextBoxInformationBitsText);
                    bool[] codeCombination = Goley_2312_C75.Code.Encode(ref informationBits);
                    TextBoxCodeCombinationText = Converter.BoolArrayToBinaryString.Convert(ref codeCombination);

                }
                else
                {
                    TextBoxInformationBitsBorderBrush = "Red";
                }

            }
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
            TextBoxInformationBitsBorderBrush = "Gray";
            ButtonInformationInformationBitsTextColor = "Gray";

            if (TextBoxInformationBitsText == string.Empty)
            {
                TextBoxInformationBitsBorderBrush = "Gray";
                ButtonInformationInformationBitsTextColor = "BlueViolet";
                informationInformationBitsToolTip.AppendLine("* The \"" + LableValueInformation + "\" field is empty.");
            }
            else
            {
                if (!Golay2312C75Checks.InformationPartLength(ref _TextBoxInformationBitsText))//Lengtg Check
                {
                    TextBoxInformationBitsBorderBrush = "Red";
                    ButtonInformationInformationBitsTextColor = "BlueViolet";
                    informationInformationBitsToolTip.AppendLine("* The \"" + LableValueInformation + "\" field length must be 12.");
                }

                if (!Golay2312C75Checks.BinaryFormat(ref _TextBoxInformationBitsText))//String Format Check
                {
                    TextBoxInformationBitsBorderBrush = "Red";
                    ButtonInformationInformationBitsTextColor = "BlueViolet";
                    informationInformationBitsToolTip.AppendLine("* The \"" + LableValueInformation + "\" field contains a non-binary symbol.");
                }
            }

            if (string.IsNullOrEmpty(informationInformationBitsToolTip.ToString()))
            {
                informationInformationBitsToolTip.AppendLine("* The \"" + LableValueInformation + "\" combination is valid.");
            }

            informationInformationBitsToolTip.Remove(informationInformationBitsToolTip.Length - 2, 2);

            ButtonInformationInformationBitsToolTipText = informationInformationBitsToolTip.ToString();


            OnPropertyChanged();
        }

        #endregion




    }
}
