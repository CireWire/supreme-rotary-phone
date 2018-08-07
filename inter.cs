using System;

class MainClass 
{

  public interface IShape
  {
    void Draw();
  }

  class Circle: IShape
  {
    public void Draw()
    {
      Console.WriteLine("Draw Circle!");
    }
  }
  public static void Main (string[] args) {
    IShape c = new Circle();
    c.Draw();
  }
}
