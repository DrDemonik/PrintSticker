module FN
open System
open System.IO
open System.Text
open System.Text.RegularExpressions
open System.Reflection
open System.Linq
open System.Windows
open System.Windows.Controls
open System.Windows.Media
open Zen.Barcode
open System.Printing


let regEtik=new Regex("PP010,125:DIR1:AN1:FT\"Swiss 721 Bold BT\",18,00:PT\"(.*)\"\r"+
                        "PP010,090:DIR1:AN1:FT\"Swiss 721 BT\",10,00:PT\"(.*)\"\r"+
                        "PP010,062:DIR1:AN1:FT\"Swiss 721 BT\",10,00:PT\"(.*)\"\r"+
                        "PP010,034:DIR1:AN1:FT\"Swiss 721 BT\",10,00:PT\"(.*)\"\r"+
                        "PP010,006:DIR1:AN1:FT\"Swiss 721 BT\",10,00:PT\"(.*)\"\r"+
                        "PP065,010:AN1:DIR4:PL110,4\r"+
                        "PP085,080:DIR1:AN1:FT\"Swiss 721 BT\",13,00:PT\"(.*)\"\r"+
                        "PP185,080:DIR1:AN1:FT\"Swiss 721 BT\",13,00:PT\"(.*)\"\r"+
                        "PP085,032:DIR1:AN1:FT\"Swiss 721 BT\",13,00:PT\"(.*)\"\r"+
                        "PP215,032:DIR1:AN1:FT\"Swiss 721 BT\",13,00:PT\"(.*)\"\r"+
                        "PP330,032:DIR1:AN1:FT\"Swiss 721 BT\",13,00:PT\"(.*)\"\r"+
                        "PP525,080:DIR1:AN1:FT\"Swiss 721 BT\",12,00:PT\"(.*)\"\r"+
                        "PP085,000:DIR1:AN1:FT\"Swiss 721 BT\",08,00:PT\"(.*)\"\r"+
                        "PP500,032:DIR1:AN1:FT\"Swiss 721 BT\",09,00:PT\"(.*)\"\r")
let regImp=new Regex("PP010,120:DIR1:AN1:FT\"Swiss 721 Bold BT\",18,00:PT\"(.*)\"\r"+
                        "PP010,096:DIR1:AN1:FT\"Swiss 721 BT\",12,00:PT\"(.*)\"\r"+
                        "PP010,076:DIR1:AN1:FT\"Swiss 721 BT\",8,00:PT\"(.*)\"\r"+
                        "PP320,090:DIR1:AN1:FT\"Swiss 721 BT\",14,00:PT\"(.*)\"\r"+
                        "PP320,002:DIR1:AN1:FT\"Swiss 721 BT\",14,00:PT\"(.*)\"\r"+
                        "PP320,060:DIR1:AN1:FT\"Swiss 721 BT\",14,00:PT\"(.*)\"\r"+
                        "PP490,060:DIR1:AN1:FT\"Swiss 721 BT\",14,00:PT\"(.*)\"\r"+
                        "PP490,032:DIR1:AN1:FT\"Swiss 721 BT\",14,00:PT\"(.*)\"\r"+
                        "PP490,005:DIR1:AN1:FT\"Swiss 721 BT\",8,00:PT\"(.*)\"\r"+
                        "PP320,040:DIR1:AN1:FT\"Swiss 721 BT\",8,00:PT\"(.*)\"\r")
let regBar=new Regex(":PB\"(\d*)\"\:PF")
let regAbc=new Regex("PP(\d*),(\d*):DIR(\d):AN.:FT\"Swiss 721 BT\",(\d*),00:PT\"(.*?)\"")
let regLine=new Regex("PP(\d*),(\d*):AN1:DIR(\d):PL(\d*),(\d)")
let libPath=Assembly.GetExecutingAssembly().Location|>Path.GetDirectoryName

let enc=Encoding.GetEncoding(1251)

type Drawing.Bitmap with
    member ob.Source=
        System.Windows.Interop.Imaging.CreateBitmapSourceFromHBitmap(
            ob.GetHbitmap(), 
            IntPtr.Zero, 
            System.Windows.Int32Rect.Empty, 
            System.Windows.Media.Imaging.BitmapSizeOptions.FromWidthAndHeight(ob.Width,ob.Height))

let PrintGrid(grid:Grid)=
    let pd=new System.Windows.Controls.PrintDialog()
    pd.PrintQueue<-(new LocalPrintServer()).DefaultPrintQueue
    let size=new System.Windows.Size(pd.PrintableAreaWidth,pd.PrintableAreaHeight)
    grid.Measure(size)
    grid.Arrange(new System.Windows.Rect(new System.Windows.Point(0.0,0.0),size))
    (grid.Parent:?>Window).Show()|>ignore
    Threading.Thread.Sleep(1000)
    pd.PrintVisual(grid,"Sticker")

let EtiketParse path=
    let txt=File.ReadAllText(path,enc)
    regBar.Match(txt)|>function
        |m when m.Success->
            let barc=m.Groups.[1].Value
            regEtik.Match(txt)|>function
                |m when m.Success->
                    Some(None,barc,[for g in m.Groups->g.Value]|>List.tail
                            |>List.zip ["mark";"sht";"pp";"fn";"rh";"posgr";"sideAndSize";"strSteelCart";"car";"sp";"customername";"orderitemname";"mon_comm"])
                |_->regImp.Match(txt)|>function 
                    |m when m.Success->
                        //win image
                        let bmp=new Drawing.Bitmap(170,170)
                        let gr=Drawing.Graphics.FromImage(bmp)
                        let pen=new Drawing.Pen(Drawing.Color.Black,2.0f)
                        let penB=new Drawing.Pen(Drawing.Color.Black,4.0f)
                        //draw lines
                        [for m in regLine.Matches(txt)->m]
                            |>List.iter (fun m->
                                            let x1=int(m.Groups.[1].Value)-620
                                            let y1=170-(int(m.Groups.[2].Value)-5)
                                            let delta=int(m.Groups.[4].Value)
                                            let p=m.Groups.[5].Value|>function
                                                    |"4"->pen
                                                    |_->penB
                                            let x2,y2=
                                                m.Groups.[3].Value|>function
                                                    |"1"->x1+delta,y1
                                                    |"2"->x1,y1+delta
                                                    |"3"->x1-delta,y1
                                                    |_->x1,y1-delta
                                            gr.DrawLine(p,x1,y1,x2,y2))
                        //draw marking
                        [for m in regAbc.Matches(txt)->m.Groups]
                            |>List.filter (fun g->int(g.[1].Value)>619)
                            |>List.iter (fun g->let x1=float32(g.[1].Value)-620.0f-20.0f
                                                let y1=170.0f-(float32(g.[2].Value)-5.0f)
                                                let fnt=new Drawing.Font("consola",20.0f)
                                                let v=(g.[5].Value,g.[3].Value)|>function
                                                    |"V","1"->"V"
                                                    |"V","2"->"<"
                                                    |"V","3"->"^"
                                                    |"V","4"->">"
                                                    |x,_->x
                                                gr.DrawString(v,fnt,Drawing.Brushes.Black,new Drawing.PointF(x1,y1)))
                        Some(Some(bmp),barc,[for g in m.Groups->g.Value]|>List.tail
                                    |>List.zip ["mark";"MarkBalka";"ColorCode";"SideBalka";"car";"strSteelCart";"PosGroup";"pp";"IsShtulp";"IsFalsh"])
                    |_->None
        |_->None

let PrintStickerFromMnf(path)=
    path|>EtiketParse|>function
        |Some(None,barc,lst)-> //не импост
            use ms=new MemoryStream(File.ReadAllBytes(Path.Combine(libPath,"stickerBlk.xaml")))
            let win=Markup.XamlReader.Load(ms):?>Window
            let sticker=win.FindName("sticker"):?>Grid
            let barcod=win.FindName("barcod"):?>Image
            lst|>List.iter (fun (name,vl)->(win.FindName(name):?>TextBlock).Text<-vl)
            let brc=BarcodeDrawFactory.GetSymbology(BarcodeSymbology.Code128)
            barcod.Source<-(brc.Draw(barc,30):?>Drawing.Bitmap).Source
            PrintGrid sticker
        |Some(Some(bmp),barc,lst)->
            use ms=new MemoryStream(File.ReadAllBytes(Path.Combine(libPath,"stickerImp.xaml")))
            let win=Markup.XamlReader.Load(ms):?>Window
            let sticker=win.FindName("sticker"):?>Grid
            let barcod=win.FindName("barcod"):?>Image
            let imgWin=win.FindName("imgWin"):?>Image
            imgWin.Source<-bmp.Source
            lst|>List.iter (fun (name,vl)->(win.FindName(name):?>TextBlock).Text<-vl)
            let brc=BarcodeDrawFactory.GetSymbology(BarcodeSymbology.Code128)
            barcod.Source<-(brc.Draw(barc,30):?>Drawing.Bitmap).Source
            PrintGrid sticker
        |_->()