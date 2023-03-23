namespace System;

public class Cosine{
   public double degree {get;set;}
    public double radian => degree * (Math.PI/180);
    public double Cos => Math.Cos(radian);
}

public class Sine{
    public double degree {get;set;}
       public double radian => degree * (Math.PI/180);
    public double Sin => Math.Sin(radian);
}

public class Tangent{
    public double degree {get;set;}
       public double radian => degree * (Math.PI/180);
    public double Tan => Math.Tan(radian);
}

// public class SineFunctions{
//     public int Numbe { get; set; }
// }
