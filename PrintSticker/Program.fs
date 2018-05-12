open System

[<STAThread>]
[<EntryPoint>]
let main argv = 
    argv|>function
        |[|path|]->path|>FN.PrintStickerFromMnf
        |_->()
    0 // return an integer exit code
