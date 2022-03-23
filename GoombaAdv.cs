class GoombaAdv : Goomba
{
    
  public int checkNumber = 0;
    private string[] goombaSpriteLeftFoot;
    private string[] goombaSpriteRightFoot;
    

    public GoombaAdv(int speed) : base(speed)
    {
        goombaSpriteLeftFoot = new string[10];
        goombaSpriteRightFoot = new string[10];
        SetSprite();

    }


    public override void DrawSprite()
    {   


       checkNumber ++;
     string spaces="";


      for(int i=0; i<this.posX; i++){

          spaces+=" ";
          
      } 
    if(checkNumber/2==0 || checkNumber%2==1 ){

         foreach(string leftFoot in goombaSpriteLeftFoot){

        var left = spaces+leftFoot;

          Console.WriteLine(left);
       }

    } else

        foreach(string rightFoot in goombaSpriteRightFoot){
      
        var right = (spaces+rightFoot);
       
        Console.WriteLine(right);
      } 


    }

     private  void SetSprite()
    {  
goombaSpriteLeftFoot[0]= @"     ________  ";
goombaSpriteLeftFoot[1]= @"    /        \ ";
goombaSpriteLeftFoot[2]= @"   /  \    /  \ ";
goombaSpriteLeftFoot[3]= @"  /   |    |   \ ";
goombaSpriteLeftFoot[4]= @" /  -^------^-  \ ";
goombaSpriteLeftFoot[5]= @"|________________| ";
goombaSpriteLeftFoot[6]= @" ____ /    \ ";  
goombaSpriteLeftFoot[7]= @"/____\      |____ ";
goombaSpriteLeftFoot[8] =@"       ==== /____\ ";
goombaSpriteLeftFoot[9]= @"                     ";  



goombaSpriteRightFoot[0]= @"     ________  ";
goombaSpriteRightFoot[1]= @"    /        \ ";
goombaSpriteRightFoot[2]= @"   /  \    /  \ ";
goombaSpriteRightFoot[3]= @"  /   |    |   \ ";
goombaSpriteRightFoot[4]= @" /  -^------^-  \ ";
goombaSpriteRightFoot[5]= @"|________________| ";
goombaSpriteRightFoot[6]= @"      /    \ ____ ";
goombaSpriteRightFoot[7]= @" ____|      /____\ ";
goombaSpriteRightFoot[8]= @"/____\ ====         ";
goombaSpriteRightFoot[9]= @"                     ";



        
    }
}