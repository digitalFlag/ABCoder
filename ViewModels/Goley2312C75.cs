using ABCoder.ViewModels.Base;
using System.Text;

namespace ABCoder.ViewModels
{
    internal partial class MainWindowViewModel : ViewModel
    {

        private void SetGoley2312C75Options()
        {
            LableValueCodeInstanceName = CodeInstanceGoley2312C75.Name;
            LableValueCodeInstancePolynomial = CodeInstanceGoley2312C75.Polynomial;
            LableValueCodeWordLength = CodeInstanceGoley2312C75.CodeWordLength;
            LableValueInformationPartLength = CodeInstanceGoley2312C75.InformationPartLength;
            LableValueVerificationPartLength = CodeInstanceGoley2312C75.VerificationPartLength;
            LableValueErrorDetectionCapability = CodeInstanceGoley2312C75.ErrorDetectionCapability;
            LableValueErrorCorrectionCapability =   CodeInstanceGoley2312C75.ErrorCorrectionCapability;
        }

        private void CheckGoley2312C75InformationBitsCombination(ref StringBuilder informationInformationBitsToolTip)
        {
            if (!Goley_2312_C75.Checks.InformationPartLength(ref _TextBoxInformationBitsText))//Lengtg Check
            {
                TextBoxInformationBitsBorderBrush = "Firebrick";
                ButtonInformationInformationBitsTextColor = "Firebrick";
                informationInformationBitsToolTip.AppendLine("* The \"" + LableValueInformation + "\" field length must be 12.");
                TextBoxCodeCombinationText = string.Empty;
            }

            if (!ChecksGeneral.Checks.BinaryFormat(ref _TextBoxInformationBitsText))//String Format Check
            {
                TextBoxInformationBitsBorderBrush = "Firebrick";
                ButtonInformationInformationBitsTextColor = "Firebrick";
                informationInformationBitsToolTip.AppendLine("* The \"" + LableValueInformation + "\" field contains a non-binary symbol.");
            }
        }

        private void EncodeGoley2312C75()
        {
            TextBoxInformationBitsBorderBrush = "DeepSkyBlue";
            bool[] informationBits = Converter.BinaryStringToBoolArray.Convert(ref _TextBoxInformationBitsText);
            bool[] codeCombination = Goley_2312_C75.Code.Encode(ref informationBits);
            TextBoxCodeCombinationText = Converter.BoolArrayToBinaryString.Convert(ref codeCombination);
        }
    }
}
