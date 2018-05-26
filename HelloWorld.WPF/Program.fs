open System
open System.Windows


[<STAThread>]
[<EntryPoint>]
let main _ =
    let app = XamlUtils.loadXaml<Application>("App.xaml")
    let mainWindow = new HelloWorld.WPF.MainWindow()
    app.Run(mainWindow)