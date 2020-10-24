class Person
{
    string name;

     byte age=32;

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
    //auto implemented property
    public string Name{get; set;}
public string address{get;}//readonly property
}