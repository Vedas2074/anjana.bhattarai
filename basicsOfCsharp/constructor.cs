namespace LearningClasses
{
    internal class Person
    {
        //Default parameterless constructor
        public Person()
        {
            
        }
        //parameterized constructor
    public Person(string n, string add)
    {
      this.Name = n;
     this.Address = add;
        this.Age= a;
     }
      public Person(string n, string add, byte a)
    {
      this.Name = n;
     this.Address = add;
        this.Age= a;
     }
   
    public int Name { get; set; }
    public int Address { get; set; }
     public int Age { get; set; }    
     }
}