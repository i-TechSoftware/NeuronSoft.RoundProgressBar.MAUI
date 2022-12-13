# Round Progress Bar for MAUI
This repository contains a simple round progress bar for MAUI .NET 7

![](https://github.com/i-TechSoftware/NeuronSoft.RoundProgressBar.MAUI/blob/main/preview.png)

The following properties are available for customization:

| Property Name     | Property Type  | Min-Max     | Description                     |
| ----------------- | -------------- | ----------- | ------------------------------- |
| Progress          | double         | 0..100      | Percent progress                |
| ProgressColor     | Color          |             | Progress bar line color         |
| PathProgressColor | Color          |             | Underlay line color             |
| TextProgressColor | Color          |             | Inner text color                |
| ProgressSize      | int            | > 1         | Progress bar size               |
| FontSize          | double         |             | Inner text size                 |
| FontAttributes    | FontAttributes |             | Inner text font attribute       |
| FontFamily        | string         |             | Inner text font family          |
| ProgressFill      | Brush          |             | Brush to fill the inner circle  |
| TextIsVisible     | bool           | true..false | Visibility of inner text        |

                
Right now, some properties are hard-coded, such as the line thickness of the progress bar, but you can tweak that yourself. If you fix any bugs or add new functionality - feel free to create a new pull request

Usage example:

XAML
```
...
xmlns:maui="clr-namespace:NeuronSoft.RoundProgressBar.MAUI;assembly=NeuronSoft.RoundProgressBar.MAUI"
...
<maui:RoundProgressBar 
                x:Name="progressBar" 
                Progress="0" 
                ProgressColor="Red" 
                PathProgressColor="OrangeRed"
                TextProgressColor ="Black"
                ProgressSize="40"
                FontSize="18"
                FontAttributes="Bold"
                FontFamily="OswaldVariable"
                ProgressFill="White"
                />
```
C#
```
private async void OnCounterClicked(object sender, EventArgs e)
{
  for (double i = 1; i < 101; i++)
  {
    progressBar.Progress = i;
    await Task.Delay(100);
  }
}
```
