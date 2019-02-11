using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;

namespace StartupCode_PrintSticker
{
internal static class _FN
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
internal static readonly Regex regEtik_15;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
internal static readonly Regex regImp_29;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
internal static readonly Regex regBar_39;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
internal static readonly Regex regAbc_40;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
internal static readonly Regex regLine_41;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
internal static readonly string libPath_42;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
internal static readonly Encoding enc_44;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
[CompilerGenerated]
////[DebuggerNonUserCode]
internal static int init_;

	static _FN()
{
    Regex regEtik = regEtik_15 = new Regex("PP010,125:DIR1:AN1:FT\"Swiss 721 Bold BT\",18,00:PT\"(.*)\"\r" + "PP010,090:DIR1:AN1:FT\"Swiss 721 BT\",10,00:PT\"(.*)\"\r" + "PP010,062:DIR1:AN1:FT\"Swiss 721 BT\",10,00:PT\"(.*)\"\r" + "PP010,034:DIR1:AN1:FT\"Swiss 721 BT\",10,00:PT\"(.*)\"\r" + "PP010,006:DIR1:AN1:FT\"Swiss 721 BT\",10,00:PT\"(.*)\"\r" + "PP065,010:AN1:DIR4:PL110,4\r" + "PP085,080:DIR1:AN1:FT\"Swiss 721 BT\",13,00:PT\"(.*)\"\r" + "PP185,080:DIR1:AN1:FT\"Swiss 721 BT\",13,00:PT\"(.*)\"\r" + "PP085,032:DIR1:AN1:FT\"Swiss 721 BT\",13,00:PT\"(.*)\"\r" + "PP215,032:DIR1:AN1:FT\"Swiss 721 BT\",13,00:PT\"(.*)\"\r" + "PP330,032:DIR1:AN1:FT\"Swiss 721 BT\",13,00:PT\"(.*)\"\r" + "PP525,080:DIR1:AN1:FT\"Swiss 721 BT\",12,00:PT\"(.*)\"\r" + "PP085,000:DIR1:AN1:FT\"Swiss 721 BT\",08,00:PT\"(.*)\"\r" + "PP500,032:DIR1:AN1:FT\"Swiss 721 BT\",09,00:PT\"(.*)\"\r");
    Regex regImp = regImp_29 = new Regex("PP010,120:DIR1:AN1:FT\"Swiss 721 Bold BT\",18,00:PT\"(.*)\"\r" + "PP010,096:DIR1:AN1:FT\"Swiss 721 BT\",12,00:PT\"(.*)\"\r" + "PP010,076:DIR1:AN1:FT\"Swiss 721 BT\",8,00:PT\"(.*)\"\r" + "PP320,090:DIR1:AN1:FT\"Swiss 721 BT\",14,00:PT\"(.*)\"\r" + "PP320,002:DIR1:AN1:FT\"Swiss 721 BT\",14,00:PT\"(.*)\"\r" + "PP320,060:DIR1:AN1:FT\"Swiss 721 BT\",14,00:PT\"(.*)\"\r" + "PP490,060:DIR1:AN1:FT\"Swiss 721 BT\",14,00:PT\"(.*)\"\r" + "PP490,032:DIR1:AN1:FT\"Swiss 721 BT\",14,00:PT\"(.*)\"\r" + "PP490,005:DIR1:AN1:FT\"Swiss 721 BT\",8,00:PT\"(.*)\"\r" + "PP320,040:DIR1:AN1:FT\"Swiss 721 BT\",8,00:PT\"(.*)\"\r");
    Regex regBar = regBar_39 = new Regex(":PB\"(\\d*)\"\\:PF");
    Regex regAbc = regAbc_40 = new Regex("PP(\\d*),(\\d*):DIR(\\d):AN.:FT\"Swiss 721 BT\",(\\d*),00:PT\"(.*?)\"");
    Regex regLine = regLine_41 = new Regex("PP(\\d*),(\\d*):AN1:DIR(\\d):PL(\\d*),(\\d)");
    string location = Assembly.GetExecutingAssembly().Location;
    string path = location;
    string libPath = libPath_42 = Path.GetDirectoryName(path);
    Encoding enc = enc_44 = Encoding.GetEncoding(1251);
}
}

}