using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Shapes
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public List<Point> points = new List<Point>();
        
        public List<Shape> list = new List<Shape>();
        public Point click { get; set; }

        public Shape shape;

        public int n = 0;

        public MainWindow()
        {
            InitializeComponent();
            cbShapes.ItemsSource = list;
            
        }

        private void Cswork_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (shape is Circle)
            {
                lblAddNewPoint.Content = "Kliknij,\naby dodać punkt";
                click = new Point(e.GetPosition(cswork).X, e.GetPosition(cswork).Y);
                points.Add(click);
                if (points.Count != 2) { return; }
                Draw();
                lblAddNewPoint.Content = "";
                points.Clear();
            }
            else if (shape is Triangle)
            {
                lblAddNewPoint.Content = "Kliknij,\naby dodać punkt";
                click = new Point(e.GetPosition(cswork).X, e.GetPosition(cswork).Y);
                points.Add(click);
                if (points.Count != 3) { return; }
                Draw();
                lblAddNewPoint.Content = "";
                points.Clear();
            }
            else if (shape is Quadrangle)
            {
                lblAddNewPoint.Content = "Kliknij,\naby dodać punkt";
                click = new Point(e.GetPosition(cswork).X, e.GetPosition(cswork).Y);
                points.Add(click);
                if (points.Count != 4) { return; }
                Draw();
                lblAddNewPoint.Content = "";
                points.Clear();
            }
            else if (shape is Sixthrangle)
            {
                lblAddNewPoint.Content = "Kliknij,\naby dodać punkt";
                click = new Point(e.GetPosition(cswork).X, e.GetPosition(cswork).Y);
                points.Add(click);
                if (points.Count != 6) { return; }
                Draw();
                lblAddNewPoint.Content = "";
                points.Clear();
            }
        }

        private void Draw()
        {
            
            if (shape is Circle circle)
            {
                circle.s = points[0];
                circle.k = points[1];
                double length = Math.Sqrt(Math.Pow((circle.s.X - circle.k.X), 2) + Math.Pow(circle.s.Y - circle.k.Y, 2));
                Ellipse el = new Ellipse();
                el.StrokeThickness = 5;
                el.Stroke = Brushes.Green;
                el.Width = length * 2;
                el.Height = length * 2;
                Canvas.SetTop(el, circle.s.Y - length);
                Canvas.SetLeft(el, circle.s.X - length);
                cswork.Children.Add(el);
                lblshowarea.Content = (int)circle.Area();
                lblshowrounding.Content = (int)circle.Rounding();
                n++;
                circle.number = n;
                list.Add(circle);
                cbShapes.Items.Refresh();
                

            } else if(shape is Triangle triangle)
            {
                triangle.p1 = points[0];
                triangle.p2 = points[1];
                triangle.p3 = points[2];
                Polygon tr = new Polygon();
                tr.StrokeThickness = 5;
                tr.Stroke = Brushes.Blue;
                List<Point> trpoints = new List<Point>()
                {
                    triangle.p1,triangle.p2,triangle.p3
                };
                tr.Points = new PointCollection(trpoints);
                cswork.Children.Add(tr);
                lblshowarea.Content = triangle.Area();
                lblshowrounding.Content = (int)triangle.Rounding();
                n++;
                triangle.number = n;
                list.Add(triangle);
                cbShapes.Items.Refresh();

            }
            else if(shape is Quadrangle quadrangle)
            {
                quadrangle.p1 = points[0];
                quadrangle.p2 = points[1];
                quadrangle.p3 = points[2];
                quadrangle.p4 = points[3];
                quadrangle.Sort();
                Polygon quad = new Polygon();
                quad.StrokeThickness = 5;
                quad.Stroke = Brushes.Red;
                quad.Points = new PointCollection(quadrangle.qpoints);
                cswork.Children.Add(quad);
                lblshowarea.Content =(int)quadrangle.Area();
                lblshowrounding.Content = (int)quadrangle.Rounding();
                n++;
                quadrangle.number = n;
                list.Add(quadrangle);
                cbShapes.Items.Refresh();

            }
            else if(shape is Sixthrangle sixthrangle)
            {
                sixthrangle.p1 = points[0];
                sixthrangle.p2 = points[1];
                sixthrangle.p3 = points[2];
                sixthrangle.p4 = points[3];
                sixthrangle.p5 = points[4];
                sixthrangle.p6 = points[5];
                sixthrangle.Sort();
                Polygon six = new Polygon();
                six.StrokeThickness = 5;
                six.Stroke = Brushes.Yellow;
                six.Points = new PointCollection(sixthrangle.spoints);
                cswork.Children.Add(six);
                lblshowarea.Content = (int)sixthrangle.Area();
                lblshowrounding.Content = (int)sixthrangle.Rounding();
                n++;
                sixthrangle.number = n;
                list.Add(sixthrangle);
                cbShapes.Items.Refresh();
            }
        }

    private void BtAddCircle_Click(object sender, RoutedEventArgs e)
        {
            cbShapes.SelectedIndex = -1;
            cswork.Children.Clear();
            shape = new Circle();
            lblAddNewPoint.Content = "Kliknij,\naby dodać środek";
        }

        private void BtAddTriangle_Click(object sender, RoutedEventArgs e)
        {
            cbShapes.SelectedIndex = -1;
            cswork.Children.Clear();
            shape = new Triangle();
            lblAddNewPoint.Content = "Kliknij,\naby dodać punkt";
        }

        private void BtAddQuadrangle_Click(object sender, RoutedEventArgs e)
        {
            cbShapes.SelectedIndex = -1;
            cswork.Children.Clear();
            shape = new Quadrangle();
            lblAddNewPoint.Content = "Kliknij,\naby dodać punkt";

        }

        private void BtAddOtherShape_Click(object sender, RoutedEventArgs e)
        {
            cbShapes.SelectedIndex = -1;
            cswork.Children.Clear();
            shape = new Sixthrangle();
            lblAddNewPoint.Content = "Kliknij,\naby dodać punkt";

        }

        private void BtDelete_Click(object sender, RoutedEventArgs e)
        {
            list.RemoveAt(cbShapes.SelectedIndex);
            cbShapes.Items.Refresh();
            cswork.Children.Clear();
            lblshowarea.Content = "";
            lblshowrounding.Content = "";
        }

        private void CbShapes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
            if(cbShapes.SelectedItem is Circle circle)
            {
                cswork.Children.Clear();
                points.Add(circle.s);
                points.Add(circle.k);
                double length = Math.Sqrt(Math.Pow((circle.s.X - circle.k.X), 2) + Math.Pow(circle.s.Y - circle.k.Y, 2));
                Ellipse el = new Ellipse();
                el.StrokeThickness = 5;
                el.Stroke = Brushes.Green;
                el.Width = length * 2;
                el.Height = length * 2;
                Canvas.SetTop(el, circle.s.Y - length);
                Canvas.SetLeft(el, circle.s.X - length);
                cswork.Children.Add(el);
                lblshowarea.Content = (int)circle.Area();
                lblshowrounding.Content = (int)circle.Rounding();
                cswork.Focus();
                points.Clear();
            }
            else if (cbShapes.SelectedItem is Triangle triangle)
            {
                cswork.Children.Clear();
                points.Add(triangle.p1);
                points.Add(triangle.p2);
                points.Add(triangle.p3);
                Polygon tr = new Polygon();
                tr.StrokeThickness = 5;
                tr.Stroke = Brushes.Blue;
                List<Point> trpoints = new List<Point>()
                {
                    triangle.p1,triangle.p2,triangle.p3
                };
                tr.Points = new PointCollection(trpoints);
                cswork.Children.Add(tr);
                lblshowarea.Content = triangle.Area();
                lblshowrounding.Content = (int)triangle.Rounding();
                cswork.Focus();
                points.Clear();
            } else if(cbShapes.SelectedItem is Quadrangle quadrangle)
            {
                cswork.Children.Clear();
                points.Add(quadrangle.p1);
                points.Add(quadrangle.p2);
                points.Add(quadrangle.p3);
                points.Add(quadrangle.p4);
                quadrangle.Sort();
                Polygon quad = new Polygon();
                quad.StrokeThickness = 5;
                quad.Stroke = Brushes.Red;
                quad.Points = new PointCollection(quadrangle.qpoints);
                cswork.Children.Add(quad);
                lblshowarea.Content = (int)quadrangle.Area();
                lblshowrounding.Content = (int)quadrangle.Rounding();
               
                cswork.Focus();
                points.Clear();
            }
            else if(cbShapes.SelectedItem is Sixthrangle sixthrangle)
            {
                cswork.Children.Clear();
                points.Add(sixthrangle.p1);
                points.Add(sixthrangle.p2);
                points.Add(sixthrangle.p3);
                points.Add(sixthrangle.p4);
                points.Add(sixthrangle.p5);
                points.Add(sixthrangle.p6);
                sixthrangle.Sort();
                Polygon six = new Polygon();
                six.StrokeThickness = 5;
                six.Stroke = Brushes.Yellow;
                six.Points = new PointCollection(sixthrangle.spoints);
                cswork.Children.Add(six);
                lblshowarea.Content = (int)sixthrangle.Area();
                lblshowrounding.Content = (int)sixthrangle.Rounding();
                cswork.Focus();
                points.Clear();
            } 
        }
    }
}
