using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

<Style TargetType = "{x:Type Button}" >
    <Setter Property="Background" Value="#373737" />
    <Setter Property = "Foreground" Value="White" />
    <Setter Property = "FontSize" Value="15" />
    <Setter Property = "SnapsToDevicePixels" Value="True" />

    <Setter Property = "Template" >
        < Setter.Value >
            < ControlTemplate TargetType="{x:Type Button}">
                <Border CornerRadius = "4" Background="{TemplateBinding Background}">
                    <Grid>
                        <Path x:Name="PathIcon" Width="360" Height="60" Stretch="Fill" Fill="#4C87B3" HorizontalAlignment="Left" Margin="17,0,0,0" Data="F1 M 30.0833,22.1667L 50.6665,37.6043L 50.6665,38.7918L 30.0833,53.8333L 30.0833,22.1667 Z "/>
                        <ContentPresenter x:Name="MyContentPresenter" Content="{TemplateBinding Content}" HorizontalAlignment="Center" VerticalAlignment="Center" Margin="0,0,0,0" />                                
                    </Grid>
                </Border>

                <ControlTemplate.Triggers>
                    <Trigger Property = "IsMouseOver" Value="True">
                        <Setter Property = "Background" Value="#E59400" />
                        <Setter Property = "Foreground" Value="White" />
                        <Setter TargetName = "PathIcon" Property="Fill" Value="Black" />
                    </Trigger>

                    <Trigger Property = "IsPressed" Value="True">
                        <Setter Property = "Background" Value="OrangeRed" />
                        <Setter Property = "Foreground" Value="White" />
                    </Trigger>
                </ControlTemplate.Triggers>
            </ControlTemplate>
        </Setter.Value>
    </Setter>
</Style>

namespace InstallScreen
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        /// Open StartScreen
        private void btnInstall_Click(object sender, RoutedEventArgs e)
        {

        }

        /// Closes Application
        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }
    }
}
