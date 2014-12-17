using AbstractCoffeeMaker;

namespace M4CoffeeMaker
{
  public class M4CoffeeMaker
  {
    public static void Main(string[] args)
    {
      CoffeeMakerAPI api = new M4CoffeeMakerApi();
      M4UserInterface ui = new M4UserInterface(api);
      M4HotWaterSource hws = new M4HotWaterSource(api);
      M4ContainmentVessel cv = new M4ContainmentVessel(api);

      ui.Init(hws, cv);
      hws.Init(ui, cv);
      cv.Init(ui, hws);

      while (true)
      {
        ui.Poll();
        hws.Poll();
        cv.Poll();
      }
    }
  }
}
