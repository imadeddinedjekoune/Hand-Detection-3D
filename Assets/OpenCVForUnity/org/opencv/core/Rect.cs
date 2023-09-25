using System;
using OpenCVForUnity.UnityUtils;

namespace OpenCVForUnity.CoreModule
{

    /**
     * <p>template<typename _Tp> class CV_EXPORTS Rect_ <code></p>
     *
     * <p>// C++ code:</p>
     *
     *
     * <p>public:</p>
     *
     * <p>typedef _Tp value_type;</p>
     *
     * <p>//! various constructors</p>
     *
     * <p>Rect_();</p>
     *
     * <p>Rect_(_Tp _x, _Tp _y, _Tp _width, _Tp _height);</p>
     *
     * <p>Rect_(const Rect_& r);</p>
     *
     * <p>Rect_(const CvRect& r);</p>
     *
     * <p>Rect_(const Point_<_Tp>& org, const Size_<_Tp>& sz);</p>
     *
     * <p>Rect_(const Point_<_Tp>& pt1, const Point_<_Tp>& pt2);</p>
     *
     * <p>Rect_& operator = (const Rect_& r);</p>
     *
     * <p>//! the top-left corner</p>
     *
     * <p>Point_<_Tp> tl() const;</p>
     *
     * <p>//! the bottom-right corner</p>
     *
     * <p>Point_<_Tp> br() const;</p>
     *
     * <p>//! size (width, height) of the rectangle</p>
     *
     * <p>Size_<_Tp> size() const;</p>
     *
     * <p>//! area (width*height) of the rectangle</p>
     *
     * <p>_Tp area() const;</p>
     *
     * <p>//! conversion to another data type</p>
     *
     * <p>template<typename _Tp2> operator Rect_<_Tp2>() const;</p>
     *
     * <p>//! conversion to the old-style CvRect</p>
     *
     * <p>operator CvRect() const;</p>
     *
     * <p>//! checks whether the rectangle contains the point</p>
     *
     * <p>bool contains(const Point_<_Tp>& pt) const;</p>
     *
     * <p>_Tp x, y, width, height; //< the top-left corner, as well as width and height
     * of the rectangle</p>
     *
     * <p>};</p>
     *
     * <p>Template class for 2D rectangles, described by the following parameters:
     * </code></p>
     * <ul>
     *   <li> Coordinates of the top-left corner. This is a default interpretation
     * of <code>Rect_.x</code> and <code>Rect_.y</code> in OpenCV. Though, in your
     * algorithms you may count <code>x</code> and <code>y</code> from the
     * bottom-left corner.
     *   <li> Rectangle width and height.
     * </ul>
     *
     * <p>OpenCV typically assumes that the top and left boundary of the rectangle are
     * inclusive, while the right and bottom boundaries are not. For example, the
     * method <code>Rect_.contains</code> returns <code>true</code> if</p>
     *
     * <p><em>x <= pt.x &lt x+width,&ltBR&gty <= pt.y &lt y+height</em></p>
     *
     * <p>Virtually every loop over an imageROI in OpenCV (where ROI is specified by
     * <code>Rect_<int></code>) is implemented as: <code></p>
     *
     * <p>// C++ code:</p>
     *
     * <p>for(int y = roi.y; y < roi.y + rect.height; y++)</p>
     *
     * <p>for(int x = roi.x; x < roi.x + rect.width; x++)</p>
     *
     *
     * <p>//...</p>
     *
     *
     * <p>In addition to the class members, the following operations on rectangles are
     * implemented: </code></p>
     * <ul>
     *   <li> <em>rect = rect +- point</em> (shifting a rectangle by a certain
     * offset)
     *   <li> <em>rect = rect +- size</em> (expanding or shrinking a rectangle by a
     * certain amount)
     *   <li> <code>rect += point, rect -= point, rect += size, rect -= size</code>
     * (augmenting operations)
     *   <li> <code>rect = rect1 & rect2</code> (rectangle intersection)
     *   <li> <code>rect = rect1 | rect2</code> (minimum area rectangle containing
     * <code>rect2</code> and <code>rect3</code>)
     *   <li> <code>rect &= rect1, rect |= rect1</code> (and the corresponding
     * augmenting operations)
     *   <li> <code>rect == rect1, rect != rect1</code> (rectangle comparison)
     * </ul>
     *
     * <p>This is an example how the partial ordering on rectangles can be established
     * (rect1<em>subseteq</em> rect2): <code></p>
     *
     * <p>// C++ code:</p>
     *
     * <p>template<typename _Tp> inline bool</p>
     *
     * <p>operator <= (const Rect_<_Tp>& r1, const Rect_<_Tp>& r2)</p>
     *
     *
     * <p>return (r1 & r2) == r1;</p>
     *
     *
     * <p>For your convenience, the <code>Rect_<></code> alias is available:</p>
     *
     * <p>typedef Rect_<int> Rect;</p>
     *
     * @see <a href="http://docs.opencv.org/modules/core/doc/basic_structures.html#rect">org.opencv.core.Rect_</a>
     */
    [System.Serializable]
    public class Rect : IEquatable<Rect>
    {

        public int x, y, width, height;

        public Rect(int x, int y, int width, int height)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
        }

        public Rect()
            : this(0, 0, 0, 0)
        {

        }

        public Rect(Point p1, Point p2)
        {
            x = (int)(p1.x < p2.x ? p1.x : p2.x);
            y = (int)(p1.y < p2.y ? p1.y : p2.y);
            width = (int)(p1.x > p2.x ? p1.x : p2.x) - x;
            height = (int)(p1.y > p2.y ? p1.y : p2.y) - y;
        }

        public Rect(Point p, Size s)
            : this((int)p.x, (int)p.y, (int)s.width, (int)s.height)
        {

        }

        public Rect(double[] vals)
        {
            set(vals);
        }

        public void set(double[] vals)
        {
            if (vals != null)
            {
                x = vals.Length > 0 ? (int)vals[0] : 0;
                y = vals.Length > 1 ? (int)vals[1] : 0;
                width = vals.Length > 2 ? (int)vals[2] : 0;
                height = vals.Length > 3 ? (int)vals[3] : 0;
            }
            else
            {
                x = 0;
                y = 0;
                width = 0;
                height = 0;
            }
        }

        public Rect clone()
        {
            return new Rect(x, y, width, height);
        }

        public Point tl()
        {
            return new Point(x, y);
        }

        public Point br()
        {
            return new Point(x + width, y + height);
        }

        public Size size()
        {
            return new Size(width, height);
        }

        public double area()
        {
            return width * height;
        }

        public bool empty()
        {
            return width <= 0 || height <= 0;
        }

        public bool contains(Point p)
        {
            return x <= p.x && p.x < x + width && y <= p.y && p.y < y + height;
        }

        //@Override
        public override int GetHashCode()
        {
            const int prime = 31;
            int result = 1;
            long temp;
            temp = BitConverter.DoubleToInt64Bits(height);
            result = prime * result + (int)(temp ^ (Utils.URShift(temp, 32)));
            temp = BitConverter.DoubleToInt64Bits(width);
            result = prime * result + (int)(temp ^ (Utils.URShift(temp, 32)));
            temp = BitConverter.DoubleToInt64Bits(x);
            result = prime * result + (int)(temp ^ (Utils.URShift(temp, 32)));
            temp = BitConverter.DoubleToInt64Bits(y);
            result = prime * result + (int)(temp ^ (Utils.URShift(temp, 32)));
            return result;
        }

        //@Override
        public override bool Equals(Object obj)
        {
            if (!(obj is Rect))
                return false;
            if ((Rect)obj == this)
                return true;

            Rect it = (Rect)obj;
            return x == it.x && y == it.y && width == it.width && height == it.height;
        }

        //@Override
        public override string ToString()
        {
            return "{" + x + ", " + y + ", " + width + "x" + height + "}";
        }

        //

        #region Operators

        // (here R stand for a rect ( Rect ), p for a point ( Point ), S for a size ( Size ).)

        #region Binary

        // R + p, R + S
        public static Rect operator +(Rect a, Point b)
        {
            return new Rect(a.x + (int)b.x, a.y + (int)b.y, a.width, a.height);
        }

        public static Rect operator +(Rect a, Size b)
        {
            return new Rect(a.x, a.y, a.width + (int)b.width, a.height + (int)b.height);
        }

        // R - p, R - S
        public static Rect operator -(Rect a, Point b)
        {
            return new Rect(a.x - (int)b.x, a.y - (int)b.y, a.width, a.height);
        }

        public static Rect operator -(Rect a, Size b)
        {
            return new Rect(a.x, a.y, a.width - (int)b.width, a.height - (int)b.height);
        }

        // R & R
        public static Rect operator &(Rect a, Rect b)
        {
            return intersect(a, b);
        }

        // R | R
        public static Rect operator |(Rect a, Rect b)
        {
            return union(a, b);
        }

        #endregion

        #region Comparison

        public bool Equals(Rect a)
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
            return this.x == a.x && this.y == a.y && this.width == a.width && this.height == a.height;
        }

        // R == R
        public static bool operator ==(Rect a, Rect b)
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
            return a.x == b.x && a.y == b.y && a.width == b.width && a.height == b.height;
        }

        // R != R
        public static bool operator !=(Rect a, Rect b)
        {
            return !(a == b);
        }

        #endregion

        #endregion

        public bool contains(int x, int y)
        {
            return this.x <= x && x < this.x + this.width && this.y <= y && y < this.y + this.height;
        }

        public bool contains(Rect rect)
        {
            return x <= rect.x &&
            (rect.x + rect.width) <= (x + width) &&
            y <= rect.y &&
            (rect.y + rect.height) <= (y + height);
        }

        public void inflate(int width, int height)
        {
            this.x -= width;
            this.y -= height;
            this.width += (2 * width);
            this.height += (2 * height);
        }

        public void inflate(Size size)
        {
            inflate((int)size.width, (int)size.height);
        }

        public static Rect inflate(Rect rect, int x, int y)
        {
            rect.inflate(x, y);
            return rect;
        }

        public static Rect intersect(Rect a, Rect b)
        {
            int x1 = Math.Max(a.x, b.x);
            int x2 = Math.Min(a.x + a.width, b.x + b.width);
            int y1 = Math.Max(a.y, b.y);
            int y2 = Math.Min(a.y + a.height, b.y + b.height);

            if (x2 >= x1 && y2 >= y1)
                return new Rect(x1, y1, x2 - x1, y2 - y1);
            return new Rect();
        }

        public Rect intersect(Rect rect)
        {
            return intersect(this, rect);
        }

        public bool intersectsWith(Rect rect)
        {
            return (
                (x < rect.x + rect.width) &&
                (x + width > rect.x) &&
                (y < rect.y + rect.height) &&
                (y + height > rect.y)
            );
        }

        public Rect union(Rect rect)
        {
            return union(this, rect);
        }

        public static Rect union(Rect a, Rect b)
        {
            int x1 = Math.Min(a.x, b.x);
            int x2 = Math.Max(a.x + a.width, b.x + b.width);
            int y1 = Math.Min(a.y, b.y);
            int y2 = Math.Max(a.y + a.height, b.y + b.height);

            return new Rect(x1, y1, x2 - x1, y2 - y1);
        }
        //
    }
}