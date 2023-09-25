using System;
using OpenCVForUnity.UnityUtils;

namespace OpenCVForUnity.CoreModule
{

    /**
     * <p>template<typename _Tp> class CV_EXPORTS Point3_ <code></p>
     *
     * <p>// C++ code:</p>
     *
     *
     * <p>public:</p>
     *
     * <p>typedef _Tp value_type;</p>
     *
     * <p>// various constructors</p>
     *
     * <p>Point3_();</p>
     *
     * <p>Point3_(_Tp _x, _Tp _y, _Tp _z);</p>
     *
     * <p>Point3_(const Point3_& pt);</p>
     *
     * <p>explicit Point3_(const Point_<_Tp>& pt);</p>
     *
     * <p>Point3_(const CvPoint3D32f& pt);</p>
     *
     * <p>Point3_(const Vec<_Tp, 3>& v);</p>
     *
     * <p>Point3_& operator = (const Point3_& pt);</p>
     *
     * <p>//! conversion to another data type</p>
     *
     * <p>template<typename _Tp2> operator Point3_<_Tp2>() const;</p>
     *
     * <p>//! conversion to the old-style CvPoint...</p>
     *
     * <p>operator CvPoint3D32f() const;</p>
     *
     * <p>//! conversion to cv.Vec<></p>
     *
     * <p>operator Vec<_Tp, 3>() const;</p>
     *
     * <p>//! dot product</p>
     *
     * <p>_Tp dot(const Point3_& pt) const;</p>
     *
     * <p>//! dot product computed in double-precision arithmetics</p>
     *
     * <p>double ddot(const Point3_& pt) const;</p>
     *
     * <p>//! cross product of the 2 3D points</p>
     *
     * <p>Point3_ cross(const Point3_& pt) const;</p>
     *
     * <p>_Tp x, y, z; //< the point coordinates</p>
     *
     * <p>};</p>
     *
     * <p>Template class for 3D points specified by its coordinates </code></p>
     *
     * <p><em>x</em>, <em>y</em> and <em>z</em>.
     * An instance of the class is interchangeable with the C structure
     * <code>CvPoint2D32f</code>. Similarly to <code>Point_</code>, the coordinates
     * of 3D points can be converted to another type. The vector arithmetic and
     * comparison operations are also supported.
     * The following <code>Point3_<></code> aliases are available: <code></p>
     *
     * <p>// C++ code:</p>
     *
     * <p>typedef Point3_<int> Point3i;</p>
     *
     * <p>typedef Point3_<float> Point3f;</p>
     *
     * <p>typedef Point3_<double> Point3d;</p>
     *
     * @see <a href="http://docs.opencv.org/modules/core/doc/basic_structures.html#point3">org.opencv.core.Point3_</a>
     */
    [System.Serializable]
    public class Point3 : IEquatable<Point3>
    {

        public double x, y, z;

        public Point3(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public Point3()
            : this(0, 0, 0)
        {

        }

        public Point3(Point p)
        {
            x = p.x;
            y = p.y;
            z = 0;
        }

        public Point3(double[] vals)
            : this()
        {

            set(vals);
        }

        public void set(double[] vals)
        {
            if (vals != null)
            {
                x = vals.Length > 0 ? vals[0] : 0;
                y = vals.Length > 1 ? vals[1] : 0;
                z = vals.Length > 2 ? vals[2] : 0;
            }
            else
            {
                x = 0;
                y = 0;
                z = 0;
            }
        }

        public Point3 clone()
        {
            return new Point3(x, y, z);
        }

        public double dot(Point3 p)
        {
            return x * p.x + y * p.y + z * p.z;
        }

        public Point3 cross(Point3 p)
        {
            return new Point3(y * p.z - z * p.y, z * p.x - x * p.z, x * p.y - y * p.x);
        }

        //@Override
        public override int GetHashCode()
        {
            const int prime = 31;
            int result = 1;
            long temp;
            temp = BitConverter.DoubleToInt64Bits(x);
            result = prime * result + (int)(temp ^ (Utils.URShift(temp, 32)));
            temp = BitConverter.DoubleToInt64Bits(y);
            result = prime * result + (int)(temp ^ (Utils.URShift(temp, 32)));
            temp = BitConverter.DoubleToInt64Bits(z);
            result = prime * result + (int)(temp ^ (Utils.URShift(temp, 32)));
            return result;
        }

        //@Override
        public override bool Equals(Object obj)
        {
            if (!(obj is Point3))
                return false;
            if ((Point3)obj == this)
                return true;

            Point3 it = (Point3)obj;
            return x == it.x && y == it.y && z == it.z;
        }

        //@Override
        public override string ToString()
        {
            return "{" + x + ", " + y + ", " + z + "}";
        }

        //

        #region Operators

        // (here p stand for a point ( Point3 ), alpha for a real-valued scalar ( double ).)

        #region Unary

        // -p
        public static Point3 operator -(Point3 a)
        {
            return new Point3(-a.x, -a.y, -a.z);
        }

        #endregion

        #region Binary

        // p + p
        public static Point3 operator +(Point3 a, Point3 b)
        {
            return new Point3(a.x + b.x, a.y + b.y, a.z + b.z);
        }

        // p - p
        public static Point3 operator -(Point3 a, Point3 b)
        {
            return new Point3(a.x - b.x, a.y - b.y, a.z - b.z);
        }

        // p * alpha, alpha * p
        public static Point3 operator *(Point3 a, double b)
        {
            return new Point3(a.x * b, a.y * b, a.z * b);
        }

        public static Point3 operator *(double a, Point3 b)
        {
            return new Point3(b.x * a, b.y * a, b.z * a);
        }

        // p / alpha
        public static Point3 operator /(Point3 a, double b)
        {
            return new Point3(a.x / b, a.y / b, a.z / b);
        }

        #endregion

        #region Comparison

        public bool Equals(Point3 a)
        {
            // If both are same instance, return true.
            if (System.Object.ReferenceEquals(this, a))
            {
                return true;
            }

            // If object is null, return false.
            if ((object)a == null)
            {
                return false;
            }

            // Return true if the fields match:
            return this.x == a.x && this.y == a.y && this.z == a.z;
        }

        // p == p
        public static bool operator ==(Point3 a, Point3 b)
        {
            // If both are null, or both are same instance, return true.
            if (System.Object.ReferenceEquals(a, b))
            {
                return true;
            }

            // If one is null, but not both, return false.
            if (((object)a == null) || ((object)b == null))
            {
                return false;
            }

            // Return true if the fields match:
            return a.x == b.x && a.y == b.y && a.z == b.z;
        }

        // p != p
        public static bool operator !=(Point3 a, Point3 b)
        {
            return !(a == b);
        }

        #endregion

        #endregion

        //
    }
}
