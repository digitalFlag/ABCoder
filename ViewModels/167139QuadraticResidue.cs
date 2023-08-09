using ABCoder.ViewModels.Base;
using System.Text;

namespace ABCoder.ViewModels
{
    internal partial class MainWindowViewModel : ViewModel
    {

        private void Set167139QuadraticResidueOptions()
        {
            if (string.IsNullOrEmpty(CodeInstance167139QuadraticResidue.Name))
            {
                LableValueCodeInstanceName = ComboBoxCodeType167139QuadraticResidueContent;
            }
            else
            {
                LableValueCodeInstanceName = CodeInstance167139QuadraticResidue.Name;

            }
            if (string.IsNullOrEmpty(CodeInstance167139QuadraticResidue.Polynomial))
            {
                LableValueCodeInstancePolynomial = "x⁸+x⁵+x⁴+x³+1";
            }
            else
            {
                LableValueCodeInstancePolynomial = CodeInstance167139QuadraticResidue.Polynomial;
            }
            LableValueCodeWordLength = CodeInstance167139QuadraticResidue.CodeWordLength;
            LableValueInformationPartLength = CodeInstance167139QuadraticResidue.InformationPartLength;
            LableValueVerificationPartLength = CodeInstance167139QuadraticResidue.VerificationPartLength;
            LableValueErrorDetectionCapability = CodeInstance167139QuadraticResidue.ErrorDetectionCapability;
            LableValueErrorCorrectionCapability = CodeInstance167139QuadraticResidue.ErrorCorrectionCapability;
        }

        private void Check167139QuadraticResidueInformationBitsCombination(ref StringBuilder informationInformationBitsToolTip)
        {
            if (!_16_7_139_QuadraticResidue.Checks.InformationPartLength(ref _TextBoxInformationBitsText))//Lengtg Check
            {
                TextBoxInformationBitsBorderBrush = "Firebrick";
                ButtonInformationInformationBitsTextColor = "Firebrick";
                informationInformationBitsToolTip.AppendLine("* The \"" + LableValueInformation + "\" field length must be 7.");
                TextBoxCodeCombinationText = string.Empty;
            }

            if (!ChecksGeneral.Checks.BinaryFormat(ref _TextBoxInformationBitsText))//String Format Check
            {
                TextBoxInformationBitsBorderBrush = "Firebrick";
                ButtonInformationInformationBitsTextColor = "Firebrick";
                informationInformationBitsToolTip.AppendLine("* The \"" + LableValueInformation + "\" field contains a non-binary symbol.");
            }
        }

        private void Check167139QuadraticResidueCodeWord(ref StringBuilder codeCombinationToolTip)
        {
            if (!_16_7_139_QuadraticResidue.Checks.CodeWordLength(ref _TextBoxCodeCombinationText))//Lengtg Check
            {
                TextBoxCodeCombinationBorderBrush = "Firebrick";
                ButtonInformationCodeCombinationTextColor = "Firebrick";
                codeCombinationToolTip.AppendLine("* The \"" + LableValueCodeCombination + "\" field length must be 16.");
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

        private void Encode167139QuadraticResidue()
        {
            TextBoxInformationBitsBorderBrush = "DeepSkyBlue";
            bool[] informationBits = Converter.BinaryStringToBoolArray.Convert(ref _TextBoxInformationBitsText);
            bool[] codeCombination = _16_7_139_QuadraticResidue.Code.Encode(ref informationBits);
            TextBoxCodeCombinationText = Converter.BoolArrayToBinaryString.Convert(ref codeCombination);
        }

        private void Decode167139QuadraticResidue()
        {
            bool[] codeWord = Converter.BinaryStringToBoolArray.Convert(ref _TextBoxCodeCombinationText);
            bool[] errors = new bool[16];
            if (_16_7_139_QuadraticResidue.Decode.IsValidCombination(ref codeWord))// No errors
            {
                bool[] infornationPart = _16_7_139_QuadraticResidue.Parts.SelectTheInformationPartFromTheCodeWord(ref codeWord);
                TextBoxInformationBitsText = Converter.BoolArrayToBinaryString.Convert(ref infornationPart);
                CreateErrorBitsText167139QuadraticResidue(ref codeWord, ref errors);
                return;
            }// No errors
            bool[] syndrom = _16_7_139_QuadraticResidue.Decode.CalculateSindrom(ref codeWord);
            if (_16_7_139_QuadraticResidue.SingleError.Check(ref syndrom, ref errors))// Single error
            {
                CreateErrorBitsText167139QuadraticResidue(ref codeWord, ref errors);
                return;
            }// Single error
            if (_16_7_139_QuadraticResidue.DoubleError.Check(ref syndrom, ref errors))// Double error
            {
                CreateErrorBitsText167139QuadraticResidue(ref codeWord, ref errors);
                return;
            }// Double error
            Converter.InvertBoolArrayValues.Execute(ref errors);
            CreateErrorBitsText167139QuadraticResidue(ref codeWord, ref errors);
        }

        private void CreateErrorBitsText167139QuadraticResidue(ref bool[] codeWord, ref bool[] errors)
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

            TextBoxInformationBitsText = TextBlockLetter0Text + TextBlockLetter1Text + TextBlockLetter2Text + TextBlockLetter3Text +
                                         TextBlockLetter4Text + TextBlockLetter5Text + TextBlockLetter6Text;

        }


    }
}
