namespace Vector3D
{
    internal class Vector3D
    {
        private float x, y, z;
        private const float defaultCoordinateValue = 0f;
        private const float scalar = 2f;

        private static float distanceX, distanceY, distanceZ;
        private static float distance, distanceTo, length, lengthSquared;

        // Default constructor
        public Vector3D()
        {
            x = y = z = defaultCoordinateValue;
        }

        // Parameterized constructor
        public Vector3D(float _x, float _y, float _z)
        {
            x = _x; 
            y = _y;
            z = _z;
        }

        // Overloading the addition operator
        public static Vector3D operator +(Vector3D _vector1, Vector3D _vector2)
        {
            return new Vector3D(_vector1.x + _vector2.x, _vector1.y + _vector2.y, _vector1.z + _vector2.z);
        }

        // Overloading the subtraction operator
        public static Vector3D operator -(Vector3D _vector1, Vector3D _vector2)
        {
            return new Vector3D(_vector1.x - _vector2.x, _vector1.y - _vector2.y, _vector1.z - _vector2.z);
        }

        // Overloading the multiplication operator with scalar
        public static Vector3D operator *(Vector3D _vector, float _scalar)
        {
            return new Vector3D(_vector.x * _scalar, _vector.y * _scalar, _vector.z * _scalar);
        }

        // Method to calculate the distance between two vectors
        public static float Distance(Vector3D _vector1, Vector3D _vector2)
        {
            distanceX = _vector1.x - _vector2.x;
            distanceY = _vector1.y - _vector2.y;
            distanceZ = _vector1.z - _vector2.z;
            return (float)Math.Sqrt(distanceX * distanceX + distanceY * distanceY + distanceZ * distanceZ);
        }

        // Non-static method to calculate the distance from the current vector to another vector
        public float DistanceTo(Vector3D _other)
        {
            distanceX = x - _other.x;
            distanceY = y - _other.y;
            distanceZ = z - _other.z;
            return (float)Math.Sqrt(distanceX * distanceX + distanceY * distanceY + distanceZ * distanceZ);
        }

        // Method to calculate the length of the vector
        public float Length()
        {
            return (float)Math.Sqrt(x * x + y * y + z * z);
        }

        // Method to calculate the squared length of the vector
        public float LengthSquared()
        {
            return x * x + y * y + z * z;
        }

        static void Main(string[] args)
        {
            // Create two vectors
            Vector3D vector1 = new Vector3D(1, 2, 3);
            Vector3D vector2 = new Vector3D(4, 5, 6);

            // Example of using operators and methods
            Vector3D sum = vector1 + vector2;
            Vector3D difference = vector1 - vector2;
            Vector3D scaled = vector1 * scalar;

            distance = Vector3D.Distance(vector1, vector2);
            distanceTo = vector1.DistanceTo(vector2);

            length = vector1.Length();
            lengthSquared = vector1.LengthSquared();

            // Output the results to the console
            Console.WriteLine("Sum: " + sum.x + ", " + sum.y + ", " + sum.z);
            Console.WriteLine("Difference: " + difference.x + ", " + difference.y + ", " + difference.z);
            Console.WriteLine("Scaled: " + scaled.x + ", " + scaled.y + ", " + scaled.z);
            Console.WriteLine("Distance (Static): " + distance.ToString(format: "F2"));
            Console.WriteLine("Distance (Non-static): " + distanceTo.ToString(format: "F2"));
            Console.WriteLine("Length: " + length.ToString(format: "F2"));
            Console.WriteLine("LengthSquared: " + lengthSquared.ToString(format: "F2"));

            Console.ReadKey();
        }
    }
}
