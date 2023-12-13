## Vektor Mathematik
- Drei float Attribute/Felder: x, y, z
```csharp
private float x, y, z;
```

- Standardkonstruktor in dem x, y, z auf 0 gesetzt werden 
```csharp
public Vector3D()
{
	x = y = z = 0;
}
```
- Einen Konstruktor in dem x, y, z mit Parametern initialisiert werden
```csharp
public Vector3D(float _x, float _y, float _z)
{
	x = _x;
	y = _y;
	z = _z;
}
```
- Addition Operator für die Addition mit einem anderen Vektor
```csharp
public static Vector3D operator + (Vector3D _vector1, Vector3D _vector2)
{
	return new Vector3D(_vector1.x + _vector2.x, _vector1.y + _vector2.y, _vector1.z + _vector2.z);
}
```
- Substraktion Operator für die Substraktion mit einem anderen Vektor
```csharp
public static Vector3D operator - (Vector3D _vector1, Vector3D _vector2)
{
	return new Vector3D(_vector1.x - _vector2.x, _vector1.y - _vector2.y, _vector1.z - _vector2.z);
}
```
- Multiplikation Operator für die Multiplikation mit einem Skalar (Zahl)
```csharp
public static Vector3D operator * (Vector3D _vector, float _scalar)
{
	return new Vector3D(_vector.x * _scalar, _vector.y * _scalar, _vector.z * _scalar);
}
```
- Methode die die Distanz zwischen zwei Vektoren/Punkten berechnet und als float zurückgeben. Implementiere diese Methode in einer statischen und nicht-statischen Version.
statisch
```csharp
public static float Distance(Vector3D _vector1, Vector3D _vector2)
{
	float distanceX = _vector1.x - _vector2.x;
	float distanceY = _vector1.y - _vector2.y;
	float distanceZ = _vector1.z - _vector2.z;
	
	return (float)Math.Sqrt(distanceX * distanceX + distanceY * distanceY + distanceZ * distanceZ);
}
```
nicht-statisch
```csharp
public float DistanceTo(Vector3D _other)
{
	float distanceX = x - _other.x;
	float distanceY = y - _other.y;
	float distanceZ = z - _other.z;
	
	return (float)Math.Sqrt(distanceX * distanceX + distanceY * distanceY + distanceZ * distanceZ);
    }
```
- Methode die die Länge eines Vektors berechnet und als float ausgibt.
```csharp
public float Length()
{
	return (float)Math.Sqrt(x * x + y * y + z * z);
}
```
- Methode die die Quadratlänge eines Vektors berechnet und als float ausgibt
```csharp
public float LengthSquared()
{
	return x * x + y * y + z * z;
}
```
