using task3_SOLID;

IBird penguin = new Penguin();
penguin.Say();

IBird sparrow = new Sparrow();
sparrow.Say();
if (sparrow is IFlyable flyableBird)
{
    flyableBird.Fly();
}