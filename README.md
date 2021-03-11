# Walkthrough
What is Chester? It is an open source UI developed by ``Nino Nakano#0001`` and ready to build project.  
How do I get myself updated? You can join our discord by clicking [me.](https://discord.gg/Qwv73gBUZu)  

# Changelogs
- ThemeInterface↴  
```csharp
Manager.GetMain = JsonConvert.DeserializeObject<Data.Main>(File.ReadAllText("user-data.json"));
var Main = Manager.GetMain.MainWindow;

Data.ApplyBorder(Background, Main.Background);

//Note that ApplyThemes are currently disabled for upcoming image support.
```
- Registry Settings↴  
```csharp
this.Topmost = Settings.Instance.Topmost;
```
- Main UI
- Custom Styles
- Options UI

# To be added
- Unlock FPS
- Auto Attach
- Auto Execute
- Auto Refresh
- Prompt Clear
- Toggle ThemeInterface
- And more

# Important
I did not make the syntax highlighting but I found it somewhere in the internet, However I did modify it and added most of the keywords.

- Discontinued
