namespace InterfaceSegregation;

interface IComparable
{
    bool GraterThan(IComparable right);
    bool GraterOrEqualThan(IComparable right);
    bool LessOrEqualThan(IComparable right);
    bool LessThan(IComparable right);

}

interface IEquatable {
    bool Equal(IComparable right);
}

class Number : IEquatable
{
    public bool Equal(IComparable right){ return true;}
}