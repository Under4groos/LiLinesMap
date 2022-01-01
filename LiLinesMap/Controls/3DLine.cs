using LiLinesMap.Lib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;

namespace LiLinesMap.Controls
{
    public struct Mat3Da
    {
        public Lib.Vector vector_pos_1;
        public Lib.Vector vector_pos_2;
        public Lib.Vector2 pos_to_screen;
        public Lib.Angle angle_to_screen;
        public override string ToString()
        {
            return $"V1: {vector_pos_1} V2: {vector_pos_2} V2: {pos_to_screen} A: {angle_to_screen} ";
        }
    }
    public class Line3D : Shape
    {

        public Vector2 startPoint
        {
            get;set;
        }
        public Vector2 endPoint
        {
            get;set;
        }

        public Mat3Da mat3Da;

        public void SetVector3D(Lib.Vector vector , Lib.Vector vector_2, Lib.Vector2 pos , Lib.Angle angle)
        {
            mat3Da.vector_pos_1 = vector;
            mat3Da.vector_pos_2 = vector_2;
            mat3Da.pos_to_screen = pos;


            startPoint = new Lib.Vector().ToScreen(vector, pos, angle);
            endPoint = new Lib.Vector().ToScreen(vector_2, pos, angle);

            Update();
        }
        public void Update3D()
        {
            SetVector3D(mat3Da.vector_pos_1, mat3Da.vector_pos_2, mat3Da.pos_to_screen, mat3Da.angle_to_screen);
        }
        private LineGeometry _lineGeometry;
        protected override Geometry DefiningGeometry => _lineGeometry;
        public Line3D()
        {

            _lineGeometry = new LineGeometry(startPoint.ToPoint(), endPoint.ToPoint());
            Stroke = Brushes.Red;
        }
        public void Update()
        {
            // _lineGeometry = new LineGeometry(startPoint.ToPoint(), endPoint.ToPoint());
            _lineGeometry.StartPoint = startPoint.ToPoint();
            _lineGeometry.EndPoint = endPoint.ToPoint();
        }
    }
}
