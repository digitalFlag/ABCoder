using ABCoder.ViewModels.Base;
using System.Text;

namespace ABCoder.ViewModels
{
    internal partial class MainWindowViewModel : ViewModel
    {
        private void SetHumming161113Options()
        {
            LableValueCodeInstanceName = CodeInstanceHamming161113.Name;
            LableValueCodeInstancePolynomial = CodeInstanceHamming161113.Polynomial;
            LableValueCodeWordLength = CodeInstanceHamming161113.CodeWordLength;
            LableValueInformationPartLength = CodeInstanceHamming161113.InformationPartLength;
            LableValueVerificationPartLength = CodeInstanceHamming161113.VerificationPartLength;
            LableValueErrorDetectionCapability = CodeInstanceHamming161113.ErrorDetectionCapability;
            LableValueErrorCorrectionCapability = CodeInstanceHamming161113.ErrorCorrectionCapability;
        }

        private void CheckHumming161113InformationBitsCombination(ref StringBuilder informationInformationBitsToolTip)
        {
            if (!Hamming_1611_13.Checks.InformationPartLength(ref _TextBoxInformationBitsText))//Lengtg Check
            {
                TextBoxInformationBitsBorderBrush = "Firebrick";
                ButtonInformationInformationBitsTextColor = "Firebrick";
                informationInformationBitsToolTip.AppendLine("* The \"" + LableValueInformation + "\" field length must be 11.");
                TextBoxCodeCombinationText = string.Empty;
            }

            if (!ChecksGeneral.Checks.BinaryFormat(ref _TextBoxInformationBitsText))//String Format Check
            {
                TextBoxInformationBitsBorderBrush = "Firebrick";
                ButtonInformationInformationBitsTextColor = "Firebrick";
                informationInformationBitsToolTip.AppendLine("* The \"" + LableValueInformation + "\" field contains a non-binary symbol.");
            }
        }

        private void EncodeHumming161113()
        {
            TextBoxInformationBitsBorderBrush = "DeepSkyBlue";
            bool[] informationBits = Converter.BinaryStringToBoolArray.Convert(ref _TextBoxInformationBitsText);
            bool[] codeCombination = Hamming_1611_13.Code.Encode(ref informationBits);
            TextBoxCodeCombinationText = Converter.BoolArrayToBinaryString.Convert(ref codeCombination);
        }
    }
}
