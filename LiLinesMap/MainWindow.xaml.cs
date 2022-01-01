using LiLinesMap.Controls;
using LiLinesMap.Lib;
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

namespace LiLinesMap
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Lib.Vector[] vectors = {
                new Lib.Vector(-1, +1, -1),
                new Lib.Vector(+1, +1, -1),
                new Lib.Vector(+1, -1, -1),
                new Lib.Vector(-1, -1, -1),
                new Lib.Vector(-1, +1, +1),
                new Lib.Vector(+1, +1, +1),
                new Lib.Vector(+1, -1, +1),
                new Lib.Vector(-1, -2, +1),
            };

            foreach (Lib.Vector item1 in vectors)
            {
                foreach (Lib.Vector item2 in vectors)
                {
                    Line3D _3DLine = new Line3D();
                    _3DLine.SetVector3D(
                        item1.Mul(35),
                        item2.Mul(35),
                        new Lib.Vector2((int)this.Width / 2, (int)this.Height / 2),
                        new Lib.Angle(30, 30, 30)

                        );
                    grid_d.Children.Add(_3DLine);

                }
                  
            }
           
            

            double x = 0;
            Lib.TimerTick timerTick = new Lib.TimerTick();
            timerTick.Time = 1;
            timerTick.Tick += (o, e) =>
            {
                foreach (Line3D line3d_ in grid_d.Children)
                {
                    line3d_.mat3Da.angle_to_screen = new Lib.Angle(x, 60, x);
                    line3d_.Update3D();
                }
               
                

                

                x += 0.1;
            };
            timerTick.Start();
        }
    }
}
