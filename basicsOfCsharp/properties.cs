class Person
{
    internal string name;

     byte age;

    public byte Age 
    {
        get
        {
            return age;
        }

        set
        {
            if(value > 20 && value < 30)
            {
                age = value ;
            }
        }
    }
}