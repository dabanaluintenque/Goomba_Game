  // Exam Coding
class Hero{

    public virtual void PrintString(){

        Console.WriteLine("Here is the list of Heroes");
    }
}

class Mario : Hero 
{

    public override void PrintString()
    {
        Console.WriteLine("I am Mario!");
    }

 
}

 class Yoshi: Hero
 {

   public override void PrintString()
   {
       Console.WriteLine("I am Yoshi!");
   }
 }

