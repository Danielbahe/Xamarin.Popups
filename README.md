# Xamarin.Popups

Show alerts, widgets and popups from the viewmodel! 0 LINES OF CODE ON VIEWS

# Tested Platforms:
- Android
- UWP
- iOS

# Complatible With:
- Xamarin Forms
- MVVMCross framework (5.6.3)

# How to

## Xamarin normal 
ALERT! Remember to set the base class on initial tag and set all your content on the page layout.

```xaml
<poppable:PoppablePage xmlns="http://xamarin.com/schemas/2014/forms"
                    xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
                    x:Class="SampleProject.Views.SampleView"
                    xmlns:poppable="clr-namespace:Xamarin.Popups.Pages;assembly=Xamarin.Popups"
                    xmlns:views="clr-namespace:SampleProject.Views;assembly=SampleProject"
                    Title="Title">
		<poppable:PoppablePage.PageLayout> <!-- All the view elements inside or you will have errors-->
        <StackLayout>
            <Button Text="Miau" Command="{Binding ClickCommand}"/>
        </StackLayout>
		</poppable:PoppablePage.PageLayout>
</poppable:PoppablePage>
```
```c#
    public partial class SampleView : PoppablePage
      {
          public SampleView()
          {
              InitializeComponent();
          } 
      }
  ```
 The ViewModel just inherate from PoppableViewModel, nothing special
```c#
public class SampleViewModel : BaseViewModel
        {
            public ICommand ClickCommand { get; set; }
            public SampleViewModel()
            {
                ClickCommand = new Command(async () => await ExecuteClickCommand());
            }

            private void ExecuteClickedCommand()
            {
                this.ShowLoading();
            }
        }
```

## MVVMCROSS 
ALERT! Remember to set the base class on initial tag and set all your content on the page layout.
```xaml
  <poppable:MvxPoppablePage xmlns="http://xamarin.com/schemas/2014/forms"
                    xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
                    x:Class="SampleProject.Views.SampleView"
                    xmlns:mvx="clr-namespace:MvvmCross.Forms.Views;assembly=MvvmCross.Forms"
                    xmlns:poppable="clr-namespace:Xamarin.Popups.Pages;assembly=Xamarin.Popups"
                    xmlns:views="clr-namespace:SampleProject.Views;assembly=SampleProject"
                    Title="Title">

    		<poppable:MvxPoppablePage.PageLayout><!-- All the view elements inside or you will have errors-->
        		<StackLayout>
            		<Button Text="Miau" Command="{Binding ClickCommand}"/>
        		</StackLayout>
        </poppable:MvxPoppablePage.PageLayout>
    </poppable:MvxPoppablePage>
```
		
	
```c#
    public partial class SampleView : MvxPoppablePage
      {
          public SampleView()
          {
              InitializeComponent();
          } 
      }
			
```
 The ViewModel just inherate from MvxPoppableViewModel, nothing special
```c#
 public class SampleViewModel : MvxPoppableViewModel
        {
            public IMvxCommand ClickCommand { get; set; }
            public SampleViewModel()
            {
                ClickCommand = new MvxCommand(ExecuteClickCommand);
            }

            private void ExecuteClickCommand()
            {
                this.ShowLoading();
            }
        }
```
