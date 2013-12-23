using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace AUTOPARTS.DCAT.VALIDATION
{
    public  class VALIDITY
    {
        public static int StringValidation(String pValue, char pValidity, String pTxtType, String pLtrCase, int pMinLen, int pMaxLen)
        {
            bool bIsAlphaChar = false;
            bool bIsNumericChar = false;
            bool bIsSpecialChar = false;
            bool bIsUpperCase = false;
            bool bIsLowerCase = false;
            bool bIsEmpty = false;
            bool bContinue = false;
            if ((pValidity == 'M' || pValidity == 'O') && (pTxtType.Equals("A") || pTxtType.Equals("N") || pTxtType.Equals("AN") || pTxtType.Equals("S") || pTxtType.Equals("SA") || pTxtType.Equals("SA") || pTxtType.Equals("SN") || pTxtType.Equals("SAN")) && (pLtrCase.Equals("L") || pLtrCase.Equals("U") || pLtrCase.Equals("LU")))
            {
                String sMinLen = (pMinLen).ToString();
                String sMaxLen = (pMaxLen).ToString();

                Regex pattern = new Regex("[0-9]*");


                bool s = pattern.IsMatch(sMinLen);
                bool b = pattern.IsMatch(sMaxLen);

                if (s==b)
                {
                    bContinue = true;
                }

                //if (sMinLen.matches("[0-9]*") && sMaxLen.matches("[0-9]*"))
                //    bContinue = true;
            }
            if (bContinue)
            {
                if (pValue.Equals(""))
                    bIsEmpty = true;
                else
                    bIsEmpty = false;
                if (pValidity == 'M' && bIsEmpty)
                    return 2;
                if (!bIsEmpty)
                {
                    for (int iCount = 0; iCount < pValue.Length; iCount++)
                    {
                        char cCharAt = pValue.ElementAt(iCount);
                        int iAscii = cCharAt;
                        if (iAscii >= 65 && iAscii <= 90)
                        {
                            bIsAlphaChar = true;
                            bIsUpperCase = true;
                        }
                        if (iAscii >= 97 && iAscii <= 122)
                        {
                            bIsAlphaChar = true;
                            bIsLowerCase = true;
                        }
                        if (iAscii == 32 || iAscii == 64)
                            bIsAlphaChar = true;
                        if (iAscii == 46)
                            bIsAlphaChar = true;
                        if (iAscii >= 33 && iAscii <= 47 || iAscii >= 91 && iAscii <= 96 || iAscii >= 123 && iAscii <= 126)
                            bIsSpecialChar = true;
                        if (iAscii >= 48 && iAscii <= 57)
                            bIsNumericChar = true;
                    }

                    if (pTxtType.Equals("A"))
                    {
                        if (bIsNumericChar)
                            return 4;
                        if (bIsSpecialChar)
                            return 5;
                        if (pLtrCase.Equals("U"))
                        {
                            if (bIsLowerCase)
                                return 6;
                        }
                        else
                            if (pLtrCase.Equals("L") && bIsUpperCase)
                                return 7;
                    }
                    else
                        if (pTxtType.Equals("N"))
                        {
                            if (bIsAlphaChar)
                                return 3;
                            if (bIsSpecialChar)
                                return 5;
                        }
                        else
                            if (pTxtType.Equals("AN"))
                            {
                                if (bIsSpecialChar)
                                    return 5;
                                if (pLtrCase.Equals("U"))
                                {
                                    if (bIsLowerCase)
                                        return 6;
                                }
                                else
                                    if (pLtrCase.Equals("L") && bIsUpperCase)
                                        return 7;
                            }
                            else
                                if (pTxtType.Equals("S"))
                                {
                                    if (bIsAlphaChar)
                                        return 3;
                                    if (bIsNumericChar)
                                        return 4;
                                }
                                else
                                    if (pTxtType.Equals("SA"))
                                    {
                                        if (bIsNumericChar)
                                            return 4;
                                        if (pLtrCase.Equals("U"))
                                        {
                                            if (bIsLowerCase)
                                                return 6;
                                        }
                                        else
                                            if (pLtrCase.Equals("L") && bIsUpperCase)
                                                return 7;
                                    }
                                    else
                                        if (pTxtType.Equals("SN"))
                                        {
                                            if (bIsAlphaChar)
                                                return 3;
                                        }
                                        else
                                            if (pTxtType.Equals("SAN"))
                                                if (pLtrCase.Equals("U"))
                                                {
                                                    if (bIsLowerCase)
                                                        return 6;
                                                }
                                                else
                                                    if (pLtrCase.Equals("L") && bIsUpperCase)
                                                        return 7;
                    if (pValue.Length < pMinLen)
                        return 8;
                    if (pValue.Length > pMaxLen)
                        return 9;
                }
                return 0;
            }
            else
            {
                return 1;
            }
        }


        public static string StringValidationMsg(int validityNo) 
        {
            string msgText = "Value is " + " [Error] " + " Code ";

            switch (validityNo)
            {
                case 1:
                    msgText = "Entered parameter names are invalid Please check ";
                    break;
                case 2:
                    msgText = "Entered parameter names are invalid Please check ";
                    break;
                case 3:
                    msgText = "Entered parameter names are invalid Please check ";
                    break;
                case 4:
                    msgText = "Entered parameter names are invalid Please check ";
                    break;
                case 5:
                    msgText = "Entered parameter names are invalid Please check ";
                    break;
                case 6:
                    msgText = "Entered parameter names are invalid Please check ";
                    break;
                case 7:
                    msgText = "Entered parameter names are invalid Please check ";
                    break;
                case 8:
                    msgText = "Entered parameter names are invalid Please check ";
                    break;
                case 9:
                    msgText = "Entered parameter names are invalid Please check ";
                    break;
                default:
                    break;
            }


            return msgText;        
        }

    }
}
