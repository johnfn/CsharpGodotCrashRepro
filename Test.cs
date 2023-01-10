using Godot;
using System;

interface IFoo {
  public void TestMethod() {
    GD.Print("Hello");
  }
}

public partial class Test : Node2D, IFoo {
  public override void _Ready() {
    TestMethod();
  }
  
  public void TestMethod() {
    (this as IFoo).TestMethod();
  }
}
