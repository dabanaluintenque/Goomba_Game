// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
/*
Star star = new Star(10);

 star.DrawSprite();

 Ground ground = new Ground(50);
 ground.DrawSprite();  */

/*

Star star = new Star(4);
 Goomba goomba = new Goomba(4);

 Ground ground = new Ground(120);

 GoombaWalk gWalk = new GoombaWalk(star, goomba,ground);

 gWalk.StartAnimation();

 

 ParaGoomba pGoomba = new ParaGoomba(4);

 pGoomba.DrawSprite(); */




Star star = new Star(4);
 Goomba goomba = new Goomba(4);

// Ground ground = new Ground(4);

 ParaGoomba pGoomba = new ParaGoomba(4);

 Ground ground = new Ground(120);
 GoombaWalk gWalk = new GoombaWalk(star, pGoomba,ground);
 Console.Clear();
 gWalk.StartAnimation();


 

 

