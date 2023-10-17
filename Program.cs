public class Progam
{
    
    static void Main()
    {
        
        // Console.WriteLine(Area(3));
        // Console.WriteLine(Area(3,2)); 
        // Console.WriteLine(Area(3,2,4)); 
        // Console.WriteLine(Area(3,2,4,5)); 

        // Console.WriteLine(Power(2,3));
        // Console.WriteLine(power(2));
        // Console.WriteLine(power(2,3));

        // prfloatInfo("Vugar");
        // prfloatInfo("Vugar","Samadov");
        // prfloatInfo("Vugar","Samadov","Vagif");
    }
    
    #region OverloadTasks
    static float Area(float radius)
    {
        float p = 3;
        return p * Power(radius,2);
    }

    static float Area(float sideA, float sideB)
    {
        return sideA * sideB;
    }

    static float Area(float sideA, float sideB, float sideC)
    {
        return 2 * (sideA * sideB + sideA * sideC + sideC * sideB);
    }

    static float Area(float sideA, float sideB, float sideC, float radius)
    {
        return perimeter(sideA,sideB,sideC)/2 * radius;
    }
    static float perimeter(float sideA, float sideB, float sideC)
    {
        return sideA + sideB + sideC;
    }

    static float Power(float basee, float exponent)
    {
        float result = basee;
        
        while (--exponent != 0)
            result *= basee;

        return result;
    }
    #endregion
    #region Sinifde yazdiqlarimiz
    
    static float power(float basee, float exponent = 2)
    {
        float result = basee;
        
        while (--exponent != 0)
            result *= basee;

        return result;
    }

    static void prfloatInfo(string name)
    {
        Console.WriteLine(name);
    }
    
    static void prfloatInfo(string name,string surname)
    {
        Console.WriteLine(surname,name);
    }
    
    static void prfloatInfo(string name,string surname, string fathersName)
    {
        Console.WriteLine(name[0]+"."+surname+" "+fathersName);
    }
    
    #endregion
}
