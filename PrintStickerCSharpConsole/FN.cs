using StartupCode_PrintSticker;
using Microsoft.FSharp.Collections;
using Microsoft.FSharp.Core;
using Microsoft.FSharp.Core.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Printing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media.Imaging;
using Zen.Barcode;

namespace PrintStickerCSharpConsole
{
    [CompilationMapping(SourceConstructFlags.Module)]

    public static class FN
    {
        [Serializable]
        internal sealed class EtiketParse_71_1 : FSharpFunc<Unit, IEnumerator>
	{
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
        [CompilerGenerated]
        //[DebuggerNonUserCode]
        public GroupCollection inputSequence;

        [CompilerGenerated]
        //[DebuggerNonUserCode]
        internal EtiketParse_71_1(GroupCollection inputSequence)
		{
			this.inputSequence = inputSequence;
		}

    public override IEnumerator Invoke(Unit unitVar)
    {
        return inputSequence.GetEnumerator();
    }
}

[Serializable]
internal sealed class EtiketParse_71_2 : FSharpFunc<IEnumerator, bool>
	{
		[CompilerGenerated]
//[DebuggerNonUserCode]
internal EtiketParse_71_2()
		{
		}

		public override bool Invoke(IEnumerator enumerator)
{
    return enumerator.MoveNext();
}
	}

	[Serializable]
internal sealed class EtiketParse_71_3 : FSharpFunc<IEnumerator, Group>
	{
		[CompilerGenerated]
//[DebuggerNonUserCode]
internal EtiketParse_71_3()
		{
		}

		public override Group Invoke(IEnumerator enumerator)
{
    return (Group)enumerator.Current;
}
	}

	[Serializable]
[StructLayout(LayoutKind.Auto, CharSet = CharSet.Auto)]
[CompilationMapping(SourceConstructFlags.Closure)]
internal sealed class EtiketParse_71 : GeneratedSequenceBase<string>
	{
		//public Match m = _m;
            public Match m;

            //public Group g = g;
            public Group g;

            [DebuggerBrowsable(DebuggerBrowsableState.Never)]
            [CompilerGenerated]
            //[DebuggerNonUserCode]
            public IEnumerator<Group> @enum;//= @enum;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        [CompilerGenerated]
        //[DebuggerNonUserCode]
        public int pc/* = pc*/;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        [CompilerGenerated]
        //[DebuggerNonUserCode]
        public string current /*= current*/;

            public override bool CheckClose
            {
                get
                {
                    switch (pc)
                    {
                        default:
                            return true;
                        case 1:
                            return true;
                        case 0:
                        case 3:
                            return false;
                    }
                }
                }

            public override string LastGenerated
            {
                get
                {
                    return current;
                }
            }

            public EtiketParse_71(Match _m, Group _g, IEnumerator<Group> @enum_, int _pc, string _current)
		{
                m = _m;
                g = _g;
                @enum = @enum_;
                pc = _pc;
                current = _current;
            }

		public override int GenerateNext(ref IEnumerable<string> next)
{
    switch (pc)
    {
        default:
            {
                GroupCollection groups = m.Groups;
                @enum = Microsoft.FSharp.Core.CompilerServices.RuntimeHelpers.EnumerateFromFunctions(new EtiketParse_71_1(groups), new EtiketParse_71_2(), new EtiketParse_71_3()).GetEnumerator();
                pc = 1;
                goto IL_0064;
            }
        case 2:
            g = null;
            goto IL_0064;
        case 1:
            pc = 3;
            LanguagePrimitives.IntrinsicFunctions.Dispose(@enum);
            @enum = null;
            pc = 3;
            break;
        case 3:
            break;
            IL_0064:
            if (@enum.MoveNext())
            {
                g = @enum.Current;
                pc = 2;
                current = g.Value;
                return 1;
            }
            goto case 1;
    }
    current = null;
    return 0;
}

public override void Close()
{
    Exception ex = null;
    while (true)
    {
        switch (pc)
        {
            case 3:
                if (ex != null)
                {
                    throw ex;
                }
                return;
        }
        Unit unit;
        try
        {
            switch (pc)
            {
                default:
                    pc = 3;
                    LanguagePrimitives.IntrinsicFunctions.Dispose(@enum);
                    break;
                case 0:
                case 3:
                    break;
            }
            pc = 3;
            current = null;
            unit = null;
        }
        catch (Exception e)
        {
            //Exception e = (Exception)obj;
            ex = e;
            unit = null;
        }
    }
}

//public override bool get_CheckClose()
//{
//    switch (pc)
//    {
//        default:
//            return true;
//        case 1:
//            return true;
//        case 0:
//        case 3:
//            return false;
//    }
//}

[CompilerGenerated]
//[DebuggerNonUserCode]
//public override string get_LastGenerated()
//{
//    return current;
//}

//[CompilerGenerated]
//[DebuggerNonUserCode]
public override IEnumerator<string> GetFreshEnumerator()
{
    return new EtiketParse_71(m, null, null, 0, null);
}
	}

	[Serializable]
internal sealed class EtiketParse_82_4 : FSharpFunc<Match, Unit>
	{
		public Graphics gr;

public Pen pen;

public Pen penB;

[CompilerGenerated]
//[DebuggerNonUserCode]
internal EtiketParse_82_4(Graphics gr, Pen pen, Pen penB)
		{

            this.gr = gr;

            this.pen = pen;

            this.penB = penB;

        }

public override Unit Invoke(Match m)
{
    int x3 = LanguagePrimitives.ParseInt32(m.Groups[1].Value) - 620;
    int y3 = 170 - (LanguagePrimitives.ParseInt32(m.Groups[2].Value) - 5);
    int delta = LanguagePrimitives.ParseInt32(m.Groups[4].Value);
    string value = m.Groups[5].Value;
    string text = value;
    string a = text;
    Pen p = (!string.Equals(a, "4")) ? penB : pen;
    string value2 = m.Groups[3].Value;
    string text2 = value2;
    string a2 = text2;
    Tuple<int, int> tuple = string.Equals(a2, "1") ? new Tuple<int, int>(x3 + delta, y3) : (string.Equals(a2, "2") ? new Tuple<int, int>(x3, y3 + delta) : ((!string.Equals(a2, "3")) ? new Tuple<int, int>(x3, y3 - delta) : new Tuple<int, int>(x3 - delta, y3)));
    int y2 = tuple.Item2;
    int x2 = tuple.Item1;
    gr.DrawLine(p, x3, y3, x2, y2);
    return null;
}
	}

	[Serializable]
internal sealed class EtiketParse_81_6 : FSharpFunc<Unit, IEnumerator>
	{
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
[CompilerGenerated]
//[DebuggerNonUserCode]
public MatchCollection inputSequence;

[CompilerGenerated]
//[DebuggerNonUserCode]
internal EtiketParse_81_6(MatchCollection inputSequence)
		{

            this.inputSequence = inputSequence;

        }

public override IEnumerator Invoke(Unit unitVar)
{
    return inputSequence.GetEnumerator();
}
	}

	[Serializable]
internal sealed class EtiketParse_81_7 : FSharpFunc<IEnumerator, bool>
	{
		[CompilerGenerated]
//[DebuggerNonUserCode]
internal EtiketParse_81_7()
		{
		}

		public override bool Invoke(IEnumerator enumerator)
{
    return enumerator.MoveNext();
}
	}

	[Serializable]
internal sealed class EtiketParse_81_8 : FSharpFunc<IEnumerator, Match>
	{
		[CompilerGenerated]
//[DebuggerNonUserCode]
internal EtiketParse_81_8()
		{
		}

		public override Match Invoke(IEnumerator enumerator)
{
    return (Match)enumerator.Current;
}
	}

	[Serializable]
[StructLayout(LayoutKind.Auto, CharSet = CharSet.Auto)]
[CompilationMapping(SourceConstructFlags.Closure)]
internal sealed class EtiketParse_81_5 : GeneratedSequenceBase<Match>
	{
		public string txt/* = txt*/;

public Match m /*= m*/;

[DebuggerBrowsable(DebuggerBrowsableState.Never)]
[CompilerGenerated]
//[DebuggerNonUserCode]
public IEnumerator<Match> @enum /*= @enum*/;

[DebuggerBrowsable(DebuggerBrowsableState.Never)]
[CompilerGenerated]
//[DebuggerNonUserCode]
public int pc /*= pc*/;

[DebuggerBrowsable(DebuggerBrowsableState.Never)]
[CompilerGenerated]
//[DebuggerNonUserCode]
public Match current /*= current*/;

            public override bool CheckClose
            {
                get
                {
                    switch (pc)
                    {
                        default:
                            return true;
                        case 1:
                            return true;
                        case 0:
                        case 3:
                            return false;
                    }
                }
            }

            public override Match LastGenerated
            {
                get
                {
                    return current;
                }
            }

            public EtiketParse_81_5(string _txt, Match _m, IEnumerator<Match> @enum_, int _pc, Match _current)
		{
                txt = _txt;
                m = _m;
                @enum = @enum_;
                pc = _pc;
                current = _current;
            }

		public override int GenerateNext(ref IEnumerable<Match> next)
{
    switch (pc)
    {
        default:
            {
                MatchCollection inputSequence = regLine.Matches(txt);
                @enum = Microsoft.FSharp.Core.CompilerServices.RuntimeHelpers.EnumerateFromFunctions(new EtiketParse_81_6(inputSequence), new EtiketParse_81_7(), new EtiketParse_81_8()).GetEnumerator();
                pc = 1;
                goto IL_0069;
            }
        case 2:
            m = null;
            goto IL_0069;
        case 1:
            pc = 3;
            LanguagePrimitives.IntrinsicFunctions.Dispose(@enum);
            @enum = null;
            pc = 3;
            break;
        case 3:
            break;
            IL_0069:
            if (@enum.MoveNext())
            {
                m = @enum.Current;
                pc = 2;
                current = m;
                return 1;
            }
            goto case 1;
    }
    current = null;
    return 0;
}

public override void Close()
{
    Exception ex = null;
    while (true)
    {
        switch (pc)
        {
            case 3:
                if (ex != null)
                {
                    throw ex;
                }
                return;
        }
        Unit unit;
        try
        {
            switch (pc)
            {
                default:
                    pc = 3;
                    LanguagePrimitives.IntrinsicFunctions.Dispose(@enum);
                    break;
                case 0:
                case 3:
                    break;
            }
            pc = 3;
            current = null;
            unit = null;
        }
        catch (Exception e)
        {
            //Exception e = (Exception)obj;
            ex = e;
            unit = null;
        }
    }
}

//public override bool get_CheckClose()
//{
//    switch (pc)
//    {
//        default:
//            return true;
//        case 1:
//            return true;
//        case 0:
//        case 3:
//            return false;
//    }
//}

//[CompilerGenerated]
////[DebuggerNonUserCode]
//public override Match get_LastGenerated()
//{
//    return current;
//}

[CompilerGenerated]
//[DebuggerNonUserCode]
public override IEnumerator<Match> GetFreshEnumerator()
{
    return new EtiketParse_81_5(txt, null, null, 0, null);
}
	}

	[Serializable]
internal sealed class EtiketParse_99_9 : FSharpFunc<GroupCollection, Unit>
	{
		public Graphics gr;

[CompilerGenerated]
//[DebuggerNonUserCode]
internal EtiketParse_99_9(Graphics gr)
		{

            this.gr = gr;

        }

public override Unit Invoke(GroupCollection g)
{
    float x2 = float.Parse(g[1].Value?.Replace("_", ""), NumberStyles.Float, CultureInfo.InvariantCulture) - 620f - 20f;
    float y = 170f - (float.Parse(g[2].Value?.Replace("_", ""), NumberStyles.Float, CultureInfo.InvariantCulture) - 5f);
    Font fnt = new Font("consola", 20f);
    Tuple<string, string> tuple = new Tuple<string, string>(g[5].Value, g[3].Value);
    Tuple<string, string> tuple2 = tuple;
    Tuple<string, string> tuple3 = tuple2;
    string x;
    if (!string.Equals(tuple3.Item1, "V"))
    {
        x = tuple3.Item1;
        goto IL_0164;
    }
    object obj;
    if (!string.Equals(tuple3.Item2, "1"))
    {
        if (!string.Equals(tuple3.Item2, "2"))
        {
            if (!string.Equals(tuple3.Item2, "3"))
            {
                if (!string.Equals(tuple3.Item2, "4"))
                {
                    x = tuple3.Item1;
                    goto IL_0164;
                }
                obj = ">";
            }
            else
            {
                obj = "^";
            }
        }
        else
        {
            obj = "<";
        }
    }
    else
    {
        obj = "V";
    }
    goto IL_0167;
    IL_0167:
    string v = (string)obj;
    gr.DrawString(v, fnt, Brushes.Black, new PointF(x2, y));
    return null;
    IL_0164:
    obj = x;
    goto IL_0167;
}
	}

	[Serializable]
internal sealed class EtiketParse_98_10 : FSharpFunc<GroupCollection, bool>
	{
		[CompilerGenerated]
//[DebuggerNonUserCode]
internal EtiketParse_98_10()
		{
		}

		public override bool Invoke(GroupCollection g)
{
    return LanguagePrimitives.ParseInt32(g[1].Value) > 619;
}
	}

	[Serializable]
internal sealed class EtiketParse_97_12 : FSharpFunc<Unit, IEnumerator>
	{
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
[CompilerGenerated]
//[DebuggerNonUserCode]
public MatchCollection inputSequence;

[CompilerGenerated]
//[DebuggerNonUserCode]
internal EtiketParse_97_12(MatchCollection inputSequence)
		{

            this.inputSequence = inputSequence;

        }

public override IEnumerator Invoke(Unit unitVar)
{
    return inputSequence.GetEnumerator();
}
	}

	[Serializable]
internal sealed class EtiketParse_97_13 : FSharpFunc<IEnumerator, bool>
	{
		[CompilerGenerated]
//[DebuggerNonUserCode]
internal EtiketParse_97_13()
		{
		}

		public override bool Invoke(IEnumerator enumerator)
{
    return enumerator.MoveNext();
}
	}

	[Serializable]
internal sealed class EtiketParse_97_14 : FSharpFunc<IEnumerator, Match>
	{
		[CompilerGenerated]
//[DebuggerNonUserCode]
internal EtiketParse_97_14()
		{
		}

		public override Match Invoke(IEnumerator enumerator)
{
    return (Match)enumerator.Current;
}
	}

	[Serializable]
[StructLayout(LayoutKind.Auto, CharSet = CharSet.Auto)]
[CompilationMapping(SourceConstructFlags.Closure)]
internal sealed class EtiketParse_97_11 : GeneratedSequenceBase<GroupCollection>
	{
		public string txt /*= txt*/;

public Match m /*= m*/;

[DebuggerBrowsable(DebuggerBrowsableState.Never)]
[CompilerGenerated]
//[DebuggerNonUserCode]
public IEnumerator<Match> @enum /*= @enum*/;

[DebuggerBrowsable(DebuggerBrowsableState.Never)]
[CompilerGenerated]
//[DebuggerNonUserCode]
public int pc /*= pc*/;

[DebuggerBrowsable(DebuggerBrowsableState.Never)]
[CompilerGenerated]
//[DebuggerNonUserCode]
public GroupCollection current /*= current*/;

            public override bool CheckClose
            {
                get
                {
                    switch (pc)
                    {
                        default:
                            return true;
                        case 1:
                            return true;
                        case 0:
                        case 3:
                            return false;
                    }
                }
            }

            public override GroupCollection LastGenerated
            {
                get
                {
                    return current;
                }
            }

            public EtiketParse_97_11(string _txt, Match _m, IEnumerator<Match> @enum_, int _pc, GroupCollection _current)
		{
                txt = _txt;
                m = _m;
                @enum = @enum_;
                pc = _pc;
                current = _current;
            }

		public override int GenerateNext(ref IEnumerable<GroupCollection> next)
{
    switch (pc)
    {
        default:
            {
                MatchCollection inputSequence = regAbc.Matches(txt);
                @enum = Microsoft.FSharp.Core.CompilerServices.RuntimeHelpers.EnumerateFromFunctions(new EtiketParse_97_12(inputSequence), new EtiketParse_97_13(), new EtiketParse_97_14()).GetEnumerator();
                pc = 1;
                goto IL_0069;
            }
        case 2:
            m = null;
            goto IL_0069;
        case 1:
            pc = 3;
            LanguagePrimitives.IntrinsicFunctions.Dispose(@enum);
            @enum = null;
            pc = 3;
            break;
        case 3:
            break;
            IL_0069:
            if (@enum.MoveNext())
            {
                m = @enum.Current;
                pc = 2;
                current = m.Groups;
                return 1;
            }
            goto case 1;
    }
    current = null;
    return 0;
}

public override void Close()
{
    Exception ex = null;
    while (true)
    {
        switch (pc)
        {
            case 3:
                if (ex != null)
                {
                    throw ex;
                }
                return;
        }
        Unit unit;
        try
        {
            switch (pc)
            {
                default:
                    pc = 3;
                    LanguagePrimitives.IntrinsicFunctions.Dispose(@enum);
                    break;
                case 0:
                case 3:
                    break;
            }
            pc = 3;
            current = null;
            unit = null;
        }
        catch (Exception e)
        {
            //Exception e = (Exception)obj;
            ex = e;
            unit = null;
        }
    }
}

//public override bool get_CheckClose()
//{
//    switch (pc)
//    {
//        default:
//            return true;
//        case 1:
//            return true;
//        case 0:
//        case 3:
//            return false;
//    }
//}

//[CompilerGenerated]
////[DebuggerNonUserCode]
//public override GroupCollection get_LastGenerated()
//{
//    return current;
//}

[CompilerGenerated]
//[DebuggerNonUserCode]
public override IEnumerator<GroupCollection> GetFreshEnumerator()
{
    return new EtiketParse_97_11(txt, null, null, 0, null);
}
	}

	[Serializable]
internal sealed class EtiketParse_109_16 : FSharpFunc<Unit, IEnumerator>
	{
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
[CompilerGenerated]
//[DebuggerNonUserCode]
public GroupCollection inputSequence;

[CompilerGenerated]
//[DebuggerNonUserCode]
internal EtiketParse_109_16(GroupCollection inputSequence)
		{

            this.inputSequence = inputSequence;

        }

public override IEnumerator Invoke(Unit unitVar)
{
    return inputSequence.GetEnumerator();
}
	}

	[Serializable]
internal sealed class EtiketParse_109_17 : FSharpFunc<IEnumerator, bool>
	{
		[CompilerGenerated]
//[DebuggerNonUserCode]
internal EtiketParse_109_17()
		{
		}

		public override bool Invoke(IEnumerator enumerator)
{
    return enumerator.MoveNext();
}
	}

	[Serializable]
internal sealed class EtiketParse_109_18 : FSharpFunc<IEnumerator, Group>
	{
		[CompilerGenerated]
//[DebuggerNonUserCode]
internal EtiketParse_109_18()
		{
		}

		public override Group Invoke(IEnumerator enumerator)
{
    return (Group)enumerator.Current;
}
	}

	[Serializable]
[StructLayout(LayoutKind.Auto, CharSet = CharSet.Auto)]
[CompilationMapping(SourceConstructFlags.Closure)]
internal sealed class EtiketParse_109_15 : GeneratedSequenceBase<string>
	{
		public Match m /*= m*/;

public Group g /*= g*/;

[DebuggerBrowsable(DebuggerBrowsableState.Never)]
[CompilerGenerated]
//[DebuggerNonUserCode]
public IEnumerator<Group> @enum /*= @enum*/;

[DebuggerBrowsable(DebuggerBrowsableState.Never)]
[CompilerGenerated]
//[DebuggerNonUserCode]
public int pc /*= pc*/;

[DebuggerBrowsable(DebuggerBrowsableState.Never)]
[CompilerGenerated]
//[DebuggerNonUserCode]
public string current /*= current*/;

            public override bool CheckClose
            {
                get
                {
                    switch (pc)
                    {
                        default:
                            return true;
                        case 1:
                            return true;
                        case 0:
                        case 3:
                            return false;
                    }
                }
            }

            public override string LastGenerated
            {
                get
                {
                    return current;
                }
            }

            public EtiketParse_109_15(Match _m, Group _g, IEnumerator<Group> @enum_, int _pc, string _current)
		{
                m = _m;
                g = _g;
                @enum = @enum_;
                pc = _pc;
                current = _current;
            }

		public override int GenerateNext(ref IEnumerable<string> next)
{
    switch (pc)
    {
        default:
            {
                GroupCollection groups = m.Groups;
                @enum = Microsoft.FSharp.Core.CompilerServices.RuntimeHelpers.EnumerateFromFunctions(new EtiketParse_109_16(groups), new EtiketParse_109_17(), new EtiketParse_109_18()).GetEnumerator();
                pc = 1;
                goto IL_0064;
            }
        case 2:
            g = null;
            goto IL_0064;
        case 1:
            pc = 3;
            LanguagePrimitives.IntrinsicFunctions.Dispose(@enum);
            @enum = null;
            pc = 3;
            break;
        case 3:
            break;
            IL_0064:
            if (@enum.MoveNext())
            {
                g = @enum.Current;
                pc = 2;
                current = g.Value;
                return 1;
            }
            goto case 1;
    }
    current = null;
    return 0;
}

public override void Close()
{
    Exception ex = null;
    while (true)
    {
        switch (pc)
        {
            case 3:
                if (ex != null)
                {
                    throw ex;
                }
                return;
        }
        Unit unit;
        try
        {
            switch (pc)
            {
                default:
                    pc = 3;
                    LanguagePrimitives.IntrinsicFunctions.Dispose(@enum);
                    break;
                case 0:
                case 3:
                    break;
            }
            pc = 3;
            current = null;
            unit = null;
        }
        catch (Exception e)
        {
            //Exception e = (Exception)obj;
            ex = e;
            unit = null;
        }
    }
}

//public override bool get_CheckClose()
//{
//    switch (pc)
//    {
//        default:
//            return true;
//        case 1:
//            return true;
//        case 0:
//        case 3:
//            return false;
//    }
//}

//[CompilerGenerated]
////[DebuggerNonUserCode]
//public override string get_LastGenerated()
//{
//    return current;
//}

[CompilerGenerated]
//[DebuggerNonUserCode]
public override IEnumerator<string> GetFreshEnumerator()
{
    return new EtiketParse_109_15(m, null, null, 0, null);
}
	}

	[Serializable]
internal sealed class PrintStickerFromMnf_121 : FSharpFunc<Tuple<string, string>, Unit>
	{
		public Window win;

[CompilerGenerated]
//[DebuggerNonUserCode]
internal PrintStickerFromMnf_121(Window win)
		{

            this.win = win;

        }

public override Unit Invoke(Tuple<string, string> tupledArg)
{
    string name = tupledArg.Item1;
    string vl = tupledArg.Item2;
    ((TextBlock)win.FindName(name)).Text = vl;
    return null;
}
	}

	[Serializable]
internal sealed class PrintStickerFromMnf_132_1 : FSharpFunc<Tuple<string, string>, Unit>
	{
		public Window win;

[CompilerGenerated]
//[DebuggerNonUserCode]
internal PrintStickerFromMnf_132_1(Window win)
		{

            this.win = win;

        }

public override Unit Invoke(Tuple<string, string> tupledArg)
{
    string name = tupledArg.Item1;
    string vl = tupledArg.Item2;
    ((TextBlock)win.FindName(name)).Text = vl;
    return null;
}
	}

	[CompilationMapping(SourceConstructFlags.Value)]
public static Regex regEtik
{
    get
    {
        return _FN.regEtik_15;
    }
}

[CompilationMapping(SourceConstructFlags.Value)]
public static Regex regImp
{
    get
    {
        return _FN.regImp_29;
    }
}

[CompilationMapping(SourceConstructFlags.Value)]
public static Regex regBar
{
    get
    {
        return _FN.regBar_39;
    }
}

[CompilationMapping(SourceConstructFlags.Value)]
public static Regex regAbc
{
    get
    {
        return _FN.regAbc_40;
    }
}

[CompilationMapping(SourceConstructFlags.Value)]
public static Regex regLine
{
    get
    {
        return _FN.regLine_41;
    }
}

[CompilationMapping(SourceConstructFlags.Value)]
public static string libPath
{
    get
    {
        return _FN.libPath_42;
    }
}

[CompilationMapping(SourceConstructFlags.Value)]
public static Encoding enc
{
    get
    {
        return _FN.enc_44;
    }
}

[CompilationArgumentCounts(new int[]
{
        1,
        0
})]
public static BitmapSource /*Bitmap.*/get_Source(Bitmap P_0)
{
    return Imaging.CreateBitmapSourceFromHBitmap(P_0.GetHbitmap(), IntPtr.Zero, Int32Rect.Empty, BitmapSizeOptions.FromWidthAndHeight(P_0.Width, P_0.Height));
}

public static void PrintGrid(Grid grid)
{
    PrintDialog pd = new PrintDialog();
    pd.PrintQueue = new LocalPrintServer().DefaultPrintQueue;
    System.Windows.Size size = new System.Windows.Size(pd.PrintableAreaWidth, pd.PrintableAreaHeight);
    grid.Measure(size);
    grid.Arrange(new Rect(new System.Windows.Point(0.0, 0.0), size));
    ((Window)grid.Parent).Show();
    Thread.Sleep(1000);
    pd.PrintVisual(grid, "Sticker");
}

public static FSharpOption<Tuple<FSharpOption<Bitmap>, string, FSharpList<Tuple<string, string>>>> EtiketParse(string path)
{
    string txt = File.ReadAllText(path, enc);
    Match match = regBar.Match(txt);
    Match match2 = match;
    Match match3 = match2;
    Match n = match3;
    if (n.Success)
    {
        Match m = match3;
        string barc = m.Groups[1].Value;
        Match match4 = regEtik.Match(txt);
        Match match5 = match4;
        Match match6 = match5;
        Match l = match6;
        if (l.Success)
        {
            Match k = match6;
            return FSharpOption<Tuple<FSharpOption<Bitmap>, string, FSharpList<Tuple<string, string>>>>.Some(new Tuple<FSharpOption<Bitmap>, string, FSharpList<Tuple<string, string>>>(null, barc, ListModule.Zip(FSharpList<string>.Cons("mark", FSharpList<string>.Cons("sht", FSharpList<string>.Cons("pp", FSharpList<string>.Cons("fn", FSharpList<string>.Cons("rh", FSharpList<string>.Cons("posgr", FSharpList<string>.Cons("sideAndSize", FSharpList<string>.Cons("strSteelCart", FSharpList<string>.Cons("car", FSharpList<string>.Cons("sp", FSharpList<string>.Cons("customername", FSharpList<string>.Cons("orderitemname", FSharpList<string>.Cons("mon_comm", FSharpList<string>.Empty))))))))))))), ListModule.Tail(SeqModule.ToList(new EtiketParse_71(k, null, null, 0, null))))));
        }
        Match match7 = regImp.Match(txt);
        Match match8 = match7;
        Match match9 = match8;
        Match j = match9;
        if (j.Success)
        {
            Match i = match9;
            Bitmap bmp = new Bitmap(170, 170);
            Graphics gr = Graphics.FromImage(bmp);
            Pen pen = new Pen(Color.Black, 2f);
            Pen penB = new Pen(Color.Black, 4f);
            ListModule.Iterate(new EtiketParse_82_4(gr, pen, penB), SeqModule.ToList(new EtiketParse_81_5(txt, null, null, 0, null)));
            ListModule.Iterate(new EtiketParse_99_9(gr), ListModule.Filter(new EtiketParse_98_10(), SeqModule.ToList(new EtiketParse_97_11(txt, null, null, 0, null))));
            return FSharpOption<Tuple<FSharpOption<Bitmap>, string, FSharpList<Tuple<string, string>>>>.Some(new Tuple<FSharpOption<Bitmap>, string, FSharpList<Tuple<string, string>>>(FSharpOption<Bitmap>.Some(bmp), barc, ListModule.Zip(FSharpList<string>.Cons("mark", FSharpList<string>.Cons("MarkBalka", FSharpList<string>.Cons("ColorCode", FSharpList<string>.Cons("SideBalka", FSharpList<string>.Cons("car", FSharpList<string>.Cons("strSteelCart", FSharpList<string>.Cons("PosGroup", FSharpList<string>.Cons("pp", FSharpList<string>.Cons("IsShtulp", FSharpList<string>.Cons("IsFalsh", FSharpList<string>.Empty)))))))))), ListModule.Tail(SeqModule.ToList(new EtiketParse_109_15(i, null, null, 0, null))))));
        }
        return null;
    }
    return null;
}

        
        public static void PrintStickerFromMnf(string path)
{
    FSharpOption<Tuple<FSharpOption<Bitmap>, string, FSharpList<Tuple<string, string>>>> fSharpOption = EtiketParse(path);
    FSharpOption<Tuple<FSharpOption<Bitmap>, string, FSharpList<Tuple<string, string>>>> fSharpOption2 = fSharpOption;
    FSharpOption<Tuple<FSharpOption<Bitmap>, string, FSharpList<Tuple<string, string>>>> fSharpOption3 = fSharpOption2;
    if (fSharpOption3 != null)
    {
        FSharpOption<Tuple<FSharpOption<Bitmap>, string, FSharpList<Tuple<string, string>>>> fSharpOption4 = fSharpOption3;
        if (fSharpOption4.Value.Item1 != null)
        {
            FSharpOption<Bitmap> item = fSharpOption4.Value.Item1;
            FSharpList<Tuple<string, string>> lst2 = fSharpOption4.Value.Item3;
            Bitmap bmp = item.Value;
            string barc2 = fSharpOption4.Value.Item2;
            using (MemoryStream stream = new MemoryStream(File.ReadAllBytes(Path.Combine(libPath, "stickerImp.xaml"))))
            {
                object obg = XamlReader.Load((Stream)stream);
                        Window win2 = (Window)obg;
                                //Window win2 = (Window)XamlReader.Load((Stream)stream);
                                Grid sticker2 = (Grid)win2.FindName("sticker");
                System.Windows.Controls.Image barcod2 = (System.Windows.Controls.Image)win2.FindName("barcod");
                System.Windows.Controls.Image imgWin = (System.Windows.Controls.Image)win2.FindName("imgWin");
                imgWin.Source = /*Bitmap.*/get_Source(bmp);
                ListModule.Iterate(new PrintStickerFromMnf_132_1(win2), lst2);
                BarcodeDraw brc2 = BarcodeDrawFactory.GetSymbology(BarcodeSymbology.Code128);
                barcod2.Source = /*Bitmap.*/get_Source((Bitmap)brc2.Draw(barc2, 30));
                PrintGrid(sticker2);
                Unit unit = null;
            }
        }
        else
        {
            FSharpList<Tuple<string, string>> lst = fSharpOption4.Value.Item3;
            string barc = fSharpOption4.Value.Item2;
            using (MemoryStream ms = new MemoryStream(File.ReadAllBytes(Path.Combine(libPath, "stickerBlk.xaml"))))
            {
                        object obg = XamlReader.Load((Stream)ms);
                        Window win = (Window)obg;
                        //Window win = (Window)XamlReader.Load((Stream)ms);
                        Grid sticker = (Grid)win.FindName("sticker");
                System.Windows.Controls.Image barcod = (System.Windows.Controls.Image)win.FindName("barcod");
                ListModule.Iterate(new PrintStickerFromMnf_121(win), lst);
                BarcodeDraw brc = BarcodeDrawFactory.GetSymbology(BarcodeSymbology.Code128);
                barcod.Source = /*Bitmap.*/get_Source((Bitmap)brc.Draw(barc, 30));
                PrintGrid(sticker);
                Unit unit2 = null;
            }
        }
    }
}
}

}