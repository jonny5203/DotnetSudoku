using DotnetSudoku.Model;
using Microsoft.Maui.Layouts;
using StackLayout = Microsoft.Maui.Controls.Compatibility.StackLayout;

namespace DotnetSudoku;

public partial class MainPage : ContentPage
{
    internal Board _board;
    
    public MainPage()
    {
        InitializeComponent();

        _board = new Board();

        Console.WriteLine(_board.GetGroupByPosition(0, 0).GetCellStringValue(0,0));

        Grid mainGrid = new Grid
        {
            VerticalOptions = LayoutOptions.FillAndExpand,
            RowDefinitions =
            {
                new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
                new RowDefinition
                {
                    Height = new GridLength(1,
                        GridUnitType.Star)
                },
                new RowDefinition { Height = new GridLength(1, GridUnitType.Star) }
            },
            ColumnDefinitions =
            {
                new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                new ColumnDefinition
                {
                    Width = new GridLength(1, GridUnitType.Star)
                }
            }
        };

        // Create 3x3 inner grids
        for (int row = 0; row < 3; row++)
        {
            for (int col = 0; col < 3; col++)
            {
                Grid innerGrid = new Grid
                {
                    RowDefinitions =
                    {
                        new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
                        new RowDefinition
                        {
                            Height = new GridLength(1,
                                GridUnitType.Star)
                        },
                        new RowDefinition { Height = new GridLength(1, GridUnitType.Star) }
                    },
                    ColumnDefinitions =
                    {
                        new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                        new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                        new ColumnDefinition
                        {
                            Width = new GridLength(1, GridUnitType.Star)
                        }
                    }
                };

                Border border = new Border()
                {
                    Stroke = Colors.Blue,
                    StrokeThickness = 3,
                    Content = innerGrid
                };

                //Group currentGroup = _board.GetGroupByPosition(row, col);

                // Add buttons to the inner grid
                for (int innerRow = 0; innerRow < 3; innerRow++)
                {
                    for (int innerCol = 0; innerCol < 3; innerCol++)
                    {
                        Button button = new Button
                        {
                            Text = "1",//currentGroup.GetCellStringValue(innerRow, innerCol),
                            TextColor = Colors.White,
                            BackgroundColor = Colors.Transparent,
                            BorderColor = Colors.Black,
                            BorderWidth = 1,
                            HorizontalOptions = LayoutOptions.Fill,
                            VerticalOptions = LayoutOptions.Fill,
                            FontSize = 18 // Adjust font size as needed
                        };
                        innerGrid.Add(button, innerCol, innerRow);

                    }
                }
                
                // Add the inner grid to the main grid
                mainGrid.Add(border, col, row);
            }
        }

        ContentView content = new ContentView()
        {
            VerticalOptions = LayoutOptions.Center,
            HorizontalOptions = LayoutOptions.Center,
            Content = mainGrid
        };
        
        content.WidthRequest = 600;
        content.HeightRequest = 600;
        
        Content = content;

        /*var mainPage = Application.Current.MainPage;

        mainPage.Loaded += (s, e) =>
        {
            mainPage.Window.Width = mainFlexLayout.Width + mainFlexLayout.Margin.Left + mainFlexLayout.Margin.Right + 80; // Add extra width
            mainPage.Window.Height = mainFlexLayout.Height + mainFlexLayout.Margin.Top + mainFlexLayout.Margin.Bottom + 80; // Add extra height
        };*/
    }

    private void OnCellButtonClicked(object sender, EventArgs e)
    {
        Button button = (Button)sender;
        // Handle the button click event here (e.g., show a number picker)
    }
}