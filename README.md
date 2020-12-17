# Walkthrough
What is Chester? It is an open source UI developed by ``Nino Nakano#0001`` and ready to build project.  
How do I get myself updated? You can join our discord by clicking [me.](https://discord.gg/Qwv73gBUZu)  

# Changelogs
- Added ThemeInterface  
```csharp
Manager.GetMain = JsonConvert.DeserializeObject<Data.Main>(File.ReadAllText("user-data.json"));
var Main = Manager.GetMain.MainWindow;

Data.ApplyBorder(Background, Main.Background);

//Note that ApplyThemes are currently disabled for upcoming image support.
```
