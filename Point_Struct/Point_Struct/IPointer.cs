namespace Point_Struct
{
    interface IPointer
    {
        double GetArea();
        double GetArea(IPointer secPoint);

        double GetPerimeter();
        double GetPerimeter(IPointer secPoint);

        double GetLenghth();
        double GetLenghth(IPointer secPoint);

        string GetType();
        bool TypeEquals(IPointer obj);
    }
}
