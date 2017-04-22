using NeptusSystemModules.Modules.ControlesNeptus.UserControls.Endereco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeptusSystemModules.Modules.ControlesNeptus.Util
{
    public class Util
    {
        public string FormatString(string mascara, string valor)
        {
            string novoValor = string.Empty;
            int posicao = 0;
            for (int i = 0; mascara.Length > i; i++)
            {
                if (mascara[i] == '#')
                {
                    if (valor.Length > posicao)
                    {
                        novoValor = novoValor + valor[posicao];
                        posicao++;
                    }
                    else
                        break;
                }
                else
                {
                    if (valor.Length > posicao)
                        novoValor = novoValor + mascara[i];
                    else
                        break;
                }
            }
            return novoValor;
        }

        public UF Retorna_UF(string suf)
        {
            switch (suf)
            {
                case "AC":
                    return UF.AC;
                case "AL":
                    return UF.AL;
                case "AM":
                    return UF.AM;
                case "AP":
                    return UF.AP;
                case "BA":
                    return UF.BA;
                case "CE":
                    return UF.CE;
                case "DF":
                    return UF.DF;
                case "ES":
                    return UF.ES;
                case "GO":
                    return UF.GO;
                case "MA":
                    return UF.MA;
                case "MG":
                    return UF.MG;
                case "MS":
                    return UF.MS;
                case "MT":
                    return UF.MT;
                case "PA":
                    return UF.PA;
                case "PB":
                    return UF.PB;
                case "PE":
                    return UF.PE;
                case "PI":
                    return UF.PI;
                case "PR":
                    return UF.PR;
                case "RJ":
                    return UF.RJ;
                case "RN":
                    return UF.RN;
                case "RO":
                    return UF.RO;
                case "RR":
                    return UF.RR;
                case "RS":
                    return UF.RS;
                case "SC":
                    return UF.SC;
                case "SE":
                    return UF.SE;
                case "SP":
                    return UF.SP;
                case "TO":
                    return UF.TO;
                default:
                    return UF.SP;
            }
        }
    }
}
