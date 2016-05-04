using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace editor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool x;
        Point currentPoint = new Point();
        TextBox te;
        public MainWindow()
        {
            InitializeComponent();
            list.SelectedIndex = 0;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //pin
            cnv.EditingMode = InkCanvasEditingMode.Ink;
        }

        private void list_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //set color from listbox
            color(list.SelectedIndex);
        }

        void color(int i)
        {
            //pin color
            if (i == 0)
                cnv.DefaultDrawingAttributes.Color = Colors.Black;
            else if (i == 1)
                cnv.DefaultDrawingAttributes.Color = Colors.Blue;
            else if (i == 2)
                cnv.DefaultDrawingAttributes.Color = Colors.Red;
            else if (i == 3)
                cnv.DefaultDrawingAttributes.Color = Colors.Yellow;
            else if (i == 4)
                cnv.DefaultDrawingAttributes.Color = Colors.Green;
            else if (i == 5)
                cnv.DefaultDrawingAttributes.Color = Colors.Brown;
            else if (i == 6)
                cnv.DefaultDrawingAttributes.Color = Colors.White;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //normal mouse to change on mouse down
            cnv.EditingMode = InkCanvasEditingMode.None;
            x = false;
            ext = 1;
        }
        SolidColorBrush c;
        SolidColorBrush col(int se)
        {//colors for background
            if (se == 0)
            {
                c = new SolidColorBrush(Colors.Black);
            }
            else if (se == 1)
            {
                c = new SolidColorBrush(Colors.Blue);
            }
            else if (se == 2)
            {
                c = new SolidColorBrush(Colors.Red);
            }
            else if (se == 3)
            {
                c = new SolidColorBrush(Colors.Yellow);
            }
            else if (se == 4)
            {
                c = new SolidColorBrush(Colors.Green);
            }
            else if (se == 5)
            {
                c = new SolidColorBrush(Colors.Brown);
            }
            else if (se == 6)
            {
                c = new SolidColorBrush(Colors.White);
            }
            return c;
        }
        int ext;

        private void cnv_MouseDown(object sender, MouseButtonEventArgs e)
        {
            //change background
            if (ext == 1)
            {
                cnv.Background = col(list.SelectedIndex);
            }
            ////////////////////////////////////////////////
            if (ext==0)
            {
                //text ctrl
                if (e.ButtonState == MouseButtonState.Pressed)
                    currentPoint = e.GetPosition(cnv);
                te = new TextBox();
                te.Background = new SolidColorBrush(Colors.Transparent);
                te.BorderThickness = new Thickness(0);
                te.Margin = new Thickness(currentPoint.X, currentPoint.Y, 0, 0);
                te.SpellCheck.IsEnabled = true;
                te.AcceptsReturn = true;
                cnv.Children.Add(te);
                te.FontSize = 20;
                te.Foreground = col(list.SelectedIndex);
                Keyboard.Focus(te);
            }
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            //ruler for point by point
            cnv.EditingMode = InkCanvasEditingMode.EraseByPoint;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            //ruler for line
            cnv.EditingMode = InkCanvasEditingMode.EraseByStroke;
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            //select ctrl
            cnv.EditingMode = InkCanvasEditingMode.Select;
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            //new window
            cnv.Strokes.Clear();
            cnv.Background = new SolidColorBrush(Colors.White);
            cnv.Children.Clear();

        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            //copy
            cnv.CopySelection();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            //paste
            cnv.Paste();
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            //cut
            cnv.CutSelection();
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            //to in put text access from mouse down event
            x = true;
            ext = 0;
            cnv.EditingMode = InkCanvasEditingMode.None;
        }
        private void DrawToImage(FrameworkElement element)
        {
            // saveing canvas as image
            try { 
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif";
            save.Title = "Save the File";
            Nullable<bool> result = save.ShowDialog();
            StreamWriter write = new StreamWriter(File.Create(save.FileName));

            write.Dispose();

            element.Measure(new Size(double.PositiveInfinity, double.PositiveInfinity));
            element.Arrange(new Rect(element.DesiredSize));
            element.UpdateLayout();

            RenderTargetBitmap bitmap = new RenderTargetBitmap((int)element.Width, (int)element.Height,120
                                                               , 120, PixelFormats.Pbgra32);
            bitmap.Render(element);

            BitmapEncoder encoder = new PngBitmapEncoder();
            encoder.Frames.Add(BitmapFrame.Create(bitmap));

            using (Stream s = File.OpenWrite(save.FileName))
            {
                encoder.Save(s);
            }
            }
            catch { }
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {

            
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            // function of saving
            DrawToImage(cnv);
        }
        Ellipse mos;
        bool el;
        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            //draw ellipse
            el = false;
            ext = 3;
            mos = new Ellipse();
            mos.Width = 100;
            mos.Height = 100;
            cnv.Children.Add(mos);
            mos.Fill = col(list.SelectedIndex);
            cnv.EditingMode = InkCanvasEditingMode.None;
            mos.MouseDown += mos_MouseDown;
        }

        void mos_MouseDown(object sender, MouseButtonEventArgs e)
        {
            mos.Fill = col(list.SelectedIndex);
        }

        private void cnv_KeyDown(object sender, KeyEventArgs e)
        {
            // smple idea of undo text writting
            if (e.Key==Key.LeftCtrl && e.Key==Key.Z)
            {
                te.Undo();
            }
        }
        Rectangle r;
        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            //drawing rectangle
            el = true;
            ext = 3;
            r = new Rectangle();
            r.Width = 100;
            r.Height = 100;
            cnv.Children.Add(r);
            r.Fill = col(list.SelectedIndex);
            cnv.EditingMode = InkCanvasEditingMode.None;
            r.MouseDown += r_MouseDown;
        }

        void r_MouseDown(object sender, MouseButtonEventArgs e)
        {
            //fill rectangle
            r.Fill = col(list.SelectedIndex);
        }


        private void Window_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            // size changed when max and resize window
            cnv.Height = (int)gr.ActualHeight;
            cnv.Width = (int)gr.ActualWidth;
        }

        private void list_MouseEnter_1(object sender, MouseEventArgs e)
        {
        }

        private void list_MouseMove(object sender, MouseEventArgs e)
        {
        }

        private void ItemsControl_MouseEnter(object sender, MouseEventArgs e)
        {
            try
            {
                if(ext==0)
                te.Foreground = it1.Background;

                if(el==true)
                r.Fill = it1.Background;
                if (el == false)
                mos.Fill = it1.Background;
            }
            catch { }
        }

        private void ItemsControl_StylusEnter(object sender, StylusEventArgs e)
        {
        }

        private void ItemsControl_MouseEnter_1(object sender, MouseEventArgs e)
        {
            try
            {
                if (ext == 0)
                te.Foreground = it3.Background;

                if (el == false)
                mos.Fill = it3.Background;
                if (el == true)
                r.Fill = it3.Background;
            }
            catch { }
        }

        private void ItemsControl_MouseEnter_2(object sender, MouseEventArgs e)
        {
            try
            {
                if (ext == 0)
                te.Foreground = it4.Background;

                if (el == false)
                mos.Fill = it4.Background;
                if (el == true)
                r.Fill = it4.Background;
            }
            catch { }
        }

        private void ItemsControl_MouseEnter_3(object sender, MouseEventArgs e)
        {
            try
            {
                if (ext == 0)
                te.Foreground = it5.Background;

                if (el == false)
                mos.Fill = it5.Background;
                if (el == true)
                r.Fill = it5.Background;
            }
            catch { }
        }

        private void ItemsControl_MouseEnter_4(object sender, MouseEventArgs e)
        {
            try
            {
                if (ext == 0)
                te.Foreground = it6.Background;

                if (el == false)
                mos.Fill = it6.Background;
                if (el == true)
                r.Fill = it6.Background;
            }
            catch { }
        }

        private void ItemsControl_MouseEnter_5(object sender, MouseEventArgs e)
        {
            try
            {
                if (ext == 0)
                te.Foreground = it7.Background;

                if (el == false)
                mos.Fill = it7.Background;
                if (el == true)
                r.Fill = it7.Background;
            }
            catch { }
        }

        private void list_MouseLeave(object sender, MouseEventArgs e)
        {
            try
            {
                if (ext == 0)
                te.Foreground = col(list.SelectedIndex);

                if (el == false)
                mos.Fill = col(list.SelectedIndex);
                if (el == true)
                r.Fill = col(list.SelectedIndex);
            }
            catch { }
        }

        private void it2_MouseEnter(object sender, MouseEventArgs e)
        {
            try
            {
                if (ext == 0)
                te.Foreground = it2.Background;
                if (el == false)
                mos.Fill = it2.Background;
                if (el == true)
                r.Fill = it2.Background;
            }
            catch { }
        }

        private void Button_Click_14(object sender, RoutedEventArgs e)
        {
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                Nullable<bool> result = open.ShowDialog();
                open.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif";
                StreamReader read = new StreamReader(File.OpenRead(open.FileName));
                cnv.Strokes.Clear();
                cnv.Background = new SolidColorBrush(Colors.White);
                cnv.Children.Clear();
                Uri u = new Uri(open.FileName);
                ImageBrush b = new ImageBrush();
                b.ImageSource = new BitmapImage(u);
                cnv.Background = b;
                read.Dispose();
            }
            catch { }
        }
    }
}
