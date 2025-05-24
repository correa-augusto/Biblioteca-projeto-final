using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

//AUGUSTO DOS SANTOS CORRÊA
namespace Biblioteca
{
    internal class ClassEnum
    {

        public enum EnumFuncionarioCargo
        {
            [Description("Gerente")]
            Gerente = 0,
            [Description("Atendente")]
            Atendente = 1,
            [Description("Caixa")]
            Caixa = 2,
            [Description("Estagiário")]
            Estagiário = 3,
        }

        public enum EnumExemplarStatus
        {
            [Description("Pendente")]
            Pendente = 1,
            [Description("Lido")]
            Lido = 2,
            [Description("Emprestado")]
            Emprestado = 3,
            [Description("Devolvido")]
            Devolvido = 4,
            [Description("Perdido")]
            Perdido = 5,
        }

        public enum EnumGenericoTipo
        {
            [Description("Jornais")]
            Jornais = 1,
            [Description("Calendários e Agendas")]
            CalendariosAgendas = 2,
            [Description("Mapas e Atlas")]
            MapasAtlas = 3,
            [Description("Postais e Cartões de Saudação")]
            PostaisCartoesSaudacao = 4,
            [Description("Papéis de Presente e Material de Embalagem")]
            PapeisPresenteMaterialEmbalagem = 5,
            [Description("DVDs e Blu-rays")]
            DVDsBlurays = 6,
            [Description("CDs e Vinis")]
            CDsVinis = 7,
            [Description("K7")]
            K7 = 8,
            [Description("Jogos de Tabuleiro e Quebra-Cabeças")]
            JogosTabuleiroQuebraCabecas = 9,
            [Description("Material de Papelaria e Escritório")]
            MaterialPapelariaEscritorio = 10,
            [Description("Produtos Relacionados à Cultura Pop")]
            ProdutosRelacionadosCulturaPop = 11,
            [Description("Audiolivros")]
            Audiolivros = 12,
            [Description("Outros")]
            Outros = 13,
        }
    }


}
public static class EnumExtensions
{
    public static string GetDescription(this Enum GenericEnum)
    {
        Type genericEnumType = GenericEnum.GetType();
        MemberInfo[] memberInfo = genericEnumType.GetMember(GenericEnum.ToString());
        if ((memberInfo != null && memberInfo.Length > 0))
        {
            var _Attribs = memberInfo[0].GetCustomAttributes(typeof(DescriptionAttribute), false);
            if ((_Attribs != null && _Attribs.Count() > 0))
            {
                return ((DescriptionAttribute)_Attribs.ElementAt(0)).Description;
            }
        }
        return GenericEnum.ToString();
    }
}


